namespace blokerX
{
    partial class frmPregledAkcijskihCijenaNivo3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledAkcijskihCijenaNivo3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbSvi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDokada = new System.Windows.Forms.DateTimePicker();
            this.dtpODkada = new System.Windows.Forms.DateTimePicker();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCjenici = new DevExpress.XtraGrid.GridControl();
            this.akcijeskeCijeneNivo3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akcCijeneNivo3 = new blokerX.AkcCijeneNivo3();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprc_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vaziod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_vazido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_aktivna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_letak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprc_tipx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRG_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.akcijeskeCijeneNivo3TableAdapter = new blokerX.AkcCijeneNivo3TableAdapters.akcijeskeCijeneNivo3TableAdapter();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeskeCijeneNivo3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcCijeneNivo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbSvi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDokada);
            this.panel1.Controls.Add(this.dtpODkada);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 94);
            this.panel1.TabIndex = 0;
            // 
            // ckbSvi
            // 
            this.ckbSvi.AutoSize = true;
            this.ckbSvi.Location = new System.Drawing.Point(420, 15);
            this.ckbSvi.Name = "ckbSvi";
            this.ckbSvi.Size = new System.Drawing.Size(92, 17);
            this.ckbSvi.TabIndex = 20;
            this.ckbSvi.Text = "Svi dobavljači";
            this.ckbSvi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(958, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "F9 - excel";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(401, 50);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 18;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Za razdoblje od:";
            // 
            // dtpDokada
            // 
            this.dtpDokada.Location = new System.Drawing.Point(252, 52);
            this.dtpDokada.Name = "dtpDokada";
            this.dtpDokada.Size = new System.Drawing.Size(112, 20);
            this.dtpDokada.TabIndex = 15;
            // 
            // dtpODkada
            // 
            this.dtpODkada.Location = new System.Drawing.Point(100, 52);
            this.dtpODkada.Name = "dtpODkada";
            this.dtpODkada.Size = new System.Drawing.Size(116, 20);
            this.dtpODkada.TabIndex = 14;
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(100, 12);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.NullText = "";
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(286, 20);
            this.glDobavljac.TabIndex = 12;
            this.glDobavljac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glDobavljac_KeyDown);
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
            this.colPA_SIFRA1,
            this.colPA_NAZIV1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPA_ID
            // 
            this.colPA_ID.FieldName = "PA_ID";
            this.colPA_ID.Name = "colPA_ID";
            // 
            // colPA_SIFRA1
            // 
            this.colPA_SIFRA1.Caption = "Šifra";
            this.colPA_SIFRA1.FieldName = "PA_SIFRA";
            this.colPA_SIFRA1.Name = "colPA_SIFRA1";
            this.colPA_SIFRA1.Visible = true;
            this.colPA_SIFRA1.VisibleIndex = 0;
            this.colPA_SIFRA1.Width = 260;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Partner";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 1;
            this.colPA_NAZIV1.Width = 1453;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dobavljač:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 28);
            this.panel2.TabIndex = 12;
            // 
            // dgCjenici
            // 
            this.dgCjenici.DataSource = this.akcijeskeCijeneNivo3BindingSource;
            this.dgCjenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCjenici.Location = new System.Drawing.Point(0, 94);
            this.dgCjenici.MainView = this.gridView2;
            this.dgCjenici.Name = "dgCjenici";
            this.dgCjenici.Size = new System.Drawing.Size(1066, 434);
            this.dgCjenici.TabIndex = 13;
            this.dgCjenici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgCjenici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCjenici_KeyDown);
            // 
            // akcijeskeCijeneNivo3BindingSource
            // 
            this.akcijeskeCijeneNivo3BindingSource.DataMember = "akcijeskeCijeneNivo3";
            this.akcijeskeCijeneNivo3BindingSource.DataSource = this.akcCijeneNivo3;
            // 
            // akcCijeneNivo3
            // 
            this.akcCijeneNivo3.DataSetName = "AkcCijeneNivo3";
            this.akcCijeneNivo3.EnforceConstraints = false;
            this.akcCijeneNivo3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colprc_ID,
            this.colprc_vaziod,
            this.colprc_vazido,
            this.colprc_aktivna,
            this.colprc_letak,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.colprc_napomena,
            this.colPA_SIFRA,
            this.colPA_NAZIV,
            this.colprc_tipa,
            this.colprc_tipb,
            this.colprc_tipc,
            this.colprc_tipd,
            this.colprc_tipx,
            this.colRG_SIFRA,
            this.colRG_NAZIV,
            this.gridColumn1});
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
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.PaintStyleName = "WindowsXP";
            this.gridView2.SynchronizeClones = false;
            // 
            // colprc_ID
            // 
            this.colprc_ID.Caption = "Broj";
            this.colprc_ID.FieldName = "prc_ID";
            this.colprc_ID.Name = "colprc_ID";
            this.colprc_ID.Visible = true;
            this.colprc_ID.VisibleIndex = 0;
            this.colprc_ID.Width = 60;
            // 
            // colprc_vaziod
            // 
            this.colprc_vaziod.Caption = "Važi od";
            this.colprc_vaziod.FieldName = "prc_vaziod";
            this.colprc_vaziod.Name = "colprc_vaziod";
            this.colprc_vaziod.Visible = true;
            this.colprc_vaziod.VisibleIndex = 1;
            // 
            // colprc_vazido
            // 
            this.colprc_vazido.Caption = "Važi do";
            this.colprc_vazido.FieldName = "prc_vazido";
            this.colprc_vazido.Name = "colprc_vazido";
            this.colprc_vazido.Visible = true;
            this.colprc_vazido.VisibleIndex = 2;
            // 
            // colprc_aktivna
            // 
            this.colprc_aktivna.Caption = "Aktivna";
            this.colprc_aktivna.FieldName = "prc_aktivna";
            this.colprc_aktivna.Name = "colprc_aktivna";
            this.colprc_aktivna.Visible = true;
            this.colprc_aktivna.VisibleIndex = 3;
            this.colprc_aktivna.Width = 57;
            // 
            // colprc_letak
            // 
            this.colprc_letak.Caption = "Letak";
            this.colprc_letak.FieldName = "prc_letak";
            this.colprc_letak.Name = "colprc_letak";
            this.colprc_letak.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colprc_letak.Visible = true;
            this.colprc_letak.VisibleIndex = 4;
            this.colprc_letak.Width = 69;
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikl";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 5;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikl";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 6;
            this.colAR_NAZIV.Width = 195;
            // 
            // colprc_napomena
            // 
            this.colprc_napomena.Caption = "Napomena";
            this.colprc_napomena.FieldName = "prc_napomena";
            this.colprc_napomena.Name = "colprc_napomena";
            this.colprc_napomena.Visible = true;
            this.colprc_napomena.VisibleIndex = 7;
            this.colprc_napomena.Width = 106;
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.Caption = "Partner šifra";
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 8;
            this.colPA_SIFRA.Width = 79;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Partner naziv";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 9;
            this.colPA_NAZIV.Width = 221;
            // 
            // colprc_tipa
            // 
            this.colprc_tipa.Caption = "A";
            this.colprc_tipa.FieldName = "prc_tipa";
            this.colprc_tipa.Name = "colprc_tipa";
            this.colprc_tipa.Visible = true;
            this.colprc_tipa.VisibleIndex = 10;
            this.colprc_tipa.Width = 69;
            // 
            // colprc_tipb
            // 
            this.colprc_tipb.Caption = "B";
            this.colprc_tipb.FieldName = "prc_tipb";
            this.colprc_tipb.Name = "colprc_tipb";
            this.colprc_tipb.Visible = true;
            this.colprc_tipb.VisibleIndex = 11;
            this.colprc_tipb.Width = 69;
            // 
            // colprc_tipc
            // 
            this.colprc_tipc.Caption = "C";
            this.colprc_tipc.FieldName = "prc_tipc";
            this.colprc_tipc.Name = "colprc_tipc";
            this.colprc_tipc.Visible = true;
            this.colprc_tipc.VisibleIndex = 12;
            this.colprc_tipc.Width = 65;
            // 
            // colprc_tipd
            // 
            this.colprc_tipd.Caption = "D";
            this.colprc_tipd.FieldName = "prc_tipd";
            this.colprc_tipd.Name = "colprc_tipd";
            this.colprc_tipd.Visible = true;
            this.colprc_tipd.VisibleIndex = 13;
            this.colprc_tipd.Width = 72;
            // 
            // colprc_tipx
            // 
            this.colprc_tipx.Caption = "X";
            this.colprc_tipx.FieldName = "prc_tipx";
            this.colprc_tipx.Name = "colprc_tipx";
            this.colprc_tipx.Visible = true;
            this.colprc_tipx.VisibleIndex = 14;
            this.colprc_tipx.Width = 70;
            // 
            // colRG_SIFRA
            // 
            this.colRG_SIFRA.Caption = "RG šifra";
            this.colRG_SIFRA.FieldName = "RG_SIFRA";
            this.colRG_SIFRA.Name = "colRG_SIFRA";
            this.colRG_SIFRA.Visible = true;
            this.colRG_SIFRA.VisibleIndex = 15;
            // 
            // colRG_NAZIV
            // 
            this.colRG_NAZIV.Caption = "RG naziv";
            this.colRG_NAZIV.FieldName = "RG_NAZIV";
            this.colRG_NAZIV.Name = "colRG_NAZIV";
            this.colRG_NAZIV.Visible = true;
            this.colRG_NAZIV.VisibleIndex = 16;
            this.colRG_NAZIV.Width = 165;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater";
            this.gridColumn1.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 17;
            this.gridColumn1.Width = 133;
            // 
            // akcijeskeCijeneNivo3TableAdapter
            // 
            this.akcijeskeCijeneNivo3TableAdapter.ClearBeforeFill = true;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledAkcijskihCijenaNivo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 556);
            this.Controls.Add(this.dgCjenici);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledAkcijskihCijenaNivo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled akcijskih cijena nivo 3";
            this.Load += new System.EventHandler(this.frmPregledAkcijskihCijenaNivo3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledAkcijskihCijenaNivo3_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCjenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcijeskeCijeneNivo3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcCijeneNivo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgCjenici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource akcijeskeCijeneNivo3BindingSource;
        private AkcCijeneNivo3 akcCijeneNivo3;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vaziod;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_vazido;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_aktivna;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_letak;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_napomena;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipa;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipb;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipc;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipd;
        private DevExpress.XtraGrid.Columns.GridColumn colprc_tipx;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colRG_NAZIV;
        private AkcCijeneNivo3TableAdapters.akcijeskeCijeneNivo3TableAdapter akcijeskeCijeneNivo3TableAdapter;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDokada;
        private System.Windows.Forms.DateTimePicker dtpODkada;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbSvi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}