namespace blokerX
{
    partial class frmDodajSKalkulacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajSKalkulacije));
            this.poslovnica = new blokerX.Poslovnica();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaTableAdapter = new blokerX.PoslovnicaTableAdapters.poslovnicaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtBrojKalk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnZapisi = new System.Windows.Forms.Button();
            this.SaKalkulacije = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldokument_DO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPR_NABCIJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ulaz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colufaifa_UI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_BROJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_netocijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPZ_POSTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljedinicaMjere_JM_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluf_broj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluf_dokumentpartnera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgKalkulacija = new DevExpress.XtraGrid.GridControl();
            this.kalkulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalkulacija = new blokerX.Kalkulacija();
            this.kalkulTableAdapter = new blokerX.KalkulacijaTableAdapters.kalkulTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaKalkulacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKalkulacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkulacija)).BeginInit();
            this.SuspendLayout();
            // 
            // poslovnica
            // 
            this.poslovnica.DataSetName = "Poslovnica";
            this.poslovnica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.poslovnica;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.glPoslovnica);
            this.panel1.Controls.Add(this.txtNapomena);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.txtBrojKalk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 112);
            this.panel1.TabIndex = 0;
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(137, 49);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ImmediatePopup = true;
            this.glPoslovnica.Properties.NullText = "";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Size = new System.Drawing.Size(298, 20);
            this.glPoslovnica.TabIndex = 12;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(135, 77);
            this.txtNapomena.MaxLength = 60;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(300, 20);
            this.txtNapomena.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Napomena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trgovina / skladiše";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(252, 10);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(92, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži stavke";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtBrojKalk
            // 
            this.txtBrojKalk.Location = new System.Drawing.Point(135, 12);
            this.txtBrojKalk.Name = "txtBrojKalk";
            this.txtBrojKalk.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKalk.TabIndex = 0;
            this.txtBrojKalk.Leave += new System.EventHandler(this.txtBrojKalk_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kalkulacija broj:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnZapisi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 45);
            this.panel2.TabIndex = 13;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(557, 10);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnZapisi
            // 
            this.btnZapisi.Location = new System.Drawing.Point(465, 10);
            this.btnZapisi.Name = "btnZapisi";
            this.btnZapisi.Size = new System.Drawing.Size(86, 23);
            this.btnZapisi.TabIndex = 0;
            this.btnZapisi.Text = "Zapiši gratise";
            this.btnZapisi.UseVisualStyleBackColor = true;
            this.btnZapisi.Click += new System.EventHandler(this.btnZapisi_Click);
            // 
            // SaKalkulacije
            // 
            this.SaKalkulacije.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.SaKalkulacije.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SaKalkulacije.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.Empty.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.EvenRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.EvenRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.SaKalkulacije.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SaKalkulacije.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.SaKalkulacije.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.FilterPanel.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.FilterPanel.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.SaKalkulacije.Appearance.FixedLine.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.SaKalkulacije.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.FocusedRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.FocusedRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.SaKalkulacije.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SaKalkulacije.Appearance.FooterPanel.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.GroupButton.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.GroupButton.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.GroupButton.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.GroupFooter.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.GroupFooter.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.SaKalkulacije.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.GroupPanel.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.GroupPanel.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.SaKalkulacije.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.SaKalkulacije.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.GroupRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.GroupRow.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.GroupRow.Options.UseFont = true;
            this.SaKalkulacije.Appearance.GroupRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.SaKalkulacije.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.SaKalkulacije.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SaKalkulacije.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.SaKalkulacije.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.SaKalkulacije.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SaKalkulacije.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.SaKalkulacije.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.SaKalkulacije.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.SaKalkulacije.Appearance.HorzLine.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.OddRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.OddRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.SaKalkulacije.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.SaKalkulacije.Appearance.Preview.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.Preview.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.Row.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.Row.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.SaKalkulacije.Appearance.RowSeparator.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.SaKalkulacije.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.SaKalkulacije.Appearance.SelectedRow.Options.UseBackColor = true;
            this.SaKalkulacije.Appearance.SelectedRow.Options.UseForeColor = true;
            this.SaKalkulacije.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.SaKalkulacije.Appearance.VertLine.Options.UseBackColor = true;
            this.SaKalkulacije.ColumnPanelRowHeight = 50;
            this.SaKalkulacije.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldokument_DO_ID,
            this.colartikl_ar_ID,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colPR_NABCIJ,
            this.colpr_ulaz,
            this.colufaifa_UI_ID,
            this.colDO_BROJ,
            this.colpo_sifra1,
            this.colpo_naziv1,
            this.coldo_datum,
            this.colpr_netocijena,
            this.gridColumn1,
            this.colPZ_POSTO,
            this.coljedinicaMjere_JM_SIFRA,
            this.coluf_broj,
            this.coluf_dokumentpartnera});
            this.SaKalkulacije.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.SaKalkulacije.GridControl = this.dgKalkulacija;
            this.SaKalkulacije.Name = "SaKalkulacije";
            this.SaKalkulacije.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.SaKalkulacije.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.SaKalkulacije.OptionsBehavior.AutoSelectAllInEditor = false;
            this.SaKalkulacije.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.SaKalkulacije.OptionsBehavior.Editable = false;
            this.SaKalkulacije.OptionsCustomization.AllowFilter = false;
            this.SaKalkulacije.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SaKalkulacije.OptionsSelection.MultiSelect = true;
            this.SaKalkulacije.OptionsView.ColumnAutoWidth = false;
            this.SaKalkulacije.OptionsView.EnableAppearanceEvenRow = true;
            this.SaKalkulacije.OptionsView.EnableAppearanceOddRow = true;
            this.SaKalkulacije.OptionsView.ShowAutoFilterRow = true;
            this.SaKalkulacije.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.SaKalkulacije.OptionsView.ShowGroupPanel = false;
            this.SaKalkulacije.OptionsView.ShowIndicator = false;
            this.SaKalkulacije.PaintStyleName = "WindowsXP";
            this.SaKalkulacije.SynchronizeClones = false;
            // 
            // coldokument_DO_ID
            // 
            this.coldokument_DO_ID.FieldName = "dokument_DO_ID";
            this.coldokument_DO_ID.Name = "coldokument_DO_ID";
            // 
            // colartikl_ar_ID
            // 
            this.colartikl_ar_ID.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID.Name = "colartikl_ar_ID";
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 0;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 1;
            this.colAR_NAZIV.Width = 183;
            // 
            // colPR_NABCIJ
            // 
            this.colPR_NABCIJ.Caption = "Nab cijena";
            this.colPR_NABCIJ.FieldName = "PR_NABCIJ";
            this.colPR_NABCIJ.Name = "colPR_NABCIJ";
            this.colPR_NABCIJ.Visible = true;
            this.colPR_NABCIJ.VisibleIndex = 2;
            // 
            // colpr_ulaz
            // 
            this.colpr_ulaz.Caption = "Promet ulaz";
            this.colpr_ulaz.FieldName = "pr_ulaz";
            this.colpr_ulaz.Name = "colpr_ulaz";
            this.colpr_ulaz.Visible = true;
            this.colpr_ulaz.VisibleIndex = 4;
            // 
            // colufaifa_UI_ID
            // 
            this.colufaifa_UI_ID.FieldName = "ufaifa_UI_ID";
            this.colufaifa_UI_ID.Name = "colufaifa_UI_ID";
            // 
            // colDO_BROJ
            // 
            this.colDO_BROJ.Caption = "Broj dok";
            this.colDO_BROJ.FieldName = "DO_BROJ";
            this.colDO_BROJ.Name = "colDO_BROJ";
            this.colDO_BROJ.Visible = true;
            this.colDO_BROJ.VisibleIndex = 3;
            // 
            // colpo_sifra1
            // 
            this.colpo_sifra1.Caption = "Šifra poslovnice";
            this.colpo_sifra1.FieldName = "po_sifra";
            this.colpo_sifra1.Name = "colpo_sifra1";
            this.colpo_sifra1.Visible = true;
            this.colpo_sifra1.VisibleIndex = 5;
            // 
            // colpo_naziv1
            // 
            this.colpo_naziv1.Caption = "Naziv poslovnice";
            this.colpo_naziv1.FieldName = "po_naziv";
            this.colpo_naziv1.Name = "colpo_naziv1";
            this.colpo_naziv1.Visible = true;
            this.colpo_naziv1.VisibleIndex = 6;
            this.colpo_naziv1.Width = 141;
            // 
            // coldo_datum
            // 
            this.coldo_datum.Caption = "Datum";
            this.coldo_datum.FieldName = "do_datum";
            this.coldo_datum.Name = "coldo_datum";
            this.coldo_datum.Visible = true;
            this.coldo_datum.VisibleIndex = 7;
            // 
            // colpr_netocijena
            // 
            this.colpr_netocijena.Caption = "Neto cijena";
            this.colpr_netocijena.FieldName = "pr_netocijena";
            this.colpr_netocijena.Name = "colpr_netocijena";
            this.colpr_netocijena.Visible = true;
            this.colpr_netocijena.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Promet ulaz suma";
            this.gridColumn1.FieldName = "sum(promet_pr_ulazvr)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // colPZ_POSTO
            // 
            this.colPZ_POSTO.Caption = "Porez";
            this.colPZ_POSTO.FieldName = "PZ_POSTO";
            this.colPZ_POSTO.Name = "colPZ_POSTO";
            this.colPZ_POSTO.Visible = true;
            this.colPZ_POSTO.VisibleIndex = 10;
            // 
            // coljedinicaMjere_JM_SIFRA
            // 
            this.coljedinicaMjere_JM_SIFRA.Caption = "Jedinica mjere";
            this.coljedinicaMjere_JM_SIFRA.FieldName = "jedinicaMjere_JM_SIFRA";
            this.coljedinicaMjere_JM_SIFRA.Name = "coljedinicaMjere_JM_SIFRA";
            this.coljedinicaMjere_JM_SIFRA.Visible = true;
            this.coljedinicaMjere_JM_SIFRA.VisibleIndex = 11;
            // 
            // coluf_broj
            // 
            this.coluf_broj.FieldName = "uf_broj";
            this.coluf_broj.Name = "coluf_broj";
            // 
            // coluf_dokumentpartnera
            // 
            this.coluf_dokumentpartnera.FieldName = "uf_dokumentpartnera";
            this.coluf_dokumentpartnera.Name = "coluf_dokumentpartnera";
            // 
            // dgKalkulacija
            // 
            this.dgKalkulacija.DataSource = this.kalkulBindingSource;
            this.dgKalkulacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKalkulacija.Location = new System.Drawing.Point(0, 112);
            this.dgKalkulacija.MainView = this.SaKalkulacije;
            this.dgKalkulacija.Name = "dgKalkulacija";
            this.dgKalkulacija.Size = new System.Drawing.Size(751, 274);
            this.dgKalkulacija.TabIndex = 14;
            this.dgKalkulacija.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SaKalkulacije});
            // 
            // kalkulBindingSource
            // 
            this.kalkulBindingSource.DataMember = "kalkul";
            this.kalkulBindingSource.DataSource = this.kalkulacija;
            // 
            // kalkulacija
            // 
            this.kalkulacija.DataSetName = "Kalkulacija";
            this.kalkulacija.EnforceConstraints = false;
            this.kalkulacija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalkulTableAdapter
            // 
            this.kalkulTableAdapter.ClearBeforeFill = true;
            // 
            // frmDodajSKalkulacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 431);
            this.Controls.Add(this.dgKalkulacija);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDodajSKalkulacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj s kalkulacije";
            this.Load += new System.EventHandler(this.Dodaj_s_kalkulacije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodajSKalkulacije_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaKalkulacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKalkulacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkulacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Poslovnica poslovnica;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovnicaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtBrojKalk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnZapisi;
        private DevExpress.XtraGrid.Views.Grid.GridView SaKalkulacije;
        private DevExpress.XtraGrid.Columns.GridColumn coldokument_DO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colPR_NABCIJ;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ulaz;
        private DevExpress.XtraGrid.Columns.GridColumn colufaifa_UI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_BROJ;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra1;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv1;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_datum;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_netocijena;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colPZ_POSTO;
        private DevExpress.XtraGrid.Columns.GridColumn coljedinicaMjere_JM_SIFRA;
        private DevExpress.XtraGrid.GridControl dgKalkulacija;
        private System.Windows.Forms.BindingSource kalkulBindingSource;
        private Kalkulacija kalkulacija;
        private KalkulacijaTableAdapters.kalkulTableAdapter kalkulTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coluf_broj;
        private DevExpress.XtraGrid.Columns.GridColumn coluf_dokumentpartnera;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
    }
}