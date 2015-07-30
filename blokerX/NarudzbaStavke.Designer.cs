namespace blokerX
{
    partial class frmStavkeNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStavkeNarudzbe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivTrgovine = new System.Windows.Forms.TextBox();
            this.txtSifraTrgovine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.dgStavke = new DevExpress.XtraGrid.GridControl();
            this.narudzbaStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbaStavke = new blokerX.NarudzbaStavke();
            this.dgStavkeNarudzbe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnarudzba_na_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarkod_bk_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnarucena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_nabavnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colodobreno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_isporucenakolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZA_STANJE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_nenarucuj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_pakiranjeTrgovina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_pakiranje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_trenutnazaliha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprepravi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnas_prodanakolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_dnevnonaruceno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colar_dnevnoodobreno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmm_maxkolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmm_minkolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_minkolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_maxkolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.narudzbaStavkeTableAdapter = new blokerX.NarudzbaStavkeTableAdapters.narudzbaStavkeTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBrojDana);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNazivTrgovine);
            this.panel1.Controls.Add(this.txtSifraTrgovine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBrojNarudzbe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSkladiste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 78);
            this.panel1.TabIndex = 0;
            // 
            // txtTip
            // 
            this.txtTip.BackColor = System.Drawing.SystemColors.Window;
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTip.Location = new System.Drawing.Point(515, 43);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tip posl.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "dana";
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrojDana.Location = new System.Drawing.Point(517, 12);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.ReadOnly = true;
            this.txtBrojDana.Size = new System.Drawing.Size(61, 20);
            this.txtBrojDana.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prodaja za:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Skladište:";
            // 
            // txtNazivTrgovine
            // 
            this.txtNazivTrgovine.BackColor = System.Drawing.SystemColors.Window;
            this.txtNazivTrgovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivTrgovine.Location = new System.Drawing.Point(212, 43);
            this.txtNazivTrgovine.Name = "txtNazivTrgovine";
            this.txtNazivTrgovine.ReadOnly = true;
            this.txtNazivTrgovine.Size = new System.Drawing.Size(191, 20);
            this.txtNazivTrgovine.TabIndex = 6;
            // 
            // txtSifraTrgovine
            // 
            this.txtSifraTrgovine.BackColor = System.Drawing.SystemColors.Window;
            this.txtSifraTrgovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSifraTrgovine.Location = new System.Drawing.Point(77, 43);
            this.txtSifraTrgovine.Name = "txtSifraTrgovine";
            this.txtSifraTrgovine.ReadOnly = true;
            this.txtSifraTrgovine.Size = new System.Drawing.Size(100, 20);
            this.txtSifraTrgovine.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trgovina:";
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(303, 12);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.ReadOnly = true;
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.txtBrojNarudzbe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj narudžbe:";
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.BackColor = System.Drawing.SystemColors.Window;
            this.txtSkladiste.Location = new System.Drawing.Point(77, 15);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.ReadOnly = true;
            this.txtSkladiste.Size = new System.Drawing.Size(100, 20);
            this.txtSkladiste.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIzlaz);
            this.panel2.Controls.Add(this.btnIspis);
            this.panel2.Controls.Add(this.btnZakljuci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 54);
            this.panel2.TabIndex = 1;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(965, 14);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "ESC - izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(178, 13);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Location = new System.Drawing.Point(24, 13);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(132, 23);
            this.btnZakljuci.TabIndex = 0;
            this.btnZakljuci.Text = "Zaključi narudžbu";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // dgStavke
            // 
            this.dgStavke.DataSource = this.narudzbaStavkeBindingSource;
            this.dgStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStavke.Location = new System.Drawing.Point(0, 78);
            this.dgStavke.MainView = this.dgStavkeNarudzbe;
            this.dgStavke.Name = "dgStavke";
            this.dgStavke.Size = new System.Drawing.Size(1246, 381);
            this.dgStavke.TabIndex = 0;
            this.dgStavke.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgStavkeNarudzbe});
            // 
            // narudzbaStavkeBindingSource
            // 
            this.narudzbaStavkeBindingSource.DataMember = "narudzbaStavke";
            this.narudzbaStavkeBindingSource.DataSource = this.narudzbaStavke;
            // 
            // narudzbaStavke
            // 
            this.narudzbaStavke.DataSetName = "NarudzbaStavke";
            this.narudzbaStavke.EnforceConstraints = false;
            this.narudzbaStavke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgStavkeNarudzbe
            // 
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.Empty.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgStavkeNarudzbe.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgStavkeNarudzbe.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeNarudzbe.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgStavkeNarudzbe.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseFont = true;
            this.dgStavkeNarudzbe.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgStavkeNarudzbe.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeNarudzbe.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.OddRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.OddRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgStavkeNarudzbe.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgStavkeNarudzbe.Appearance.Preview.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.Preview.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.Row.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.Row.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgStavkeNarudzbe.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgStavkeNarudzbe.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgStavkeNarudzbe.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeNarudzbe.Appearance.VertLine.Options.UseBackColor = true;
            this.dgStavkeNarudzbe.ColumnPanelRowHeight = 50;
            this.dgStavkeNarudzbe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRG_SIFRA,
            this.colRG_NAZIV,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colnas_ID,
            this.colnarudzba_na_ID,
            this.colartikl_ar_ID,
            this.colbarkod_bk_kod,
            this.colnarucena,
            this.colnas_nabavnacijena,
            this.colodobreno,
            this.colnas_isporucenakolicina,
            this.colZA_STANJE,
            this.colar_nenarucuj,
            this.colprc_vazido,
            this.colar_pakiranjeTrgovina,
            this.colar_pakiranje,
            this.colnas_trenutnazaliha,
            this.colprepravi,
            this.colnas_prodanakolicina,
            this.colar_dnevnonaruceno,
            this.colar_dnevnoodobreno,
            this.colmm_maxkolicina,
            this.colmm_minkolicina,
            this.colmi_minkolicina,
            this.colmi_maxkolicina});
            this.dgStavkeNarudzbe.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgStavkeNarudzbe.GridControl = this.dgStavke;
            this.dgStavkeNarudzbe.Name = "dgStavkeNarudzbe";
            this.dgStavkeNarudzbe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeNarudzbe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeNarudzbe.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgStavkeNarudzbe.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgStavkeNarudzbe.OptionsCustomization.AllowColumnMoving = false;
            this.dgStavkeNarudzbe.OptionsCustomization.AllowFilter = false;
            this.dgStavkeNarudzbe.OptionsLayout.Columns.AddNewColumns = false;
            this.dgStavkeNarudzbe.OptionsLayout.Columns.RemoveOldColumns = false;
            this.dgStavkeNarudzbe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgStavkeNarudzbe.OptionsView.ColumnAutoWidth = false;
            this.dgStavkeNarudzbe.OptionsView.EnableAppearanceEvenRow = true;
            this.dgStavkeNarudzbe.OptionsView.EnableAppearanceOddRow = true;
            this.dgStavkeNarudzbe.OptionsView.ShowAutoFilterRow = true;
            this.dgStavkeNarudzbe.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgStavkeNarudzbe.OptionsView.ShowGroupPanel = false;
            this.dgStavkeNarudzbe.OptionsView.ShowIndicator = false;
            this.dgStavkeNarudzbe.PaintStyleName = "WindowsXP";
            this.dgStavkeNarudzbe.SynchronizeClones = false;
            this.dgStavkeNarudzbe.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgStavkeNarudzbe_RowCellStyle);
            this.dgStavkeNarudzbe.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dgStavkeNarudzbe_CellValueChanged);
            this.dgStavkeNarudzbe.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dgStavkeNarudzbe_RowUpdated);
            this.dgStavkeNarudzbe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgStavkeNarudzbe_KeyUp);
            this.dgStavkeNarudzbe.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dgStavkeNarudzbe_MouseWheel);
            this.dgStavkeNarudzbe.GotFocus += new System.EventHandler(this.dgStavkeNarudzbe_GotFocus);
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "Šifra RG";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.OptionsColumn.AllowEdit = false;
            this.colRG_SIFRA.OptionsColumn.AllowMove = false;
            this.colRG_SIFRA.Width = 84;
            // 
            // colRG_NAZIV
            // 
            this.colRG_NAZIV.Caption = "Naziv RG";
            this.colRG_NAZIV.FieldName = "RG_NAZIV";
            this.colRG_NAZIV.Name = "colRG_NAZIV";
            this.colRG_NAZIV.OptionsColumn.AllowEdit = false;
            this.colRG_NAZIV.Width = 179;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Artikl šifra";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.OptionsColumn.AllowEdit = false;
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 0;
            this.colAR_SIFRA.Width = 72;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Artikl naziv";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.OptionsColumn.AllowEdit = false;
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 1;
            this.colAR_NAZIV.Width = 243;
            // 
            // colnas_ID
            // 
            this.colnas_ID.FieldName = "nas_ID";
            this.colnas_ID.Name = "colnas_ID";
            this.colnas_ID.OptionsColumn.AllowEdit = false;
            // 
            // colnarudzba_na_ID
            // 
            this.colnarudzba_na_ID.FieldName = "narudzba_na_ID";
            this.colnarudzba_na_ID.Name = "colnarudzba_na_ID";
            this.colnarudzba_na_ID.OptionsColumn.AllowEdit = false;
            // 
            // colartikl_ar_ID
            // 
            this.colartikl_ar_ID.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID.Name = "colartikl_ar_ID";
            this.colartikl_ar_ID.OptionsColumn.AllowEdit = false;
            // 
            // colbarkod_bk_kod
            // 
            this.colbarkod_bk_kod.Caption = "Barkod";
            this.colbarkod_bk_kod.FieldName = "barkod_bk_kod";
            this.colbarkod_bk_kod.Name = "colbarkod_bk_kod";
            this.colbarkod_bk_kod.OptionsColumn.AllowEdit = false;
            this.colbarkod_bk_kod.Width = 82;
            // 
            // colnarucena
            // 
            this.colnarucena.Caption = "Naručena količina";
            this.colnarucena.FieldName = "narucena";
            this.colnarucena.Name = "colnarucena";
            this.colnarucena.OptionsColumn.AllowEdit = false;
            this.colnarucena.Visible = true;
            this.colnarucena.VisibleIndex = 3;
            this.colnarucena.Width = 57;
            // 
            // colnas_nabavnacijena
            // 
            this.colnas_nabavnacijena.Caption = "Nabavna cijena";
            this.colnas_nabavnacijena.DisplayFormat.FormatString = "n2";
            this.colnas_nabavnacijena.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnas_nabavnacijena.FieldName = "nas_nabavnacijena";
            this.colnas_nabavnacijena.Name = "colnas_nabavnacijena";
            this.colnas_nabavnacijena.OptionsColumn.AllowEdit = false;
            this.colnas_nabavnacijena.Visible = true;
            this.colnas_nabavnacijena.VisibleIndex = 9;
            this.colnas_nabavnacijena.Width = 68;
            // 
            // colodobreno
            // 
            this.colodobreno.Caption = "Ispravljena količina";
            this.colodobreno.FieldName = "odobreno";
            this.colodobreno.Name = "colodobreno";
            this.colodobreno.Visible = true;
            this.colodobreno.VisibleIndex = 4;
            this.colodobreno.Width = 65;
            // 
            // colnas_isporucenakolicina
            // 
            this.colnas_isporucenakolicina.Caption = "Isporučena količina";
            this.colnas_isporucenakolicina.FieldName = "nas_isporucenakolicina";
            this.colnas_isporucenakolicina.Name = "colnas_isporucenakolicina";
            this.colnas_isporucenakolicina.OptionsColumn.AllowEdit = false;
            this.colnas_isporucenakolicina.Width = 76;
            // 
            // colZA_STANJE
            // 
            this.colZA_STANJE.Caption = "Zaliha na sklad.";
            this.colZA_STANJE.DisplayFormat.FormatString = "n2";
            this.colZA_STANJE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colZA_STANJE.FieldName = "ZA_STANJE";
            this.colZA_STANJE.Name = "colZA_STANJE";
            this.colZA_STANJE.OptionsColumn.AllowEdit = false;
            this.colZA_STANJE.Visible = true;
            this.colZA_STANJE.VisibleIndex = 2;
            this.colZA_STANJE.Width = 54;
            // 
            // colar_nenarucuj
            // 
            this.colar_nenarucuj.Caption = "Nema robe";
            this.colar_nenarucuj.FieldName = "ar_nenarucuj";
            this.colar_nenarucuj.Name = "colar_nenarucuj";
            this.colar_nenarucuj.OptionsColumn.AllowEdit = false;
            this.colar_nenarucuj.Visible = true;
            this.colar_nenarucuj.VisibleIndex = 17;
            this.colar_nenarucuj.Width = 47;
            // 
            // colprc_vazido
            // 
            this.colprc_vazido.Caption = "Akcija traje do";
            this.colprc_vazido.FieldName = "prc_vazido";
            this.colprc_vazido.Name = "colprc_vazido";
            this.colprc_vazido.OptionsColumn.AllowEdit = false;
            this.colprc_vazido.Visible = true;
            this.colprc_vazido.VisibleIndex = 16;
            this.colprc_vazido.Width = 66;
            // 
            // colar_pakiranjeTrgovina
            // 
            this.colar_pakiranjeTrgovina.Caption = "Min. kol. za trgovinu";
            this.colar_pakiranjeTrgovina.FieldName = "ar_pakiranjeTrgovina";
            this.colar_pakiranjeTrgovina.Name = "colar_pakiranjeTrgovina";
            this.colar_pakiranjeTrgovina.OptionsColumn.AllowEdit = false;
            this.colar_pakiranjeTrgovina.Visible = true;
            this.colar_pakiranjeTrgovina.VisibleIndex = 11;
            this.colar_pakiranjeTrgovina.Width = 64;
            // 
            // colar_pakiranje
            // 
            this.colar_pakiranje.Caption = "Karton";
            this.colar_pakiranje.FieldName = "ar_pakiranje";
            this.colar_pakiranje.Name = "colar_pakiranje";
            this.colar_pakiranje.OptionsColumn.AllowEdit = false;
            this.colar_pakiranje.Visible = true;
            this.colar_pakiranje.VisibleIndex = 10;
            this.colar_pakiranje.Width = 52;
            // 
            // colnas_trenutnazaliha
            // 
            this.colnas_trenutnazaliha.Caption = "Zalih u trg.";
            this.colnas_trenutnazaliha.FieldName = "nas_trenutnazaliha";
            this.colnas_trenutnazaliha.Name = "colnas_trenutnazaliha";
            this.colnas_trenutnazaliha.OptionsColumn.AllowEdit = false;
            this.colnas_trenutnazaliha.Visible = true;
            this.colnas_trenutnazaliha.VisibleIndex = 5;
            this.colnas_trenutnazaliha.Width = 61;
            // 
            // colprepravi
            // 
            this.colprepravi.Caption = "Ispravak";
            this.colprepravi.FieldName = "prepravi";
            this.colprepravi.Name = "colprepravi";
            this.colprepravi.OptionsColumn.AllowEdit = false;
            // 
            // colnas_prodanakolicina
            // 
            this.colnas_prodanakolicina.Caption = "Prodana količina";
            this.colnas_prodanakolicina.FieldName = "nas_prodanakolicina";
            this.colnas_prodanakolicina.Name = "colnas_prodanakolicina";
            this.colnas_prodanakolicina.OptionsColumn.AllowEdit = false;
            this.colnas_prodanakolicina.Visible = true;
            this.colnas_prodanakolicina.VisibleIndex = 6;
            this.colnas_prodanakolicina.Width = 72;
            // 
            // colar_dnevnonaruceno
            // 
            this.colar_dnevnonaruceno.Caption = "Ukupno naručeno";
            this.colar_dnevnonaruceno.FieldName = "ar_dnevnonaruceno";
            this.colar_dnevnonaruceno.Name = "colar_dnevnonaruceno";
            this.colar_dnevnonaruceno.OptionsColumn.AllowEdit = false;
            this.colar_dnevnonaruceno.Visible = true;
            this.colar_dnevnonaruceno.VisibleIndex = 7;
            // 
            // colar_dnevnoodobreno
            // 
            this.colar_dnevnoodobreno.Caption = "Ukupno odobreno";
            this.colar_dnevnoodobreno.FieldName = "ar_dnevnoodobreno";
            this.colar_dnevnoodobreno.Name = "colar_dnevnoodobreno";
            this.colar_dnevnoodobreno.OptionsColumn.AllowEdit = false;
            this.colar_dnevnoodobreno.Visible = true;
            this.colar_dnevnoodobreno.VisibleIndex = 8;
            // 
            // colmm_maxkolicina
            // 
            this.colmm_maxkolicina.Caption = "Maximum";
            this.colmm_maxkolicina.FieldName = "mm_maxkolicina";
            this.colmm_maxkolicina.Name = "colmm_maxkolicina";
            this.colmm_maxkolicina.OptionsColumn.AllowEdit = false;
            this.colmm_maxkolicina.Visible = true;
            this.colmm_maxkolicina.VisibleIndex = 13;
            this.colmm_maxkolicina.Width = 55;
            // 
            // colmm_minkolicina
            // 
            this.colmm_minkolicina.Caption = "Minimum";
            this.colmm_minkolicina.FieldName = "mm_minkolicina";
            this.colmm_minkolicina.Name = "colmm_minkolicina";
            this.colmm_minkolicina.OptionsColumn.AllowEdit = false;
            this.colmm_minkolicina.Visible = true;
            this.colmm_minkolicina.VisibleIndex = 12;
            this.colmm_minkolicina.Width = 52;
            // 
            // colmi_minkolicina
            // 
            this.colmi_minkolicina.Caption = "Iznimka min";
            this.colmi_minkolicina.FieldName = "mi_minkolicina";
            this.colmi_minkolicina.Name = "colmi_minkolicina";
            this.colmi_minkolicina.OptionsColumn.AllowEdit = false;
            this.colmi_minkolicina.Visible = true;
            this.colmi_minkolicina.VisibleIndex = 14;
            this.colmi_minkolicina.Width = 46;
            // 
            // colmi_maxkolicina
            // 
            this.colmi_maxkolicina.Caption = "Iznimka max";
            this.colmi_maxkolicina.FieldName = "mi_maxkolicina";
            this.colmi_maxkolicina.Name = "colmi_maxkolicina";
            this.colmi_maxkolicina.OptionsColumn.AllowEdit = false;
            this.colmi_maxkolicina.Visible = true;
            this.colmi_maxkolicina.VisibleIndex = 15;
            this.colmi_maxkolicina.Width = 46;
            // 
            // narudzbaStavkeTableAdapter
            // 
            this.narudzbaStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // frmStavkeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 513);
            this.Controls.Add(this.dgStavke);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStavkeNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke narudžbe";
            this.Deactivate += new System.EventHandler(this.frmStavkeNarudzbe_Deactivate);
            this.Load += new System.EventHandler(this.frmStavkeNarudzbe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStavkeNarudzbe_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgStavke;
        private DevExpress.XtraGrid.Views.Grid.GridView dgStavkeNarudzbe;
        private System.Windows.Forms.TextBox txtNazivTrgovine;
        private System.Windows.Forms.TextBox txtSifraTrgovine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnZakljuci;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colnarudzba_na_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkod_bk_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_nabavnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_isporucenakolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colZA_STANJE;
        private DevExpress.XtraGrid.Columns.GridColumn colar_nenarucuj;

        private DevExpress.XtraGrid.Columns.GridColumn colar_pakiranjeTrgovina;
        private DevExpress.XtraGrid.Columns.GridColumn colar_pakiranje;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_trenutnazaliha;
        private DevExpress.XtraGrid.Columns.GridColumn colprepravi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colnas_prodanakolicina;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vazido;
        private System.Windows.Forms.BindingSource narudzbaStavkeBindingSource;
        private NarudzbaStavke narudzbaStavke;
        private NarudzbaStavkeTableAdapters.narudzbaStavkeTableAdapter narudzbaStavkeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnarucena;
        private DevExpress.XtraGrid.Columns.GridColumn colodobreno;
        private DevExpress.XtraGrid.Columns.GridColumn colar_dnevnonaruceno;
        private DevExpress.XtraGrid.Columns.GridColumn colar_dnevnoodobreno;
        private DevExpress.XtraGrid.Columns.GridColumn colmm_maxkolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colmm_minkolicina;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_minkolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_maxkolicina;
    }
}