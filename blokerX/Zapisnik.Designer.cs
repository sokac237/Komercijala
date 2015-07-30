namespace blokerX
{
    partial class frmZapisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZapisnik));
            this.label1 = new System.Windows.Forms.Label();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnica = new blokerX.Poslovnica();
            this.glPartner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljac = new blokerX.dobavljac();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZapisnik = new System.Windows.Forms.TextBox();
            this.TxtOdobrenje = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNabavnaVrijednost = new DevExpress.XtraEditors.TextEdit();
            this.txtProdajnaVrij = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbZakljucen = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnZapisi = new System.Windows.Forms.Button();
            this.partnerTableAdapter = new blokerX.dobavljacTableAdapters.partnerTableAdapter();
            this.poslovnicaTableAdapter = new blokerX.PoslovnicaTableAdapters.poslovnicaTableAdapter();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojAkcije = new System.Windows.Forms.TextBox();
            this.txtVrijednost = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNabavnaVrijednost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdajnaVrij.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrijednost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trgovina/skladište:";
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.poslovnica;
            // 
            // poslovnica
            // 
            this.poslovnica.DataSetName = "Poslovnica";
            this.poslovnica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Location = new System.Drawing.Point(159, 57);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.ImmediatePopup = true;
            this.glPartner.Properties.NullText = "";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridView1;
            this.glPartner.Size = new System.Drawing.Size(298, 20);
            this.glPartner.TabIndex = 1;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_ID,
            this.colPA_SIFRA,
            this.colPA_NAZIV});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Naziv";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dobavljač:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(159, 91);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(126, 20);
            this.dtpDatum.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Zapisnik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Odobrenje:";
            // 
            // txtZapisnik
            // 
            this.txtZapisnik.Location = new System.Drawing.Point(159, 137);
            this.txtZapisnik.MaxLength = 30;
            this.txtZapisnik.Name = "txtZapisnik";
            this.txtZapisnik.Size = new System.Drawing.Size(300, 20);
            this.txtZapisnik.TabIndex = 3;
            this.txtZapisnik.Leave += new System.EventHandler(this.txtZapisnik_Leave);
            // 
            // TxtOdobrenje
            // 
            this.TxtOdobrenje.Location = new System.Drawing.Point(159, 171);
            this.TxtOdobrenje.MaxLength = 30;
            this.TxtOdobrenje.Name = "TxtOdobrenje";
            this.TxtOdobrenje.Size = new System.Drawing.Size(300, 20);
            this.TxtOdobrenje.TabIndex = 4;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(159, 214);
            this.txtNapomena.MaxLength = 60;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(413, 20);
            this.txtNapomena.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Napomena:";
            // 
            // txtNabavnaVrijednost
            // 
            this.txtNabavnaVrijednost.Location = new System.Drawing.Point(159, 244);
            this.txtNabavnaVrijednost.Name = "txtNabavnaVrijednost";
            this.txtNabavnaVrijednost.Properties.Mask.EditMask = "c2";
            this.txtNabavnaVrijednost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNabavnaVrijednost.Size = new System.Drawing.Size(130, 20);
            this.txtNabavnaVrijednost.TabIndex = 6;
            // 
            // txtProdajnaVrij
            // 
            this.txtProdajnaVrij.Location = new System.Drawing.Point(159, 274);
            this.txtProdajnaVrij.Name = "txtProdajnaVrij";
            this.txtProdajnaVrij.Properties.Mask.EditMask = "c2";
            this.txtProdajnaVrij.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProdajnaVrij.Size = new System.Drawing.Size(130, 20);
            this.txtProdajnaVrij.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nabavna vrijednost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Prodajna vrijednost:";
            // 
            // ckbZakljucen
            // 
            this.ckbZakljucen.AutoSize = true;
            this.ckbZakljucen.Location = new System.Drawing.Point(159, 317);
            this.ckbZakljucen.Name = "ckbZakljucen";
            this.ckbZakljucen.Size = new System.Drawing.Size(104, 17);
            this.ckbZakljucen.TabIndex = 10;
            this.ckbZakljucen.Text = "Zaključi zapisnik";
            this.ckbZakljucen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnOdustani);
            this.panel1.Controls.Add(this.btnZapisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 46);
            this.panel1.TabIndex = 47;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(519, 11);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnZapisi
            // 
            this.btnZapisi.Location = new System.Drawing.Point(427, 11);
            this.btnZapisi.Name = "btnZapisi";
            this.btnZapisi.Size = new System.Drawing.Size(75, 23);
            this.btnZapisi.TabIndex = 11;
            this.btnZapisi.Text = "Zapiši";
            this.btnZapisi.UseVisualStyleBackColor = true;
            this.btnZapisi.Click += new System.EventHandler(this.btnZapisi_Click);
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(159, 20);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ImmediatePopup = true;
            this.glPoslovnica.Properties.NullText = "";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Size = new System.Drawing.Size(298, 20);
            this.glPoslovnica.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Broj akcije:";
            // 
            // txtBrojAkcije
            // 
            this.txtBrojAkcije.Location = new System.Drawing.Point(402, 244);
            this.txtBrojAkcije.MaxLength = 7;
            this.txtBrojAkcije.Name = "txtBrojAkcije";
            this.txtBrojAkcije.Size = new System.Drawing.Size(107, 20);
            this.txtBrojAkcije.TabIndex = 7;
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(402, 274);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Properties.Mask.EditMask = "n2";
            this.txtVrijednost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVrijednost.Size = new System.Drawing.Size(107, 20);
            this.txtVrijednost.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(299, 277);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 13);
            this.label27.TabIndex = 51;
            this.label27.Text = "Vrijednost sniženja:";
            // 
            // frmZapisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 413);
            this.Controls.Add(this.txtVrijednost);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBrojAkcije);
            this.Controls.Add(this.glPoslovnica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckbZakljucen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProdajnaVrij);
            this.Controls.Add(this.txtNabavnaVrijednost);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOdobrenje);
            this.Controls.Add(this.txtZapisnik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.glPartner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmZapisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapisnik";
            this.Load += new System.EventHandler(this.frmZapisnik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmZapisnik_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNabavnaVrijednost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdajnaVrij.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVrijednost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZapisnik;
        private System.Windows.Forms.TextBox TxtOdobrenje;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtNabavnaVrijednost;
        private DevExpress.XtraEditors.TextEdit txtProdajnaVrij;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbZakljucen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnZapisi;
        private dobavljac dobavljac;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private dobavljacTableAdapters.partnerTableAdapter partnerTableAdapter;
        private Poslovnica poslovnica;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private PoslovnicaTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojAkcije;
        private DevExpress.XtraEditors.TextEdit txtVrijednost;
        private System.Windows.Forms.Label label27;
    }
}