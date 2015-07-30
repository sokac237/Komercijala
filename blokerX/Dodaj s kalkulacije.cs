using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using blokirajx;

namespace blokerX
{
    public partial class frmDodajSKalkulacije : Form
    {
        MySqlConnection connection = new MySqlConnection();
        string ConnectionString;
        string artiklID;
        string arSifra;
        string poSifra;
        int postoji;
        string gr_ID;
        string poslovodja;

        Upiti veza = new Upiti();
        string kalkulacijaID;
        int kalkID;
        int brojac;
        string IP, katalog;
        string datumdok;
        string kolicina;
        decimal kolicin;
        string nabavnacijena;
        string nabavnaVrijednost;
        decimal nabVrijed;
        decimal nabCije;
        string prodajnacijena;
        string prodajnaVriejdnost;
        decimal prodVrijed;
        decimal prodCije;
        string ufaifaBroj;  //iz ufaifa tablice 
        string napomena;
        string poslovnicaID;
        int zavrsen;
        string zapisnik;
        string odobrenje;

        public frmDodajSKalkulacije()
        {
            InitializeComponent();
        }

        private void Dodaj_s_kalkulacije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.FillBy1(this.poslovnica.poslovnica);

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                kalkID = Convert.ToInt32(kalkulacijaID);
                this.kalkulTableAdapter.Fill(this.kalkulacija.kalkul, kalkID);                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBrojKalk_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable ufapostoji = new DataTable();
                if (txtBrojKalk.Text != "")
                {
                    veza.ExecuteQuery("select ufaifa.UI_ID from ufaifa where ufaifa.uf_broj= " + txtBrojKalk.Text.Trim() + " and ufaifa.partner_PA_ID=5061", ref ufapostoji);
                   
                    if (ufapostoji.Rows.Count > 0)
                    {                      
                                kalkulacijaID = ufapostoji.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ovaj kalkulacija ne postoji!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDodajSKalkulacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnZapisi_Click(object sender, EventArgs e)
        {
            if (glPoslovnica.Text != "" && SaKalkulacije.RowCount > 0)
            {

                napomena = txtNapomena.Text.Trim();
                poslovnicaID = glPoslovnica.EditValue.ToString();
                zavrsen = 1;

                DohvatiSifruID dohvati = new DohvatiSifruID();
                poslovodja = dohvati.DohvatiIDSifra("po_ImePoslovodje","poslovnica","po_ID = "+poslovnicaID+"");

                for (brojac = 0; brojac < SaKalkulacije.RowCount; brojac++)
                {
                    System.Data.DataRow row = SaKalkulacije.GetDataRow(brojac);

                    if (row != null) //pokupi podatke za trenutni red
                    {
                        artiklID = row[1].ToString();
                        arSifra = row[4].ToString();
                        kolicina = row[2].ToString().Replace(",", ".");
                        kolicin = Convert.ToDecimal(row[2]);
                        datumdok = Convert.ToDateTime(row[10]).ToString("yyyy-MM-dd");
                        ufaifaBroj = row[16].ToString();
                        nabavnacijena = row[3].ToString().Replace(",", ".");
                        nabCije = Convert.ToDecimal(row[3]);
                        nabVrijed = nabCije * kolicin;
                        nabavnaVrijednost = Convert.ToString(nabVrijed).Replace(",", ".");

                        zapisnik = row[15].ToString();
                        odobrenje = row[15].ToString();

                        provjeriPostojiLiKalkVecDodana();

                        //provjeri cjenik poslovnice i vrstu poslovnice

                        DataTable PoslovnicaPodaci = new DataTable();
                        veza.ExecuteQuery("select vp_sifra from poslovnica where po_id = " + glPoslovnica.EditValue + "", ref PoslovnicaPodaci);

                        if (PoslovnicaPodaci.Rows.Count > 0)
                        {
                            string vrsta = PoslovnicaPodaci.Rows[0][0].ToString();

                            if (vrsta == "100") //znači da je veleprodaja uzmi nabavbu cijenu iz grida
                            {
                                prodajnacijena = row[3].ToString().Replace(",", ".");
                                prodCije = Convert.ToDecimal(row[3]);
                                prodVrijed = prodCije * kolicin;
                                prodajnaVriejdnost = Convert.ToString(prodVrijed).Replace(",", ".");
                            }
                            else //spoji se na katalog zalihe i pogledaj prodajnu cijenu
                            {
                                pokupiPodatkeBaza();

                                connection = new MySqlConnection();
                                ConnectionString = "Server = " + IP + "; Database=" + katalog + "; Uid=admin10; Pwd=movema10;";
                                connection.ConnectionString = ConnectionString;

                                connection.Open();
                                DataTable podaci = new DataTable();

                                MySqlCommand comm = new MySqlCommand(@"select za_maloprodcijena from zalihe where ar_sifra = '" + arSifra + "'", connection);
                                    
                                MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                                comm.ExecuteNonQuery();

                                adapter.Fill(podaci);

                                connection.Close();

                                if (podaci.Rows.Count > 0)
                                {
                                    prodajnacijena = podaci.Rows[0][0].ToString().Replace(",", ".");
                                    prodCije = Convert.ToDecimal(podaci.Rows[0][0]);
                                    prodVrijed = prodCije * kolicin;
                                    prodajnaVriejdnost = Convert.ToString(prodVrijed).Replace(",", ".");
                                }
                            }
                        }
                    }
                    //MessageBox.Show("insert into gratis (partneri_pa_ID, gr_datum, gr_zapisnik, gr_odobrenje, artikl_ar_ID, gr_kolicina, gr_nabavnacijena, gr_nabavnavrijednost, gr_prodajnacijena, gr_prodajnavrijednost, ufaifa_uf_broj, gr_napomena, poslovnica_po_ID, operater_op_ID,gr_zavrsen, gr_vrsta) values (5061,'"+datumdok+"',"+zapisnik+", "+odobrenje+", "+artiklID+", "+kolicina+","+nabavnacijena+", "+nabavnaVrijednost+", "+prodajnacijena+", "+prodajnaVriejdnost+","+ufaifaBroj+", '"+napomena+"',"+poslovnicaID+","+Global.KorisnikID+", "+zavrsen+", 'TG')");
                    if (postoji == 1)
                    {
                        veza.ExecuteQuery("update gratis set gr_datum = '" + datumdok + "', gr_zapisnik = '" + zapisnik + "' , gr_odobrenje = '" + odobrenje + "', artikl_ar_ID = " + artiklID + ", gr_kolicina = " + kolicina + ", gr_nabavnacijena = " + nabavnacijena + ", gr_nabavnavrijednost = " + nabavnaVrijednost + ", gr_prodajnacijena = " + prodajnacijena + ", gr_prodajnavrijednost = " + prodajnaVriejdnost + ", ufaifa_uf_broj = " + ufaifaBroj + ", gr_napomena = '" + napomena + "', poslovnica_po_ID = " + poslovnicaID + ", operater_op_ID = '" + poslovodja + "', operater_op_ID_izmjena = "+Global.KorisnikID+" where gr_ID = " + gr_ID + "");
                    }
                    else
                    {
                        veza.ExecuteQuery(@"insert into gratis (partneri_pa_ID, gr_datum, gr_zapisnik, gr_odobrenje, artikl_ar_ID, gr_kolicina, gr_nabavnacijena, gr_nabavnavrijednost, gr_prodajnacijena, gr_prodajnavrijednost, ufaifa_uf_broj, gr_napomena, poslovnica_po_ID, operater_op_ID,gr_zavrsen, gr_vrsta, operater_op_ID_izmjena) 
                                    values (5061,'" + datumdok + "','" + zapisnik + "', '" + odobrenje + "', " + artiklID + ", " + kolicina + "," + nabavnacijena + ", " + nabavnaVrijednost + ", " + prodajnacijena + ", " + prodajnaVriejdnost + "," + ufaifaBroj + ", '" + napomena + "'," + poslovnicaID + ",'" + poslovodja + "', " + zavrsen + ", 'TG', "+Global.KorisnikID+")");
                    }
                    frmUnosGratisa.osvjezi.PerformClick();
                }
                MessageBox.Show("Uspješno ste ažurirali gratise!");
            }
        }


        private void provjeriPostojiLiKalkVecDodana()
        {
            DataTable podaci = new DataTable();
            veza.ExecuteQuery("select gr_ID from gratis where ufaifa_uf_broj = "+txtBrojKalk.Text.Trim()+" and  poslovnica_po_ID = "+glPoslovnica.EditValue+" and artikl_ar_ID = "+artiklID+"", ref podaci);

            if (podaci.Rows.Count > 0)
            {
                gr_ID = podaci.Rows[0][0].ToString();
                postoji = 1;
            }
            else
            {
                postoji = 0;
            }
        }

        private void pokupiPodatkeBaza()
        {
            try
            {
                DataTable baza = new DataTable();
                veza.ExecuteQuery("select po_IPadresa , po_katalog , po_naziv from poslovnica where po_ID = " + glPoslovnica.EditValue + "", ref baza);

                if (baza.Rows.Count > 0)
                {
                    IP = baza.Rows[0][0].ToString();
                    katalog = baza.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void glPoslovnica_Leave(object sender, EventArgs e)
        {
            try
            {
                if (glPoslovnica.Text != "")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();

                    poSifra = dohvati.DohvatiIDSifra("po_sifra", "poslovnica", "po_ID = " + glPoslovnica.EditValue + "");
                    //poSifra = poSifra.PadLeft(2);
                }
                else
                {
                    MessageBox.Show("Odaberite poslovnicu!");
                    glPoslovnica.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
