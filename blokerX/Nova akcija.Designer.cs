namespace blokerX
{
    partial class frmNovaAkcija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaAkcija));
            this.label1 = new System.Windows.Forms.Label();
            this.glKategorija = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kategorijeAkcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijeAkcija = new blokerX.KategorijeAkcija();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpok_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpok_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojAkcije = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpODKada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOKada = new System.Windows.Forms.DateTimePicker();
            this.cmbAktivna = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.kategorijeAkcijaTableAdapter = new blokerX.KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.glPartner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbAkcijaVezana = new System.Windows.Forms.ComboBox();
            this.glSifraVezane = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPopust = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dgAkcijeStavke = new DevExpress.XtraGrid.GridControl();
            this.akcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nova_akcija_stavke = new blokerX.Nova_akcija_stavke();
            this.dgAkcijaStavka = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAKC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKCIJEZAG_AKC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_BROJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_VAZIOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_VAZIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_AKTIVNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_OPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_OPIS2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_POPUST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_IZNOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_KOLIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_KOMADA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_ODSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_DOSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOK_DANUTJEDNU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colakc_cijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.akcijeTableAdapter = new blokerX.Nova_akcija_stavkeTableAdapters.akcijeTableAdapter();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSifraVezane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijeStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nova_akcija_stavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijaStavka)).BeginInit();
            this.SuspendLayout();
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
            // glKategorija
            // 
            this.glKategorija.EditValue = "";
            this.glKategorija.Location = new System.Drawing.Point(167, 13);
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
            this.glKategorija.TabIndex = 0;
            this.glKategorija.EditValueChanged += new System.EventHandler(this.glKategorija_EditValueChanged);
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
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpok_sifra, DevExpress.Data.ColumnSortOrder.Descending)});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj akcije:";
            // 
            // txtBrojAkcije
            // 
            this.txtBrojAkcije.Location = new System.Drawing.Point(167, 39);
            this.txtBrojAkcije.Name = "txtBrojAkcije";
            this.txtBrojAkcije.Size = new System.Drawing.Size(100, 20);
            this.txtBrojAkcije.TabIndex = 4;
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
            // dtpODKada
            // 
            this.dtpODKada.Location = new System.Drawing.Point(167, 65);
            this.dtpODKada.Name = "dtpODKada";
            this.dtpODKada.Size = new System.Drawing.Size(128, 20);
            this.dtpODKada.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "do dana:";
            // 
            // dtpDOKada
            // 
            this.dtpDOKada.Location = new System.Drawing.Point(367, 65);
            this.dtpDOKada.Name = "dtpDOKada";
            this.dtpDOKada.Size = new System.Drawing.Size(128, 20);
            this.dtpDOKada.TabIndex = 8;
            // 
            // cmbAktivna
            // 
            this.cmbAktivna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivna.FormattingEnabled = true;
            this.cmbAktivna.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAktivna.Location = new System.Drawing.Point(167, 91);
            this.cmbAktivna.Name = "cmbAktivna";
            this.cmbAktivna.Size = new System.Drawing.Size(68, 21);
            this.cmbAktivna.TabIndex = 9;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(167, 119);
            this.txtOpis.MaxLength = 30;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(328, 20);
            this.txtOpis.TabIndex = 12;
            // 
            // kategorijeAkcijaTableAdapter
            // 
            this.kategorijeAkcijaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPosalji);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblPoruka);
            this.panel1.Controls.Add(this.glPartner);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cmbAkcijaVezana);
            this.panel1.Controls.Add(this.glSifraVezane);
            this.panel1.Controls.Add(this.txtPopust);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSpremi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.glKategorija);
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
            this.panel1.Size = new System.Drawing.Size(741, 289);
            this.panel1.TabIndex = 13;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPosalji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPosalji.Location = new System.Drawing.Point(630, 28);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(91, 23);
            this.btnPosalji.TabIndex = 29;
            this.btnPosalji.Text = "Pošalji akciju >>";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Visible = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "del - briši stavku";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.BackColor = System.Drawing.SystemColors.Control;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoruka.ForeColor = System.Drawing.Color.Red;
            this.lblPoruka.Location = new System.Drawing.Point(497, 168);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 27;
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Enabled = false;
            this.glPartner.Location = new System.Drawing.Point(167, 172);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.ImmediatePopup = true;
            this.glPartner.Properties.NullText = "";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridView2;
            this.glPartner.Size = new System.Drawing.Size(300, 20);
            this.glPartner.TabIndex = 14;
            this.glPartner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glPartner_KeyDown);
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_ID,
            this.colPA_SIFRA,
            this.colPA_NAZIV});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPA_ID
            // 
            this.colPA_ID.FieldName = "PA_ID";
            this.colPA_ID.Name = "colPA_ID";
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.Caption = "sifra";
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 291;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "naziv";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 1421;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Dobavljač:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "F9 - excel";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(739, 248);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1, 1);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbAkcijaVezana
            // 
            this.cmbAkcijaVezana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAkcijaVezana.FormattingEnabled = true;
            this.cmbAkcijaVezana.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAkcijaVezana.Location = new System.Drawing.Point(168, 198);
            this.cmbAkcijaVezana.Name = "cmbAkcijaVezana";
            this.cmbAkcijaVezana.Size = new System.Drawing.Size(68, 21);
            this.cmbAkcijaVezana.TabIndex = 15;
            this.cmbAkcijaVezana.SelectedIndexChanged += new System.EventHandler(this.cmbAkcijaVezana_SelectedIndexChanged);
            // 
            // glSifraVezane
            // 
            this.glSifraVezane.EditValue = "";
            this.glSifraVezane.Enabled = false;
            this.glSifraVezane.Location = new System.Drawing.Point(167, 225);
            this.glSifraVezane.Name = "glSifraVezane";
            this.glSifraVezane.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glSifraVezane.Properties.DataSource = this.kategorijeAkcijaBindingSource;
            this.glSifraVezane.Properties.DisplayMember = "pok_naziv";
            this.glSifraVezane.Properties.ImmediatePopup = true;
            this.glSifraVezane.Properties.NullText = "";
            this.glSifraVezane.Properties.ValueMember = "pok_sifra";
            this.glSifraVezane.Properties.View = this.gridView1;
            this.glSifraVezane.Size = new System.Drawing.Size(300, 20);
            this.glSifraVezane.TabIndex = 16;
            this.glSifraVezane.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glSifraVezane_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "pok_naziv";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 1548;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "pok_sifra";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 182;
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(167, 145);
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
            this.btnSpremi.Location = new System.Drawing.Point(643, 257);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Šifra kategorije vezane akcije:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Akcija vezana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "F7 - nova stavka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "F4 - izmijeni stavku";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIzlaz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 48);
            this.panel2.TabIndex = 14;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(643, 13);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 99;
            this.btnIzlaz.Text = "Esc - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dgAkcijeStavke
            // 
            this.dgAkcijeStavke.DataSource = this.akcijeBindingSource;
            this.dgAkcijeStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkcijeStavke.Location = new System.Drawing.Point(0, 289);
            this.dgAkcijeStavke.MainView = this.dgAkcijaStavka;
            this.dgAkcijeStavke.Name = "dgAkcijeStavke";
            this.dgAkcijeStavke.Size = new System.Drawing.Size(741, 207);
            this.dgAkcijeStavke.TabIndex = 17;
            this.dgAkcijeStavke.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgAkcijaStavka});
            this.dgAkcijeStavke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgAkcijeStavke_KeyDown);
            // 
            // akcijeBindingSource
            // 
            this.akcijeBindingSource.DataMember = "akcije";
            this.akcijeBindingSource.DataSource = this.nova_akcija_stavke;
            // 
            // nova_akcija_stavke
            // 
            this.nova_akcija_stavke.DataSetName = "Nova_akcija_stavke";
            this.nova_akcija_stavke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgAkcijaStavka
            // 
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.Empty.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcijaStavka.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcijaStavka.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcijaStavka.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgAkcijaStavka.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgAkcijaStavka.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcijaStavka.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcijaStavka.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcijaStavka.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAkcijaStavka.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgAkcijaStavka.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.GroupRow.Options.UseFont = true;
            this.dgAkcijaStavka.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgAkcijaStavka.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgAkcijaStavka.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgAkcijaStavka.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgAkcijaStavka.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgAkcijaStavka.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgAkcijaStavka.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgAkcijaStavka.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgAkcijaStavka.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgAkcijaStavka.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.OddRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.OddRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgAkcijaStavka.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgAkcijaStavka.Appearance.Preview.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.Preview.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.Row.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.Row.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgAkcijaStavka.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgAkcijaStavka.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgAkcijaStavka.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgAkcijaStavka.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgAkcijaStavka.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgAkcijaStavka.Appearance.VertLine.Options.UseBackColor = true;
            this.dgAkcijaStavka.ColumnPanelRowHeight = 50;
            this.dgAkcijaStavka.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAKC_ID,
            this.colAKCIJEZAG_AKC_ID,
            this.colPOK_SIFRA1,
            this.colAKC_BROJ,
            this.colPOK_VAZIOD,
            this.colPOK_VAZIDO,
            this.colAKC_AKTIVNA,
            this.colPOK_OPIS,
            this.colPOK_OPIS2,
            this.colAKC_POPUST,
            this.colPOK_IZNOS,
            this.colPOK_KOLIC,
            this.colPOK_KOMADA,
            this.colRG_SIFRA,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colPOK_ODSAT,
            this.colPOK_DOSAT,
            this.colPOK_DANUTJEDNU,
            this.colakc_cijena});
            this.dgAkcijaStavka.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgAkcijaStavka.GridControl = this.dgAkcijeStavke;
            this.dgAkcijaStavka.Name = "dgAkcijaStavka";
            this.dgAkcijaStavka.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgAkcijaStavka.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgAkcijaStavka.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgAkcijaStavka.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgAkcijaStavka.OptionsBehavior.Editable = false;
            this.dgAkcijaStavka.OptionsCustomization.AllowFilter = false;
            this.dgAkcijaStavka.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgAkcijaStavka.OptionsSelection.MultiSelect = true;
            this.dgAkcijaStavka.OptionsView.ColumnAutoWidth = false;
            this.dgAkcijaStavka.OptionsView.EnableAppearanceEvenRow = true;
            this.dgAkcijaStavka.OptionsView.EnableAppearanceOddRow = true;
            this.dgAkcijaStavka.OptionsView.ShowAutoFilterRow = true;
            this.dgAkcijaStavka.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgAkcijaStavka.OptionsView.ShowGroupPanel = false;
            this.dgAkcijaStavka.OptionsView.ShowIndicator = false;
            this.dgAkcijaStavka.PaintStyleName = "WindowsXP";
            this.dgAkcijaStavka.SynchronizeClones = false;
            // 
            // colAKC_ID
            // 
            this.colAKC_ID.FieldName = "AKC_ID";
            this.colAKC_ID.Name = "colAKC_ID";
            // 
            // colAKCIJEZAG_AKC_ID
            // 
            this.colAKCIJEZAG_AKC_ID.FieldName = "AKCIJEZAG_AKC_ID";
            this.colAKCIJEZAG_AKC_ID.Name = "colAKCIJEZAG_AKC_ID";
            // 
            // colPOK_SIFRA1
            // 
            this.colPOK_SIFRA1.FieldName = "POK_SIFRA";
            this.colPOK_SIFRA1.Name = "colPOK_SIFRA1";
            // 
            // colAKC_BROJ
            // 
            this.colAKC_BROJ.Caption = "Broj akcije";
            this.colAKC_BROJ.FieldName = "AKC_BROJ";
            this.colAKC_BROJ.Name = "colAKC_BROJ";
            // 
            // colPOK_VAZIOD
            // 
            this.colPOK_VAZIOD.Caption = "Važi od";
            this.colPOK_VAZIOD.FieldName = "POK_VAZIOD";
            this.colPOK_VAZIOD.Name = "colPOK_VAZIOD";
            this.colPOK_VAZIOD.Visible = true;
            this.colPOK_VAZIOD.VisibleIndex = 0;
            // 
            // colPOK_VAZIDO
            // 
            this.colPOK_VAZIDO.Caption = "Važi do";
            this.colPOK_VAZIDO.FieldName = "POK_VAZIDO";
            this.colPOK_VAZIDO.Name = "colPOK_VAZIDO";
            this.colPOK_VAZIDO.Visible = true;
            this.colPOK_VAZIDO.VisibleIndex = 1;
            // 
            // colAKC_AKTIVNA
            // 
            this.colAKC_AKTIVNA.Caption = "Aktivna";
            this.colAKC_AKTIVNA.FieldName = "AKC_AKTIVNA";
            this.colAKC_AKTIVNA.Name = "colAKC_AKTIVNA";
            this.colAKC_AKTIVNA.Visible = true;
            this.colAKC_AKTIVNA.VisibleIndex = 2;
            // 
            // colPOK_OPIS
            // 
            this.colPOK_OPIS.Caption = "Opis";
            this.colPOK_OPIS.FieldName = "POK_OPIS";
            this.colPOK_OPIS.Name = "colPOK_OPIS";
            this.colPOK_OPIS.Visible = true;
            this.colPOK_OPIS.VisibleIndex = 3;
            this.colPOK_OPIS.Width = 142;
            // 
            // colPOK_OPIS2
            // 
            this.colPOK_OPIS2.Caption = "Opis 2";
            this.colPOK_OPIS2.FieldName = "POK_OPIS2";
            this.colPOK_OPIS2.Name = "colPOK_OPIS2";
            this.colPOK_OPIS2.Visible = true;
            this.colPOK_OPIS2.VisibleIndex = 4;
            this.colPOK_OPIS2.Width = 166;
            // 
            // colAKC_POPUST
            // 
            this.colAKC_POPUST.Caption = "Popust";
            this.colAKC_POPUST.FieldName = "AKC_POPUST";
            this.colAKC_POPUST.Name = "colAKC_POPUST";
            this.colAKC_POPUST.Visible = true;
            this.colAKC_POPUST.VisibleIndex = 5;
            // 
            // colPOK_IZNOS
            // 
            this.colPOK_IZNOS.Caption = "Iznos";
            this.colPOK_IZNOS.FieldName = "POK_IZNOS";
            this.colPOK_IZNOS.Name = "colPOK_IZNOS";
            this.colPOK_IZNOS.Visible = true;
            this.colPOK_IZNOS.VisibleIndex = 6;
            // 
            // colPOK_KOLIC
            // 
            this.colPOK_KOLIC.Caption = "Količina";
            this.colPOK_KOLIC.FieldName = "POK_KOLIC";
            this.colPOK_KOLIC.Name = "colPOK_KOLIC";
            this.colPOK_KOLIC.Visible = true;
            this.colPOK_KOLIC.VisibleIndex = 7;
            this.colPOK_KOLIC.Width = 63;
            // 
            // colPOK_KOMADA
            // 
            this.colPOK_KOMADA.Caption = "Komada";
            this.colPOK_KOMADA.FieldName = "POK_KOMADA";
            this.colPOK_KOMADA.Name = "colPOK_KOMADA";
            this.colPOK_KOMADA.Visible = true;
            this.colPOK_KOMADA.VisibleIndex = 9;
            this.colPOK_KOMADA.Width = 60;
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "Šifra RG";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 10;
            this.colRG_SIFRA.Width = 95;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 11;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 12;
            this.colAR_NAZIV.Width = 172;
            // 
            // colPOK_ODSAT
            // 
            this.colPOK_ODSAT.Caption = "Od sata";
            this.colPOK_ODSAT.FieldName = "POK_ODSAT";
            this.colPOK_ODSAT.Name = "colPOK_ODSAT";
            this.colPOK_ODSAT.Visible = true;
            this.colPOK_ODSAT.VisibleIndex = 13;
            // 
            // colPOK_DOSAT
            // 
            this.colPOK_DOSAT.Caption = "Do sata";
            this.colPOK_DOSAT.FieldName = "POK_DOSAT";
            this.colPOK_DOSAT.Name = "colPOK_DOSAT";
            this.colPOK_DOSAT.Visible = true;
            this.colPOK_DOSAT.VisibleIndex = 14;
            // 
            // colPOK_DANUTJEDNU
            // 
            this.colPOK_DANUTJEDNU.Caption = "Dan u tjednu";
            this.colPOK_DANUTJEDNU.FieldName = "POK_DANUTJEDNU";
            this.colPOK_DANUTJEDNU.Name = "colPOK_DANUTJEDNU";
            this.colPOK_DANUTJEDNU.Visible = true;
            this.colPOK_DANUTJEDNU.VisibleIndex = 15;
            // 
            // colakc_cijena
            // 
            this.colakc_cijena.Caption = "Cijena";
            this.colakc_cijena.FieldName = "akc_cijena";
            this.colakc_cijena.Name = "colakc_cijena";
            this.colakc_cijena.Visible = true;
            this.colakc_cijena.VisibleIndex = 8;
            // 
            // akcijeTableAdapter
            // 
            this.akcijeTableAdapter.ClearBeforeFill = true;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovaAkcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 544);
            this.Controls.Add(this.dgAkcijeStavke);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmNovaAkcija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova akcija";
            this.Load += new System.EventHandler(this.frmNovaAkcija_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNovaAkcija_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.glKategorija.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeAkcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glSifraVezane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopust.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijeStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nova_akcija_stavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkcijaStavka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit glKategorija;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojAkcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpODKada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOKada;
        private System.Windows.Forms.ComboBox cmbAktivna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpis;
        private KategorijeAkcija kategorijeAkcija;
        private System.Windows.Forms.BindingSource kategorijeAkcijaBindingSource;
        private KategorijeAkcijaTableAdapters.kategorijeAkcijaTableAdapter kategorijeAkcijaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIzlaz;
        private DevExpress.XtraGrid.GridControl dgAkcijeStavke;
        private DevExpress.XtraGrid.Views.Grid.GridView dgAkcijaStavka;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpok_sifra;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtPopust;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.GridLookUpEdit glSifraVezane;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ComboBox cmbAkcijaVezana;
        private System.Windows.Forms.BindingSource akcijeBindingSource;
        private Nova_akcija_stavke nova_akcija_stavke;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAKCIJEZAG_AKC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_BROJ;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_VAZIOD;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_VAZIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_AKTIVNA;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_OPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_OPIS2;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_POPUST;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_IZNOS;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_KOLIC;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_KOMADA;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_ODSAT;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_DOSAT;
        private DevExpress.XtraGrid.Columns.GridColumn colPOK_DANUTJEDNU;
        private Nova_akcija_stavkeTableAdapters.akcijeTableAdapter akcijeTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_cijena;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label13;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPosalji;
    }
}