namespace blokerX
{
    partial class frmArtikliDobavljacaPoBarkodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikliDobavljacaPoBarkodu));
            this.label1 = new System.Windows.Forms.Label();
            this.glDobavljac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtSifKodDobavljac = new System.Windows.Forms.TextBox();
            this.txtSifArtikl = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.cmbB = new System.Windows.Forms.ComboBox();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.cmbD = new System.Windows.Forms.ComboBox();
            this.cmbX = new System.Windows.Forms.ComboBox();
            this.txtPaket = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnStalniCjenik = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač";
            // 
            // glDobavljac
            // 
            this.glDobavljac.EditValue = "";
            this.glDobavljac.Location = new System.Drawing.Point(106, 18);
            this.glDobavljac.Name = "glDobavljac";
            this.glDobavljac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDobavljac.Properties.DataSource = this.partnerBindingSource;
            this.glDobavljac.Properties.DisplayMember = "PA_NAZIV";
            this.glDobavljac.Properties.ImmediatePopup = true;
            this.glDobavljac.Properties.ValueMember = "PA_ID";
            this.glDobavljac.Properties.View = this.gridLookUpEdit1View;
            this.glDobavljac.Size = new System.Drawing.Size(300, 20);
            this.glDobavljac.TabIndex = 1;
            this.glDobavljac.EditValueChanged += new System.EventHandler(this.glDobavljac_EditValueChanged);
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
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Šifra kod dobavljača:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Šifra artikla:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(128, 62);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(184, 20);
            this.txtBarkod.TabIndex = 5;
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            this.txtBarkod.Leave += new System.EventHandler(this.txtBarkod_Leave);
            // 
            // txtSifKodDobavljac
            // 
            this.txtSifKodDobavljac.Location = new System.Drawing.Point(128, 90);
            this.txtSifKodDobavljac.Name = "txtSifKodDobavljac";
            this.txtSifKodDobavljac.Size = new System.Drawing.Size(134, 20);
            this.txtSifKodDobavljac.TabIndex = 6;
            this.txtSifKodDobavljac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifKodDobavljac_KeyPress);
            this.txtSifKodDobavljac.Leave += new System.EventHandler(this.txtSifKodDobavljac_Leave);
            // 
            // txtSifArtikl
            // 
            this.txtSifArtikl.Location = new System.Drawing.Point(128, 119);
            this.txtSifArtikl.Name = "txtSifArtikl";
            this.txtSifArtikl.Size = new System.Drawing.Size(134, 20);
            this.txtSifArtikl.TabIndex = 7;
            this.txtSifArtikl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifArtikl_KeyDown);
            this.txtSifArtikl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifArtikl_KeyPress);
            this.txtSifArtikl.Leave += new System.EventHandler(this.txtSifArtikl_Leave);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(330, 65);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(25, 13);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "___";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "B (da/ne):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "A (da/ne):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "D (da/ne):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "C (da/ne):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Paket:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "X (da/ne):";
            // 
            // cmbA
            // 
            this.cmbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbA.Location = new System.Drawing.Point(138, 164);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(59, 21);
            this.cmbA.TabIndex = 17;
            // 
            // cmbB
            // 
            this.cmbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB.FormattingEnabled = true;
            this.cmbB.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbB.Location = new System.Drawing.Point(138, 191);
            this.cmbB.Name = "cmbB";
            this.cmbB.Size = new System.Drawing.Size(59, 21);
            this.cmbB.TabIndex = 18;
            // 
            // cmbC
            // 
            this.cmbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbC.Location = new System.Drawing.Point(138, 221);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(59, 21);
            this.cmbC.TabIndex = 19;
            // 
            // cmbD
            // 
            this.cmbD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbD.FormattingEnabled = true;
            this.cmbD.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbD.Location = new System.Drawing.Point(138, 250);
            this.cmbD.Name = "cmbD";
            this.cmbD.Size = new System.Drawing.Size(59, 21);
            this.cmbD.TabIndex = 20;
            // 
            // cmbX
            // 
            this.cmbX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbX.FormattingEnabled = true;
            this.cmbX.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbX.Location = new System.Drawing.Point(138, 277);
            this.cmbX.Name = "cmbX";
            this.cmbX.Size = new System.Drawing.Size(59, 21);
            this.cmbX.TabIndex = 21;
            // 
            // txtPaket
            // 
            this.txtPaket.Location = new System.Drawing.Point(138, 312);
            this.txtPaket.MaxLength = 11;
            this.txtPaket.Name = "txtPaket";
            this.txtPaket.Size = new System.Drawing.Size(79, 20);
            this.txtPaket.TabIndex = 22;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(281, 335);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 24;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(362, 335);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnStalniCjenik
            // 
            this.btnStalniCjenik.Location = new System.Drawing.Point(482, 335);
            this.btnStalniCjenik.Name = "btnStalniCjenik";
            this.btnStalniCjenik.Size = new System.Drawing.Size(93, 23);
            this.btnStalniCjenik.TabIndex = 26;
            this.btnStalniCjenik.Text = "Stalni cjenik";
            this.btnStalniCjenik.UseVisualStyleBackColor = true;
            this.btnStalniCjenik.Click += new System.EventHandler(this.btnStalniCjenik_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "(F2)";
            // 
            // frmArtikliDobavljacaPoBarkodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 370);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnStalniCjenik);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPaket);
            this.Controls.Add(this.cmbX);
            this.Controls.Add(this.cmbD);
            this.Controls.Add(this.cmbC);
            this.Controls.Add(this.cmbB);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtSifArtikl);
            this.Controls.Add(this.txtSifKodDobavljac);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glDobavljac);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmArtikliDobavljacaPoBarkodu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli dobavljača po barkodu";
            this.Load += new System.EventHandler(this.frmArtikliDobavljacaPoBarkodu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArtikliDobavljacaPoBarkodu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.glDobavljac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit glDobavljac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtSifKodDobavljac;
        private System.Windows.Forms.TextBox txtSifArtikl;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.ComboBox cmbB;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.ComboBox cmbD;
        private System.Windows.Forms.ComboBox cmbX;
        private System.Windows.Forms.TextBox txtPaket;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnStalniCjenik;
        private System.Windows.Forms.Label label11;
    }
}