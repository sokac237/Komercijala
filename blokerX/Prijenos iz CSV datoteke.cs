using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FileHelpers;
using DevExpress.XtraGrid.Views.Grid;
using blokirajx;


namespace blokerX
{
    public partial class frmPrijenosIzCSVDatoteke : Form
    {
        Upiti veza = new Upiti();

        DataTable podaciOartiklu = new DataTable();

        int brojac;

        public string sifra;
        public string nazivArtikla;
        string Barkod;

        string sifraArtikla;
        string sifraKodDobavljaca;
        string sifrapartnera;
        string partnerID;
        string proizvodjacID;
        string artiklID;

        decimal cijena;
        decimal rabat;
        decimal akcCijena;
        decimal akcRabat;

        string Konsignacija;

        string datumOdProvjera;
        string datumDoProvjera;


        public frmPrijenosIzCSVDatoteke()
        {
            InitializeComponent();
        }

        private void frmPrijenosIzCSVDatoteke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
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

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IDpartnera = Convert.ToInt32(glDobavljac.EditValue);
                this.nabavnicjenikTableAdapter.Fill(this.cjenikDobavljacaCSV.nabavnicjenik, IDpartnera);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.EditValue.ToString() != "" && glCjenik.EditValue.ToString() != "" && txtPutanja.Text != "")
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);

                            if (row != null)
                            {
                                sifraArtikla = row[1].ToString();
                                sifraKodDobavljaca = row[10].ToString();

                                if (row[11].ToString() != "")
                                {
                                    Konsignacija = row[11].ToString();
                                }
                                else
                                {
                                    Konsignacija = "";
                                }

                                

                                if (sifraKodDobavljaca == "")
                                {
                                    sifraKodDobavljaca = "";
                                }

                                sifrapartnera = row[9].ToString();

                                string cijena = Convert.ToString(row[3]).Replace(',', '.');
                                string rabat = Convert.ToString(row[4]).Replace(',', '.');
                                string akcCijena = Convert.ToString(row[5]).Replace(',', '.');
                                string akcRabat = Convert.ToString(row[6]).Replace(',', '.');

                                dohvatiPodatke();

                                if (artiklID != "" && proizvodjacID != "")
                                {

                                    string Upit;
                                    string upit2;
                                    string upit3;

                                    Upit = "update artikl set partneri_PA_ID = " + proizvodjacID + "";
                                    if (Konsignacija != "")
                                    {
                                        upit2 = ",ar_konsignacija = '" + Konsignacija + "' ";
                                    }
                                    else
                                    {
                                        upit2 = "";
                                    }
                                   
                                    upit3 =  " where ar_ID = " + artiklID + "";

                                    string CijeliUpit = Upit + upit2+ upit3;
                                    //MessageBox.Show(CijeliUpit);

                                    veza.ExecuteQuery(CijeliUpit);


                                    //MessageBox.Show("update artikl set partneri_PA_ID = " + proizvodjacID + " where ar_ID = " + artiklID + "");
                                    //veza.ExecuteQuery("update artikl set partneri_PA_ID = " + proizvodjacID + ", ar_konsignacija = '"+ Konsignacija +"' where ar_ID = " + artiklID + "");
                                }

                                //provjeri postoji li za odabrani cjenik artikl već dodan

                                DataTable podaci = new DataTable();

                                veza.ExecuteQuery("select artikl_ar_ID from nabavnistavka, nabavnicjenik where nabavnistavka.artikl_ar_ID = '" + artiklID + "' and nabavnicjenik.nac_ID = " + glCjenik.EditValue + " and nabavnicjenik.partneri_PA_ID = " + proizvodjacID + " and nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID",ref podaci);

                                if (podaci.Rows.Count == 0) //insert
                                {
                                    string Upit;
                                    string upit2;

                                    Upit = "insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID ";
                                    upit2 = "values (" + glCjenik.EditValue + ", " + artiklID + "";

                                    if (cijena != "0")
                                    {
                                        Upit = Upit + " , nas_tvornickacijena";
                                        upit2 = upit2 + " , '" + cijena + "'";
                                    }

                                    if (rabat != "0")
                                    {
                                        Upit = Upit + " , nas_postorabata";
                                        upit2 = upit2 + " , '" + rabat + "'";
                                    }

                                    if (akcCijena != "0")
                                    {
                                        Upit = Upit + " , nas_akcijskacijena";
                                        upit2 = upit2 + ", '" + akcCijena + "'";
                                    }

                                    if (akcRabat != "0")
                                    {
                                        Upit = Upit + " , nas_akcijskirabat";
                                        upit2 = upit2 + " , '" + akcRabat + "'";
                                    }

                                    //dodaj operater na kraju

                                    Upit = Upit + " , operater_op_ID)";
                                    upit2 = upit2 + " , " + Global.KorisnikID + ")";

                                    string CijeliUpit = Upit + upit2;
                                    //MessageBox.Show(CijeliUpit);

                                    veza.ExecuteQuery(""+CijeliUpit+"");

                                    //if (partnerID != "" && artiklID != "")
                                    //{
                                    //    //insert treba
                                    //    veza.ExecuteQuery("insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID, nas_tvornickacijena, nas_postorabata, nas_akcijskacijena, nas_akcijskirabat, operater_op_ID) values ('" + glCjenik.EditValue + "', " + artiklID + ", '" + cijena + "', '" + rabat + "', '" + akcCijena + "', '" + akcRabat + "', " + Global.KorisnikID + ")");
                                    //}


                                    //if (artiklID != "" && partnerID != "")
                                    //{
                                    //    Upit = "update dobavljacartikl set doa_tvornickacijena = '" + cijena + "', doa_postorabata = '" + rabat + "'";

                                    //    if (sifraKodDobavljaca != "")
                                    //    {
                                    //        Upit = Upit + ",doa_sifraKodDobavljaca = " + "'" + sifraKodDobavljaca + "'";
                                    //    }

                                    //    Upit = Upit + " where artikl_ar_ID = " + artiklID + " and partneri_pa_ID = " + partnerID + "";

                                    //    CijeliUpit = Upit;

                                    //    veza.ExecuteQuery("" + CijeliUpit + "");


                                    //    //MessageBox.Show("update dobavljacartikl set doa_sifraKodDobavljaca = '" + sifraKodDobavljaca + "' where artikl_ar_ID = " + artiklID + " and partneri_pa_ID = " + partnerID + " ");
                                    //    //veza.ExecuteQuery("update dobavljacartikl set doa_sifraKodDobavljaca = '" + sifraKodDobavljaca + "', doa_tvornickacijena = '" + cijena + "', doa_postorabata = '" + rabat + "' where artikl_ar_ID = " + artiklID + " and partneri_pa_ID = " + partnerID + " ");
                                    //}
                                }
                                else //update
                                {
                                    string Upit;

                                    Upit = "update nabavnistavka set nas_tvornickacijena = '" + cijena + "', nas_postorabata = '" + rabat + "' , nas_akcijskacijena ='" + akcCijena + "', nas_akcijskirabat = '" + akcRabat + "', operater_op_ID = " + Global.KorisnikID + " where nabavnicjenik_nac_ID = " + glCjenik.EditValue + " and artikl_ar_ID = " + artiklID + "";
        
                                    veza.ExecuteQuery(""+Upit+"");                                    
                                }


                                if (artiklID != "" && partnerID != "")
                                {
                                    string Upit;
                                    DataTable provjera = new DataTable();

                                    veza.ExecuteQuery("select * from dobavljacartikl where artikl_ar_ID = "+artiklID+" and partneri_pa_ID = "+partnerID+" ", ref provjera);

                                    if (provjera.Rows.Count > 0)
                                    {
                                        //postoji radi update

                                        Upit = "update dobavljacartikl set doa_tvornickacijena = '" + cijena + "', doa_postorabata = '" + rabat + "'";

                                        if (sifraKodDobavljaca != "")
                                        {
                                            Upit = Upit + ",doa_sifraKodDobavljaca = " + "'" + sifraKodDobavljaca + "'";
                                        }

                                        Upit = Upit + " where artikl_ar_ID = " + artiklID + " and partneri_pa_ID = " + partnerID + "";

                                        string CijeliUpit = Upit;

                                        veza.ExecuteQuery("" + CijeliUpit + "");
                                    }
                                    else
                                    {               
                                        //izbij rabat iz tvornicke cijene da dobiješ nabavnu
                                        decimal cij = Convert.ToDecimal(cijena.Replace('.', ','));
                                        decimal rab = Convert.ToDecimal(rabat.Replace('.', ','));
                                        decimal nabcij = cij * (100-rab)/100;
                                        string nabci = Convert.ToString(nabcij).Replace(',', '.');
                                        //nema insertaj
                                        //veza.ExecuteQuery(@"insert into dobavljacartikl (artikl_ar_ID, partneri_pa_ID, doa_nabcij, doa_tvornickacijena, doa_postorabata)  
                                        //values(" + artiklID + ", " + partnerID + ", '" + nabci + "', '" + cijena + "', '" + rabat + "') ");
                                    }
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

        [DelimitedRecord(";")]
        
        public class myCSVFile
        {
            [FieldOptional] public string Barkod = "";
            [FieldOptional] public string cijena;
            [FieldOptional] public string rabat;
            [FieldOptional] public string akcijska;
            [FieldOptional] public string akcrab;
            [FieldOptional] [FieldConverter(ConverterKind.Date, "dd/MM/yyyy")] public DateTime? datum;
            [FieldOptional] [FieldConverter(ConverterKind.Date, "dd/MM/yyyy")] public DateTime? doKada;
            [FieldOptional] public string proizvodjac;
            [FieldOptional] public string sifraKodDobavljaca;
            [FieldOptional] public string konsignacija;

        }

        private void prikaziCSVuGrid()
        { 
            FileHelperEngine engine = new FileHelperEngine(typeof(myCSVFile));

            myCSVFile[] result = engine.ReadFile(txtPutanja.Text) as myCSVFile[];

            DataTable tablica = new DataTable();
            tablica.Columns.Add("Barkod", typeof(string));
            tablica.Columns.Add("Šifra", typeof(string));
            tablica.Columns.Add("Naziv artikla", typeof(string));
            tablica.Columns.Add("Cijena", typeof(decimal));
            tablica.Columns.Add("Rabat", typeof(decimal));
            tablica.Columns.Add("Akcijska cijena", typeof(decimal));
            tablica.Columns.Add("Akcijski rabat", typeof(decimal));
            tablica.Columns.Add("Od kada", typeof(DateTime));
            tablica.Columns.Add("Do kada", typeof(DateTime)); 
            tablica.Columns.Add("Proizvođač", typeof(string));
            tablica.Columns.Add("Šifra art. kod dobavljača", typeof(string));
            tablica.Columns.Add("Artikl na konsignaciji", typeof(string));
            
            foreach(myCSVFile row in result)
            {
                Barkod = row.Barkod;
                dohvatiSifraNaziv();

                if (row.cijena != "")
                {
                    cijena = Convert.ToDecimal(row.cijena);
                }
                else
                {
                    cijena = 0;
                }

                if (row.rabat != "")
                {
                    rabat = Convert.ToDecimal(row.rabat.ToString());
                }
                else
                {
                    rabat = 0;
                }

                if (row.akcijska != "")
                {
                    akcCijena = Convert.ToDecimal(row.akcijska);
                }
                else
                {
                    akcCijena = 0;
                }

                if (row.akcrab != "")
                {
                    akcRabat = Convert.ToDecimal(row.akcrab);
                }
                else
                {
                    akcRabat = 0;
                }

                if (row.konsignacija != "")
                {
                    if (row.konsignacija == "1")
                        Konsignacija = "1";
                    else
                    {
                        Konsignacija = "0";
                    }
                }
                else
                {
                    Konsignacija = "0";
                }



                if (sifra != "")
                {
                    tablica.Rows.Add(row.Barkod, sifra, nazivArtikla, cijena, rabat, akcCijena, akcRabat, row.datum, row.doKada, row.proizvodjac, row.sifraKodDobavljaca, row.konsignacija);
                }
            }
            this.dgCSVPodaci.DataSource = tablica;
        }
              
        

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.EditValue.ToString() != "" && glCjenik.EditValue.ToString() != "" && txtPutanja.Text != "")
                {
                    provjeriDatumCjenika();
                    prikaziCSVuGrid();
                    lblStatus.Text = "";
                    btnPrenesi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void dohvatiSifraNaziv()
        {
            try
            {
                veza.ExecuteQuery("select artikl.ar_sifra, artikl.ar_naziv from artikl, barkod where artikl.ar_ID = barkod.artikl_ar_ID and barkod.bk_kod = '"+Barkod+"'", ref podaciOartiklu);
                
                if (podaciOartiklu.Rows.Count > 0)
                {
                    sifra = podaciOartiklu.Rows[0][0].ToString();
                    nazivArtikla = podaciOartiklu.Rows[0][1].ToString();
                    podaciOartiklu.Clear(); 
                }
                else
                {
                    sifra = "";
                    nazivArtikla = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgArtikl_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string sifra = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Šifra"]);
                string cijena = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Cijena"]);
                //string rabat = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Rabat"]);
                string datumod = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Od kada"]);
                string datumdo = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Do kada"]);
                string konsignacija = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Artikl na konsignaciji"]);

                if (datumod == "")
                {
                    datumOdProvjera = "";
                }

                if (datumdo == "")
                {
                    datumDoProvjera = "";
                }

                if (sifra == "" || cijena == "" || /*rabat == "" ||*/ datumOdProvjera != datumod || datumDoProvjera != datumdo)
                {
                    e.Appearance.ForeColor = Color.Red;

                    lblStatus.Text = "Imate stavki koje nisu dobro formatirane. Ispravite pogreške pa ponovo unesite *.csv file.";

                    if (lblStatus.Text != "")
                    {
                        btnPrenesi.Enabled = false;
                    }
                }


                if(konsignacija != "")
                {
                    if (konsignacija != "1" && konsignacija != "0")
                    {
                        e.Appearance.ForeColor = Color.Red;

                        lblStatus.Text = "Imate stavki koje nisu dobro formatirane. Ispravite pogreške pa ponovo unesite *.csv file.";

                        if (lblStatus.Text != "")
                        {
                            btnPrenesi.Enabled = false;
                        }
                    }
                }
                
            }
        }
        private void provjeriDatumCjenika()
        {
            try
            {
                DataTable cjenik = new DataTable();
                string IDcjenika = glCjenik.EditValue.ToString();

                veza.ExecuteQuery("select nabavnicjenik.nac_vaziod, nabavnicjenik.nac_vazido, nabavnicjenik.nac_nivo from nabavnicjenik where nabavnicjenik.nac_ID = '" + IDcjenika + "'", ref cjenik);

                if (cjenik.Rows.Count > 0)
                {
                    datumOdProvjera = Convert.ToDateTime(cjenik.Rows[0][0]).ToString("dd.MM.yyyy.");
                    
                    if (cjenik.Rows[0][1].ToString() != "")
                    {
                        datumDoProvjera = Convert.ToDateTime(cjenik.Rows[0][1]).ToString("dd.MM.yyyy.");
                    }
                    else
                    {
                        datumDoProvjera = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dohvatiPodatke()
        {
            try
            {
                DataTable partner = new DataTable();
                if (sifrapartnera != "")
                {
                    veza.ExecuteQuery("select pa_ID from partner where pa_sifra =" + sifrapartnera + "", ref partner);
                    if (partner.Rows.Count > 0)
                    {
                        proizvodjacID = partner.Rows[0][0].ToString();
                    }
                }
                else
                {
                    proizvodjacID = glDobavljac.EditValue.ToString();
                }


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

                DataTable Cjenik = new DataTable();
                if (glCjenik.Text != "")
                {
                    veza.ExecuteQuery("select partneri_pa_ID from nabavnicjenik where nac_ID = '"+glCjenik.EditValue+"'", ref Cjenik);
                    if (Cjenik.Rows.Count > 0) 
                    {
                        partnerID = Cjenik.Rows[0][0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPrijenosIzCSVDatoteke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPoruka UForm = null;
                if ((UForm = (frmPoruka)IsFormAlreadyOpen(typeof(frmPoruka))) == null)
                {
                    frmPoruka _frm = new frmPoruka();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.vrstaCSVa = "C";
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

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }
    }
}
