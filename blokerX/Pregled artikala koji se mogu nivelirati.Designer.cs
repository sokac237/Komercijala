namespace blokerX
{
    partial class FrmPregledArtikalaNivelacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledArtikalaNivelacija));
            this.dgArtikl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldnz_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_OP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_PO_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_odkada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_dokada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_opis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colop_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgArtikli = new DevExpress.XtraGrid.GridControl();
            this.artikliNiveliranjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliKojiSeMoguNivelirati = new blokerX.ArtikliKojiSeMoguNivelirati();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgPomocni = new DevExpress.XtraGrid.GridControl();
            this.pregledNivelacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgPomoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldnz_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_opis1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_odkada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldnz_dokada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldn_preporucenacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.artikliNiveliranjeTableAdapter = new blokerX.ArtikliKojiSeMoguNiveliratiTableAdapters.ArtikliNiveliranjeTableAdapter();
            this.pregledNivelacijeTableAdapter = new blokerX.ArtikliKojiSeMoguNiveliratiTableAdapters.pregledNivelacijeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliNiveliranjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliKojiSeMoguNivelirati)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPomocni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNivelacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPomoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArtikl
            // 
            this.dgArtikl.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikl.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikl.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgArtikl.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgArtikl.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgArtikl.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.Empty.Options.UseBackColor = true;
            this.dgArtikl.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikl.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikl.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgArtikl.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikl.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgArtikl.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgArtikl.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgArtikl.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgArtikl.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgArtikl.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikl.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikl.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgArtikl.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgArtikl.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgArtikl.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgArtikl.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgArtikl.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikl.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgArtikl.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgArtikl.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikl.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgArtikl.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.GroupRow.Options.UseFont = true;
            this.dgArtikl.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikl.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikl.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikl.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgArtikl.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgArtikl.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgArtikl.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgArtikl.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikl.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgArtikl.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgArtikl.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.OddRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.OddRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgArtikl.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgArtikl.Appearance.Preview.Options.UseBackColor = true;
            this.dgArtikl.Appearance.Preview.Options.UseForeColor = true;
            this.dgArtikl.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.Row.Options.UseBackColor = true;
            this.dgArtikl.Appearance.Row.Options.UseForeColor = true;
            this.dgArtikl.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgArtikl.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgArtikl.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgArtikl.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikl.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgArtikl.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgArtikl.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgArtikl.Appearance.VertLine.Options.UseBackColor = true;
            this.dgArtikl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldnz_ID,
            this.coloperater_OP_ID,
            this.colposlovnica_PO_Id,
            this.coldnz_odkada,
            this.coldnz_dokada,
            this.coldnz_opis,
            this.coldnz_datumizrade,
            this.colop_sifra,
            this.gridColumn1,
            this.gridColumn2});
            this.dgArtikl.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgArtikl.GridControl = this.dgArtikli;
            this.dgArtikl.Name = "dgArtikl";
            this.dgArtikl.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgArtikl.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgArtikl.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgArtikl.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgArtikl.OptionsBehavior.Editable = false;
            this.dgArtikl.OptionsCustomization.AllowColumnMoving = false;
            this.dgArtikl.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgArtikl.OptionsView.ColumnAutoWidth = false;
            this.dgArtikl.OptionsView.EnableAppearanceEvenRow = true;
            this.dgArtikl.OptionsView.EnableAppearanceOddRow = true;
            this.dgArtikl.OptionsView.ShowAutoFilterRow = true;
            this.dgArtikl.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgArtikl.OptionsView.ShowGroupPanel = false;
            this.dgArtikl.OptionsView.ShowIndicator = false;
            this.dgArtikl.PaintStyleName = "WindowsXP";
            this.dgArtikl.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldnz_ID, DevExpress.Data.ColumnSortOrder.Descending)});
            this.dgArtikl.SynchronizeClones = false;
            // 
            // coldnz_ID
            // 
            this.coldnz_ID.Caption = "Broj";
            this.coldnz_ID.FieldName = "dnz_ID";
            this.coldnz_ID.Name = "coldnz_ID";
            this.coldnz_ID.Visible = true;
            this.coldnz_ID.VisibleIndex = 0;
            // 
            // coloperater_OP_ID
            // 
            this.coloperater_OP_ID.FieldName = "operater_OP_ID";
            this.coloperater_OP_ID.Name = "coloperater_OP_ID";
            // 
            // colposlovnica_PO_Id
            // 
            this.colposlovnica_PO_Id.FieldName = "poslovnica_PO_Id";
            this.colposlovnica_PO_Id.Name = "colposlovnica_PO_Id";
            // 
            // coldnz_odkada
            // 
            this.coldnz_odkada.Caption = "Od kada";
            this.coldnz_odkada.FieldName = "dnz_odkada";
            this.coldnz_odkada.Name = "coldnz_odkada";
            this.coldnz_odkada.Visible = true;
            this.coldnz_odkada.VisibleIndex = 2;
            // 
            // coldnz_dokada
            // 
            this.coldnz_dokada.Caption = "Do kada";
            this.coldnz_dokada.FieldName = "dnz_dokada";
            this.coldnz_dokada.Name = "coldnz_dokada";
            this.coldnz_dokada.Visible = true;
            this.coldnz_dokada.VisibleIndex = 3;
            // 
            // coldnz_opis
            // 
            this.coldnz_opis.Caption = "Opis dokumenta";
            this.coldnz_opis.FieldName = "dnz_opis";
            this.coldnz_opis.Name = "coldnz_opis";
            this.coldnz_opis.Visible = true;
            this.coldnz_opis.VisibleIndex = 1;
            this.coldnz_opis.Width = 229;
            // 
            // coldnz_datumizrade
            // 
            this.coldnz_datumizrade.Caption = "Datum izrade";
            this.coldnz_datumizrade.FieldName = "dnz_datumizrade";
            this.coldnz_datumizrade.Name = "coldnz_datumizrade";
            this.coldnz_datumizrade.Visible = true;
            this.coldnz_datumizrade.VisibleIndex = 4;
            this.coldnz_datumizrade.Width = 134;
            // 
            // colop_sifra
            // 
            this.colop_sifra.FieldName = "op_sifra";
            this.colop_sifra.Name = "colop_sifra";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater";
            this.gridColumn1.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 206;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Broj artikala";
            this.gridColumn2.FieldName = "count(dozvoljenanivelacijaartikl_artikl_AR_ID )";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // dgArtikli
            // 
            this.dgArtikli.DataSource = this.artikliNiveliranjeBindingSource;
            this.dgArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtikli.Location = new System.Drawing.Point(0, 0);
            this.dgArtikli.MainView = this.dgArtikl;
            this.dgArtikli.Name = "dgArtikli";
            this.dgArtikli.Size = new System.Drawing.Size(1011, 393);
            this.dgArtikli.TabIndex = 16;
            this.dgArtikli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgArtikl});
            this.dgArtikli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgArtikli_KeyDown);
            // 
            // artikliNiveliranjeBindingSource
            // 
            this.artikliNiveliranjeBindingSource.DataMember = "ArtikliNiveliranje";
            this.artikliNiveliranjeBindingSource.DataSource = this.artikliKojiSeMoguNivelirati;
            // 
            // artikliKojiSeMoguNivelirati
            // 
            this.artikliKojiSeMoguNivelirati.DataSetName = "ArtikliKojiSeMoguNivelirati";
            this.artikliKojiSeMoguNivelirati.EnforceConstraints = false;
            this.artikliKojiSeMoguNivelirati.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(321, 15);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Briši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(77, 13);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "F7 - novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(177, 13);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjena.TabIndex = 1;
            this.btnIzmjena.Text = "F4 - izmjena";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(901, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Esc - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgPomocni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDO);
            this.panel1.Controls.Add(this.dtpOD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAzuriraj);
            this.panel1.Controls.Add(this.btnIzlaz);
            this.panel1.Controls.Add(this.btnIzmjena);
            this.panel1.Controls.Add(this.btnNovi);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 46);
            this.panel1.TabIndex = 0;
            // 
            // dgPomocni
            // 
            this.dgPomocni.DataSource = this.pregledNivelacijeBindingSource;
            this.dgPomocni.Location = new System.Drawing.Point(994, 84);
            this.dgPomocni.MainView = this.dgPomoc;
            this.dgPomocni.Name = "dgPomocni";
            this.dgPomocni.Size = new System.Drawing.Size(10, 10);
            this.dgPomocni.TabIndex = 17;
            this.dgPomocni.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgPomoc});
            // 
            // pregledNivelacijeBindingSource
            // 
            this.pregledNivelacijeBindingSource.DataMember = "pregledNivelacije";
            this.pregledNivelacijeBindingSource.DataSource = this.artikliKojiSeMoguNivelirati;
            // 
            // dgPomoc
            // 
            this.dgPomoc.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPomoc.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPomoc.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgPomoc.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgPomoc.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgPomoc.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.Empty.Options.UseBackColor = true;
            this.dgPomoc.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPomoc.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPomoc.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgPomoc.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPomoc.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgPomoc.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgPomoc.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgPomoc.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgPomoc.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgPomoc.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPomoc.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPomoc.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgPomoc.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgPomoc.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgPomoc.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgPomoc.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgPomoc.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPomoc.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgPomoc.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgPomoc.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPomoc.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPomoc.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.GroupRow.Options.UseFont = true;
            this.dgPomoc.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPomoc.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPomoc.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPomoc.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgPomoc.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgPomoc.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgPomoc.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgPomoc.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPomoc.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPomoc.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgPomoc.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.OddRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.OddRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgPomoc.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgPomoc.Appearance.Preview.Options.UseBackColor = true;
            this.dgPomoc.Appearance.Preview.Options.UseForeColor = true;
            this.dgPomoc.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.Row.Options.UseBackColor = true;
            this.dgPomoc.Appearance.Row.Options.UseForeColor = true;
            this.dgPomoc.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgPomoc.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgPomoc.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgPomoc.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPomoc.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgPomoc.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgPomoc.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPomoc.Appearance.VertLine.Options.UseBackColor = true;
            this.dgPomoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldnz_ID1,
            this.coldnz_opis1,
            this.coldnz_odkada1,
            this.coldnz_dokada1,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.coldn_preporucenacijena,
            this.colpo_sifra,
            this.colpo_naziv});
            this.dgPomoc.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgPomoc.GridControl = this.dgPomocni;
            this.dgPomoc.Name = "dgPomoc";
            this.dgPomoc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPomoc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPomoc.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgPomoc.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgPomoc.OptionsBehavior.Editable = false;
            this.dgPomoc.OptionsCustomization.AllowColumnMoving = false;
            this.dgPomoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgPomoc.OptionsView.ColumnAutoWidth = false;
            this.dgPomoc.OptionsView.EnableAppearanceEvenRow = true;
            this.dgPomoc.OptionsView.EnableAppearanceOddRow = true;
            this.dgPomoc.OptionsView.ShowAutoFilterRow = true;
            this.dgPomoc.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgPomoc.OptionsView.ShowGroupPanel = false;
            this.dgPomoc.OptionsView.ShowIndicator = false;
            this.dgPomoc.PaintStyleName = "WindowsXP";
            this.dgPomoc.SynchronizeClones = false;
            // 
            // coldnz_ID1
            // 
            this.coldnz_ID1.Caption = "Broj";
            this.coldnz_ID1.FieldName = "dnz_ID";
            this.coldnz_ID1.Name = "coldnz_ID1";
            this.coldnz_ID1.Visible = true;
            this.coldnz_ID1.VisibleIndex = 0;
            // 
            // coldnz_opis1
            // 
            this.coldnz_opis1.Caption = "Opis";
            this.coldnz_opis1.FieldName = "dnz_opis";
            this.coldnz_opis1.Name = "coldnz_opis1";
            this.coldnz_opis1.Visible = true;
            this.coldnz_opis1.VisibleIndex = 1;
            // 
            // coldnz_odkada1
            // 
            this.coldnz_odkada1.Caption = "Od kada";
            this.coldnz_odkada1.FieldName = "dnz_odkada";
            this.coldnz_odkada1.Name = "coldnz_odkada1";
            this.coldnz_odkada1.Visible = true;
            this.coldnz_odkada1.VisibleIndex = 2;
            // 
            // coldnz_dokada1
            // 
            this.coldnz_dokada1.Caption = "Do kada";
            this.coldnz_dokada1.FieldName = "dnz_dokada";
            this.coldnz_dokada1.Name = "coldnz_dokada1";
            this.coldnz_dokada1.Visible = true;
            this.coldnz_dokada1.VisibleIndex = 3;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 4;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 5;
            // 
            // coldn_preporucenacijena
            // 
            this.coldn_preporucenacijena.Caption = "Preporučena cij.";
            this.coldn_preporucenacijena.FieldName = "dn_preporucenacijena";
            this.coldn_preporucenacijena.Name = "coldn_preporucenacijena";
            this.coldn_preporucenacijena.Visible = true;
            this.coldn_preporucenacijena.VisibleIndex = 6;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra poslovnice";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 7;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv poslovnice";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "do";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Od";
            this.label2.Visible = false;
            // 
            // dtpDO
            // 
            this.dtpDO.CustomFormat = " ";
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDO.Location = new System.Drawing.Point(698, 16);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(128, 20);
            this.dtpDO.TabIndex = 13;
            this.dtpDO.Visible = false;
            this.dtpDO.Enter += new System.EventHandler(this.dtpDO_Enter);
            this.dtpDO.Leave += new System.EventHandler(this.dateTimePicker2_Leave);
            // 
            // dtpOD
            // 
            this.dtpOD.CustomFormat = " ";
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOD.Location = new System.Drawing.Point(521, 15);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(128, 20);
            this.dtpOD.TabIndex = 12;
            this.dtpOD.Visible = false;
            this.dtpOD.Enter += new System.EventHandler(this.dtpOD_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "F9 - excel";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(1104, 12);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(1, 1);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // artikliNiveliranjeTableAdapter
            // 
            this.artikliNiveliranjeTableAdapter.ClearBeforeFill = true;
            // 
            // pregledNivelacijeTableAdapter
            // 
            this.pregledNivelacijeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPregledArtikalaNivelacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 439);
            this.Controls.Add(this.dgArtikli);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPregledArtikalaNivelacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled artikala koji se mogu nivelirati";
            this.Load += new System.EventHandler(this.FrmPregledArtikalaNivelacija_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPregledArtikalaNivelacija_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliNiveliranjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliKojiSeMoguNivelirati)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPomocni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNivelacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPomoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView dgArtikl;
        private DevExpress.XtraGrid.GridControl dgArtikli;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Panel panel1;
        private ArtikliKojiSeMoguNivelirati artikliKojiSeMoguNivelirati;
        private System.Windows.Forms.BindingSource artikliNiveliranjeBindingSource;
        private ArtikliKojiSeMoguNiveliratiTableAdapters.ArtikliNiveliranjeTableAdapter artikliNiveliranjeTableAdapter;
        private System.Windows.Forms.Button btnAzuriraj;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_ID;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_OP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_PO_Id;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_odkada;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_dokada;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_opis;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_datumizrade;
        private DevExpress.XtraGrid.Columns.GridColumn colop_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private DevExpress.XtraGrid.GridControl dgPomocni;
        private DevExpress.XtraGrid.Views.Grid.GridView dgPomoc;
        private System.Windows.Forms.BindingSource pregledNivelacijeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_opis1;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_odkada1;
        private DevExpress.XtraGrid.Columns.GridColumn coldnz_dokada1;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn coldn_preporucenacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private ArtikliKojiSeMoguNiveliratiTableAdapters.pregledNivelacijeTableAdapter pregledNivelacijeTableAdapter;

    }
}