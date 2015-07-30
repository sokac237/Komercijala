using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;

namespace blokerX
{
    public partial class frmNovaAkcijaStavke : Form
    {
        Upiti veza = new Upiti();
        DataTable stavke = new DataTable();

        int provjeraPostotakPospusta;

        string _SifraAkcije;
        string _brojAkcije;
        string _popust;
        string _od;
        string _do;
        string _oznaka;
        string _idzaglavlja;
        string _idstavka;
        string _opis;


        string opis;
        string opis2;
        string danUtjednu;
        string ARsifra;
        string ARnaziv;
        string iznosRacuna;
        string kolicina;
        string Popust;
        string robnaGrupa;
        string datumOD;
        string datumDO;
        string vrijemeOD;
        string vrijemeDO;
        string brojKomada;
        int aktivna;
        string status;
        string sifraDobavljac;
        string nazivDobavljac;
        string vrijediOD;
        string vrijediDO;
        string AkcijaID;
        int postojiArtiklUAkciji;

        string cijena;


        public frmNovaAkcijaStavke()
        {
            InitializeComponent();
        }

        public string IDZaglavlja
        {
            get { return _idzaglavlja; }
            set { _idzaglavlja = value; }
        }

        public string sifraAkcije
        {
            get { return _SifraAkcije; }
            set { _SifraAkcije = value; }
        }

        public string brojAkcije
        {
            get { return _brojAkcije; }
            set { _brojAkcije = value; }
        }

        public string popust
        {
            get { return _popust; }
            set { _popust = value; }
        }

        public string OD
        {
            get { return _od; }
            set { _od = value; }           
        }

