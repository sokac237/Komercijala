namespace blokerX
{
    partial class frmPregledPozicijaZaTrgovinu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledPozicijaZaTrgovinu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnica = new blokerX.Poslovnica();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPozicije = new DevExpress.XtraGrid.GridControl();
            this.dodatneTrgovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatnePozicijeZaTrgovinu = new blokerX.DodatnePozicijeZaTrgovinu();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpozicija_poz_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_PO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_odkada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_dokada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_opis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpoz_opis2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poslovnicaTableAdapter = new blokerX.PoslovnicaTableAdapters.poslovnicaTableAdapter();
            this.dodatneTrgovinaTableAdapter = new blokerX.DodatnePozicijeZaTrgovinuTableAdapters.DodatneTrgovinaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPozicije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatneTrgovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnePozicijeZaTrgovinu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.glPoslovnica);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIzvjestaj);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.dtpDatumDO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDatumOD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 99);
            this.panel1.TabIndex = 0;
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(100, 19);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ImmediatePopup = true;
            this.glPoslovnica.Properties.NullText = "";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Size = new System.Drawing.Size(298, 20);
            this.glPoslovnica.TabIndex = 0;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.poslovnica;
            // 
            // poslovnica
            // 
            this.poslovnica.DataSetName = "Poslovnica";
            this.poslovnica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(951, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "F9 - excel";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(524, 55);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 4;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(434, 55);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.Location = new System.Drawing.Point(284, 57);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(127, 20);
            this.dtpDatumDO.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "do:";
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.Location = new System.Drawing.Point(100, 57);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(127, 20);
            this.dtpDatumOD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razdoblje od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poslovnica:";
            // 
            // dgPozicije
            // 
            this.dgPozicije.DataSource = this.dodatneTrgovinaBindingSource;
            this.dgPozicije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPozicije.Location = new System.Drawing.Point(0, 99);
            this.dgPozicije.MainView = this.gridView2;
            this.dgPozicije.Name = "dgPozicije";
            this.dgPozicije.Size = new System.Drawing.Size(1038, 446);
            this.dgPozicije.TabIndex = 19;
            this.dgPozicije.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dodatneTrgovinaBindingSource
            // 
            this.dodatneTrgovinaBindingSource.DataMember = "DodatneTrgovina";
            this.dodatneTrgovinaBindingSource.DataSource = this.dodatnePozicijeZaTrgovinu;
            // 
            // dodatnePozicijeZaTrgovinu
            // 
            this.dodatnePozicijeZaTrgovinu.DataSetName = "DodatnePozicijeZaTrgovinu";
            this.dodatnePozicijeZaTrgovinu.EnforceConstraints = false;
            this.dodatnePozicijeZaTrgovinu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colpozicija_poz_ID,
            this.colposlovnica_PO_ID,
            this.colpo_sifra,
            this.colpo_naziv,
            this.colpoz_odkada,
            this.colpoz_dokada,
            this.colpoz_opis,
            this.colpoz_opis2,
            this.gridColumn1,
            this.colvp_naziv,
            this.colpa_sifra,
            this.colpa_naziv});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView2.GridControl = this.dgPozicije;
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
            // colpozicija_poz_ID
            // 
            this.colpozicija_poz_ID.Caption = "Broj pozicije";
            this.colpozicija_poz_ID.FieldName = "pozicija_poz_ID";
            this.colpozicija_poz_ID.Name = "colpozicija_poz_ID";
            this.colpozicija_poz_ID.Visible = true;
            this.colpozicija_poz_ID.VisibleIndex = 0;
            // 
            // colposlovnica_PO_ID
            // 
            this.colposlovnica_PO_ID.FieldName = "poslovnica_PO_ID";
            this.colposlovnica_PO_ID.Name = "colposlovnica_PO_ID";
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            // 
            // colpoz_odkada
            // 
            this.colpoz_odkada.Caption = "Od kada";
            this.colpoz_odkada.FieldName = "poz_odkada";
            this.colpoz_odkada.Name = "colpoz_odkada";
            this.colpoz_odkada.Visible = true;
            this.colpoz_odkada.VisibleIndex = 3;
            // 
            // colpoz_dokada
            // 
            this.colpoz_dokada.Caption = "Do kada";
            this.colpoz_dokada.FieldName = "poz_dokada";
            this.colpoz_dokada.Name = "colpoz_dokada";
            this.colpoz_dokada.Visible = true;
            this.colpoz_dokada.VisibleIndex = 4;
            // 
            // colpoz_opis
            // 
            this.colpoz_opis.Caption = "Opis";
            this.colpoz_opis.FieldName = "poz_opis";
            this.colpoz_opis.Name = "colpoz_opis";
            this.colpoz_opis.Visible = true;
            this.colpoz_opis.VisibleIndex = 6;
            this.colpoz_opis.Width = 158;
            // 
            // colpoz_opis2
            // 
            this.colpoz_opis2.Caption = "Opis 2";
            this.colpoz_opis2.FieldName = "poz_opis2";
            this.colpoz_opis2.Name = "colpoz_opis2";
            this.colpoz_opis2.Visible = true;
            this.colpoz_opis2.VisibleIndex = 7;
            this.colpoz_opis2.Width = 175;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Komercijalist";
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 128;
            // 
            // colvp_naziv
            // 
            this.colvp_naziv.Caption = "Pozicija";
            this.colvp_naziv.FieldName = "vp_naziv";
            this.colvp_naziv.Name = "colvp_naziv";
            this.colvp_naziv.Visible = true;
            this.colvp_naziv.VisibleIndex = 5;
            this.colvp_naziv.Width = 140;
            // 
            // colpa_sifra
            // 
            this.colpa_sifra.Caption = "Šifra partner";
            this.colpa_sifra.FieldName = "pa_sifra";
            this.colpa_sifra.Name = "colpa_sifra";
            this.colpa_sifra.Visible = true;
            this.colpa_sifra.VisibleIndex = 1;
            this.colpa_sifra.Width = 80;
            // 
            // colpa_naziv
            // 
            this.colpa_naziv.Caption = "Naziv  partnera";
            this.colpa_naziv.FieldName = "pa_naziv";
            this.colpa_naziv.Name = "colpa_naziv";
            this.colpa_naziv.Visible = true;
            this.colpa_naziv.VisibleIndex = 2;
            this.colpa_naziv.Width = 174;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // dodatneTrgovinaTableAdapter
            // 
            this.dodatneTrgovinaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledPozicijaZaTrgovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 545);
            this.Controls.Add(this.dgPozicije);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledPozicijaZaTrgovinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled pozicija za trgovinu";
            this.Load += new System.EventHandler(this.frmPregledPozicijaZaTrgovinu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledPozicijaZaTrgovinu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPozicije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatneTrgovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatnePozicijeZaTrgovinu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgPozicije;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.Label label2;
        private Poslovnica poslovnica;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovnicaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private System.Windows.Forms.BindingSource dodatneTrgovinaBindingSource;
        private DodatnePozicijeZaTrgovinu dodatnePozicijeZaTrgovinu;
        private DevExpress.XtraGrid.Columns.GridColumn colpozicija_poz_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_PO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_odkada;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_dokada;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_opis;
        private DevExpress.XtraGrid.Columns.GridColumn colpoz_opis2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv;
        private DodatnePozicijeZaTrgovinuTableAdapters.DodatneTrgovinaTableAdapter dodatneTrgovinaTableAdapter;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
    }
}