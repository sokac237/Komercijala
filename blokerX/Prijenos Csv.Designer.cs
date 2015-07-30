namespace blokerX
{
    partial class frmPrijenosCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijenosCSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPutanja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.dgCSVPodaci = new DevExpress.XtraGrid.GridControl();
            this.dgPodaci = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 63);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(982, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "F1 - pomoć";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(419, 20);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(95, 23);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prenesi u tablicu";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::blokerX.Properties.Resources.open;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.Location = new System.Drawing.Point(368, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 21);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPutanja
            // 
            this.txtPutanja.Location = new System.Drawing.Point(96, 22);
            this.txtPutanja.Name = "txtPutanja";
            this.txtPutanja.Size = new System.Drawing.Size(266, 20);
            this.txtPutanja.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CSV datoteka:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.btnPrenesi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 64);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(176, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 9;
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Location = new System.Drawing.Point(17, 23);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(105, 23);
            this.btnPrenesi.TabIndex = 6;
            this.btnPrenesi.Text = "Spremi podatke";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // dgCSVPodaci
            // 
            this.dgCSVPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCSVPodaci.Location = new System.Drawing.Point(0, 63);
            this.dgCSVPodaci.MainView = this.dgPodaci;
            this.dgCSVPodaci.Name = "dgCSVPodaci";
            this.dgCSVPodaci.Size = new System.Drawing.Size(1070, 409);
            this.dgCSVPodaci.TabIndex = 20;
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
            this.dgPodaci.FixedLineWidth = 1;
            this.dgPodaci.GridControl = this.dgCSVPodaci;
            this.dgPodaci.Name = "dgPodaci";
            this.dgPodaci.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPodaci.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPodaci.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgPodaci.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgPodaci.OptionsBehavior.Editable = false;
            this.dgPodaci.OptionsCustomization.AllowColumnMoving = false;
            this.dgPodaci.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgPodaci.OptionsView.ColumnAutoWidth = false;
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
            // frmPrijenosCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 536);
            this.Controls.Add(this.dgCSVPodaci);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrijenosCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijenos iz CSV datoteke";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrijenosCSV_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgCSVPodaci;
        private DevExpress.XtraGrid.Views.Grid.GridView dgPodaci;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPutanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrenesi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
    }
}