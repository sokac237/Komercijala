namespace blokerX
{
    partial class frmOperater
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperater));
            this.dgOperater = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOperater = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperater)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOperater
            // 
            this.dgOperater.AllowUserToAddRows = false;
            this.dgOperater.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgOperater.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOperater.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgOperater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOperater.Location = new System.Drawing.Point(0, 65);
            this.dgOperater.Name = "dgOperater";
            this.dgOperater.ReadOnly = true;
            this.dgOperater.Size = new System.Drawing.Size(403, 376);
            this.dgOperater.TabIndex = 9;
            this.dgOperater.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOperater_CellDoubleClick);
            this.dgOperater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgOperater_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Traži:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOperater);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 65);
            this.panel1.TabIndex = 8;
            // 
            // txtOperater
            // 
            this.txtOperater.Location = new System.Drawing.Point(83, 20);
            this.txtOperater.Name = "txtOperater";
            this.txtOperater.Size = new System.Drawing.Size(144, 20);
            this.txtOperater.TabIndex = 0;
            this.txtOperater.TextChanged += new System.EventHandler(this.txtOperater_TextChanged);
            // 
            // frmOperater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 441);
            this.Controls.Add(this.dgOperater);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmOperater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operateri";
            this.Load += new System.EventHandler(this.Operateri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Operateri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperater)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOperater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOperater;
    }
}