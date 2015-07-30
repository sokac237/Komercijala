namespace blokerX
{
    partial class frmPregledNarudzbiSaSkladista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNarudzbiSaSkladista));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPonistiPonudu = new System.Windows.Forms.Button();
            this.dgNarudzbe = new DevExpress.XtraGrid.GridControl();
            this.dgNarudzbeZag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glDobavljac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "F4 pregled stavki";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(451, 28);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(113, 30);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "CONCAT(operater_op_ime,\' \' ,operater_op_prezime)";
            this.glDobavljac.Properties.ValueMember = "op_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(310, 20);
            this.glDobavljac.TabIndex = 6;
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
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
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
            this.colPA_SIFRA.Width = 229;
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Naziv";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 837;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPonistiPonudu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 75);
            this.panel2.TabIndex = 1;
            // 
            // btnPonistiPonudu
            // 
            this.btnPonistiPonudu.Location = new System.Drawing.Point(52, 24);
            this.btnPonistiPonudu.Name = "btnPonistiPonudu";
            this.btnPonistiPonudu.Size = new System.Drawing.Size(102, 23);
            this.btnPonistiPonudu.TabIndex = 0;
            this.btnPonistiPonudu.Text = "Poništi narudžbu";
            this.btnPonistiPonudu.UseVisualStyleBackColor = true;
            // 
            // dgNarudzbe
            // 
            this.dgNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNarudzbe.Location = new System.Drawing.Point(0, 100);
            this.dgNarudzbe.MainView = this.dgNarudzbeZag;
            this.dgNarudzbe.Name = "dgNarudzbe";
            this.dgNarudzbe.Size = new System.Drawing.Size(994, 383);
            this.dgNarudzbe.TabIndex = 22;
            this.dgNarudzbe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgNarudzbeZag});
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
            this.dgNarudzbeZag.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgNarudzbeZag.GridControl = this.dgNarudzbe;
            this.dgNarudzbeZag.Name = "dgNarudzbeZag";
            this.dgNarudzbeZag.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNarudzbeZag.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgNarudzbeZag.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgNarudzbeZag.OptionsBehavior.Editable = false;
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
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledNarudzbiSaSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 558);
            this.Controls.Add(this.dgNarudzbe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregledNarudzbiSaSkladista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled narudžbi od odbavljača sa skladišta Vinkovci i Vukovar";
            this.Load += new System.EventHandler(this.Pregled_narudzbi_sa_skladista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbeZag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgNarudzbe;
        private DevExpress.XtraGrid.Views.Grid.GridView dgNarudzbeZag;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Button btnPrikazi;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Button btnPonistiPonudu;
    }
}