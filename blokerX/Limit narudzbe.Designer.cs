namespace blokerX
{
    partial class frmLimitNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLimitNarudzbe));
            this.label2 = new System.Windows.Forms.Label();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner = new blokerX.Partner();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpa_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgLimit = new DevExpress.XtraGrid.GridControl();
            this.limitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.limitTrgovinaZaPartnera = new blokerX.LimitTrgovinaZaPartnera();
            this.dgLimitTrgovine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldop_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldop_limit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_po_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldop_danisat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_asortiman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new blokerX.PartnerTableAdapters.partnerTableAdapter();
            this.limitTableAdapter = new blokerX.LimitTrgovinaZaPartneraTableAdapters.limitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitTrgovinaZaPartnera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLimitTrgovine)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Partner:";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(103, 30);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "pa_naziv";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.NullText = "";
            this.glDobavljac.Properties.ValueMember = "pa_ID";
            this.glDobavljac.Properties.View = this.gridView1;
            this.glDobavljac.Size = new System.Drawing.Size(300, 20);
            this.glDobavljac.TabIndex = 1;
            this.glDobavljac.EditValueChanged += new System.EventHandler(this.glDobavljac_EditValueChanged);
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpa_ID,
            this.colpa_naziv});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpa_naziv, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colpa_ID
            // 
            this.colpa_ID.FieldName = "pa_ID";
            this.colpa_ID.Name = "colpa_ID";
            // 
            // colpa_naziv
            // 
            this.colpa_naziv.Caption = "partner";
            this.colpa_naziv.FieldName = "pa_naziv";
            this.colpa_naziv.Name = "colpa_naziv";
            this.colpa_naziv.Visible = true;
            this.colpa_naziv.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 103);
            this.panel1.TabIndex = 6;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(438, 59);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgLimit
            // 
            this.dgLimit.DataSource = this.limitBindingSource;
            this.dgLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLimit.Location = new System.Drawing.Point(0, 103);
            this.dgLimit.MainView = this.dgLimitTrgovine;
            this.dgLimit.Name = "dgLimit";
            this.dgLimit.Size = new System.Drawing.Size(1149, 370);
            this.dgLimit.TabIndex = 7;
            this.dgLimit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgLimitTrgovine});
            // 
            // limitBindingSource
            // 
            this.limitBindingSource.DataMember = "limit";
            this.limitBindingSource.DataSource = this.limitTrgovinaZaPartnera;
            // 
            // limitTrgovinaZaPartnera
            // 
            this.limitTrgovinaZaPartnera.DataSetName = "LimitTrgovinaZaPartnera";
            this.limitTrgovinaZaPartnera.EnforceConstraints = false;
            this.limitTrgovinaZaPartnera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgLimitTrgovine
            // 
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.Empty.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgLimitTrgovine.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgLimitTrgovine.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgLimitTrgovine.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgLimitTrgovine.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgLimitTrgovine.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgLimitTrgovine.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgLimitTrgovine.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgLimitTrgovine.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLimitTrgovine.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgLimitTrgovine.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.GroupRow.Options.UseFont = true;
            this.dgLimitTrgovine.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgLimitTrgovine.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgLimitTrgovine.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgLimitTrgovine.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgLimitTrgovine.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgLimitTrgovine.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgLimitTrgovine.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgLimitTrgovine.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgLimitTrgovine.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgLimitTrgovine.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.OddRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.OddRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgLimitTrgovine.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgLimitTrgovine.Appearance.Preview.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.Preview.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.Row.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.Row.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgLimitTrgovine.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgLimitTrgovine.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgLimitTrgovine.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgLimitTrgovine.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgLimitTrgovine.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgLimitTrgovine.Appearance.VertLine.Options.UseBackColor = true;
            this.dgLimitTrgovine.ColumnPanelRowHeight = 50;
            this.dgLimitTrgovine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldop_ID,
            this.coldop_limit,
            this.colposlovnica_po_id,
            this.colpo_naziv,
            this.gridColumn1,
            this.coldop_danisat,
            this.colpo_asortiman});
            this.dgLimitTrgovine.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgLimitTrgovine.GridControl = this.dgLimit;
            this.dgLimitTrgovine.Name = "dgLimitTrgovine";
            this.dgLimitTrgovine.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgLimitTrgovine.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgLimitTrgovine.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgLimitTrgovine.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgLimitTrgovine.OptionsCustomization.AllowColumnMoving = false;
            this.dgLimitTrgovine.OptionsCustomization.AllowFilter = false;
            this.dgLimitTrgovine.OptionsLayout.Columns.AddNewColumns = false;
            this.dgLimitTrgovine.OptionsLayout.Columns.RemoveOldColumns = false;
            this.dgLimitTrgovine.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgLimitTrgovine.OptionsView.ColumnAutoWidth = false;
            this.dgLimitTrgovine.OptionsView.EnableAppearanceEvenRow = true;
            this.dgLimitTrgovine.OptionsView.EnableAppearanceOddRow = true;
            this.dgLimitTrgovine.OptionsView.ShowAutoFilterRow = true;
            this.dgLimitTrgovine.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgLimitTrgovine.OptionsView.ShowGroupPanel = false;
            this.dgLimitTrgovine.OptionsView.ShowIndicator = false;
            this.dgLimitTrgovine.PaintStyleName = "WindowsXP";
            this.dgLimitTrgovine.SynchronizeClones = false;
            this.dgLimitTrgovine.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dgStavkeNarudzbe_RowUpdated);
            this.dgLimitTrgovine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgLimitTrgovine_KeyUp);
            this.dgLimitTrgovine.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dgLimitTrgovine_MouseWheel);
            this.dgLimitTrgovine.Click += new System.EventHandler(this.dgLimitTrgovine_Click);
            // 
            // coldop_ID
            // 
            this.coldop_ID.FieldName = "dop_ID";
            this.coldop_ID.Name = "coldop_ID";
            this.coldop_ID.OptionsColumn.AllowEdit = false;
            // 
            // coldop_limit
            // 
            this.coldop_limit.Caption = "Limit za narudžbu";
            this.coldop_limit.FieldName = "dop_limit";
            this.coldop_limit.Name = "coldop_limit";
            this.coldop_limit.Visible = true;
            this.coldop_limit.VisibleIndex = 2;
            this.coldop_limit.Width = 133;
            // 
            // colposlovnica_po_id
            // 
            this.colposlovnica_po_id.FieldName = "poslovnica_po_id";
            this.colposlovnica_po_id.Name = "colposlovnica_po_id";
            this.colposlovnica_po_id.OptionsColumn.AllowEdit = false;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Poslovnica";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.OptionsColumn.AllowEdit = false;
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 0;
            this.colpo_naziv.Width = 279;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater mijenjao";
            this.gridColumn1.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 243;
            // 
            // coldop_danisat
            // 
            this.coldop_danisat.Caption = "Datum izmjene";
            this.coldop_danisat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldop_danisat.FieldName = "dop_danisat";
            this.coldop_danisat.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldop_danisat.Name = "coldop_danisat";
            this.coldop_danisat.OptionsColumn.AllowEdit = false;
            this.coldop_danisat.Visible = true;
            this.coldop_danisat.VisibleIndex = 4;
            this.coldop_danisat.Width = 126;
            // 
            // colpo_asortiman
            // 
            this.colpo_asortiman.Caption = "Tip poslovnice";
            this.colpo_asortiman.FieldName = "po_asortiman";
            this.colpo_asortiman.Name = "colpo_asortiman";
            this.colpo_asortiman.OptionsColumn.AllowEdit = false;
            this.colpo_asortiman.Visible = true;
            this.colpo_asortiman.VisibleIndex = 1;
            this.colpo_asortiman.Width = 102;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // limitTableAdapter
            // 
            this.limitTableAdapter.ClearBeforeFill = true;
            // 
            // frmLimitNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 473);
            this.Controls.Add(this.dgLimit);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLimitNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limit narudžbe poslovnice prema dobavljaču";
            this.Load += new System.EventHandler(this.frmLimitNarudzbe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLimitNarudzbe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitTrgovinaZaPartnera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLimitTrgovine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraGrid.GridControl dgLimit;
        private DevExpress.XtraGrid.Views.Grid.GridView dgLimitTrgovine;
        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_naziv;
        private System.Windows.Forms.BindingSource limitBindingSource;
        private LimitTrgovinaZaPartnera limitTrgovinaZaPartnera;
        private LimitTrgovinaZaPartneraTableAdapters.limitTableAdapter limitTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldop_ID;
        private DevExpress.XtraGrid.Columns.GridColumn coldop_limit;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_po_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn coldop_danisat;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_asortiman;
    }
}