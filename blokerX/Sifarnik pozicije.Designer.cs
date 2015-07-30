namespace blokerX
{
    partial class frmVrstePozicije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVrstePozicije));
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.vrstapozicijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstePozicija = new blokerX.VrstePozicija();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvp_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvp_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vrstapozicijeTableAdapter = new blokerX.VrstePozicijaTableAdapters.vrstapozicijeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstapozicijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstePozicija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.vrstapozicijeBindingSource;
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView5;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(261, 317);
            this.gridControl4.TabIndex = 20;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridControl4.DoubleClick += new System.EventHandler(this.gridControl4_DoubleClick);
            // 
            // vrstapozicijeBindingSource
            // 
            this.vrstapozicijeBindingSource.DataMember = "vrstapozicije";
            this.vrstapozicijeBindingSource.DataSource = this.vrstePozicija;
            // 
            // vrstePozicija
            // 
            this.vrstePozicija.DataSetName = "VrstePozicija";
            this.vrstePozicija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView5
            // 
            this.gridView5.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView5.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView5.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView5.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView5.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.Empty.Options.UseBackColor = true;
            this.gridView5.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView5.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView5.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView5.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView5.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView5.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView5.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView5.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView5.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView5.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView5.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView5.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView5.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView5.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupRow.Options.UseFont = true;
            this.gridView5.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView5.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView5.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView5.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView5.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView5.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView5.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView5.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView5.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView5.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView5.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView5.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView5.Appearance.Preview.Options.UseBackColor = true;
            this.gridView5.Appearance.Preview.Options.UseForeColor = true;
            this.gridView5.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.Row.Options.UseBackColor = true;
            this.gridView5.Appearance.Row.Options.UseForeColor = true;
            this.gridView5.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView5.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView5.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView5.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView5.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView5.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvp_id,
            this.colvp_naziv});
            this.gridView5.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.gridView5.GridControl = this.gridControl4;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView5.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsSelection.MultiSelect = true;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.EnableAppearanceOddRow = true;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.PaintStyleName = "WindowsXP";
            this.gridView5.SynchronizeClones = false;
            // 
            // colvp_id
            // 
            this.colvp_id.FieldName = "vp_id";
            this.colvp_id.Name = "colvp_id";
            // 
            // colvp_naziv
            // 
            this.colvp_naziv.Caption = "Naziv pozicije";
            this.colvp_naziv.FieldName = "vp_naziv";
            this.colvp_naziv.Name = "colvp_naziv";
            this.colvp_naziv.Visible = true;
            this.colvp_naziv.VisibleIndex = 0;
            this.colvp_naziv.Width = 246;
            // 
            // vrstapozicijeTableAdapter
            // 
            this.vrstapozicijeTableAdapter.ClearBeforeFill = true;
            // 
            // frmVrstePozicije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 317);
            this.Controls.Add(this.gridControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVrstePozicije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrste pozicije";
            this.Load += new System.EventHandler(this.Sifarnik_pozicije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstapozicijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstePozicija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private VrstePozicija vrstePozicija;
        private System.Windows.Forms.BindingSource vrstapozicijeBindingSource;
        private VrstePozicijaTableAdapters.vrstapozicijeTableAdapter vrstapozicijeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_id;
        private DevExpress.XtraGrid.Columns.GridColumn colvp_naziv;
    }
}