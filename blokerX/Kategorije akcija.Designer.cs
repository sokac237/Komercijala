namespace blokerX
{
    partial class frmKategorijeAkcija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorijeAkcija));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAkcijskiNabavniCjenici = new DevExpress.XtraGrid.GridControl();
            this.kategorijeAkcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeAkcija = new blokerX.KategorijeAkcija();
            this.dgKategorije = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpok_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_vaziod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_ispis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_izmjena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_aktivan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kategorijeAkcijaTableAdapter = new blokerX.KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 83);
            this.panel1.TabIndex = 0;
            // 
            // dgAkcijskiNabavniCjenici
            // 
            this.dgAkcijskiNabavniCjenici.DataSource = this.kategorijeAkcijaBindingSource;
            this.dgAkcijskiNabavniCjenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkcijskiNabavniCjenici.Location = new System.Drawing.Point(0, 83);
            this.dgAkcijskiNabavniCjenici.MainView = this.dgKategorije;
            this.dgAkcijskiNabavniCjenici.Name = "dgAkcijskiNabavniCjenici";
            this.dgAkcijskiNabavniCjenici.Size = new System.Drawing.Size(716, 407);
            this.dgAkcijskiNabavniCjenici.TabIndex = 13;
            this.dgAkcijskiNabavniCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgKategorije});
            // 
            // kategorijeAkcijaBindingSource
            // 
            this.kategorijeAkcijaBindingSource.DataMember = "kategorijeAkcija";
            this.kategorijeAkcijaBindingSource.DataSource = this.kategorijeAkcija;
            // 
            // kategorijeAkcija
            // 
            this.kategorijeAkcija.DataSetName = "KategorijeAkcija";
            this.kategorijeAkcija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgKategorije
            // 
            this.dgKategorije.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgKategorije.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgKategorije.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgKategorije.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgKategorije.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgKategorije.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.Empty.Options.UseBackColor = true;
            this.dgKategorije.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgKategorije.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgKategorije.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgKategorije.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgKategorije.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgKategorije.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgKategorije.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgKategorije.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgKategorije.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgKategorije.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgKategorije.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgKategorije.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgKategorije.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgKategorije.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgKategorije.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgKategorije.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgKategorije.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgKategorije.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgKategorije.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgKategorije.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgKategorije.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgKategorije.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.GroupRow.Options.UseFont = true;
            this.dgKategorije.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgKategorije.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgKategorije.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgKategorije.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgKategorije.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgKategorije.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgKategorije.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgKategorije.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgKategorije.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgKategorije.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgKategorije.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.OddRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.OddRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgKategorije.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgKategorije.Appearance.Preview.Options.UseBackColor = true;
            this.dgKategorije.Appearance.Preview.Options.UseForeColor = true;
            this.dgKategorije.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.Row.Options.UseBackColor = true;
            this.dgKategorije.Appearance.Row.Options.UseForeColor = true;
            this.dgKategorije.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgKategorije.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgKategorije.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgKategorije.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgKategorije.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgKategorije.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgKategorije.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgKategorije.Appearance.VertLine.Options.UseBackColor = true;
            this.dgKategorije.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpok_sifra,
            this.colpok_naziv,
            this.colpok_vaziod,
            this.colpok_vazido,
            this.colpok_ispis,
            this.colpok_izmjena,
            this.colpok_aktivan});
            this.dgKategorije.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgKategorije.GridControl = this.dgAkcijskiNabavniCjenici;
            this.dgKategorije.Name = "dgKategorije";
            this.dgKategorije.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgKategorije.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgKategorije.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgKategorije.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgKategorije.OptionsBehavior.Editable = false;
            this.dgKategorije.OptionsCustomization.AllowColumnMoving = false;
            this.dgKategorije.OptionsCustomization.AllowFilter = false;
            this.dgKategorije.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgKategorije.OptionsSelection.MultiSelect = true;
            this.dgKategorije.OptionsView.ColumnAutoWidth = false;
            this.dgKategorije.OptionsView.EnableAppearanceEvenRow = true;
            this.dgKategorije.OptionsView.EnableAppearanceOddRow = true;
            this.dgKategorije.OptionsView.ShowAutoFilterRow = true;
            this.dgKategorije.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgKategorije.OptionsView.ShowGroupPanel = false;
            this.dgKategorije.OptionsView.ShowIndicator = false;
            this.dgKategorije.PaintStyleName = "WindowsXP";
            this.dgKategorije.SynchronizeClones = false;
            // 
            // colpok_sifra
            // 
            this.colpok_sifra.Caption = "Šifra";
            this.colpok_sifra.FieldName = "pok_sifra";
            this.colpok_sifra.Name = "colpok_sifra";
            this.colpok_sifra.Visible = true;
            this.colpok_sifra.VisibleIndex = 0;
            // 
            // colpok_naziv
            // 
            this.colpok_naziv.Caption = "Naziv";
            this.colpok_naziv.FieldName = "pok_naziv";
            this.colpok_naziv.Name = "colpok_naziv";
            this.colpok_naziv.Visible = true;
            this.colpok_naziv.VisibleIndex = 1;
            this.colpok_naziv.Width = 239;
            // 
            // colpok_vaziod
            // 
            this.colpok_vaziod.Caption = "Važi od";
            this.colpok_vaziod.FieldName = "pok_vaziod";
            this.colpok_vaziod.Name = "colpok_vaziod";
            this.colpok_vaziod.Visible = true;
            this.colpok_vaziod.VisibleIndex = 2;
            // 
            // colpok_vazido
            // 
            this.colpok_vazido.Caption = "Važi do";
            this.colpok_vazido.FieldName = "pok_vazido";
            this.colpok_vazido.Name = "colpok_vazido";
            this.colpok_vazido.Visible = true;
            this.colpok_vazido.VisibleIndex = 3;
            // 
            // colpok_ispis
            // 
            this.colpok_ispis.Caption = "Ispis";
            this.colpok_ispis.FieldName = "pok_ispis";
            this.colpok_ispis.Name = "colpok_ispis";
            this.colpok_ispis.Visible = true;
            this.colpok_ispis.VisibleIndex = 4;
            // 
            // colpok_izmjena
            // 
            this.colpok_izmjena.Caption = "Izmjena";
            this.colpok_izmjena.FieldName = "pok_izmjena";
            this.colpok_izmjena.Name = "colpok_izmjena";
            this.colpok_izmjena.Visible = true;
            this.colpok_izmjena.VisibleIndex = 5;
            // 
            // colpok_aktivan
            // 
            this.colpok_aktivan.Caption = "Aktivan";
            this.colpok_aktivan.FieldName = "pok_aktivan";
            this.colpok_aktivan.Name = "colpok_aktivan";
            this.colpok_aktivan.Visible = true;
            this.colpok_aktivan.VisibleIndex = 6;
            // 
            // kategorijeAkcijaTableAdapter
            // 
            this.kategorijeAkcijaTableAdapter.ClearBeforeFill = true;
            // 
            // frmKategorijeAkcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 490);
            this.Controls.Add(this.dgAkcijskiNabavniCjenici);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKategorijeAkcija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije akcija";
            this.Load += new System.EventHandler(this.frmKategorijeAkcija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgAkcijskiNabavniCjenici;
        private DevExpress.XtraGrid.Views.Grid.GridView dgKategorije;
        private KategorijeAkcija kategorijeAkcija;
        private System.Windows.Forms.BindingSource kategorijeAkcijaBindingSource;
        private KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter kategorijeAkcijaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_vaziod;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_vazido;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_ispis;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_izmjena;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_aktivan;
    }
}