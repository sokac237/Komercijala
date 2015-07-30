namespace blokerX
{
    partial class frmUnosArtikalaKojimaSeMijenjaCijena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosArtikalaKojimaSeMijenjaCijena));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifraOperatera = new System.Windows.Forms.TextBox();
            this.txtSifraPoslovnice = new System.Windows.Forms.TextBox();
            this.txtOpisCjenika = new System.Windows.Forms.TextBox();
            this.dtpOdKada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDoKada = new System.Windows.Forms.DateTimePicker();
            this.lblNazivPoslovnice = new System.Windows.Forms.Label();
            this.lblNazivOperatera = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.ckbAktivna = new System.Windows.Forms.CheckBox();
            this.txtPreporucenaCijena = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.txtArtiklSifra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSpremiArtikl = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgCjenici = new DevExpress.XtraGrid.GridControl();
            this.artikliZaNivelacijuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliZaNivelaciju = new blokerX.ArtikliZaNivelaciju();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldn_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldozvoljenaNivelacijaZag_dnz_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_AR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldn_aktivna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldn_preporucenacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldn_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.artikliZaNivelacijuTableAdapter = new blokerX.ArtikliZaNivelacijuTableAdapters.ArtikliZaNivelacijuTableAdapter();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreporucenaCijena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliZaNivelacijuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliZaNivelaciju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(737, 6);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(818, 6);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 10;
            this.btnIzlaz.Text = "Esc - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnIzlaz);
            this.panel3.Controls.Add(this.btnSpremi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 38);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(134, 12);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.ReadOnly = true;
            this.txtBroj.Size = new System.Drawing.Size(76, 20);
            this.txtBroj.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBroj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 34);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operater:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poslovnica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis cjenika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period važenja:";
            // 
            // txtSifraOperatera
            // 
            this.txtSifraOperatera.Location = new System.Drawing.Point(134, 9);
            this.txtSifraOperatera.Name = "txtSifraOperatera";
            this.txtSifraOperatera.Size = new System.Drawing.Size(76, 20);
            this.txtSifraOperatera.TabIndex = 1;
            this.txtSifraOperatera.TextChanged += new System.EventHandler(this.txtSifraOperatera_TextChanged);
            this.txtSifraOperatera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraOperatera_KeyDown);
            // 
            // txtSifraPoslovnice
            // 
            this.txtSifraPoslovnice.Location = new System.Drawing.Point(134, 42);
            this.txtSifraPoslovnice.Name = "txtSifraPoslovnice";
            this.txtSifraPoslovnice.Size = new System.Drawing.Size(76, 20);
            this.txtSifraPoslovnice.TabIndex = 2;
            this.txtSifraPoslovnice.TextChanged += new System.EventHandler(this.txtSifraPoslovnice_TextChanged);
            this.txtSifraPoslovnice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraPoslovnice_KeyDown);
            // 
            // txtOpisCjenika
            // 
            this.txtOpisCjenika.Location = new System.Drawing.Point(134, 74);
            this.txtOpisCjenika.MaxLength = 25;
            this.txtOpisCjenika.Name = "txtOpisCjenika";
            this.txtOpisCjenika.Size = new System.Drawing.Size(204, 20);
            this.txtOpisCjenika.TabIndex = 3;
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.Location = new System.Drawing.Point(134, 108);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(129, 20);
            this.dtpOdKada.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "do:";
            // 
            // dtpDoKada
            // 
            this.dtpDoKada.Location = new System.Drawing.Point(327, 108);
            this.dtpDoKada.Name = "dtpDoKada";
            this.dtpDoKada.Size = new System.Drawing.Size(129, 20);
            this.dtpDoKada.TabIndex = 5;
            // 
            // lblNazivPoslovnice
            // 
            this.lblNazivPoslovnice.AutoSize = true;
            this.lblNazivPoslovnice.Location = new System.Drawing.Point(232, 48);
            this.lblNazivPoslovnice.Name = "lblNazivPoslovnice";
            this.lblNazivPoslovnice.Size = new System.Drawing.Size(25, 13);
            this.lblNazivPoslovnice.TabIndex = 12;
            this.lblNazivPoslovnice.Text = "___";
            // 
            // lblNazivOperatera
            // 
            this.lblNazivOperatera.AutoSize = true;
            this.lblNazivOperatera.Location = new System.Drawing.Point(232, 12);
            this.lblNazivOperatera.Name = "lblNazivOperatera";
            this.lblNazivOperatera.Size = new System.Drawing.Size(25, 13);
            this.lblNazivOperatera.TabIndex = 13;
            this.lblNazivOperatera.Text = "___";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblNazivOperatera);
            this.panel5.Controls.Add(this.lblNazivPoslovnice);
            this.panel5.Controls.Add(this.dtpDoKada);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.dtpOdKada);
            this.panel5.Controls.Add(this.txtOpisCjenika);
            this.panel5.Controls.Add(this.txtSifraPoslovnice);
            this.panel5.Controls.Add(this.txtSifraOperatera);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 138);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBrisi);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnAzuriraj);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Controls.Add(this.dgCjenici);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 397);
            this.panel2.TabIndex = 2;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(496, 148);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 23;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnOdustani);
            this.panel4.Controls.Add(this.ckbAktivna);
            this.panel4.Controls.Add(this.txtPreporucenaCijena);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lblNazivArtikla);
            this.panel4.Controls.Add(this.txtArtiklSifra);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnSpremiArtikl);
            this.panel4.Location = new System.Drawing.Point(588, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 192);
            this.panel4.TabIndex = 22;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(221, 160);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // ckbAktivna
            // 
            this.ckbAktivna.AutoSize = true;
            this.ckbAktivna.Checked = true;
            this.ckbAktivna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAktivna.Location = new System.Drawing.Point(121, 116);
            this.ckbAktivna.Name = "ckbAktivna";
            this.ckbAktivna.Size = new System.Drawing.Size(62, 17);
            this.ckbAktivna.TabIndex = 4;
            this.ckbAktivna.Text = "Aktivna";
            this.ckbAktivna.UseVisualStyleBackColor = true;
            // 
            // txtPreporucenaCijena
            // 
            this.txtPreporucenaCijena.Location = new System.Drawing.Point(125, 75);
            this.txtPreporucenaCijena.Name = "txtPreporucenaCijena";
            this.txtPreporucenaCijena.Properties.Mask.EditMask = "c2";
            this.txtPreporucenaCijena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPreporucenaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtPreporucenaCijena.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Preporučena cijena:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(12, 8);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(25, 13);
            this.lblNazivArtikla.TabIndex = 3;
            this.lblNazivArtikla.Text = "___";
            // 
            // txtArtiklSifra
            // 
            this.txtArtiklSifra.Location = new System.Drawing.Point(125, 41);
            this.txtArtiklSifra.Name = "txtArtiklSifra";
            this.txtArtiklSifra.Size = new System.Drawing.Size(100, 20);
            this.txtArtiklSifra.TabIndex = 2;
            this.txtArtiklSifra.TextChanged += new System.EventHandler(this.txtArtiklSifra_TextChanged);
            this.txtArtiklSifra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArtiklSifra_KeyDown);
            this.txtArtiklSifra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtiklSifra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Artikl:";
            // 
            // btnSpremiArtikl
            // 
            this.btnSpremiArtikl.Location = new System.Drawing.Point(140, 160);
            this.btnSpremiArtikl.Name = "btnSpremiArtikl";
            this.btnSpremiArtikl.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiArtikl.TabIndex = 5;
            this.btnSpremiArtikl.Text = "Spremi";
            this.btnSpremiArtikl.UseVisualStyleBackColor = true;
            this.btnSpremiArtikl.Click += new System.EventHandler(this.btnSpremiArtikl_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(496, 100);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 21;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(496, 56);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgCjenici
            // 
            this.dgCjenici.DataSource = this.artikliZaNivelacijuBindingSource;
            this.dgCjenici.Location = new System.Drawing.Point(6, 6);
            this.dgCjenici.MainView = this.gridView2;
            this.dgCjenici.Name = "dgCjenici";
            this.dgCjenici.Size = new System.Drawing.Size(472, 385);
            this.dgCjenici.TabIndex = 19;
            this.dgCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // artikliZaNivelacijuBindingSource
            // 
            this.artikliZaNivelacijuBindingSource.DataMember = "ArtikliZaNivelaciju";
            this.artikliZaNivelacijuBindingSource.DataSource = this.artikliZaNivelaciju;
            // 
            // artikliZaNivelaciju
            // 
            this.artikliZaNivelaciju.DataSetName = "ArtikliZaNivelaciju";
            this.artikliZaNivelaciju.EnforceConstraints = false;
            this.artikliZaNivelaciju.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.coldn_id,
            this.coldozvoljenaNivelacijaZag_dnz_id,
            this.colAR_NAZIV,
            this.colAR_SIFRA,
            this.colartikl_AR_ID,
            this.coldn_aktivna,
            this.coldn_preporucenacijena,
            this.coloperater_op_id,
            this.gridColumn1,
            this.coldn_datumizrade});
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
            // coldn_id
            // 
            this.coldn_id.FieldName = "dn_id";
            this.coldn_id.Name = "coldn_id";
            // 
            // coldozvoljenaNivelacijaZag_dnz_id
            // 
            this.coldozvoljenaNivelacijaZag_dnz_id.Caption = "Broj";
            this.coldozvoljenaNivelacijaZag_dnz_id.FieldName = "dozvoljenaNivelacijaZag_dnz_id";
            this.coldozvoljenaNivelacijaZag_dnz_id.Name = "coldozvoljenaNivelacijaZag_dnz_id";
            this.coldozvoljenaNivelacijaZag_dnz_id.Visible = true;
            this.coldozvoljenaNivelacijaZag_dnz_id.VisibleIndex = 0;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikl";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 2;
            this.colAR_NAZIV.Width = 172;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikl";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 1;
            // 
            // colartikl_AR_ID
            // 
            this.colartikl_AR_ID.FieldName = "artikl_AR_ID";
            this.colartikl_AR_ID.Name = "colartikl_AR_ID";
            // 
            // coldn_aktivna
            // 
            this.coldn_aktivna.Caption = "Aktivna";
            this.coldn_aktivna.FieldName = "dn_aktivna";
            this.coldn_aktivna.Name = "coldn_aktivna";
            this.coldn_aktivna.Visible = true;
            this.coldn_aktivna.VisibleIndex = 4;
            // 
            // coldn_preporucenacijena
            // 
            this.coldn_preporucenacijena.Caption = "Prep. cijena";
            this.coldn_preporucenacijena.DisplayFormat.FormatString = "c2";
            this.coldn_preporucenacijena.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldn_preporucenacijena.FieldName = "dn_preporucenacijena";
            this.coldn_preporucenacijena.Name = "coldn_preporucenacijena";
            this.coldn_preporucenacijena.Visible = true;
            this.coldn_preporucenacijena.VisibleIndex = 3;
            // 
            // coloperater_op_id
            // 
            this.coloperater_op_id.FieldName = "operater_op_id";
            this.coloperater_op_id.Name = "coloperater_op_id";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater";
            this.gridColumn1.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 163;
            // 
            // coldn_datumizrade
            // 
            this.coldn_datumizrade.Caption = "Dat. izrade";
            this.coldn_datumizrade.FieldName = "dn_datumizrade";
            this.coldn_datumizrade.Name = "coldn_datumizrade";
            this.coldn_datumizrade.Visible = true;
            this.coldn_datumizrade.VisibleIndex = 6;
            // 
            // artikliZaNivelacijuTableAdapter
            // 
            this.artikliZaNivelacijuTableAdapter.ClearBeforeFill = true;
            // 
            // frmUnosArtikalaKojimaSeMijenjaCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmUnosArtikalaKojimaSeMijenjaCijena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos artikala kojima se mijenja cijena";
            this.Deactivate += new System.EventHandler(this.frmUnosArtikalaKojimaSeMijenjaCijena_Deactivate);
            this.Load += new System.EventHandler(this.frmUnosArtikalaKojimaSeMijenjaCijena_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUnosArtikalaKojimaSeMijenjaCijena_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreporucenaCijena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliZaNivelacijuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliZaNivelaciju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifraOperatera;
        private System.Windows.Forms.TextBox txtSifraPoslovnice;
        private System.Windows.Forms.TextBox txtOpisCjenika;
        private System.Windows.Forms.DateTimePicker dtpOdKada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDoKada;
        private System.Windows.Forms.Label lblNazivPoslovnice;
        private System.Windows.Forms.Label lblNazivOperatera;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.CheckBox ckbAktivna;
        private DevExpress.XtraEditors.TextEdit txtPreporucenaCijena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.TextBox txtArtiklSifra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSpremiArtikl;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private DevExpress.XtraGrid.GridControl dgCjenici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource artikliZaNivelacijuBindingSource;
        private ArtikliZaNivelaciju artikliZaNivelaciju;
        private DevExpress.XtraGrid.Columns.GridColumn coldn_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldozvoljenaNivelacijaZag_dnz_id;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_AR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn coldn_aktivna;
        private DevExpress.XtraGrid.Columns.GridColumn coldn_preporucenacijena;
        private DevExpress.XtraGrid.Columns.GridColumn coldn_datumizrade;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_id;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private ArtikliZaNivelacijuTableAdapters.ArtikliZaNivelacijuTableAdapter artikliZaNivelacijuTableAdapter;
        private System.Windows.Forms.Button btnBrisi;

    }
}