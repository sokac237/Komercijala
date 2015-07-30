namespace blokerX
{
    partial class frmPregledStanjaArtikalauXGrupiZaTrgovinu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledStanjaArtikalauXGrupiZaTrgovinu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnica = new blokerX.Poslovnica();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glKomercijalist = new DevExpress.XtraEditors.GridLookUpEdit();
            this.operaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komercijalist = new blokerX.Komercijalist();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colop_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgAkcijskiNabavniCjenici = new DevExpress.XtraGrid.GridControl();
            this.stanjeArtikalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stanjeArtikala = new blokerX.StanjeArtikala();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZA_STANJE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZA_NABCIJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operaterTableAdapter = new blokerX.KomercijalistTableAdapters.operaterTableAdapter();
            this.poslovnicaTableAdapter = new blokerX.PoslovnicaTableAdapters.poslovnicaTableAdapter();
            this.stanjeArtikalaTableAdapter = new blokerX.StanjeArtikalaTableAdapters.StanjeArtikalaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glKomercijalist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeArtikalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.glPoslovnica);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glKomercijalist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 86);
            this.panel1.TabIndex = 0;
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(104, 45);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ImmediatePopup = true;
            this.glPoslovnica.Properties.NullText = "";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Size = new System.Drawing.Size(305, 20);
            this.glPoslovnica.TabIndex = 3;
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
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(453, 42);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glKomercijalist
            // 
            this.glKomercijalist.EditValue = "";
            this.glKomercijalist.Location = new System.Drawing.Point(104, 15);
            this.glKomercijalist.Name = "glKomercijalist";
            this.glKomercijalist.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glKomercijalist.Properties.DataSource = this.operaterBindingSource;
            this.glKomercijalist.Properties.DisplayMember = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.glKomercijalist.Properties.ImmediatePopup = true;
            this.glKomercijalist.Properties.ValueMember = "op_ID";
            this.glKomercijalist.Properties.View = this.gridView3;
            this.glKomercijalist.Size = new System.Drawing.Size(305, 20);
            this.glKomercijalist.TabIndex = 2;
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
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colop_ID,
            this.gridColumn1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colop_ID
            // 
            this.colop_ID.Caption = "ID";
            this.colop_ID.FieldName = "op_ID";
            this.colop_ID.Name = "colop_ID";
            this.colop_ID.Visible = true;
            this.colop_ID.VisibleIndex = 0;
            this.colop_ID.Width = 183;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ime i prezime";
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 881;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poslovnica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komercijalist:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 48);
            this.panel2.TabIndex = 13;
            // 
            // dgAkcijskiNabavniCjenici
            // 
            this.dgAkcijskiNabavniCjenici.DataSource = this.stanjeArtikalaBindingSource;
            this.dgAkcijskiNabavniCjenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkcijskiNabavniCjenici.Location = new System.Drawing.Point(0, 86);
            this.dgAkcijskiNabavniCjenici.MainView = this.gridView2;
            this.dgAkcijskiNabavniCjenici.Name = "dgAkcijskiNabavniCjenici";
            this.dgAkcijskiNabavniCjenici.Size = new System.Drawing.Size(814, 370);
            this.dgAkcijskiNabavniCjenici.TabIndex = 14;
            this.dgAkcijskiNabavniCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // stanjeArtikalaBindingSource
            // 
            this.stanjeArtikalaBindingSource.DataMember = "stanjeArtikala";
            this.stanjeArtikalaBindingSource.DataSource = this.stanjeArtikala;
            // 
            // stanjeArtikala
            // 
            this.stanjeArtikala.DataSetName = "StanjeArtikala";
            this.stanjeArtikala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colZA_STANJE,
            this.colZA_NABCIJ,
            this.gridColumn2,
            this.colRG_SIFRA,
            this.colpo_sifra});
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
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.PaintStyleName = "WindowsXP";
            this.gridView2.SynchronizeClones = false;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 0;
            this.colAR_SIFRA.Width = 102;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 1;
            this.colAR_NAZIV.Width = 218;
            // 
            // colZA_STANJE
            // 
            this.colZA_STANJE.Caption = "Količina";
            this.colZA_STANJE.DisplayFormat.FormatString = "n2";
            this.colZA_STANJE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colZA_STANJE.FieldName = "ZA_STANJE";
            this.colZA_STANJE.Name = "colZA_STANJE";
            this.colZA_STANJE.Visible = true;
            this.colZA_STANJE.VisibleIndex = 2;
            this.colZA_STANJE.Width = 84;
            // 
            // colZA_NABCIJ
            // 
            this.colZA_NABCIJ.Caption = "Nabavna cijena";
            this.colZA_NABCIJ.DisplayFormat.FormatString = "c2";
            this.colZA_NABCIJ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colZA_NABCIJ.FieldName = "ZA_NABCIJ";
            this.colZA_NABCIJ.Name = "colZA_NABCIJ";
            this.colZA_NABCIJ.Visible = true;
            this.colZA_NABCIJ.VisibleIndex = 3;
            this.colZA_NABCIJ.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Vrijednost";
            this.gridColumn2.DisplayFormat.FormatString = "n2";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.SummaryItem.DisplayFormat = "{0:#.00}";
            this.gridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn2.UnboundExpression = "[ZA_STANJE] * [ZA_NABCIJ]";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "Robna grupa";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 5;
            this.colRG_SIFRA.Width = 81;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Skladište";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 6;
            // 
            // operaterTableAdapter
            // 
            this.operaterTableAdapter.ClearBeforeFill = true;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // stanjeArtikalaTableAdapter
            // 
            this.stanjeArtikalaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledStanjaArtikalauXGrupiZaTrgovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 504);
            this.Controls.Add(this.dgAkcijskiNabavniCjenici);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledStanjaArtikalauXGrupiZaTrgovinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled stanja artikala u X grupi za trgovinu";
            this.Load += new System.EventHandler(this.frmPregledStanjaArtikalauXGrupiZaTrgovinu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledStanjaArtikalauXGrupiZaTrgovinu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glKomercijalist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijskiNabavniCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeArtikalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgAkcijskiNabavniCjenici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraEditors.GridLookUpEdit glKomercijalist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private Komercijalist komercijalist;
        private System.Windows.Forms.BindingSource operaterBindingSource;
        private KomercijalistTableAdapters.operaterTableAdapter operaterTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colop_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private Poslovnica poslovnica;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovnicaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private System.Windows.Forms.BindingSource stanjeArtikalaBindingSource;
        private StanjeArtikala stanjeArtikala;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colZA_STANJE;
        private DevExpress.XtraGrid.Columns.GridColumn colZA_NABCIJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private StanjeArtikalaTableAdapters.StanjeArtikalaTableAdapter stanjeArtikalaTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
    }
}