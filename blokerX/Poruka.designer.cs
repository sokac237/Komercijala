namespace blokerX
{
    partial class frmPoruka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoruka));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPrijenosCjenika = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlNabavniAkcijski = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlMPCakcija = new System.Windows.Forms.Panel();
            this.pnlArtiklCSV = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPrijenosCjenika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlNabavniAkcijski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlMPCakcija.SuspendLayout();
            this.pnlArtiklCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(506, 525);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 62);
            this.label1.TabIndex = 15;
            this.label1.Text = "Upute za pravljenje CSV datoteke";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(585, 49);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prilikom izrade CSV dokumenta treba paziti da se uzmu potrebni podaci i sortiraju" +
    " redom kako je navedeno!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 47);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kolone redom: Barokod, Cijena, Rabat, AkcijskaCijena, AkcijskiRabat, Odkada, Doka" +
    "da, Proizvođač, ŠifraKodDobavljača, Konsignacija\r\n";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 151);
            this.label4.TabIndex = 20;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 79);
            this.label5.TabIndex = 21;
            this.label5.Text = "Primjer retka s podacima:\r\n\r\n3858888676674;8,15;10; ; ; ; ; ; ;";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(585, 52);
            this.label6.TabIndex = 22;
            this.label6.Text = "Napomena: obavezne kolone koje moraju postojati su Barkod, Cijena, Rabat , \r\nosta" +
    "le su proizvoljne i ne moraju postojati";
            // 
            // pnlPrijenosCjenika
            // 
            this.pnlPrijenosCjenika.Controls.Add(this.label6);
            this.pnlPrijenosCjenika.Controls.Add(this.label5);
            this.pnlPrijenosCjenika.Controls.Add(this.label4);
            this.pnlPrijenosCjenika.Controls.Add(this.label2);
            this.pnlPrijenosCjenika.Controls.Add(this.label3);
            this.pnlPrijenosCjenika.Controls.Add(this.label1);
            this.pnlPrijenosCjenika.Controls.Add(this.btnOK);
            this.pnlPrijenosCjenika.Controls.Add(this.pictureBox1);
            this.pnlPrijenosCjenika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrijenosCjenika.Location = new System.Drawing.Point(0, 0);
            this.pnlPrijenosCjenika.Name = "pnlPrijenosCjenika";
            this.pnlPrijenosCjenika.Size = new System.Drawing.Size(647, 617);
            this.pnlPrijenosCjenika.TabIndex = 0;
            this.pnlPrijenosCjenika.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(132, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(252, 62);
            this.label24.TabIndex = 15;
            this.label24.Text = "Upute za pravljenje CSV datoteke";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(12, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(585, 49);
            this.label23.TabIndex = 17;
            this.label23.Text = "Prilikom izrade CSV dokumenta treba paziti da se uzmu potrebni podaci i sortiraju" +
    " redom kako je navedeno!";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(12, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(593, 47);
            this.label22.TabIndex = 19;
            this.label22.Text = "Kolone redom: EAN, Šifra artikla, Šifra kod dobavljača, VPC, Rabat, Akc. Rabat, N" +
    "C, Povećanje";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(12, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(593, 151);
            this.label21.TabIndex = 20;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(12, 363);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(593, 79);
            this.label20.TabIndex = 21;
            this.label20.Text = "Primjer retka s podacima:\r\n\r\n3850291028972;084156;245;5,99000;10,00;18,00;4,42062" +
    ";30,00";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(12, 443);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(585, 92);
            this.label19.TabIndex = 22;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // pnlNabavniAkcijski
            // 
            this.pnlNabavniAkcijski.Controls.Add(this.label19);
            this.pnlNabavniAkcijski.Controls.Add(this.label20);
            this.pnlNabavniAkcijski.Controls.Add(this.label21);
            this.pnlNabavniAkcijski.Controls.Add(this.label22);
            this.pnlNabavniAkcijski.Controls.Add(this.label23);
            this.pnlNabavniAkcijski.Controls.Add(this.label24);
            this.pnlNabavniAkcijski.Controls.Add(this.button2);
            this.pnlNabavniAkcijski.Controls.Add(this.pictureBox4);
            this.pnlNabavniAkcijski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNabavniAkcijski.Location = new System.Drawing.Point(0, 0);
            this.pnlNabavniAkcijski.Name = "pnlNabavniAkcijski";
            this.pnlNabavniAkcijski.Size = new System.Drawing.Size(647, 617);
            this.pnlNabavniAkcijski.TabIndex = 24;
            this.pnlNabavniAkcijski.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(132, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(252, 62);
            this.label18.TabIndex = 15;
            this.label18.Text = "Upute za pravljenje CSV datoteke";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(12, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(585, 49);
            this.label17.TabIndex = 17;
            this.label17.Text = "Prilikom izrade CSV dokumenta treba paziti da se uzmu potrebni podaci i sortiraju" +
    " redom kako je navedeno!";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(12, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(593, 47);
            this.label16.TabIndex = 19;
            this.label16.Text = "Kolone redom: EAN, Šifra artikla, Šifra kod dobavljača, MPC tipa, MPC tipb, MPC t" +
    "ipc, MPC tipd, MPC tipx, Cijena letka, Napomena\r\n\r\n";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(593, 151);
            this.label15.TabIndex = 20;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(12, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(593, 79);
            this.label14.TabIndex = 21;
            this.label14.Text = "Primjer retka s podacima:\r\n\r\n3858882210140;;;5,99;5,99;7,49;6,49;5,99;;nacionalna" +
    " akcija";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(585, 65);
            this.label13.TabIndex = 22;
            this.label13.Text = "Napomena: obavezne kolone koje moraju postojati su EAN ili Šifra artikla ili šifr" +
    "a kod dobavljača, cijene tipa, tipb,tipc,tipd,tipx, preostale dvije kolone su op" +
    "cionalne (cijena letka i napomena).";
            // 
            // pnlMPCakcija
            // 
            this.pnlMPCakcija.Controls.Add(this.label13);
            this.pnlMPCakcija.Controls.Add(this.label14);
            this.pnlMPCakcija.Controls.Add(this.label15);
            this.pnlMPCakcija.Controls.Add(this.label16);
            this.pnlMPCakcija.Controls.Add(this.label17);
            this.pnlMPCakcija.Controls.Add(this.label18);
            this.pnlMPCakcija.Controls.Add(this.button1);
            this.pnlMPCakcija.Controls.Add(this.pictureBox3);
            this.pnlMPCakcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMPCakcija.Location = new System.Drawing.Point(0, 0);
            this.pnlMPCakcija.Name = "pnlMPCakcija";
            this.pnlMPCakcija.Size = new System.Drawing.Size(647, 617);
            this.pnlMPCakcija.TabIndex = 26;
            this.pnlMPCakcija.Visible = false;
            // 
            // pnlArtiklCSV
            // 
            this.pnlArtiklCSV.Controls.Add(this.label7);
            this.pnlArtiklCSV.Controls.Add(this.label8);
            this.pnlArtiklCSV.Controls.Add(this.label9);
            this.pnlArtiklCSV.Controls.Add(this.label10);
            this.pnlArtiklCSV.Controls.Add(this.label11);
            this.pnlArtiklCSV.Controls.Add(this.label12);
            this.pnlArtiklCSV.Controls.Add(this.btnOK2);
            this.pnlArtiklCSV.Controls.Add(this.pictureBox2);
            this.pnlArtiklCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArtiklCSV.Location = new System.Drawing.Point(0, 0);
            this.pnlArtiklCSV.Name = "pnlArtiklCSV";
            this.pnlArtiklCSV.Size = new System.Drawing.Size(647, 617);
            this.pnlArtiklCSV.TabIndex = 28;
            this.pnlArtiklCSV.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(585, 52);
            this.label7.TabIndex = 22;
            this.label7.Text = "Napomena: obavezne kolone koje moraju postojati su Barkod artikla ili  Šifra arti" +
    "kla te barem jedna od ostalih kolona koja se hoće dodati";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(593, 79);
            this.label8.TabIndex = 21;
            this.label8.Text = "Primjer retka s podacima:\r\n\r\n;450368;8,15;10; ; ; ; ; ;\r\n3850159110009; ; ; ; ; ;" +
    " ;705;705";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(601, 151);
            this.label9.TabIndex = 20;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(593, 47);
            this.label10.TabIndex = 19;
            this.label10.Text = "Kolone redom: Barkod artikla, Šifra artikla, Dubina, Širina, Visina, Težina, Jedi" +
    "nica mj., Robna marka, Proizvođač, Glavni Dobavljač";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(585, 49);
            this.label11.TabIndex = 17;
            this.label11.Text = "Prilikom izrade CSV dokumenta treba paziti da se uzmu potrebni podaci i sortiraju" +
    " redom kako je navedeno!";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(132, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 62);
            this.label12.TabIndex = 15;
            this.label12.Text = "Upute za pravljenje CSV datoteke";
            // 
            // btnOK2
            // 
            this.btnOK2.Location = new System.Drawing.Point(506, 525);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(75, 23);
            this.btnOK2.TabIndex = 18;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // frmPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(647, 617);
            this.Controls.Add(this.pnlArtiklCSV);
            this.Controls.Add(this.pnlMPCakcija);
            this.Controls.Add(this.pnlNabavniAkcijski);
            this.Controls.Add(this.pnlPrijenosCjenika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPoruka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruka";
            this.Load += new System.EventHandler(this.frmPoruka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPrijenosCjenika.ResumeLayout(false);
            this.pnlPrijenosCjenika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlNabavniAkcijski.ResumeLayout(false);
            this.pnlNabavniAkcijski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlMPCakcija.ResumeLayout(false);
            this.pnlMPCakcija.PerformLayout();
            this.pnlArtiklCSV.ResumeLayout(false);
            this.pnlArtiklCSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPrijenosCjenika;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlNabavniAkcijski;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlMPCakcija;
        private System.Windows.Forms.Panel pnlArtiklCSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}