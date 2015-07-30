namespace blokerX
{
    partial class frmSnizenjaOdDobavljaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnizenjaOdDobavljaca));
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner = new blokerX.Partner();
            this.kategorijeAkcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeAkcija = new blokerX.KategorijeAkcija();
            this.partnerTableAdapter = new blokerX.PartnerTableAdapters.partnerTableAdapter();
            this.kategorijeAkcijaTableAdapter = new blokerX.KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter();
            this.artiklDobavljacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snizenja = new blokerX.Snizenja();
            this.snizeniArtikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snizenje_odabrani = new blokerX.Snizenje_odabrani();
            this.artiklDobavljacaTableAdapter = new blokerX.SnizenjaTableAdapters.artiklDobavljacaTableAdapter();
            this.snizeniArtikliTableAdapter = new blokerX.Snizenje_odabraniTableAdapters.SnizeniArtikliTableAdapter();
            this.zaliheStanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akcijeStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaliheStanjeTableAdapter = new blokerX.Snizenje_odabraniTableAdapters.zaliheStanjeTableAdapter();
            this.akcijeStavkeTableAdapter = new blokerX.Snizenje_odabraniTableAdapters.akcijeStavkeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVrijednost = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.glPartner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpa_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDokumPar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPopust = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAktivna = new System.Windows.Forms.ComboBox();
            this.txtBrojAkcije = new System.Windows.Forms.TextBox();
            this.dtpDOKada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpODKada = new System.Windows.Forms.DateTimePicker();
            this.colar_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_Sifra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Spremi = new System.Windows.Forms.Button();
            this.Brisi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgSnizeniArtikl = new DevExpress.XtraGrid.GridControl();
            this.dgSnizeni = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colARTIKL_AR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARTIKL_AR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBK_KOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgArtiklDobavljac = new DevExpress.XtraGrid.GridControl();
            this.dgArtikDobav = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_Sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoa_sifraKodDobavljaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbk_kod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colAR_NAZIV3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_Sifra2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgSnizeniArtikliStanja = new DevExpress.XtraGrid.GridControl();
            this.dgSnizeniStanja = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colar_sifra3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_naziv6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colza_stanje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colza_nabcij = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colza_maloprodcijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnica = new blokerX.Poslovnica();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgArtikliUAkciji = new DevExpress.XtraGrid.GridControl();
            this.dgartikliUAkcijiStavke = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAR_SIFRA4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_KOLIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_POPUST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_AKTIVNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_VAZIOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_VAZIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBK_KOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colakc_cijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.pnlIzmjenaStavkiAkcije = new System.Windows.Forms.Panel();
            this.ckbIstekRoka = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCijena = new DevExpress.XtraEditors.TextEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbAktivnaStavka = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPopustStavka = new DevExpress.XtraEditors.TextEdit();
            this.txtKolicina = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOpisStavka = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Spremi2 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.colar_naziv4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.poslovnicaTableAdapter = new blokerX.PoslovnicaTableAdapters.poslovnicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklDobavljacaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizeniArtikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenje_odabrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheStanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeStavkeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrijednost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtiklDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikDobav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniArtikliStanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniStanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikliUAkciji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgartikliUAkcijiStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.pnlIzmjenaStavkiAkcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopustStavka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina.Properties)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "partner";
            this.partnerBindingSource.DataSource = this.partner;
            // 
            // partner
            // 
            this.partner.DataSetName = "Partner";
            this.partner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijeAkcijaBindingSource
            // 
            this.kategorijeAkcijaBindingSource.DataMember = "kategorijeAkcija";
            this.kategorijeAkcijaBindingSource.DataSource = this.kategorijeAkcija;
            // 
            // kategorijeAkcija
            // 
            this.kategorijeAkcija.DataSetName = "KategorijeAkcija";
            this.kategorijeAkcija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijeAkcijaTableAdapter
            // 
            this.kategorijeAkcijaTableAdapter.ClearBeforeFill = true;
            // 
            // artiklDobavljacaBindingSource
            // 
            this.artiklDobavljacaBindingSource.DataMember = "artiklDobavljaca";
            this.artiklDobavljacaBindingSource.DataSource = this.snizenja;
            // 
            // snizenja
            // 
            this.snizenja.DataSetName = "Snizenja";
            this.snizenja.EnforceConstraints = false;
            this.snizenja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snizeniArtikliBindingSource
            // 
            this.snizeniArtikliBindingSource.DataMember = "SnizeniArtikli";
            this.snizeniArtikliBindingSource.DataSource = this.snizenje_odabrani;
            // 
            // snizenje_odabrani
            // 
            this.snizenje_odabrani.DataSetName = "Snizenje_odabrani";
            this.snizenje_odabrani.EnforceConstraints = false;
            this.snizenje_odabrani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklDobavljacaTableAdapter
            // 
            this.artiklDobavljacaTableAdapter.ClearBeforeFill = true;
            // 
            // snizeniArtikliTableAdapter
            // 
            this.snizeniArtikliTableAdapter.ClearBeforeFill = true;
            // 
            // zaliheStanjeBindingSource
            // 
            this.zaliheStanjeBindingSource.DataMember = "zaliheStanje";
            this.zaliheStanjeBindingSource.DataSource = this.snizenje_odabrani;
            // 
            // akcijeStavkeBindingSource
            // 
            this.akcijeStavkeBindingSource.DataMember = "akcijeStavke";
            this.akcijeStavkeBindingSource.DataSource = this.snizenje_odabrani;
            // 
            // zaliheStanjeTableAdapter
            // 
            this.zaliheStanjeTableAdapter.ClearBeforeFill = true;
            // 
            // akcijeStavkeTableAdapter
            // 
            this.akcijeStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVrijednost);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.glPartner);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtDokumPar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPopust);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSpremi);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbAktivna);
            this.panel1.Controls.Add(this.txtBrojAkcije);
            this.panel1.Controls.Add(this.dtpDOKada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpODKada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 243);
            this.panel1.TabIndex = 1;
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(377, 93);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Properties.Mask.EditMask = "n2";
            this.txtVrijednost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVrijednost.Properties.ReadOnly = true;
            this.txtVrijednost.Size = new System.Drawing.Size(107, 20);
            this.txtVrijednost.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(270, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "Vrijednost sniženja:";
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Location = new System.Drawing.Point(184, 208);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "pa_naziv";
            this.glPartner.Properties.ImmediatePopup = true;
            this.glPartner.Properties.NullText = "";
            this.glPartner.Properties.ValueMember = "pa_ID";
            this.glPartner.Properties.View = this.gridView2;
            this.glPartner.Size = new System.Drawing.Size(300, 20);
            this.glPartner.TabIndex = 15;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpa_ID,
            this.colpa_naziv});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colpa_ID
            // 
            this.colpa_ID.FieldName = "pa_ID";
            this.colpa_ID.Name = "colpa_ID";
            // 
            // colpa_naziv
            // 
            this.colpa_naziv.Caption = "Naziv";
            this.colpa_naziv.FieldName = "pa_naziv";
            this.colpa_naziv.Name = "colpa_naziv";
            this.colpa_naziv.Visible = true;
            this.colpa_naziv.VisibleIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Partner:";
            // 
            // txtDokumPar
            // 
            this.txtDokumPar.Location = new System.Drawing.Point(185, 177);
            this.txtDokumPar.Name = "txtDokumPar";
            this.txtDokumPar.Size = new System.Drawing.Size(299, 20);
            this.txtDokumPar.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dokument partnera:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(184, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sniženja od dobavljača";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(186, 145);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Properties.Mask.EditMask = "P2";
            this.txtPopust.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPopust.Size = new System.Drawing.Size(121, 20);
            this.txtPopust.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Popust (%):";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(596, 211);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(186, 119);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(328, 20);
            this.txtOpis.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija akcije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Akcija aktivna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj akcije:";
            // 
            // cmbAktivna
            // 
            this.cmbAktivna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivna.FormattingEnabled = true;
            this.cmbAktivna.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAktivna.Location = new System.Drawing.Point(186, 91);
            this.cmbAktivna.Name = "cmbAktivna";
            this.cmbAktivna.Size = new System.Drawing.Size(68, 21);
            this.cmbAktivna.TabIndex = 9;
            // 
            // txtBrojAkcije
            // 
            this.txtBrojAkcije.Location = new System.Drawing.Point(186, 39);
            this.txtBrojAkcije.Name = "txtBrojAkcije";
            this.txtBrojAkcije.Size = new System.Drawing.Size(100, 20);
            this.txtBrojAkcije.TabIndex = 4;
            // 
            // dtpDOKada
            // 
            this.dtpDOKada.CustomFormat = " ";
            this.dtpDOKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOKada.Location = new System.Drawing.Point(377, 65);
            this.dtpDOKada.Name = "dtpDOKada";
            this.dtpDOKada.Size = new System.Drawing.Size(107, 20);
            this.dtpDOKada.TabIndex = 8;
            this.dtpDOKada.ValueChanged += new System.EventHandler(this.dtpDOKada_ValueChanged);
            this.dtpDOKada.Enter += new System.EventHandler(this.dtpDOKada_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Važi od dana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "do dana:";
            // 
            // dtpODKada
            // 
            this.dtpODKada.CustomFormat = " ";
            this.dtpODKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpODKada.Location = new System.Drawing.Point(186, 65);
            this.dtpODKada.Name = "dtpODKada";
            this.dtpODKada.Size = new System.Drawing.Size(113, 20);
            this.dtpODKada.TabIndex = 6;
            this.dtpODKada.ValueChanged += new System.EventHandler(this.dtpODKada_ValueChanged);
            this.dtpODKada.Enter += new System.EventHandler(this.dtpODKada_Enter);
            // 
            // colar_ID1
            // 
            this.colar_ID1.FieldName = "ar_ID";
            this.colar_ID1.Name = "colar_ID1";
            this.colar_ID1.Visible = true;
            this.colar_ID1.VisibleIndex = 0;
            // 
            // colAR_NAZIV2
            // 
            this.colAR_NAZIV2.FieldName = "AR_NAZIV";
            this.colAR_NAZIV2.Name = "colAR_NAZIV2";
            this.colAR_NAZIV2.Visible = true;
            this.colAR_NAZIV2.VisibleIndex = 1;
            // 
            // colar_Sifra1
            // 
            this.colar_Sifra1.FieldName = "ar_Sifra";
            this.colar_Sifra1.Name = "colar_Sifra1";
            this.colar_Sifra1.Visible = true;
            this.colar_Sifra1.VisibleIndex = 2;
            // 
            // colar_ID2
            // 
            this.colar_ID2.FieldName = "ar_ID";
            this.colar_ID2.Name = "colar_ID2";
            this.colar_ID2.Visible = true;
            this.colar_ID2.VisibleIndex = 0;
            // 
            // Spremi
            // 
            this.Spremi.Image = ((System.Drawing.Image)(resources.GetObject("Spremi.Image")));
            this.Spremi.Location = new System.Drawing.Point(601, 88);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(40, 43);
            this.Spremi.TabIndex = 5;
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // Brisi
            // 
            this.Brisi.Image = ((System.Drawing.Image)(resources.GetObject("Brisi.Image")));
            this.Brisi.Location = new System.Drawing.Point(601, 137);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(40, 43);
            this.Brisi.TabIndex = 6;
            this.Brisi.UseVisualStyleBackColor = true;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 57);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Svi artikli dobavljača";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(591, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sniženi artikli dobavljača";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgSnizeniArtikl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(833, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 313);
            this.panel6.TabIndex = 8;
            // 
            // dgSnizeniArtikl
            // 
            this.dgSnizeniArtikl.DataSource = this.snizeniArtikliBindingSource;
            this.dgSnizeniArtikl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSnizeniArtikl.Location = new System.Drawing.Point(0, 0);
            this.dgSnizeniArtikl.MainView = this.dgSnizeni;
            this.dgSnizeniArtikl.Name = "dgSnizeniArtikl";
            this.dgSnizeniArtikl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.dgSnizeniArtikl.Size = new System.Drawing.Size(440, 313);
            this.dgSnizeniArtikl.TabIndex = 14;
            this.dgSnizeniArtikl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgSnizeni});
            // 
            // dgSnizeni
            // 
            this.dgSnizeni.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeni.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeni.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.Empty.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeni.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeni.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeni.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgSnizeni.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgSnizeni.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeni.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeni.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeni.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeni.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgSnizeni.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.GroupRow.Options.UseFont = true;
            this.dgSnizeni.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeni.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeni.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeni.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgSnizeni.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgSnizeni.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeni.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizeni.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.OddRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.OddRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgSnizeni.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgSnizeni.Appearance.Preview.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.Preview.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.Row.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.Row.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgSnizeni.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgSnizeni.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeni.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgSnizeni.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgSnizeni.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizeni.Appearance.VertLine.Options.UseBackColor = true;
            this.dgSnizeni.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colARTIKL_AR_ID,
            this.colARTIKL_AR_SIFRA,
            this.colBK_KOD,
            this.colAR_NAZIV1});
            this.dgSnizeni.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgSnizeni.GridControl = this.dgSnizeniArtikl;
            this.dgSnizeni.Name = "dgSnizeni";
            this.dgSnizeni.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizeni.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizeni.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgSnizeni.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgSnizeni.OptionsBehavior.Editable = false;
            this.dgSnizeni.OptionsCustomization.AllowColumnMoving = false;
            this.dgSnizeni.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgSnizeni.OptionsView.ColumnAutoWidth = false;
            this.dgSnizeni.OptionsView.EnableAppearanceEvenRow = true;
            this.dgSnizeni.OptionsView.EnableAppearanceOddRow = true;
            this.dgSnizeni.OptionsView.ShowAutoFilterRow = true;
            this.dgSnizeni.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgSnizeni.OptionsView.ShowGroupPanel = false;
            this.dgSnizeni.OptionsView.ShowIndicator = false;
            this.dgSnizeni.PaintStyleName = "WindowsXP";
            this.dgSnizeni.SynchronizeClones = false;
            // 
            // colARTIKL_AR_ID
            // 
            this.colARTIKL_AR_ID.FieldName = "ARTIKL_AR_ID";
            this.colARTIKL_AR_ID.Name = "colARTIKL_AR_ID";
            // 
            // colARTIKL_AR_SIFRA
            // 
            this.colARTIKL_AR_SIFRA.Caption = "Šifra artikla";
            this.colARTIKL_AR_SIFRA.FieldName = "ARTIKL_AR_SIFRA";
            this.colARTIKL_AR_SIFRA.Name = "colARTIKL_AR_SIFRA";
            this.colARTIKL_AR_SIFRA.Visible = true;
            this.colARTIKL_AR_SIFRA.VisibleIndex = 0;
            // 
            // colBK_KOD
            // 
            this.colBK_KOD.Caption = "Barkod";
            this.colBK_KOD.FieldName = "BK_KOD";
            this.colBK_KOD.Name = "colBK_KOD";
            this.colBK_KOD.Visible = true;
            this.colBK_KOD.VisibleIndex = 1;
            this.colBK_KOD.Width = 116;
            // 
            // colAR_NAZIV1
            // 
            this.colAR_NAZIV1.Caption = "Naziv artikla";
            this.colAR_NAZIV1.FieldName = "AR_NAZIV";
            this.colAR_NAZIV1.Name = "colAR_NAZIV1";
            this.colAR_NAZIV1.Visible = true;
            this.colAR_NAZIV1.VisibleIndex = 2;
            this.colAR_NAZIV1.Width = 212;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgArtiklDobavljac);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(571, 313);
            this.panel7.TabIndex = 9;
            // 
            // dgArtiklDobavljac
            // 
            this.dgArtiklDobavljac.DataSource = this.artiklDobavljacaBindingSource;
            this.dgArtiklDobavljac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtiklDobavljac.Location = new System.Drawing.Point(0, 0);
            this.dgArtiklDobavljac.MainView = this.dgArtikDobav;
            this.dgArtiklDobavljac.Name = "dgArtiklDobavljac";
            this.dgArtiklDobavljac.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.dgArtiklDobavljac.Size = new System.Drawing.Size(571, 313);
            this.dgArtiklDobavljac.TabIndex = 14;
            this.dgArtiklDobavljac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgArtikDobav,
            this.gridView1});
            // 
            // dgArtikDobav
            // 
            this.dgArtikDobav.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikDobav.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikDobav.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.Empty.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikDobav.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikDobav.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikDobav.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgArtikDobav.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgArtikDobav.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikDobav.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikDobav.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikDobav.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgArtikDobav.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgArtikDobav.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.GroupRow.Options.UseFont = true;
            this.dgArtikDobav.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgArtikDobav.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgArtikDobav.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgArtikDobav.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgArtikDobav.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgArtikDobav.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgArtikDobav.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgArtikDobav.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.OddRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.OddRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgArtikDobav.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgArtikDobav.Appearance.Preview.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.Preview.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.Row.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.Row.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgArtikDobav.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgArtikDobav.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgArtikDobav.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgArtikDobav.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgArtikDobav.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgArtikDobav.Appearance.VertLine.Options.UseBackColor = true;
            this.dgArtikDobav.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colar_ID,
            this.colAR_NAZIV,
            this.colar_Sifra,
            this.coldoa_sifraKodDobavljaca,
            this.colbk_kod2});
            this.dgArtikDobav.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgArtikDobav.GridControl = this.dgArtiklDobavljac;
            this.dgArtikDobav.Name = "dgArtikDobav";
            this.dgArtikDobav.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgArtikDobav.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgArtikDobav.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgArtikDobav.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgArtikDobav.OptionsBehavior.Editable = false;
            this.dgArtikDobav.OptionsCustomization.AllowColumnMoving = false;
            this.dgArtikDobav.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgArtikDobav.OptionsView.ColumnAutoWidth = false;
            this.dgArtikDobav.OptionsView.EnableAppearanceEvenRow = true;
            this.dgArtikDobav.OptionsView.EnableAppearanceOddRow = true;
            this.dgArtikDobav.OptionsView.ShowAutoFilterRow = true;
            this.dgArtikDobav.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgArtikDobav.OptionsView.ShowGroupPanel = false;
            this.dgArtikDobav.OptionsView.ShowIndicator = false;
            this.dgArtikDobav.PaintStyleName = "WindowsXP";
            this.dgArtikDobav.SynchronizeClones = false;
            // 
            // colar_ID
            // 
            this.colar_ID.FieldName = "ar_ID";
            this.colar_ID.Name = "colar_ID";
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 2;
            this.colAR_NAZIV.Width = 264;
            // 
            // colar_Sifra
            // 
            this.colar_Sifra.Caption = "Šifra artikla";
            this.colar_Sifra.FieldName = "ar_Sifra";
            this.colar_Sifra.Name = "colar_Sifra";
            this.colar_Sifra.Visible = true;
            this.colar_Sifra.VisibleIndex = 0;
            this.colar_Sifra.Width = 86;
            // 
            // coldoa_sifraKodDobavljaca
            // 
            this.coldoa_sifraKodDobavljaca.Caption = "Šifra kod dobavljača";
            this.coldoa_sifraKodDobavljaca.FieldName = "doa_sifraKodDobavljaca";
            this.coldoa_sifraKodDobavljaca.Name = "coldoa_sifraKodDobavljaca";
            this.coldoa_sifraKodDobavljaca.Visible = true;
            this.coldoa_sifraKodDobavljaca.VisibleIndex = 1;
            this.coldoa_sifraKodDobavljaca.Width = 117;
            // 
            // colbk_kod2
            // 
            this.colbk_kod2.Caption = "Barkod";
            this.colbk_kod2.FieldName = "bk_kod";
            this.colbk_kod2.Name = "colbk_kod2";
            this.colbk_kod2.Visible = true;
            this.colbk_kod2.VisibleIndex = 3;
            this.colbk_kod2.Width = 85;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colar_ID,
            this.colAR_NAZIV,
            this.colar_Sifra,
            this.coldoa_sifraKodDobavljaca});
            this.gridView1.GridControl = this.dgArtiklDobavljac;
            this.gridView1.Name = "gridView1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Brisi);
            this.panel3.Controls.Add(this.Spremi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 372);
            this.panel3.TabIndex = 6;
            // 
            // colAR_NAZIV3
            // 
            this.colAR_NAZIV3.FieldName = "AR_NAZIV";
            this.colAR_NAZIV3.Name = "colAR_NAZIV3";
            this.colAR_NAZIV3.Visible = true;
            this.colAR_NAZIV3.VisibleIndex = 1;
            // 
            // colar_Sifra2
            // 
            this.colar_Sifra2.FieldName = "ar_Sifra";
            this.colar_Sifra2.Name = "colar_Sifra2";
            this.colar_Sifra2.Visible = true;
            this.colar_Sifra2.VisibleIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(0, 615);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1275, 400);
            this.panel5.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgSnizeniArtikliStanja);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(468, 341);
            this.panel8.TabIndex = 9;
            // 
            // dgSnizeniArtikliStanja
            // 
            this.dgSnizeniArtikliStanja.DataSource = this.zaliheStanjeBindingSource;
            this.dgSnizeniArtikliStanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSnizeniArtikliStanja.Location = new System.Drawing.Point(0, 86);
            this.dgSnizeniArtikliStanja.MainView = this.dgSnizeniStanja;
            this.dgSnizeniArtikliStanja.Name = "dgSnizeniArtikliStanja";
            this.dgSnizeniArtikliStanja.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit3});
            this.dgSnizeniArtikliStanja.Size = new System.Drawing.Size(468, 255);
            this.dgSnizeniArtikliStanja.TabIndex = 29;
            this.dgSnizeniArtikliStanja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgSnizeniStanja,
            this.gridView3});
            this.dgSnizeniArtikliStanja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSnizeniArtikliStanja_KeyDown);
            // 
            // dgSnizeniStanja
            // 
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.Empty.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeniStanja.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeniStanja.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeniStanja.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgSnizeniStanja.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgSnizeniStanja.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeniStanja.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeniStanja.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeniStanja.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizeniStanja.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgSnizeniStanja.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.GroupRow.Options.UseFont = true;
            this.dgSnizeniStanja.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizeniStanja.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizeniStanja.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizeniStanja.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgSnizeniStanja.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgSnizeniStanja.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizeniStanja.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizeniStanja.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.OddRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.OddRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgSnizeniStanja.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgSnizeniStanja.Appearance.Preview.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.Preview.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.Row.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.Row.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgSnizeniStanja.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgSnizeniStanja.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizeniStanja.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgSnizeniStanja.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgSnizeniStanja.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizeniStanja.Appearance.VertLine.Options.UseBackColor = true;
            this.dgSnizeniStanja.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colar_sifra3,
            this.colar_naziv6,
            this.colza_stanje,
            this.colza_nabcij,
            this.colza_maloprodcijena});
            this.dgSnizeniStanja.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgSnizeniStanja.GridControl = this.dgSnizeniArtikliStanja;
            this.dgSnizeniStanja.Name = "dgSnizeniStanja";
            this.dgSnizeniStanja.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizeniStanja.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizeniStanja.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgSnizeniStanja.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgSnizeniStanja.OptionsBehavior.Editable = false;
            this.dgSnizeniStanja.OptionsCustomization.AllowColumnMoving = false;
            this.dgSnizeniStanja.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgSnizeniStanja.OptionsView.ColumnAutoWidth = false;
            this.dgSnizeniStanja.OptionsView.EnableAppearanceEvenRow = true;
            this.dgSnizeniStanja.OptionsView.EnableAppearanceOddRow = true;
            this.dgSnizeniStanja.OptionsView.ShowAutoFilterRow = true;
            this.dgSnizeniStanja.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgSnizeniStanja.OptionsView.ShowGroupPanel = false;
            this.dgSnizeniStanja.OptionsView.ShowIndicator = false;
            this.dgSnizeniStanja.PaintStyleName = "WindowsXP";
            this.dgSnizeniStanja.SynchronizeClones = false;
            // 
            // colar_sifra3
            // 
            this.colar_sifra3.Caption = "Šifra";
            this.colar_sifra3.FieldName = "ar_sifra";
            this.colar_sifra3.Name = "colar_sifra3";
            this.colar_sifra3.Visible = true;
            this.colar_sifra3.VisibleIndex = 0;
            this.colar_sifra3.Width = 51;
            // 
            // colar_naziv6
            // 
            this.colar_naziv6.Caption = "Naziv";
            this.colar_naziv6.FieldName = "ar_naziv";
            this.colar_naziv6.Name = "colar_naziv6";
            this.colar_naziv6.Visible = true;
            this.colar_naziv6.VisibleIndex = 1;
            this.colar_naziv6.Width = 210;
            // 
            // colza_stanje
            // 
            this.colza_stanje.Caption = "Stanje";
            this.colza_stanje.FieldName = "za_stanje";
            this.colza_stanje.Name = "colza_stanje";
            this.colza_stanje.Visible = true;
            this.colza_stanje.VisibleIndex = 2;
            this.colza_stanje.Width = 54;
            // 
            // colza_nabcij
            // 
            this.colza_nabcij.Caption = "Nab cij.";
            this.colza_nabcij.FieldName = "za_nabcij";
            this.colza_nabcij.Name = "colza_nabcij";
            this.colza_nabcij.Visible = true;
            this.colza_nabcij.VisibleIndex = 3;
            // 
            // colza_maloprodcijena
            // 
            this.colza_maloprodcijena.Caption = "Prod cij.";
            this.colza_maloprodcijena.FieldName = "za_maloprodcijena";
            this.colza_maloprodcijena.Name = "colza_maloprodcijena";
            this.colza_maloprodcijena.Visible = true;
            this.colza_maloprodcijena.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAR_NAZIV1,
            this.colar_sifra3,
            this.colza_stanje,
            this.colARTIKL_AR_ID});
            this.gridView3.GridControl = this.dgSnizeniArtikliStanja;
            this.gridView3.Name = "gridView3";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.glPoslovnica);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(468, 86);
            this.panel10.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "F7 - dodaj u akciju";
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(9, 34);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ImmediatePopup = true;
            this.glPoslovnica.Properties.NullText = "";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Size = new System.Drawing.Size(298, 20);
            this.glPoslovnica.TabIndex = 28;
            this.glPoslovnica.EditValueChanged += new System.EventHandler(this.glPoslovnica_EditValueChanged);
            this.glPoslovnica.Leave += new System.EventHandler(this.glPoslovnica_Leave);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(6, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Poslovnica:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgArtikliUAkciji);
            this.panel9.Controls.Add(this.pnlIzmjenaStavkiAkcije);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(584, 57);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(689, 341);
            this.panel9.TabIndex = 8;
            // 
            // dgArtikliUAkciji
            // 
            this.dgArtikliUAkciji.DataSource = this.akcijeStavkeBindingSource;
            this.dgArtikliUAkciji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtikliUAkciji.Location = new System.Drawing.Point(0, 208);
            this.dgArtikliUAkciji.MainView = this.dgartikliUAkcijiStavke;
            this.dgArtikliUAkciji.Name = "dgArtikliUAkciji";
            this.dgArtikliUAkciji.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit4});
            this.dgArtikliUAkciji.Size = new System.Drawing.Size(689, 133);
            this.dgArtikliUAkciji.TabIndex = 18;
            this.dgArtikliUAkciji.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgartikliUAkcijiStavke});
            this.dgArtikliUAkciji.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgArtikliUAkciji_KeyDown);
            // 
            // dgartikliUAkcijiStavke
            // 
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.Empty.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgartikliUAkcijiStavke.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgartikliUAkcijiStavke.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgartikliUAkcijiStavke.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.Options.UseFont = true;
            this.dgartikliUAkcijiStavke.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgartikliUAkcijiStavke.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgartikliUAkcijiStavke.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgartikliUAkcijiStavke.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.OddRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.OddRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgartikliUAkcijiStavke.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgartikliUAkcijiStavke.Appearance.Preview.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.Preview.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.Row.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.Row.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgartikliUAkcijiStavke.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgartikliUAkcijiStavke.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgartikliUAkcijiStavke.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgartikliUAkcijiStavke.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgartikliUAkcijiStavke.Appearance.VertLine.Options.UseBackColor = true;
            this.dgartikliUAkcijiStavke.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAR_SIFRA4,
            this.colAR_NAZIV5,
            this.colPOK_KOLIC,
            this.colAKC_POPUST,
            this.colAKC_AKTIVNA,
            this.colPOK_VAZIOD,
            this.colPOK_VAZIDO,
            this.colBK_KOD1,
            this.colakc_cijena});
            this.dgartikliUAkcijiStavke.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgartikliUAkcijiStavke.GridControl = this.dgArtikliUAkciji;
            this.dgartikliUAkcijiStavke.Name = "dgartikliUAkcijiStavke";
            this.dgartikliUAkcijiStavke.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgartikliUAkcijiStavke.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgartikliUAkcijiStavke.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgartikliUAkcijiStavke.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgartikliUAkcijiStavke.OptionsBehavior.Editable = false;
            this.dgartikliUAkcijiStavke.OptionsCustomization.AllowColumnMoving = false;
            this.dgartikliUAkcijiStavke.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgartikliUAkcijiStavke.OptionsView.ColumnAutoWidth = false;
            this.dgartikliUAkcijiStavke.OptionsView.EnableAppearanceEvenRow = true;
            this.dgartikliUAkcijiStavke.OptionsView.EnableAppearanceOddRow = true;
            this.dgartikliUAkcijiStavke.OptionsView.ShowAutoFilterRow = true;
            this.dgartikliUAkcijiStavke.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgartikliUAkcijiStavke.OptionsView.ShowGroupPanel = false;
            this.dgartikliUAkcijiStavke.OptionsView.ShowIndicator = false;
            this.dgartikliUAkcijiStavke.PaintStyleName = "WindowsXP";
            this.dgartikliUAkcijiStavke.SynchronizeClones = false;
            // 
            // colAR_SIFRA4
            // 
            this.colAR_SIFRA4.Caption = "Šifra";
            this.colAR_SIFRA4.FieldName = "AR_SIFRA";
            this.colAR_SIFRA4.Name = "colAR_SIFRA4";
            this.colAR_SIFRA4.Visible = true;
            this.colAR_SIFRA4.VisibleIndex = 0;
            this.colAR_SIFRA4.Width = 65;
            // 
            // colAR_NAZIV5
            // 
            this.colAR_NAZIV5.Caption = "Naziv";
            this.colAR_NAZIV5.FieldName = "AR_NAZIV";
            this.colAR_NAZIV5.Name = "colAR_NAZIV5";
            this.colAR_NAZIV5.Visible = true;
            this.colAR_NAZIV5.VisibleIndex = 1;
            this.colAR_NAZIV5.Width = 161;
            // 
            // colPOK_KOLIC
            // 
            this.colPOK_KOLIC.Caption = "Količina";
            this.colPOK_KOLIC.FieldName = "POK_KOLIC";
            this.colPOK_KOLIC.Name = "colPOK_KOLIC";
            this.colPOK_KOLIC.Visible = true;
            this.colPOK_KOLIC.VisibleIndex = 2;
            this.colPOK_KOLIC.Width = 59;
            // 
            // colAKC_POPUST
            // 
            this.colAKC_POPUST.Caption = "Popust";
            this.colAKC_POPUST.FieldName = "AKC_POPUST";
            this.colAKC_POPUST.Name = "colAKC_POPUST";
            this.colAKC_POPUST.Visible = true;
            this.colAKC_POPUST.VisibleIndex = 3;
            this.colAKC_POPUST.Width = 51;
            // 
            // colAKC_AKTIVNA
            // 
            this.colAKC_AKTIVNA.Caption = "Aktivna";
            this.colAKC_AKTIVNA.FieldName = "AKC_AKTIVNA";
            this.colAKC_AKTIVNA.Name = "colAKC_AKTIVNA";
            this.colAKC_AKTIVNA.Visible = true;
            this.colAKC_AKTIVNA.VisibleIndex = 4;
            this.colAKC_AKTIVNA.Width = 54;
            // 
            // colPOK_VAZIOD
            // 
            this.colPOK_VAZIOD.Caption = "Važi od";
            this.colPOK_VAZIOD.FieldName = "POK_VAZIOD";
            this.colPOK_VAZIOD.Name = "colPOK_VAZIOD";
            this.colPOK_VAZIOD.Visible = true;
            this.colPOK_VAZIOD.VisibleIndex = 5;
            this.colPOK_VAZIOD.Width = 73;
            // 
            // colPOK_VAZIDO
            // 
            this.colPOK_VAZIDO.Caption = "Važi do";
            this.colPOK_VAZIDO.FieldName = "POK_VAZIDO";
            this.colPOK_VAZIDO.Name = "colPOK_VAZIDO";
            this.colPOK_VAZIDO.Visible = true;
            this.colPOK_VAZIDO.VisibleIndex = 6;
            this.colPOK_VAZIDO.Width = 70;
            // 
            // colBK_KOD1
            // 
            this.colBK_KOD1.Caption = "Barkod";
            this.colBK_KOD1.FieldName = "BK_KOD";
            this.colBK_KOD1.Name = "colBK_KOD1";
            this.colBK_KOD1.Visible = true;
            this.colBK_KOD1.VisibleIndex = 7;
            // 
            // colakc_cijena
            // 
            this.colakc_cijena.Caption = "Cijena";
            this.colakc_cijena.FieldName = "akc_cijena";
            this.colakc_cijena.Name = "colakc_cijena";
            this.colakc_cijena.Visible = true;
            this.colakc_cijena.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // pnlIzmjenaStavkiAkcije
            // 
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.ckbIstekRoka);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label26);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.txtCijena);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label24);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.btnClose);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.cmbAktivnaStavka);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label23);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.dtpDatumDO);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label18);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.dtpDatumOD);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label22);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.txtPopustStavka);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.txtKolicina);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label10);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label17);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.txtOpisStavka);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.label19);
            this.pnlIzmjenaStavkiAkcije.Controls.Add(this.Spremi2);
            this.pnlIzmjenaStavkiAkcije.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIzmjenaStavkiAkcije.Location = new System.Drawing.Point(0, 54);
            this.pnlIzmjenaStavkiAkcije.Name = "pnlIzmjenaStavkiAkcije";
            this.pnlIzmjenaStavkiAkcije.Size = new System.Drawing.Size(689, 154);
            this.pnlIzmjenaStavkiAkcije.TabIndex = 17;
            // 
            // ckbIstekRoka
            // 
            this.ckbIstekRoka.AutoSize = true;
            this.ckbIstekRoka.Location = new System.Drawing.Point(347, 130);
            this.ckbIstekRoka.Name = "ckbIstekRoka";
            this.ckbIstekRoka.Size = new System.Drawing.Size(73, 17);
            this.ckbIstekRoka.TabIndex = 56;
            this.ckbIstekRoka.Text = "Istek roka";
            this.ckbIstekRoka.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(226, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "%";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(347, 72);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Properties.Mask.EditMask = "n";
            this.txtCijena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 50;
            this.txtCijena.Enter += new System.EventHandler(this.txtCijena_Enter);
            this.txtCijena.Leave += new System.EventHandler(this.txtCijena_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(292, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Cijena:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(641, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 20);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbAktivnaStavka
            // 
            this.cmbAktivnaStavka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivnaStavka.FormattingEnabled = true;
            this.cmbAktivnaStavka.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAktivnaStavka.Location = new System.Drawing.Point(132, 126);
            this.cmbAktivnaStavka.Name = "cmbAktivnaStavka";
            this.cmbAktivnaStavka.Size = new System.Drawing.Size(39, 21);
            this.cmbAktivnaStavka.TabIndex = 55;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "Akc. aktivna:";
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.CustomFormat = " ";
            this.dtpDatumDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDO.Location = new System.Drawing.Point(347, 98);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(130, 20);
            this.dtpDatumDO.TabIndex = 53;
            this.dtpDatumDO.ValueChanged += new System.EventHandler(this.dtpDatumDO_ValueChanged);
            this.dtpDatumDO.Enter += new System.EventHandler(this.dtpDatumDO_Enter);
            this.dtpDatumDO.Leave += new System.EventHandler(this.dtpDatumDO_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(281, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "do datuma:";
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.CustomFormat = " ";
            this.dtpDatumOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOD.Location = new System.Drawing.Point(132, 98);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(132, 20);
            this.dtpDatumOD.TabIndex = 51;
            this.dtpDatumOD.ValueChanged += new System.EventHandler(this.dtpDatumOD_ValueChanged);
            this.dtpDatumOD.Enter += new System.EventHandler(this.dtpDatumOD_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "Važi od datuma:";
            // 
            // txtPopustStavka
            // 
            this.txtPopustStavka.Location = new System.Drawing.Point(132, 72);
            this.txtPopustStavka.Name = "txtPopustStavka";
            this.txtPopustStavka.Properties.Mask.EditMask = "n";
            this.txtPopustStavka.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPopustStavka.Size = new System.Drawing.Size(91, 20);
            this.txtPopustStavka.TabIndex = 49;
            this.txtPopustStavka.Enter += new System.EventHandler(this.txtPopustStavka_Enter);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(132, 41);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Properties.Mask.EditMask = "n3";
            this.txtKolicina.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 48;
            this.txtKolicina.Enter += new System.EventHandler(this.txtKolicina_Enter);
            this.txtKolicina.Leave += new System.EventHandler(this.txtKolicina_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Popust:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Količina:";
            // 
            // txtOpisStavka
            // 
            this.txtOpisStavka.Location = new System.Drawing.Point(132, 12);
            this.txtOpisStavka.MaxLength = 40;
            this.txtOpisStavka.Name = "txtOpisStavka";
            this.txtOpisStavka.Size = new System.Drawing.Size(244, 20);
            this.txtOpisStavka.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Opis:";
            // 
            // Spremi2
            // 
            this.Spremi2.Image = ((System.Drawing.Image)(resources.GetObject("Spremi2.Image")));
            this.Spremi2.Location = new System.Drawing.Point(483, 101);
            this.Spremi2.Name = "Spremi2";
            this.Spremi2.Size = new System.Drawing.Size(44, 48);
            this.Spremi2.TabIndex = 57;
            this.Spremi2.UseVisualStyleBackColor = true;
            this.Spremi2.Click += new System.EventHandler(this.Spremi2_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(689, 54);
            this.panel11.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(170, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "F9 - izbriši";
            this.label25.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(12, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "F4 - izmjena artikla u akciji";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(10, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Sniženi artikli poslovnice";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1273, 57);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Odabir artikala za poslovnicu";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(788, 16);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(156, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Pošalji akciju u trgovine >>>";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnPosalji);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Enabled = false;
            this.panel12.Location = new System.Drawing.Point(0, 1015);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1275, 58);
            this.panel12.TabIndex = 10;
            // 
            // colar_naziv4
            // 
            this.colar_naziv4.Caption = "Naziv artikla";
            this.colar_naziv4.FieldName = "ar_naziv";
            this.colar_naziv4.Name = "colar_naziv4";
            this.colar_naziv4.Visible = true;
            this.colar_naziv4.VisibleIndex = 1;
            this.colar_naziv4.Width = 203;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colpo_id
            // 
            this.colpo_id.FieldName = "po_id";
            this.colpo_id.Name = "colpo_id";
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 0;
            this.colpo_sifra.Width = 234;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 1;
            this.colpo_naziv.Width = 1477;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSnizenjaOdDobavljaca
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1292, 616);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSnizenjaOdDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniženja od dobavljača";
            this.Load += new System.EventHandler(this.frmSnizenjaOdDobavljaca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnizenjaOdDobavljaca_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklDobavljacaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizeniArtikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenje_odabrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheStanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeStavkeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrijednost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtiklDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikDobav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniArtikliStanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizeniStanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikliUAkciji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgartikliUAkcijiStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.pnlIzmjenaStavkiAkcije.ResumeLayout(false);
            this.pnlIzmjenaStavkiAkcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopustStavka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina.Properties)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private KategorijeAkcija kategorijeAkcija;
        private System.Windows.Forms.BindingSource kategorijeAkcijaBindingSource;
        private KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter kategorijeAkcijaTableAdapter;
        private System.Windows.Forms.BindingSource artiklDobavljacaBindingSource;
        private Snizenja snizenja;
        private System.Windows.Forms.BindingSource snizeniArtikliBindingSource;
        private Snizenje_odabrani snizenje_odabrani;
        private SnizenjaTableAdapters.artiklDobavljacaTableAdapter artiklDobavljacaTableAdapter;
        private Snizenje_odabraniTableAdapters.SnizeniArtikliTableAdapter snizeniArtikliTableAdapter;
        private System.Windows.Forms.BindingSource zaliheStanjeBindingSource;
        private Snizenje_odabraniTableAdapters.zaliheStanjeTableAdapter zaliheStanjeTableAdapter;
        private System.Windows.Forms.BindingSource akcijeStavkeBindingSource;
        private Snizenje_odabraniTableAdapters.akcijeStavkeTableAdapter akcijeStavkeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDokumPar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtPopust;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAktivna;
        private System.Windows.Forms.TextBox txtBrojAkcije;
        private System.Windows.Forms.DateTimePicker dtpDOKada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpODKada;
        private DevExpress.XtraGrid.Columns.GridColumn colar_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV2;
        private DevExpress.XtraGrid.Columns.GridColumn colar_Sifra1;
        private DevExpress.XtraGrid.Columns.GridColumn colar_ID2;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl dgSnizeniArtikl;
        private DevExpress.XtraGrid.Views.Grid.GridView dgSnizeni;
        private DevExpress.XtraGrid.Columns.GridColumn colARTIKL_AR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colARTIKL_AR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colBK_KOD;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraGrid.GridControl dgArtiklDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView dgArtikDobav;
        private DevExpress.XtraGrid.Columns.GridColumn colar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colar_Sifra;
        private DevExpress.XtraGrid.Columns.GridColumn coldoa_sifraKodDobavljaca;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV3;
        private DevExpress.XtraGrid.Columns.GridColumn colar_Sifra2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.GridControl dgSnizeniArtikliStanja;
        private DevExpress.XtraGrid.Views.Grid.GridView dgSnizeniStanja;
        private DevExpress.XtraGrid.Columns.GridColumn colar_sifra3;
        private DevExpress.XtraGrid.Columns.GridColumn colza_stanje;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraGrid.GridControl dgArtikliUAkciji;
        private DevExpress.XtraGrid.Views.Grid.GridView dgartikliUAkcijiStavke;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private System.Windows.Forms.Panel pnlIzmjenaStavkiAkcije;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbAktivnaStavka;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.TextEdit txtPopustStavka;
        private DevExpress.XtraEditors.TextEdit txtKolicina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOpisStavka;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Spremi2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraGrid.Columns.GridColumn colar_naziv4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colar_naziv6;
        private Poslovnica poslovnica;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovnicaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCijena;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA4;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV5;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_KOLIC;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_POPUST;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_AKTIVNA;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_VAZIOD;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_VAZIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colBK_KOD1;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_cijena;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraGrid.Columns.GridColumn colza_nabcij;
        private DevExpress.XtraGrid.Columns.GridColumn colbk_kod2;
        private DevExpress.XtraGrid.Columns.GridColumn colza_maloprodcijena;
        private DevExpress.XtraEditors.TextEdit txtVrijednost;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox ckbIstekRoka;
    }
}