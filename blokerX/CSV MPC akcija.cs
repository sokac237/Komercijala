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
    public partial class frmCSVMPCakcija : Form
    {
        DataTable podaciOartiklu = new DataTable();

        int brojac;

        public string sifra;
        public string nazivArtikla;
        string Barkod;

        string sifraArtikla;
        string sifrakodDobavljaca;
        string sifrapartnera;
        string partnerID;
        string proizvodjacID;
        string artiklID;

        decimal cijenaA;
        decimal cijenaB;
        decimal cijenaC;
        decimal cijenaD;
        decimal cijenaX;
        decimal letak;


        string napomena;
        string greska;


        Upiti veza = new Upiti();
        string _idcjenik;

        public frmCSVMPCakcija()
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

        private void frmCSVMPCakcija_Load(object sender, EventArgs e)
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
            public string sifrakodDobavljaca = "";
            [FieldOptional]
            public string cijenaA;
            [FieldOptional]
            public string cijenaB;
            [FieldOptional]
            public string cijenaC;
            [FieldOptional]
            public string cijenaD;
            [FieldOptional]
            public string cijenaX;

            [FieldOptional]
            public string letak;
            [FieldOptional]
            public string napomena;
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
            tablica.Columns.Add("CijenaA", typeof(decimal));
            tablica.Columns.Add("CijenaB", typeof(decimal));
            tablica.Columns.Add("CijenaC", typeof(decimal));
            tablica.Columns.Add("CijenaD", typeof(decimal));
            tablica.Columns.Add("CijenaX", typeof(decimal));
            tablica.Columns.Add("Letak", typeof(decimal));
            tablica.Columns.Add("Napomena", typeof(string));
            tablica.Columns.Add("Greška", typeof(string));


            foreach (myCSVFile row in result)
            {
                greska = "";
                Barkod = row.Barkod;
                sifra = row.sifra;
                sifrakodDobavljaca = row.sifrakodDobavljaca;

                if (Barkod == "" && sifra == "" && sifrakodDobavljaca == "")
                { 
                //preskoci sve
                }
                else
                {

                    dohvatiSifraNaziv();

                    if (row.cijenaA != "")
                    {
                        cijenaA = Convert.ToDecimal(row.cijenaA);
                    }
                    else
                    {
                        cijenaA = 0;
                        greska = "Neispravna cijena";
                    }

                    if (row.cijenaB != "")
                    {
                        cijenaB = Convert.ToDecimal(row.cijenaB);
                    }
                    else
                    {
                        cijenaB = 0;
                        greska = "Neispravna cijena";
                    }

                    if (row.cijenaC != "")
                    {
                        cijenaC = Convert.ToDecimal(row.cijenaC);
                    }
                    else
                    {
                        cijenaC = 0;
                        greska = "Neispravna cijena";
                    }

                    if (row.cijenaD != "")
                    {
                        cijenaD = Convert.ToDecimal(row.cijenaD);
                    }
                    else
                    {
                        cijenaD = 0;
                        greska = "Neispravna cijena";
                    }

                    if (row.cijenaX != "")
                    {
                        cijenaX = Convert.ToDecimal(row.cijenaX);
                    }
                    else
                    {
                        cijenaX = 0;
                        greska = "Neispravna cijena";
                    }

                    if (row.letak != "")
                    {
                        letak = Convert.ToDecimal(row.letak);
                    }
                    else
                    {
                        letak = 0;
                    }

                    if (row.napomena != "")
                    {
                        napomena = row.napomena.ToString();
                    }
                    else
                    {
                        napomena = "";
                    }

                    tablica.Rows.Add(row.Barkod, sifra, nazivArtikla, cijenaA, cijenaB, cijenaC, cijenaD, cijenaX, letak, napomena, greska);
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
                    veza.ExecuteQuery("select artikl.ar_sifra, artikl.ar_naziv from artikl where artikl.ar_sifra = " + sifra + "", ref podaciOartiklu);


                    if (podaciOartiklu.Rows.Count > 0)
                    {
                        sifra = podaciOartiklu.Rows[0][0].ToString();
                        nazivArtikla = podaciOartiklu.Rows[0][1].ToString();
                        podaciOartiklu.Clear();

                    }
                    else if (sifrakodDobavljaca != "" && partnerID != "")
                    {
                        //provjeri sifru kod dobavljaca
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

        private void dgPodaci_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string sifra = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Šifra"]);
                string cijenaA = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CijenaA"]);
                string cijenaB = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CijenaB"]);
                string cijenaC = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CijenaC"]);
                string cijenaD = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CijenaD"]);
                string cijenaX = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CijenaX"]);





                if (sifra == "" /*|| cijenaA == "0" || cijenaB == "0" || cijenaC == "0" || cijenaD == "0" || cijenaX == "0" */)
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

                              
                                string cijenaA = Convert.ToString(row[3]).Replace(',', '.');
                                string cijenaB = Convert.ToString(row[4]).Replace(',', '.');
                                string cijenaC = Convert.ToString(row[5]).Replace(',', '.');
                                string cijenaD = Convert.ToString(row[6]).Replace(',', '.');
                                string cijenaX = Convert.ToString(row[7]).Replace(',', '.');

                                string letak = Convert.ToString(row[8]).Replace(',', '.');

                                string napomena = row[9].ToString();


                                dohvatiPodatke();

                                //provjeri postoji li za odabrani cjenik artikl već dodan

                                DataTable podaci = new DataTable();

                                veza.ExecuteQuery("select artikl_ar_ID from prodajnistavka, prodajnicjenik where prodajnistavka.artikl_ar_ID = '" + artiklID + "' and prodajnicjenik.prc_ID = " + _idcjenik + " and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID", ref podaci);

                                if (podaci.Rows.Count == 0) //insert
                                {
                                    string Upit;
                                    string upit2;

                                    Upit = "insert into prodajnistavka (prodajnicjenik_prc_ID, artikl_ar_ID ";
                                    upit2 = "values (" + _idcjenik + ", " + artiklID + "";

                                    if (cijenaA != "0")
                                    {
                                        Upit = Upit + " , prc_tipa";
                                        upit2 = upit2 + " , '" + cijenaA + "'";
                                    }

                                    if (cijenaB != "0")
                                    {
                                        Upit = Upit + " , prc_tipb";
                                        upit2 = upit2 + " , '" + cijenaB + "'";
                                    }

                                    if (cijenaC != "0")
                                    {
                                        Upit = Upit + " , prc_tipc";
                                        upit2 = upit2 + " , '" + cijenaC + "'";
                                    }

                                    if (cijenaD != "0")
                                    {
                                        Upit = Upit + " , prc_tipd";
                                        upit2 = upit2 + " , '" + cijenaD + "'";
                                    }

                                    if (cijenaX != "0")
                                    {
                                        Upit = Upit + " , prc_tipx";
                                        upit2 = upit2 + " , '" + cijenaX + "'";
                                    }

                                    if (letak != "0")
                                    {
                                        Upit = Upit + " , prc_letak";
                                        upit2 = upit2 + " , '" + letak + "'";
                                    }


                                    if (partnerID != "")
                                    {
                                        Upit = Upit + " , partner_pa_id";
                                        upit2 = upit2 + " , " + partnerID + "";
                                    }


                         
                                        Upit = Upit + " , prc_napomena)";
                                        upit2 = upit2 + " , '" + napomena + "')";
                                    


                                   
                                    //dodaj operater na kraju

                                    //Upit = Upit + " , operater_op_ID)";
                                    //upit2 = upit2 + " , " + Global.KorisnikID + ")";

                                    string CijeliUpit = Upit + upit2;
          

                                    veza.ExecuteQuery("" + CijeliUpit + "");

                                   
                                }
                                else //update
                                {
                                    string Upit;


                                    if (partnerID == "")
                                    {
                                        partnerID = "default";
                                    }

                                    Upit = "update prodajnistavka set prc_tipa = '" + cijenaA + "', prc_tipb = '" + cijenaB + "' , prc_tipc = '" + cijenaC + "', prc_tipd = '" + cijenaD + "', prc_tipx = '" + cijenaX + "', prc_letak ='"+letak+"', prc_napomena = '"+napomena+"', partner_pa_id = "+partnerID+" where prodajnicjenik_prc_ID = " + _idcjenik + " and artikl_ar_ID = " + artiklID + "";
                                    //MessageBox.Show("update prodajnistavka set prc_tipa = '" + cijenaA + "', prc_tipb = '" + cijenaB + "' , prc_tipc = '" + cijenaC + "', prc_tipd = '" + cijenaD + "', prc_tipx = '" + cijenaX + "', prc_letak ='" + letak + "', prc_napomena = '" + napomena + "', partner_pa_id = " + partnerID + " where prodajnicjenik_prc_ID = " + _idcjenik + " and artikl_ar_ID = " + artiklID + "");
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

        private void frmCSVMPCakcija_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                frmPoruka UForm = null;
                if ((UForm = (frmPoruka)IsFormAlreadyOpen(typeof(frmPoruka))) == null)
                {
                    frmPoruka _frm = new frmPoruka();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.vrstaCSVa = "MPCA";
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
