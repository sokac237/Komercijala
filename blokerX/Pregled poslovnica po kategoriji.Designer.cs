namespace blokerX
{
    partial class frmPregledPoslovnicaPoKategoriji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledPoslovnicaPoKategoriji));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAsortimanCjenik = new System.Windows.Forms.Button();
            this.btnUkupno = new System.Windows.Forms.Button();
            this.btnAzurirajPregledPoslovnicaPoKategoriji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAkcijskiNabavniCjenici = new DevExpress.XtraGrid.GridControl();
            this.poslovnicePoKategorijiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicePoKategoriji = new blokerX.PoslovnicePoKategoriji();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmj_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_asortiman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_cjenik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poslovnicePoKategorijiTableAdapter = new blokerX.PoslovnicePoKategorijiTableAdapters.PoslovnicePoKategorijiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicePoKategorijiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicePoKategoriji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAsortimanCjenik);
            this.panel1.Controls.Add(this.btnUkupno);
            this.panel1.Controls.Add(this.btnAzurirajPregledPoslovnicaPoKategoriji);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 54);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "F9 - excel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lista za grupu trgovina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsortimanCjenik
            // 
            this.btnAsortimanCjenik.Location = new System.Drawing.Point(148, 21);
            this.btnAsortimanCjenik.Name = "btnAsortimanCjenik";
            this.btnAsortimanCjenik.Size = new System.Drawing.Size(126, 23);
            this.btnAsortimanCjenik.TabIndex = 3;
            this.btnAsortimanCjenik.Text = "Lista asortiman / cjenik";
            this.btnAsortimanCjenik.UseVisualStyleBackColor = true;
            this.btnAsortimanCjenik.Click += new System.EventHandler(this.btnAsortimanCjenik_Click);
            // 
            // btnUkupno
            // 
            this.btnUkupno.Location = new System.Drawing.Point(31, 21);
            this.btnUkupno.Name = "btnUkupno";
            this.btnUkupno.Size = new System.Drawing.Size(97, 23);
            this.btnUkupno.TabIndex = 2;
            this.btnUkupno.Text = "Lista ukupno";
            this.btnUkupno.UseVisualStyleBackColor = true;
            this.btnUkupno.Click += new System.EventHandler(this.btnUkupno_Click);
            // 
            // btnAzurirajPregledPoslovnicaPoKategoriji
            // 
            this.btnAzurirajPregledPoslovnicaPoKategoriji.Location = new System.Drawing.Point(9, 19);
            this.btnAzurirajPregledPoslovnicaPoKategoriji.Name = "btnAzurirajPregledPoslovnicaPoKategoriji";
            this.btnAzurirajPregledPoslovnicaPoKategoriji.Size = new System.Drawing.Size(1, 1);
            this.btnAzurirajPregledPoslovnicaPoKategoriji.TabIndex = 1;
            this.btnAzurirajPregledPoslovnicaPoKategoriji.UseVisualStyleBackColor = true;
            this.btnAzurirajPregledPoslovnicaPoKategoriji.Click += new System.EventHandler(this.btnAzurirajPregledPoslovnicaPoKategoriji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(704, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "F4 - ažuriranje asortimana i cjenika";
            // 
            // dgAkcijskiNabavniCjenici
            // 
            this.dgAkcijskiNabavniCjenici.DataSource = this.poslovnicePoKategorijiBindingSource;
            this.dgAkcijskiNabavniCjenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkcijskiNabavniCjenici.Location = new System.Drawing.Point(0, 0);
            this.dgAkcijskiNabavniCjenici.MainView = this.gridView2;
            this.dgAkcijskiNabavniCjenici.Name = "dgAkcijskiNabavniCjenici";
            this.dgAkcijskiNabavniCjenici.Size = new System.Drawing.Size(885, 339);
            this.dgAkcijskiNabavniCjenici.TabIndex = 17;
            this.dgAkcijskiNabavniCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgAkcijskiNabavniCjenici.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgAkcijskiNabavniCjenici_KeyUp);
            // 
            // poslovnicePoKategorijiBindingSource
            // 
            this.poslovnicePoKategorijiBindingSource.DataMember = "PoslovnicePoKategoriji";
            this.poslovnicePoKategorijiBindingSource.DataSource = this.poslovnicePoKategoriji;
            // 
            // poslovnicePoKategoriji
            // 
            this.poslovnicePoKategoriji.DataSetName = "PoslovnicePoKategoriji";
            this.poslovnicePoKategoriji.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpo_sifra,
            this.colpo_naziv,
            this.colmj_naziv,
            this.colpo_asortiman,
            this.colpo_cjenik,
            this.colpo_ID});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView2.GridControl = this.dgAkcijskiNabavniCjenici;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.PaintStyleName = "WindowsXP";
            this.gridView2.SynchronizeClones = false;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 0;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Poslovnica";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 1;
            this.colpo_naziv.Width = 237;
            // 
            // colmj_naziv
            // 
            this.colmj_naziv.Caption = "Mjesto";
            this.colmj_naziv.FieldName = "mj_naziv";
            this.colmj_naziv.Name = "colmj_naziv";
            this.colmj_naziv.Visible = true;
            this.colmj_naziv.VisibleIndex = 2;
            this.colmj_naziv.Width = 227;
            // 
            // colpo_asortiman
            // 
            this.colpo_asortiman.Caption = "Asortiman";
            this.colpo_asortiman.FieldName = "po_asortiman";
            this.colpo_asortiman.Name = "colpo_asortiman";
            this.colpo_asortiman.Visible = true;
            this.colpo_asortiman.VisibleIndex = 3;
            // 
            // colpo_cjenik
            // 
            this.colpo_cjenik.Caption = "Cjenik";
            this.colpo_cjenik.FieldName = "po_cjenik";
            this.colpo_cjenik.Name = "colpo_cjenik";
            this.colpo_cjenik.Visible = true;
            this.colpo_cjenik.VisibleIndex = 4;
            // 
            // colpo_ID
            // 
            this.colpo_ID.FieldName = "po_ID";
            this.colpo_ID.Name = "colpo_ID";
            // 
            // poslovnicePoKategorijiTableAdapter
            // 
            this.poslovnicePoKategorijiTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledPoslovnicaPoKategoriji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 393);
            this.Controls.Add(this.dgAkcijskiNabavniCjenici);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledPoslovnicaPoKategoriji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled poslovnica po kategoriji";
            this.Load += new System.EventHandler(this.Pregled_poslovnica_po_kategoriji_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledPoslovnicaPoKategoriji_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicePoKategorijiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicePoKategoriji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgAkcijskiNabavniCjenici;
        private System.Windows.Forms.Label label1;
        private PoslovnicePoKategoriji poslovnicePoKategoriji;
        private System.Windows.Forms.BindingSource poslovnicePoKategorijiBindingSource;
        private PoslovnicePoKategorijiTableAdapters.PoslovnicePoKategorijiTableAdapter poslovnicePoKategorijiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colmj_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_asortiman;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_cjenik;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_ID;
        private System.Windows.Forms.Button btnAzurirajPregledPoslovnicaPoKategoriji;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAsortimanCjenik;
        private System.Windows.Forms.Button btnUkupno;
        private System.Windows.Forms.Label label2;
    }
}