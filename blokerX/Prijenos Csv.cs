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
    public partial class frmPrijenosCSV : Form
    {
        Upiti veza = new Upiti();

        DataTable podaciOartiklu = new DataTable();
        DataTable podaciORobmaMarka = new DataTable();
        DataTable podaciOProizvodjacu = new DataTable();
        DataTable podaciOGlavnomDobavljacu = new DataTable();

        string Barkod;
        public string nazivArtikla;
        string Sifra;
        string jedinicaMjere;
        string brand;
        string proizvodjac;
        string glavniDobavljac;
        Boolean nepoznato;
        string artiklID;
        string brandID;
        string proizvodjacID;
        string glavniDobavljacID;

        decimal U_jmj;
        decimal sirina;
        decimal dubina;
        decimal visina;


        string rm_sifra;
        string proizvodjacSifra;
        string glavniDobavljacSifra;

        int brojac;

        public frmPrijenosCSV()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // retrieve the name of the selected folder
                string foldername = this.openFileDialog1.FileName;

                // print the folder name on a label
                this.txtPutanja.Text = foldername;
            }
            else
            {
                this.txtPutanja.Text = "";
            }
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
                MessageBox.Show(ex.Message);
            }       
        }

        [DelimitedRecord(";")]
        private class myCSVFile
        {
            [FieldOptional] public string Barkod = "";
            [FieldOptional] public string Sifra = "";
            [FieldOptional] public string dubina = "";
            [FieldOptional] public string sirina = "";
            [FieldOptional] public string visina = "";
            [FieldOptional] public string Ujmj = "";
            [FieldOptional] public string Jmj = "";
            [FieldOptional] public string Brand = "";
            [FieldOptional] public string proizvodjac = "";
            [FieldOptional] public string glavniDobavljac = "";
        }

        private void prikaziCSVuGrid()
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(myCSVFile));

            myCSVFile[] result = engine.ReadFile(txtPutanja.Text) as myCSVFile[];

            DataTable tablica = new DataTable();
            tablica.Columns.Add("Barkod", typeof(string));
            tablica.Columns.Add("Šifra", typeof(string));
            tablica.Columns.Add("Naziv artikla", typeof(string));
            tablica.Columns.Add("Dubina", typeof(decimal));
            tablica.Columns.Add("Širina", typeof(decimal));
            tablica.Columns.Add("Visina", typeof(decimal));
            tablica.Columns.Add("U jmj", typeof(decimal));
            tablica.Columns.Add("Jed. mj.", typeof(string));
            tablica.Columns.Add("nepoznato", typeof(string));
            tablica.Columns.Add("sifra brand", typeof(string));
            tablica.Columns.Add("Brand", typeof(string));
            tablica.Columns.Add("Sifra proizvodjac", typeof(string));
            tablica.Columns.Add("Proizvođač", typeof(string));
            tablica.Columns.Add("Sifra glavni dobavljac", typeof(string));
            tablica.Columns.Add("Glavni dobavljač", typeof(string));

            foreach (myCSVFile row in result)
            {
                nepoznato = false;
                Barkod = row.Barkod;
                Sifra = row.Sifra.PadLeft(6,' ');
                rm_sifra = row.Brand;
                proizvodjacSifra = row.proizvodjac;
                glavniDobavljacSifra = row.glavniDobavljac;

                dohvatiSifraNaziv();

                if (rm_sifra != "")
                {
                    dohvatiRobnaMarkaNaziv();
                }
                else
                {
                    brand = "";
                }

                if (proizvodjacSifra != "")
                {
                    dohvatiProizvodjacNaziv();
                }
                else
                {
                    proizvodjac = "";
                }


                if (glavniDobavljacSifra != "")
                {
                    dohvatiGlavniDobavljacNaziv();
                }
                else
                {
                    glavniDobavljac = "";
                }

                if (row.dubina != "")
                {
                    dubina = Convert.ToDecimal(row.dubina);
                }
                else
                {
                    dubina = 0; 
                }

                if (row.sirina != "")
                {
                    sirina = Convert.ToDecimal(row.sirina);
                }
                else
                { 
                    sirina = 0; 
                }

                if (row.Ujmj != "")
                {
                    U_jmj = Convert.ToDecimal(row.Ujmj);
                }
                else
                {
                    U_jmj = 0; 
                }

                if (row.visina != "")
                {
                    visina = Convert.ToDecimal(row.visina);
                }
                else
                {
                    visina = 0;
                }

                tablica.Rows.Add(row.Barkod, Sifra, nazivArtikla, dubina, sirina, visina, U_jmj, row.Jmj, nepoznato, row.Brand, brand, row.proizvodjac, proizvodjac, row.glavniDobavljac, glavniDobavljac);
            }
            this.dgCSVPodaci.DataSource = tablica;
        }

        private void dohvatiSifraNaziv()
        {
            try
            {
                //prvo provjeri barcode
                 veza.ExecuteQuery("select artikl.ar_sifra, artikl.ar_naziv from artikl, barkod where artikl.ar_ID = barkod.artikl_ar_ID and barkod.bk_kod = '" + Barkod + "'", ref podaciOartiklu);

                 if (podaciOartiklu.Rows.Count > 0)
                 {
                     Sifra = podaciOartiklu.Rows[0][0].ToString();
                     nazivArtikla = podaciOartiklu.Rows[0][1].ToString();
                     podaciOartiklu.Clear();
                 }
                 else
                 {
                     veza.ExecuteQuery("select artikl.ar_naziv, ar_ID from artikl where artikl.ar_sifra = '" + Sifra + "'", ref podaciOartiklu);
                     if (podaciOartiklu.Rows.Count > 0)
                     {
                         nazivArtikla = podaciOartiklu.Rows[0][0].ToString();
                         artiklID = podaciOartiklu.Rows[0][1].ToString();
                         //nepoznato = false;
                         podaciOartiklu.Clear();
                     }
                     else
                     {
                         nazivArtikla = "";
                         nepoznato = true;
                     }
                 } 
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }

        private void dohvatiProizvodjacNaziv()
        {
            try
            {
                veza.ExecuteQuery("select pa_naziv, pa_ID from partner where pa_sifra = '" + proizvodjacSifra + "'", ref podaciOProizvodjacu);
                if (podaciOProizvodjacu.Rows.Count > 0)
                {
                    proizvodjac = podaciOProizvodjacu.Rows[0][0].ToString();
                    proizvodjacID = podaciOProizvodjacu.Rows[0][1].ToString();
                    //nepoznato = false;
                    podaciOProizvodjacu.Clear();
                }
                else
                {
                    proizvodjac = "";
                    nepoznato = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dohvatiGlavniDobavljacNaziv()
        {
            try
            {
                veza.ExecuteQuery("select pa_naziv, pa_ID from partner where pa_sifra = '" + glavniDobavljacSifra + "'", ref podaciOGlavnomDobavljacu);
                if (podaciOGlavnomDobavljacu.Rows.Count > 0)
                {
                    glavniDobavljac = podaciOGlavnomDobavljacu.Rows[0][0].ToString();
                    glavniDobavljacID = podaciOGlavnomDobavljacu.Rows[0][1].ToString();
                    //nepoznato = false;
                    podaciOGlavnomDobavljacu.Clear();
                }
                else
                {
                    glavniDobavljac = "";
                    nepoznato = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dohvatiRobnaMarkaNaziv()
        {
            try
            {
                veza.ExecuteQuery("select rm_naziv , rm_id from robnamarka where rm_sifra = '" + rm_sifra + "'", ref podaciORobmaMarka);
                if (podaciORobmaMarka.Rows.Count > 0)
                {
                    brand = podaciORobmaMarka.Rows[0][0].ToString();
                    brandID = podaciORobmaMarka.Rows[0][1].ToString();
                    //nepoznato = false;
                    podaciORobmaMarka.Clear();
                }
                else
                {
                    brand = "";
                    nepoznato = true;
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
                string nepoznato = View.GetRowCellDisplayText(e.RowHandle, View.Columns["nepoznato"]);                              
   
                if (nepoznato == "True")
                {
                    e.Appearance.ForeColor = Color.Red;

                    lblStatus.Text = "Imate stavki koje nisu dobro formatirane. Ispravite pogreške pa ponovo unesite *.csv file.";

                    if (lblStatus.Text != "")
                    {
                        //btnPrenesi.Enabled = false;
                    }
                }
            }
        }

        public static string OdreziDesno(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);

            return result;
        }



        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPutanja.Text != "")
                {
                    if (dgPodaci.RowCount > 0)
                    {
                        for (brojac = 0; brojac < dgPodaci.RowCount; brojac++)
                        {
                            System.Data.DataRow row = dgPodaci.GetDataRow(brojac);
                            //string a = row["nepoznato"].ToString();
                            if (row != null && row["nepoznato"].ToString() != "True")
                            {
                                nazivArtikla = row[2].ToString();
                                Sifra = row[1].ToString();
                                rm_sifra = row[9].ToString();
                                proizvodjacSifra = row[11].ToString();
                                glavniDobavljacSifra = row[13].ToString();

                                if (Sifra.Length == 6)
                                {
                                    //return;
                                }
                                else
                                {
                                    Sifra = Sifra.PadLeft(6,' ');
                                }
                                DohvatiSifruID dohvati = new DohvatiSifruID();
                                artiklID = dohvati.DohvatiIDSifra("ar_ID","artikl","ar_sifra = '"+Sifra+"'");
                                jedinicaMjere = row[7].ToString();
                                string dubina = Convert.ToString(row[3]).Replace(',', '.');
                                string sirina = Convert.ToString(row[4]).Replace(',', '.');
                                string visina = Convert.ToString(row[5]).Replace(',', '.');
                                string U_jmj = Convert.ToString(row[6]).Replace(',', '.');                                
                                

                                string upit;
                                upit = "update artikl set";

                                if (U_jmj != "0")
                                {
                                    upit = upit + " ar_tezina = '" + U_jmj + "'";
                                }

                                if (dubina != "0")
                                {

                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " ar_duzina = '" + dubina + "'";
                                    }
                                    else
                                    {
                                        upit = upit + " , ar_duzina = '"+dubina+"'";
                                    }
                                }

                                if (sirina != "0")
                                {
                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " ar_sirina = '"+sirina+"'";
                                    }
                                    else
                                    { 
                                        upit = upit + " , ar_sirina = '"+sirina+"'";
                                    }
                                }

                                if (visina != "0")
                                {
                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " ar_visina = '" + visina + "'";
                                    }
                                    else
                                    {
                                        upit = upit + " , ar_visina = '" + visina + "'";
                                    }
                                }

                                if (jedinicaMjere != "")
                                {
                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " jedinicaMjere_JM_SIFRA_pre = '" + jedinicaMjere + "'";
                                    }
                                    else
                                    {
                                        upit = upit + " , jedinicaMjere_JM_SIFRA_pre = '" + jedinicaMjere + "'";
                                    }
                                }

                                if (rm_sifra != "")
                                {
                                    brandID = dohvati.DohvatiIDSifra("rm_ID", "robnamarka", "rm_sifra = '" + rm_sifra + "'");

                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " robnaMarka_rm_ID = '" + brandID + "'";
                                    }
                                    else
                                    {
                                        upit = upit + " , robnaMarka_rm_ID = '" + brandID + "'";
                                    }
                                }

                                if (proizvodjacSifra != "")
                                {
                                    proizvodjacID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + proizvodjacSifra + "'");
                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " partneri_PA_ID = " + proizvodjacID + "";
                                    }
                                    else
                                    {
                                        upit = upit + " , partneri_PA_ID = " + proizvodjacID + "";
                                    }
                                }


                                if (glavniDobavljacSifra != "")
                                {
                                    glavniDobavljacID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + glavniDobavljacSifra + "'");
                                    if (OdreziDesno(upit, 3) == "set")
                                    {
                                        upit = upit + " partner_pa_iddobavljaca = " + glavniDobavljacID + "";
                                    }
                                    else
                                    {
                                        upit = upit + " , partner_pa_iddobavljaca = " + glavniDobavljacID + "";
                                    }
                                } 
                                
                                upit = upit + " where ar_ID = " + artiklID + "";
                                //MessageBox.Show(upit);
                                veza.ExecuteQuery(""+upit+"");
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

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void frmPrijenosCSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPoruka UForm = null;
                if ((UForm = (frmPoruka)IsFormAlreadyOpen(typeof(frmPoruka))) == null)
                {
                    frmPoruka _frm = new frmPoruka();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.vrstaCSVa = "A";
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
