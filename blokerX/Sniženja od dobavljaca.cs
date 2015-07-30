using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokerX.Sifarnik;
using MySql.Data.MySqlClient;
using blokirajx;
using System.Configuration;

namespace blokerX
{
    public partial class frmSnizenjaOdDobavljaca : Form
    {
        int marza = 12; //zapovijedana marža

        DohvatiSifruID dohvati = new DohvatiSifruID();
        Upiti veza = new Upiti();
        DataTable podaciAkcije = new DataTable();
        int brojAkcije;
        string noviRedniBroj;
        int idZag;
        int dobavljacID;
        int dokumentPostoji = 0;

        MySqlConnection connection = new MySqlConnection();
        string ConnectionString;

        int brojac;

        string datumOD;
        string datumDO;
       
        int aktivna;
        string popust;
        string vrijednost;
        string akcBroj;
        string dokumPar;
        string partnerID;
        string sifraPartner;

        string _akcijaID;
        string _oznaka;

        string IP;
        string katalog;

        string sifraArtiklaStavka;
        string nazivArtiklaStavka;
        string poslovnicaIDStavka;

        string kolicinaStavka;
        string cijenaStavka;
        string PopustStavka;
        string nabavnaCijena;

        string prodajnaCijena;

        string datumODStavka;
        string datumDOStavka;
        string vrijediDO; //upotrebljava se za istek roka, ukoliko je odabran istek u ovu varijablu se zapisuje datumDOstavka

        int aktivnaStavka;
        string sifraDobavljacStavka;
        string nazivDobavljacStavka;
        string bkKod;

        string IDStavkaAkcije;

        int azurirati;
        int prodano = 0;
        int odobreno = 0;
        string postoSnizenja;



        string poslovodja;

        string datum;  

        public frmSnizenjaOdDobavljaca()
        {
            InitializeComponent();
        }

