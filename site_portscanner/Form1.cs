using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace site_portscanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int PortKoncowy { get; set; }


        private void btnSkanuj_Click(object sender, EventArgs e)
        {
            IPAddress adresHosta = null;
            int portStart = 0;
            int portKoniec = 0;

            lbListaPortow.Items.Clear();
            lblAdresIP.Text = "";
            tslStatus.Text = "";

            try
            {
                adresHosta = Dns.GetHostEntry(txtAdres.Text).AddressList[0];
                portStart = Int16.Parse(txtPortS.Text);
                portKoniec = Int16.Parse(txtPortK.Text);
                this.PortKoncowy = portKoniec;

                if (portStart < 0 || portStart > Int16.MaxValue || portStart > portKoniec || portKoniec > Int16.MaxValue)
                {
                    throw new Exception("Niepoprawne numery portów");
                }
                lblAdresIP.Text = adresHosta.ToString();
                tslStatus.Text = "Trwa skanowanie ...";
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Podano niepoprawną nazwę hosta");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Socket gniazdo = new Socket(adresHosta.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Thread watek = null;
            for (int i = portStart; i <= portKoniec; i += 25)
            {
                watek = new Thread(new ParameterizedThreadStart(skanowanie));
                watek.Start(new DaneSkan() { Gniazdo = gniazdo, ZdalnyHost = new IPEndPoint(adresHosta.Address, i) });
            }
            //watek.Join();
            //tslStatus.Text = "Skanowanie zakończone";
        }


        public void skanowanie(object par)
        {
            Socket gniazdo = ((DaneSkan)par).Gniazdo;
            IPEndPoint zdalnyHost = ((DaneSkan)par).ZdalnyHost;
            int nrPortu = zdalnyHost.Port;

            for (int i = nrPortu; i < nrPortu + 25; i++)
            {
                try
                {
                    gniazdo = new Socket(zdalnyHost.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    zdalnyHost = new IPEndPoint(zdalnyHost.Address, i);
                    gniazdo.Connect(zdalnyHost);
                    gniazdo.Close();
                    this.BeginInvoke(new WynikDelegacja(wypiszWynik), i);
                }
                catch (SocketException ex)
                {
                    // Console.WriteLine("brak połączenia na porcie: " + port.Port);
                    if (i == this.PortKoncowy)
                        tslStatus.Text = "Skanowanie zakończone";
                }
                finally
                {
                    // gniazdo.Dispose();
                    // port = null;
                }
            }
        }
        public void wypiszWynik(int port)
        {
            lbListaPortow.Items.Add(port);
            if (port == this.PortKoncowy)
                tslStatus.Text = "Skanowanie zakończone";
        }

        public delegate void WynikDelegacja(int port);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

    }

    class DaneSkan
    {
        public Socket Gniazdo { get; set; }
        public IPEndPoint ZdalnyHost { get; set; }
    }
}
