namespace site_portscanner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdresIP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListaPortow = new System.Windows.Forms.ListBox();
            this.txtPortK = new System.Windows.Forms.TextBox();
            this.txtPortS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSkanuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(152, 11);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(289, 20);
            this.txtAdres.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Podaj adres serwisu:";
            // 
            // lblAdresIP
            // 
            this.lblAdresIP.AutoSize = true;
            this.lblAdresIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresIP.Location = new System.Drawing.Point(16, 28);
            this.lblAdresIP.Name = "lblAdresIP";
            this.lblAdresIP.Size = new System.Drawing.Size(59, 13);
            this.lblAdresIP.TabIndex = 2;
            this.lblAdresIP.Text = "Adres IP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbListaPortow);
            this.groupBox1.Controls.Add(this.lblAdresIP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(21, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 247);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki skanowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otwarte porty: ";
            // 
            // lbListaPortow
            // 
            this.lbListaPortow.FormattingEnabled = true;
            this.lbListaPortow.Location = new System.Drawing.Point(19, 89);
            this.lbListaPortow.Name = "lbListaPortow";
            this.lbListaPortow.Size = new System.Drawing.Size(374, 134);
            this.lbListaPortow.TabIndex = 3;
            // 
            // txtPortK
            // 
            this.txtPortK.Location = new System.Drawing.Point(336, 48);
            this.txtPortK.Name = "txtPortK";
            this.txtPortK.Size = new System.Drawing.Size(91, 20);
            this.txtPortK.TabIndex = 22;
            // 
            // txtPortS
            // 
            this.txtPortS.Location = new System.Drawing.Point(133, 48);
            this.txtPortS.Name = "txtPortS";
            this.txtPortS.Size = new System.Drawing.Size(91, 20);
            this.txtPortS.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(242, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Port końcowy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port początkowy:";
            // 
            // btnSkanuj
            // 
            this.btnSkanuj.Location = new System.Drawing.Point(25, 93);
            this.btnSkanuj.Name = "btnSkanuj";
            this.btnSkanuj.Size = new System.Drawing.Size(204, 23);
            this.btnSkanuj.TabIndex = 24;
            this.btnSkanuj.Text = "Skanuj";
            this.btnSkanuj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 419);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPortK);
            this.Controls.Add(this.txtPortS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSkanuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdresIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbListaPortow;
        private System.Windows.Forms.TextBox txtPortK;
        private System.Windows.Forms.TextBox txtPortS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSkanuj;
    }
}

