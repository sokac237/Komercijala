namespace blokerX
{
    partial class frmSifreArtikalaKodDobavljaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreArtikalaKodDobavljaca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSifreKodDobavljaca = new DevExpress.XtraGrid.GridControl();
            this.sifreKodDobavljacaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sifraArtiklaKodDobavljaca = new blokerX.SifraArtiklaKodDobavljaca();
            this.dgSifreDobavljac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldoa_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoa_sifraKodDobavljaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colartikl_ar_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.sifreKodDobavljacaTableAdapter = new blokerX.SifraArtiklaKodDobavljacaTableAdapters.SifreKodDobavljacaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDArtikl = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtSifraArtikla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSifraKodDobavljaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifreKodDobavljaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreKodDobavljacaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifraArtiklaKodDobavljaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifreDobavljac)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 84);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "F7 - dodaj ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F4 - izmjena";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(442, 29);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.txtPrikazi_Click);
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(102, 31);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(300, 20);
            this.glDobavljac.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // dgSifreKodDobavljaca
            // 
            this.dgSifreKodDobavljaca.DataSource = this.sifreKodDobavljacaBindingSource;
            this.dgSifreKodDobavljaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSifreKodDobavljaca.Location = new System.Drawing.Point(0, 84);
            this.dgSifreKodDobavljaca.MainView = this.dgSifreDobavljac;
            this.dgSifreKodDobavljaca.Name = "dgSifreKodDobavljaca";
            this.dgSifreKodDobavljaca.Size = new System.Drawing.Size(905, 517);
            this.dgSifreKodDobavljaca.TabIndex = 20;
            this.dgSifreKodDobavljaca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgSifreDobavljac});
            this.dgSifreKodDobavljaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSifreKodDobavljaca_KeyDown);
            // 
            // sifreKodDobavljacaBindingSource
            // 
            this.sifreKodDobavljacaBindingSource.DataMember = "SifreKodDobavljaca";
            this.sifreKodDobavljacaBindingSource.DataSource = this.sifraArtiklaKodDobavljaca;
            // 
            // sifraArtiklaKodDobavljaca
            // 
            this.sifraArtiklaKodDobavljaca.DataSetName = "SifraArtiklaKodDobavljaca";
            this.sifraArtiklaKodDobavljaca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgSifreDobavljac
            // 
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.Empty.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSifreDobavljac.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSifreDobavljac.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSifreDobavljac.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgSifreDobavljac.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgSifreDobavljac.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSifreDobavljac.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSifreDobavljac.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSifreDobavljac.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSifreDobavljac.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgSifreDobavljac.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.GroupRow.Options.UseFont = true;
            this.dgSifreDobavljac.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSifreDobavljac.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSifreDobavljac.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSifreDobavljac.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgSifreDobavljac.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgSifreDobavljac.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSifreDobavljac.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSifreDobavljac.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.OddRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.OddRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgSifreDobavljac.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgSifreDobavljac.Appearance.Preview.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.Preview.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.Row.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.Row.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgSifreDobavljac.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgSifreDobavljac.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSifreDobavljac.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgSifreDobavljac.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgSifreDobavljac.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSifreDobavljac.Appearance.VertLine.Options.UseBackColor = true;
            this.dgSifreDobavljac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldoa_ID,
            this.colAR_SIFRA,
            this.colAR_NAZIV,
            this.coldoa_sifraKodDobavljaca,
            this.colartikl_ar_ID});
            this.dgSifreDobavljac.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgSifreDobavljac.GridControl = this.dgSifreKodDobavljaca;
            this.dgSifreDobavljac.Name = "dgSifreDobavljac";
            this.dgSifreDobavljac.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSifreDobavljac.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSifreDobavljac.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgSifreDobavljac.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgSifreDobavljac.OptionsBehavior.Editable = false;
            this.dgSifreDobavljac.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgSifreDobavljac.OptionsSelection.MultiSelect = true;
            this.dgSifreDobavljac.OptionsView.ColumnAutoWidth = false;
            this.dgSifreDobavljac.OptionsView.EnableAppearanceEvenRow = true;
            this.dgSifreDobavljac.OptionsView.EnableAppearanceOddRow = true;
            this.dgSifreDobavljac.OptionsView.ShowAutoFilterRow = true;
            this.dgSifreDobavljac.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgSifreDobavljac.OptionsView.ShowGroupPanel = false;
            this.dgSifreDobavljac.OptionsView.ShowIndicator = false;
            this.dgSifreDobavljac.PaintStyleName = "WindowsXP";
            this.dgSifreDobavljac.SynchronizeClones = false;
            // 
            // coldoa_ID
            // 
            this.coldoa_ID.FieldName = "doa_ID";
            this.coldoa_ID.Name = "coldoa_ID";
            // 
            // colAR_SIFRA
            // 
            this.colAR_SIFRA.Caption = "Šifra artikla";
            this.colAR_SIFRA.FieldName = "AR_SIFRA";
            this.colAR_SIFRA.Name = "colAR_SIFRA";
            this.colAR_SIFRA.Visible = true;
            this.colAR_SIFRA.VisibleIndex = 0;
            this.colAR_SIFRA.Width = 108;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Naziv artikla";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 1;
            this.colAR_NAZIV.Width = 339;
            // 
            // coldoa_sifraKodDobavljaca
            // 
            this.coldoa_sifraKodDobavljaca.Caption = "Šifra artikla kod dobavljača";
            this.coldoa_sifraKodDobavljaca.FieldName = "doa_sifraKodDobavljaca";
            this.coldoa_sifraKodDobavljaca.Name = "coldoa_sifraKodDobavljaca";
            this.coldoa_sifraKodDobavljaca.Visible = true;
            this.coldoa_sifraKodDobavljaca.VisibleIndex = 2;
            this.coldoa_sifraKodDobavljaca.Width = 183;
            // 
            // colartikl_ar_ID
            // 
            this.colartikl_ar_ID.FieldName = "artikl_ar_ID";
            this.colartikl_ar_ID.Name = "colartikl_ar_ID";
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // sifreKodDobavljacaTableAdapter
            // 
            this.sifreKodDobavljacaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIDArtikl);
            this.panel2.Controls.Add(this.lblNaziv);
            this.panel2.Controls.Add(this.txtSifraArtikla);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Controls.Add(this.txtSifraKodDobavljaca);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 227);
            this.panel2.TabIndex = 21;
            // 
            // txtIDArtikl
            // 
            this.txtIDArtikl.Location = new System.Drawing.Point(375, 28);
            this.txtIDArtikl.Name = "txtIDArtikl";
            this.txtIDArtikl.Size = new System.Drawing.Size(100, 20);
            this.txtIDArtikl.TabIndex = 9;
            this.txtIDArtikl.Visible = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(136, 62);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "___";
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Location = new System.Drawing.Point(138, 28);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(215, 20);
            this.txtSifraArtikla.TabIndex = 5;
            this.txtSifraArtikla.TextChanged += new System.EventHandler(this.txtSifraArtikla_TextChanged);
            this.txtSifraArtikla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifraArtikla_KeyDown);
            this.txtSifraArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifraArtikla_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Šifra artikla:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(278, 139);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(197, 139);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Spremi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSifraKodDobavljaca
            // 
            this.txtSifraKodDobavljaca.Location = new System.Drawing.Point(138, 100);
            this.txtSifraKodDobavljaca.Name = "txtSifraKodDobavljaca";
            this.txtSifraKodDobavljaca.Size = new System.Drawing.Size(215, 20);
            this.txtSifraKodDobavljaca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Šifra kod dobavljača:";
            // 
            // frmSifreArtikalaKodDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgSifreKodDobavljaca);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSifreArtikalaKodDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Šifre artikala kod dobavljača";
            this.Load += new System.EventHandler(this.frmSifreArtikalaKodDobavljaca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSifreArtikalaKodDobavljaca_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifreKodDobavljaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreKodDobavljacaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifraArtiklaKodDobavljaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifreDobavljac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgSifreKodDobavljaca;
        private DevExpress.XtraGrid.Views.Grid.GridView dgSifreDobavljac;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.BindingSource sifreKodDobavljacaBindingSource;
        private SifraArtiklaKodDobavljaca sifraArtiklaKodDobavljaca;
        private DevExpress.XtraGrid.Columns.GridColumn coldoa_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn coldoa_sifraKodDobavljaca;
        private SifraArtiklaKodDobavljacaTableAdapters.SifreKodDobavljacaTableAdapter sifreKodDobavljacaTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtSifraArtikla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSifraKodDobavljaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDArtikl;
        private DevExpress.XtraGrid.Columns.GridColumn colartikl_ar_ID;
    }
}