namespace blokerX
{
    partial class frmPrijenosIzCSVDatoteke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijenosIzCSVDatoteke));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPutanja = new System.Windows.Forms.TextBox();
            this.glCjenik = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nabavnicjenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjenikDobavljacaCSV = new blokerX.CjenikDobavljacaCSV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnac_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_opis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vaziod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_aktivan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnac_nivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartneri_PA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.dgCSVPodaci = new DevExpress.XtraGrid.GridControl();
            this.dgPodaci = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.nabavnicjenikTableAdapter = new blokerX.CjenikDobavljacaCSVTableAdapters.nabavnicjenikTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glCjenik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavnicjenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikDobavljacaCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtPutanja);
            this.panel1.Controls.Add(this.glCjenik);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 94);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "F1 - pomoć";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(436, 63);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(95, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prenesi u tablicu";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::blokerX.Properties.Resources.open;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.Location = new System.Drawing.Point(385, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 21);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPutanja
            // 
            this.txtPutanja.Location = new System.Drawing.Point(113, 65);
            this.txtPutanja.Name = "txtPutanja";
            this.txtPutanja.Size = new System.Drawing.Size(266, 20);
            this.txtPutanja.TabIndex = 2;
            // 
            // glCjenik
            // 
            this.glCjenik.EditValue = "";
            this.glCjenik.Location = new System.Drawing.Point(113, 38);
            this.glCjenik.Name = "glCjenik";
            this.glCjenik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCjenik.Properties.DataSource = this.nabavnicjenikBindingSource;
            this.glCjenik.Properties.DisplayMember = "nac_opis";
            this.glCjenik.Properties.ValueMember = "nac_ID";
            this.glCjenik.Properties.View = this.gridView1;
            this.glCjenik.Size = new System.Drawing.Size(298, 20);
            this.glCjenik.TabIndex = 1;
            // 
            // nabavnicjenikBindingSource
            // 
            this.nabavnicjenikBindingSource.DataMember = "nabavnicjenik";
            this.nabavnicjenikBindingSource.DataSource = this.cjenikDobavljacaCSV;
            // 
            // cjenikDobavljacaCSV
            // 
            this.cjenikDobavljacaCSV.DataSetName = "CjenikDobavljacaCSV";
            this.cjenikDobavljacaCSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnac_ID,
            this.colnac_opis,
            this.colnac_vaziod,
            this.colnac_vazido,
            this.colnac_aktivan,
            this.colnac_nivo,
            this.colpartneri_PA_ID});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnac_ID
            // 
            this.colnac_ID.Caption = "Broj";
            this.colnac_ID.FieldName = "nac_ID";
            this.colnac_ID.Name = "colnac_ID";
            this.colnac_ID.Visible = true;
            this.colnac_ID.VisibleIndex = 0;
            this.colnac_ID.Width = 170;
            // 
            // colnac_opis
            // 
            this.colnac_opis.Caption = "Opis";
            this.colnac_opis.FieldName = "nac_opis";
            this.colnac_opis.Name = "colnac_opis";
            this.colnac_opis.Visible = true;
            this.colnac_opis.VisibleIndex = 1;
            this.colnac_opis.Width = 530;
            // 
            // colnac_vaziod
            // 
            this.colnac_vaziod.Caption = "Važi od";
            this.colnac_vaziod.FieldName = "nac_vaziod";
            this.colnac_vaziod.Name = "colnac_vaziod";
            this.colnac_vaziod.Visible = true;
            this.colnac_vaziod.VisibleIndex = 2;
            this.colnac_vaziod.Width = 366;
            // 
            // colnac_vazido
            // 
            this.colnac_vazido.FieldName = "nac_vazido";
            this.colnac_vazido.Name = "colnac_vazido";
            // 
            // colnac_aktivan
            // 
            this.colnac_aktivan.FieldName = "nac_aktivan";
            this.colnac_aktivan.Name = "colnac_aktivan";
            // 
            // colnac_nivo
            // 
            this.colnac_nivo.FieldName = "nac_nivo";
            this.colnac_nivo.Name = "colnac_nivo";
            // 
            // colpartneri_PA_ID
            // 
            this.colpartneri_PA_ID.FieldName = "partneri_PA_ID";
            this.colpartneri_PA_ID.Name = "colpartneri_PA_ID";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(113, 12);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(298, 20);
            this.glDobavljac.TabIndex = 0;
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
            this.colPA_SIFRA.Width = 180;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 515;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CSV datoteka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cjenik dobavljača:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.btnPrenesi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 69);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(213, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 6;
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Location = new System.Drawing.Point(34, 21);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(105, 23);
            this.btnPrenesi.TabIndex = 5;
            this.btnPrenesi.Text = "Spremi podatke";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // dgCSVPodaci
            // 
            this.dgCSVPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCSVPodaci.Location = new System.Drawing.Point(0, 94);
            this.dgCSVPodaci.MainView = this.dgPodaci;
            this.dgCSVPodaci.Name = "dgCSVPodaci";
            this.dgCSVPodaci.Size = new System.Drawing.Size(883, 381);
            this.dgCSVPodaci.TabIndex = 18;
            this.dgCSVPodaci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgPodaci});
            // 
            // dgPodaci
            // 
            this.dgPodaci.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPodaci.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPodaci.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgPodaci.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgPodaci.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgPodaci.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.Empty.Options.UseBackColor = true;
            this.dgPodaci.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPodaci.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPodaci.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgPodaci.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPodaci.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgPodaci.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgPodaci.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgPodaci.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgPodaci.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgPodaci.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPodaci.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPodaci.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgPodaci.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgPodaci.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgPodaci.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgPodaci.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgPodaci.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPodaci.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgPodaci.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgPodaci.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPodaci.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPodaci.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.GroupRow.Options.UseFont = true;
            this.dgPodaci.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPodaci.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPodaci.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPodaci.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgPodaci.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgPodaci.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgPodaci.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgPodaci.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgPodaci.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgPodaci.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPodaci.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPodaci.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgPodaci.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.OddRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.OddRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgPodaci.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgPodaci.Appearance.Preview.Options.UseBackColor = true;
            this.dgPodaci.Appearance.Preview.Options.UseForeColor = true;
            this.dgPodaci.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.Row.Options.UseBackColor = true;
            this.dgPodaci.Appearance.Row.Options.UseForeColor = true;
            this.dgPodaci.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgPodaci.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgPodaci.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgPodaci.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPodaci.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgPodaci.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgPodaci.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPodaci.Appearance.VertLine.Options.UseBackColor = true;
            this.dgPodaci.ColumnPanelRowHeight = 50;
            this.dgPodaci.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgPodaci.GridControl = this.dgCSVPodaci;
            this.dgPodaci.Name = "dgPodaci";
            this.dgPodaci.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPodaci.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPodaci.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgPodaci.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgPodaci.OptionsBehavior.Editable = false;
            this.dgPodaci.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgPodaci.OptionsView.EnableAppearanceEvenRow = true;
            this.dgPodaci.OptionsView.EnableAppearanceOddRow = true;
            this.dgPodaci.OptionsView.ShowAutoFilterRow = true;
            this.dgPodaci.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgPodaci.OptionsView.ShowGroupPanel = false;
            this.dgPodaci.OptionsView.ShowIndicator = false;
            this.dgPodaci.PaintStyleName = "WindowsXP";
            this.dgPodaci.SynchronizeClones = false;
            this.dgPodaci.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgArtikl_RowCellStyle);
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // nabavnicjenikTableAdapter
            // 
            this.nabavnicjenikTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrijenosIzCSVDatoteke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 544);
            this.Controls.Add(this.dgCSVPodaci);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrijenosIzCSVDatoteke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijenos cijena iz CSV datoteke";
            this.Load += new System.EventHandler(this.frmPrijenosIzCSVDatoteke_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrijenosIzCSVDatoteke_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glCjenik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavnicjenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikDobavljacaCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgCSVPodaci;
        private DevExpress.XtraGrid.Views.Grid.GridView dgPodaci;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPutanja;
        private DevExpress.XtraEditors.GridLookUpEdit glCjenik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nabavnicjenikBindingSource;
        private CjenikDobavljacaCSV cjenikDobavljacaCSV;
        private CjenikDobavljacaCSVTableAdapters.nabavnicjenikTableAdapter nabavnicjenikTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_opis;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vaziod;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_vazido;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_aktivan;
        private DevExpress.XtraGrid.Columns.GridColumn colnac_nivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpartneri_PA_ID;
        private System.Windows.Forms.Button btnPrenesi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
    }
}