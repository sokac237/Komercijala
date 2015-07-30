namespace blokerX
{
    partial class frmDodatnePozicije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodatnePozicije));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCjenici = new DevExpress.XtraGrid.GridControl();
            this.dodatnePozicijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatne_pozicije = new blokerX.Dodatne_pozicije();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpoz_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_opis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_odkada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_dokada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colop_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSve = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dodatnePozicijeTableAdapter = new blokerX.Dodatne_pozicijeTableAdapters.DodatnePozicijeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnePozicijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatne_pozicije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 37);
            this.panel2.TabIndex = 17;
            // 
            // dgCjenici
            // 
            this.dgCjenici.DataSource = this.dodatnePozicijeBindingSource;
            this.dgCjenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCjenici.Location = new System.Drawing.Point(0, 120);
            this.dgCjenici.MainView = this.gridView2;
            this.dgCjenici.Name = "dgCjenici";
            this.dgCjenici.Size = new System.Drawing.Size(1079, 441);
            this.dgCjenici.TabIndex = 18;
            this.dgCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgCjenici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCjenici_KeyDown);
            // 
            // dodatnePozicijeBindingSource
            // 
            this.dodatnePozicijeBindingSource.DataMember = "DodatnePozicije";
            this.dodatnePozicijeBindingSource.DataSource = this.dodatne_pozicije;
            // 
            // dodatne_pozicije
            // 
            this.dodatne_pozicije.DataSetName = "Dodatne_pozicije";
            this.dodatne_pozicije.EnforceConstraints = false;
            this.dodatne_pozicije.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colpoz_datumizrade,
            this.colpoz_opis,
            this.colpoz_odkada,
            this.colpoz_dokada,
            this.colpa_naziv,
            this.gridColumn1,
            this.colpa_sifra,
            this.colop_sifra,
            this.colvp_naziv,
            this.colpoz_ID,
            this.gridColumn2});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView2.GridControl = this.dgCjenici;
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
            // colpoz_datumizrade
            // 
            this.colpoz_datumizrade.Caption = "Dat. izrade";
            this.colpoz_datumizrade.FieldName = "poz_datumizrade";
            this.colpoz_datumizrade.Name = "colpoz_datumizrade";
            this.colpoz_datumizrade.Visible = true;
            this.colpoz_datumizrade.VisibleIndex = 5;
            // 
            // colpoz_opis
            // 
            this.colpoz_opis.Caption = "Opis";
            this.colpoz_opis.FieldName = "poz_opis";
            this.colpoz_opis.Name = "colpoz_opis";
            this.colpoz_opis.Visible = true;
            this.colpoz_opis.VisibleIndex = 6;
            this.colpoz_opis.Width = 117;
            // 
            // colpoz_odkada
            // 
            this.colpoz_odkada.Caption = "Od kada";
            this.colpoz_odkada.FieldName = "poz_odkada";
            this.colpoz_odkada.Name = "colpoz_odkada";
            this.colpoz_odkada.Visible = true;
            this.colpoz_odkada.VisibleIndex = 7;
            // 
            // colpoz_dokada
            // 
            this.colpoz_dokada.Caption = "Do kada";
            this.colpoz_dokada.FieldName = "poz_dokada";
            this.colpoz_dokada.Name = "colpoz_dokada";
            this.colpoz_dokada.Visible = true;
            this.colpoz_dokada.VisibleIndex = 8;
            // 
            // colpa_naziv
            // 
            this.colpa_naziv.Caption = "Partner";
            this.colpa_naziv.FieldName = "pa_naziv";
            this.colpa_naziv.Name = "colpa_naziv";
            this.colpa_naziv.Visible = true;
            this.colpa_naziv.VisibleIndex = 4;
            this.colpa_naziv.Width = 185;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Komercijalist";
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 148;
            // 
            // colpa_sifra
            // 
            this.colpa_sifra.Caption = "Šifra partnera";
            this.colpa_sifra.FieldName = "pa_sifra";
            this.colpa_sifra.Name = "colpa_sifra";
            this.colpa_sifra.Visible = true;
            this.colpa_sifra.VisibleIndex = 3;
            this.colpa_sifra.Width = 86;
            // 
            // colop_sifra
            // 
            this.colop_sifra.Caption = "Šifra komercijaliste";
            this.colop_sifra.FieldName = "op_sifra";
            this.colop_sifra.Name = "colop_sifra";
            this.colop_sifra.Visible = true;
            this.colop_sifra.VisibleIndex = 1;
            this.colop_sifra.Width = 110;
            // 
            // colvp_naziv
            // 
            this.colvp_naziv.Caption = "Pozicija";
            this.colvp_naziv.FieldName = "vp_naziv";
            this.colvp_naziv.Name = "colvp_naziv";
            this.colvp_naziv.Visible = true;
            this.colvp_naziv.VisibleIndex = 10;
            this.colvp_naziv.Width = 100;
            // 
            // colpoz_ID
            // 
            this.colpoz_ID.Caption = "Broj";
            this.colpoz_ID.FieldName = "poz_ID";
            this.colpoz_ID.Name = "colpoz_ID";
            this.colpoz_ID.Visible = true;
            this.colpoz_ID.VisibleIndex = 0;
            this.colpoz_ID.Width = 51;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Iznos";
            this.gridColumn2.DisplayFormat.FormatString = "n2";
            this.gridColumn2.FieldName = "sum(pozicijaracun_pozr_iznosracuna)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 53;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSve);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.txtGodina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOsvjezi);
            this.panel1.Controls.Add(this.btnIzlaz);
            this.panel1.Controls.Add(this.btnIzvjestaj);
            this.panel1.Controls.Add(this.btnIzmjena);
            this.panel1.Controls.Add(this.btnNovi);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(266, 19);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(75, 23);
            this.btnSve.TabIndex = 7;
            this.btnSve.Text = "Sve ukupno";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(171, 19);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(73, 21);
            this.txtGodina.MaxLength = 4;
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(78, 20);
            this.txtGodina.TabIndex = 0;
            this.txtGodina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGodina_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Godina:";
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(1068, 21);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(1, 1);
            this.btnOsvjezi.TabIndex = 5;
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(983, 80);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Esc - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(749, 68);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(200, 35);
            this.btnIzvjestaj.TabIndex = 5;
            this.btnIzvjestaj.Text = "F5 - Pregled dogovorenih pozicija\r\nF6 - Pregled za fakture po mjesecima";
            this.btnIzvjestaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(134, 81);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjena.TabIndex = 3;
            this.btnIzmjena.Text = "F4 - izmjena";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(23, 81);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNovi.TabIndex = 2;
            this.btnNovi.Text = "F7 - novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(239, 82);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Briši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dodatnePozicijeTableAdapter
            // 
            this.dodatnePozicijeTableAdapter.ClearBeforeFill = true;
            // 
            // frmDodatnePozicije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 598);
            this.Controls.Add(this.dgCjenici);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDodatnePozicije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatne pozicije";
            this.Load += new System.EventHandler(this.frmDodatnePozicije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodatnePozicije_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnePozicijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatne_pozicije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgCjenici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_datumizrade;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_opis;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_odkada;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_dokada;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colop_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_naziv;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnObrisi;
        public Dodatne_pozicije dodatne_pozicije;
        public System.Windows.Forms.BindingSource dodatnePozicijeBindingSource;
        public Dodatne_pozicijeTableAdapters.DodatnePozicijeTableAdapter dodatnePozicijeTableAdapter;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSve;
    }
}