namespace blokerX
{
    partial class frmIzmjenaCijena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzmjenaCijena));
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbAktivna = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStopaPoreza = new DevExpress.XtraEditors.TextEdit();
            this.txtNabavna = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCijenaLetka = new DevExpress.XtraEditors.TextEdit();
            this.txtCijenaX = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtCijenaA = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtCijenaB = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtCijenaC = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtCijenaD = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtMarzaA = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtMarzaB = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtMarzaC = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtMarzaD = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtMarzaX = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.btnApreracun = new System.Windows.Forms.Button();
            this.btnBpreracun = new System.Windows.Forms.Button();
            this.btnCpreracun = new System.Windows.Forms.Button();
            this.btnDpreracun = new System.Windows.Forms.Button();
            this.btnXpreracun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStopaPoreza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNabavna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijenaLetka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(131, 256);
            this.txtNapomena.MaxLength = 50;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(284, 20);
            this.txtNapomena.TabIndex = 12;
            this.txtNapomena.Text = " ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(60, 259);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Napomena:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(60, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Cijena letka:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(588, 286);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(507, 286);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbAktivna
            // 
            this.cmbAktivna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivna.FormattingEnabled = true;
            this.cmbAktivna.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cmbAktivna.Location = new System.Drawing.Point(131, 201);
            this.cmbAktivna.Name = "cmbAktivna";
            this.cmbAktivna.Size = new System.Drawing.Size(59, 21);
            this.cmbAktivna.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(242, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Cijena (kn)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(128, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Marža (%)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Aktivna (da/ne):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(86, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Tip X:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tip D:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(86, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Tip C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Tip B:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Tip A:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivArtikla.Location = new System.Drawing.Point(76, 24);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(35, 17);
            this.lblNazivArtikla.TabIndex = 34;
            this.lblNazivArtikla.Text = "___";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(27, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Artikl:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtStopaPoreza);
            this.groupBox1.Controls.Add(this.txtNabavna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(428, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 88);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o artiklu";
            // 
            // txtStopaPoreza
            // 
            this.txtStopaPoreza.Location = new System.Drawing.Point(98, 50);
            this.txtStopaPoreza.Name = "txtStopaPoreza";
            this.txtStopaPoreza.Properties.Mask.EditMask = "c2";
            this.txtStopaPoreza.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtStopaPoreza.Properties.ReadOnly = true;
            this.txtStopaPoreza.Size = new System.Drawing.Size(73, 20);
            this.txtStopaPoreza.TabIndex = 71;
            // 
            // txtNabavna
            // 
            this.txtNabavna.Location = new System.Drawing.Point(98, 24);
            this.txtNabavna.Name = "txtNabavna";
            this.txtNabavna.Properties.Mask.EditMask = "c2";
            this.txtNabavna.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNabavna.Properties.ReadOnly = true;
            this.txtNabavna.Size = new System.Drawing.Size(73, 20);
            this.txtNabavna.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stopa poreza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nabavna cijena:";
            // 
            // txtCijenaLetka
            // 
            this.txtCijenaLetka.Location = new System.Drawing.Point(131, 229);
            this.txtCijenaLetka.Name = "txtCijenaLetka";
            this.txtCijenaLetka.Properties.Mask.EditMask = "c2";
            this.txtCijenaLetka.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCijenaLetka.Size = new System.Drawing.Size(130, 20);
            this.txtCijenaLetka.TabIndex = 11;
            // 
            // txtCijenaX
            // 
            this.txtCijenaX.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtCijenaX.InputMask = "{LOC}nnnnnnn.nn";
            this.txtCijenaX.Location = new System.Drawing.Point(229, 175);
            this.txtCijenaX.Name = "txtCijenaX";
            this.txtCijenaX.PromptChar = ' ';
            this.txtCijenaX.Size = new System.Drawing.Size(73, 20);
            this.txtCijenaX.TabIndex = 9;
            this.txtCijenaX.Leave += new System.EventHandler(this.txtCijenaX_Leave);
            // 
            // txtCijenaA
            // 
            this.txtCijenaA.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtCijenaA.InputMask = "{LOC}nnnnnnn.nn";
            this.txtCijenaA.Location = new System.Drawing.Point(229, 76);
            this.txtCijenaA.Name = "txtCijenaA";
            this.txtCijenaA.PromptChar = ' ';
            this.txtCijenaA.Size = new System.Drawing.Size(73, 20);
            this.txtCijenaA.TabIndex = 1;
            this.txtCijenaA.Leave += new System.EventHandler(this.txtCijenaA_Leave);
            // 
            // txtCijenaB
            // 
            this.txtCijenaB.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtCijenaB.InputMask = "{LOC}nnnnnnn.nn";
            this.txtCijenaB.Location = new System.Drawing.Point(229, 101);
            this.txtCijenaB.Name = "txtCijenaB";
            this.txtCijenaB.PromptChar = ' ';
            this.txtCijenaB.Size = new System.Drawing.Size(73, 20);
            this.txtCijenaB.TabIndex = 3;
            this.txtCijenaB.Leave += new System.EventHandler(this.txtCijenaB_Leave);
            // 
            // txtCijenaC
            // 
            this.txtCijenaC.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtCijenaC.InputMask = "{LOC}nnnnnnn.nn";
            this.txtCijenaC.Location = new System.Drawing.Point(229, 126);
            this.txtCijenaC.Name = "txtCijenaC";
            this.txtCijenaC.PromptChar = ' ';
            this.txtCijenaC.Size = new System.Drawing.Size(73, 20);
            this.txtCijenaC.TabIndex = 5;
            this.txtCijenaC.Leave += new System.EventHandler(this.txtCijenaC_Leave);
            // 
            // txtCijenaD
            // 
            this.txtCijenaD.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtCijenaD.InputMask = "{LOC}nnnnnnn.nn";
            this.txtCijenaD.Location = new System.Drawing.Point(229, 151);
            this.txtCijenaD.Name = "txtCijenaD";
            this.txtCijenaD.PromptChar = ' ';
            this.txtCijenaD.Size = new System.Drawing.Size(73, 20);
            this.txtCijenaD.TabIndex = 7;
            this.txtCijenaD.Leave += new System.EventHandler(this.txtCijenaD_Leave);
            // 
            // txtMarzaA
            // 
            this.txtMarzaA.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtMarzaA.InputMask = "{LOC}-nnnnnnn.nn";
            this.txtMarzaA.Location = new System.Drawing.Point(131, 76);
            this.txtMarzaA.Name = "txtMarzaA";
            this.txtMarzaA.PromptChar = ' ';
            this.txtMarzaA.Size = new System.Drawing.Size(73, 20);
            this.txtMarzaA.TabIndex = 0;
            this.txtMarzaA.Leave += new System.EventHandler(this.txtMarzaA_Leave);
            // 
            // txtMarzaB
            // 
            this.txtMarzaB.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtMarzaB.InputMask = "{LOC}-nnnnnnn.nn";
            this.txtMarzaB.Location = new System.Drawing.Point(131, 101);
            this.txtMarzaB.Name = "txtMarzaB";
            this.txtMarzaB.PromptChar = ' ';
            this.txtMarzaB.Size = new System.Drawing.Size(73, 20);
            this.txtMarzaB.TabIndex = 2;
            this.txtMarzaB.Leave += new System.EventHandler(this.txtMarzaB_Leave);
            // 
            // txtMarzaC
            // 
            this.txtMarzaC.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtMarzaC.InputMask = "{LOC}-nnnnnnn.nn";
            this.txtMarzaC.Location = new System.Drawing.Point(131, 126);
            this.txtMarzaC.Name = "txtMarzaC";
            this.txtMarzaC.PromptChar = ' ';
            this.txtMarzaC.Size = new System.Drawing.Size(73, 20);
            this.txtMarzaC.TabIndex = 4;
            this.txtMarzaC.Leave += new System.EventHandler(this.txtMarzaC_Leave);
            // 
            // txtMarzaD
            // 
            this.txtMarzaD.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtMarzaD.InputMask = "{LOC}-nnnnnnn.nn";
            this.txtMarzaD.Location = new System.Drawing.Point(131, 151);
            this.txtMarzaD.Name = "txtMarzaD";
            this.txtMarzaD.PromptChar = ' ';
            this.txtMarzaD.Size = new System.Drawing.Size(73, 20);
            this.txtMarzaD.TabIndex = 6;
            this.txtMarzaD.Leave += new System.EventHandler(this.txtMarzaD_Leave);
            // 
            // txtMarzaX
            // 
            this.txtMarzaX.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Double;
            this.txtMarzaX.InputMask = "{LOC}-nnnnnnn.nn";
            this.txtMarzaX.Location = new System.Drawing.Point(131, 175);
            this.txtMarzaX.Name = "txtMarzaX";
            this.txtMarzaX.PromptChar = ' ';
            this.txtMarzaX.Size = new System.Drawing.Size(73, 20);
            this.txtMarzaX.TabIndex = 8;
            this.txtMarzaX.Leave += new System.EventHandler(this.txtMarzaX_Leave);
            // 
            // btnApreracun
            // 
            this.btnApreracun.Location = new System.Drawing.Point(324, 74);
            this.btnApreracun.Name = "btnApreracun";
            this.btnApreracun.Size = new System.Drawing.Size(36, 23);
            this.btnApreracun.TabIndex = 87;
            this.btnApreracun.Text = "0,09";
            this.btnApreracun.UseVisualStyleBackColor = true;
            this.btnApreracun.Click += new System.EventHandler(this.btnApreracun_Click);
            // 
            // btnBpreracun
            // 
            this.btnBpreracun.Location = new System.Drawing.Point(324, 99);
            this.btnBpreracun.Name = "btnBpreracun";
            this.btnBpreracun.Size = new System.Drawing.Size(36, 23);
            this.btnBpreracun.TabIndex = 88;
            this.btnBpreracun.Text = "0,09";
            this.btnBpreracun.UseVisualStyleBackColor = true;
            this.btnBpreracun.Click += new System.EventHandler(this.btnBpreracun_Click);
            // 
            // btnCpreracun
            // 
            this.btnCpreracun.Location = new System.Drawing.Point(324, 124);
            this.btnCpreracun.Name = "btnCpreracun";
            this.btnCpreracun.Size = new System.Drawing.Size(36, 23);
            this.btnCpreracun.TabIndex = 89;
            this.btnCpreracun.Text = "0,09";
            this.btnCpreracun.UseVisualStyleBackColor = true;
            this.btnCpreracun.Click += new System.EventHandler(this.btnCpreracun_Click);
            // 
            // btnDpreracun
            // 
            this.btnDpreracun.Location = new System.Drawing.Point(324, 149);
            this.btnDpreracun.Name = "btnDpreracun";
            this.btnDpreracun.Size = new System.Drawing.Size(36, 23);
            this.btnDpreracun.TabIndex = 90;
            this.btnDpreracun.Text = "0,09";
            this.btnDpreracun.UseVisualStyleBackColor = true;
            this.btnDpreracun.Click += new System.EventHandler(this.btnDpreracun_Click);
            // 
            // btnXpreracun
            // 
            this.btnXpreracun.Location = new System.Drawing.Point(324, 173);
            this.btnXpreracun.Name = "btnXpreracun";
            this.btnXpreracun.Size = new System.Drawing.Size(36, 23);
            this.btnXpreracun.TabIndex = 91;
            this.btnXpreracun.Text = "0,09";
            this.btnXpreracun.UseVisualStyleBackColor = true;
            this.btnXpreracun.Click += new System.EventHandler(this.btnXpreracun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Zaokruži";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 94;
            this.label4.Text = "Šifra:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSifra.Location = new System.Drawing.Point(76, 5);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(31, 15);
            this.lblSifra.TabIndex = 95;
            this.lblSifra.Text = "___";
            // 
            // frmIzmjenaCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 334);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXpreracun);
            this.Controls.Add(this.btnDpreracun);
            this.Controls.Add(this.btnCpreracun);
            this.Controls.Add(this.btnBpreracun);
            this.Controls.Add(this.btnApreracun);
            this.Controls.Add(this.txtMarzaX);
            this.Controls.Add(this.txtMarzaD);
            this.Controls.Add(this.txtMarzaC);
            this.Controls.Add(this.txtMarzaB);
            this.Controls.Add(this.txtMarzaA);
            this.Controls.Add(this.txtCijenaD);
            this.Controls.Add(this.txtCijenaC);
            this.Controls.Add(this.txtCijenaB);
            this.Controls.Add(this.txtCijenaA);
            this.Controls.Add(this.txtCijenaX);
            this.Controls.Add(this.txtCijenaLetka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbAktivna);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmIzmjenaCijena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena cijene";
            this.Deactivate += new System.EventHandler(this.frmIzmjenaCijena_Deactivate);
            this.Load += new System.EventHandler(this.frmIzmjenaCijena_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIzmjenaCijena_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStopaPoreza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNabavna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijenaLetka.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbAktivna;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCijenaLetka;
        private DevExpress.XtraEditors.TextEdit txtStopaPoreza;
        private DevExpress.XtraEditors.TextEdit txtNabavna;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtCijenaX;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtCijenaA;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtCijenaB;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtCijenaC;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtCijenaD;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtMarzaA;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtMarzaB;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtMarzaC;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtMarzaD;
        private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtMarzaX;
        private System.Windows.Forms.Button btnApreracun;
        private System.Windows.Forms.Button btnBpreracun;
        private System.Windows.Forms.Button btnCpreracun;
        private System.Windows.Forms.Button btnDpreracun;
        private System.Windows.Forms.Button btnXpreracun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSifra;

    }
}