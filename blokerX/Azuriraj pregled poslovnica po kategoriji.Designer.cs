namespace blokerX
{
    partial class frmAzurirajPoslovnicePoKategoriji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajPoslovnicePoKategoriji));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.lblNazivPoslovnice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAsortiman = new System.Windows.Forms.TextBox();
            this.txtCjenik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(309, 137);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(391, 137);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poslovnica:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(128, 23);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 0;
            // 
            // lblNazivPoslovnice
            // 
            this.lblNazivPoslovnice.AutoSize = true;
            this.lblNazivPoslovnice.Location = new System.Drawing.Point(245, 23);
            this.lblNazivPoslovnice.Name = "lblNazivPoslovnice";
            this.lblNazivPoslovnice.Size = new System.Drawing.Size(25, 13);
            this.lblNazivPoslovnice.TabIndex = 4;
            this.lblNazivPoslovnice.Text = "___";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupa za asortiman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupa za cjenik:";
            // 
            // txtAsortiman
            // 
            this.txtAsortiman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsortiman.Location = new System.Drawing.Point(128, 61);
            this.txtAsortiman.MaxLength = 1;
            this.txtAsortiman.Name = "txtAsortiman";
            this.txtAsortiman.ReadOnly = true;
            this.txtAsortiman.Size = new System.Drawing.Size(49, 20);
            this.txtAsortiman.TabIndex = 1;
            this.txtAsortiman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsortiman_KeyPress);
            // 
            // txtCjenik
            // 
            this.txtCjenik.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCjenik.Location = new System.Drawing.Point(128, 99);
            this.txtCjenik.MaxLength = 1;
            this.txtCjenik.Name = "txtCjenik";
            this.txtCjenik.Size = new System.Drawing.Size(49, 20);
            this.txtCjenik.TabIndex = 2;
            this.txtCjenik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCjenik_KeyPress);
            // 
            // frmAzurirajPoslovnicePoKategoriji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 175);
            this.Controls.Add(this.txtCjenik);
            this.Controls.Add(this.txtAsortiman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNazivPoslovnice);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajPoslovnicePoKategoriji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj poslovnice po kategoriji";
            this.Load += new System.EventHandler(this.frmAzurirajPoslovnicePoKategoriji_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajPoslovnicePoKategoriji_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label lblNazivPoslovnice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsortiman;
        private System.Windows.Forms.TextBox txtCjenik;
    }
}