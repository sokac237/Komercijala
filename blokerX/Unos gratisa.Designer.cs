namespace blokerX
{
    partial class frmUnosGratisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosGratisa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNezaduzene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZapisnik = new System.Windows.Forms.Button();
            this.btnDodajKalkul = new System.Windows.Forms.Button();
            this.dgGratis = new DevExpress.XtraGrid.GridControl();
            this.gratisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gratis1 = new blokerX.Gratis();
            this.gratis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgr_zavrsen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_zapisnik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_odobrenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_ImePoslovodje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_kolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_nabavnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_nabavnavrijednost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_prodajnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_prodajnavrijednost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colufaifa_uf_broj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_vrijemeIzmjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gratisTableAdapter = new blokerX.GratisTableAdapters.gratisTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGratis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNezaduzene);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnZapisnik);
            this.panel1.Controls.Add(this.btnDodajKalkul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 69);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1140, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNezaduzene
            // 
            this.btnNezaduzene.Location = new System.Drawing.Point(548, 24);
            this.btnNezaduzene.Name = "btnNezaduzene";
            this.btnNezaduzene.Size = new System.Drawing.Size(155, 23);
            this.btnNezaduzene.TabIndex = 3;
            this.btnNezaduzene.Text = "Nezadužene kalkulacije";
            this.btnNezaduzene.UseVisualStyleBackColor = true;
            this.btnNezaduzene.Click += new System.EventHandler(this.btnNezaduzene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F4 - izmjena zapisnika";
            // 
            // btnZapisnik
            // 
            this.btnZapisnik.Location = new System.Drawing.Point(178, 24);
            this.btnZapisnik.Name = "btnZapisnik";
            this.btnZapisnik.Size = new System.Drawing.Size(117, 23);
            this.btnZapisnik.TabIndex = 1;
            this.btnZapisnik.Text = "Dodaj zapisnik";
            this.btnZapisnik.UseVisualStyleBackColor = true;
            this.btnZapisnik.Click += new System.EventHandler(this.btnZapisnik_Click);
            // 
            // btnDodajKalkul
            // 
            this.btnDodajKalkul.Location = new System.Drawing.Point(40, 24);
            this.btnDodajKalkul.Name = "btnDodajKalkul";
            this.btnDodajKalkul.Size = new System.Drawing.Size(117, 23);
            this.btnDodajKalkul.TabIndex = 0;
            this.btnDodajKalkul.Text = "Dodaj s kalkulacije";
            this.btnDodajKalkul.UseVisualStyleBackColor = true;
            this.btnDodajKalkul.Click += new System.EventHandler(this.btnDodajKalkul_Click);
            // 
            // dgGratis
            // 
            this.dgGratis.DataSource = this.gratisBindingSource;
            this.dgGratis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGratis.Location = new System.Drawing.Point(0, 69);
            this.dgGratis.MainView = this.gratis;
            this.dgGratis.Name = "dgGratis";
            this.dgGratis.Size = new System.Drawing.Size(1235, 535);
            this.dgGratis.TabIndex = 11;
            this.dgGratis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gratis});
            this.dgGratis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCjenici_KeyDown);
            // 
            // gratisBindingSource
            // 
            this.gratisBindingSource.DataMember = "gratis";
            this.gratisBindingSource.DataSource = this.gratis1;
            // 
            // gratis1
            // 
            this.gratis1.DataSetName = "Gratis";
            this.gratis1.EnforceConstraints = false;
            this.gratis1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gratis
            // 
            this.gratis.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gratis.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gratis.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gratis.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gratis.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gratis.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.Empty.Options.UseBackColor = true;
            this.gratis.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.EvenRow.Options.UseBackColor = true;
            this.gratis.Appearance.EvenRow.Options.UseForeColor = true;
            this.gratis.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gratis.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gratis.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gratis.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gratis.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gratis.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gratis.Appearance.FixedLine.Options.UseBackColor = true;
            this.gratis.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gratis.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gratis.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gratis.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gratis.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupButton.Options.UseBackColor = true;
            this.gratis.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupButton.Options.UseForeColor = true;
            this.gratis.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gratis.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gratis.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gratis.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gratis.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gratis.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupRow.Options.UseBackColor = true;
            this.gratis.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupRow.Options.UseFont = true;
            this.gratis.Appearance.GroupRow.Options.UseForeColor = true;
            this.gratis.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gratis.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gratis.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gratis.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gratis.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gratis.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gratis.Appearance.HorzLine.Options.UseBackColor = true;
            this.gratis.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.OddRow.Options.UseBackColor = true;
            this.gratis.Appearance.OddRow.Options.UseForeColor = true;
            this.gratis.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gratis.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gratis.Appearance.Preview.Options.UseBackColor = true;
            this.gratis.Appearance.Preview.Options.UseForeColor = true;
            this.gratis.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.Row.Options.UseBackColor = true;
            this.gratis.Appearance.Row.Options.UseForeColor = true;
            this.gratis.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gratis.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gratis.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gratis.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gratis.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gratis.Appearance.VertLine.Options.UseBackColor = true;
            this.gratis.ColumnPanelRowHeight = 50;
            this.gratis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgr_zavrsen,
            this.colpo_sifra,
            this.colpo_naziv,
            this.colPA_NAZIV,
            this.colgr_datum,
            this.colgr_zapisnik,
            this.colgr_odobrenje,
            this.colpo_ImePoslovodje,
            this.colgr_kolicina,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colgr_nabavnacijena,
            this.colgr_nabavnavrijednost,
            this.colgr_prodajnacijena,
            this.colgr_prodajnavrijednost,
            this.colufaifa_uf_broj,
            this.colgr_napomena,
            this.colgr_ID,
            this.colgr_vrijemeIzmjene,
            this.gridColumn1});
            this.gratis.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gratis.GridControl = this.dgGratis;
            this.gratis.Name = "gratis";
            this.gratis.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gratis.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gratis.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gratis.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gratis.OptionsBehavior.Editable = false;
            this.gratis.OptionsCustomization.AllowColumnMoving = false;
            this.gratis.OptionsCustomization.AllowFilter = false;
            this.gratis.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gratis.OptionsSelection.MultiSelect = true;
            this.gratis.OptionsView.ColumnAutoWidth = false;
            this.gratis.OptionsView.EnableAppearanceEvenRow = true;
            this.gratis.OptionsView.EnableAppearanceOddRow = true;
            this.gratis.OptionsView.ShowAutoFilterRow = true;
            this.gratis.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gratis.OptionsView.ShowGroupPanel = false;
            this.gratis.OptionsView.ShowIndicator = false;
            this.gratis.PaintStyleName = "WindowsXP";
            this.gratis.SynchronizeClones = false;
            // 
            // colgr_zavrsen
            // 
            this.colgr_zavrsen.Caption = "Zaključen";
            this.colgr_zavrsen.FieldName = "gr_zavrsen";
            this.colgr_zavrsen.Name = "colgr_zavrsen";
            this.colgr_zavrsen.Visible = true;
            this.colgr_zavrsen.VisibleIndex = 0;
            this.colgr_zavrsen.Width = 64;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šif posl.";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 1;
            this.colpo_sifra.Width = 61;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Poslovnica";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 2;
            this.colpo_naziv.Width = 133;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Partner";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 3;
            this.colPA_NAZIV.Width = 184;
            // 
            // colgr_datum
            // 
            this.colgr_datum.Caption = "Datum";
            this.colgr_datum.FieldName = "gr_datum";
            this.colgr_datum.Name = "colgr_datum";
            this.colgr_datum.Visible = true;
            this.colgr_datum.VisibleIndex = 4;
            this.colgr_datum.Width = 65;
            // 
            // colgr_zapisnik
            // 
            this.colgr_zapisnik.Caption = "Zapisnik";
            this.colgr_zapisnik.FieldName = "gr_zapisnik";
            this.colgr_zapisnik.Name = "colgr_zapisnik";
            this.colgr_zapisnik.Visible = true;
            this.colgr_zapisnik.VisibleIndex = 5;
            this.colgr_zapisnik.Width = 98;
            // 
            // colgr_odobrenje
            // 
            this.colgr_odobrenje.Caption = "Odobrenje";
            this.colgr_odobrenje.FieldName = "gr_odobrenje";
            this.colgr_odobrenje.Name = "colgr_odobrenje";
            this.colgr_odobrenje.Visible = true;
            this.colgr_odobrenje.VisibleIndex = 6;
            this.colgr_odobrenje.Width = 107;
            // 
            // colpo_ImePoslovodje
            // 
            this.colpo_ImePoslovodje.Caption = "Poslovođa";
            this.colpo_ImePoslovodje.FieldName = "po_ImePoslovodje";
            this.colpo_ImePoslovodje.Name = "colpo_ImePoslovodje";
            this.colpo_ImePoslovodje.Visible = true;
            this.colpo_ImePoslovodje.VisibleIndex = 7;
            this.colpo_ImePoslovodje.Width = 131;
            // 
            // colgr_kolicina
            // 
            this.colgr_kolicina.Caption = "Količina";
            this.colgr_kolicina.FieldName = "gr_kolicina";
            this.colgr_kolicina.Name = "colgr_kolicina";
            this.colgr_kolicina.Visible = true;
            this.colgr_kolicina.VisibleIndex = 8;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 9;
            this.colAR_SIFRA.Width = 61;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 10;
            this.colAR_NAZIV.Width = 139;
            // 
            // colgr_nabavnacijena
            // 
            this.colgr_nabavnacijena.Caption = "Nabavna cijena";
            this.colgr_nabavnacijena.FieldName = "gr_nabavnacijena";
            this.colgr_nabavnacijena.Name = "colgr_nabavnacijena";
            this.colgr_nabavnacijena.Visible = true;
            this.colgr_nabavnacijena.VisibleIndex = 11;
            this.colgr_nabavnacijena.Width = 65;
            // 
            // colgr_nabavnavrijednost
            // 
            this.colgr_nabavnavrijednost.Caption = "Nabavna vrijednost";
            this.colgr_nabavnavrijednost.FieldName = "gr_nabavnavrijednost";
            this.colgr_nabavnavrijednost.Name = "colgr_nabavnavrijednost";
            this.colgr_nabavnavrijednost.Visible = true;
            this.colgr_nabavnavrijednost.VisibleIndex = 12;
            this.colgr_nabavnavrijednost.Width = 66;
            // 
            // colgr_prodajnacijena
            // 
            this.colgr_prodajnacijena.Caption = "Prodajna cijena";
            this.colgr_prodajnacijena.FieldName = "gr_prodajnacijena";
            this.colgr_prodajnacijena.Name = "colgr_prodajnacijena";
            this.colgr_prodajnacijena.Visible = true;
            this.colgr_prodajnacijena.VisibleIndex = 13;
            this.colgr_prodajnacijena.Width = 63;
            // 
            // colgr_prodajnavrijednost
            // 
            this.colgr_prodajnavrijednost.Caption = "Prodajna vrijednost";
            this.colgr_prodajnavrijednost.FieldName = "gr_prodajnavrijednost";
            this.colgr_prodajnavrijednost.Name = "colgr_prodajnavrijednost";
            this.colgr_prodajnavrijednost.Visible = true;
            this.colgr_prodajnavrijednost.VisibleIndex = 14;
            this.colgr_prodajnavrijednost.Width = 68;
            // 
            // colufaifa_uf_broj
            // 
            this.colufaifa_uf_broj.Caption = "Kalkulacija";
            this.colufaifa_uf_broj.FieldName = "ufaifa_uf_broj";
            this.colufaifa_uf_broj.Name = "colufaifa_uf_broj";
            this.colufaifa_uf_broj.Visible = true;
            this.colufaifa_uf_broj.VisibleIndex = 15;
            // 
            // colgr_napomena
            // 
            this.colgr_napomena.Caption = "Napomena";
            this.colgr_napomena.FieldName = "gr_napomena";
            this.colgr_napomena.Name = "colgr_napomena";
            this.colgr_napomena.Visible = true;
            this.colgr_napomena.VisibleIndex = 16;
            this.colgr_napomena.Width = 172;
            // 
            // colgr_ID
            // 
            this.colgr_ID.FieldName = "gr_ID";
            this.colgr_ID.Name = "colgr_ID";
            // 
            // colgr_vrijemeIzmjene
            // 
            this.colgr_vrijemeIzmjene.Caption = "Vrijeme izmjene";
            this.colgr_vrijemeIzmjene.FieldName = "gr_vrijemeIzmjene";
            this.colgr_vrijemeIzmjene.Name = "colgr_vrijemeIzmjene";
            this.colgr_vrijemeIzmjene.Visible = true;
            this.colgr_vrijemeIzmjene.VisibleIndex = 18;
            this.colgr_vrijemeIzmjene.Width = 84;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater izmijenio";
            this.gridColumn1.FieldName = "concat(operater_op_ime, \' \' , operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 17;
            this.gridColumn1.Width = 97;
            // 
            // gratisTableAdapter
            // 
            this.gratisTableAdapter.ClearBeforeFill = true;
            // 
            // frmUnosGratisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 604);
            this.Controls.Add(this.dgGratis);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUnosGratisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos gratisa";
            this.Load += new System.EventHandler(this.frmUnosGratisa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGratis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNezaduzene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZapisnik;
        private System.Windows.Forms.Button btnDodajKalkul;
        private DevExpress.XtraGrid.GridControl dgGratis;
        private DevExpress.XtraGrid.Views.Grid.GridView gratis;
        private Gratis gratis1;
        private System.Windows.Forms.BindingSource gratisBindingSource;
        private GratisTableAdapters.gratisTableAdapter gratisTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_zavrsen;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_datum;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_zapisnik;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_odobrenje;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_ImePoslovodje;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_kolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_nabavnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_nabavnavrijednost;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_prodajnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_prodajnavrijednost;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_napomena;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_ID;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colufaifa_uf_broj;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_vrijemeIzmjene;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}