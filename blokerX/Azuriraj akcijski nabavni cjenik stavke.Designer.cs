namespace blokerX
{
    partial class frmAzurirajAkcijskiNabavniStavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzurirajAkcijskiNabavniStavke));
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.nabavnistavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nabavneCijenePoCjenicima = new blokerX.NabavneCijenePoCjenicima();
            this.nabavnistavkaTableAdapter = new blokerX.NabavneCijenePoCjenicimaTableAdapters.nabavnistavkaTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnas_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnabavniCjenik_nac_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_tvornickacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_postorabata = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_akcijskacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_akcijskirabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_datumizmjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vaziod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaxKoeficijent = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAkcijskaCijena = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtAkcijskiRabat = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtRabat = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtTvornickaCijena = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.dgNabavneCijenePoCjenicima = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnas_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnabavniCjenik_nac_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_tvornickacijena1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_postorabata1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_akcijskacijena1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_akcijskirabat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_datumizmjene1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vaziod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vazido1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtIzmjena = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtSifArtikl = new System.Windows.Forms.TextBox();
            this.txtSifKodDobavljac = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCjenik = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMaksimumPoTipu = new DevExpress.XtraGrid.GridControl();
            this.tipPoslovniceMaksimumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipMaksimum = new blokerX.TipMaksimum();
            this.dgMaksPoTipu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnas_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltip_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_maxkoeficijent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_datumizmjene2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIP_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNaziviSifraArtikla = new System.Windows.Forms.Label();
            this.lblCjenik2 = new System.Windows.Forms.Label();
            this.tipPoslovniceMaksimumTableAdapter = new blokerX.TipMaksimumTableAdapters.tipPoslovniceMaksimumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavnistavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavneCijenePoCjenicima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxKoeficijent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNabavneCijenePoCjenicima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaksimumPoTipu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipPoslovniceMaksimumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipMaksimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaksPoTipu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // nabavnistavkaBindingSource
            // 
            this.nabavnistavkaBindingSource.DataMember = "nabavnistavka";
            this.nabavnistavkaBindingSource.DataSource = this.nabavneCijenePoCjenicima;
            // 
            // nabavneCijenePoCjenicima
            // 
            this.nabavneCijenePoCjenicima.DataSetName = "NabavneCijenePoCjenicima";
            this.nabavneCijenePoCjenicima.EnforceConstraints = false;
            this.nabavneCijenePoCjenicima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nabavnistavkaTableAdapter
            // 
            this.nabavnistavkaTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnas_ID,
            this.colnabavniCjenik_nac_ID,
            this.colartikl_ar_ID,
            this.colnas_tvornickacijena,
            this.colnas_postorabata,
            this.colnas_akcijskacijena,
            this.colnas_akcijskirabat,
            this.colnas_datumizmjene,
            this.coloperater_op_ID,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.gridColumn1,
            this.colnac_vaziod,
            this.colnac_vazido});
            this.gridView1.Name = "gridView1";
            // 
            // colnas_ID
            // 
            this.colnas_ID.FieldName = "nas_ID";
            this.colnas_ID.Name = "colnas_ID";
            this.colnas_ID.Visible = true;
            this.colnas_ID.VisibleIndex = 0;
            // 
            // colnabavniCjenik_nac_ID
            // 
            this.colnabavniCjenik_nac_ID.FieldName = "nabavniCjenik_nac_ID";
            this.colnabavniCjenik_nac_ID.Name = "colnabavniCjenik_nac_ID";
            this.colnabavniCjenik_nac_ID.Visible = true;
            this.colnabavniCjenik_nac_ID.VisibleIndex = 1;
            // 
            // colartikl_ar_ID
            // 
            this.colartikl_ar_ID.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID.Name = "colartikl_ar_ID";
            this.colartikl_ar_ID.Visible = true;
            this.colartikl_ar_ID.VisibleIndex = 2;
            // 
            // colnas_tvornickacijena
            // 
            this.colnas_tvornickacijena.FieldName = "nas_tvornickacijena";
            this.colnas_tvornickacijena.Name = "colnas_tvornickacijena";
            this.colnas_tvornickacijena.Visible = true;
            this.colnas_tvornickacijena.VisibleIndex = 3;
            // 
            // colnas_postorabata
            // 
            this.colnas_postorabata.FieldName = "nas_postorabata";
            this.colnas_postorabata.Name = "colnas_postorabata";
            this.colnas_postorabata.Visible = true;
            this.colnas_postorabata.VisibleIndex = 4;
            // 
            // colnas_akcijskacijena
            // 
            this.colnas_akcijskacijena.FieldName = "nas_akcijskacijena";
            this.colnas_akcijskacijena.Name = "colnas_akcijskacijena";
            this.colnas_akcijskacijena.Visible = true;
            this.colnas_akcijskacijena.VisibleIndex = 5;
            // 
            // colnas_akcijskirabat
            // 
            this.colnas_akcijskirabat.FieldName = "nas_akcijskirabat";
            this.colnas_akcijskirabat.Name = "colnas_akcijskirabat";
            this.colnas_akcijskirabat.Visible = true;
            this.colnas_akcijskirabat.VisibleIndex = 6;
            // 
            // colnas_datumizmjene
            // 
            this.colnas_datumizmjene.FieldName = "nas_datumizmjene";
            this.colnas_datumizmjene.Name = "colnas_datumizmjene";
            this.colnas_datumizmjene.Visible = true;
            this.colnas_datumizmjene.VisibleIndex = 7;
            // 
            // coloperater_op_ID
            // 
            this.coloperater_op_ID.FieldName = "operater_op_ID";
            this.coloperater_op_ID.Name = "coloperater_op_ID";
            this.coloperater_op_ID.Visible = true;
            this.coloperater_op_ID.VisibleIndex = 8;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 9;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // colnac_vaziod
            // 
            this.colnac_vaziod.FieldName = "nac_vaziod";
            this.colnac_vaziod.Name = "colnac_vaziod";
            this.colnac_vaziod.Visible = true;
            this.colnac_vaziod.VisibleIndex = 12;
            // 
            // colnac_vazido
            // 
            this.colnac_vazido.FieldName = "nac_vazido";
            this.colnac_vazido.Name = "colnac_vazido";
            this.colnac_vazido.Visible = true;
            this.colnac_vazido.VisibleIndex = 13;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1012, 558);
            this.tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Akc. cjenik stavka";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaxKoeficijent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAkcijskaCijena);
            this.panel2.Controls.Add(this.txtAkcijskiRabat);
            this.panel2.Controls.Add(this.txtRabat);
            this.panel2.Controls.Add(this.txtTvornickaCijena);
            this.panel2.Controls.Add(this.dgNabavneCijenePoCjenicima);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnSpremi);
            this.panel2.Controls.Add(this.txtIzmjena);
            this.panel2.Controls.Add(this.lblNaziv);
            this.panel2.Controls.Add(this.txtSifArtikl);
            this.panel2.Controls.Add(this.txtSifKodDobavljac);
            this.panel2.Controls.Add(this.txtBarkod);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.glDobavljac);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 483);
            this.panel2.TabIndex = 27;
            // 
            // txtMaxKoeficijent
            // 
            this.txtMaxKoeficijent.Location = new System.Drawing.Point(185, 227);
            this.txtMaxKoeficijent.Name = "txtMaxKoeficijent";
            this.txtMaxKoeficijent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMaxKoeficijent.Properties.Mask.EditMask = "\\d{0,3}";
            this.txtMaxKoeficijent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtMaxKoeficijent.Properties.MaxLength = 3;
            this.txtMaxKoeficijent.Properties.NullText = "0";
            this.txtMaxKoeficijent.Size = new System.Drawing.Size(130, 20);
            this.txtMaxKoeficijent.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Povećaj maksimum narudžbe (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "(F2)";
            // 
            // txtAkcijskaCijena
            // 
            this.txtAkcijskaCijena.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtAkcijskaCijena.InputMask = "{LOC}nnnnnnn.nnnnn";
            this.txtAkcijskaCijena.Location = new System.Drawing.Point(142, 201);
            this.txtAkcijskaCijena.Name = "txtAkcijskaCijena";
            this.txtAkcijskaCijena.PromptChar = ' ';
            this.txtAkcijskaCijena.Size = new System.Drawing.Size(93, 20);
            this.txtAkcijskaCijena.TabIndex = 37;
            // 
            // txtAkcijskiRabat
            // 
            this.txtAkcijskiRabat.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtAkcijskiRabat.InputMask = "{LOC}nnnnnnn.nn";
            this.txtAkcijskiRabat.Location = new System.Drawing.Point(142, 172);
            this.txtAkcijskiRabat.Name = "txtAkcijskiRabat";
            this.txtAkcijskiRabat.PromptChar = ' ';
            this.txtAkcijskiRabat.Size = new System.Drawing.Size(73, 20);
            this.txtAkcijskiRabat.TabIndex = 36;
            this.txtAkcijskiRabat.Enter += new System.EventHandler(this.txtAkcRab_Enter);
            this.txtAkcijskiRabat.Leave += new System.EventHandler(this.txtAkcRab_Leave);
            // 
            // txtRabat
            // 
            this.txtRabat.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtRabat.InputMask = "{LOC}nnnnnnn.nn";
            this.txtRabat.Location = new System.Drawing.Point(142, 144);
            this.txtRabat.Name = "txtRabat";
            this.txtRabat.PromptChar = ' ';
            this.txtRabat.Size = new System.Drawing.Size(73, 20);
            this.txtRabat.TabIndex = 35;
            this.txtRabat.Enter += new System.EventHandler(this.txtRab_Enter);
            // 
            // txtTvornickaCijena
            // 
            this.txtTvornickaCijena.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtTvornickaCijena.InputMask = "{LOC}nnnnnnn.nn";
            this.txtTvornickaCijena.Location = new System.Drawing.Point(142, 116);
            this.txtTvornickaCijena.Name = "txtTvornickaCijena";
            this.txtTvornickaCijena.PromptChar = ' ';
            this.txtTvornickaCijena.Size = new System.Drawing.Size(73, 20);
            this.txtTvornickaCijena.TabIndex = 34;
            this.txtTvornickaCijena.Enter += new System.EventHandler(this.txtTvor_Enter);
            // 
            // dgNabavneCijenePoCjenicima
            // 
            this.dgNabavneCijenePoCjenicima.DataSource = this.nabavnistavkaBindingSource;
            this.dgNabavneCijenePoCjenicima.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNabavneCijenePoCjenicima.Location = new System.Drawing.Point(0, 301);
            this.dgNabavneCijenePoCjenicima.MainView = this.gridView3;
            this.dgNabavneCijenePoCjenicima.Name = "dgNabavneCijenePoCjenicima";
            this.dgNabavneCijenePoCjenicima.Size = new System.Drawing.Size(998, 182);
            this.dgNabavneCijenePoCjenicima.TabIndex = 51;
            this.dgNabavneCijenePoCjenicima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView3.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupRow.Options.UseFont = true;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView3.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView3.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView3.Appearance.Preview.Options.UseBackColor = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseForeColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView3.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnas_ID1,
            this.colnabavniCjenik_nac_ID1,
            this.colartikl_ar_ID1,
            this.colnas_tvornickacijena1,
            this.colnas_postorabata1,
            this.colnas_akcijskacijena1,
            this.colnas_akcijskirabat1,
            this.colnas_datumizmjene1,
            this.coloperater_op_ID2,
            this.colAR_SIFRA1,
            this.colAR_NAZIV1,
            this.gridColumn2,
            this.colnac_vaziod1,
            this.colnac_vazido1});
            this.gridView3.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView3.GridControl = this.dgNabavneCijenePoCjenicima;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView3.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowIndicator = false;
            this.gridView3.PaintStyleName = "WindowsXP";
            this.gridView3.SynchronizeClones = false;
            // 
            // colnas_ID1
            // 
            this.colnas_ID1.FieldName = "nas_ID";
            this.colnas_ID1.Name = "colnas_ID1";
            // 
            // colnabavniCjenik_nac_ID1
            // 
            this.colnabavniCjenik_nac_ID1.Caption = "Cjenik";
            this.colnabavniCjenik_nac_ID1.FieldName = "nabavniCjenik_nac_ID";
            this.colnabavniCjenik_nac_ID1.Name = "colnabavniCjenik_nac_ID1";
            this.colnabavniCjenik_nac_ID1.Visible = true;
            this.colnabavniCjenik_nac_ID1.VisibleIndex = 0;
            // 
            // colartikl_ar_ID1
            // 
            this.colartikl_ar_ID1.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID1.Name = "colartikl_ar_ID1";
            // 
            // colnas_tvornickacijena1
            // 
            this.colnas_tvornickacijena1.Caption = "Tvornička cijena";
            this.colnas_tvornickacijena1.DisplayFormat.FormatString = "c2";
            this.colnas_tvornickacijena1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnas_tvornickacijena1.FieldName = "nas_tvornickacijena";
            this.colnas_tvornickacijena1.Name = "colnas_tvornickacijena1";
            this.colnas_tvornickacijena1.Visible = true;
            this.colnas_tvornickacijena1.VisibleIndex = 3;
            this.colnas_tvornickacijena1.Width = 96;
            // 
            // colnas_postorabata1
            // 
            this.colnas_postorabata1.Caption = "Rabat";
            this.colnas_postorabata1.FieldName = "nas_postorabata";
            this.colnas_postorabata1.Name = "colnas_postorabata1";
            this.colnas_postorabata1.Visible = true;
            this.colnas_postorabata1.VisibleIndex = 4;
            // 
            // colnas_akcijskacijena1
            // 
            this.colnas_akcijskacijena1.Caption = "Akcijska cijena";
            this.colnas_akcijskacijena1.DisplayFormat.FormatString = "c2";
            this.colnas_akcijskacijena1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnas_akcijskacijena1.FieldName = "nas_akcijskacijena";
            this.colnas_akcijskacijena1.Name = "colnas_akcijskacijena1";
            this.colnas_akcijskacijena1.Visible = true;
            this.colnas_akcijskacijena1.VisibleIndex = 5;
            this.colnas_akcijskacijena1.Width = 88;
            // 
            // colnas_akcijskirabat1
            // 
            this.colnas_akcijskirabat1.Caption = "Akcijski rabat";
            this.colnas_akcijskirabat1.FieldName = "nas_akcijskirabat";
            this.colnas_akcijskirabat1.Name = "colnas_akcijskirabat1";
            this.colnas_akcijskirabat1.Visible = true;
            this.colnas_akcijskirabat1.VisibleIndex = 6;
            this.colnas_akcijskirabat1.Width = 91;
            // 
            // colnas_datumizmjene1
            // 
            this.colnas_datumizmjene1.Caption = "Izmjena";
            this.colnas_datumizmjene1.FieldName = "nas_datumizmjene";
            this.colnas_datumizmjene1.Name = "colnas_datumizmjene1";
            this.colnas_datumizmjene1.Visible = true;
            this.colnas_datumizmjene1.VisibleIndex = 7;
            // 
            // coloperater_op_ID2
            // 
            this.coloperater_op_ID2.FieldName = "operater_op_ID";
            this.coloperater_op_ID2.Name = "coloperater_op_ID2";
            // 
            // colAR_SIFRA1
            // 
            this.colAR_SIFRA1.Caption = "Šifra artikla";
            this.colAR_SIFRA1.FieldName = "AR_SIFRA";
            this.colAR_SIFRA1.Name = "colAR_SIFRA1";
            this.colAR_SIFRA1.Visible = true;
            this.colAR_SIFRA1.VisibleIndex = 1;
            this.colAR_SIFRA1.Width = 88;
            // 
            // colAR_NAZIV1
            // 
            this.colAR_NAZIV1.Caption = "Naziv artikla";
            this.colAR_NAZIV1.FieldName = "AR_NAZIV";
            this.colAR_NAZIV1.Name = "colAR_NAZIV1";
            this.colAR_NAZIV1.Visible = true;
            this.colAR_NAZIV1.VisibleIndex = 2;
            this.colAR_NAZIV1.Width = 160;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Operater";
            this.gridColumn2.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 110;
            // 
            // colnac_vaziod1
            // 
            this.colnac_vaziod1.Caption = "Važi od";
            this.colnac_vaziod1.FieldName = "nac_vaziod";
            this.colnac_vaziod1.Name = "colnac_vaziod1";
            this.colnac_vaziod1.Visible = true;
            this.colnac_vaziod1.VisibleIndex = 9;
            // 
            // colnac_vazido1
            // 
            this.colnac_vazido1.Caption = "Važi do";
            this.colnac_vazido1.FieldName = "nac_vazido";
            this.colnac_vazido1.Name = "colnac_vazido1";
            this.colnac_vazido1.Visible = true;
            this.colnac_vazido1.VisibleIndex = 10;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(916, 268);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 44;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(835, 268);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 42;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIzmjena
            // 
            this.txtIzmjena.Location = new System.Drawing.Point(142, 265);
            this.txtIzmjena.Name = "txtIzmjena";
            this.txtIzmjena.ReadOnly = true;
            this.txtIzmjena.Size = new System.Drawing.Size(298, 20);
            this.txtIzmjena.TabIndex = 50;
            this.txtIzmjena.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(341, 41);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblNaziv.TabIndex = 49;
            this.lblNaziv.Text = "___";
            // 
            // txtSifArtikl
            // 
            this.txtSifArtikl.Location = new System.Drawing.Point(140, 82);
            this.txtSifArtikl.Name = "txtSifArtikl";
            this.txtSifArtikl.Size = new System.Drawing.Size(136, 20);
            this.txtSifArtikl.TabIndex = 32;
            this.txtSifArtikl.TextChanged += new System.EventHandler(this.txtSifArtikl_TextChanged);
            this.txtSifArtikl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifArtikl_KeyDown);
            this.txtSifArtikl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifArtikl_KeyPress);
            this.txtSifArtikl.Leave += new System.EventHandler(this.txtSifArtikl_Leave);
            // 
            // txtSifKodDobavljac
            // 
            this.txtSifKodDobavljac.Location = new System.Drawing.Point(451, 82);
            this.txtSifKodDobavljac.Name = "txtSifKodDobavljac";
            this.txtSifKodDobavljac.Size = new System.Drawing.Size(136, 20);
            this.txtSifKodDobavljac.TabIndex = 33;
            this.txtSifKodDobavljac.TextChanged += new System.EventHandler(this.txtSifKodDobavljac_TextChanged);
            this.txtSifKodDobavljac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifKodDobavljac_KeyPress);
            this.txtSifKodDobavljac.Leave += new System.EventHandler(this.txtSifKodDobavljac_Leave);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(140, 38);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(184, 20);
            this.txtBarkod.TabIndex = 31;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            this.txtBarkod.Leave += new System.EventHandler(this.txtBarkod_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Šifra artikla:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Šifra kod dobavljača:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Barkod:";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(140, 9);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(300, 20);
            this.glDobavljac.TabIndex = 30;
            this.glDobavljac.EditValueChanged += new System.EventHandler(this.glDobavljac_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_ID,
            this.colPA_SIFRA,
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
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 118;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 560;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Dobavljač:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Izmjena:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Akcijska cijena (VPC):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Akcijski rabat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Redovni rabat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tvornička cijena:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCjenik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 43);
            this.panel1.TabIndex = 26;
            // 
            // lblCjenik
            // 
            this.lblCjenik.AutoSize = true;
            this.lblCjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCjenik.Location = new System.Drawing.Point(21, 13);
            this.lblCjenik.Name = "lblCjenik";
            this.lblCjenik.Size = new System.Drawing.Size(36, 20);
            this.lblCjenik.TabIndex = 0;
            this.lblCjenik.Text = "___";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMaksimumPoTipu);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maksimum po tipovima";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMaksimumPoTipu
            // 
            this.dgMaksimumPoTipu.DataSource = this.tipPoslovniceMaksimumBindingSource;
            this.dgMaksimumPoTipu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgMaksimumPoTipu.Location = new System.Drawing.Point(3, 93);
            this.dgMaksimumPoTipu.MainView = this.dgMaksPoTipu;
            this.dgMaksimumPoTipu.Name = "dgMaksimumPoTipu";
            this.dgMaksimumPoTipu.Size = new System.Drawing.Size(998, 417);
            this.dgMaksimumPoTipu.TabIndex = 53;
            this.dgMaksimumPoTipu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgMaksPoTipu});
            // 
            // tipPoslovniceMaksimumBindingSource
            // 
            this.tipPoslovniceMaksimumBindingSource.DataMember = "tipPoslovniceMaksimum";
            this.tipPoslovniceMaksimumBindingSource.DataSource = this.tipMaksimum;
            // 
            // tipMaksimum
            // 
            this.tipMaksimum.DataSetName = "TipMaksimum";
            this.tipMaksimum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgMaksPoTipu
            // 
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.Empty.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgMaksPoTipu.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgMaksPoTipu.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgMaksPoTipu.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgMaksPoTipu.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgMaksPoTipu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgMaksPoTipu.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgMaksPoTipu.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgMaksPoTipu.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaksPoTipu.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgMaksPoTipu.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.GroupRow.Options.UseFont = true;
            this.dgMaksPoTipu.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgMaksPoTipu.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgMaksPoTipu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgMaksPoTipu.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgMaksPoTipu.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgMaksPoTipu.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgMaksPoTipu.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgMaksPoTipu.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.OddRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.OddRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgMaksPoTipu.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgMaksPoTipu.Appearance.Preview.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.Preview.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.Row.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.Row.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgMaksPoTipu.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgMaksPoTipu.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgMaksPoTipu.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgMaksPoTipu.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgMaksPoTipu.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgMaksPoTipu.Appearance.VertLine.Options.UseBackColor = true;
            this.dgMaksPoTipu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnas_ID2,
            this.coltip_sifra,
            this.colnas_maxkoeficijent,
            this.coloperater,
            this.colnas_datumizmjene2,
            this.colTIP_id});
            this.dgMaksPoTipu.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgMaksPoTipu.GridControl = this.dgMaksimumPoTipu;
            this.dgMaksPoTipu.Name = "dgMaksPoTipu";
            this.dgMaksPoTipu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgMaksPoTipu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgMaksPoTipu.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgMaksPoTipu.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgMaksPoTipu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgMaksPoTipu.OptionsSelection.MultiSelect = true;
            this.dgMaksPoTipu.OptionsView.ColumnAutoWidth = false;
            this.dgMaksPoTipu.OptionsView.EnableAppearanceEvenRow = true;
            this.dgMaksPoTipu.OptionsView.EnableAppearanceOddRow = true;
            this.dgMaksPoTipu.OptionsView.ShowAutoFilterRow = true;
            this.dgMaksPoTipu.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgMaksPoTipu.OptionsView.ShowGroupPanel = false;
            this.dgMaksPoTipu.OptionsView.ShowIndicator = false;
            this.dgMaksPoTipu.PaintStyleName = "WindowsXP";
            this.dgMaksPoTipu.SynchronizeClones = false;
            this.dgMaksPoTipu.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dgMaksPoTipu_RowUpdated);
            this.dgMaksPoTipu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgMaksPoTipu_KeyUp);
            this.dgMaksPoTipu.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dgMaksPoTipu_MouseWheel);
            this.dgMaksPoTipu.GotFocus += new System.EventHandler(this.dgMaksPoTipu_GotFocus);
            // 
            // colnas_ID2
            // 
            this.colnas_ID2.FieldName = "nas_ID";
            this.colnas_ID2.Name = "colnas_ID2";
            // 
            // coltip_sifra
            // 
            this.coltip_sifra.Caption = "Šifra tipa poslovnice";
            this.coltip_sifra.FieldName = "tip_sifra";
            this.coltip_sifra.Name = "coltip_sifra";
            this.coltip_sifra.OptionsColumn.AllowEdit = false;
            this.coltip_sifra.Visible = true;
            this.coltip_sifra.VisibleIndex = 0;
            this.coltip_sifra.Width = 124;
            // 
            // colnas_maxkoeficijent
            // 
            this.colnas_maxkoeficijent.Caption = "Maksimum narudžbe";
            this.colnas_maxkoeficijent.FieldName = "nas_maxkoeficijent";
            this.colnas_maxkoeficijent.Name = "colnas_maxkoeficijent";
            this.colnas_maxkoeficijent.Visible = true;
            this.colnas_maxkoeficijent.VisibleIndex = 1;
            this.colnas_maxkoeficijent.Width = 128;
            // 
            // coloperater
            // 
            this.coloperater.Caption = "Operater";
            this.coloperater.FieldName = "operater";
            this.coloperater.Name = "coloperater";
            this.coloperater.OptionsColumn.AllowEdit = false;
            this.coloperater.Visible = true;
            this.coloperater.VisibleIndex = 2;
            this.coloperater.Width = 165;
            // 
            // colnas_datumizmjene2
            // 
            this.colnas_datumizmjene2.Caption = "Izmjena";
            this.colnas_datumizmjene2.FieldName = "nas_datumizmjene";
            this.colnas_datumizmjene2.Name = "colnas_datumizmjene2";
            this.colnas_datumizmjene2.OptionsColumn.AllowEdit = false;
            this.colnas_datumizmjene2.Visible = true;
            this.colnas_datumizmjene2.VisibleIndex = 3;
            this.colnas_datumizmjene2.Width = 148;
            // 
            // colTIP_id
            // 
            this.colTIP_id.FieldName = "TIP_id";
            this.colTIP_id.Name = "colTIP_id";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblNaziviSifraArtikla);
            this.panel3.Controls.Add(this.lblCjenik2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 90);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maksimalni koeficijent prema tipu poslovnice za artikl";
            // 
            // lblNaziviSifraArtikla
            // 
            this.lblNaziviSifraArtikla.AutoSize = true;
            this.lblNaziviSifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziviSifraArtikla.Location = new System.Drawing.Point(22, 29);
            this.lblNaziviSifraArtikla.Name = "lblNaziviSifraArtikla";
            this.lblNaziviSifraArtikla.Size = new System.Drawing.Size(29, 16);
            this.lblNaziviSifraArtikla.TabIndex = 2;
            this.lblNaziviSifraArtikla.Text = "___";
            // 
            // lblCjenik2
            // 
            this.lblCjenik2.AutoSize = true;
            this.lblCjenik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCjenik2.Location = new System.Drawing.Point(22, 9);
            this.lblCjenik2.Name = "lblCjenik2";
            this.lblCjenik2.Size = new System.Drawing.Size(32, 18);
            this.lblCjenik2.TabIndex = 1;
            this.lblCjenik2.Text = "___";
            // 
            // tipPoslovniceMaksimumTableAdapter
            // 
            this.tipPoslovniceMaksimumTableAdapter.ClearBeforeFill = true;
            // 
            // frmAzurirajAkcijskiNabavniStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 558);
            this.Controls.Add(this.tabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAzurirajAkcijskiNabavniStavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriraj akcijski cjenik stavke";
            this.Deactivate += new System.EventHandler(this.frmAzurirajAkcijskiNabavniStavke_Deactivate);
            this.Load += new System.EventHandler(this.frmAzurirajAkcijskiNabavniStavke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAzurirajAkcijskiNabavniStavke_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavnistavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavneCijenePoCjenicima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxKoeficijent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNabavneCijenePoCjenicima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaksimumPoTipu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipPoslovniceMaksimumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipMaksimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaksPoTipu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.BindingSource nabavnistavkaBindingSource;
        private NabavneCijenePoCjenicima nabavneCijenePoCjenicima;
        private NabavneCijenePoCjenicimaTableAdapters.nabavnistavkaTableAdapter nabavnistavkaTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colnabavniCjenik_nac_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_tvornickacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_postorabata;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_akcijskacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_akcijskirabat;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_datumizmjene;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vaziod;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vazido;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtMaxKoeficijent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtAkcijskaCijena;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtAkcijskiRabat;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtRabat;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtTvornickaCijena;
        private DevExpress.XtraGrid.GridControl dgNabavneCijenePoCjenicima;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colnabavniCjenik_nac_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_tvornickacijena1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_postorabata1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_akcijskacijena1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_akcijskirabat1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_datumizmjene1;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vaziod1;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vazido1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtIzmjena;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtSifArtikl;
        private System.Windows.Forms.TextBox txtSifKodDobavljac;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCjenik;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl dgMaksimumPoTipu;
        private DevExpress.XtraGrid.Views.Grid.GridView dgMaksPoTipu;
        private System.Windows.Forms.Label lblCjenik2;
        private System.Windows.Forms.Label lblNaziviSifraArtikla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipPoslovniceMaksimumBindingSource;
        private TipMaksimum tipMaksimum;
        private TipMaksimumTableAdapters.tipPoslovniceMaksimumTableAdapter tipPoslovniceMaksimumTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn coltip_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_maxkoeficijent;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_datumizmjene2;
        private DevExpress.XtraGrid.Columns.GridColumn colTIP_id;
    }
}