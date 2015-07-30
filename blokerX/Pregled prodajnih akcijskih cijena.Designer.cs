namespace blokerX
{
    partial class frmPregledProdajnihAkcijskihCijena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledProdajnihAkcijskihCijena));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbBezDobavljaca = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDokada = new System.Windows.Forms.DateTimePicker();
            this.dtpODkada = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziArtikle = new System.Windows.Forms.Button();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgArtikli = new DevExpress.XtraGrid.GridControl();
            this.pregledAkcProdCijenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_akcijskih_prodajnih_cijena = new blokerX.Pregled_akcijskih_prodajnih_cijena();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprc_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vaziod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vazido1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_nivo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_aktivna1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipb1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_letak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.colprc_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vaziod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_nivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprodajnicjenik_prc_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_aktivna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pregledAkcProdCijenaTableAdapter = new blokerX.Pregled_akcijskih_prodajnih_cijenaTableAdapters.PregledAkcProdCijenaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledAkcProdCijenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcijskih_prodajnih_cijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ckbBezDobavljaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbNivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDokada);
            this.panel1.Controls.Add(this.dtpODkada);
            this.panel1.Controls.Add(this.btnPrikaziArtikle);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 79);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1079, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "F9 - excel";
            // 
            // ckbBezDobavljaca
            // 
            this.ckbBezDobavljaca.AutoSize = true;
            this.ckbBezDobavljaca.Location = new System.Drawing.Point(388, 15);
            this.ckbBezDobavljaca.Name = "ckbBezDobavljaca";
            this.ckbBezDobavljaca.Size = new System.Drawing.Size(99, 17);
            this.ckbBezDobavljaca.TabIndex = 20;
            this.ckbBezDobavljaca.Text = "Bez dobavljača";
            this.ckbBezDobavljaca.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nivo:";
            // 
            // cmbNivo
            // 
            this.cmbNivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivo.FormattingEnabled = true;
            this.cmbNivo.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cmbNivo.Location = new System.Drawing.Point(426, 48);
            this.cmbNivo.Name = "cmbNivo";
            this.cmbNivo.Size = new System.Drawing.Size(41, 21);
            this.cmbNivo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Razdoblje od:";
            // 
            // dtpDokada
            // 
            this.dtpDokada.Location = new System.Drawing.Point(253, 48);
            this.dtpDokada.Name = "dtpDokada";
            this.dtpDokada.Size = new System.Drawing.Size(112, 20);
            this.dtpDokada.TabIndex = 2;
            // 
            // dtpODkada
            // 
            this.dtpODkada.Location = new System.Drawing.Point(106, 48);
            this.dtpODkada.Name = "dtpODkada";
            this.dtpODkada.Size = new System.Drawing.Size(111, 20);
            this.dtpODkada.TabIndex = 1;
            // 
            // btnPrikaziArtikle
            // 
            this.btnPrikaziArtikle.Location = new System.Drawing.Point(550, 45);
            this.btnPrikaziArtikle.Name = "btnPrikaziArtikle";
            this.btnPrikaziArtikle.Size = new System.Drawing.Size(106, 23);
            this.btnPrikaziArtikle.TabIndex = 4;
            this.btnPrikaziArtikle.Text = "Prikaži artikle";
            this.btnPrikaziArtikle.UseVisualStyleBackColor = true;
            this.btnPrikaziArtikle.Click += new System.EventHandler(this.btnPrikaziArtikle_Click);
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(76, 12);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(286, 20);
            this.glDobavljac.TabIndex = 0;
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
            this.colPA_SIFRA.Caption = "Šifra";
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 187;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Naziv";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 877;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobavljač:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 69);
            this.panel2.TabIndex = 12;
            // 
            // dgArtikli
            // 
            this.dgArtikli.DataSource = this.pregledAkcProdCijenaBindingSource;
            this.dgArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtikli.Location = new System.Drawing.Point(0, 79);
            this.dgArtikli.MainView = this.gridView2;
            this.dgArtikli.Name = "dgArtikli";
            this.dgArtikli.Size = new System.Drawing.Size(1144, 432);
            this.dgArtikli.TabIndex = 13;
            this.dgArtikli.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pregledAkcProdCijenaBindingSource
            // 
            this.pregledAkcProdCijenaBindingSource.DataMember = "PregledAkcProdCijena";
            this.pregledAkcProdCijenaBindingSource.DataSource = this.pregled_akcijskih_prodajnih_cijena;
            // 
            // pregled_akcijskih_prodajnih_cijena
            // 
            this.pregled_akcijskih_prodajnih_cijena.DataSetName = "Pregled_akcijskih_prodajnih_cijena";
            this.pregled_akcijskih_prodajnih_cijena.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colprc_ID2,
            this.colprc_vaziod1,
            this.colprc_vazido1,
            this.colprc_nivo1,
            this.colpa_naziv2,
            this.gridColumn2,
            this.colprc_aktivna1,
            this.colprc_tipa1,
            this.colprc_tipb1,
            this.colprc_tipc1,
            this.colprc_tipd1,
            this.colprc_tipx,
            this.colprc_napomena,
            this.colprc_letak,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colRG_NAZIV,
            this.colRG_SIFRA});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView2.GridControl = this.dgArtikli;
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
            // colprc_ID2
            // 
            this.colprc_ID2.Caption = "Broj";
            this.colprc_ID2.FieldName = "prc_ID";
            this.colprc_ID2.Name = "colprc_ID2";
            this.colprc_ID2.Visible = true;
            this.colprc_ID2.VisibleIndex = 0;
            this.colprc_ID2.Width = 61;
            // 
            // colprc_vaziod1
            // 
            this.colprc_vaziod1.Caption = "Važi od";
            this.colprc_vaziod1.FieldName = "prc_vaziod";
            this.colprc_vaziod1.Name = "colprc_vaziod1";
            this.colprc_vaziod1.Visible = true;
            this.colprc_vaziod1.VisibleIndex = 4;
            // 
            // colprc_vazido1
            // 
            this.colprc_vazido1.Caption = "Važi do";
            this.colprc_vazido1.FieldName = "prc_vazido";
            this.colprc_vazido1.Name = "colprc_vazido1";
            this.colprc_vazido1.Visible = true;
            this.colprc_vazido1.VisibleIndex = 5;
            // 
            // colprc_nivo1
            // 
            this.colprc_nivo1.Caption = "Nivo";
            this.colprc_nivo1.FieldName = "prc_nivo";
            this.colprc_nivo1.Name = "colprc_nivo1";
            this.colprc_nivo1.Visible = true;
            this.colprc_nivo1.VisibleIndex = 13;
            this.colprc_nivo1.Width = 39;
            // 
            // colpa_naziv2
            // 
            this.colpa_naziv2.Caption = "Partner";
            this.colpa_naziv2.FieldName = "pa_naziv";
            this.colpa_naziv2.Name = "colpa_naziv2";
            this.colpa_naziv2.Visible = true;
            this.colpa_naziv2.VisibleIndex = 14;
            this.colpa_naziv2.Width = 125;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colprc_aktivna1
            // 
            this.colprc_aktivna1.Caption = "Aktivna";
            this.colprc_aktivna1.FieldName = "prc_aktivna";
            this.colprc_aktivna1.Name = "colprc_aktivna1";
            this.colprc_aktivna1.Visible = true;
            this.colprc_aktivna1.VisibleIndex = 15;
            this.colprc_aktivna1.Width = 56;
            // 
            // colprc_tipa1
            // 
            this.colprc_tipa1.Caption = "A";
            this.colprc_tipa1.FieldName = "prc_tipa";
            this.colprc_tipa1.Name = "colprc_tipa1";
            this.colprc_tipa1.Visible = true;
            this.colprc_tipa1.VisibleIndex = 6;
            this.colprc_tipa1.Width = 45;
            // 
            // colprc_tipb1
            // 
            this.colprc_tipb1.Caption = "B";
            this.colprc_tipb1.FieldName = "prc_tipb";
            this.colprc_tipb1.Name = "colprc_tipb1";
            this.colprc_tipb1.Visible = true;
            this.colprc_tipb1.VisibleIndex = 7;
            this.colprc_tipb1.Width = 47;
            // 
            // colprc_tipc1
            // 
            this.colprc_tipc1.Caption = "C";
            this.colprc_tipc1.FieldName = "prc_tipc";
            this.colprc_tipc1.Name = "colprc_tipc1";
            this.colprc_tipc1.Visible = true;
            this.colprc_tipc1.VisibleIndex = 8;
            this.colprc_tipc1.Width = 44;
            // 
            // colprc_tipd1
            // 
            this.colprc_tipd1.Caption = "D";
            this.colprc_tipd1.FieldName = "prc_tipd";
            this.colprc_tipd1.Name = "colprc_tipd1";
            this.colprc_tipd1.Visible = true;
            this.colprc_tipd1.VisibleIndex = 9;
            this.colprc_tipd1.Width = 41;
            // 
            // colprc_tipx
            // 
            this.colprc_tipx.Caption = "X";
            this.colprc_tipx.FieldName = "prc_tipx";
            this.colprc_tipx.Name = "colprc_tipx";
            this.colprc_tipx.Visible = true;
            this.colprc_tipx.VisibleIndex = 10;
            this.colprc_tipx.Width = 43;
            // 
            // colprc_napomena
            // 
            this.colprc_napomena.Caption = "Napomena";
            this.colprc_napomena.FieldName = "prc_napomena";
            this.colprc_napomena.Name = "colprc_napomena";
            this.colprc_napomena.Visible = true;
            this.colprc_napomena.VisibleIndex = 16;
            this.colprc_napomena.Width = 95;
            // 
            // colprc_letak
            // 
            this.colprc_letak.Caption = "Letak";
            this.colprc_letak.FieldName = "prc_letak";
            this.colprc_letak.Name = "colprc_letak";
            this.colprc_letak.SummaryItem.DisplayFormat = "{0:#.00}";
            this.colprc_letak.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colprc_letak.Visible = true;
            this.colprc_letak.VisibleIndex = 3;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 1;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 2;
            this.colAR_NAZIV.Width = 219;
            // 
            // colRG_NAZIV
            // 
            this.colRG_NAZIV.Caption = "RG naziv";
            this.colRG_NAZIV.FieldName = "RG_NAZIV";
            this.colRG_NAZIV.Name = "colRG_NAZIV";
            this.colRG_NAZIV.Visible = true;
            this.colRG_NAZIV.VisibleIndex = 12;
            this.colRG_NAZIV.Width = 144;
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "RG šifra";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 11;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // colprc_ID
            // 
            this.colprc_ID.FieldName = "prc_ID";
            this.colprc_ID.Name = "colprc_ID";
            // 
            // colprc_vaziod
            // 
            this.colprc_vaziod.FieldName = "prc_vaziod";
            this.colprc_vaziod.Name = "colprc_vaziod";
            // 
            // colprc_vazido
            // 
            this.colprc_vazido.FieldName = "prc_vazido";
            this.colprc_vazido.Name = "colprc_vazido";
            // 
            // colprc_nivo
            // 
            this.colprc_nivo.FieldName = "prc_nivo";
            this.colprc_nivo.Name = "colprc_nivo";
            // 
            // colpa_naziv1
            // 
            this.colpa_naziv1.FieldName = "pa_naziv";
            this.colpa_naziv1.Name = "colpa_naziv1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colprc_ID1
            // 
            this.colprc_ID1.FieldName = "prc_ID1";
            this.colprc_ID1.Name = "colprc_ID1";
            // 
            // colprodajnicjenik_prc_ID
            // 
            this.colprodajnicjenik_prc_ID.FieldName = "prodajnicjenik_prc_ID";
            this.colprodajnicjenik_prc_ID.Name = "colprodajnicjenik_prc_ID";
            // 
            // colprc_aktivna
            // 
            this.colprc_aktivna.FieldName = "prc_aktivna";
            this.colprc_aktivna.Name = "colprc_aktivna";
            // 
            // colprc_tipa
            // 
            this.colprc_tipa.FieldName = "prc_tipa";
            this.colprc_tipa.Name = "colprc_tipa";
            // 
            // colprc_tipb
            // 
            this.colprc_tipb.FieldName = "prc_tipb";
            this.colprc_tipb.Name = "colprc_tipb";
            // 
            // colprc_tipc
            // 
            this.colprc_tipc.FieldName = "prc_tipc";
            this.colprc_tipc.Name = "colprc_tipc";
            // 
            // colprc_tipd
            // 
            this.colprc_tipd.FieldName = "prc_tipd";
            this.colprc_tipd.Name = "colprc_tipd";
            // 
            // pregledAkcProdCijenaTableAdapter
            // 
            this.pregledAkcProdCijenaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledProdajnihAkcijskihCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 580);
            this.Controls.Add(this.dgArtikli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledProdajnihAkcijskihCijena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled prodajnih akcijskih cijena";
            this.Load += new System.EventHandler(this.frmPregledProdajnihAkcijskihCijena_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledProdajnihAkcijskihCijena_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledAkcProdCijenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcijskih_prodajnih_cijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgArtikli;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDokada;
        private System.Windows.Forms.DateTimePicker dtpODkada;
        private System.Windows.Forms.Button btnPrikaziArtikle;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNivo;
        private System.Windows.Forms.CheckBox ckbBezDobavljaca;
        private System.Windows.Forms.BindingSource pregledAkcProdCijenaBindingSource;
        private Pregled_akcijskih_prodajnih_cijena pregled_akcijskih_prodajnih_cijena;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vaziod1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vazido1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_nivo1;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_aktivna1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipa1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipb1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipc1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipd1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipx;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_napomena;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_letak;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vaziod;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vazido;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_nivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colprodajnicjenik_prc_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_aktivna;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipa;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipb;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipc;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipd;
        private Pregled_akcijskih_prodajnih_cijenaTableAdapters.PregledAkcProdCijenaTableAdapter pregledAkcProdCijenaTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}