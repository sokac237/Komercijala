namespace blokerX
{
    partial class frmAzurirajStalniNabavniCjenikStavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajStalniNabavniCjenikStavke));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new DevExpress.XtraEditors.TextEdit();
            this.txtRabat = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIzmjena = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSifraKodDobavljaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRabat.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod / šifra:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(97, 12);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(130, 20);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            this.txtBarkod.Leave += new System.EventHandler(this.txtBarkod_Leave);
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(253, 15);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(25, 13);
            this.lblArtikl.TabIndex = 2;
            this.lblArtikl.Text = "___";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rabat:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(97, 9);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Properties.Mask.EditMask = "c5";
            this.txtCijena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCijena.Size = new System.Drawing.Size(130, 20);
            this.txtCijena.TabIndex = 3;
            // 
            // txtRabat
            // 
            this.txtRabat.Location = new System.Drawing.Point(97, 44);
            this.txtRabat.Name = "txtRabat";
            this.txtRabat.Properties.Mask.EditMask = "P2";
            this.txtRabat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRabat.Properties.NullText = "0";
            this.txtRabat.Size = new System.Drawing.Size(130, 20);
            this.txtRabat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Zadnja izmjena:";
            // 
            // txtIzmjena
            // 
            this.txtIzmjena.Location = new System.Drawing.Point(97, 86);
            this.txtIzmjena.Name = "txtIzmjena";
            this.txtIzmjena.ReadOnly = true;
            this.txtIzmjena.Size = new System.Drawing.Size(269, 20);
            this.txtIzmjena.TabIndex = 108;
            this.txtIzmjena.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(376, 115);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(457, 115);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSifraKodDobavljaca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBarkod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblArtikl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 67);
            this.panel1.TabIndex = 111;
            // 
            // txtSifraKodDobavljaca
            // 
            this.txtSifraKodDobavljaca.Location = new System.Drawing.Point(97, 38);
            this.txtSifraKodDobavljaca.Name = "txtSifraKodDobavljaca";
            this.txtSifraKodDobavljaca.Size = new System.Drawing.Size(130, 20);
            this.txtSifraKodDobavljaca.TabIndex = 5;
            this.txtSifraKodDobavljaca.Leave += new System.EventHandler(this.txtSifraKodDobavljaca_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Šifra kod dobav:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "(F2)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRabat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnSpremi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCijena);
            this.panel2.Controls.Add(this.txtIzmjena);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 144);
            this.panel2.TabIndex = 112;
            // 
            // frmAzurirajStalniNabavniCjenikStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 211);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajStalniNabavniCjenikStavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj stalni nabavni cjenik stavke";
            this.Deactivate += new System.EventHandler(this.frmAzurirajStalniNabavniCjenikStavke_Deactivate);
            this.Load += new System.EventHandler(this.frmAzurirajStalniNabavniCjenikStavke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajStalniNabavniCjenikStavke_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRabat.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCijena;
        private DevExpress.XtraEditors.TextEdit txtRabat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIzmjena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifraKodDobavljaca;
        private System.Windows.Forms.Label label6;
    }
}