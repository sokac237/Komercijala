namespace blokerX
{
    partial class frmPripremaCijena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPripremaCijena));
            this.btnPripremi = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPripremi
            // 
            this.btnPripremi.Location = new System.Drawing.Point(220, 84);
            this.btnPripremi.Name = "btnPripremi";
            this.btnPripremi.Size = new System.Drawing.Size(75, 23);
            this.btnPripremi.TabIndex = 0;
            this.btnPripremi.Text = "Pripremi";
            this.btnPripremi.UseVisualStyleBackColor = true;
            this.btnPripremi.Click += new System.EventHandler(this.btnPripremi_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(23, 24);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(280, 23);
            this.pbar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 59);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(302, 84);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // frmPripremaCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 119);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.btnPripremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPripremaCijena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priprema cijena za trgovinu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPripremi;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Timer timer1;
    }
}