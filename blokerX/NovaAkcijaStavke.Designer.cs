namespace blokerX
{
    partial class frmNovaAkcijaStavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaAkcijaStavke));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpVrijediDO = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpVrijediOD = new System.Windows.Forms.DateTimePicker();
            this.txtStatusKupca = new System.Windows.Forms.TextBox();
            this.txtBodovi = new DevExpress.XtraEditors.TextEdit();
            this.txtCijena = new DevExpress.XtraEditors.TextEdit();
            this.txtKune = new DevExpress.XtraEditors.TextEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbAktivna = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbBrojKupona = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpVrijemeDO = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpVrijemeOD = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRobnaGrupa = new System.Windows.Forms.Label();
            this.txtRobnaGrupa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPopust = new DevExpress.XtraEditors.TextEdit();
            this.txtKolicina = new DevExpress.XtraEditors.TextEdit();
            this.txtIznosRacuna = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.txtSifraArtikla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDanUTjednu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis2 = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojAkcije = new System.Windows.Forms.TextBox();
            this.glKategorija = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kategorijeAkcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeAkcija = new blokerX.KategorijeAkcija();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpok_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.kategorijeAkcijaTableAdapter = new blokerX.KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodovi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKune.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIznosRacuna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnSpremi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 42);
            this.panel2.TabIndex = 2;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(649, 7);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(567, 7);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 50;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpVrijediDO);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.dtpVrijediOD);
            this.panel1.Controls.Add(this.txtStatusKupca);
            this.panel1.Controls.Add(this.txtBodovi);
            this.panel1.Controls.Add(this.txtCijena);
            this.panel1.Controls.Add(this.txtKune);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cmbAktivna);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cmbBrojKupona);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.dtpVrijemeDO);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dtpVrijemeOD);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dtpDatumDO);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtpDatumOD);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblRobnaGrupa);
            this.panel1.Controls.Add(this.txtRobnaGrupa);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPopust);
            this.panel1.Controls.Add(this.txtKolicina);
            this.panel1.Controls.Add(this.txtIznosRacuna);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblNazivArtikla);
            this.panel1.Controls.Add(this.txtSifraArtikla);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbDanUTjednu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOpis2);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBrojAkcije);
            this.panel1.Controls.Add(this.glKategorija);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 524);
            this.panel1.TabIndex = 1;
            // 
            // dtpVrijediDO
            // 
            this.dtpVrijediDO.Enabled = false;
            this.dtpVrijediDO.Location = new System.Drawing.Point(594, 479);
            this.dtpVrijediDO.Name = "dtpVrijediDO";
            this.dtpVrijediDO.Size = new System.Drawing.Size(112, 20);
            this.dtpVrijediDO.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "do datuma:";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Enabled = false;
            this.glDobavljac.Location = new System.Drawing.Point(406, 450);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.NullText = "";
            this.glDobavljac.Properties.ValueMember = "PA_SIFRA";
            this.glDobavljac.Properties.View = this.gridView1;
            this.glDobavljac.Size = new System.Drawing.Size(286, 20);
            this.glDobavljac.TabIndex = 47;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_SIFRA,
            this.colPA_NAZIV});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPA_NAZIV, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 227;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 1503;
            // 
            // dtpVrijediOD
            // 
            this.dtpVrijediOD.Enabled = false;
            this.dtpVrijediOD.Location = new System.Drawing.Point(406, 479);
            this.dtpVrijediOD.Name = "dtpVrijediOD";
            this.dtpVrijediOD.Size = new System.Drawing.Size(112, 20);
            this.dtpVrijediOD.TabIndex = 49;
            // 
            // txtStatusKupca
            // 
            this.txtStatusKupca.Enabled = false;
            this.txtStatusKupca.Location = new System.Drawing.Point(406, 421);
            this.txtStatusKupca.MaxLength = 2;
            this.txtStatusKupca.Name = "txtStatusKupca";
            this.txtStatusKupca.Size = new System.Drawing.Size(81, 20);
            this.txtStatusKupca.TabIndex = 46;
            // 
            // txtBodovi
            // 
            this.txtBodovi.Enabled = false;
            this.txtBodovi.Location = new System.Drawing.Point(128, 476);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.Properties.Mask.EditMask = "c2";
            this.txtBodovi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBodovi.Size = new System.Drawing.Size(100, 20);
            this.txtBodovi.TabIndex = 45;
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(128, 450);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Properties.Mask.EditMask = "c2";
            this.txtCijena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 44;
            // 
            // txtKune
            // 
            this.txtKune.Enabled = false;
            this.txtKune.Location = new System.Drawing.Point(128, 421);
            this.txtKune.Name = "txtKune";
            this.txtKune.Properties.Mask.EditMask = "c2";
            this.txtKune.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKune.Size = new System.Drawing.Size(100, 20);
            this.txtKune.TabIndex = 43;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(299, 483);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "Kupon iskoristiti od:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(342, 453);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Dobavljač:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(299, 424);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "Šifra statusa kupca:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(79, 478);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Bodovi:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(83, 453);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Cijena:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 424);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Kune:";
            // 
            // cmbAktivna
            // 
            this.cmbAktivna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivna.FormattingEnabled = true;
            this.cmbAktivna.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAktivna.Location = new System.Drawing.Point(390, 363);
            this.cmbAktivna.Name = "cmbAktivna";
            this.cmbAktivna.Size = new System.Drawing.Size(39, 21);
            this.cmbAktivna.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(314, 366);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Akc. aktivna:";
            // 
            // cmbBrojKupona
            // 
            this.cmbBrojKupona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojKupona.Enabled = false;
            this.cmbBrojKupona.FormattingEnabled = true;
            this.cmbBrojKupona.Items.AddRange(new object[] {
            "0 - prema visini računa",
            "1 - 1 kupon",
            "2 - 2 kupona",
            "3 - 3 kupona"});
            this.cmbBrojKupona.Location = new System.Drawing.Point(128, 363);
            this.cmbBrojKupona.Name = "cmbBrojKupona";
            this.cmbBrojKupona.Size = new System.Drawing.Size(121, 21);
            this.cmbBrojKupona.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Broj kupona:";
            // 
            // dtpVrijemeDO
            // 
            this.dtpVrijemeDO.Enabled = false;
            this.dtpVrijemeDO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeDO.Location = new System.Drawing.Point(317, 333);
            this.dtpVrijemeDO.Name = "dtpVrijemeDO";
            this.dtpVrijemeDO.ShowUpDown = true;
            this.dtpVrijemeDO.Size = new System.Drawing.Size(111, 20);
            this.dtpVrijemeDO.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "do vremena:";
            // 
            // dtpVrijemeOD
            // 
            this.dtpVrijemeOD.CustomFormat = "";
            this.dtpVrijemeOD.Enabled = false;
            this.dtpVrijemeOD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemeOD.Location = new System.Drawing.Point(128, 333);
            this.dtpVrijemeOD.Name = "dtpVrijemeOD";
            this.dtpVrijemeOD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpVrijemeOD.ShowUpDown = true;
            this.dtpVrijemeOD.Size = new System.Drawing.Size(111, 20);
            this.dtpVrijemeOD.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Od vremena:";
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.Location = new System.Drawing.Point(317, 303);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(112, 20);
            this.dtpDatumDO.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "do datuma:";
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.Location = new System.Drawing.Point(128, 303);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(112, 20);
            this.dtpDatumOD.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Važi od datuma:";
            // 
            // lblRobnaGrupa
            // 
            this.lblRobnaGrupa.AutoSize = true;
            this.lblRobnaGrupa.Location = new System.Drawing.Point(215, 278);
            this.lblRobnaGrupa.Name = "lblRobnaGrupa";
            this.lblRobnaGrupa.Size = new System.Drawing.Size(25, 13);
            this.lblRobnaGrupa.TabIndex = 24;
            this.lblRobnaGrupa.Text = "___";
            // 
            // txtRobnaGrupa
            // 
            this.txtRobnaGrupa.Enabled = false;
            this.txtRobnaGrupa.Location = new System.Drawing.Point(128, 275);
            this.txtRobnaGrupa.Name = "txtRobnaGrupa";
            this.txtRobnaGrupa.Size = new System.Drawing.Size(81, 20);
            this.txtRobnaGrupa.TabIndex = 23;
            this.txtRobnaGrupa.TextChanged += new System.EventHandler(this.txtRobnaGrupa_TextChanged);
            this.txtRobnaGrupa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRobnaGrupa_KeyDown);
            this.txtRobnaGrupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRobnaGrupa_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Robna grupa:";
            // 
            // txtPopust
            // 
            this.txtPopust.Enabled = false;
            this.txtPopust.Location = new System.Drawing.Point(128, 244);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Properties.Mask.EditMask = "P2";
            this.txtPopust.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPopust.Size = new System.Drawing.Size(121, 20);
            this.txtPopust.TabIndex = 21;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Enabled = false;
            this.txtKolicina.Location = new System.Drawing.Point(128, 215);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Properties.Mask.EditMask = "c2";
            this.txtKolicina.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 20;
            // 
            // txtIznosRacuna
            // 
            this.txtIznosRacuna.Enabled = false;
            this.txtIznosRacuna.Location = new System.Drawing.Point(128, 189);
            this.txtIznosRacuna.Name = "txtIznosRacuna";
            this.txtIznosRacuna.Properties.Mask.EditMask = "c2";
            this.txtIznosRacuna.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIznosRacuna.Size = new System.Drawing.Size(121, 20);
            this.txtIznosRacuna.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Popust:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Količina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Iznos računa:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(215, 152);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(25, 13);
            this.lblNazivArtikla.TabIndex = 15;
            this.lblNazivArtikla.Text = "___";
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Enabled = false;
            this.txtSifraArtikla.Location = new System.Drawing.Point(128, 149);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(81, 20);
            this.txtSifraArtikla.TabIndex = 14;
            this.txtSifraArtikla.TextChanged += new System.EventHandler(this.txtSifraArtikla_TextChanged);
            this.txtSifraArtikla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraArtikla_KeyDown);
            this.txtSifraArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifraArtikla_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Šifra artikla:";
            // 
            // cmbDanUTjednu
            // 
            this.cmbDanUTjednu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanUTjednu.Enabled = false;
            this.cmbDanUTjednu.FormattingEnabled = true;
            this.cmbDanUTjednu.Items.AddRange(new object[] {
            "1 - Nedjelja",
            "2 - Ponedjeljak",
            "3 - Utorak",
            "4 - Srijeda",
            "5 - Četvrtak",
            "6 - Petak",
            "7 - Subota"});
            this.cmbDanUTjednu.Location = new System.Drawing.Point(128, 122);
            this.cmbDanUTjednu.Name = "cmbDanUTjednu";
            this.cmbDanUTjednu.Size = new System.Drawing.Size(121, 21);
            this.cmbDanUTjednu.TabIndex = 12;
            this.cmbDanUTjednu.SelectedIndexChanged += new System.EventHandler(this.cmbDanUTjednu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dan u tjednu:";
            // 
            // txtOpis2
            // 
            this.txtOpis2.Enabled = false;
            this.txtOpis2.Location = new System.Drawing.Point(128, 96);
            this.txtOpis2.MaxLength = 40;
            this.txtOpis2.Name = "txtOpis2";
            this.txtOpis2.Size = new System.Drawing.Size(300, 20);
            this.txtOpis2.TabIndex = 10;
            // 
            // txtOpis
            // 
            this.txtOpis.Enabled = false;
            this.txtOpis.Location = new System.Drawing.Point(128, 69);
            this.txtOpis.MaxLength = 40;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(300, 20);
            this.txtOpis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis dodatni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis poklon bona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj akcije:";
            // 
            // txtBrojAkcije
            // 
            this.txtBrojAkcije.Enabled = false;
            this.txtBrojAkcije.Location = new System.Drawing.Point(128, 43);
            this.txtBrojAkcije.Name = "txtBrojAkcije";
            this.txtBrojAkcije.Size = new System.Drawing.Size(100, 20);
            this.txtBrojAkcije.TabIndex = 6;
            // 
            // glKategorija
            // 
            this.glKategorija.EditValue = "";
            this.glKategorija.Enabled = false;
            this.glKategorija.Location = new System.Drawing.Point(128, 17);
            this.glKategorija.Name = "glKategorija";
            this.glKategorija.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glKategorija.Properties.DataSource = this.kategorijeAkcijaBindingSource;
            this.glKategorija.Properties.DisplayMember = "pok_naziv";
            this.glKategorija.Properties.ImmediatePopup = true;
            this.glKategorija.Properties.NullText = "";
            this.glKategorija.Properties.ValueMember = "pok_sifra";
            this.glKategorija.Properties.View = this.gridLookUpEdit1View;
            this.glKategorija.Size = new System.Drawing.Size(300, 20);
            this.glKategorija.TabIndex = 3;
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpok_naziv,
            this.colpok_sifra});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpok_naziv, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colpok_naziv
            // 
            this.colpok_naziv.FieldName = "pok_naziv";
            this.colpok_naziv.Name = "colpok_naziv";
            this.colpok_naziv.Visible = true;
            this.colpok_naziv.VisibleIndex = 1;
            this.colpok_naziv.Width = 1548;
            // 
            // colpok_sifra
            // 
            this.colpok_sifra.FieldName = "pok_sifra";
            this.colpok_sifra.Name = "colpok_sifra";
            this.colpok_sifra.Visible = true;
            this.colpok_sifra.VisibleIndex = 0;
            this.colpok_sifra.Width = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija akcije:";
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijeAkcijaTableAdapter
            // 
            this.kategorijeAkcijaTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovaAkcijaStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmNovaAkcijaStavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akcija stavke";
            this.Load += new System.EventHandler(this.frmNovaAkcijaStavke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNovaAkcijaStavke_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodovi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKune.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIznosRacuna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit glKategorija;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_sifra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.TextBox txtSifraArtikla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDanUTjednu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojAkcije;
        private System.Windows.Forms.DateTimePicker dtpVrijediOD;
        private System.Windows.Forms.TextBox txtStatusKupca;
        private DevExpress.XtraEditors.TextEdit txtBodovi;
        private DevExpress.XtraEditors.TextEdit txtCijena;
        private DevExpress.XtraEditors.TextEdit txtKune;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbAktivna;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbBrojKupona;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpVrijemeDO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpVrijemeOD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRobnaGrupa;
        private System.Windows.Forms.TextBox txtRobnaGrupa;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtPopust;
        private DevExpress.XtraEditors.TextEdit txtKolicina;
        private DevExpress.XtraEditors.TextEdit txtIznosRacuna;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private KategorijeAkcija kategorijeAkcija;
        private System.Windows.Forms.BindingSource kategorijeAkcijaBindingSource;
        private KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter kategorijeAkcijaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpVrijediDO;
        private System.Windows.Forms.Label label7;
    }
}