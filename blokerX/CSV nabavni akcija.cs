using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileHelpers;
using DevExpress.XtraGrid.Views.Grid;
using blokirajx;

namespace blokerX
{
    public partial class frmCSVnabavniakcija : Form
    {
        Upiti veza = new Upiti();


        DataTable podaciOartiklu = new DataTable();

        int brojac;
        public string sifrakodDobavljaca;
        public string sifra;
        public string nazivArtikla;
        string Barkod;

        string partnerID;
        string _idcjenik;



        decimal VPC;
        decimal NC;
        decimal Rabat;
        decimal Akc_Rabat;
        decimal povecanje;

        string sifraArtikla;
        string artiklID;

        string greska;

        public frmCSVnabavniakcija()
        {
            InitializeComponent();
        }


        public string IDcjenika
        {
            get { return _idcjenik; }
            set { _idcjenik = value; }
        }

        public string IDpartnera
        {
            get { return partnerID; }
            set { partnerID = value; }
        }

        private void frmCSVnabavniakcija_Load(object sender, EventArgs e)
        {
            txtCjenikBroj.Text = _idcjenik;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();

            openFileDialogCSV.InitialDirectory = Application.ExecutablePath.ToString();
            openFileDialogCSV.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialogCSV.FilterIndex = 1;
            openFileDialogCSV.RestoreDirectory = true;

            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                this.txtPutanja.Text = openFileDialogCSV.FileName.ToString();
            }
        }



        [DelimitedRecord(";")]

