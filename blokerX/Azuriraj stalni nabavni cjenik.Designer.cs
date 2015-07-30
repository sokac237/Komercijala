namespace blokerX
{
    partial class frmAzurirajStalniNabavniCjenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajStalniNabavniCjenik));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.ckbAktivan = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblPartnerNaziv = new System.Windows.Forms.Label();
            this.txtPartnerSifra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cjenik važi od:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(117, 24);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(133, 20);
            this.dtpDatumOd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis cjenika:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(117, 59);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(298, 20);
            this.txtOpis.TabIndex = 2;
            // 
            // ckbAktivan
            // 
            this.ckbAktivan.AutoSize = true;
            this.ckbAktivan.Checked = true;
            this.ckbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAktivan.Location = new System.Drawing.Point(117, 121);
            this.ckbAktivan.Name = "ckbAktivan";
            this.ckbAktivan.Size = new System.Drawing.Size(62, 17);
            this.ckbAktivan.TabIndex = 4;
            this.ckbAktivan.Text = "Aktivan";
            this.ckbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(259, 147);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(340, 147);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblPartnerNaziv
            // 
            this.lblPartnerNaziv.AutoSize = true;
            this.lblPartnerNaziv.Location = new System.Drawing.Point(188, 93);
            this.lblPartnerNaziv.Name = "lblPartnerNaziv";
            this.lblPartnerNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblPartnerNaziv.TabIndex = 23;
            this.lblPartnerNaziv.Text = "___";
            // 
            // txtPartnerSifra
            // 
            this.txtPartnerSifra.Enabled = false;
            this.txtPartnerSifra.Location = new System.Drawing.Point(117, 90);
            this.txtPartnerSifra.Name = "txtPartnerSifra";
            this.txtPartnerSifra.Size = new System.Drawing.Size(65, 20);
            this.txtPartnerSifra.TabIndex = 3;
            this.txtPartnerSifra.TextChanged += new System.EventHandler(this.txtPartnerSifra_TextChanged);
            this.txtPartnerSifra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartnerSifra_KeyPress);
            this.txtPartnerSifra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPartnerSifra_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Partner:";
            // 
            // frmAzurirajStalniNabavniCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 183);
            this.Controls.Add(this.lblPartnerNaziv);
            this.Controls.Add(this.txtPartnerSifra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.ckbAktivan);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajStalniNabavniCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj stalni nabavni cjenik";
            this.Deactivate += new System.EventHandler(this.frmAzurirajStalniNabavniCjenik_Deactivate);
            this.Load += new System.EventHandler(this.frmAzurirajStalniNabavniCjenik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajStalniNabavniCjenik_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox ckbAktivan;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblPartnerNaziv;
        private System.Windows.Forms.TextBox txtPartnerSifra;
        private System.Windows.Forms.Label label10;
    }
}