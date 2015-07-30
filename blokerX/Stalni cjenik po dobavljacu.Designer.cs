namespace blokerX
{
    partial class frmStalniCjenikPoDobavljacu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStalniCjenikPoDobavljacu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrikaziRG = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSviArtikli = new System.Windows.Forms.RadioButton();
            this.rbArtikliUCjeniku = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSveGrupe = new System.Windows.Forms.CheckBox();
            this.btnPrikaziArtikle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.dgRG = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgsifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgnazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odabir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.robnaGrupazadobavljacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rGDobavljac = new blokerX.RGDobavljac();
            this.robnaGrupa_za_dobavljacaTableAdapter = new blokerX.RGDobavljacTableAdapters.robnaGrupa_za_dobavljacaTableAdapter();
            this.dgArtikli = new DevExpress.XtraGrid.GridControl();
            this.stalniCjenikDobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliUStalniCjenikDobavljac = new blokerX.ArtikliUStalniCjenikDobavljac();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colar_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_aktivna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpz_posto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_povnak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnabavnaCijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.artikliUstalnomCjenikuZaDobavljacaTableAdapter = new blokerX.ArtikliUStalniCjenikDobavljacTableAdapters.ArtikliUstalnomCjenikuZaDobavljacaTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robnaGrupazadobavljacaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalniCjenikDobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliUStalniCjenikDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrikaziRG);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFiltriraj);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbSveGrupe);
            this.panel1.Controls.Add(this.btnPrikaziArtikle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 117);
            this.panel1.TabIndex = 0;
            // 
            // btnPrikaziRG
            // 
            this.btnPrikaziRG.Location = new System.Drawing.Point(431, 11);
            this.btnPrikaziRG.Name = "btnPrikaziRG";
            this.btnPrikaziRG.Size = new System.Drawing.Size(106, 23);
            this.btnPrikaziRG.TabIndex = 9;
            this.btnPrikaziRG.Text = "Prikaži RG";
            this.btnPrikaziRG.UseVisualStyleBackColor = true;
            this.btnPrikaziRG.Click += new System.EventHandler(this.btnPrikaziRG_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(683, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "F9 - kopiraj u excel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(568, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "F4 - izmjena cijena";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(652, 69);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 15;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Visible = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Bez nabave";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSviArtikli);
            this.groupBox1.Controls.Add(this.rbArtikliUCjeniku);
            this.groupBox1.Location = new System.Drawing.Point(224, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbSviArtikli
            // 
            this.rbSviArtikli.AutoSize = true;
            this.rbSviArtikli.Location = new System.Drawing.Point(169, 20);
            this.rbSviArtikli.Name = "rbSviArtikli";
            this.rbSviArtikli.Size = new System.Drawing.Size(122, 17);
            this.rbSviArtikli.TabIndex = 1;
            this.rbSviArtikli.Text = "Svi artikli dobavljača";
            this.rbSviArtikli.UseVisualStyleBackColor = true;
            // 
            // rbArtikliUCjeniku
            // 
            this.rbArtikliUCjeniku.AutoSize = true;
            this.rbArtikliUCjeniku.Checked = true;
            this.rbArtikliUCjeniku.Location = new System.Drawing.Point(35, 20);
            this.rbArtikliUCjeniku.Name = "rbArtikliUCjeniku";
            this.rbArtikliUCjeniku.Size = new System.Drawing.Size(96, 17);
            this.rbArtikliUCjeniku.TabIndex = 0;
            this.rbArtikliUCjeniku.TabStop = true;
            this.rbArtikliUCjeniku.Text = "Artikli u cjeniku";
            this.rbArtikliUCjeniku.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "2x click za odabir";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(83, 12);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(286, 20);
            this.glDobavljac.TabIndex = 8;
            this.glDobavljac.EditValueChanged += new System.EventHandler(this.glDobavljac_EditValueChanged);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "partner";
            this.partnerBindingSource.DataSource = this.dobavljac;
            // 
            // dobavljac
            // 
            this.dobavljac.DataSetName = "dobavljac";
            this.dobavljac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_ID,
            this.colPA_NAZIV});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPA_NAZIV, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colPA_ID
            // 
            this.colPA_ID.FieldName = "PA_ID";
            this.colPA_ID.Name = "colPA_ID";
            this.colPA_ID.Visible = true;
            this.colPA_ID.VisibleIndex = 0;
            this.colPA_ID.Width = 133;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 919;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dobavljač:";
            // 
            // ckbSveGrupe
            // 
            this.ckbSveGrupe.AutoSize = true;
            this.ckbSveGrupe.Location = new System.Drawing.Point(18, 75);
            this.ckbSveGrupe.Name = "ckbSveGrupe";
            this.ckbSveGrupe.Size = new System.Drawing.Size(75, 17);
            this.ckbSveGrupe.TabIndex = 11;
            this.ckbSveGrupe.Text = "Sve grupe";
            this.ckbSveGrupe.UseVisualStyleBackColor = true;
            this.ckbSveGrupe.CheckedChanged += new System.EventHandler(this.ckbSveGrupe_CheckedChanged);
            // 
            // btnPrikaziArtikle
            // 
            this.btnPrikaziArtikle.Location = new System.Drawing.Point(431, 40);
            this.btnPrikaziArtikle.Name = "btnPrikaziArtikle";
            this.btnPrikaziArtikle.Size = new System.Drawing.Size(106, 23);
            this.btnPrikaziArtikle.TabIndex = 10;
            this.btnPrikaziArtikle.Text = "Prikaži artikle";
            this.btnPrikaziArtikle.UseVisualStyleBackColor = true;
            this.btnPrikaziArtikle.Click += new System.EventHandler(this.btnPrikaziArtikle_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 49);
            this.panel2.TabIndex = 1;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // dgRG
            // 
            this.dgRG.AllowUserToAddRows = false;
            this.dgRG.AllowUserToDeleteRows = false;
            this.dgRG.AllowUserToResizeColumns = false;
            this.dgRG.AllowUserToResizeRows = false;
            this.dgRG.AutoGenerateColumns = false;
            this.dgRG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRG.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgRG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rgsifraDataGridViewTextBoxColumn,
            this.rgnazivDataGridViewTextBoxColumn,
            this.odabir});
            this.dgRG.DataSource = this.robnaGrupazadobavljacaBindingSource;
            this.dgRG.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgRG.Location = new System.Drawing.Point(0, 117);
            this.dgRG.Name = "dgRG";
            this.dgRG.ReadOnly = true;
            this.dgRG.RowHeadersVisible = false;
            this.dgRG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRG.Size = new System.Drawing.Size(262, 442);
            this.dgRG.TabIndex = 8;
            this.dgRG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRG_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rgsifraDataGridViewTextBoxColumn
            // 
            this.rgsifraDataGridViewTextBoxColumn.DataPropertyName = "rg_sifra";
            this.rgsifraDataGridViewTextBoxColumn.FillWeight = 76.06961F;
            this.rgsifraDataGridViewTextBoxColumn.HeaderText = "Sifra";
            this.rgsifraDataGridViewTextBoxColumn.Name = "rgsifraDataGridViewTextBoxColumn";
            this.rgsifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgnazivDataGridViewTextBoxColumn
            // 
            this.rgnazivDataGridViewTextBoxColumn.DataPropertyName = "rg_naziv";
            this.rgnazivDataGridViewTextBoxColumn.FillWeight = 167.5127F;
            this.rgnazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.rgnazivDataGridViewTextBoxColumn.Name = "rgnazivDataGridViewTextBoxColumn";
            this.rgnazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odabir
            // 
            this.odabir.FillWeight = 56.41774F;
            this.odabir.HeaderText = "Da/Ne";
            this.odabir.Name = "odabir";
            this.odabir.ReadOnly = true;
            // 
            // robnaGrupazadobavljacaBindingSource
            // 
            this.robnaGrupazadobavljacaBindingSource.DataMember = "robnaGrupa_za_dobavljaca";
            this.robnaGrupazadobavljacaBindingSource.DataSource = this.rGDobavljac;
            // 
            // rGDobavljac
            // 
            this.rGDobavljac.DataSetName = "RGDobavljac";
            this.rGDobavljac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robnaGrupa_za_dobavljacaTableAdapter
            // 
            this.robnaGrupa_za_dobavljacaTableAdapter.ClearBeforeFill = true;
            // 
            // dgArtikli
            // 
            this.dgArtikli.DataSource = this.stalniCjenikDobavljacBindingSource;
            this.dgArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtikli.Location = new System.Drawing.Point(262, 117);
            this.dgArtikli.MainView = this.gridView2;
            this.dgArtikli.Name = "dgArtikli";
            this.dgArtikli.Size = new System.Drawing.Size(1103, 442);
            this.dgArtikli.TabIndex = 9;
            this.dgArtikli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgArtikli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgArtikli_KeyUp);
            // 
            // stalniCjenikDobavljacBindingSource
            // 
            this.stalniCjenikDobavljacBindingSource.DataMember = "StalniCjenikDobavljac";
            this.stalniCjenikDobavljacBindingSource.DataSource = this.artikliUStalniCjenikDobavljac;
            // 
            // artikliUStalniCjenikDobavljac
            // 
            this.artikliUStalniCjenikDobavljac.DataSetName = "ArtikliUStalniCjenikDobavljac";
            this.artikliUStalniCjenikDobavljac.EnforceConstraints = false;
            this.artikliUStalniCjenikDobavljac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colar_naziv,
            this.colar_sifra,
            this.colprc_aktivna,
            this.colprc_tipa,
            this.gridColumn1,
            this.colprc_tipb,
            this.gridColumn2,
            this.colprc_tipc,
            this.gridColumn3,
            this.colprc_tipd,
            this.gridColumn4,
            this.colprc_tipx,
            this.gridColumn5,
            this.colar_ID,
            this.colpz_posto,
            this.colar_povnak,
            this.colnabavnaCijena});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView2.GridControl = this.dgArtikli;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView2.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // colar_naziv
            // 
            this.colar_naziv.Caption = "Naziv";
            this.colar_naziv.FieldName = "ar_naziv";
            this.colar_naziv.Name = "colar_naziv";
            this.colar_naziv.Visible = true;
            this.colar_naziv.VisibleIndex = 0;
            this.colar_naziv.Width = 360;
            // 
            // colar_sifra
            // 
            this.colar_sifra.Caption = "Šifra";
            this.colar_sifra.FieldName = "ar_sifra";
            this.colar_sifra.Name = "colar_sifra";
            this.colar_sifra.Visible = true;
            this.colar_sifra.VisibleIndex = 1;
            this.colar_sifra.Width = 140;
            // 
            // colprc_aktivna
            // 
            this.colprc_aktivna.Caption = "Aktivna";
            this.colprc_aktivna.FieldName = "prc_aktivna";
            this.colprc_aktivna.Name = "colprc_aktivna";
            this.colprc_aktivna.Visible = true;
            this.colprc_aktivna.VisibleIndex = 2;
            this.colprc_aktivna.Width = 92;
            // 
            // colprc_tipa
            // 
            this.colprc_tipa.Caption = "Tip A";
            this.colprc_tipa.FieldName = "prc_tipa";
            this.colprc_tipa.Name = "colprc_tipa";
            this.colprc_tipa.Visible = true;
            this.colprc_tipa.VisibleIndex = 3;
            this.colprc_tipa.Width = 99;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "% ";
            this.gridColumn1.DisplayFormat.FormatString = "n2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "\r\nIif([prc_tipa] = 0.00,0  , 100 * (((([prc_tipa] - [ar_povnak]) / (1 + [pz_posto" +
    "] / 100)) - [nabavnaCijena]) / ( [nabavnaCijena] - [ar_povnak]))\r\n )";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 84;
            // 
            // colprc_tipb
            // 
            this.colprc_tipb.Caption = "Tip B";
            this.colprc_tipb.FieldName = "prc_tipb";
            this.colprc_tipb.Name = "colprc_tipb";
            this.colprc_tipb.Visible = true;
            this.colprc_tipb.VisibleIndex = 5;
            this.colprc_tipb.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "%";
            this.gridColumn2.DisplayFormat.FormatString = "n2";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundExpression = "\r\nIif([prc_tipb] = 0.00, 0 , 100 * (((([prc_tipb] - [ar_povnak]) / (1 + [pz_posto" +
    "] / 100)) - [nabavnaCijena]) / ( [nabavnaCijena] - [ar_povnak])) )";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 83;
            // 
            // colprc_tipc
            // 
            this.colprc_tipc.Caption = "Tip C";
            this.colprc_tipc.FieldName = "prc_tipc";
            this.colprc_tipc.Name = "colprc_tipc";
            this.colprc_tipc.Visible = true;
            this.colprc_tipc.VisibleIndex = 7;
            this.colprc_tipc.Width = 104;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "%";
            this.gridColumn3.DisplayFormat.FormatString = "n2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "Iif([prc_tipc] = 0.00, 0 , 100 * (((([prc_tipc] - [ar_povnak]) / (1 + [pz_posto] " +
    "/ 100)) -  [nabavnaCijena]) / ( [nabavnaCijena] - [ar_povnak])) )";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 86;
            // 
            // colprc_tipd
            // 
            this.colprc_tipd.Caption = "Tip D";
            this.colprc_tipd.FieldName = "prc_tipd";
            this.colprc_tipd.Name = "colprc_tipd";
            this.colprc_tipd.Visible = true;
            this.colprc_tipd.VisibleIndex = 9;
            this.colprc_tipd.Width = 106;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "%";
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundExpression = "Iif([prc_tipd] = 0.00, 0 , 100 * (((([prc_tipd] - [ar_povnak]) / (1 + [pz_posto] " +
    "/ 100)) -  [nabavnaCijena]) / ( [nabavnaCijena] - [ar_povnak])) )";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            this.gridColumn4.Width = 85;
            // 
            // colprc_tipx
            // 
            this.colprc_tipx.Caption = "Tip X";
            this.colprc_tipx.FieldName = "prc_tipx";
            this.colprc_tipx.Name = "colprc_tipx";
            this.colprc_tipx.Visible = true;
            this.colprc_tipx.VisibleIndex = 11;
            this.colprc_tipx.Width = 97;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "%";
            this.gridColumn5.DisplayFormat.FormatString = "n2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundExpression = "\r\nIif([prc_tipx] = 0.00,  0, 100 * (((([prc_tipx] - [ar_povnak]) / (1 + [pz_posto" +
    "] / 100)) - [nabavnaCijena]) / ( [nabavnaCijena] - [ar_povnak])) )";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 12;
            this.gridColumn5.Width = 84;
            // 
            // colar_ID
            // 
            this.colar_ID.FieldName = "ar_ID";
            this.colar_ID.Name = "colar_ID";
            // 
            // colpz_posto
            // 
            this.colpz_posto.FieldName = "pz_posto";
            this.colpz_posto.Name = "colpz_posto";
            // 
            // colar_povnak
            // 
            this.colar_povnak.FieldName = "ar_povnak";
            this.colar_povnak.Name = "colar_povnak";
            // 
            // colnabavnaCijena
            // 
            this.colnabavnaCijena.Caption = "Nabavna cijena";
            this.colnabavnaCijena.FieldName = "nabavnaCijena";
            this.colnabavnaCijena.Name = "colnabavnaCijena";
            this.colnabavnaCijena.Visible = true;
            this.colnabavnaCijena.VisibleIndex = 13;
            this.colnabavnaCijena.Width = 227;
            // 
            // artikliUstalnomCjenikuZaDobavljacaTableAdapter
            // 
            this.artikliUstalnomCjenikuZaDobavljacaTableAdapter.ClearBeforeFill = true;
            // 
            // frmStalniCjenikPoDobavljacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 608);
            this.Controls.Add(this.dgArtikli);
            this.Controls.Add(this.dgRG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmStalniCjenikPoDobavljacu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stalni cjenik po dobavljaču";
            this.Load += new System.EventHandler(this.frmStalniCjenikPoDobavljacu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStalniCjenikPoDobavljacu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robnaGrupazadobavljacaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rGDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalniCjenikDobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliUStalniCjenikDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSveGrupe;
        private System.Windows.Forms.Button btnPrikaziArtikle;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSviArtikli;
        private System.Windows.Forms.RadioButton rbArtikliUCjeniku;
        private System.Windows.Forms.DataGridView dgRG;
        private System.Windows.Forms.BindingSource robnaGrupazadobavljacaBindingSource;
        private RGDobavljac rGDobavljac;
        private RGDobavljacTableAdapters.robnaGrupa_za_dobavljacaTableAdapter robnaGrupa_za_dobavljacaTableAdapter;
        private DevExpress.XtraGrid.GridControl dgArtikli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgsifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgnazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odabir;
        private System.Windows.Forms.BindingSource stalniCjenikDobavljacBindingSource;
        private ArtikliUStalniCjenikDobavljac artikliUStalniCjenikDobavljac;
        private ArtikliUStalniCjenikDobavljacTableAdapters.ArtikliUstalnomCjenikuZaDobavljacaTableAdapter artikliUstalnomCjenikuZaDobavljacaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colar_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colar_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_aktivna;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipa;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipb;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipc;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipd;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipx;
        private DevExpress.XtraGrid.Columns.GridColumn colar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpz_posto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colar_povnak;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrikaziRG;
        private DevExpress.XtraGrid.Columns.GridColumn colnabavnaCijena;


    }
}