        public string DO
        {
            get { return _do; }
            set { _do = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string IDstavka
        {
            get { return _idstavka; }
            set { _idstavka = value; }
        }

        public string opisZag
        {
            get { return _opis; }
            set { _opis = value; }
        }


        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniFormu()
        {
            try
            {
                if (stavke.Rows[0][0].ToString() != "")
                {
                    txtOpis.Text = stavke.Rows[0][0].ToString();
                }
                else
                {
                    txtOpis.Text = "";
                }

                if (stavke.Rows[0][1].ToString() != "")
                {
                    txtOpis2.Text = stavke.Rows[0][1].ToString();
                }
                else
                {
                    txtOpis2.Text = "";
                }

                if (stavke.Rows[0][14].ToString() != "")
                {
                    int a = Convert.ToInt32(stavke.Rows[0][14]);

                    if (a == 1){cmbDanUTjednu.Text = "1 - Nedjelja";}
                    else if (a == 2) { cmbDanUTjednu.Text = "2 - Ponedjeljak"; }
                    else if (a == 3) { cmbDanUTjednu.Text = "3 - Utorak"; }
                    else if (a == 4) { cmbDanUTjednu.Text = "4 - Srijeda"; }
                    else if (a == 5) { cmbDanUTjednu.Text = "5 - Četvrtak"; }
                    else if (a == 6) { cmbDanUTjednu.Text = "6 - Petak"; }
                    else if (a == 7) { cmbDanUTjednu.Text = "7 - Subota"; }                    
                }
                else
                {
                    danUtjednu = "";
                }

                if (stavke.Rows[0][3].ToString() != "")
                {
                    txtSifraArtikla.Text = stavke.Rows[0][3].ToString();
                }
                else
                {
                    ARsifra = "";
                    ARnaziv = "";
                }

                if (stavke.Rows[0][5].ToString() != "")
                {
                    txtIznosRacuna.Text = stavke.Rows[0][5].ToString();
                }

                if (stavke.Rows[0][6].ToString() != "")
                {
                    txtKolicina.Text = stavke.Rows[0][6].ToString();
                }

                if (stavke.Rows[0][13].ToString() != "")
                {
                    txtPopust.Text = stavke.Rows[0][13].ToString();
                }
                else
                {
                    txtPopust.Text = "";
                }

                if (stavke.Rows[0][2].ToString() != "")
                {
                    txtRobnaGrupa.Text = stavke.Rows[0][2].ToString();
                }
                else
                {
                    robnaGrupa = "";
                }

                dtpDatumOD.Text = stavke.Rows[0][8].ToString();
                dtpDatumDO.Text = stavke.Rows[0][9].ToString();



                dtpVrijemeOD.Text = stavke.Rows[0][10].ToString();
                dtpVrijemeDO.Text = stavke.Rows[0][11].ToString();

                if (stavke.Rows[0][7].ToString() != "")
                {

                    int a = Convert.ToInt32(stavke.Rows[0][7]);
                    //cmbBrojKupona.Text.Substring(0, 1);
                    if (a == 0) 
                    {
                        cmbBrojKupona.Text = "0 - prema visini računa";
                    }
                    else if (a == 1)
                    {
                        cmbBrojKupona.Text = "1 - 1 kupon";
                    }
                    else if (a == 2)
                    {
                        cmbBrojKupona.Text = "2 - 2 kupona";
                    }
                    else if (a == 3)
                    {
                        cmbBrojKupona.Text = "3 - 3 kupona";
                    }
                }

                if (stavke.Rows[0][12].ToString() == "True")
                {
                    cmbAktivna.Text = "Da";
                }
                else
                {
                    cmbAktivna.Text = "Ne";
                }

                if (stavke.Rows[0][15].ToString() != "")
                {
                    txtStatusKupca.Text = stavke.Rows[0][15].ToString(); ;
                }
                else
                {
                    txtStatusKupca.Text = "";
                }

                if (stavke.Rows[0][16].ToString() != "")
                {
                    glDobavljac.EditValue = stavke.Rows[0][16];
                }

                dtpVrijediOD.Text = stavke.Rows[0][18].ToString();
                dtpVrijediDO.Text = stavke.Rows[0][19].ToString();

                if (_SifraAkcije == "18")
                {
                    txtPopust.Text = stavke.Rows[0][20].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNovaAkcijaStavke_Load(object sender, EventArgs e)
        {

            if (_oznaka == "I") //insert
            {
                PrikaziStoTreba();
                popuniPoljaSifraAkcije13();
                cmbAktivna.Text = "Da";
                dtpDatumOD.Text = _od;
                dtpDatumDO.Text = _do;
                txtOpis.Text = _opis;
                dtpVrijemeOD.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 00);
                dtpVrijemeDO.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            }
            else   //update
            {
                try
                {
                    PrikaziStoTreba();

                    glKategorija.EditValue = _SifraAkcije;
                    txtBrojAkcije.Text = _brojAkcije;
                    //popuni formu podacima iz baze
                    veza.ExecuteQuery("select pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada,pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, pok_danutjednu,kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediod, pok_vrijedido, akc_cijena from mpman.akcije where akc_ID = " + _idstavka + " ", ref stavke);
                    popuniFormu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // TODO: This line of code loads data into the 'kategorijeAkcija.kategorijeAkcija' table. You can move, or remove it, as needed.
            this.kategorijeAkcijaTableAdapter.Fill(this.kategorijeAkcija.kategorijeAkcija);
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);

            glKategorija.EditValue = _SifraAkcije;
            txtBrojAkcije.Text = _brojAkcije;                        
        }

        private void popuniPoljaSifraAkcije13()
        {
            try
            {
                //dohvatiti ako postoji barem jedna stavka podatke opis, opis2, iznos i  broj kupona (komada)
                if (_oznaka == "I")
                {
                    DataTable podaci = new DataTable();

                    veza.ExecuteQuery("select pok_opis2, pok_iznos, pok_komada from mpman.akcije where akcijezag_akc_ID = "+_idzaglavlja+"", ref podaci);

                    if (podaci.Rows.Count > 0)
                    {
                        txtOpis2.Text = podaci.Rows[0][0].ToString();
                        txtIznosRacuna.EditValue = podaci.Rows[0][1];


                        int a = Convert.ToInt32(podaci.Rows[0][2]);
                        //cmbBrojKupona.Text.Substring(0, 1);
                        if (a == 0)
                        {
                            cmbBrojKupona.Text = "0 - prema visini računa";
                        }
                        else if (a == 1)
                        {
                            cmbBrojKupona.Text = "1 - 1 kupon";
                        }
                        else if (a == 2)
                        {
                            cmbBrojKupona.Text = "2 - 2 kupona";
                        }
                        else if (a == 3)
                        {
                            cmbBrojKupona.Text = "3 - 3 kupona";
                        }

                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrikaziStoTreba()
        {
            try
            {
                if (_SifraAkcije == "1")
                {
                    cmbDanUTjednu.Enabled = true;
                    txtPopust.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                }
                else if (_SifraAkcije == "2")
                {
                    txtPopust.Enabled = true;
                    txtIznosRacuna.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    dtpVrijemeOD.Enabled = true;
                    dtpVrijemeDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "3")
                {
                    txtPopust.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    dtpVrijemeOD.Enabled = true;
                    dtpVrijemeDO.Enabled = true;
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "4")
                {
                    txtPopust.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    dtpVrijemeOD.Enabled = true;
                    dtpVrijemeDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "5")
                {
                    cmbAktivna.Enabled = true;
                    txtPopust.EditValue = _popust;
                    txtSifraArtikla.Enabled = true;
                    dtpDatumOD.Text = _od;
                    dtpDatumDO.Text = _do;
                }
                else if (_SifraAkcije == "6")
                {
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    txtIznosRacuna.Enabled = true;
                    cmbBrojKupona.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "7")
                {
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    txtSifraArtikla.Enabled = true;
                    cmbBrojKupona.Enabled = true;

                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                    dtpVrijediOD.Enabled = true;
                    dtpVrijediDO.Enabled = true;


                    if (Global.akcija13dobavljac != "")
                    {
                        //ako ima partner otvara se polje pok iznos
                        //pok_kolic je fiksno 1
                        //to se povlaci na svaku sljedeću stavku

                        txtIznosRacuna.Enabled = true;
                        txtKolicina.Enabled = true;

                        txtKolicina.EditValue = 1;
                        txtKolicina.Properties.ReadOnly = true;



                        if (_oznaka == "A")
                        {
                            //azuriranje - onemoguci neka polja ako postoji dobavljac
                            txtIznosRacuna.Enabled = false;
                            txtKolicina.Enabled = false;
                            cmbBrojKupona.Enabled = false;
                            //dtpDatumOD.Enabled = false;
                            //dtpDatumDO.Enabled = false;
                        }
                    }
                    else
                    {
                        //nema partnera popunjava se pok_kolic
                        txtKolicina.Enabled = true;
                    }


                  
                }
                else if (_SifraAkcije == "8")
                {
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    txtIznosRacuna.Enabled = true;
                    cmbBrojKupona.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "9")
                {
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    txtIznosRacuna.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "10")
                {
                    txtRobnaGrupa.Enabled = true;
                    cmbAktivna.Enabled = true;
                    dtpDatumOD.Text = _od;
                    dtpDatumDO.Text = _do;
                }
                else if (_SifraAkcije == "11")
                {
                    cmbAktivna.Enabled = true;
                    txtPopust.EditValue = _popust;
                    txtRobnaGrupa.Enabled = true;
                    dtpDatumOD.Text = _od;
                    dtpDatumDO.Text = _do;
                    dtpVrijemeOD.Enabled = true;
                    dtpVrijemeDO.Enabled = true;
                }
                else if (_SifraAkcije == "12")
                {
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                }
                else if (_SifraAkcije == "13")
                {
                    //datOD i datDO preuzimam iz zag
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;

                    //opis - naziv dobavljaca
                    //opis 2 - nagrada
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;

                    //sifraAkcije artikla

                    txtSifraArtikla.Enabled = true;

                    cmbAktivna.Enabled = true;

                    //treba i replicira se na sve isto
                    cmbBrojKupona.Enabled = true;


                    if (Global.akcija13dobavljac != "")
                    {
                        //ako ima partner otvara se polje pok iznos
                        //pok_kolic je fiksno 1
                        //to se povlaci na svaku sljedeću stavku

                        txtIznosRacuna.Enabled = true;
                        txtKolicina.Enabled = true;

                        txtKolicina.EditValue = 1;
                        txtKolicina.Properties.ReadOnly = true;



                        if (_oznaka == "A")
                        {
                            //azuriranje - onemoguci neka polja ako postoji dobavljac
                            txtIznosRacuna.Enabled = false;
                            txtKolicina.Enabled = false;
                            cmbBrojKupona.Enabled = false;
                            dtpDatumOD.Enabled = false;
                            dtpDatumDO.Enabled = false;
                        }
                    }
                    else
                    {
                        //nema partnera popunjava se pok_kolic
                        txtKolicina.Enabled = true;
                    }


                  
                }
                else if (_SifraAkcije == "14")
                {
                    txtPopust.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                    dtpVrijemeOD.Enabled = true;
                    dtpVrijemeDO.Enabled = true;
                }
                else if (_SifraAkcije == "15")
                {
                    txtIznosRacuna.Enabled = true;
                    cmbBrojKupona.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    dtpVrijediOD.Enabled = true;
                    dtpVrijediDO.Enabled = true;
                }
                else if (_SifraAkcije == "17")
                {
                    txtOpis.Enabled = true;
                    txtSifraArtikla.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                    txtPopust.Enabled = true;
                }
                else if (_SifraAkcije == "18")
                {
                    label10.Text = "Cijena:";
                    txtOpis.Enabled = true;
                    txtOpis2.Enabled = true;
                    txtSifraArtikla.Enabled = true;
                    txtKolicina.Enabled = true;
                    dtpDatumOD.Enabled = true;
                    dtpDatumDO.Enabled = true;
                    cmbAktivna.Enabled = true;
                    txtPopust.Enabled = true; //ovo spremaj u polje akc_cijena
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSifraArtikla_TextChanged(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();
            if (txtSifraArtikla.Text != "")
            {
                veza.ExecuteQuery("select ar_naziv from artikl where ar_sifra = '" + txtSifraArtikla.Text + "'", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblNazivArtikla.Text = bar.Rows[0][0].ToString();
                }
                else
                {
                    lblNazivArtikla.Text = "___";
                }
            }
            else
            {
                lblNazivArtikla.Text = "___";
            }
        }

        private void txtSifraArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmSifarnikArtikala _frm = new frmSifarnikArtikala();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifraArtikla.Text = _frm.ArtiklSifra;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtSifraArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            //}
        }

        private void txtRobnaGrupa_TextChanged(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();

            if (txtRobnaGrupa.Text != "")
            {
                veza.ExecuteQuery("select rg_naziv from robnagrupa where rg_sifra = '" + txtRobnaGrupa.Text + "'", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblRobnaGrupa.Text = bar.Rows[0][0].ToString();
                }
                else
                {
                    lblRobnaGrupa.Text = "___";
                }
            }     
        }

        private void txtRobnaGrupa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmRobneGrupe _frm = new frmRobneGrupe();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtRobnaGrupa.Text = _frm.RGSifra;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtRobnaGrupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmNovaAkcijaStavke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

            private void provjeriPostotakPopusta()
        {
            try
            {
                if (txtPopust.Enabled == true)
                {
                    decimal postotak = Convert.ToDecimal(txtPopust.EditValue);
                    if (postotak > 0)
                    {
                        provjeraPostotakPospusta = 1;
                    }
                    else
                    {
                        provjeraPostotakPospusta = 0;
                    }
                }
                else
                {
                    //ako je onemogućen pusti popust
                    provjeraPostotakPospusta = 1;

                    //decimal postotak = Convert.ToDecimal(txtPopust.EditValue);
                    //if (postotak > 0)
                    //{
                    //    provjeraPostotakPospusta = 1;
                    //}
                    //else
                    //{
                    //    provjeraPostotakPospusta = 0;
                    //}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void provjeriPostojiLiArtiklVecDodan()
        {
            try
            {
                DataTable stackaPostoji = new DataTable();

                veza.ExecuteQuery("select akc_ID from mpman.akcije where akcijezag_akc_ID =  " + _idzaglavlja + " and ar_sifra = '" + txtSifraArtikla.Text + "'", ref stackaPostoji);


                if (stackaPostoji.Rows.Count > 0)
                {
                    MessageBox.Show("Ovaj artikl već je dodan u ovu akciju, možete ga vidjeti na popisu i ažurirati!!");
                    postojiArtiklUAkciji = 1;
                    this.Close();
                }
                else
                {
                    postojiArtiklUAkciji = 0;
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
                if (glKategorija.EditValue.ToString() == "17")
                {
                    if (txtSifraArtikla.Enabled = true && lblNazivArtikla.Text != "___")
                    {
                        if (postojiArtiklUAkciji != 1)
                        {
                            provjeriPostotakPopusta();

                            if (provjeraPostotakPospusta == 1)
                            {
                                if (txtSifraArtikla.Text.Trim().Length == 6)
                                {
                                    string barkod = "00" + txtSifraArtikla.Text;

                                    if (_oznaka == "I") //insert
                                    {
                                        provjeriPostojiLiArtiklVecDodan();

                                        if (postojiArtiklUAkciji != 1)
                                        {
                                            PokupiPodatke();


                                            //MessageBox.Show("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO) values ('" + AkcijaID + "', '" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", " + ARsifra + ", " + ARnaziv + ", '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "')");
                                            veza.ExecuteQuery("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO, bk_kod) values ('" + AkcijaID + "', '" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", '" + ARsifra + "', '" + ARnaziv + "', '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "', '" + barkod + "')");

                                            MessageBox.Show("Uspješno ste dodali zapis!");
                                            this.Close();
                                            Global.akcijaZagID = AkcijaID;
                                            Global.akcijaSifra = _SifraAkcije;
                                            Global.akcijaBroj = _brojAkcije;
                                            frmNovaAkcija.osvjezi.PerformClick();
                                        }
                                    }
                                    else //update
                                    {
                                        PokupiPodatke();

                                        //MessageBox.Show("update mpman.akcije set pok_opis = '" + opis + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", ar_sifra = " + ARsifra + ", ar_naziv = " + ARnaziv + ",pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "' where akc_ID = " + _idstavka + "");
                                        veza.ExecuteQuery(@"update mpman.akcije set pok_opis = '" + opis + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", ar_sifra = '" + ARsifra + "', ar_naziv = '" + ARnaziv + "',pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "', bk_kod = '" + barkod + "' where akc_ID = " + _idstavka + "");

                                        MessageBox.Show("Uspješno ste ažurirali zapis!");
                                        this.Close();
                                        frmNovaAkcija.osvjezi.PerformClick();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Šifra artikla mora biti duga 6 znamenki!!");
                                    txtSifraArtikla.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Postotak popusta nesmije biti 0 % !");
                                txtPopust.Focus();
                            }
                        }
                    }
                    else                    
                    {
                        txtSifraArtikla.Enabled = true;
                        txtSifraArtikla.Focus();
                    }
                }
                else //sve ostale akcije osima 16 i 17   
                {
                    if (txtSifraArtikla.Enabled = true && lblNazivArtikla.Text != "___")
                    {
                        if (postojiArtiklUAkciji != 1)
                        {
                            provjeriPostotakPopusta();

                            if (provjeraPostotakPospusta == 1)
                            {

                                if (_oznaka == "I") //insert
                                {
                                    provjeriPostojiLiArtiklVecDodan();
                                    if (postojiArtiklUAkciji != 1)
                                    {
                                        PokupiPodatke();
                                        //MessageBox.Show("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO) values ('" + AkcijaID + "', '" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", " + ARsifra + ", " + ARnaziv + ", '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "')");
                                        veza.ExecuteQuery("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO, akc_cijena) values ('" + AkcijaID + "', '" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", '" + ARsifra + "', '" + ARnaziv + "', '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "', '"+cijena+"')");

                                        MessageBox.Show("Uspješno ste dodali zapis!");
                                        this.Close();
                                        Global.akcijaZagID = AkcijaID;
                                        Global.akcijaSifra = _SifraAkcije;
                                        Global.akcijaBroj = _brojAkcije;
                                        frmNovaAkcija.osvjezi.PerformClick();
                                    }
                                }
                                else //update
                                {
                                    PokupiPodatke();
                                    //MessageBox.Show("update mpman.akcije set pok_opis = '" + opis + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", ar_sifra = '" + ARsifra + "', ar_naziv = '" + ARnaziv + "',pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "', akc_cijena = '"+cijena+"' where akc_ID = " + _idstavka + "");
                                    veza.ExecuteQuery(@"update mpman.akcije set pok_opis = '" + opis + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", ar_sifra = '" + ARsifra + "', ar_naziv = '" + ARnaziv + "',pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "', akc_cijena = '"+cijena+"' where akc_ID = " + _idstavka + "");

                                    MessageBox.Show("Uspješno ste ažurirali zapis!");
                                    this.Close();
                                    frmNovaAkcija.osvjezi.PerformClick();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Postotak popusta nesmije biti 0 % !");
                                txtPopust.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (postojiArtiklUAkciji != 1)
                        {
                            provjeriPostotakPopusta();

                            if (provjeraPostotakPospusta == 1)
                            {

                                if (_oznaka == "I") //insert
                                {

                                    PokupiPodatke();
                                    //MessageBox.Show("insert into mpman.akcije (akcijezag_akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO) values ('" + AkcijaID + "', '" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "')");
                                    veza.ExecuteQuery("insert into mpman.akcije (akcijezag_akc_ID, ar_naziv, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust,  pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediOD, pok_vrijediDO) values ('" + AkcijaID + "', '"+ARnaziv+"','" + _SifraAkcije + "' , '" + _brojAkcije + "', '" + opis + "', '" + opis2 + "', " + robnaGrupa + ", '" + iznosRacuna + "', '" + kolicina + "', '" + brojKomada + "', '" + datumOD + "', '" + datumDO + "', '" + vrijemeOD + "', '" + vrijemeDO + "', '" + aktivna + "', '" + Popust + "', " + danUtjednu + ", " + status + ", " + sifraDobavljac + ", " + nazivDobavljac + ", '" + vrijediOD + "', '" + vrijediDO + "')");

                                    MessageBox.Show("Uspješno ste dodali zapis!");
                                    this.Close();
                                    Global.akcijaZagID = AkcijaID;
                                    Global.akcijaSifra = _SifraAkcije;
                                    Global.akcijaBroj = _brojAkcije;
                                    frmNovaAkcija.osvjezi.PerformClick();

                                }
                                else //update
                                {
                                    PokupiPodatke();
                                    //MessageBox.Show("update mpman.akcije set pok_opis = '" + opis + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", ar_sifra = " + ARsifra + ", ar_naziv = " + ARnaziv + ",pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "' where akc_ID = " + _idstavka + "");
                                    veza.ExecuteQuery(@"update mpman.akcije set pok_opis = '" + opis + "', ar_naziv = '" + ARnaziv + "', pok_opis2 = '" + opis2 + "', rg_sifra = " + robnaGrupa + ", pok_iznos = '" + iznosRacuna + "', pok_kolic = '" + kolicina + "', pok_komada = '" + brojKomada + "', pok_vaziod = '" + datumOD + "', pok_vazido = '" + datumDO + "', pok_odsat = '" + vrijemeOD + "', pok_dosat = '" + vrijemeDO + "', akc_aktivna = '" + aktivna + "', akc_popust = '" + Popust + "',  pok_danutjednu = " + danUtjednu + ", kup_statk = " + status + ", ar_sifradob = " + sifraDobavljac + ", ar_nazivdob = " + nazivDobavljac + ", pok_vrijediOD = '" + vrijediOD + "', pok_vrijediDO = '" + vrijediDO + "' where akc_ID = " + _idstavka + "");

                                    MessageBox.Show("Uspješno ste ažurirali zapis!");
                                    this.Close();
                                    frmNovaAkcija.osvjezi.PerformClick();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Postotak popusta nesmije biti 0 % !");
                                txtPopust.Focus();
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

        private void cmbDanUTjednu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanUTjednu.Text.Substring(0, 1) == "1")
            {
                if (txtOpis.Text.Length > 8 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 8, 8) == "Nedjelja")
                { 
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Nedjelja";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "2")
            {
                if (txtOpis.Text.Length > 10 && txtOpis.Text.Substring(txtOpis.Text.Length - 10, 10) == "Ponedjeljak")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Ponedjeljak";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "3")
            {
                if (txtOpis.Text.Length > 6 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 6, 6) == "Utorak")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Utorak";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "4")
            {
                if (txtOpis.Text.Length > 7 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 7, 7) == "Srijeda")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Srijeda";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "5")
            {
                if (txtOpis.Text.Length > 8 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 8, 8) == "Četvrtak")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Četvrtak";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "6")
            {
                if (txtOpis.Text.Length > 5 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 5, 5) == "Petak")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Petak";
                }
            }
            else if (cmbDanUTjednu.Text.Substring(0, 1) == "7")
            {
                if (txtOpis.Text.Length > 6 &&  txtOpis.Text.Substring(txtOpis.Text.Length - 6, 6) == "Subota")
                {
                    return;
                }
                else
                {
                    txtOpis.Text = txtOpis.Text + "- Subota";
                }
                txtOpis.Text = txtOpis.Text + "- Subota";
            }
        }

        private void PokupiPodatke()
        {
            try
            {
                DataTable IDakcije = new DataTable();
                veza.ExecuteQuery("select akc_ID from mpman.akcijezag where pok_sifra = '" + _SifraAkcije + "' and akc_broj = '" + _brojAkcije + "'", ref IDakcije);

                if (IDakcije.Rows.Count > 0)
                {
                    AkcijaID = IDakcije.Rows[0][0].ToString();
                }

                if (txtOpis.Text != "")
                {
                    opis = txtOpis.Text.Trim();
                }
                else
                {
                    opis = "";
                }

                if (txtOpis2.Text != "")
                {
                    opis2 = txtOpis2.Text.Trim();
                }
                else
                {
                    opis2 = "";
                }

                if (cmbDanUTjednu.Text != "")
                {
                    danUtjednu = cmbDanUTjednu.Text.Substring(0, 1);
                }
                else 
                {
                    danUtjednu = "default";
                }

                if (lblNazivArtikla.Text != "___")
                {
                    ARsifra = txtSifraArtikla.Text;
                    ARnaziv = lblNazivArtikla.Text;
                }
                else
                {
                    ARsifra = "default";
                    ARnaziv = "default";
                }

                if (txtIznosRacuna.Text != "")
                {
                    iznosRacuna = Convert.ToString(txtIznosRacuna.Text).Replace(',', '.');
                }
                else
                {
                    iznosRacuna = "0.00";
                }

                if (txtKolicina.Text != "")
                {
                    kolicina = Convert.ToString(txtKolicina.Text).Replace(',', '.');
                }
                else
                {
                    kolicina = "0.00";
                }

                if (txtPopust.Text != "")
                {
                    Popust = Convert.ToString(txtPopust.Text).Replace(',', '.');
                }
                else
                {
                    Popust = "0.00";
                }

                if (lblRobnaGrupa.Text != "___")
                {
                    robnaGrupa = "'" + txtRobnaGrupa.Text + "'";

                    if (_SifraAkcije == "11")
                    {
                        if (lblRobnaGrupa.Text.Length > 32)
                        {
                            ARnaziv = lblRobnaGrupa.Text.Substring(0, 32);
                        }
                        else
                        {
                            ARnaziv = lblRobnaGrupa.Text;
                        }
                    }
                }
                else
                {
                    robnaGrupa =  "default";
                }

                datumOD = Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                datumDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("yyyy-MM-dd");

                vrijemeOD = Convert.ToDateTime(dtpVrijemeOD.Text).ToShortTimeString();
                vrijemeDO = Convert.ToDateTime(dtpVrijemeDO.Text).ToShortTimeString();

                if (cmbBrojKupona.Text != "")
                {
                    brojKomada = cmbBrojKupona.Text.Substring(0, 1);
                }
                else
                {
                    brojKomada = "0.00";
                }

                if (cmbAktivna.Text == "Da")
                {
                    aktivna = 1;
                }
                else
                {
                    aktivna = 0;
                }

                if (txtStatusKupca.Text != "")
                {
                    status = txtStatusKupca.Text.Trim();
                }
                else
                {
                    status = "default";
                }

                if (glDobavljac.Text != "")
                {
                    sifraDobavljac = glDobavljac.EditValue.ToString();
                    nazivDobavljac = glDobavljac.Text;
                }
                else
                {
                    sifraDobavljac = "default";
                    nazivDobavljac = "default";
                }

                vrijediOD = Convert.ToDateTime(dtpVrijediOD.Text).ToString("yyyy-MM-dd");
                vrijediDO = Convert.ToDateTime(dtpVrijediDO.Text).ToString("yyyy-MM-dd");


                if (_SifraAkcije == "18")
                {
                    //umjesto popusta spremi cijenu u polje akc_cijena

                    Popust = Convert.ToString(txtPopust.Text).Replace(',', '.');

                    cijena = Popust;

                    Popust = "0.00";
                }
                else
                {
                    cijena = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
