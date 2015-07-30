namespace blokerX
{
    partial class frmPregledNarudzbiPoKomercijalistu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNarudzbiPoKomercijalistu));
            this.dgNarudzbe = new DevExpress.XtraGrid.GridControl();
            this.pregledNarudzbiPoKomercijalistiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbe_po_komercijalisti = new blokerX.Narudzbe_po_komercijalisti();
            this.dgNarudzbeZag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnaručeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colodobreno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisporuceno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazlika = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbrojnarudžbi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colneizmjenjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colneisporucene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanjeisporucene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviseisporucene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.operaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komercijalist = new blokerX.Komercijalist();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colop_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.operaterTableAdapter = new blokerX.KomercijalistTableAdapters.operaterTableAdapter();
            this.pregledNarudzbiPoKomercijalistiTableAdapter = new blokerX.Narudzbe_po_komercijalistiTableAdapters.pregledNarudzbiPoKomercijalistiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNarudzbiPoKomercijalistiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbe_po_komercijalisti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNarudzbe
            // 
            this.dgNarudzbe.DataSource = this.pregledNarudzbiPoKomercijalistiBindingSource;
            this.dgNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNarudzbe.Location = new System.Drawing.Point(0, 101);
            this.dgNarudzbe.MainView = this.dgNarudzbeZag;
            this.dgNarudzbe.Name = "dgNarudzbe";
            this.dgNarudzbe.Size = new System.Drawing.Size(1255, 416);
            this.dgNarudzbe.TabIndex = 24;
            this.dgNarudzbe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgNarudzbeZag});
            this.dgNarudzbe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgNarudzbe_KeyDown);
            // 
            // pregledNarudzbiPoKomercijalistiBindingSource
            // 
            this.pregledNarudzbiPoKomercijalistiBindingSource.DataMember = "pregledNarudzbiPoKomercijalisti";
            this.pregledNarudzbiPoKomercijalistiBindingSource.DataSource = this.narudzbe_po_komercijalisti;
            // 
            // narudzbe_po_komercijalisti
            // 
            this.narudzbe_po_komercijalisti.DataSetName = "Narudzbe_po_komercijalisti";
            this.narudzbe_po_komercijalisti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgNarudzbeZag
            // 
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.Empty.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgNarudzbeZag.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgNarudzbeZag.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgNarudzbeZag.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseFont = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgNarudzbeZag.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgNarudzbeZag.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNarudzbeZag.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.OddRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.OddRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgNarudzbeZag.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgNarudzbeZag.Appearance.Preview.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.Preview.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.Row.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.Row.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgNarudzbeZag.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNarudzbeZag.Appearance.VertLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.ColumnPanelRowHeight = 50;
            this.dgNarudzbeZag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRG_SIFRA,
            this.colRG_NAZIV,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colnaručeno,
            this.colodobreno,
            this.colisporuceno,
            this.colrazlika,
            this.colbrojnarudžbi,
            this.colneizmjenjene,
            this.colneisporucene,
            this.colmanjeisporucene,
            this.colviseisporucene});
            this.dgNarudzbeZag.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgNarudzbeZag.GridControl = this.dgNarudzbe;
            this.dgNarudzbeZag.Name = "dgNarudzbeZag";
            this.dgNarudzbeZag.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgNarudzbeZag.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgNarudzbeZag.OptionsBehavior.Editable = false;
            this.dgNarudzbeZag.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgNarudzbeZag.OptionsView.EnableAppearanceEvenRow = true;
            this.dgNarudzbeZag.OptionsView.EnableAppearanceOddRow = true;
            this.dgNarudzbeZag.OptionsView.ShowAutoFilterRow = true;
            this.dgNarudzbeZag.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgNarudzbeZag.OptionsView.ShowGroupPanel = false;
            this.dgNarudzbeZag.OptionsView.ShowIndicator = false;
            this.dgNarudzbeZag.PaintStyleName = "WindowsXP";
            this.dgNarudzbeZag.SynchronizeClones = false;
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "Šifra RG";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 0;
            this.colRG_SIFRA.Width = 87;
            // 
            // colRG_NAZIV
            // 
            this.colRG_NAZIV.AppearanceCell.Options.UseTextOptions = true;
            this.colRG_NAZIV.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRG_NAZIV.AppearanceHeader.Options.UseTextOptions = true;
            this.colRG_NAZIV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colRG_NAZIV.Caption = "Naziv RG";
            this.colRG_NAZIV.FieldName = "RG_NAZIV";
            this.colRG_NAZIV.Name = "colRG_NAZIV";
            this.colRG_NAZIV.Visible = true;
            this.colRG_NAZIV.VisibleIndex = 1;
            this.colRG_NAZIV.Width = 264;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Artikl šifra";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 2;
            this.colAR_SIFRA.Width = 87;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.AppearanceHeader.Options.UseTextOptions = true;
            this.colAR_NAZIV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAR_NAZIV.Caption = "Artikl naziv";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 3;
            this.colAR_NAZIV.Width = 306;
            // 
            // colnaručeno
            // 
            this.colnaručeno.Caption = "Naručena količina";
            this.colnaručeno.FieldName = "naručeno";
            this.colnaručeno.Name = "colnaručeno";
            this.colnaručeno.Visible = true;
            this.colnaručeno.VisibleIndex = 4;
            this.colnaručeno.Width = 97;
            // 
            // colodobreno
            // 
            this.colodobreno.Caption = "Odobrena količina";
            this.colodobreno.FieldName = "odobreno";
            this.colodobreno.Name = "colodobreno";
            this.colodobreno.Visible = true;
            this.colodobreno.VisibleIndex = 5;
            this.colodobreno.Width = 96;
            // 
            // colisporuceno
            // 
            this.colisporuceno.Caption = "Isporučena količina";
            this.colisporuceno.FieldName = "isporuceno";
            this.colisporuceno.Name = "colisporuceno";
            this.colisporuceno.Visible = true;
            this.colisporuceno.VisibleIndex = 6;
            this.colisporuceno.Width = 107;
            // 
            // colrazlika
            // 
            this.colrazlika.Caption = "Razlika";
            this.colrazlika.FieldName = "razlika";
            this.colrazlika.Name = "colrazlika";
            this.colrazlika.Visible = true;
            this.colrazlika.VisibleIndex = 7;
            this.colrazlika.Width = 87;
            // 
            // colbrojnarudžbi
            // 
            this.colbrojnarudžbi.Caption = "Broj narudžbi";
            this.colbrojnarudžbi.FieldName = "broj narudžbi";
            this.colbrojnarudžbi.Name = "colbrojnarudžbi";
            this.colbrojnarudžbi.Visible = true;
            this.colbrojnarudžbi.VisibleIndex = 8;
            this.colbrojnarudžbi.Width = 87;
            // 
            // colneizmjenjene
            // 
            this.colneizmjenjene.Caption = "Neizmjenjenih narudžbi";
            this.colneizmjenjene.FieldName = "neizmjenjene";
            this.colneizmjenjene.Name = "colneizmjenjene";
            this.colneizmjenjene.Visible = true;
            this.colneizmjenjene.VisibleIndex = 9;
            this.colneizmjenjene.Width = 122;
            // 
            // colneisporucene
            // 
            this.colneisporucene.Caption = "Neisporučenih";
            this.colneisporucene.FieldName = "neisporucene";
            this.colneisporucene.Name = "colneisporucene";
            this.colneisporucene.Visible = true;
            this.colneisporucene.VisibleIndex = 10;
            this.colneisporucene.Width = 129;
            // 
            // colmanjeisporucene
            // 
            this.colmanjeisporucene.Caption = "Manje isporučenih";
            this.colmanjeisporucene.FieldName = "manje isporucene";
            this.colmanjeisporucene.Name = "colmanjeisporucene";
            this.colmanjeisporucene.Visible = true;
            this.colmanjeisporucene.VisibleIndex = 11;
            this.colmanjeisporucene.Width = 116;
            // 
            // colviseisporucene
            // 
            this.colviseisporucene.Caption = "Više isporučenih";
            this.colviseisporucene.FieldName = "vise isporucene";
            this.colviseisporucene.Name = "colviseisporucene";
            this.colviseisporucene.Visible = true;
            this.colviseisporucene.VisibleIndex = 12;
            this.colviseisporucene.Width = 164;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 78);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpOd);
            this.panel1.Controls.Add(this.dtpDO);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 101);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1152, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "F9 - excel";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(85, 52);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(136, 20);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(255, 52);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(140, 20);
            this.dtpDO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Od datuma:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(434, 20);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(85, 22);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.operaterBindingSource;
            this.glDobavljac.Properties.DisplayMember = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.glDobavljac.Properties.ValueMember = "op_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(310, 20);
            this.glDobavljac.TabIndex = 1;
            // 
            // operaterBindingSource
            // 
            this.operaterBindingSource.DataMember = "operater";
            this.operaterBindingSource.DataSource = this.komercijalist;
            // 
            // komercijalist
            // 
            this.komercijalist.DataSetName = "Komercijalist";
            this.komercijalist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colop_ID});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ime prezime";
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colop_ID
            // 
            this.colop_ID.FieldName = "op_ID";
            this.colop_ID.Name = "colop_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Komercijalist:";
            // 
            // operaterTableAdapter
            // 
            this.operaterTableAdapter.ClearBeforeFill = true;
            // 
            // pregledNarudzbiPoKomercijalistiTableAdapter
            // 
            this.pregledNarudzbiPoKomercijalistiTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNarudzbiPoKomercijalistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.dgNarudzbe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledNarudzbiPoKomercijalistu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled narudžbi po komercijalisti";
            this.Load += new System.EventHandler(this.frmPregledNarudzbiPoKomercijalistu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledNarudzbiPoKomercijalistu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNarudzbiPoKomercijalistiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbe_po_komercijalisti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgNarudzbe;
        private DevExpress.XtraGrid.Views.Grid.GridView dgNarudzbeZag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colop_ID;
        private System.Windows.Forms.Label label1;
        private Komercijalist komercijalist;
        private System.Windows.Forms.BindingSource operaterBindingSource;
        private KomercijalistTableAdapters.operaterTableAdapter operaterTableAdapter;
        private System.Windows.Forms.BindingSource pregledNarudzbiPoKomercijalistiBindingSource;
        private Narudzbe_po_komercijalisti narudzbe_po_komercijalisti;
        private Narudzbe_po_komercijalistiTableAdapters.pregledNarudzbiPoKomercijalistiTableAdapter pregledNarudzbiPoKomercijalistiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colnaručeno;
        private DevExpress.XtraGrid.Columns.GridColumn colodobreno;
        private DevExpress.XtraGrid.Columns.GridColumn colisporuceno;
        private DevExpress.XtraGrid.Columns.GridColumn colrazlika;
        private DevExpress.XtraGrid.Columns.GridColumn colbrojnarudžbi;
        private DevExpress.XtraGrid.Columns.GridColumn colneizmjenjene;
        private DevExpress.XtraGrid.Columns.GridColumn colneisporucene;
        private DevExpress.XtraGrid.Columns.GridColumn colmanjeisporucene;
        private DevExpress.XtraGrid.Columns.GridColumn colviseisporucene;
        private System.Windows.Forms.Label label2;
    }
}