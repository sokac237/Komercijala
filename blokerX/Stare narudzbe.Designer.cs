namespace blokerX
{
    partial class frmStareNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStareNarudzbe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.operaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komercijalist = new blokerX.Komercijalist();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colop_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgNarudzbe = new DevExpress.XtraGrid.GridControl();
            this.potvrdjeneNarudzbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potvrdjeneNarudzbe = new blokerX.PotvrdjeneNarudzbe();
            this.dgNarudzbeZag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colna_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_vrsta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_broj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_po_idS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_po_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartner_PA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_datum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_vrijeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_ediObradjeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater_op_IDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_potvrdjeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colna_vrijemepotrvde1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkladiste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoslovnica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKomercijalist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraPoslovnice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifraSkladista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operaterTableAdapter = new blokerX.KomercijalistTableAdapters.operaterTableAdapter();
            this.potvrdjeneNarudzbeTableAdapter = new blokerX.PotvrdjeneNarudzbeTableAdapters.PotvrdjeneNarudzbeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potvrdjeneNarudzbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potvrdjeneNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpOd);
            this.panel1.Controls.Add(this.dtpDO);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 101);
            this.panel1.TabIndex = 0;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(85, 52);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(136, 20);
            this.dtpOd.TabIndex = 12;
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(255, 52);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(140, 20);
            this.dtpDO.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Od datuma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(438, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "F4 - stavke";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(434, 20);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(85, 22);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.operaterBindingSource;
            this.glDobavljac.Properties.DisplayMember = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.glDobavljac.Properties.ValueMember = "op_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(310, 20);
            this.glDobavljac.TabIndex = 5;
            // 
            // operaterBindingSource
            // 
            this.operaterBindingSource.DataMember = "operater";
            this.operaterBindingSource.DataSource = this.komercijalist;
            // 
            // komercijalist
            // 
            this.komercijalist.DataSetName = "Komercijalist";
            this.komercijalist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colop_ID});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ime prezime";
            this.gridColumn1.FieldName = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colop_ID
            // 
            this.colop_ID.FieldName = "op_ID";
            this.colop_ID.Name = "colop_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Komercijalist:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 78);
            this.panel2.TabIndex = 1;
            // 
            // dgNarudzbe
            // 
            this.dgNarudzbe.DataSource = this.potvrdjeneNarudzbeBindingSource;
            this.dgNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNarudzbe.Location = new System.Drawing.Point(0, 101);
            this.dgNarudzbe.MainView = this.dgNarudzbeZag;
            this.dgNarudzbe.Name = "dgNarudzbe";
            this.dgNarudzbe.Size = new System.Drawing.Size(1006, 371);
            this.dgNarudzbe.TabIndex = 21;
            this.dgNarudzbe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgNarudzbeZag});
            this.dgNarudzbe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgNarudzbe_KeyDown);
            // 
            // potvrdjeneNarudzbeBindingSource
            // 
            this.potvrdjeneNarudzbeBindingSource.DataMember = "PotvrdjeneNarudzbe";
            this.potvrdjeneNarudzbeBindingSource.DataSource = this.potvrdjeneNarudzbe;
            // 
            // potvrdjeneNarudzbe
            // 
            this.potvrdjeneNarudzbe.DataSetName = "PotvrdjeneNarudzbe";
            this.potvrdjeneNarudzbe.EnforceConstraints = false;
            this.potvrdjeneNarudzbe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgNarudzbeZag
            // 
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.Empty.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgNarudzbeZag.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgNarudzbeZag.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNarudzbeZag.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgNarudzbeZag.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseFont = true;
            this.dgNarudzbeZag.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNarudzbeZag.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgNarudzbeZag.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgNarudzbeZag.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNarudzbeZag.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNarudzbeZag.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.OddRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.OddRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgNarudzbeZag.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgNarudzbeZag.Appearance.Preview.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.Preview.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.Row.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.Row.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgNarudzbeZag.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgNarudzbeZag.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNarudzbeZag.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgNarudzbeZag.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgNarudzbeZag.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNarudzbeZag.Appearance.VertLine.Options.UseBackColor = true;
            this.dgNarudzbeZag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colna_ID,
            this.colna_vrsta,
            this.colna_broj,
            this.colposlovnica_po_idS,
            this.colposlovnica_po_id,
            this.colpartner_PA_ID,
            this.colna_datum1,
            this.colna_vrijeme,
            this.colna_ediObradjeno,
            this.coloperater_op_ID,
            this.coloperater_op_IDK,
            this.colna_potvrdjeno,
            this.colna_vrijemepotrvde1,
            this.colSkladiste,
            this.colPoslovnica,
            this.colKomercijalist,
            this.colOperater,
            this.colSifraPoslovnice,
            this.colSifraSkladista});
            this.dgNarudzbeZag.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgNarudzbeZag.GridControl = this.dgNarudzbe;
            this.dgNarudzbeZag.Name = "dgNarudzbeZag";
            this.dgNarudzbeZag.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgNarudzbeZag.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgNarudzbeZag.OptionsBehavior.Editable = false;
            this.dgNarudzbeZag.OptionsCustomization.AllowColumnMoving = false;
            this.dgNarudzbeZag.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgNarudzbeZag.OptionsView.EnableAppearanceEvenRow = true;
            this.dgNarudzbeZag.OptionsView.EnableAppearanceOddRow = true;
            this.dgNarudzbeZag.OptionsView.ShowAutoFilterRow = true;
            this.dgNarudzbeZag.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgNarudzbeZag.OptionsView.ShowGroupPanel = false;
            this.dgNarudzbeZag.OptionsView.ShowIndicator = false;
            this.dgNarudzbeZag.PaintStyleName = "WindowsXP";
            this.dgNarudzbeZag.SynchronizeClones = false;
            // 
            // colna_ID
            // 
            this.colna_ID.FieldName = "na_ID";
            this.colna_ID.Name = "colna_ID";
            // 
            // colna_vrsta
            // 
            this.colna_vrsta.FieldName = "na_vrsta";
            this.colna_vrsta.Name = "colna_vrsta";
            // 
            // colna_broj
            // 
            this.colna_broj.Caption = "Broj narudžbe";
            this.colna_broj.FieldName = "na_broj";
            this.colna_broj.Name = "colna_broj";
            this.colna_broj.Visible = true;
            this.colna_broj.VisibleIndex = 2;
            this.colna_broj.Width = 152;
            // 
            // colposlovnica_po_idS
            // 
            this.colposlovnica_po_idS.FieldName = "poslovnica_po_idS";
            this.colposlovnica_po_idS.Name = "colposlovnica_po_idS";
            // 
            // colposlovnica_po_id
            // 
            this.colposlovnica_po_id.FieldName = "poslovnica_po_id";
            this.colposlovnica_po_id.Name = "colposlovnica_po_id";
            // 
            // colpartner_PA_ID
            // 
            this.colpartner_PA_ID.FieldName = "partner_PA_ID";
            this.colpartner_PA_ID.Name = "colpartner_PA_ID";
            // 
            // colna_datum1
            // 
            this.colna_datum1.Caption = "Datum";
            this.colna_datum1.FieldName = "na_datum1";
            this.colna_datum1.Name = "colna_datum1";
            this.colna_datum1.Visible = true;
            this.colna_datum1.VisibleIndex = 3;
            this.colna_datum1.Width = 124;
            // 
            // colna_vrijeme
            // 
            this.colna_vrijeme.FieldName = "na_vrijeme";
            this.colna_vrijeme.Name = "colna_vrijeme";
            // 
            // colna_ediObradjeno
            // 
            this.colna_ediObradjeno.FieldName = "na_ediObradjeno";
            this.colna_ediObradjeno.Name = "colna_ediObradjeno";
            // 
            // coloperater_op_ID
            // 
            this.coloperater_op_ID.FieldName = "operater_op_ID";
            this.coloperater_op_ID.Name = "coloperater_op_ID";
            // 
            // coloperater_op_IDK
            // 
            this.coloperater_op_IDK.FieldName = "operater_op_IDK";
            this.coloperater_op_IDK.Name = "coloperater_op_IDK";
            // 
            // colna_potvrdjeno
            // 
            this.colna_potvrdjeno.Caption = "Potvrđeno";
            this.colna_potvrdjeno.FieldName = "na_potvrdjeno";
            this.colna_potvrdjeno.Name = "colna_potvrdjeno";
            this.colna_potvrdjeno.Visible = true;
            this.colna_potvrdjeno.VisibleIndex = 5;
            this.colna_potvrdjeno.Width = 134;
            // 
            // colna_vrijemepotrvde1
            // 
            this.colna_vrijemepotrvde1.Caption = "Vrijeme potvrde";
            this.colna_vrijemepotrvde1.FieldName = "na_vrijemepotrvde1";
            this.colna_vrijemepotrvde1.Name = "colna_vrijemepotrvde1";
            this.colna_vrijemepotrvde1.Visible = true;
            this.colna_vrijemepotrvde1.VisibleIndex = 6;
            this.colna_vrijemepotrvde1.Width = 172;
            // 
            // colSkladiste
            // 
            this.colSkladiste.Caption = "Naziv skladišta";
            this.colSkladiste.FieldName = "Skladiste";
            this.colSkladiste.Name = "colSkladiste";
            this.colSkladiste.Visible = true;
            this.colSkladiste.VisibleIndex = 1;
            this.colSkladiste.Width = 213;
            // 
            // colPoslovnica
            // 
            this.colPoslovnica.Caption = "Naziv poslovnice";
            this.colPoslovnica.FieldName = "Poslovnica";
            this.colPoslovnica.Name = "colPoslovnica";
            this.colPoslovnica.Visible = true;
            this.colPoslovnica.VisibleIndex = 9;
            this.colPoslovnica.Width = 285;
            // 
            // colKomercijalist
            // 
            this.colKomercijalist.Caption = "Komercijalist";
            this.colKomercijalist.FieldName = "Komercijalist";
            this.colKomercijalist.Name = "colKomercijalist";
            this.colKomercijalist.Visible = true;
            this.colKomercijalist.VisibleIndex = 4;
            this.colKomercijalist.Width = 180;
            // 
            // colOperater
            // 
            this.colOperater.Caption = "Operater";
            this.colOperater.FieldName = "Operater";
            this.colOperater.Name = "colOperater";
            this.colOperater.Visible = true;
            this.colOperater.VisibleIndex = 7;
            this.colOperater.Width = 178;
            // 
            // colSifraPoslovnice
            // 
            this.colSifraPoslovnice.Caption = "Šifra poslovnice";
            this.colSifraPoslovnice.FieldName = "SifraPoslovnice";
            this.colSifraPoslovnice.Name = "colSifraPoslovnice";
            this.colSifraPoslovnice.Visible = true;
            this.colSifraPoslovnice.VisibleIndex = 8;
            this.colSifraPoslovnice.Width = 156;
            // 
            // colSifraSkladista
            // 
            this.colSifraSkladista.Caption = "Šifra skladišta";
            this.colSifraSkladista.FieldName = "SifraSkladista";
            this.colSifraSkladista.Name = "colSifraSkladista";
            this.colSifraSkladista.Visible = true;
            this.colSifraSkladista.VisibleIndex = 0;
            this.colSifraSkladista.Width = 155;
            // 
            // operaterTableAdapter
            // 
            this.operaterTableAdapter.ClearBeforeFill = true;
            // 
            // potvrdjeneNarudzbeTableAdapter
            // 
            this.potvrdjeneNarudzbeTableAdapter.ClearBeforeFill = true;
            // 
            // frmStareNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 550);
            this.Controls.Add(this.dgNarudzbe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmStareNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stare narudžbe";
            this.Load += new System.EventHandler(this.frmStareNarudzbe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStareNarudzbe_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komercijalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potvrdjeneNarudzbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potvrdjeneNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colop_ID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgNarudzbe;
        private DevExpress.XtraGrid.Views.Grid.GridView dgNarudzbeZag;
        private Komercijalist komercijalist;
        private System.Windows.Forms.BindingSource operaterBindingSource;
        private KomercijalistTableAdapters.operaterTableAdapter operaterTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource potvrdjeneNarudzbeBindingSource;
        private PotvrdjeneNarudzbe potvrdjeneNarudzbe;
        private DevExpress.XtraGrid.Columns.GridColumn colna_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colna_vrsta;
        private DevExpress.XtraGrid.Columns.GridColumn colna_broj;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_po_idS;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_po_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpartner_PA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colna_vrijeme;
        private DevExpress.XtraGrid.Columns.GridColumn colna_ediObradjeno;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_ID;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater_op_IDK;
        private DevExpress.XtraGrid.Columns.GridColumn colna_potvrdjeno;
        private DevExpress.XtraGrid.Columns.GridColumn colSkladiste;
        private DevExpress.XtraGrid.Columns.GridColumn colPoslovnica;
        private DevExpress.XtraGrid.Columns.GridColumn colKomercijalist;
        private DevExpress.XtraGrid.Columns.GridColumn colOperater;
        private PotvrdjeneNarudzbeTableAdapters.PotvrdjeneNarudzbeTableAdapter potvrdjeneNarudzbeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraPoslovnice;
        private DevExpress.XtraGrid.Columns.GridColumn colSifraSkladista;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private DevExpress.XtraGrid.Columns.GridColumn colna_datum1;
        private DevExpress.XtraGrid.Columns.GridColumn colna_vrijemepotrvde1;
    }
}