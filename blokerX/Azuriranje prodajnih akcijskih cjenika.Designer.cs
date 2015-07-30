namespace blokerX
{
    partial class frmAzurirajProdajniAkcijskiCjenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajProdajniAkcijskiCjenik));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOdKada = new System.Windows.Forms.DateTimePicker();
            this.dtpDoKada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbNivo = new System.Windows.Forms.ComboBox();
            this.ckbAktivna = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPartnerSifra = new System.Windows.Forms.TextBox();
            this.lblPartnerNaziv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIzmjenaDatum = new System.Windows.Forms.TextBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(105, 19);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.ReadOnly = true;
            this.txtBroj.Size = new System.Drawing.Size(65, 20);
            this.txtBroj.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Od kada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do kada:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(105, 52);
            this.txtNaziv.MaxLength = 30;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(271, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Naziv:";
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.Location = new System.Drawing.Point(105, 113);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(112, 20);
            this.dtpOdKada.TabIndex = 3;
            // 
            // dtpDoKada
            // 
            this.dtpDoKada.Location = new System.Drawing.Point(105, 143);
            this.dtpDoKada.Name = "dtpDoKada";
            this.dtpDoKada.Size = new System.Drawing.Size(112, 20);
            this.dtpDoKada.TabIndex = 4;
            this.dtpDoKada.Leave += new System.EventHandler(this.dtpDoKada_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "(maloprodajne cijene)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "(maloprodajne cijene)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Aktivna:";
            // 
            // ckbNivo
            // 
            this.ckbNivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckbNivo.FormattingEnabled = true;
            this.ckbNivo.Items.AddRange(new object[] {
            "2",
            "3"});
            this.ckbNivo.Location = new System.Drawing.Point(105, 174);
            this.ckbNivo.Name = "ckbNivo";
            this.ckbNivo.Size = new System.Drawing.Size(50, 21);
            this.ckbNivo.TabIndex = 5;
            // 
            // ckbAktivna
            // 
            this.ckbAktivna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckbAktivna.FormattingEnabled = true;
            this.ckbAktivna.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.ckbAktivna.Location = new System.Drawing.Point(105, 207);
            this.ckbAktivna.Name = "ckbAktivna";
            this.ckbAktivna.Size = new System.Drawing.Size(50, 21);
            this.ckbAktivna.TabIndex = 6;
            this.ckbAktivna.SelectedIndexChanged += new System.EventHandler(this.ckbAktivna_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(172, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "1 - najmanji, 2- srednji, 3 - najviši prioritet";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(335, 288);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(416, 288);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 8;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Partner:";
            // 
            // txtPartnerSifra
            // 
            this.txtPartnerSifra.Location = new System.Drawing.Point(105, 82);
            this.txtPartnerSifra.MaxLength = 11;
            this.txtPartnerSifra.Name = "txtPartnerSifra";
            this.txtPartnerSifra.Size = new System.Drawing.Size(65, 20);
            this.txtPartnerSifra.TabIndex = 2;
            this.txtPartnerSifra.TextChanged += new System.EventHandler(this.txtPartnerSifra_TextChanged);
            this.txtPartnerSifra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartnerSifra_KeyPress);
            this.txtPartnerSifra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPartnerSifra_KeyUp);
            // 
            // lblPartnerNaziv
            // 
            this.lblPartnerNaziv.AutoSize = true;
            this.lblPartnerNaziv.Location = new System.Drawing.Point(176, 85);
            this.lblPartnerNaziv.Name = "lblPartnerNaziv";
            this.lblPartnerNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblPartnerNaziv.TabIndex = 20;
            this.lblPartnerNaziv.Text = "___";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zadnja izmjena:";
            // 
            // txtIzmjenaDatum
            // 
            this.txtIzmjenaDatum.Location = new System.Drawing.Point(105, 243);
            this.txtIzmjenaDatum.Name = "txtIzmjenaDatum";
            this.txtIzmjenaDatum.ReadOnly = true;
            this.txtIzmjenaDatum.Size = new System.Drawing.Size(271, 20);
            this.txtIzmjenaDatum.TabIndex = 22;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.BackColor = System.Drawing.Color.Green;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoruka.ForeColor = System.Drawing.Color.Yellow;
            this.lblPoruka.Location = new System.Drawing.Point(172, 207);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 23;
            // 
            // frmAzurirajProdajniAkcijskiCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 323);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.txtIzmjenaDatum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPartnerNaziv);
            this.Controls.Add(this.txtPartnerSifra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckbAktivna);
            this.Controls.Add(this.ckbNivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDoKada);
            this.Controls.Add(this.dtpOdKada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajProdajniAkcijskiCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje prodajnih akcijskih cjenika";
            this.Deactivate += new System.EventHandler(this.frmAzurirajProdajniAkcijskiCjenik_Deactivate);
            this.Load += new System.EventHandler(this.frmAzurirajProdajniAkcijskiCjenik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajProdajniAkcijskiCjenik_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOdKada;
        private System.Windows.Forms.DateTimePicker dtpDoKada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ckbNivo;
        private System.Windows.Forms.ComboBox ckbAktivna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPartnerSifra;
        private System.Windows.Forms.Label lblPartnerNaziv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIzmjenaDatum;
        private System.Windows.Forms.Label lblPoruka;
    }
}