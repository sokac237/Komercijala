namespace blokerX
{
    partial class frmPregledGratisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledGratisa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrebaciUExcel = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgGratis = new DevExpress.XtraGrid.GridControl();
            this.pregledGratisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_gratisa = new blokerX.Pregled_gratisa();
            this.gratis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgr_zavrsen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_PO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartneri_PA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_zapisnik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_odobrenje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_vrsta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_kolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_nabavnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_nabavnavrijednost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_prodajnacijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_prodajnavrijednost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colufaifa_uf_broj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_vrijemeIzmjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colakc_broj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgr_vrijednostsnizenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pregledGratisTableAdapter = new blokerX.Pregled_gratisaTableAdapters.PregledGratisTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGratis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledGratisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_gratisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUpozorenje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPrebaciUExcel);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.dtpDO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpOD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 98);
            this.panel1.TabIndex = 0;
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.AutoSize = true;
            this.lblUpozorenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenje.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenje.Location = new System.Drawing.Point(45, 65);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Size = new System.Drawing.Size(0, 17);
            this.lblUpozorenje.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "F5 - total po poslovnicama";
            // 
            // btnPrebaciUExcel
            // 
            this.btnPrebaciUExcel.Location = new System.Drawing.Point(575, 28);
            this.btnPrebaciUExcel.Name = "btnPrebaciUExcel";
            this.btnPrebaciUExcel.Size = new System.Drawing.Size(100, 22);
            this.btnPrebaciUExcel.TabIndex = 5;
            this.btnPrebaciUExcel.Text = "Prebaci u excel";
            this.btnPrebaciUExcel.UseVisualStyleBackColor = true;
            this.btnPrebaciUExcel.Click += new System.EventHandler(this.btnPrebaciUExcel_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(480, 28);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(317, 31);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(128, 20);
            this.dtpDO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "do:";
            // 
            // dtpOD
            // 
            this.dtpOD.Location = new System.Drawing.Point(129, 32);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(128, 20);
            this.dtpOD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Za razdoblje od:";
            // 
            // dgGratis
            // 
            this.dgGratis.DataSource = this.pregledGratisBindingSource;
            this.dgGratis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGratis.Location = new System.Drawing.Point(0, 98);
            this.dgGratis.MainView = this.gratis;
            this.dgGratis.Name = "dgGratis";
            this.dgGratis.Size = new System.Drawing.Size(1013, 427);
            this.dgGratis.TabIndex = 12;
            this.dgGratis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gratis});
            // 
            // pregledGratisBindingSource
            // 
            this.pregledGratisBindingSource.DataMember = "PregledGratis";
            this.pregledGratisBindingSource.DataSource = this.pregled_gratisa;
            // 
            // pregled_gratisa
            // 
            this.pregled_gratisa.DataSetName = "Pregled_gratisa";
            this.pregled_gratisa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gratis
            // 
            this.gratis.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gratis.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gratis.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gratis.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gratis.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gratis.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gratis.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.Empty.Options.UseBackColor = true;
            this.gratis.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.EvenRow.Options.UseBackColor = true;
            this.gratis.Appearance.EvenRow.Options.UseForeColor = true;
            this.gratis.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gratis.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gratis.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gratis.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gratis.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gratis.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gratis.Appearance.FixedLine.Options.UseBackColor = true;
            this.gratis.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gratis.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gratis.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gratis.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gratis.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupButton.Options.UseBackColor = true;
            this.gratis.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupButton.Options.UseForeColor = true;
            this.gratis.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gratis.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gratis.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gratis.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gratis.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gratis.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gratis.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.GroupRow.Options.UseBackColor = true;
            this.gratis.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gratis.Appearance.GroupRow.Options.UseFont = true;
            this.gratis.Appearance.GroupRow.Options.UseForeColor = true;
            this.gratis.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gratis.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gratis.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gratis.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gratis.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gratis.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gratis.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gratis.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gratis.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gratis.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gratis.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gratis.Appearance.HorzLine.Options.UseBackColor = true;
            this.gratis.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.OddRow.Options.UseBackColor = true;
            this.gratis.Appearance.OddRow.Options.UseForeColor = true;
            this.gratis.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gratis.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gratis.Appearance.Preview.Options.UseBackColor = true;
            this.gratis.Appearance.Preview.Options.UseForeColor = true;
            this.gratis.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.Row.Options.UseBackColor = true;
            this.gratis.Appearance.Row.Options.UseForeColor = true;
            this.gratis.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gratis.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gratis.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gratis.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gratis.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gratis.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gratis.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gratis.Appearance.VertLine.Options.UseBackColor = true;
            this.gratis.ColumnPanelRowHeight = 50;
            this.gratis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgr_zavrsen,
            this.colposlovnica_PO_ID,
            this.colpo_naziv,
            this.colpartneri_PA_ID,
            this.colPA_NAZIV,
            this.colgr_datum,
            this.colgr_zapisnik,
            this.colgr_odobrenje,
            this.coloperater_op_ID,
            this.colgr_vrsta,
            this.colAR_NAZIV,
            this.colgr_kolicina,
            this.colgr_nabavnacijena,
            this.colgr_nabavnavrijednost,
            this.colgr_prodajnacijena,
            this.colgr_prodajnavrijednost,
            this.colufaifa_uf_broj,
            this.colgr_napomena,
            this.colgr_vrijemeIzmjene,
            this.gridColumn1,
            this.colakc_broj,
            this.colgr_vrijednostsnizenja});
            this.gratis.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gratis.GridControl = this.dgGratis;
            this.gratis.Name = "gratis";
            this.gratis.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gratis.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gratis.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gratis.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gratis.OptionsBehavior.Editable = false;
            this.gratis.OptionsCustomization.AllowColumnMoving = false;
            this.gratis.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gratis.OptionsSelection.MultiSelect = true;
            this.gratis.OptionsView.ColumnAutoWidth = false;
            this.gratis.OptionsView.EnableAppearanceEvenRow = true;
            this.gratis.OptionsView.EnableAppearanceOddRow = true;
            this.gratis.OptionsView.ShowAutoFilterRow = true;
            this.gratis.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gratis.OptionsView.ShowFooter = true;
            this.gratis.OptionsView.ShowGroupPanel = false;
            this.gratis.OptionsView.ShowIndicator = false;
            this.gratis.PaintStyleName = "WindowsXP";
            this.gratis.SynchronizeClones = false;
            // 
            // colgr_zavrsen
            // 
            this.colgr_zavrsen.Caption = "Završen";
            this.colgr_zavrsen.FieldName = "gr_zavrsen";
            this.colgr_zavrsen.Name = "colgr_zavrsen";
            this.colgr_zavrsen.Visible = true;
            this.colgr_zavrsen.VisibleIndex = 0;
            this.colgr_zavrsen.Width = 63;
            // 
            // colposlovnica_PO_ID
            // 
            this.colposlovnica_PO_ID.FieldName = "poslovnica_PO_ID";
            this.colposlovnica_PO_ID.Name = "colposlovnica_PO_ID";
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Trg/sklad";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 1;
            this.colpo_naziv.Width = 138;
            // 
            // colpartneri_PA_ID
            // 
            this.colpartneri_PA_ID.FieldName = "partneri_PA_ID";
            this.colpartneri_PA_ID.Name = "colpartneri_PA_ID";
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Partner";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 2;
            this.colPA_NAZIV.Width = 151;
            // 
            // colgr_datum
            // 
            this.colgr_datum.Caption = "Datum";
            this.colgr_datum.FieldName = "gr_datum";
            this.colgr_datum.Name = "colgr_datum";
            this.colgr_datum.Visible = true;
            this.colgr_datum.VisibleIndex = 3;
            // 
            // colgr_zapisnik
            // 
            this.colgr_zapisnik.Caption = "Zapisnik";
            this.colgr_zapisnik.FieldName = "gr_zapisnik";
            this.colgr_zapisnik.Name = "colgr_zapisnik";
            this.colgr_zapisnik.Visible = true;
            this.colgr_zapisnik.VisibleIndex = 4;
            this.colgr_zapisnik.Width = 104;
            // 
            // colgr_odobrenje
            // 
            this.colgr_odobrenje.Caption = "Odobrenje";
            this.colgr_odobrenje.FieldName = "gr_odobrenje";
            this.colgr_odobrenje.Name = "colgr_odobrenje";
            this.colgr_odobrenje.Visible = true;
            this.colgr_odobrenje.VisibleIndex = 5;
            this.colgr_odobrenje.Width = 98;
            // 
            // coloperater_op_ID
            // 
            this.coloperater_op_ID.Caption = "Osoba";
            this.coloperater_op_ID.FieldName = "operater_op_ID";
            this.coloperater_op_ID.Name = "coloperater_op_ID";
            this.coloperater_op_ID.Visible = true;
            this.coloperater_op_ID.VisibleIndex = 6;
            this.coloperater_op_ID.Width = 159;
            // 
            // colgr_vrsta
            // 
            this.colgr_vrsta.Caption = "Vrsta";
            this.colgr_vrsta.FieldName = "gr_vrsta";
            this.colgr_vrsta.Name = "colgr_vrsta";
            this.colgr_vrsta.Visible = true;
            this.colgr_vrsta.VisibleIndex = 7;
            this.colgr_vrsta.Width = 49;
            // 
            // colAR_NAZIV
            // 
            this.colAR_NAZIV.Caption = "Artikl";
            this.colAR_NAZIV.FieldName = "AR_NAZIV";
            this.colAR_NAZIV.Name = "colAR_NAZIV";
            this.colAR_NAZIV.Visible = true;
            this.colAR_NAZIV.VisibleIndex = 8;
            this.colAR_NAZIV.Width = 191;
            // 
            // colgr_kolicina
            // 
            this.colgr_kolicina.Caption = "Količina";
            this.colgr_kolicina.FieldName = "gr_kolicina";
            this.colgr_kolicina.Name = "colgr_kolicina";
            this.colgr_kolicina.Visible = true;
            this.colgr_kolicina.VisibleIndex = 9;
            this.colgr_kolicina.Width = 89;
            // 
            // colgr_nabavnacijena
            // 
            this.colgr_nabavnacijena.Caption = "Nab. cijena";
            this.colgr_nabavnacijena.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgr_nabavnacijena.FieldName = "gr_nabavnacijena";
            this.colgr_nabavnacijena.Name = "colgr_nabavnacijena";
            this.colgr_nabavnacijena.Visible = true;
            this.colgr_nabavnacijena.VisibleIndex = 10;
            this.colgr_nabavnacijena.Width = 86;
            // 
            // colgr_nabavnavrijednost
            // 
            this.colgr_nabavnavrijednost.Caption = "Nab. vrijednost";
            this.colgr_nabavnavrijednost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgr_nabavnavrijednost.FieldName = "gr_nabavnavrijednost";
            this.colgr_nabavnavrijednost.Name = "colgr_nabavnavrijednost";
            this.colgr_nabavnavrijednost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colgr_nabavnavrijednost.Visible = true;
            this.colgr_nabavnavrijednost.VisibleIndex = 11;
            this.colgr_nabavnavrijednost.Width = 89;
            // 
            // colgr_prodajnacijena
            // 
            this.colgr_prodajnacijena.Caption = "Prod. cijena";
            this.colgr_prodajnacijena.FieldName = "gr_prodajnacijena";
            this.colgr_prodajnacijena.Name = "colgr_prodajnacijena";
            this.colgr_prodajnacijena.Visible = true;
            this.colgr_prodajnacijena.VisibleIndex = 12;
            this.colgr_prodajnacijena.Width = 82;
            // 
            // colgr_prodajnavrijednost
            // 
            this.colgr_prodajnavrijednost.Caption = "Prod. vrijednost";
            this.colgr_prodajnavrijednost.FieldName = "gr_prodajnavrijednost";
            this.colgr_prodajnavrijednost.Name = "colgr_prodajnavrijednost";
            this.colgr_prodajnavrijednost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colgr_prodajnavrijednost.Visible = true;
            this.colgr_prodajnavrijednost.VisibleIndex = 13;
            this.colgr_prodajnavrijednost.Width = 82;
            // 
            // colufaifa_uf_broj
            // 
            this.colufaifa_uf_broj.Caption = "Kalkulacija";
            this.colufaifa_uf_broj.FieldName = "ufaifa_uf_broj";
            this.colufaifa_uf_broj.Name = "colufaifa_uf_broj";
            this.colufaifa_uf_broj.Visible = true;
            this.colufaifa_uf_broj.VisibleIndex = 14;
            this.colufaifa_uf_broj.Width = 95;
            // 
            // colgr_napomena
            // 
            this.colgr_napomena.Caption = "Napomena";
            this.colgr_napomena.FieldName = "gr_napomena";
            this.colgr_napomena.Name = "colgr_napomena";
            this.colgr_napomena.Visible = true;
            this.colgr_napomena.VisibleIndex = 15;
            this.colgr_napomena.Width = 183;
            // 
            // colgr_vrijemeIzmjene
            // 
            this.colgr_vrijemeIzmjene.Caption = "Vrijeme izmjene";
            this.colgr_vrijemeIzmjene.FieldName = "gr_vrijemeIzmjene";
            this.colgr_vrijemeIzmjene.Name = "colgr_vrijemeIzmjene";
            this.colgr_vrijemeIzmjene.Visible = true;
            this.colgr_vrijemeIzmjene.VisibleIndex = 17;
            this.colgr_vrijemeIzmjene.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater izmijenio ";
            this.gridColumn1.FieldName = "concat(operater_op_ime, \' \' , operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 16;
            this.gridColumn1.Width = 107;
            // 
            // colakc_broj
            // 
            this.colakc_broj.Caption = "Broj akcije";
            this.colakc_broj.FieldName = "akc_broj";
            this.colakc_broj.Name = "colakc_broj";
            this.colakc_broj.Visible = true;
            this.colakc_broj.VisibleIndex = 18;
            // 
            // colgr_vrijednostsnizenja
            // 
            this.colgr_vrijednostsnizenja.Caption = "Vrijednost sniženja";
            this.colgr_vrijednostsnizenja.FieldName = "gr_vrijednostsnizenja";
            this.colgr_vrijednostsnizenja.Name = "colgr_vrijednostsnizenja";
            this.colgr_vrijednostsnizenja.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colgr_vrijednostsnizenja.Visible = true;
            this.colgr_vrijednostsnizenja.VisibleIndex = 19;
            // 
            // pregledGratisTableAdapter
            // 
            this.pregledGratisTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledGratisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 525);
            this.Controls.Add(this.dgGratis);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledGratisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled gratisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledGratisa_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGratis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledGratisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_gratisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gratis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl dgGratis;
        private DevExpress.XtraGrid.Views.Grid.GridView gratis;
        private Pregled_gratisa pregled_gratisa;
        private System.Windows.Forms.BindingSource pregledGratisBindingSource;
        private Pregled_gratisaTableAdapters.PregledGratisTableAdapter pregledGratisTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrebaciUExcel;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_zavrsen;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_PO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpartneri_PA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_datum;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_zapisnik;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_odobrenje;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_vrsta;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_kolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_nabavnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_nabavnavrijednost;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_prodajnacijena;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_prodajnavrijednost;
        private DevExpress.XtraGrid.Columns.GridColumn colufaifa_uf_broj;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_napomena;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_vrijemeIzmjene;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_broj;
        private DevExpress.XtraGrid.Columns.GridColumn colgr_vrijednostsnizenja;
        private System.Windows.Forms.Label lblUpozorenje;
    }
}