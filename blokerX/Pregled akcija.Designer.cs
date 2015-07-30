namespace blokerX
{
    partial class frmPregledAkcija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledAkcija));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAkcije = new DevExpress.XtraGrid.GridControl();
            this.akcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_akcija = new blokerX.Pregled_akcija();
            this.dgAkcija = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKC_BROJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_DATUMOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_DATUMDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_OPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_AKTIVNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_POPUST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_VEZANA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_SIFRAVEZANA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colakc_datumizmjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.akcijeTableAdapter = new blokerX.Pregled_akcijaTableAdapters.AkcijeTableAdapter();
            this.dgPoslani = new DevExpress.XtraGrid.GridControl();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgPoslano = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKCTRG_DATUM_SLANJA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKCTRG_USPJELO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poslovnicaTableAdapter = new blokerX.Pregled_akcijaTableAdapters.poslovnicaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnIzlaz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 56);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(247, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "F9 - excel";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1007, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1, 1);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(768, 17);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "ESC - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(125, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "F4 - stavke akcije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "F7 - nova akcija";
            // 
            // dgAkcije
            // 
            this.dgAkcije.DataSource = this.akcijeBindingSource;
            this.dgAkcije.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgAkcije.Location = new System.Drawing.Point(0, 56);
            this.dgAkcije.MainView = this.dgAkcija;
            this.dgAkcije.Name = "dgAkcije";
            this.dgAkcije.Size = new System.Drawing.Size(1005, 375);
            this.dgAkcije.TabIndex = 0;
            this.dgAkcije.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgAkcija});
            this.dgAkcije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgAkcije_KeyDown);
            // 
            // akcijeBindingSource
            // 
            this.akcijeBindingSource.DataMember = "Akcije";
            this.akcijeBindingSource.DataSource = this.pregled_akcija;
            // 
            // pregled_akcija
            // 
            this.pregled_akcija.DataSetName = "Pregled_akcija";
            this.pregled_akcija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgAkcija
            // 
            this.dgAkcija.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcija.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcija.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgAkcija.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgAkcija.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgAkcija.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.Empty.Options.UseBackColor = true;
            this.dgAkcija.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcija.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcija.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgAkcija.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcija.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgAkcija.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgAkcija.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgAkcija.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgAkcija.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgAkcija.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcija.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcija.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgAkcija.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgAkcija.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgAkcija.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgAkcija.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgAkcija.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcija.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgAkcija.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgAkcija.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcija.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgAkcija.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.GroupRow.Options.UseFont = true;
            this.dgAkcija.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcija.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcija.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcija.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgAkcija.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgAkcija.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgAkcija.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgAkcija.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgAkcija.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgAkcija.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcija.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgAkcija.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgAkcija.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.OddRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.OddRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgAkcija.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgAkcija.Appearance.Preview.Options.UseBackColor = true;
            this.dgAkcija.Appearance.Preview.Options.UseForeColor = true;
            this.dgAkcija.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.Row.Options.UseBackColor = true;
            this.dgAkcija.Appearance.Row.Options.UseForeColor = true;
            this.dgAkcija.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgAkcija.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgAkcija.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgAkcija.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcija.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgAkcija.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgAkcija.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgAkcija.Appearance.VertLine.Options.UseBackColor = true;
            this.dgAkcija.ColumnPanelRowHeight = 50;
            this.dgAkcija.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKC_BROJ,
            this.colAKC_DATUMOD,
            this.colAKC_DATUMDO,
            this.colAKC_OPIS,
            this.colAKC_AKTIVNA,
            this.colAKC_POPUST,
            this.colAKC_VEZANA,
            this.colPOK_SIFRAVEZANA,
            this.colPOK_SIFRA,
            this.colPOK_NAZIV,
            this.coloperater,
            this.colakc_datumizmjene});
            this.dgAkcija.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgAkcija.GridControl = this.dgAkcije;
            this.dgAkcija.Name = "dgAkcija";
            this.dgAkcija.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgAkcija.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgAkcija.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgAkcija.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgAkcija.OptionsBehavior.Editable = false;
            this.dgAkcija.OptionsCustomization.AllowColumnMoving = false;
            this.dgAkcija.OptionsCustomization.AllowFilter = false;
            this.dgAkcija.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgAkcija.OptionsSelection.MultiSelect = true;
            this.dgAkcija.OptionsView.ColumnAutoWidth = false;
            this.dgAkcija.OptionsView.EnableAppearanceEvenRow = true;
            this.dgAkcija.OptionsView.EnableAppearanceOddRow = true;
            this.dgAkcija.OptionsView.ShowAutoFilterRow = true;
            this.dgAkcija.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgAkcija.OptionsView.ShowGroupPanel = false;
            this.dgAkcija.OptionsView.ShowIndicator = false;
            this.dgAkcija.PaintStyleName = "WindowsXP";
            this.dgAkcija.SynchronizeClones = false;
            // 
            // colAKC_BROJ
            // 
            this.colAKC_BROJ.Caption = "Broj akcije";
            this.colAKC_BROJ.FieldName = "AKC_BROJ";
            this.colAKC_BROJ.Name = "colAKC_BROJ";
            this.colAKC_BROJ.Visible = true;
            this.colAKC_BROJ.VisibleIndex = 0;
            // 
            // colAKC_DATUMOD
            // 
            this.colAKC_DATUMOD.Caption = "Datum od";
            this.colAKC_DATUMOD.FieldName = "AKC_DATUMOD";
            this.colAKC_DATUMOD.Name = "colAKC_DATUMOD";
            this.colAKC_DATUMOD.Visible = true;
            this.colAKC_DATUMOD.VisibleIndex = 1;
            // 
            // colAKC_DATUMDO
            // 
            this.colAKC_DATUMDO.Caption = "Datum do";
            this.colAKC_DATUMDO.FieldName = "AKC_DATUMDO";
            this.colAKC_DATUMDO.Name = "colAKC_DATUMDO";
            this.colAKC_DATUMDO.Visible = true;
            this.colAKC_DATUMDO.VisibleIndex = 2;
            // 
            // colAKC_OPIS
            // 
            this.colAKC_OPIS.Caption = "Opis";
            this.colAKC_OPIS.FieldName = "AKC_OPIS";
            this.colAKC_OPIS.Name = "colAKC_OPIS";
            this.colAKC_OPIS.Visible = true;
            this.colAKC_OPIS.VisibleIndex = 3;
            // 
            // colAKC_AKTIVNA
            // 
            this.colAKC_AKTIVNA.Caption = "Aktivna";
            this.colAKC_AKTIVNA.FieldName = "AKC_AKTIVNA";
            this.colAKC_AKTIVNA.Name = "colAKC_AKTIVNA";
            this.colAKC_AKTIVNA.Visible = true;
            this.colAKC_AKTIVNA.VisibleIndex = 4;
            // 
            // colAKC_POPUST
            // 
            this.colAKC_POPUST.Caption = "Popust";
            this.colAKC_POPUST.FieldName = "AKC_POPUST";
            this.colAKC_POPUST.Name = "colAKC_POPUST";
            this.colAKC_POPUST.Visible = true;
            this.colAKC_POPUST.VisibleIndex = 5;
            // 
            // colAKC_VEZANA
            // 
            this.colAKC_VEZANA.Caption = "Akcija vezana";
            this.colAKC_VEZANA.FieldName = "AKC_VEZANA";
            this.colAKC_VEZANA.Name = "colAKC_VEZANA";
            this.colAKC_VEZANA.Visible = true;
            this.colAKC_VEZANA.VisibleIndex = 6;
            this.colAKC_VEZANA.Width = 78;
            // 
            // colPOK_SIFRAVEZANA
            // 
            this.colPOK_SIFRAVEZANA.Caption = "Šifra kategorije vezane akcije";
            this.colPOK_SIFRAVEZANA.FieldName = "POK_SIFRAVEZANA";
            this.colPOK_SIFRAVEZANA.Name = "colPOK_SIFRAVEZANA";
            this.colPOK_SIFRAVEZANA.Visible = true;
            this.colPOK_SIFRAVEZANA.VisibleIndex = 7;
            this.colPOK_SIFRAVEZANA.Width = 97;
            // 
            // colPOK_SIFRA
            // 
            this.colPOK_SIFRA.Caption = "Kategorija akcije";
            this.colPOK_SIFRA.FieldName = "POK_SIFRA";
            this.colPOK_SIFRA.Name = "colPOK_SIFRA";
            this.colPOK_SIFRA.Visible = true;
            this.colPOK_SIFRA.VisibleIndex = 8;
            this.colPOK_SIFRA.Width = 97;
            // 
            // colPOK_NAZIV
            // 
            this.colPOK_NAZIV.Caption = "Naziv kategorije";
            this.colPOK_NAZIV.FieldName = "POK_NAZIV";
            this.colPOK_NAZIV.Name = "colPOK_NAZIV";
            this.colPOK_NAZIV.Visible = true;
            this.colPOK_NAZIV.VisibleIndex = 9;
            this.colPOK_NAZIV.Width = 202;
            // 
            // coloperater
            // 
            this.coloperater.Caption = "Operater";
            this.coloperater.FieldName = "operater";
            this.coloperater.Name = "coloperater";
            this.coloperater.Visible = true;
            this.coloperater.VisibleIndex = 10;
            this.coloperater.Width = 245;
            // 
            // colakc_datumizmjene
            // 
            this.colakc_datumizmjene.Caption = "Izmjena";
            this.colakc_datumizmjene.FieldName = "akc_datumizmjene";
            this.colakc_datumizmjene.Name = "colakc_datumizmjene";
            this.colakc_datumizmjene.Visible = true;
            this.colakc_datumizmjene.VisibleIndex = 11;
            this.colakc_datumizmjene.Width = 74;
            // 
            // akcijeTableAdapter
            // 
            this.akcijeTableAdapter.ClearBeforeFill = true;
            // 
            // dgPoslani
            // 
            this.dgPoslani.DataSource = this.poslovnicaBindingSource;
            this.dgPoslani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPoslani.Location = new System.Drawing.Point(0, 431);
            this.dgPoslani.MainView = this.dgPoslano;
            this.dgPoslani.Name = "dgPoslani";
            this.dgPoslani.Size = new System.Drawing.Size(1005, 182);
            this.dgPoslani.TabIndex = 1;
            this.dgPoslani.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgPoslano});
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.pregled_akcija;
            // 
            // dgPoslano
            // 
            this.dgPoslano.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslano.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslano.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgPoslano.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgPoslano.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgPoslano.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.Empty.Options.UseBackColor = true;
            this.dgPoslano.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslano.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslano.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgPoslano.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslano.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgPoslano.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgPoslano.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgPoslano.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgPoslano.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgPoslano.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslano.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslano.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgPoslano.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgPoslano.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgPoslano.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgPoslano.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgPoslano.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslano.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgPoslano.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgPoslano.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslano.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPoslano.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.GroupRow.Options.UseFont = true;
            this.dgPoslano.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslano.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslano.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslano.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgPoslano.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgPoslano.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgPoslano.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgPoslano.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgPoslano.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgPoslano.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslano.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPoslano.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgPoslano.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.OddRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.OddRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgPoslano.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgPoslano.Appearance.Preview.Options.UseBackColor = true;
            this.dgPoslano.Appearance.Preview.Options.UseForeColor = true;
            this.dgPoslano.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.Row.Options.UseBackColor = true;
            this.dgPoslano.Appearance.Row.Options.UseForeColor = true;
            this.dgPoslano.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgPoslano.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgPoslano.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgPoslano.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslano.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgPoslano.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgPoslano.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPoslano.Appearance.VertLine.Options.UseBackColor = true;
            this.dgPoslano.ColumnPanelRowHeight = 50;
            this.dgPoslano.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpo_naziv,
            this.colPO_SIFRA,
            this.colAKCTRG_DATUM_SLANJA,
            this.colAKCTRG_USPJELO});
            this.dgPoslano.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgPoslano.GridControl = this.dgPoslani;
            this.dgPoslano.Name = "dgPoslano";
            this.dgPoslano.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPoslano.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPoslano.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgPoslano.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgPoslano.OptionsBehavior.Editable = false;
            this.dgPoslano.OptionsCustomization.AllowColumnMoving = false;
            this.dgPoslano.OptionsCustomization.AllowFilter = false;
            this.dgPoslano.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgPoslano.OptionsSelection.MultiSelect = true;
            this.dgPoslano.OptionsView.ColumnAutoWidth = false;
            this.dgPoslano.OptionsView.EnableAppearanceEvenRow = true;
            this.dgPoslano.OptionsView.EnableAppearanceOddRow = true;
            this.dgPoslano.OptionsView.ShowAutoFilterRow = true;
            this.dgPoslano.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgPoslano.OptionsView.ShowGroupPanel = false;
            this.dgPoslano.OptionsView.ShowIndicator = false;
            this.dgPoslano.PaintStyleName = "WindowsXP";
            this.dgPoslano.SynchronizeClones = false;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv poslovnice";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 0;
            this.colpo_naziv.Width = 250;
            // 
            // colPO_SIFRA
            // 
            this.colPO_SIFRA.Caption = "Šifra poslovnice";
            this.colPO_SIFRA.FieldName = "PO_SIFRA";
            this.colPO_SIFRA.Name = "colPO_SIFRA";
            this.colPO_SIFRA.Visible = true;
            this.colPO_SIFRA.VisibleIndex = 1;
            // 
            // colAKCTRG_DATUM_SLANJA
            // 
            this.colAKCTRG_DATUM_SLANJA.Caption = "Datum slanja";
            this.colAKCTRG_DATUM_SLANJA.FieldName = "AKCTRG_DATUM_SLANJA";
            this.colAKCTRG_DATUM_SLANJA.Name = "colAKCTRG_DATUM_SLANJA";
            this.colAKCTRG_DATUM_SLANJA.Visible = true;
            this.colAKCTRG_DATUM_SLANJA.VisibleIndex = 2;
            this.colAKCTRG_DATUM_SLANJA.Width = 180;
            // 
            // colAKCTRG_USPJELO
            // 
            this.colAKCTRG_USPJELO.Caption = "Uspjelo slanje";
            this.colAKCTRG_USPJELO.FieldName = "AKCTRG_USPJELO";
            this.colAKCTRG_USPJELO.Name = "colAKCTRG_USPJELO";
            this.colAKCTRG_USPJELO.Visible = true;
            this.colAKCTRG_USPJELO.VisibleIndex = 3;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledAkcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 613);
            this.Controls.Add(this.dgPoslani);
            this.Controls.Add(this.dgAkcije);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledAkcija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled akcija";
            this.Load += new System.EventHandler(this.frmPregledAkcija_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledAkcija_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgAkcije;
        private DevExpress.XtraGrid.Views.Grid.GridView dgAkcija;
        private Pregled_akcija pregled_akcija;
        private System.Windows.Forms.BindingSource akcijeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_BROJ;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_DATUMOD;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_DATUMDO;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_OPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_AKTIVNA;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_POPUST;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_VEZANA;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_SIFRAVEZANA;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_NAZIV;
        private Pregled_akcijaTableAdapters.AkcijeTableAdapter akcijeTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraGrid.GridControl dgPoslani;
        private DevExpress.XtraGrid.Views.Grid.GridView dgPoslano;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colPO_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAKCTRG_DATUM_SLANJA;
        private DevExpress.XtraGrid.Columns.GridColumn colAKCTRG_USPJELO;
        private Pregled_akcijaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_datumizmjene;
        private System.Windows.Forms.Label label8;
    }
}