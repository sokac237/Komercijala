namespace blokerX
{
    partial class frmSnizenjaObracun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnizenjaObracun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreracunaj = new System.Windows.Forms.Button();
            this.dgSnizenjaObracun = new DevExpress.XtraGrid.GridControl();
            this.snizenjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregled_akcija = new blokerX.Pregled_akcija();
            this.dgSnizenja = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colakc_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_BROJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_DATUMOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_DATUMDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_OPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_AKTIVNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_POPUST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKC_VRIJEDNOSTSNIZENJA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colakc_datumizmjene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.snizenjaTableAdapter = new blokerX.Pregled_akcijaTableAdapters.snizenjaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizenjaObracun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPreracunaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "F5 - ispis";
            // 
            // btnPreracunaj
            // 
            this.btnPreracunaj.Location = new System.Drawing.Point(30, 22);
            this.btnPreracunaj.Name = "btnPreracunaj";
            this.btnPreracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnPreracunaj.TabIndex = 2;
            this.btnPreracunaj.Text = "Obračunaj";
            this.btnPreracunaj.UseVisualStyleBackColor = true;
            this.btnPreracunaj.Click += new System.EventHandler(this.btnPreracunaj_Click);
            // 
            // dgSnizenjaObracun
            // 
            this.dgSnizenjaObracun.DataSource = this.snizenjaBindingSource;
            this.dgSnizenjaObracun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSnizenjaObracun.Location = new System.Drawing.Point(0, 64);
            this.dgSnizenjaObracun.MainView = this.dgSnizenja;
            this.dgSnizenjaObracun.Name = "dgSnizenjaObracun";
            this.dgSnizenjaObracun.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.dgSnizenjaObracun.Size = new System.Drawing.Size(763, 481);
            this.dgSnizenjaObracun.TabIndex = 15;
            this.dgSnizenjaObracun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgSnizenja,
            this.gridView1});
            this.dgSnizenjaObracun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSnizenjaObracun_KeyDown);
            // 
            // snizenjaBindingSource
            // 
            this.snizenjaBindingSource.DataMember = "snizenja";
            this.snizenjaBindingSource.DataSource = this.pregled_akcija;
            // 
            // pregled_akcija
            // 
            this.pregled_akcija.DataSetName = "Pregled_akcija";
            this.pregled_akcija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgSnizenja
            // 
            this.dgSnizenja.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizenja.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizenja.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.Empty.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizenja.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizenja.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizenja.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgSnizenja.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgSnizenja.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizenja.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizenja.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizenja.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSnizenja.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgSnizenja.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.GroupRow.Options.UseFont = true;
            this.dgSnizenja.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgSnizenja.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgSnizenja.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgSnizenja.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgSnizenja.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgSnizenja.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgSnizenja.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizenja.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.OddRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.OddRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgSnizenja.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgSnizenja.Appearance.Preview.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.Preview.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.Row.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.Row.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgSnizenja.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgSnizenja.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgSnizenja.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgSnizenja.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgSnizenja.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgSnizenja.Appearance.VertLine.Options.UseBackColor = true;
            this.dgSnizenja.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colakc_ID,
            this.colAKC_BROJ,
            this.colAKC_DATUMOD,
            this.colAKC_DATUMDO,
            this.colAKC_OPIS,
            this.colAKC_AKTIVNA,
            this.colAKC_POPUST,
            this.colAKC_VRIJEDNOSTSNIZENJA,
            this.coloperater,
            this.colakc_datumizmjene});
            this.dgSnizenja.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgSnizenja.GridControl = this.dgSnizenjaObracun;
            this.dgSnizenja.Name = "dgSnizenja";
            this.dgSnizenja.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizenja.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgSnizenja.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgSnizenja.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgSnizenja.OptionsBehavior.Editable = false;
            this.dgSnizenja.OptionsCustomization.AllowColumnMoving = false;
            this.dgSnizenja.OptionsCustomization.AllowColumnResizing = false;
            this.dgSnizenja.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgSnizenja.OptionsView.EnableAppearanceEvenRow = true;
            this.dgSnizenja.OptionsView.EnableAppearanceOddRow = true;
            this.dgSnizenja.OptionsView.ShowAutoFilterRow = true;
            this.dgSnizenja.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgSnizenja.OptionsView.ShowGroupPanel = false;
            this.dgSnizenja.OptionsView.ShowIndicator = false;
            this.dgSnizenja.PaintStyleName = "WindowsXP";
            this.dgSnizenja.SynchronizeClones = false;
            this.dgSnizenja.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgSnizenja_RowCellStyle);
            // 
            // colakc_ID
            // 
            this.colakc_ID.FieldName = "akc_ID";
            this.colakc_ID.Name = "colakc_ID";
            // 
            // colAKC_BROJ
            // 
            this.colAKC_BROJ.Caption = "Broj sniženja";
            this.colAKC_BROJ.FieldName = "AKC_BROJ";
            this.colAKC_BROJ.Name = "colAKC_BROJ";
            this.colAKC_BROJ.Visible = true;
            this.colAKC_BROJ.VisibleIndex = 0;
            this.colAKC_BROJ.Width = 203;
            // 
            // colAKC_DATUMOD
            // 
            this.colAKC_DATUMOD.Caption = "Od datuma";
            this.colAKC_DATUMOD.FieldName = "AKC_DATUMOD";
            this.colAKC_DATUMOD.Name = "colAKC_DATUMOD";
            this.colAKC_DATUMOD.Visible = true;
            this.colAKC_DATUMOD.VisibleIndex = 1;
            this.colAKC_DATUMOD.Width = 234;
            // 
            // colAKC_DATUMDO
            // 
            this.colAKC_DATUMDO.Caption = "Do datuma";
            this.colAKC_DATUMDO.FieldName = "AKC_DATUMDO";
            this.colAKC_DATUMDO.Name = "colAKC_DATUMDO";
            this.colAKC_DATUMDO.Visible = true;
            this.colAKC_DATUMDO.VisibleIndex = 2;
            this.colAKC_DATUMDO.Width = 234;
            // 
            // colAKC_OPIS
            // 
            this.colAKC_OPIS.Caption = "Opis";
            this.colAKC_OPIS.FieldName = "AKC_OPIS";
            this.colAKC_OPIS.Name = "colAKC_OPIS";
            this.colAKC_OPIS.Visible = true;
            this.colAKC_OPIS.VisibleIndex = 3;
            this.colAKC_OPIS.Width = 234;
            // 
            // colAKC_AKTIVNA
            // 
            this.colAKC_AKTIVNA.Caption = "Aktivna";
            this.colAKC_AKTIVNA.FieldName = "AKC_AKTIVNA";
            this.colAKC_AKTIVNA.Name = "colAKC_AKTIVNA";
            this.colAKC_AKTIVNA.Width = 114;
            // 
            // colAKC_POPUST
            // 
            this.colAKC_POPUST.Caption = "Popust";
            this.colAKC_POPUST.FieldName = "AKC_POPUST";
            this.colAKC_POPUST.Name = "colAKC_POPUST";
            this.colAKC_POPUST.Visible = true;
            this.colAKC_POPUST.VisibleIndex = 4;
            this.colAKC_POPUST.Width = 136;
            // 
            // colAKC_VRIJEDNOSTSNIZENJA
            // 
            this.colAKC_VRIJEDNOSTSNIZENJA.Caption = "Vrijednost sniženja";
            this.colAKC_VRIJEDNOSTSNIZENJA.FieldName = "AKC_VRIJEDNOSTSNIZENJA";
            this.colAKC_VRIJEDNOSTSNIZENJA.Name = "colAKC_VRIJEDNOSTSNIZENJA";
            this.colAKC_VRIJEDNOSTSNIZENJA.Visible = true;
            this.colAKC_VRIJEDNOSTSNIZENJA.VisibleIndex = 5;
            this.colAKC_VRIJEDNOSTSNIZENJA.Width = 300;
            // 
            // coloperater
            // 
            this.coloperater.Caption = "Operater";
            this.coloperater.FieldName = "operater";
            this.coloperater.Name = "coloperater";
            this.coloperater.Visible = true;
            this.coloperater.VisibleIndex = 6;
            this.coloperater.Width = 379;
            // 
            // colakc_datumizmjene
            // 
            this.colakc_datumizmjene.Caption = "Datum obračuna";
            this.colakc_datumizmjene.FieldName = "akc_datumizmjene";
            this.colakc_datumizmjene.Name = "colakc_datumizmjene";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgSnizenjaObracun;
            this.gridView1.Name = "gridView1";
            // 
            // snizenjaTableAdapter
            // 
            this.snizenjaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F9 - excel";
            // 
            // frmSnizenjaObracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 545);
            this.Controls.Add(this.dgSnizenjaObracun);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSnizenjaObracun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniženja obračun";
            this.Load += new System.EventHandler(this.frmSnizenjaObracun_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizenjaObracun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snizenjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled_akcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnizenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPreracunaj;
        private DevExpress.XtraGrid.GridControl dgSnizenjaObracun;
        private DevExpress.XtraGrid.Views.Grid.GridView dgSnizenja;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Pregled_akcija pregled_akcija;
        private System.Windows.Forms.BindingSource snizenjaBindingSource;
        private Pregled_akcijaTableAdapters.snizenjaTableAdapter snizenjaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_BROJ;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_DATUMOD;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_DATUMDO;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_OPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_AKTIVNA;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_POPUST;
        private DevExpress.XtraGrid.Columns.GridColumn coloperater;
        private DevExpress.XtraGrid.Columns.GridColumn colAKC_VRIJEDNOSTSNIZENJA;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colakc_datumizmjene;
        private System.Windows.Forms.Label label2;
    }
}