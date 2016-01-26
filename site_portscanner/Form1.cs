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

namespace site_portscanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            for (int i = portStart; i <= portKoniec; i++)
            {
                try
                {
                    gniazdo.Connect(new IPEndPoint(adresHosta.Address, i));
                    lbListaPortow.Items.Add(i.ToString());
                }
                catch
                {

                }
            }
            tslStatus.Text = "Skanowanie zakończone";
        }
    }
}