        public class myCSVFile
        {
            [FieldOptional]
            public string Barkod = "";
            [FieldOptional]
            public string sifra = "";
            [FieldOptional]
            public string sifraKodDobavljaca = "";
            [FieldOptional]
            public string VPC;
            [FieldOptional]
            public string Rabat;
            [FieldOptional]
            public string Akc_Rabat;
            [FieldOptional]
            public string NC;
            [FieldOptional]
            public string Povecanje;
            [FieldOptional]
            public string greska;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPutanja.Text != "")
                {
                    prikaziCSVuGrid();
                    lblStatus.Text = "";
                    btnPrenesi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            } 
        }


        private void prikaziCSVuGrid()
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(myCSVFile));

            myCSVFile[] result = engine.ReadFile(txtPutanja.Text) as myCSVFile[];

            DataTable tablica = new DataTable();
            tablica.Columns.Add("Barkod", typeof(string));
            tablica.Columns.Add("Šifra", typeof(string));
            tablica.Columns.Add("Naziv artikla", typeof(string));
            tablica.Columns.Add("VPC", typeof(decimal));
            tablica.Columns.Add("Rabat", typeof(decimal));
            tablica.Columns.Add("Akc_Rabat", typeof(decimal));
            tablica.Columns.Add("NC", typeof(decimal));
            tablica.Columns.Add("Povecanje", typeof(decimal));
            tablica.Columns.Add("Greška", typeof(string));


            foreach (myCSVFile row in result)
            {
                greska = "";
                Barkod = row.Barkod;

                sifra = row.sifra;
                sifrakodDobavljaca = row.sifraKodDobavljaca;

                if (Barkod == "" && sifra == "" && sifrakodDobavljaca == "")
                {
                    //preskoci
                }
                else
                {
                    dohvatiSifraNaziv();

                    if (row.VPC != "")
                    {
                        VPC = Convert.ToDecimal(row.VPC);
                    }
                    else
                    {
                        VPC = 0;
                    }



                    if (row.NC != "")
                    {
                        NC = Convert.ToDecimal(row.NC);

                        if (row.Rabat != "")
                        {
                            Rabat = Convert.ToDecimal(row.Rabat);
                        }
                        else
                        {
                            Rabat = 0;
                        }

                        if (row.Akc_Rabat != "")
                        {
                            Akc_Rabat = Convert.ToDecimal(row.Akc_Rabat);
                        }
                        else
                        {
                            Akc_Rabat = 0;
                        }
                    }
                    else
                    {
                        //provjeri rabate i izracunaj NC
                        if (row.Rabat != "")
                        {
                            Rabat = Convert.ToDecimal(row.Rabat);
                        }
                        else
                        {
                            Rabat = 0;
                            greska = "Neispravan rabat";
                        }

                        if (row.Akc_Rabat != "")
                        {
                            Akc_Rabat = Convert.ToDecimal(row.Akc_Rabat);
                        }
                        else
                        {
                            Akc_Rabat = 0;
                            greska = "Neispravan akcijski rabat";
                        }



                        if (row.VPC != "")
                        {
                            VPC = Convert.ToDecimal(row.VPC);
                        }
                        else
                        {
                            VPC = 0;
                            greska = "Neispravna VPC cijena";
                        }





                        if (Rabat != 0 && Akc_Rabat != 0 && VPC != 0)
                        {
                            //preracunaj NC po formuli

                            //NC = VPC * ((100 - Rabat)/100) * ((100-Akc_Rabat)/100)

                            NC = Math.Round(VPC * ((100 - Rabat) / 100) * ((100 - Akc_Rabat) / 100), 5);
                        }
                        else
                        {
                            NC = 0;
                        }
                    }

                    if (row.Povecanje != "")
                    {
                        povecanje = Convert.ToDecimal(row.Povecanje);
                    }
                    else
                    {
                        povecanje = 0;
                    }



                    tablica.Rows.Add(row.Barkod, sifra, nazivArtikla, VPC, Rabat, Akc_Rabat, NC, povecanje, greska);
                    sifra = "";
                    nazivArtikla = "";

                }
                this.dgCSVPodaci.DataSource = tablica;
            }
        }

        private void dohvatiSifraNaziv()
        {
            //ovisno o barkodu, šifri artikla i šifri kod dobavljača
            try
            {
                veza.ExecuteQuery("select artikl.ar_sifra, artikl.ar_naziv from artikl, barkod where artikl.ar_ID = barkod.artikl_ar_ID and barkod.bk_kod = '" + Barkod + "'", ref podaciOartiklu);

                if (podaciOartiklu.Rows.Count > 0)
                {
                    sifra = podaciOartiklu.Rows[0][0].ToString();
                    nazivArtikla = podaciOartiklu.Rows[0][1].ToString();
                    podaciOartiklu.Clear();
                }
                else
                {

                    //pogledaj prema sifri kod nas
                    veza.ExecuteQuery("select artikl.ar_sifra, artikl.ar_naziv from artikl where artikl.ar_sifra = '" + sifra + "'", ref podaciOartiklu);


                    if (podaciOartiklu.Rows.Count > 0)
                    {
                        sifra = podaciOartiklu.Rows[0][0].ToString();
                        nazivArtikla = podaciOartiklu.Rows[0][1].ToString();
                        podaciOartiklu.Clear();

                    }
                    else
                    {
                        //provjeri prema sifri dobavljaca

                        DataTable sifkoddob = new DataTable();
 
                        veza.ExecuteQuery("select artikl.AR_SIFRA, artikl.AR_NAZIV from artikl left join dobavljacartikl on dobavljacartikl.artikl_ar_ID = artikl.ar_ID where dobavljacartikl.doa_sifraKodDobavljaca='" + sifrakodDobavljaca + "' and dobavljacartikl.partneri_PA_ID='" + partnerID + "'", ref sifkoddob);

                        if (sifkoddob.Rows.Count > 0)
                        {
                            sifra = sifkoddob.Rows[0][0].ToString();
                            nazivArtikla = sifkoddob.Rows[0][1].ToString();
                            greska = "";
                            sifkoddob.Clear();
                        }
                        else
                        {
                            greska = "Barkod / Šifra artikla nisu ispravni";
                            sifra = "";
                            nazivArtikla = "";
                            sifkoddob.Clear();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }


        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }


        private void dohvatiPodatke()
        {
            try
            {

                DataTable artiklPodaci = new DataTable();
                if (sifraArtikla != "")
                {
                    veza.ExecuteQuery("select ar_ID from artikl where ar_sifra = '" + sifraArtikla + "'", ref artiklPodaci);
                    if (artiklPodaci.Rows.Count > 0)
                    {
                        artiklID = artiklPodaci.Rows[0][0].ToString();
                    }
                }
                else
                {
                    artiklID = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPodaci_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
             GridView View = sender as GridView;
             if (e.RowHandle >= 0)
             {
                 string sifra = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Šifra"]);
                 string VPC = View.GetRowCellDisplayText(e.RowHandle, View.Columns["VPC"]);
                 string Rabat = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Rabat"]);
                 string Akc_Rabat = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Akc_Rabat"]);
                 string NC = View.GetRowCellDisplayText(e.RowHandle, View.Columns["NC"]);



                 if (sifra == "" || NC=="0" /*rabat == "" ||*/)
                 {
                     e.Appearance.ForeColor = Color.Red;

                     View.Appearance.Row.ForeColor = Color.Red;

                     lblStatus.Text = "Imate stavki koje nisu dobro formatirane. Ispravite pogreške pa ponovo unesite *.csv file.";

                     if (lblStatus.Text != "")
                     {
                         btnPrenesi.Enabled = false;
                     }
                 }
             }
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCjenikBroj.Text != "" && txtPutanja.Text != "")
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                sifraArtikla = row[1].ToString();


                                string VPC = Convert.ToString(row[3]).Replace(',', '.');
                                string Rabat = Convert.ToString(row[4]).Replace(',', '.');
                                string Akc_Rabat = Convert.ToString(row[5]).Replace(',', '.');
                                string NC = Convert.ToString(row[6]).Replace(',', '.');
                                string povecanje = Convert.ToString(row[7]).Replace(',', '.');

                                dohvatiPodatke();

                                //provjeri postoji li za odabrani cjenik artikl već dodan

                                DataTable podaci = new DataTable();
                              
                                veza.ExecuteQuery("select artikl_ar_ID from nabavnistavka, nabavnicjenik where nabavnistavka.artikl_ar_ID = '" + artiklID + "' and nabavnicjenik.nac_ID = " + _idcjenik+ " and nabavnicjenik.partneri_PA_ID = " + partnerID + " and nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID", ref podaci);

                                if (podaci.Rows.Count == 0) //insert
                                {
                                    string Upit;
                                    string upit2;

                                    Upit = "insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID ";
                                    upit2 = "values (" + _idcjenik + ", " + artiklID + "";

                                    if (VPC != "0")
                                    {
                                        Upit = Upit + " , nas_tvornickacijena";
                                        upit2 = upit2 + " , '" + VPC + "'";
                                    }

                                    if (Rabat != "0")
                                    {
                                        Upit = Upit + " , nas_postorabata";
                                        upit2 = upit2 + " , '" + Rabat + "'";
                                    }

                                    if (NC != "0")
                                    {
                                        Upit = Upit + " , nas_akcijskacijena";
                                        upit2 = upit2 + ", '" + NC + "'";
                                    }

                                    if (Akc_Rabat != "0")
                                    {
                                        Upit = Upit + " , nas_akcijskirabat";
                                        upit2 = upit2 + " , '" + Akc_Rabat + "'";
                                    }

                                    if (povecanje != "0")
                                    {
                                        Upit = Upit + " , nas_maxkoeficijent";
                                        upit2 = upit2 + " , '" + povecanje + "'";
                                    }

                                    //dodaj operater na kraju

                                    Upit = Upit + " , operater_op_ID)";
                                    upit2 = upit2 + " , " + Global.KorisnikID + ")";

                                    string CijeliUpit = Upit + upit2;
                                    //MessageBox.Show(CijeliUpit);

                                    veza.ExecuteQuery("" + CijeliUpit + "");


                                }
                                else //update
                                {
                                    string Upit;

                                    Upit = "update nabavnistavka set nas_tvornickacijena = '" + VPC + "', nas_postorabata = '" + Rabat + "' , nas_akcijskacijena ='" + NC + "', nas_akcijskirabat = '" + Akc_Rabat + "', operater_op_ID = " + Global.KorisnikID + ", nas_maxkoeficijent = '"+povecanje+"' where nabavnicjenik_nac_ID = " + _idcjenik + " and artikl_ar_ID = " + artiklID + "";

                                    veza.ExecuteQuery("" + Upit + ""); 
                                }
                            }

                        }
                        MessageBox.Show("Uspješno ste ažurirali podatke");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCSVnabavniakcija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPoruka UForm = null;
                if ((UForm = (frmPoruka)IsFormAlreadyOpen(typeof(frmPoruka))) == null)
                {
                    frmPoruka _frm = new frmPoruka();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.vrstaCSVa = "NCA";
                    _frm.Show();
                }
                else
                {
                    UForm.Focus();
                    return;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