        public string akcijaID
        {
            get { return _akcijaID; }
            set { _akcijaID = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        private void odrediBrojAkcije()
        {
            try
            {
                DataTable broj = new DataTable();

                veza.ExecuteQuery("select se_trenutnibr from serija where dokumentVrsta_dv_ID = 9", ref broj);

                if (broj.Rows.Count == 0)
                {
                    int godina = DateTime.Now.Year;
                    veza.ExecuteQuery("insert into serija (dokumentVrsta_dv_ID , PG_GODINA) values (9, " + godina + ")");
                }
                else
                {
                    veza.ExecuteQuery("update serija set se_trenutnibr = se_trenutnibr +1 where dokumentVrsta_dv_ID = 9");
                }

                veza.ExecuteQuery("select se_trenutnibr from serija where dokumentVrsta_dv_ID = 9", ref broj);

                brojAkcije = Convert.ToInt32(broj.Rows[0][0].ToString());

                if (broj.Rows[0][0].ToString().Length == 1)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2, 2) + "0000" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 2)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2, 2) + "000" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 3)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2, 2) + "00" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 4)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2, 2) + "0" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 5)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2, 2) + brojAkcije;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void provjeriDokumPar()
        {
            try
            {
                DataTable podaci = new DataTable();
                if (_oznaka != "F4")
                {
                    veza.ExecuteQuery("select akcijezag.do_dokumpar from mpman.akcijezag where akcijezag.do_dokumpar = '" + txtDokumPar.Text.Trim() + "' and partner_pa_ID = '" + glPartner.EditValue + "'", ref podaci);

                    if (podaci.Rows.Count > 0)
                    {
                        MessageBox.Show("Dokument partnera već postoji u sustavu, upišite drugi!");
                        dokumentPostoji = 1;
                    }
                    else
                    {
                        dokumentPostoji = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                DohvatiSifruID dohvati = new DohvatiSifruID();

                if (_oznaka == "F4")
                {
                    //update
                    pokupiPodatke();
                    veza.ExecuteQuery("update mpman.akcijezag set  akc_datumod = '" + datumOD + "' , akc_datumdo = '" + datumDO + "', akc_opis = '" + txtOpis.Text.Trim() + "', akc_aktivna = " + aktivna + ", akc_popust = " + popust + ", do_dokumpar = '" + dokumPar + "', operater_op_ID = " + Global.KorisnikID + " where akc_ID = " + _akcijaID + "");

                    dtpDOKada.Enabled = false;
                    dtpODKada.Enabled = false;
                    dtpDOKada.Enabled = false;
                    cmbAktivna.Enabled = false;
                    txtPopust.Enabled = false;
                    txtOpis.Enabled = false;
                    txtDokumPar.Enabled = false;
                    glPartner.Enabled = false;
                    btnSpremi.Visible = false;
                    txtVrijednost.Enabled = false;
                }
                else
                {
                    provjeriDokumPar();
                    //insert

                    if (dokumentPostoji == 0)
                    {
                        odrediBrojAkcije();

                        partnerID = glPartner.EditValue.ToString();

                        sifraPartner = dohvati.DohvatiIDSifra("pa_sifra", "partner", "pa_ID = '" + partnerID + "'");

                        pokupiPodatke();

                        //MessageBox.Show("insert into akcijezag (pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana ) values (" + glKategorija.EditValue + "," + noviRedniBroj + ",'" + datumOD + "','" + datumDO + "', '" + txtOpis.Text.Trim() + "'," + aktivna + ", " + popust + ", " + txtBrojVezaneAkcije.Text.Trim() + ", " + sifraVezane + ")");
                        akcBroj = noviRedniBroj;

                        veza.ExecuteQuery(@"insert into mpman.akcijezag (pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, partner_pa_ID, do_dokumpar, partner_pa_sifra, operater_op_ID ) 
                                values (16," + noviRedniBroj + ",'" + datumOD + "','" + datumDO + "', '" + txtOpis.Text.Trim() + "'," + aktivna + ", " + popust + ", '" + partnerID + "', '" + dokumPar + "', '" + sifraPartner + "', " + Global.KorisnikID + ")");

                        MessageBox.Show("Uspješno ste dodali zaglavlje nove akcije!");

                        txtBrojAkcije.Visible = true;
                        label2.Visible = true;
                        txtBrojAkcije.Text = noviRedniBroj;
                        txtBrojAkcije.Enabled = false;
                        btnSpremi.Visible = false;

                        panel3.Enabled = true;
                        panel5.Enabled = true;
                        pnlIzmjenaStavkiAkcije.Visible = false;

                        dtpDOKada.Enabled = false;
                        dtpODKada.Enabled = false;
                        dtpDOKada.Enabled = false;
                        cmbAktivna.Enabled = false;
                        txtPopust.Enabled = false;
                        txtOpis.Enabled = false;
                        txtDokumPar.Enabled = false;
                        glPartner.Enabled = false;
                    }
                }

                //popuni artikle koje može sniziti i koji su stavljeni na sniženje;
                //dohvati id zaglavlja akcije preko broja koji je generiran
                idZag = Convert.ToInt32(dohvati.DohvatiIDSifra("akc_id", "mpman.akcijezag", "akc_broj = '" + txtBrojAkcije.Text + "'"));
                dobavljacID = Convert.ToInt32(glPartner.EditValue);

                if (glPartner.EditValue.ToString() == "1132")
                {
                    this.artiklDobavljacaTableAdapter.artikliBoso(this.snizenja.artiklDobavljaca, idZag);
                }
                else
                {
                    this.artiklDobavljacaTableAdapter.ArtikliDobavljacaZaSnizenje(this.snizenja.artiklDobavljaca, dobavljacID, idZag);
                }

                this.snizeniArtikliTableAdapter.OdabraniArtikli(this.snizenje_odabrani.SnizeniArtikli, idZag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatke()
        {
            if (cmbAktivna.Text == "Da")
            {
                aktivna = 1;
            }
            else
            {
                aktivna = 0;
            }

            if (txtPopust.Text.ToString() == "")
            {
                popust = "0";
            }
            else
            {
                popust = Convert.ToString(txtPopust.Text).Replace(',', '.');
            }


            if (txtVrijednost.Text.ToString() == "")
            {
                vrijednost = "0.00";
            }
            else
            {
                vrijednost = Convert.ToString(txtVrijednost.Text).Replace(',', '.');
            }



            dokumPar = txtDokumPar.Text.Trim();

            datumOD = Convert.ToDateTime(dtpODKada.Text).ToString("yyyy-MM-dd");

            datumDO = Convert.ToDateTime(dtpDOKada.Text).ToString("yyyy-MM-dd");

            
        }

        private void frmSnizenjaOdDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmSnizenjaOdDobavljaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.poslovnica.poslovnica);
            // TODO: This line of code loads data into the 'kategorijeAkcija.kategorijeAkcija' table. You can move, or remove it, as needed.
            this.kategorijeAkcijaTableAdapter.Fill(this.kategorijeAkcija.kategorijeAkcija);
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);

            if (_oznaka != "F4") //insert 
            {
                cmbAktivna.Text = "Da";
                label2.Visible = false;
                txtBrojAkcije.Visible = false;
                dtpDOKada.Text = "31.12."+DateTime.Now.Year+".";
                return;
            }
            else //update napuni formu
            {
                txtVrijednost.Enabled = false;
                txtBrojAkcije.Enabled = false;
                veza.ExecuteQuery("select akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, partner_pa_ID, do_dokumpar, akc_vrijednostsnizenja from mpman.akcijezag where akc_ID = " + _akcijaID + "", ref podaciAkcije);

                if (podaciAkcije.Rows.Count > 0)
                {
                    txtBrojAkcije.Text = podaciAkcije.Rows[0][0].ToString();

                    dtpODKada.Text = podaciAkcije.Rows[0][1].ToString();
                    dtpDOKada.Text = podaciAkcije.Rows[0][2].ToString();
                    txtOpis.Text = podaciAkcije.Rows[0][3].ToString();

                    if (podaciAkcije.Rows[0][4].ToString() == "True")
                    {
                        cmbAktivna.Text = "Da";
                    }
                    else
                    {
                        cmbAktivna.Text = "Ne";
                    }

                    txtPopust.Text = podaciAkcije.Rows[0][5].ToString();

                    glPartner.EditValue = podaciAkcije.Rows[0][6].ToString();

                    txtDokumPar.Text = podaciAkcije.Rows[0][7].ToString();
                    
                    txtVrijednost.Text = podaciAkcije.Rows[0][8].ToString();

                    glPartner.Enabled = false;
                    if (podaciAkcije.Rows[0][8].ToString() == "")
                    {
                        //ako nema vrijednost u zaglavlju to znaci da nije zakljuceno snizenje omoguci editiranje
                        panel3.Enabled = true;
                        panel5.Enabled = true;            
                    }
                    else 
                    {
                        //zakljuceno snizenje onemoguci izmjene
                        panel3.Enabled = false;
                        panel5.Enabled = true;
                        panel9.Enabled = false;


                        dtpDOKada.Enabled = false;
                        dtpODKada.Enabled = false;
                        dtpDOKada.Enabled = false;
                        cmbAktivna.Enabled = false;
                        txtPopust.Enabled = false;
                        txtOpis.Enabled = false;
                        txtDokumPar.Enabled = false;
                        glPartner.Enabled = false;
                        btnSpremi.Enabled = false;
   
                    }

                    
                    
                    pnlIzmjenaStavkiAkcije.Visible = false;


                    //popuni artikle koje može sniziti i koji su stavljeni na sniženje;
                    idZag = Convert.ToInt32(dohvati.DohvatiIDSifra("akc_id", "mpman.akcijezag", "akc_broj = '" + txtBrojAkcije.Text + "'"));
                    dobavljacID = Convert.ToInt32(glPartner.EditValue);

                    if (glPartner.EditValue.ToString() == "1132")
                    {
                        this.artiklDobavljacaTableAdapter.artikliBoso(this.snizenja.artiklDobavljaca, idZag);
                    }
                    else
                    {
                        this.artiklDobavljacaTableAdapter.ArtikliDobavljacaZaSnizenje(this.snizenja.artiklDobavljaca, dobavljacID, idZag);
                    }

                    //dohvati id zaglavlja akcije preko broja koji je generiran

                    this.snizeniArtikliTableAdapter.OdabraniArtikli(this.snizenje_odabrani.SnizeniArtikli, idZag);
                }
            }
        }

        private void Spremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgArtikDobav.RowCount > 0)
                {
                    System.Data.DataRow row = dgArtikDobav.GetDataRow(dgArtikDobav.FocusedRowHandle);
                    if (row != null)
                    {
                        //insert u snizenjastavka pod ID zaglavlja od tog partnera/dobavljaca
                        string artiklID = row[0].ToString();
                        string sifra = row[2].ToString().Trim();

                        if (sifra.Length == 6)
                        {
                            //izračunaj barkod,  vodece nule dodane na 6 znakovnu šifru
                            string barkod = "00" + sifra;

                            veza.ExecuteQuery("insert into mpman.snizenjestavka (akcijezag_akc_ID, artikl_ar_ID, artikl_ar_Sifra, bk_kod) values (" + idZag + ", '" + artiklID + "', '" + sifra + "', '" + barkod + "')");

                            this.snizeniArtikliTableAdapter.OdabraniArtikli(this.snizenje_odabrani.SnizeniArtikli, idZag);
                            //this.artiklDobavljacaTableAdapter.ArtikliDobavljacaZaSnizenje(this.snizenja.artiklDobavljaca, dobavljacID, idZag);

                            if (glPartner.EditValue.ToString() == "1132")
                            {
                                this.artiklDobavljacaTableAdapter.artikliBoso(this.snizenja.artiklDobavljaca, idZag);
                            }
                            else
                            {
                                this.artiklDobavljacaTableAdapter.ArtikliDobavljacaZaSnizenje(this.snizenja.artiklDobavljaca, dobavljacID, idZag);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Šifra odabranog artikla manja je od 6 znakova!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Brisi_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataRow row = dgSnizeni.GetDataRow(dgSnizeni.FocusedRowHandle);

                if (row != null)
                {
                    string artiklID = row[0].ToString();
                    string artiklSIfra = row[1].ToString();
                    //provjeri da li je artikl iskorišten u nekoj akciji
                    DataTable provjera = new DataTable();
                    veza.ExecuteQuery("select akc_ID from mpman.akcije where akcijezag_akc_ID = " + idZag + "  and ar_sifra = '" + artiklSIfra + "'", ref provjera);

                    if (provjera.Rows.Count > 0)
                    {
                        //znači da postoji i ne dozvoli drisanje
                    }
                    else
                    {
                        //obrisi iz snizenjastavka barkod

                        veza.ExecuteQuery("delete from mpman.snizenjestavka where akcijezag_akc_ID = '" + idZag + "' and artikl_ar_ID = '" + artiklID + "'");

                        this.snizeniArtikliTableAdapter.OdabraniArtikli(this.snizenje_odabrani.SnizeniArtikli, idZag);

                        if (glPartner.EditValue.ToString() == "1132")
                        {
                            this.artiklDobavljacaTableAdapter.artikliBoso(this.snizenja.artiklDobavljaca, idZag);
                        }
                        else
                        {
                            this.artiklDobavljacaTableAdapter.ArtikliDobavljacaZaSnizenje(this.snizenja.artiklDobavljaca, dobavljacID, idZag);
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgSnizeniArtikliStanja_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F7)
                {
                    pnlIzmjenaStavkiAkcije.Visible = true;

                    txtOpisStavka.Text = txtOpis.Text;
                    txtOpisStavka.Focus();

                    //provjeri da li već postoji, ako da otvori za ažuriranje

                    System.Data.DataRow row = dgSnizeniStanja.GetDataRow(dgSnizeniStanja.FocusedRowHandle);

                    if (row != null)
                    {
                        sifraArtiklaStavka = row[1].ToString();
                        nabavnaCijena = row[3].ToString().Replace(",",".");
                        prodajnaCijena = row[4].ToString().Replace(",", ".");
                        nazivArtiklaStavka  = dohvati.DohvatiIDSifra("ar_naziv","artikl","ar_sifra = '"+sifraArtiklaStavka+"'");
                        //nazivArtiklaStavka = '"' + row[0].ToString() + '"';
                    }
                    DataTable akcijaStavke = new DataTable();

                    poslovnicaIDStavka = glPoslovnica.EditValue.ToString();

                    brojAkcije = Convert.ToInt32(txtBrojAkcije.Text);

                    //provjeri postoji li odabrani artikl u nekoj od vec kreiranih akcija za odabranu poslovnicu, kategorija 16

                    DataTable vecPostojiArtikl = new DataTable();
                    veza.ExecuteQuery("select akc_ID , akcijezag_akc_ID, pok_opis, ar_sifra, pok_kolic, akc_popust, pok_vaziod, pok_vazido, akc_aktivna, akc_broj from mpman.akcije where akcije.ar_sifra = '" + sifraArtiklaStavka + "' and akcije.pok_sifra = 16 and akcije.POSLOVNICA_PO_ID ='" + poslovnicaIDStavka + "'", ref vecPostojiArtikl);

                    if (vecPostojiArtikl.Rows.Count > 0)
                    {
                        //provjeri kolicinu prodanu i odobrenu, ako su jednake onda ne upozoravaj, ako je odobrena veca od prodane onda upozori
                        DataTable provjera = new DataTable();

                        //dohvati podatke za spajanje
                        DataTable podaciSpajanje = new DataTable();

                        int poslovnica = Convert.ToInt32(glPoslovnica.EditValue);
                        //string sifraPosl = dohvati.DohvatiIDSifra("po_sifra", "poslovnica", "po_ID = " + glPoslovnica.EditValue + " ");

                        veza.ExecuteQuery("select po_katalog, po_IPadresaPoslovnica from poslovnica where po_ID = " + poslovnica + "", ref podaciSpajanje);

                        if (podaciSpajanje.Rows.Count > 0)
                        {
                            IP = podaciSpajanje.Rows[0][1].ToString();
                            katalog = podaciSpajanje.Rows[0][0].ToString();
                        }

                        //spoji se na katalog trgovine i slektiraj artikle sa stanjima iz kataloga trgovine

                        connection = new MySqlConnection();
                        ConnectionString = "Server = " + IP + "; Database=" + katalog + "; Uid=admin10; Pwd=movema10; Connection Timeout=10;";
                        connection.ConnectionString = ConnectionString;

                        connection.Open();

                        MySqlCommand comm = new MySqlCommand(@"select akcije.POK_KOLIC, akcije.POK_PRODANO from akcije where  akcije.AR_SIFRA = " + sifraArtiklaStavka + " and akcije.pok_sifra = 16", connection);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                        comm.ExecuteNonQuery();

                        adapter.Fill(provjera);

                        connection.Close();

                        if (provjera.Rows.Count > 0)
                        {
                            prodano = Convert.ToInt32(provjera.Rows[0][1]);
                            odobreno = Convert.ToInt32(provjera.Rows[0][0]);
                            postoSnizenja = vecPostojiArtikl.Rows[0][5].ToString();
                        }

                        DialogResult result = new DialogResult();
                        if (prodano < odobreno) //znaci da nisu prodani svi sniženi artikli i da treba upozoriti
                        {
  
                            //artikl postoji za kategorija 16 dodan u nekoj od akcija, upozori da će se artikl iz prethodne akcije obrisati ukoliko ga doda u ovu akciju
                            result = MessageBox.Show("Odabrani akrtikl već postoji u nekoj akciji sniženja i nije prodan u odabranoj količini!!\nOdobrena količina: "+odobreno+",\nprodana količina: "+prodano+",\npostotak sniženja: "+postoSnizenja+",\nbroj akcije: "+vecPostojiArtikl.Rows[0][9].ToString()+" \nUkoliko želite da se u prethodnoj akciji taj artikl izbriše dodajte ga u ovu akciju. Želite li dodati artikl?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        }
                        else //znaci da je jednako, sve prodano, može novi artikl bez upozorenja ili da nema pa se slobodno može dodati
                        {
                            result = DialogResult.Yes;
                        }


                       

                        if (result == DialogResult.Yes) //znaci da se artikl smije dodati
                        {
                            veza.ExecuteQuery("select akc_ID , akcijezag_akc_ID, pok_opis, ar_sifra, pok_kolic, akc_popust, pok_vaziod, pok_vazido, akc_aktivna , akc_cijena, pok_vrijedido from mpman.akcije where akcije.ar_sifra = '" + sifraArtiklaStavka + "' and akcije.pok_sifra = 16 and akcije.akc_broj = '" + brojAkcije + "' and akcije.POSLOVNICA_PO_ID ='" + poslovnicaIDStavka + "'", ref akcijaStavke);


                            if (akcijaStavke.Rows.Count > 0) //postoji artikl u stavkama odabrane akcije za tog partnera i poslovnicu
                            {
                                //ažuriraj
                                azurirati = 1;
                                //napuni formu

                                IDStavkaAkcije = akcijaStavke.Rows[0][0].ToString();

                                txtOpisStavka.Text = akcijaStavke.Rows[0][2].ToString();

                                if (akcijaStavke.Rows[0][4].ToString() != "")
                                {
                                    txtKolicina.Text = akcijaStavke.Rows[0][4].ToString();
                                }


                                if (akcijaStavke.Rows[0][5].ToString() == "" || akcijaStavke.Rows[0][5].ToString() == "0,00" || akcijaStavke.Rows[0][5].ToString() == "0")
                                {
                                    txtPopustStavka.Text = "";

                                    if (akcijaStavke.Rows[0][9].ToString() != "")
                                    {
                                        txtCijena.Text = akcijaStavke.Rows[0][9].ToString();
                                    }
                                }
                                else
                                {
                                    txtPopustStavka.Text = akcijaStavke.Rows[0][5].ToString();
                                    txtCijena.Text = "";
                                }

                             

                                dtpDatumOD.Text = akcijaStavke.Rows[0][6].ToString();
                                dtpDatumDO.Text = akcijaStavke.Rows[0][7].ToString();

                                if (akcijaStavke.Rows[0][8].ToString() == "True")
                                {
                                    cmbAktivnaStavka.Text = "Da";
                                }
                                else
                                {
                                    cmbAktivnaStavka.Text = "Ne";
                                }

                              


                                if (akcijaStavke.Rows[0][10].ToString() != "")
                                {
                                    ckbIstekRoka.Checked = true;
                                }
                                else
                                {
                                    ckbIstekRoka.Checked = false;

                                }
                            }
                            else
                            {
                                //insert
                                azurirati = 0;
                                //refresh grid stavki       
                                txtOpisStavka.Focus();
                                //txtOpisStavka.Text = "";
                                txtKolicina.Text = "";
                                txtPopustStavka.Text = "";
                                txtCijena.Text = "";
                                dtpDatumOD.Text = DateTime.Now.Date.ToString();
                                dtpDatumDO.Text = "31.12."+DateTime.Now.Year+".";
                                cmbAktivnaStavka.Text = "Da";

                                ckbIstekRoka.Checked = true;
                            }
                        }
                        else
                        {
                            pnlIzmjenaStavkiAkcije.Visible = false;
                        }
                    }
                    else
                    {
                        azurirati = 0;
                        //refresh grid stavki       
                        txtOpisStavka.Focus();
                        //txtOpisStavka.Text = "";
                        txtKolicina.Text = "";
                        txtPopustStavka.Text = "";
                        txtCijena.Text = "";
                        dtpDatumOD.Text = DateTime.Now.Date.ToString();
                        dtpDatumDO.Text = "31.12."+DateTime.Now.Year+".";
                        cmbAktivnaStavka.Text = "Da";
                        ckbIstekRoka.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void spremi()
        {
            try
            {
                dohvatiPodatkeStavke();

                if (azurirati == 1)
                {
                    //dohvati nabavnu cijenu iz baze za artikl iz trenutne akcije  ako je ažuriranje                                   
                    string artiklID = dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = '" + sifraArtiklaStavka + "'");
                    string nabavna = dohvati.DohvatiIDSifra("akc_nabavna", "mpman.akcije", "akc_ID = " + IDStavkaAkcije + " ");

                    if (nabavna == "") //ako je po starom dodavano s postotkom nema nabavne u bazi pa moram pokupit sa glavnog skladista iz zaliha u centrali
                    {
                        string poID = dohvati.DohvatiIDSifra("poslovnica_po_ID", "artikl", "ar_ID = " + artiklID + "");

                        string nabcije = dohvati.DohvatiIDSifra("za_nabcij", "zaliha", "artikl_ar_ID = " + artiklID + " and poslovnica_po_ID = " + poID + "");


                        nabavna = nabcije.ToString().Replace(",", ".");

                    }

                    nabavnaCijena = nabavna.Replace(',', '.');
                    //update
                    veza.ExecuteQuery("update mpman.akcije set pok_opis ='" + txtOpisStavka.Text + "' , ar_sifra =  '" + sifraArtiklaStavka + "', ar_naziv = '" + nazivArtiklaStavka + "', pok_kolic = '" + kolicinaStavka + "', pok_vaziod = '" + datumODStavka + "', pok_vazido = '" + datumDOStavka + "', akc_aktivna = '" + aktivnaStavka + "', akc_popust ='" + PopustStavka + "', akc_cijena = '" + cijenaStavka + "', operater_op_ID = " + Global.KorisnikID + " , akc_nabavna = " + nabavnaCijena + ", pok_vrijedido = "+vrijediDO+"  where akc_ID = '" + IDStavkaAkcije + "'");
                }
                else
                {
                    //insert

                    string artiklID = dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = " + sifraArtiklaStavka + "");

                    int dobavljacID = Convert.ToInt32(glPartner.EditValue);
                    string datum = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    DataTable podaci = new DataTable();

                    //dohvati nabavnu cijenu uz pomoć procedure i spremi je u bazu za tu akciju

                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
                    MySqlCommand comm = new MySqlCommand("nabavnacijena", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    MySqlParameter prm = new MySqlParameter("artiklID", MySqlDbType.Int16);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = artiklID;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("dobavljacID", MySqlDbType.Int16);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = dobavljacID;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("datum", MySqlDbType.String);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = datum;
                    comm.Parameters.Add(prm);


                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Products");
                    podaci = ds.Tables["Products"];

                    if (podaci.Rows.Count > 0)
                    {
                        string vrsta = podaci.Rows[0][0].ToString();

                        if (vrsta == "A") //pokupi akcijsku cijenu
                        {
                            nabavnaCijena = podaci.Rows[0][3].ToString().Replace(',', '.');
                        }
                        else if (vrsta == "S") //tvornička cijena - rabat
                        {
                            decimal nabavnaCijenaa = Math.Round(Convert.ToDecimal(podaci.Rows[0][1].ToString()) - Convert.ToDecimal(podaci.Rows[0][1].ToString()) * Convert.ToDecimal(podaci.Rows[0][2]) / 100, 2);
                            //round (dobavljacartikl.doa_tvornickacijena - (dobavljacartikl.doa_tvornickacijena * dobavljacartikl.doa_postorabata)/100, 5) as nabavnaCijena
                            nabavnaCijena = nabavnaCijenaa.ToString().Replace(',', '.');
                        }
                        else if (vrsta == "N") //nabavnu cijenu iz zaliha
                        {
                            //imam je pokupljenu gore kod F7 na grid sa cijenom i stanjem
                        }
                    }

                    spremiZapisnikGratisa();


                    //MessageBox.Show("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv, pok_kolic, pok_vaziod, pok_vazido, akc_aktivna, akc_popust, ar_sifradob, ar_nazivdob, bk_kod, poslovnica_po_ID ) values ('" + idZag + "', 16, '" + txtBrojAkcije.Text + "', '" + txtOpisStavka.Text + "', '" + sifraArtiklaStavka + "', '" + nazivArtiklaStavka + "', '" + kolicinaStavka + "', '" + datumODStavka + "' , '" + datumDOStavka + "', '" + aktivnaStavka + "', '" + PopustStavka + "', '" + sifraDobavljacStavka + "', '" + nazivDobavljacStavka + "', '" + bkKod + "' , '" + glPoslovnica.EditValue + "')");
                    veza.ExecuteQuery("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv, pok_kolic, pok_vaziod, pok_vazido, akc_aktivna, akc_popust, ar_sifradob, ar_nazivdob, bk_kod, poslovnica_po_ID, akc_cijena, operater_op_ID, akc_nabavna, pok_vrijedido, akc_prodajnacijena) values ('" + idZag + "', 16, '" + txtBrojAkcije.Text + "', '" + txtOpisStavka.Text + "', '" + sifraArtiklaStavka + "', '" + nazivArtiklaStavka + "', '" + kolicinaStavka + "', '" + datumODStavka + "' , '" + datumDOStavka + "', '" + aktivnaStavka + "', '" + PopustStavka + "', '" + sifraDobavljacStavka + "', '" + nazivDobavljacStavka + "', '" + bkKod + "' , '" + glPoslovnica.EditValue + "', '" + cijenaStavka + "', '" + Global.KorisnikID + "' , '" + nabavnaCijena + "', "+vrijediDO+", '"+prodajnaCijena+"')");
                }

                pnlIzmjenaStavkiAkcije.Visible = false;

                //refresh grid stavki                      
                txtOpisStavka.Text = "";
                txtKolicina.Text = "";
                txtPopustStavka.Text = "";
                txtCijena.Text = "";
                dtpDatumOD.Text = DateTime.Now.Date.ToString();
                dtpDatumDO.Text = DateTime.Now.Date.ToString();
                cmbAktivnaStavka.Text = "Da";

                DataTable stavkeakcije = new DataTable();
                int poslovnica = Convert.ToInt32(glPoslovnica.EditValue);
                veza.ExecuteQuery("select akcije.AR_SIFRA, akcije.AR_NAZIV, akcije.POK_KOLIC, akcije.AKC_POPUST, akcije.AKC_AKTIVNA, akcije.POK_VAZIOD, akcije.POK_VAZIDO, akcije.BK_KOD, akcije.akc_cijena from mpman.akcije where akcije.AKCIJEZAG_AKC_ID = " + idZag + " and poslovnica_po_ID = " + poslovnica + "", ref stavkeakcije);
                dgArtikliUAkciji.DataSource = stavkeakcije;

                if (dgartikliUAkcijiStavke.RowCount > 0)
                {
                    panel12.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void spremiZapisnikGratisa()
        {
            //insert u zapisnik - gratise osnovnih podataka za svaku trgovinu za koju je dodan barem jedan artikl na sniženje
            //zapisnik dodaj samo jednom prilikom dodavanja prvog artikla
            if (dgartikliUAkcijiStavke.RowCount == 0)
            {
                //ako nema ni jednog artikla u gridu znači da mogu dodat zapisnik u gratise za tu trgovinu, prije obavezno provjeriti da li je već zapis dodan u bazu

                DataTable provjera = new DataTable();

                datum = Convert.ToDateTime(dtpODKada.Text).ToString("yyyy-MM-dd");

                //MessageBox.Show("select gr_ID from gratis where partneri_pa_ID = '" + glPartner.EditValue + " and poslovnica_po_ID = '" + glPoslovnica.EditValue + "' and  gr_zapisnik ='" + txtDokumPar.Text + "'and gr_datum = '" + datum + "' ");
                veza.ExecuteQuery("select gr_ID from gratis where partneri_pa_ID = '" + glPartner.EditValue + "' and poslovnica_po_ID = '" + glPoslovnica.EditValue + "' and  gr_zapisnik ='" + txtDokumPar.Text + "'and gr_datum = '" + datum + "' ", ref provjera);

                if (provjera.Rows.Count > 0)
                {
                    //postoji taj zapisnik ne dodaji novi
                }
                else
                {
                    if (glPartner.EditValue.ToString() == "1132")
                    {
                        //radi se o BOSO d.o.o. za njega ne unosi zapisnik u gratise
                    }
                    else
                    {
                        //dodaj zapisnik
                        pokupiPodatkeZapisnik();

                        if (txtVrijednost.Text.ToString() == "")
                        {
                            vrijednost = "0";
                        }
                        else
                        {
                            vrijednost = Convert.ToString(txtVrijednost.Text).Replace(',', '.');
                        }

                        akcBroj = txtBrojAkcije.Text;
                        //MessageBox.Show("insert into gratis (partneri_pa_ID, gr_datum, gr_zapisnik,  poslovnica_po_ID,operater_op_ID, gr_zavrsen, gr_vrsta, operater_op_ID_izmjena, akc_broj, gr_vrijednostsnizenja) values('" + glPartner.EditValue + "', '" + datum + "' , '" + txtDokumPar.Text + "','" + glPoslovnica.EditValue + "','" + poslovodja + "', 0, 'OG', " + Global.KorisnikID + ", "+akcBroj+", "+vrijednost+")");
                        veza.ExecuteQuery(@"insert into gratis (partneri_pa_ID, gr_datum, gr_zapisnik,  poslovnica_po_ID,operater_op_ID, gr_zavrsen, gr_vrsta, operater_op_ID_izmjena, akc_broj, gr_vrijednostsnizenja) 
                                                                values('" + glPartner.EditValue + "', '" + datum + "' , '" + txtDokumPar.Text + "','" + glPoslovnica.EditValue + "','" + poslovodja + "', 0, 'OG', " + Global.KorisnikID + ", "+akcBroj+", "+vrijednost+")");
                    }                   
                }
            }
        }

        private void spremi2()
        {
            try
            {
                dohvatiPodatkeStavke();
                dohvatiNabavnuCijenu(); //pokupim nabavnu cijenu

                if (azurirati == 1)
                {
                    //update
                    //MessageBox.Show("update mpman.akcije set pok_opis ='" + txtOpisStavka.Text + "' , ar_sifra =  '" + sifraArtiklaStavka + "', ar_naziv = '" + nazivArtiklaStavka + "', pok_kolic = '" + kolicinaStavka + "', pok_vaziod = '" + datumODStavka + "', pok_vazido = '" + datumDOStavka + "', akc_aktivna = '" + aktivnaStavka + "', akc_popust ='" + PopustStavka + "', akc_cijena = '" + cijenaStavka + "', operater_op_ID = " + Global.KorisnikID + ", akc_nabavna = " + nabavnaCijena + ", pok_vrijedido = " + vrijediDO + "   where akc_ID = '" + IDStavkaAkcije + "'");
                    veza.ExecuteQuery("update mpman.akcije set pok_opis ='" + txtOpisStavka.Text + "' , ar_sifra =  '" + sifraArtiklaStavka + "', ar_naziv = '" + nazivArtiklaStavka + "', pok_kolic = '" + kolicinaStavka + "', pok_vaziod = '" + datumODStavka + "', pok_vazido = '" + datumDOStavka + "', akc_aktivna = '" + aktivnaStavka + "', akc_popust ='" + PopustStavka + "', akc_cijena = '" + cijenaStavka + "', operater_op_ID = " + Global.KorisnikID + ", akc_nabavna = "+nabavnaCijena+", pok_vrijedido = "+ vrijediDO +"   where akc_ID = '" + IDStavkaAkcije + "'");
                }
                else
                {   
                    spremiZapisnikGratisa();    
                    //insert
                    //MessageBox.Show("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv, pok_kolic, pok_vaziod, pok_vazido, akc_aktivna, akc_popust, ar_sifradob, ar_nazivdob, bk_kod, poslovnica_po_ID ) values ('" + idZag + "', 16, '" + txtBrojAkcije.Text + "', '" + txtOpisStavka.Text + "', '" + sifraArtiklaStavka + "', '" + nazivArtiklaStavka + "', '" + kolicinaStavka + "', '" + datumODStavka + "' , '" + datumDOStavka + "', '" + aktivnaStavka + "', '" + PopustStavka + "', '" + sifraDobavljacStavka + "', '" + nazivDobavljacStavka + "', '" + bkKod + "' , '" + glPoslovnica.EditValue + "')");
                    veza.ExecuteQuery("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv, pok_kolic, pok_vaziod, pok_vazido, akc_aktivna, akc_popust, ar_sifradob, ar_nazivdob, bk_kod, poslovnica_po_ID, akc_cijena, operater_op_ID, akc_nabavna, pok_vrijedido, akc_prodajnacijena) values ('" + idZag + "', 16, '" + txtBrojAkcije.Text + "', '" + txtOpisStavka.Text + "', '" + sifraArtiklaStavka + "', '" + nazivArtiklaStavka + "', '" + kolicinaStavka + "', '" + datumODStavka + "' , '" + datumDOStavka + "', '" + aktivnaStavka + "', '" + PopustStavka + "', '" + sifraDobavljacStavka + "', '" + nazivDobavljacStavka + "', '" + bkKod + "' , '" + glPoslovnica.EditValue + "', '" + cijenaStavka + "', '" + Global.KorisnikID + "', '"+nabavnaCijena+"', "+vrijediDO+", '"+prodajnaCijena+"')");
                }

                pnlIzmjenaStavkiAkcije.Visible = false;

                //refresh grid stavki                      
                txtOpisStavka.Text = "";
                txtKolicina.Text = "";
                txtPopustStavka.Text = "";
                txtCijena.Text = "";
                dtpDatumOD.Text = DateTime.Now.Date.ToString();
                dtpDatumDO.Text = DateTime.Now.Date.ToString();
                cmbAktivnaStavka.Text = "Da";

                DataTable stavkeakcije = new DataTable();
                int poslovnica = Convert.ToInt32(glPoslovnica.EditValue);
                veza.ExecuteQuery("select akcije.AR_SIFRA, akcije.AR_NAZIV, akcije.POK_KOLIC, akcije.AKC_POPUST, akcije.AKC_AKTIVNA, akcije.POK_VAZIOD, akcije.POK_VAZIDO, akcije.BK_KOD, akcije.akc_cijena from mpman.akcije where akcije.AKCIJEZAG_AKC_ID = " + idZag + " and poslovnica_po_ID = " + poslovnica + "", ref stavkeakcije);
                dgArtikliUAkciji.DataSource = stavkeakcije;

                if (dgartikliUAkcijiStavke.RowCount > 0)
                {
                    panel12.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void pokupiPodatkeZapisnik()
        {
            try
            {
                if (glPartner.Text != "" && glPoslovnica.Text != "")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    poslovodja = dohvati.DohvatiIDSifra("po_ImePoslovodje", "poslovnica", "po_ID = " + glPoslovnica.EditValue + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dohvatiNabavnuCijenu()
        {
            try
            {
                if (azurirati == 1) //update
                {
                    string artiklID = dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = " + sifraArtiklaStavka + "");

                    int dobavljacID = Convert.ToInt32(glPartner.EditValue);
                    string datum = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    DataTable podaci = new DataTable();

                    //dohvati nabavnu cijenu iz baze za artikl iz trenutne akcije                                     

                    string nabavna = dohvati.DohvatiIDSifra("akc_nabavna","mpman.akcije","akc_ID = "+IDStavkaAkcije+" ");

                    if (nabavna == "") //ako je po starom dodavano s postotkom nema nabavne u bazi pa moram pokupit sa glavnog skladista iz zaliha u centrali
                    {
                        string poID = dohvati.DohvatiIDSifra("poslovnica_po_ID", "artikl", "ar_ID = " + artiklID + "");

                        string nabcije = dohvati.DohvatiIDSifra("za_nabcij","zaliha","artikl_ar_ID = "+artiklID+" and poslovnica_po_ID = "+poID+"");


                        nabavna = nabcije.ToString().Replace(",", ".");
                        
                    }

                    nabavnaCijena = nabavna.Replace(',', '.');

                    decimal nabavnaa = Convert.ToDecimal(nabavna.Replace(".", ","));
                    decimal popust = Convert.ToDecimal(PopustStavka.ToString().Replace(".", ","));
                    decimal marzaa = Convert.ToDecimal(marza);
                    decimal cijenastavkaa = nabavnaa - (nabavnaa * popust / 100); //s popustom
                    decimal cijenastavkaaa = cijenastavkaa + (cijenastavkaa * marzaa / 100); //s 12% marze

                    //dodaj još 25% poreza

                    DataTable postoporeza = new DataTable();

                    veza.ExecuteQuery("select  porez.pz_posto from porez, poreznastopa,artikl where  porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>= '" + datum + "' and artikl.ar_ID = " + artiklID + "", ref postoporeza);

                    if (postoporeza.Rows.Count > 0)
                    {
                        decimal porez = Convert.ToDecimal(postoporeza.Rows[0][0].ToString());
                        decimal sPorezom = Math.Round(cijenastavkaaa + (cijenastavkaaa * porez / 100), 2);
                        cijenaStavka = sPorezom.ToString().Replace(',', '.');
                    }
                    else
                    {
                        decimal sPorezom = Math.Round(cijenastavkaaa + (cijenastavkaaa * 25 / 100), 2);
                        cijenaStavka = sPorezom.ToString().Replace(',', '.');
                    }
                }
                else //insert
                {
                    string artiklID = dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = " + sifraArtiklaStavka + "");

                    int dobavljacID = Convert.ToInt32(glPartner.EditValue);
                    string datum = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    DataTable podaci = new DataTable();

                    //dohvati nabavnu cijenu uz pomoć procedure i spremi je u bazu za tu akciju

                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
                    MySqlCommand comm = new MySqlCommand("nabavnacijena", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    MySqlParameter prm = new MySqlParameter("artiklID", MySqlDbType.Int16);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = artiklID;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("dobavljacID", MySqlDbType.Int16);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = dobavljacID;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("datum", MySqlDbType.String);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = datum;
                    comm.Parameters.Add(prm);


                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Products");
                    podaci = ds.Tables["Products"];

                    if (podaci.Rows.Count > 0)
                    {
                        string tvornicka = podaci.Rows[0][1].ToString();
                        string rabat = podaci.Rows[0][2].ToString();
                        string akcijska = podaci.Rows[0][3].ToString();

                        string vrsta = podaci.Rows[0][0].ToString();

                        if (vrsta == "A") //pokupi akcijsku cijenu
                        {
                            nabavnaCijena = podaci.Rows[0][3].ToString().Replace(',', '.');
                        }
                        else if (vrsta == "S") //tvornička cijena - rabat
                        {
                            decimal nabavnaCijenaa = Math.Round(Convert.ToDecimal(podaci.Rows[0][1].ToString()) - Convert.ToDecimal(podaci.Rows[0][1].ToString()) * Convert.ToDecimal(podaci.Rows[0][2]) / 100, 2);
                            //round (dobavljacartikl.doa_tvornickacijena - (dobavljacartikl.doa_tvornickacijena * dobavljacartikl.doa_postorabata)/100, 5) as nabavnaCijena
                            nabavnaCijena = nabavnaCijenaa.ToString().Replace(',', '.');
                        }
                        else if (vrsta == "N") //nabavnu cijenu iz zaliha
                        {
                            //imam je pokupljenu gore kod F7 na grid sa cijenom i stanjem
                        }
                    }

                    decimal nabavnaa = Convert.ToDecimal(nabavnaCijena.ToString().Replace(".", ","));
                    decimal popust = Convert.ToDecimal(PopustStavka.ToString().Replace(".", ","));
                    decimal marzaa = Convert.ToDecimal(marza);
                    decimal cijenastavkaa = nabavnaa - (nabavnaa * popust / 100); //s popustom
                    decimal cijenastavkaaa = cijenastavkaa + (cijenastavkaa * marzaa / 100); //s 12% marze

                    //dodaj još 25% poreza



                    DataTable postoporeza = new DataTable();

                    veza.ExecuteQuery("select  porez.pz_posto from porez, poreznastopa,artikl where  porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>= '" + datum + "' and artikl.ar_ID = " + artiklID + "", ref postoporeza);

                    if (postoporeza.Rows.Count > 0)
                    {
                        decimal porez = Convert.ToDecimal(postoporeza.Rows[0][0].ToString());
                        decimal sPorezom = Math.Round(cijenastavkaaa + (cijenastavkaaa * porez / 100), 2);
                        cijenaStavka = sPorezom.ToString().Replace(',', '.');

                    }
                    else
                    {
                        decimal sPorezom = Math.Round(cijenastavkaaa + (cijenastavkaaa * 25 / 100), 2);
                        cijenaStavka = sPorezom.ToString().Replace(',', '.');
                    }
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void Spremi2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCijena.Text == "0,00" || txtCijena.Text == "0" || txtCijena.Text == "") //ako nema cijene provjeri popust
                {
                    if (txtPopustStavka.Text == "0,00" || txtPopustStavka.Text == "0" || txtPopustStavka.Text == "") //ako nema popusta
                    {
                        MessageBox.Show("Morate upisati ili cijenu ili popust!");
                        txtPopustStavka.Focus();
                    }
                    else if (txtPopustStavka.Text != "" || txtPopustStavka.Text != "0,00" || txtPopustStavka.Text != "0") //ako ima popusta
                    {
                        if (Convert.ToDecimal(txtPopustStavka.Text) > 0 && Convert.ToDecimal(txtPopustStavka.Text) < 100)
                        {
                            if (Convert.ToDecimal(txtKolicina.Text) <= 0)
                            {
                                MessageBox.Show("Količina vam je 0!! Provjerite!!");
                            }
                            else
                            {
                                spremi2();
                            }                           
                        }
                        else
                        {
                            MessageBox.Show("Postotak mora biti veći od 0 i manji od 100!!");
                        }
                    }
                }
                else //ako postoji cijena
                {
                    if (txtPopustStavka.Text != "0,00" && txtPopustStavka.Text != "0" && txtPopustStavka.Text != "") //ako ima popusta
                    {
                        MessageBox.Show("Morate upisati ili cijenu ili popust, ne oboje!");
                        txtPopustStavka.Focus();
                    }
                    else if (txtPopustStavka.Text == "" || txtPopustStavka.Text == "0,00" || txtPopustStavka.Text == "0") //ako nema popusta
                    {
                        spremi();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dohvatiPodatkeStavke()
        {
            try
            {
                if (txtKolicina.Text != "")
                {
                    kolicinaStavka = Convert.ToString(txtKolicina.Text).Replace(',', '.');
                }
                else
                {
                    kolicinaStavka = "0.00";
                }

                if (txtCijena.Text != "")
                {
                    cijenaStavka = Convert.ToString(txtCijena.Text).Replace(',', '.');
                }
                else
                {
                    cijenaStavka = "0";
                }

                if (txtPopustStavka.Text != "")
                {   
                    PopustStavka = Convert.ToString(txtPopustStavka.Text).Replace(',', '.');
                }
                else
                {
                    PopustStavka = "0";
                }

                datumODStavka = Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                datumDOStavka = Convert.ToDateTime(dtpDatumDO.Text).ToString("yyyy-MM-dd");


                if (cmbAktivnaStavka.Text == "Da")
                {
                    aktivnaStavka = 1;
                }
                else
                {
                    aktivnaStavka = 0;
                }

                if (glPartner.Text != "")
                {
                    sifraDobavljacStavka = glPartner.EditValue.ToString();

                    if (glPartner.Text.Length > 32)
                    {
                        nazivDobavljacStavka = glPartner.Text.Substring(0, 32);
                    }
                    else
                    {
                        nazivDobavljacStavka = glPartner.Text;
                    }
                }
                else
                {
                    sifraDobavljacStavka = "null";
                    nazivDobavljacStavka = "null";
                }

                if (ckbIstekRoka.Checked)
                {
                    vrijediDO = "'" + datumDOStavka + "'";
                }
                else 
                {
                    vrijediDO = "null";
                }

                bkKod = dohvati.DohvatiIDSifra("bk_kod", "mpman.snizenjestavka", "akcijezag_akc_ID = '" + idZag + "' and artikl_ar_sifra = '" + sifraArtiklaStavka + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlIzmjenaStavkiAkcije.Visible = false;
        }

        private void glPoslovnica_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dgSnizeni.RowCount > 0)
                {
                    //napravi string od šifri artikala koji su odabrani zasnizenje

                    DataTable podaci = new DataTable();
                    DataTable dat = new DataTable();

                    if (dgSnizeniStanja.RowCount > 0)
                    {
                        dgSnizeniArtikliStanja.DataSource = podaci;
                    }

                    if (dgartikliUAkcijiStavke.RowCount > 0)
                    {
                        dgArtikliUAkciji.DataSource = dat;
                    }

                    string sifreArtikala = "";

                    for (brojac = 0; brojac < dgSnizeni.RowCount; brojac++)
                    {
                        System.Data.DataRow row = dgSnizeni.GetDataRow(brojac);

                        if (sifreArtikala != "")
                        {
                            sifreArtikala = sifreArtikala + ",";
                        }
                        sifreArtikala = sifreArtikala + row[1].ToString();

                    }
                    //dohvati podatke za spajanje
                    DataTable podaciSpajanje = new DataTable();

                    int poslovnica = Convert.ToInt32(glPoslovnica.EditValue);
                    //string sifraPosl = dohvati.DohvatiIDSifra("po_sifra", "poslovnica", "po_ID = " + glPoslovnica.EditValue + " ");

                    veza.ExecuteQuery("select po_katalog, po_IPadresaPoslovnica from poslovnica where po_ID = " + poslovnica + "", ref podaciSpajanje);

                    if (podaciSpajanje.Rows.Count > 0)
                    {
                        IP = podaciSpajanje.Rows[0][1].ToString();
                        katalog = podaciSpajanje.Rows[0][0].ToString();
                    }

                    //spoji se na katalog trgovine i slektiraj artikle sa stanjima iz kataloga trgovine

                    connection = new MySqlConnection();
                    ConnectionString = "Server = " + IP + "; Database=" + katalog + "; Uid=admin10; Pwd=movema10; Connection Timeout=10;";
                    connection.ConnectionString = ConnectionString;

                    connection.Open();


                    MySqlCommand comm = new MySqlCommand(@"select artik.ar_naziv , zalihe.ar_sifra, zalihe.za_stanje, zalihe.za_nabcij, zalihe.za_maloprodcijena  from zalihe, artik where artik.AR_SIFRA = zalihe.AR_SIFRA and zalihe.ar_sifra in(" + sifreArtikala + ") ", connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    comm.ExecuteNonQuery();

                    adapter.Fill(podaci);

                    dgSnizeniArtikliStanja.DataSource = podaci;

                    connection.Close();

                    //napuni stavke ukoliko postoje za to zaglavlje i partnera i poslovnicu                   


                    veza.ExecuteQuery("select akcije.AR_SIFRA, akcije.AR_NAZIV, akcije.POK_KOLIC, akcije.AKC_POPUST, akcije.AKC_AKTIVNA, akcije.POK_VAZIOD, akcije.POK_VAZIDO, akcije.BK_KOD, akcije.akc_cijena from mpman.akcije where akcije.AKCIJEZAG_AKC_ID = " + idZag + " and poslovnica_po_ID = " + poslovnica + "", ref dat);
                    dgArtikliUAkciji.DataSource = dat;

                    if (dgartikliUAkcijiStavke.RowCount > 0)
                    {
                        panel12.Enabled = true; //ako ima stavki akcije omogući da se akcija pošalje u trgovine
                    }

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                //spoji se na replikaciju za tu trgovinu
                MessageBox.Show("Spajam se na trgovinu lokalno...");
                spajanjelokalno();
            }
        }

        private void spajanjelokalno()
        {
            try
            {
                if (dgSnizeni.RowCount > 0)
                {
                    //napravi string od šifri artikala koji su odabrani zasnizenje

                    DataTable podaci = new DataTable();
                    DataTable dat = new DataTable();

                    if (dgSnizeniStanja.RowCount > 0)
                    {
                        dgSnizeniArtikliStanja.DataSource = podaci;
                    }

                    if (dgartikliUAkcijiStavke.RowCount > 0)
                    {
                        dgArtikliUAkciji.DataSource = dat;
                    }

                    string sifreArtikala = "";

                    for (brojac = 0; brojac < dgSnizeni.RowCount; brojac++)
                    {
                        System.Data.DataRow row = dgSnizeni.GetDataRow(brojac);

                        if (sifreArtikala != "")
                        {
                            sifreArtikala = sifreArtikala + ",";
                        }
                        sifreArtikala = sifreArtikala + row[1].ToString();

                    }
                    //dohvati podatke za spajanje
                    DataTable podaciSpajanje = new DataTable();

                    int poslovnica = Convert.ToInt32(glPoslovnica.EditValue);
                    //string sifraPosl = dohvati.DohvatiIDSifra("po_sifra", "poslovnica", "po_ID = " + glPoslovnica.EditValue + " ");

                    veza.ExecuteQuery("select po_katalog, po_IPadresa from poslovnica where po_ID = " + poslovnica + "", ref podaciSpajanje);

                    if (podaciSpajanje.Rows.Count > 0)
                    {
                        IP = podaciSpajanje.Rows[0][1].ToString();
                        katalog = podaciSpajanje.Rows[0][0].ToString();
                    }

                    //spoji se na katalog trgovine i slektiraj artikle sa stanjima iz kataloga trgovine

                    connection = new MySqlConnection();
                    ConnectionString = "Server = " + IP + "; Database=" + katalog + "; Uid=admin10; Pwd=movema10; Connection Timeout=10;";
                    connection.ConnectionString = ConnectionString;

                    connection.Open();


                    MySqlCommand comm = new MySqlCommand(@"select artik.ar_naziv , zalihe.ar_sifra, zalihe.za_stanje, zalihe.za_nabcij  from zalihe, artik where artik.AR_SIFRA = zalihe.AR_SIFRA and zalihe.ar_sifra in(" + sifreArtikala + ") ", connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    comm.ExecuteNonQuery();

                    adapter.Fill(podaci);

                    dgSnizeniArtikliStanja.DataSource = podaci;

                    connection.Close();

                    //napuni stavke ukoliko postoje za to zaglavlje i partnera i poslovnicu                   


                    veza.ExecuteQuery("select akcije.AR_SIFRA, akcije.AR_NAZIV, akcije.POK_KOLIC, akcije.AKC_POPUST, akcije.AKC_AKTIVNA, akcije.POK_VAZIOD, akcije.POK_VAZIDO, akcije.BK_KOD, akcije.akc_cijena from mpman.akcije where akcije.AKCIJEZAG_AKC_ID = " + idZag + " and poslovnica_po_ID = " + poslovnica + "", ref dat);
                    dgArtikliUAkciji.DataSource = dat;

                    if (dgartikliUAkcijiStavke.RowCount > 0)
                    {
                        panel12.Enabled = true; //ako ima stavki akcije omogući da se akcija pošalje u trgovine
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void dgArtikliUAkciji_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgartikliUAkcijiStavke.RowCount > 0)
                {
                    if (e.KeyCode == Keys.F4)
                    {
                        pnlIzmjenaStavkiAkcije.Visible = true;

                        txtOpisStavka.Focus();

                        //provjeri da li već postoji, ako da otvori za ažuriranje

                        System.Data.DataRow row = dgartikliUAkcijiStavke.GetDataRow(dgartikliUAkcijiStavke.FocusedRowHandle);

                        if (row != null)
                        {
                            sifraArtiklaStavka = row[0].ToString();
                            nazivArtiklaStavka = dohvati.DohvatiIDSifra("ar_naziv", "artikl", "ar_sifra = '" + sifraArtiklaStavka + "'");
                            //nazivArtiklaStavka = '"' + row[1].ToString() + '"';
                        }
                        DataTable akcijaStavke = new DataTable();

                        poslovnicaIDStavka = glPoslovnica.EditValue.ToString();

                        brojAkcije = Convert.ToInt32(txtBrojAkcije.Text);

                        veza.ExecuteQuery("select akc_ID , akcijezag_akc_ID, pok_opis, ar_sifra, pok_kolic, akc_popust, pok_vaziod, pok_vazido, akc_aktivna, akc_cijena, pok_vrijedido from mpman.akcije where akcije.ar_sifra = '" + sifraArtiklaStavka + "' and akcije.pok_sifra = 16 and akcije.akc_broj = '" + brojAkcije + "' and akcije.POSLOVNICA_PO_ID ='" + poslovnicaIDStavka + "'", ref akcijaStavke);

                        if (akcijaStavke.Rows.Count > 0) //postoji artikl u stavkama odabrane akcije za tog partnera i poslovnicu
                        {
                            //ažuriraj
                            azurirati = 1;

                            //napuni formu

                            IDStavkaAkcije = akcijaStavke.Rows[0][0].ToString();

                            txtOpisStavka.Text = akcijaStavke.Rows[0][2].ToString();

                            if (akcijaStavke.Rows[0][4].ToString() != "")
                            {
                                txtKolicina.Text = akcijaStavke.Rows[0][4].ToString();
                            }


                            if (akcijaStavke.Rows[0][5].ToString() == "" || akcijaStavke.Rows[0][5].ToString() == "0,00" || akcijaStavke.Rows[0][5].ToString() == "0")
                            {                                
                                txtPopustStavka.Text = "";

                                if (akcijaStavke.Rows[0][9].ToString() != "")
                                {
                                    txtCijena.Text = akcijaStavke.Rows[0][9].ToString();
                                }
                            }                           
                            else
                            {
                                txtPopustStavka.Text = akcijaStavke.Rows[0][5].ToString();
                                txtCijena.Text = "";
                            }


                            dtpDatumOD.Text = akcijaStavke.Rows[0][6].ToString();
                            dtpDatumDO.Text = akcijaStavke.Rows[0][7].ToString();

                            if (akcijaStavke.Rows[0][8].ToString() == "True")
                            {
                                cmbAktivnaStavka.Text = "Da";
                            }
                            else
                            {
                                cmbAktivnaStavka.Text = "Ne";
                            }

                            string a = akcijaStavke.Rows[0][10].ToString();
                            if (akcijaStavke.Rows[0][10].ToString() != "")
                            {
                                ckbIstekRoka.Checked = true;
                            }
                            else
                            {   
                                ckbIstekRoka.Checked = false;

                            }
                            

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            DataTable operaterModul = new DataTable();

            veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = " + Global.KorisnikID + " and opov_modul = 'AKCIJETRGOVINA' ", ref operaterModul);

            if (operaterModul.Rows.Count > 0)
            {
                frmAkcijeZaTrgovinu _frm;
                foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmAkcijeZaTrgovinu))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmAkcijeZaTrgovinu();
                _frm.MdiParent = frmMain.ActiveForm;
                _frm.oznaka = "S"; //S - sniženi artikli od dobavljača
                _frm.AkcijaBroj = txtBrojAkcije.Text.Trim();
                _frm.Show();

                this.Close();
            }
        }

        private void glPoslovnica_EditValueChanged(object sender, EventArgs e)
        {
            DataTable podaci = new DataTable();
            DataTable dat = new DataTable();

            if (dgSnizeniStanja.RowCount > 0)
            {
                dgSnizeniArtikliStanja.DataSource = podaci;
            }

            if (dgartikliUAkcijiStavke.RowCount > 0)
            {
                dgArtikliUAkciji.DataSource = dat;
            }
        }

        private void txtKolicina_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtKolicina.Text == "" || txtKolicina.Text == "0" || txtKolicina.Text == "0,000")
                {
                    MessageBox.Show("Unesite količinu!");
                }
                else if (Convert.ToDecimal(txtKolicina.Text) > 1000)
                {
                    MessageBox.Show("Količina vam je veća od  1000!! Provjerite!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtCijena_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCijena.Text != "0,00" && txtCijena.Text != "0" && txtCijena.Text != "" && txtPopustStavka.Text != "")
                {
                    if (Convert.ToDecimal(txtCijena.Text) > 0 && Convert.ToDecimal(txtCijena.Text) < 500)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Cijena mora biti veća od 0 i manja od 500!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtKolicina_Enter(object sender, EventArgs e)
        {
            txtKolicina = sender as DevExpress.XtraEditors.TextEdit;
            if (txtKolicina != null)
                txtKolicina.SelectAll();
        }

        private void txtPopustStavka_Enter(object sender, EventArgs e)
        {
            txtPopustStavka = sender as DevExpress.XtraEditors.TextEdit;
            if (txtPopustStavka != null)
                txtPopustStavka.SelectAll();
        }

        private void txtCijena_Enter(object sender, EventArgs e)
        {
            txtCijena = sender as DevExpress.XtraEditors.TextEdit;
            if (txtCijena != null)
                txtCijena.SelectAll();
        }

        private void dtpDatumDO_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dtpDatumDO.Value < dtpDatumOD.Value)
                {
                    MessageBox.Show("Datum do kada ne smije biti prije datum od kada!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    dtpDatumDO.ResetText();
                    dtpDatumDO.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpODKada_Enter(object sender, EventArgs e)
        {
            if (_oznaka == "F4")
            {
                //update
            }
            else
            {
                if (dtpODKada.Text == " ")
                {
                    //dtpODKada.Format = DateTimePickerFormat.Short;
                    dtpODKada.Value = DateTime.Now;
                }
            }
        }

        private void dtpODKada_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
            dtpODKada.Format = DateTimePickerFormat.Short;
        }

        private void dtpDOKada_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
            dtpDOKada.Format = DateTimePickerFormat.Short;
        }

        private void dtpDOKada_Enter(object sender, EventArgs e)
        {
            if (_oznaka == "F4")
            {
                //update
            }
            else
            {
                if (dtpDOKada.Text == " ")
                {
                    //dtpDOKada.Format = DateTimePickerFormat.Short;
                    dtpDOKada.Value = DateTime.Now;
                }
            }          
        }

        private void dtpDatumOD_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
            dtpDatumOD.Format = DateTimePickerFormat.Short;
        }

        private void dtpDatumOD_Enter(object sender, EventArgs e)
        {
            if (azurirati == 1)
            {
                //update
            }
            else
            {

                if (dtpDatumOD.Text == " ")
                {
                    dtpDatumOD.Value = DateTime.Now;
                }
            }
        }

        private void dtpDatumDO_Enter(object sender, EventArgs e)
        {
            if (azurirati == 1)
            {
                //update
            }
            else
            {
                if (dtpDatumDO.Text == " ")
                {
                    dtpDatumDO.Value = DateTime.Now;
                }
            }
        }

        private void dtpDatumDO_ValueChanged(object sender, EventArgs e)
        {
            //SendKeys.Send("{RIGHT}");
            dtpDatumDO.Format = DateTimePickerFormat.Short;
        }
    }
}
