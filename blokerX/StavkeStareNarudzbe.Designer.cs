namespace blokerX
{
    partial class frmStavkeStareNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStavkeStareNarudzbe));
            this.dgStavke = new DevExpress.XtraGrid.GridControl();
            this.narudzbaStavkaStareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbaStavkaStare = new blokerX.NarudzbaStavkaStare();
            this.dgStavkeNarudzbe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnarudzba_na_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarkod_bk_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Razlika = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_kolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_nabavnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_odobrenakolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_isporucenakolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_nenarucuj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivTrgovine = new System.Windows.Forms.TextBox();
            this.txtSifraTrgovine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.narudzbaStavkaStareTableAdapter = new blokerX.NarudzbaStavkaStareTableAdapters.NarudzbaStavkaStareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaStareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaStare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStavke
            // 
            this.dgStavke.DataSource = this.narudzbaStavkaStareBindingSource;
            this.dgStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStavke.Location = new System.Drawing.Point(0, 78);
            this.dgStavke.MainView = this.dgStavkeNarudzbe;
            this.dgStavke.Name = "dgStavke";
            this.dgStavke.Size = new System.Drawing.Size(1046, 424);
            this.dgStavke.TabIndex = 25;
            this.dgStavke.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgStavkeNarudzbe});
            this.dgStavke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgStavke_KeyDown);
            // 
            // narudzbaStavkaStareBindingSource
            // 
            this.narudzbaStavkaStareBindingSource.DataMember = "NarudzbaStavkaStare";
            this.narudzbaStavkaStareBindingSource.DataSource = this.narudzbaStavkaStare;
            // 
            // narudzbaStavkaStare
            // 
            this.narudzbaStavkaStare.DataSetName = "NarudzbaStavkaStare";
            this.narudzbaStavkaStare.EnforceConstraints = false;
            this.narudzbaStavkaStare.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgStavkeNarudzbe
            // 
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.Empty.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgStavkeNarudzbe.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgStavkeNarudzbe.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgStavkeNarudzbe.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseFont = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeNarudzbe.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.OddRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.OddRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgStavkeNarudzbe.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgStavkeNarudzbe.Appearance.Preview.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.Preview.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.Row.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.Row.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgStavkeNarudzbe.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeNarudzbe.Appearance.VertLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRG_SIFRA,
            this.colRG_NAZIV,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colnas_ID,
            this.colnarudzba_na_ID,
            this.colartikl_ar_ID,
            this.colbarkod_bk_kod,
            this.Razlika,
            this.colnas_kolicina,
            this.colnas_nabavnacijena,
            this.colnas_odobrenakolicina,
            this.colnas_isporucenakolicina,
            this.colar_nenarucuj});
            this.dgStavkeNarudzbe.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgStavkeNarudzbe.GridControl = this.dgStavke;
            this.dgStavkeNarudzbe.Name = "dgStavkeNarudzbe";
            this.dgStavkeNarudzbe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeNarudzbe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeNarudzbe.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgStavkeNarudzbe.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgStavkeNarudzbe.OptionsBehavior.Editable = false;
            this.dgStavkeNarudzbe.OptionsCustomization.AllowColumnMoving = false;
            this.dgStavkeNarudzbe.OptionsCustomization.AllowFilter = false;
            this.dgStavkeNarudzbe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgStavkeNarudzbe.OptionsView.EnableAppearanceEvenRow = true;
            this.dgStavkeNarudzbe.OptionsView.EnableAppearanceOddRow = true;
            this.dgStavkeNarudzbe.OptionsView.ShowAutoFilterRow = true;
            this.dgStavkeNarudzbe.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgStavkeNarudzbe.OptionsView.ShowGroupPanel = false;
            this.dgStavkeNarudzbe.OptionsView.ShowIndicator = false;
            this.dgStavkeNarudzbe.PaintStyleName = "WindowsXP";
            this.dgStavkeNarudzbe.SynchronizeClones = false;
            this.dgStavkeNarudzbe.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgStavkeNarudzbe_RowCellStyle);
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "Šifra RG";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.OptionsColumn.AllowEdit = false;
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 0;
            this.colRG_SIFRA.Width = 207;
            // 
            // colRG_NAZIV
            // 
            this.colRG_NAZIV.Caption = "Naziv RG";
            this.colRG_NAZIV.FieldName = "RG_NAZIV";
            this.colRG_NAZIV.Name = "colRG_NAZIV";
            this.colRG_NAZIV.OptionsColumn.AllowEdit = false;
            this.colRG_NAZIV.Visible = true;
            this.colRG_NAZIV.VisibleIndex = 1;
            this.colRG_NAZIV.Width = 275;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Artikl šifra";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.OptionsColumn.AllowEdit = false;
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 2;
            this.colAR_SIFRA.Width = 151;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Artikl naziv";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.OptionsColumn.AllowEdit = false;
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 3;
            this.colAR_NAZIV.Width = 430;
            // 
            // colnas_ID
            // 
            this.colnas_ID.FieldName = "nas_ID";
            this.colnas_ID.Name = "colnas_ID";
            this.colnas_ID.OptionsColumn.AllowEdit = false;
            // 
            // colnarudzba_na_ID
            // 
            this.colnarudzba_na_ID.FieldName = "narudzba_na_ID";
            this.colnarudzba_na_ID.Name = "colnarudzba_na_ID";
            this.colnarudzba_na_ID.OptionsColumn.AllowEdit = false;
            // 
            // colartikl_ar_ID
            // 
            this.colartikl_ar_ID.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID.Name = "colartikl_ar_ID";
            this.colartikl_ar_ID.OptionsColumn.AllowEdit = false;
            // 
            // colbarkod_bk_kod
            // 
            this.colbarkod_bk_kod.FieldName = "barkod_bk_kod";
            this.colbarkod_bk_kod.Name = "colbarkod_bk_kod";
            this.colbarkod_bk_kod.OptionsColumn.AllowEdit = false;
            // 
            // Razlika
            // 
            this.Razlika.Caption = "Razlika";
            this.Razlika.DisplayFormat.FormatString = "n2";
            this.Razlika.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Razlika.FieldName = "Razlika";
            this.Razlika.Name = "Razlika";
            this.Razlika.OptionsColumn.AllowEdit = false;
            this.Razlika.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.Razlika.UnboundExpression = "[nas_isporucenakolicina]-[nas_kolicina]";
            this.Razlika.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Razlika.Visible = true;
            this.Razlika.VisibleIndex = 7;
            this.Razlika.Width = 121;
            // 
            // colnas_kolicina
            // 
            this.colnas_kolicina.Caption = "Naručena količina";
            this.colnas_kolicina.FieldName = "nas_kolicina";
            this.colnas_kolicina.Name = "colnas_kolicina";
            this.colnas_kolicina.OptionsColumn.AllowEdit = false;
            this.colnas_kolicina.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colnas_kolicina.Visible = true;
            this.colnas_kolicina.VisibleIndex = 4;
            this.colnas_kolicina.Width = 193;
            // 
            // colnas_nabavnacijena
            // 
            this.colnas_nabavnacijena.FieldName = "nas_nabavnacijena";
            this.colnas_nabavnacijena.Name = "colnas_nabavnacijena";
            this.colnas_nabavnacijena.OptionsColumn.AllowEdit = false;
            // 
            // colnas_odobrenakolicina
            // 
            this.colnas_odobrenakolicina.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colnas_odobrenakolicina.AppearanceCell.Options.UseFont = true;
            this.colnas_odobrenakolicina.Caption = "Odobrena količina";
            this.colnas_odobrenakolicina.FieldName = "nas_odobrenakolicina";
            this.colnas_odobrenakolicina.Name = "colnas_odobrenakolicina";
            this.colnas_odobrenakolicina.OptionsColumn.AllowEdit = false;
            this.colnas_odobrenakolicina.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colnas_odobrenakolicina.Visible = true;
            this.colnas_odobrenakolicina.VisibleIndex = 5;
            this.colnas_odobrenakolicina.Width = 180;
            // 
            // colnas_isporucenakolicina
            // 
            this.colnas_isporucenakolicina.Caption = "Isporučena količina";
            this.colnas_isporucenakolicina.FieldName = "nas_isporucenakolicina";
            this.colnas_isporucenakolicina.Name = "colnas_isporucenakolicina";
            this.colnas_isporucenakolicina.OptionsColumn.AllowEdit = false;
            this.colnas_isporucenakolicina.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colnas_isporucenakolicina.Visible = true;
            this.colnas_isporucenakolicina.VisibleIndex = 6;
            this.colnas_isporucenakolicina.Width = 176;
            // 
            // colar_nenarucuj
            // 
            this.colar_nenarucuj.FieldName = "ar_nenarucuj";
            this.colar_nenarucuj.Name = "colar_nenarucuj";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIzlaz);
            this.panel2.Controls.Add(this.btnIspis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 54);
            this.panel2.TabIndex = 24;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(867, 13);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "ESC - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(24, 13);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNazivTrgovine);
            this.panel1.Controls.Add(this.txtSifraTrgovine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBrojNarudzbe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSkladiste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 78);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "F9 - excel";
            // 
            // txtNazivTrgovine
            // 
            this.txtNazivTrgovine.BackColor = System.Drawing.SystemColors.Window;
            this.txtNazivTrgovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivTrgovine.Location = new System.Drawing.Point(212, 43);
            this.txtNazivTrgovine.Name = "txtNazivTrgovine";
            this.txtNazivTrgovine.ReadOnly = true;
            this.txtNazivTrgovine.Size = new System.Drawing.Size(191, 20);
            this.txtNazivTrgovine.TabIndex = 6;
            // 
            // txtSifraTrgovine
            // 
            this.txtSifraTrgovine.BackColor = System.Drawing.SystemColors.Window;
            this.txtSifraTrgovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraTrgovine.Location = new System.Drawing.Point(77, 43);
            this.txtSifraTrgovine.Name = "txtSifraTrgovine";
            this.txtSifraTrgovine.ReadOnly = true;
            this.txtSifraTrgovine.Size = new System.Drawing.Size(100, 20);
            this.txtSifraTrgovine.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trgovina:";
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(303, 12);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.ReadOnly = true;
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.txtBrojNarudzbe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj narudžbe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište:";
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.BackColor = System.Drawing.SystemColors.Window;
            this.txtSkladiste.Location = new System.Drawing.Point(77, 15);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.ReadOnly = true;
            this.txtSkladiste.Size = new System.Drawing.Size(100, 20);
            this.txtSkladiste.TabIndex = 0;
            // 
            // narudzbaStavkaStareTableAdapter
            // 
            this.narudzbaStavkaStareTableAdapter.ClearBeforeFill = true;
            // 
            // frmStavkeStareNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 556);
            this.Controls.Add(this.dgStavke);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStavkeStareNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke stare narudžbe";
            this.Deactivate += new System.EventHandler(this.frmStavkeStareNarudzbe_Deactivate);
            this.Load += new System.EventHandler(this.frmStavkeStareNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaStareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkaStare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgStavke;
        private DevExpress.XtraGrid.Views.Grid.GridView dgStavkeNarudzbe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNazivTrgovine;
        private System.Windows.Forms.TextBox txtSifraTrgovine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.BindingSource narudzbaStavkaStareBindingSource;
        private NarudzbaStavkaStare narudzbaStavkaStare;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colnarudzba_na_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkod_bk_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_kolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_nabavnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_odobrenakolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_isporucenakolicina;
        private NarudzbaStavkaStareTableAdapters.NarudzbaStavkaStareTableAdapter narudzbaStavkaStareTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Razlika;
        private DevExpress.XtraGrid.Columns.GridColumn colar_nenarucuj;
        private System.Windows.Forms.Label label4;
    }
}