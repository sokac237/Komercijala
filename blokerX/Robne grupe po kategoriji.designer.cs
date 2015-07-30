namespace blokirajx
{
    partial class frmRobneGrupePoKategoriji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRobneGrupePoKategoriji));
            this.panel1 = new System.Windows.Forms.Panel();
            this.glKategorija = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija = new blokerX.kategorija();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colka_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Šifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgRobneGrupe = new System.Windows.Forms.DataGridView();
            this.kategorijaTableAdapter = new blokerX.kategorijaTableAdapters.kategorijaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRobneGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.glKategorija);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 72);
            this.panel1.TabIndex = 0;
            // 
            // glKategorija
            // 
            this.glKategorija.EditValue = "";
            this.glKategorija.Location = new System.Drawing.Point(92, 27);
            this.glKategorija.Name = "glKategorija";
            this.glKategorija.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glKategorija.Properties.DataSource = this.kategorijaBindingSource;
            this.glKategorija.Properties.DisplayMember = "ka_naziv";
            this.glKategorija.Properties.ImmediatePopup = true;
            this.glKategorija.Properties.ValueMember = "ka_ID";
            this.glKategorija.Properties.View = this.gridView1;
            this.glKategorija.Size = new System.Drawing.Size(305, 20);
            this.glKategorija.TabIndex = 0;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "kategorija";
            this.kategorijaBindingSource.DataSource = this.kategorija;
            // 
            // kategorija
            // 
            this.kategorija.DataSetName = "kategorija";
            this.kategorija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colka_ID,
            this.Šifra,
            this.Naziv});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colka_ID
            // 
            this.colka_ID.FieldName = "ka_ID";
            this.colka_ID.Name = "colka_ID";
            // 
            // Šifra
            // 
            this.Šifra.FieldName = "ka_sifra";
            this.Šifra.Name = "Šifra";
            this.Šifra.Visible = true;
            this.Šifra.VisibleIndex = 0;
            this.Šifra.Width = 88;
            // 
            // Naziv
            // 
            this.Naziv.FieldName = "ka_naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Visible = true;
            this.Naziv.VisibleIndex = 1;
            this.Naziv.Width = 590;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(540, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "F5 - pregled";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(417, 27);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            // 
            // dgRobneGrupe
            // 
            this.dgRobneGrupe.AllowUserToAddRows = false;
            this.dgRobneGrupe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgRobneGrupe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRobneGrupe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgRobneGrupe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgRobneGrupe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgRobneGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRobneGrupe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRobneGrupe.Location = new System.Drawing.Point(0, 72);
            this.dgRobneGrupe.Name = "dgRobneGrupe";
            this.dgRobneGrupe.ReadOnly = true;
            this.dgRobneGrupe.Size = new System.Drawing.Size(710, 510);
            this.dgRobneGrupe.TabIndex = 2;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRobneGrupePoKategoriji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 582);
            this.Controls.Add(this.dgRobneGrupe);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRobneGrupePoKategoriji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robne grupe po kategoriji";
            this.Load += new System.EventHandler(this.frmRobneGrupePoKategoriji_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRobneGrupePoKategoriji_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRobneGrupe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit glKategorija;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridView dgRobneGrupe;
        private blokerX.kategorija kategorija;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private blokerX.kategorijaTableAdapters.kategorijaTableAdapter kategorijaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colka_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Šifra;
        private DevExpress.XtraGrid.Columns.GridColumn Naziv;
    }
}