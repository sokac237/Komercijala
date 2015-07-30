namespace blokerX
{
    partial class frmAzurirajAkcijskiNabavniCjenik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajAkcijskiNabavniCjenik));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbAktivan = new System.Windows.Forms.CheckBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpDokada = new System.Windows.Forms.DateTimePicker();
            this.dtpOdKada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPartnerNaziv = new System.Windows.Forms.Label();
            this.txtPartnerSifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbDiskont = new System.Windows.Forms.CheckBox();
            this.ckbTrgovina = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(105, 12);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.ReadOnly = true;
            this.txtBroj.Size = new System.Drawing.Size(100, 20);
            this.txtBroj.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBroj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 36);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbTrgovina);
            this.panel2.Controls.Add(this.ckbDiskont);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ckbAktivan);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnSpremi);
            this.panel2.Controls.Add(this.dtpDokada);
            this.panel2.Controls.Add(this.dtpOdKada);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblPartnerNaziv);
            this.panel2.Controls.Add(this.txtPartnerSifra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOpis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 244);
            this.panel2.TabIndex = 34;
            // 
            // ckbAktivan
            // 
            this.ckbAktivan.AutoSize = true;
            this.ckbAktivan.Checked = true;
            this.ckbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAktivan.Location = new System.Drawing.Point(108, 190);
            this.ckbAktivan.Name = "ckbAktivan";
            this.ckbAktivan.Size = new System.Drawing.Size(62, 17);
            this.ckbAktivan.TabIndex = 6;
            this.ckbAktivan.Text = "Aktivan";
            this.ckbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(405, 209);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(324, 209);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dtpDokada
            // 
            this.dtpDokada.Location = new System.Drawing.Point(105, 116);
            this.dtpDokada.Name = "dtpDokada";
            this.dtpDokada.Size = new System.Drawing.Size(129, 20);
            this.dtpDokada.TabIndex = 5;
            this.dtpDokada.Leave += new System.EventHandler(this.dtpDokada_Leave);
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.Location = new System.Drawing.Point(105, 80);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(129, 20);
            this.dtpOdKada.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Do kada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Od kada:";
            // 
            // lblPartnerNaziv
            // 
            this.lblPartnerNaziv.AutoSize = true;
            this.lblPartnerNaziv.Location = new System.Drawing.Point(176, 48);
            this.lblPartnerNaziv.Name = "lblPartnerNaziv";
            this.lblPartnerNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblPartnerNaziv.TabIndex = 37;
            this.lblPartnerNaziv.Text = "___";
            // 
            // txtPartnerSifra
            // 
            this.txtPartnerSifra.Location = new System.Drawing.Point(105, 45);
            this.txtPartnerSifra.MaxLength = 10;
            this.txtPartnerSifra.Name = "txtPartnerSifra";
            this.txtPartnerSifra.Size = new System.Drawing.Size(65, 20);
            this.txtPartnerSifra.TabIndex = 3;
            this.txtPartnerSifra.TextChanged += new System.EventHandler(this.txtPartnerSifra_TextChanged);
            this.txtPartnerSifra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartnerSifra_KeyPress);
            this.txtPartnerSifra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPartnerSifra_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dobavljač:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(105, 14);
            this.txtOpis.MaxLength = 30;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(193, 20);
            this.txtOpis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Opis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Artikl u \r\nkatalogu za:";
            // 
            // ckbDiskont
            // 
            this.ckbDiskont.AutoSize = true;
            this.ckbDiskont.Location = new System.Drawing.Point(109, 160);
            this.ckbDiskont.Name = "ckbDiskont";
            this.ckbDiskont.Size = new System.Drawing.Size(68, 17);
            this.ckbDiskont.TabIndex = 41;
            this.ckbDiskont.Text = "Diskonte";
            this.ckbDiskont.UseVisualStyleBackColor = true;
            this.ckbDiskont.CheckedChanged += new System.EventHandler(this.ckbDiskont_CheckedChanged);
            // 
            // ckbTrgovina
            // 
            this.ckbTrgovina.AutoSize = true;
            this.ckbTrgovina.Location = new System.Drawing.Point(183, 160);
            this.ckbTrgovina.Name = "ckbTrgovina";
            this.ckbTrgovina.Size = new System.Drawing.Size(68, 17);
            this.ckbTrgovina.TabIndex = 42;
            this.ckbTrgovina.Text = "Trgovine";
            this.ckbTrgovina.UseVisualStyleBackColor = true;
            this.ckbTrgovina.CheckedChanged += new System.EventHandler(this.ckbTrgovina_CheckedChanged);
            // 
            // frmAzurirajAkcijskiNabavniCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajAkcijskiNabavniCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj akcijski nabavni cjenik";
            this.Deactivate += new System.EventHandler(this.frmAzurirajAkcijskiNabavniCjenik_Deactivate);
            this.Load += new System.EventHandler(this.frmAzurirajAkcijskiNabavniCjenik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajAkcijskiNabavniCjenik_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DateTimePicker dtpDokada;
        private System.Windows.Forms.DateTimePicker dtpOdKada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPartnerNaziv;
        private System.Windows.Forms.TextBox txtPartnerSifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbAktivan;
        private System.Windows.Forms.CheckBox ckbTrgovina;
        private System.Windows.Forms.CheckBox ckbDiskont;
        private System.Windows.Forms.Label label6;
    }
}