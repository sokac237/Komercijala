namespace blokerX
{
    partial class frmAkcijeZaTrgovinu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkcijeZaTrgovinu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAkc = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtBrojAkcije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKopiranje = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbX = new System.Windows.Forms.CheckBox();
            this.ckbD = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.btnSveLijevo = new System.Windows.Forms.Button();
            this.btnSveDesno = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.novaAkcijaStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novaAkcijaStavke = new blokerX.NovaAkcijaStavke();
            this.dgNeraspoređeneTrgovine = new System.Windows.Forms.DataGridView();
            this.novaAkcijaStavkeTableAdapter = new blokerX.NovaAkcijaStavkeTableAdapters.NovaAkcijaStavkeTableAdapter();
            this.dgOdabraneTrgovine = new System.Windows.Forms.DataGridView();
            this.pOSIFRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKCAKTIVNADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datumslanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akctrgerrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novaAkcijaStavkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novaAkcijaStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNeraspoređeneTrgovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdabraneTrgovine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAkc);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.txtBrojAkcije);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 70);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F5 - Slanje DA / NE";
            // 
            // lblAkc
            // 
            this.lblAkc.AutoSize = true;
            this.lblAkc.Location = new System.Drawing.Point(357, 30);
            this.lblAkc.Name = "lblAkc";
            this.lblAkc.Size = new System.Drawing.Size(0, 13);
            this.lblAkc.TabIndex = 3;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(238, 24);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtBrojAkcije
            // 
            this.txtBrojAkcije.Location = new System.Drawing.Point(97, 27);
            this.txtBrojAkcije.Name = "txtBrojAkcije";
            this.txtBrojAkcije.Size = new System.Drawing.Size(125, 20);
            this.txtBrojAkcije.TabIndex = 1;
            this.txtBrojAkcije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojAkcije_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj akcije:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKopiranje);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnPosalji);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 162);
            this.panel2.TabIndex = 19;
            // 
            // txtKopiranje
            // 
            this.txtKopiranje.FormattingEnabled = true;
            this.txtKopiranje.Location = new System.Drawing.Point(592, 6);
            this.txtKopiranje.Name = "txtKopiranje";
            this.txtKopiranje.Size = new System.Drawing.Size(510, 108);
            this.txtKopiranje.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Log kopiranja";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(691, 127);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(596, 127);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckbX);
            this.panel3.Controls.Add(this.ckbD);
            this.panel3.Controls.Add(this.ckbC);
            this.panel3.Controls.Add(this.ckbB);
            this.panel3.Controls.Add(this.ckbA);
            this.panel3.Controls.Add(this.btnSveLijevo);
            this.panel3.Controls.Add(this.btnSveDesno);
            this.panel3.Controls.Add(this.btnLijevo);
            this.panel3.Controls.Add(this.btnDesno);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(456, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 430);
            this.panel3.TabIndex = 22;
            // 
            // ckbX
            // 
            this.ckbX.AutoSize = true;
            this.ckbX.Location = new System.Drawing.Point(51, 141);
            this.ckbX.Name = "ckbX";
            this.ckbX.Size = new System.Drawing.Size(33, 17);
            this.ckbX.TabIndex = 8;
            this.ckbX.Text = "X";
            this.ckbX.UseVisualStyleBackColor = true;
            this.ckbX.CheckedChanged += new System.EventHandler(this.ckbX_CheckedChanged);
            // 
            // ckbD
            // 
            this.ckbD.AutoSize = true;
            this.ckbD.Location = new System.Drawing.Point(51, 118);
            this.ckbD.Name = "ckbD";
            this.ckbD.Size = new System.Drawing.Size(34, 17);
            this.ckbD.TabIndex = 7;
            this.ckbD.Text = "D";
            this.ckbD.UseVisualStyleBackColor = true;
            this.ckbD.CheckedChanged += new System.EventHandler(this.ckbD_CheckedChanged);
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Location = new System.Drawing.Point(51, 95);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(33, 17);
            this.ckbC.TabIndex = 6;
            this.ckbC.Text = "C";
            this.ckbC.UseVisualStyleBackColor = true;
            this.ckbC.CheckedChanged += new System.EventHandler(this.ckbC_CheckedChanged);
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.Location = new System.Drawing.Point(51, 72);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(33, 17);
            this.ckbB.TabIndex = 5;
            this.ckbB.Text = "B";
            this.ckbB.UseVisualStyleBackColor = true;
            this.ckbB.CheckedChanged += new System.EventHandler(this.ckbB_CheckedChanged);
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.Location = new System.Drawing.Point(51, 49);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(33, 17);
            this.ckbA.TabIndex = 4;
            this.ckbA.Text = "A";
            this.ckbA.UseVisualStyleBackColor = true;
            this.ckbA.CheckedChanged += new System.EventHandler(this.ckbA_CheckedChanged);
            // 
            // btnSveLijevo
            // 
            this.btnSveLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSveLijevo.Location = new System.Drawing.Point(30, 346);
            this.btnSveLijevo.Name = "btnSveLijevo";
            this.btnSveLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnSveLijevo.TabIndex = 3;
            this.btnSveLijevo.Text = "<<<<";
            this.btnSveLijevo.UseVisualStyleBackColor = true;
            this.btnSveLijevo.Click += new System.EventHandler(this.btnSveLijevo_Click);
            // 
            // btnSveDesno
            // 
            this.btnSveDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSveDesno.Location = new System.Drawing.Point(30, 304);
            this.btnSveDesno.Name = "btnSveDesno";
            this.btnSveDesno.Size = new System.Drawing.Size(75, 23);
            this.btnSveDesno.TabIndex = 2;
            this.btnSveDesno.Text = ">>>>";
            this.btnSveDesno.UseVisualStyleBackColor = true;
            this.btnSveDesno.Click += new System.EventHandler(this.btnSveDesno_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijevo.Location = new System.Drawing.Point(30, 257);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 1;
            this.btnLijevo.Text = "<----";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDesno.Location = new System.Drawing.Point(30, 216);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 0;
            this.btnDesno.Text = "---->";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // novaAkcijaStavkeBindingSource
            // 
            this.novaAkcijaStavkeBindingSource.DataMember = "NovaAkcijaStavke";
            this.novaAkcijaStavkeBindingSource.DataSource = this.novaAkcijaStavke;
            // 
            // novaAkcijaStavke
            // 
            this.novaAkcijaStavke.DataSetName = "NovaAkcijaStavke";
            this.novaAkcijaStavke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgNeraspoređeneTrgovine
            // 
            this.dgNeraspoređeneTrgovine.AllowUserToAddRows = false;
            this.dgNeraspoređeneTrgovine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgNeraspoređeneTrgovine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNeraspoređeneTrgovine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgNeraspoređeneTrgovine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgNeraspoređeneTrgovine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNeraspoređeneTrgovine.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgNeraspoređeneTrgovine.Location = new System.Drawing.Point(0, 70);
            this.dgNeraspoređeneTrgovine.Name = "dgNeraspoređeneTrgovine";
            this.dgNeraspoređeneTrgovine.ReadOnly = true;
            this.dgNeraspoređeneTrgovine.RowHeadersWidth = 10;
            this.dgNeraspoređeneTrgovine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNeraspoređeneTrgovine.Size = new System.Drawing.Size(456, 430);
            this.dgNeraspoređeneTrgovine.TabIndex = 20;
            // 
            // novaAkcijaStavkeTableAdapter
            // 
            this.novaAkcijaStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // dgOdabraneTrgovine
            // 
            this.dgOdabraneTrgovine.AllowUserToAddRows = false;
            this.dgOdabraneTrgovine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgOdabraneTrgovine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOdabraneTrgovine.AutoGenerateColumns = false;
            this.dgOdabraneTrgovine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOdabraneTrgovine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgOdabraneTrgovine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOdabraneTrgovine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pOSIFRADataGridViewTextBoxColumn,
            this.ponazivDataGridViewTextBoxColumn,
            this.aKCAKTIVNADataGridViewCheckBoxColumn,
            this.datumslanja,
            this.poslano,
            this.akctrgerrDataGridViewTextBoxColumn});
            this.dgOdabraneTrgovine.DataSource = this.novaAkcijaStavkeBindingSource;
            this.dgOdabraneTrgovine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOdabraneTrgovine.Location = new System.Drawing.Point(592, 70);
            this.dgOdabraneTrgovine.Name = "dgOdabraneTrgovine";
            this.dgOdabraneTrgovine.ReadOnly = true;
            this.dgOdabraneTrgovine.RowHeadersWidth = 10;
            this.dgOdabraneTrgovine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOdabraneTrgovine.Size = new System.Drawing.Size(522, 430);
            this.dgOdabraneTrgovine.TabIndex = 23;
            this.dgOdabraneTrgovine.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOdabraneTrgovine_CellContentDoubleClick);
            this.dgOdabraneTrgovine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgOdabraneTrgovine_KeyDown);
            // 
            // pOSIFRADataGridViewTextBoxColumn
            // 
            this.pOSIFRADataGridViewTextBoxColumn.DataPropertyName = "PO_SIFRA";
            this.pOSIFRADataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.pOSIFRADataGridViewTextBoxColumn.Name = "pOSIFRADataGridViewTextBoxColumn";
            this.pOSIFRADataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSIFRADataGridViewTextBoxColumn.Width = 53;
            // 
            // ponazivDataGridViewTextBoxColumn
            // 
            this.ponazivDataGridViewTextBoxColumn.DataPropertyName = "po_naziv";
            this.ponazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.ponazivDataGridViewTextBoxColumn.Name = "ponazivDataGridViewTextBoxColumn";
            this.ponazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.ponazivDataGridViewTextBoxColumn.Width = 59;
            // 
            // aKCAKTIVNADataGridViewCheckBoxColumn
            // 
            this.aKCAKTIVNADataGridViewCheckBoxColumn.DataPropertyName = "AKC_AKTIVNA";
            this.aKCAKTIVNADataGridViewCheckBoxColumn.FalseValue = "Ne";
            this.aKCAKTIVNADataGridViewCheckBoxColumn.HeaderText = "Slanje";
            this.aKCAKTIVNADataGridViewCheckBoxColumn.Name = "aKCAKTIVNADataGridViewCheckBoxColumn";
            this.aKCAKTIVNADataGridViewCheckBoxColumn.ReadOnly = true;
            this.aKCAKTIVNADataGridViewCheckBoxColumn.TrueValue = "Da";
            this.aKCAKTIVNADataGridViewCheckBoxColumn.Width = 42;
            // 
            // datumslanja
            // 
            this.datumslanja.HeaderText = "Datum slanja";
            this.datumslanja.Name = "datumslanja";
            this.datumslanja.ReadOnly = true;
            this.datumslanja.Width = 93;
            // 
            // poslano
            // 
            this.poslano.HeaderText = "Poslano";
            this.poslano.Name = "poslano";
            this.poslano.ReadOnly = true;
            this.poslano.Width = 70;
            // 
            // akctrgerrDataGridViewTextBoxColumn
            // 
            this.akctrgerrDataGridViewTextBoxColumn.DataPropertyName = "akctrg_err";
            this.akctrgerrDataGridViewTextBoxColumn.HeaderText = "Greška";
            this.akctrgerrDataGridViewTextBoxColumn.Name = "akctrgerrDataGridViewTextBoxColumn";
            this.akctrgerrDataGridViewTextBoxColumn.ReadOnly = true;
            this.akctrgerrDataGridViewTextBoxColumn.Visible = false;
            this.akctrgerrDataGridViewTextBoxColumn.Width = 66;
            // 
            // frmAkcijeZaTrgovinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 662);
            this.Controls.Add(this.dgOdabraneTrgovine);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgNeraspoređeneTrgovine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAkcijeZaTrgovinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akcije za trgovinu";
            this.Load += new System.EventHandler(this.frmAkcijeZaTrgovinu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAkcijeZaTrgovinu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novaAkcijaStavkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novaAkcijaStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNeraspoređeneTrgovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdabraneTrgovine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtBrojAkcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSveLijevo;
        private System.Windows.Forms.Button btnSveDesno;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.DataGridView dgNeraspoređeneTrgovine;
        private System.Windows.Forms.CheckBox ckbX;
        private System.Windows.Forms.CheckBox ckbD;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbA;
        private System.Windows.Forms.Label lblAkc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox txtKopiranje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource novaAkcijaStavkeBindingSource;
        private NovaAkcijaStavke novaAkcijaStavke;
        private NovaAkcijaStavkeTableAdapters.NovaAkcijaStavkeTableAdapter novaAkcijaStavkeTableAdapter;
        private System.Windows.Forms.DataGridView dgOdabraneTrgovine;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSIFRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aKCAKTIVNADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumslanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslano;
        private System.Windows.Forms.DataGridViewTextBoxColumn akctrgerrDataGridViewTextBoxColumn;
    }
}