using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Transactions;
using blokirajx;

namespace blokerX
{
    public partial class frmAkcijeZaTrgovinu : Form
    {
        List<string> _items = new List<string>();
        Upiti veza = new Upiti();
        int brojac = 0;
        int counter = 0;
        int ispravanBrojAkcije = 0;
        string sifraTrgovine;
        string akcijaZagID;

        string IP;
        string katalog;

        DataTable baza = new DataTable();
        DataTable akcijazag = new DataTable();
        DataTable akcija = new DataTable();


        DataTable podaci = new DataTable();
        MySqlConnection connection = new MySqlConnection();
        string ConnectionString;

        MySqlCommand updateZaglavljaAkcije = new MySqlCommand();
        MySqlCommand insertajStavkeAkcije = new MySqlCommand();
        MySqlCommand insertZaglavljeAkcije = new MySqlCommand();
        MySqlCommand com4 = new MySqlCommand();
        MySqlCommand com5 = new MySqlCommand();
        MySqlCommand com6 = new MySqlCommand();

        string sifraAkcije;
        string brojAkcije;
        string datumOD;
        string datumDO;
        string opis;
        string nazivPoslovnice;
        int aktivna;
        string popust;
        int vezana;
        string partnerSifra;
        //int sifraVezane;


        string opis2;
        string sifraRobneGrupe;
        string sifraArtikl;
        string nazivArtikl;
        string iznos;
        string kolicina;
        string cijena;
        string komada;
        string vaziOD;
        string vaziDO;
        string odSat;
        string doSat;
        string danUTjednu;
        string statusKupca;
        string sifraDobavljaca;
        string nazivDobavaljaca;
        string vrijediOD;
        string vrijediDO;
        string barkod;

        string IDposlovnice;

        string _oznaka;
        string _brojAkcije;


        public frmAkcijeZaTrgovinu()
        {
            InitializeComponent();
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string AkcijaBroj
        {
            get { return _brojAkcije; }
            set { _brojAkcije = value; }
        }

        private void txtBrojAkcije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {                
                if(txtBrojAkcije.Text.Trim() != "")
                {
                    //provjeri da li je broj akcije 16, ako je onda pokupi samo poslovnice za koje je dodano
                    provjeriBrojAkcije();

                    if (ispravanBrojAkcije == 1)
                    {
                        if (sifraAkcije == "16") //sniženi artikli
                        {
                            ckbA.Enabled = false;
                            ckbB.Enabled = false;
                            ckbC.Enabled = false;
                            ckbD.Enabled = false;
                            ckbX.Enabled = false;

                            btnSveDesno.Enabled = false;
                            btnSveLijevo.Enabled = false;

                            //txtBrojAkcije.Text = _brojAkcije;

                            //pokupi poslovnice iz odabrane akcije

                            DataTable posl = new DataTable();
                            veza.ExecuteQuery("select boso2011.poslovnica.po_sifra, boso2011.poslovnica.po_naziv, boso2011.poslovnica.po_asortiman from boso2011.poslovnica, mpman.akcije where   mpman.akcije.POSLOVNICA_PO_ID = boso2011.poslovnica.po_id and  boso2011.poslovnica.po_datumZatvaranja is null and (boso2011.poslovnica.vp_sifra = '300' or  boso2011.poslovnica.vp_sifra ='200') and boso2011.poslovnica.po_asortiman <> '' and mpman.akcije.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + " group by boso2011.poslovnica.po_sifra ORDER BY boso2011.poslovnica.po_naziv", ref posl);

                            if (posl.Rows.Count > 0)
                            {
                                dgNeraspoređeneTrgovine.DataSource = posl;
                                string[] kolone = new string[6];
                                kolone[0] = "Šifra";
                                kolone[1] = "Naziv";
                                kolone[2] = "Asortiman";

                                for (int i = 0; i < dgNeraspoređeneTrgovine.Columns.Count; i++)
                                {
                                    dgNeraspoređeneTrgovine.Columns[i].HeaderText = kolone[i];
                                }
                            }
                        }
                        else
                        {
                            ckbA.Enabled = true;
                            ckbB.Enabled = true;
                            ckbC.Enabled = true;
                            ckbD.Enabled = true;
                            ckbX.Enabled = true;

                            btnSveDesno.Enabled = true;
                            btnSveLijevo.Enabled = true;

                            DataTable posl = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman <> '' ORDER BY po_naziv", ref posl);

                            if (posl.Rows.Count > 0)
                            {
                                dgNeraspoređeneTrgovine.DataSource = posl;
                                string[] kolone = new string[6];
                                kolone[0] = "Šifra";
                                kolone[1] = "Naziv";
                                kolone[2] = "Asortiman";

                                for (int i = 0; i < dgNeraspoređeneTrgovine.Columns.Count; i++)
                                {
                                    dgNeraspoređeneTrgovine.Columns[i].HeaderText = kolone[i];
                                }
                            }
                        }
                    }

                    //prikaži vezu akcija trgovina iz tablice akcijatrgovina ako postoji 
                    osvjeziPodatke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void osvjeziPodatke()
        {
            this.novaAkcijaStavkeTableAdapter.Fill(novaAkcijaStavke._NovaAkcijaStavke, brojAkcije );
        }

        private void provjeriBrojAkcije()
        {
            try
            {
                string akcijaBroj = txtBrojAkcije.Text.Trim();
                DataTable provjera = new DataTable();
                veza.ExecuteQuery("select * from mpman.akcijezag where akc_broj = "+akcijaBroj+"", ref provjera);

                if (provjera.Rows.Count > 0)
                {
                    ispravanBrojAkcije = 1;
                    label4.Text = "Akcija pod navedenim brojem postoji. Odredite trgovine za prijenos!";
                    brojAkcije = txtBrojAkcije.Text.Trim();
                    sifraAkcije = provjera.Rows[0][1].ToString();
                }
                else
                {
                    DataTable prazna = new DataTable();
                    ispravanBrojAkcije = 0;
                    label4.Text = "Akcija pod navedenim brojem ne postoji!";
                    brojAkcije = "0";
                    txtBrojAkcije.Focus();
                    dgNeraspoređeneTrgovine.DataSource = prazna;
                    //dgOdabraneTrgovine.DataSource = prazna;
                }
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

        private void frmAkcijeZaTrgovinu_Load(object sender, EventArgs e)
        {
            try
            {
                if (_oznaka == "S") //sniženi artikli
                {
                    ckbA.Enabled = false;
                    ckbB.Enabled = false;
                    ckbC.Enabled = false;
                    ckbD.Enabled = false;
                    ckbX.Enabled = false;

                    btnSveDesno.Enabled = false;
                    btnSveLijevo.Enabled = false;

                    txtBrojAkcije.Text = _brojAkcije;                  
                }
                else
                {
                    //normalna akcija sve ostavi kako je
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (dgNeraspoređeneTrgovine.Rows.Count > 0 && txtBrojAkcije.Text != "")
                    {
                        string sifra = dgNeraspoređeneTrgovine.CurrentRow.Cells[0].Value.ToString();
                        string akcijaBroj = txtBrojAkcije.Text.Trim();

                        //provjera da li je već dodana veza akcija / trgovina
                        DataTable rasporedene = new DataTable();

                        veza.ExecuteQuery("select * from mpman.akcijatrgovina where akc_broj = " + akcijaBroj + " and po_sifra = " + sifra + "", ref rasporedene);

                        if (rasporedene.Rows.Count == 0)
                        {
                            veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            MessageBox.Show("Veza je već dodana!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLijevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgOdabraneTrgovine.Rows.Count > 0)
                {
                    string sifra = dgOdabraneTrgovine.CurrentRow.Cells[0].Value.ToString();
                    string akcijaBroj = txtBrojAkcije.Text.Trim();

                    //provjera da li je već dodana veza akcija / trgovina
                    DataTable rasporedene = new DataTable();

                    veza.ExecuteQuery("delete from mpman.akcijatrgovina where akc_broj = " + akcijaBroj + " and po_sifra = " + sifra + "");

                    //DataTable dat = new DataTable();
                    //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                    //if (dat.Rows.Count > 0)
                    //{
                    //    dgOdabraneTrgovine.DataSource = dat;

                    //    string[] kolone = new string[6];
                    //    kolone[0] = "Šifra";
                    //    kolone[1] = "Naziv";
                    //    kolone[2] = "Slanje";
                    //    kolone[3] = "Datum slanja";
                    //    kolone[4] = "Uspjelo slanje";
                    //    kolone[5] = "Greška";

                    //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                    //    {
                    //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                    //    }
                    //}
                    //else
                    //{
                    //    DataTable prazno = new DataTable();
                    //    dgOdabraneTrgovine.DataSource = prazno;
                    //}
                    osvjeziPodatke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSveDesno_Click(object sender, EventArgs e)
        {
            if (txtBrojAkcije.Text.Trim() != "" && ispravanBrojAkcije == 1)
            {
                if (dgOdabraneTrgovine.RowCount != dgNeraspoređeneTrgovine.RowCount)
                {
                    if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                    {
                        string akcijaBroj = txtBrojAkcije.Text.Trim();

                        DataTable ostaleTrg = new DataTable();

                        veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200')  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                        for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                        {
                            string sifra = ostaleTrg.Rows[brojac][0].ToString();
                            veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                        }

                        //DataTable dat = new DataTable();
                        //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                        //if (dat.Rows.Count > 0)
                        //{
                        //    dgOdabraneTrgovine.DataSource = dat;

                        //    string[] kolone = new string[6];
                        //    kolone[0] = "Šifra";
                        //    kolone[1] = "Naziv";
                        //    kolone[2] = "Slanje";
                        //    kolone[3] = "Datum slanja";
                        //    kolone[4] = "Uspjelo slanje";
                        //    kolone[5] = "Greška";

                        //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                        //    {
                        //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                        //    }
                        //}
                        //else
                        //{
                        //    DataTable prazno = new DataTable();
                        //    dgOdabraneTrgovine.DataSource = prazno;
                        //}
                        osvjeziPodatke();
                    }
                    else
                    {
                        DataTable poslovnica = new DataTable();
                        veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                        for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            string sifra = poslovnica.Rows[brojac][0].ToString();

                            veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                        }

                        //DataTable dat = new DataTable();
                        //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                        //if (dat.Rows.Count > 0)
                        //{
                        //    dgOdabraneTrgovine.DataSource = dat;

                        //    string[] kolone = new string[6];
                        //    kolone[0] = "Šifra";
                        //    kolone[1] = "Naziv";
                        //    kolone[2] = "Slanje";
                        //    kolone[3] = "Datum slanja";
                        //    kolone[4] = "Uspjelo slanje";
                        //    kolone[5] = "Greška";

                        //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                        //    {
                        //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                        //    }
                        //}
                        //else
                        //{
                        //    DataTable prazno = new DataTable();
                        //    dgOdabraneTrgovine.DataSource = prazno;
                        //}
                        osvjeziPodatke();
                    }
                }
            }
        }

        private void ckbA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (ckbA.Checked)
                    {
                        if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            DataTable ostaleTrg = new DataTable();

                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman = 'A'  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                            for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                            {
                                string sifra = ostaleTrg.Rows[brojac][0].ToString();
                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            DataTable poslovnica = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and po_asortiman = 'A' and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                            for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                            {
                                string akcijaBroj = txtBrojAkcije.Text.Trim();

                                string sifra = poslovnica.Rows[brojac][0].ToString();

                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO, , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSveLijevo_Click(object sender, EventArgs e)
        {
            if (dgOdabraneTrgovine.Rows.Count > 0)
            {
                string akcijaBroj = txtBrojAkcije.Text.Trim();
                veza.ExecuteQuery("delete from mpman.akcijatrgovina where akc_broj = '" + akcijaBroj + "'");

                //DataTable dat = new DataTable();
                //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO, akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                //if (dat.Rows.Count > 0)
                //{
                //    dgOdabraneTrgovine.DataSource = dat;

                //    string[] kolone = new string[6];
                //    kolone[0] = "Šifra";
                //    kolone[1] = "Naziv";
                //    kolone[2] = "Slanje";
                //    kolone[3] = "Datum slanja";
                //    kolone[4] = "Uspjelo slanje";
                //    kolone[5] = "Greška";

                //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                //    {
                //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                //    }
                //}
                //else
                //{
                //    DataTable prazno = new DataTable();
                //    dgOdabraneTrgovine.DataSource = prazno;
                //}
                osvjeziPodatke();
            }
        }

        private void ckbB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (ckbB.Checked)
                    {
                        if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            DataTable ostaleTrg = new DataTable();

                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman = 'B'  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                            for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                            {
                                string sifra = ostaleTrg.Rows[brojac][0].ToString();
                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            DataTable poslovnica = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and po_asortiman = 'B' and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                            for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                            {
                                string akcijaBroj = txtBrojAkcije.Text.Trim();

                                string sifra = poslovnica.Rows[brojac][0].ToString();

                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (ckbC.Checked)
                    {
                        if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            DataTable ostaleTrg = new DataTable();

                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman = 'C'  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                            for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                            {
                                string sifra = ostaleTrg.Rows[brojac][0].ToString();
                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            DataTable poslovnica = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and po_asortiman = 'C' and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                            for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                            {
                                string akcijaBroj = txtBrojAkcije.Text.Trim();

                                string sifra = poslovnica.Rows[brojac][0].ToString();

                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbD_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (ckbD.Checked)
                    {
                        if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            DataTable ostaleTrg = new DataTable();

                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman = 'D'  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                            for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                            {
                                string sifra = ostaleTrg.Rows[brojac][0].ToString();
                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            DataTable poslovnica = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and po_asortiman = 'D' and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                            for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                            {
                                string akcijaBroj = txtBrojAkcije.Text.Trim();

                                string sifra = poslovnica.Rows[brojac][0].ToString();

                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbX_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ispravanBrojAkcije == 1)
                {
                    if (ckbX.Checked)
                    {
                        if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                        {
                            string akcijaBroj = txtBrojAkcije.Text.Trim();

                            DataTable ostaleTrg = new DataTable();

                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and po_asortiman = 'X'  and poslovnica.po_sifra not in (select mpman.akcijatrgovina.PO_SIFRA from mpman.akcijatrgovina where  akc_broj = " + akcijaBroj + " ) order by po_sifra", ref ostaleTrg);

                            for (brojac = 0; brojac < ostaleTrg.Rows.Count; brojac++)
                            {
                                string sifra = ostaleTrg.Rows[brojac][0].ToString();
                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
                        }
                        else
                        {
                            DataTable poslovnica = new DataTable();
                            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from boso2011.poslovnica where  po_datumZatvaranja is null and po_asortiman = 'X' and (vp_sifra = '300' or  vp_sifra ='200') order by po_naziv", ref poslovnica);

                            for (brojac = 0; brojac < poslovnica.Rows.Count; brojac++)
                            {
                                string akcijaBroj = txtBrojAkcije.Text.Trim();

                                string sifra = poslovnica.Rows[brojac][0].ToString();

                                veza.ExecuteQuery("insert into mpman.akcijatrgovina (akc_broj, po_sifra) values (" + akcijaBroj + ", " + sifra + ")");
                            }

                            //DataTable dat = new DataTable();
                            //veza.ExecuteQuery("select mpman.akcijatrgovina.PO_SIFRA, boso2011.poslovnica.po_naziv, mpman.akcijatrgovina.AKC_AKTIVNA, mpman.akcijatrgovina.AKCTRG_DATUM_SLANJA, mpman.akcijatrgovina.AKCTRG_USPJELO , akctrg_err from boso2011.poslovnica, mpman.akcijatrgovina where boso2011.poslovnica.po_sifra =mpman.akcijatrgovina.PO_SIFRA and mpman.akcijatrgovina.AKC_BROJ = " + txtBrojAkcije.Text.Trim() + "", ref dat);

                            //if (dat.Rows.Count > 0)
                            //{
                            //    dgOdabraneTrgovine.DataSource = dat;

                            //    string[] kolone = new string[6];
                            //    kolone[0] = "Šifra";
                            //    kolone[1] = "Naziv";
                            //    kolone[2] = "Slanje";
                            //    kolone[3] = "Datum slanja";
                            //    kolone[4] = "Uspjelo slanje";
                            //    kolone[5] = "Greška";

                            //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                            //    {
                            //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                            //    }
                            //}
                            //else
                            //{
                            //    DataTable prazno = new DataTable();
                            //    dgOdabraneTrgovine.DataSource = prazno;
                            //}
                            osvjeziPodatke();
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
            if (dgOdabraneTrgovine.Rows.Count > 0)
            {
                brojAkcije = txtBrojAkcije.Text.Trim();

                for (brojac = 0; brojac < dgOdabraneTrgovine.Rows.Count; brojac++)
                {
                    if (dgOdabraneTrgovine.Rows[brojac].Cells[2].Value.ToString() == "True")
                    {
                        string sifra = dgOdabraneTrgovine.Rows[brojac].Cells[0].Value.ToString();

                        sifraTrgovine = "  " + sifra;

                        //pokupi podatke o akciji
                        //pokupi podatke o trgovini
                        txtKopiranje.Items.Add("Prikupljam podatke za kopiranje ...");
                        scrollListBox();
                        pokupiPodatke();

                        //spoji se na bazu u trgovini
                        txtKopiranje.Items.Add("Spajam se na bazu trgovine: " + sifra + "...");
                        scrollListBox();

                        try
                        {
                            podaci.Clear();
                            connection = new MySqlConnection();
                            ConnectionString = "Server = " + IP + "; Database=" + katalog + "; Uid=admin10; Pwd=movema10;";
                            connection.ConnectionString = ConnectionString;

                            connection.Open();
                            txtKopiranje.Items.Add("Spajanje uspjelo!");
                            scrollListBox();


                            //pobrisi stare akcije gdje akc_broj pocinje s brojem trgovine
                            //ako se radi o sniženju kategorija 16 onda ne brisati zaglavlje i stavke u trgovini nego napravi update

                            MySqlTransaction transaction = connection.BeginTransaction();
                            
                            if (akcijazag.Rows[0][1].ToString() != "16")
                            {                                
                                //MySqlCommand comm = new MySqlCommand(@"delete from akcije where akc_broj like  '" + sifraTrgovine.TrimStart(' ') + "%' ", connection);

                                //comm.ExecuteNonQuery();

                                //MySqlCommand comm1 = new MySqlCommand(@"delete from akcijezag where akc_broj like  '" + sifraTrgovine.TrimStart(' ') + "%' ", connection);

                                //comm1.ExecuteNonQuery();


                                //transaction.Commit();

                                //provjeri da li treba azuriranje ili insert
                                //kopiraj podatke u bazu od trgovine

                                MySqlCommand comm2 = new MySqlCommand(@"select * from akcijezag where akc_broj = '" + brojAkcije + "' ", connection);

                                MySqlDataAdapter adapter = new MySqlDataAdapter(comm2);

                                //podaci.Dispose();
                                //veza.ExecuteQuery(@"select * from mpman.akcijezag where akc_broj = '" + brojAkcije + "' ", ref podaci);

                                try
                                {
                                    comm2.ExecuteNonQuery();

                                    //transaction.Commit();

                                    adapter.Fill(podaci);

                                    if (podaci.Rows.Count > 0) //ako postoji zaglavlje, imaju i stavke onda update
                                    {
                                        txtKopiranje.Items.Add("Kopiranje podataka u bazu trgovine ... ");
                                        scrollListBox();
                                        //update zaglavlja, brisi stavke u trgovini i insert nove
                                        pokupiPodatkeAkcijeZag();

                                        if (sifraAkcije != "13" && sifraAkcije != "7")
                                        {
                                            MySqlCommand comm3 = new MySqlCommand("update akcijezag set pok_sifra = '" + sifraAkcije + "', akc_broj =  '" + brojAkcije + "', akc_datumOD = '" + datumOD + "', akc_datumDO = '" + datumDO + "', akc_opis = '" + opis + "', po_sifra = '" + sifraTrgovine + "', po_naziv = '" + nazivPoslovnice + "', akc_aktivna = '" + aktivna + "', akc_popust = " + popust + ", akc_vezana = '" + vezana + "', pok_sifravezana = default where akc_broj = '" + brojAkcije + "'", connection);
                                            comm3.ExecuteNonQuery();
                                        }
                                        else 
                                        {
                                            //akcija 13 dodaj polje partnera za zaglavlje
                                            //MessageBox.Show("update akcijezag set pok_sifra = '" + sifraAkcije + "', akc_broj =  '" + brojAkcije + "', akc_datumOD = '" + datumOD + "', akc_datumDO = '" + datumDO + "', akc_opis = '" + opis + "', po_sifra = '" + sifraTrgovine + "', po_naziv = '" + nazivPoslovnice + "', akc_aktivna = '" + aktivna + "', akc_popust = " + popust + ", akc_vezana = '" + vezana + "', pok_sifravezana = default, partner_pa_sifra = " + partnerSifra + " where akc_broj = '" + brojAkcije + "'");
                                            MySqlCommand comm3 = new MySqlCommand("update akcijezag set pok_sifra = '" + sifraAkcije + "', akc_broj =  '" + brojAkcije + "', akc_datumOD = '" + datumOD + "', akc_datumDO = '" + datumDO + "', akc_opis = '" + opis + "', po_sifra = '" + sifraTrgovine + "', po_naziv = '" + nazivPoslovnice + "', akc_aktivna = '" + aktivna + "', akc_popust = " + popust + ", akc_vezana = '" + vezana + "', pok_sifravezana = default, partner_pa_sifra = "+partnerSifra+" where akc_broj = '" + brojAkcije + "'", connection);
                                            comm3.ExecuteNonQuery();
                                        }


                                        
                                        MySqlCommand comm4 = new MySqlCommand(@"delete from akcije where akc_broj = '" + brojAkcije + "' ", connection);

                                        comm4.ExecuteNonQuery();
                                        
                                        //transaction.Commit(); 


                                        for (counter = 0; counter < akcija.Rows.Count; counter++)
                                        {
                                            //transaction = connection.BeginTransaction();
                                            pokupiPodatkeAkcije();                                            
                                                
                                            //MessageBox.Show("insert into akcije (pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, pok_danutjednu, kup_statk, ar_sifradob,ar_nazivdob, pok_vrijediDO, pok_vrijediOD) values ('"+sifraAkcije+"', '"+brojAkcije+"', '"+opis+"', '"+opis2+"', '"+sifraRobneGrupe+"', '"+sifraArtikl+"', '"+nazivArtikl+"', '"+iznos+"', '"+kolicina+"', '"+komada+"', '"+vaziOD+"', '"+vaziDO+"', '"+odSat+"', '"+doSat+"', '"+aktivna+"', '"+popust+"', "+danUTjednu+", '"+statusKupca+"', '"+sifraDobavljaca+"', '"+nazivDobavaljaca+"', "+vrijediDO+", "+vrijediOD+") ");
                                            MySqlCommand comm5 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, pok_danutjednu, kup_statk, ar_sifradob,ar_nazivdob, pok_vrijediDO, pok_vrijediOD, bk_kod, akc_cijena)
                                                values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + opis2 + "', '" + sifraRobneGrupe + "', '" + sifraArtikl + "', " + nazivArtikl + ", '" + iznos + "', '" + kolicina + "', '" + komada + "', '" + vaziOD + "', '" + vaziDO + "', '" + odSat + "', '" + doSat + "', '" + aktivna + "', '" + popust + "', " + danUTjednu + ", " + statusKupca + ", " + sifraDobavljaca + ", " + nazivDobavaljaca + ", " + vrijediDO + ", " + vrijediOD + ", '" + barkod + "', '"+cijena+"') ", connection);

                                            comm5.ExecuteNonQuery();   
                                         
                                        }
                                    }
                                    else
                                    {
                                        //transaction = connection.BeginTransaction();
                                        //insert zaglavlja i stavki
                                        pokupiPodatkeAkcijeZag();
                                        if (sifraAkcije != "13" && sifraAkcije != "7")
                                        {
                                            MySqlCommand comm6 = new MySqlCommand("insert into akcijezag (pok_sifra, akc_broj, akc_datumOD, akc_datumDO, akc_opis, po_sifra, po_naziv, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana) values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + datumOD + "', '" + datumDO + "','" + opis + "', '" + sifraTrgovine + "', '" + nazivPoslovnice + "', '" + aktivna + "', " + popust + ", '" + vezana + "', default) ", connection);
                                            comm6.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            MySqlCommand comm6 = new MySqlCommand("insert into akcijezag (pok_sifra, akc_broj, akc_datumOD, akc_datumDO, akc_opis, po_sifra, po_naziv, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana, partner_pa_sifra) values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + datumOD + "', '" + datumDO + "','" + opis + "', '" + sifraTrgovine + "', '" + nazivPoslovnice + "', '" + aktivna + "', " + popust + ", '" + vezana + "', default, "+partnerSifra+") ", connection);
                                            comm6.ExecuteNonQuery();
                                        }
                                        //transaction.Commit();

                                        for (counter = 0; counter < akcija.Rows.Count; counter++)
                                        {

                                            //transaction = connection.BeginTransaction();
                                            pokupiPodatkeAkcije();

                                            ///MessageBox.Show("insert into akcije (pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, pok_danutjednu, kup_statk, ar_sifradob,ar_nazivdob, pok_vrijediDO, pok_vrijediOD, bk_kod) values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + opis2 + "', '" + sifraRobneGrupe + "', '" + sifraArtikl + "', " + nazivArtikl + ", '" + iznos + "', '" + kolicina + "', '" + komada + "', '" + vaziOD + "', '" + vaziDO + "', '" + odSat + "', '" + doSat + "', '" + aktivna + "', '" + popust + "', " + danUTjednu + ", '" + statusKupca + "', '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + vrijediDO + "', '" + vrijediOD + "', " + barkod + ")");
                                            MySqlCommand comm7 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, pok_danutjednu, kup_statk, ar_sifradob,ar_nazivdob, pok_vrijediDO, pok_vrijediOD, bk_kod, akc_cijena)
                                                values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + opis2 + "', '" + sifraRobneGrupe + "', '" + sifraArtikl + "', " + nazivArtikl + ", '" + iznos + "', '" + kolicina + "', '" + komada + "', '" + vaziOD + "', '" + vaziDO + "', '" + odSat + "', '" + doSat + "', '" + aktivna + "', '" + popust + "', " + danUTjednu + ", " + statusKupca + ", " + sifraDobavljaca + ", " + nazivDobavaljaca + ", " + vrijediDO + ", " + vrijediOD + ", " + barkod + ", '"+cijena+"') ", connection);

                                            comm7.ExecuteNonQuery();
                                        }
                                    }
                                    //transakcije();

                                    transaction.Commit();

                                    txtKopiranje.Items.Add("Kopiranje završeno za trgovinu: " + sifraTrgovine);
                                    txtKopiranje.Items.Add("______________________________________");
                                    scrollListBox();

                                    //podesigrid

                                    //refresh grid nakon svake kopirane i stavi "aktivna" = false

                                    connection.Close();

                                    veza.ExecuteQuery("update mpman.akcijatrgovina set akctrg_uspjelo = 1, akctrg_err = '', akctrg_datum_slanja = now() where akc_broj = '" + brojAkcije + "' and po_sifra = " + sifra + "");

                                    dgOdabraneTrgovine.Rows[brojac].Cells[2].Value = false;

                                    dgOdabraneTrgovine.Rows[brojac].Cells[3].Value = DateTime.Now.ToString("dd/MM/yyyy hh:MM:ss ");

                                    dgOdabraneTrgovine.Rows[brojac].Cells[4].Value = "Poslano";
                                }
                                catch (Exception)
                                {
                                    //MessageBox.Show("update mpman.akcijatrgovina set akctrg_err = " + "Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine + "" + ", akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                                    veza.ExecuteQuery("update mpman.akcijatrgovina set akctrg_err = '" + "Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine + "" + "', akctrg_datum_slanja = now(), akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                                    transaction.Rollback();
                                    connection.Close();
                                    txtKopiranje.Items.Add("Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine);
                                    txtKopiranje.Items.Add("______________________________________");
                                    scrollListBox();
                                }
                            }
                            else
                            {
                                //akcija je 16 - sniženje

                                //provjeri da li treba azuriranje ili insert
                                //kopiraj podatke u bazu od trgovine

                                MySqlCommand comm2 = new MySqlCommand(@"select * from akcijezag where akc_broj = '" + brojAkcije + "' ", connection);

                                MySqlDataAdapter adapter = new MySqlDataAdapter(comm2);

                                //podaci.Dispose();
                                //veza.ExecuteQuery(@"select * from mpman.akcijezag where akc_broj = '" + brojAkcije + "' ", ref podaci);

                                try
                                {
                                    comm2.ExecuteNonQuery();

                                    //transaction.Commit();

                                    adapter.Fill(podaci);

                                    if (podaci.Rows.Count > 0) //ako postoji zaglavlje, imaju i stavke onda update
                                    {
                                        txtKopiranje.Items.Add("Kopiranje podataka u bazu trgovine ... ");
                                        scrollListBox();
                                        //update zaglavlja, brisi stavke u trgovini i insert nove
                                        pokupiPodatkeAkcijeZag();

                                        //MessageBox.Show("update akcijezag set pok_sifra = '" + sifraAkcije + "', akc_broj =  '" + brojAkcije + "', akc_datumOD = '" + datumOD + "', akc_datumDO = '" + datumDO + "', akc_opis = '" + opis + "', po_sifra = '" + sifraTrgovine + "', po_naziv = '" + nazivPoslovnice + "', akc_aktivna = '" + aktivna + "', akc_popust = " + popust + ", akc_vezana = '" + vezana + "', pok_sifravezana = default where akc_broj = '" + brojAkcije + "'");
                                        MySqlCommand comm3 = new MySqlCommand("update akcijezag set pok_sifra = '" + sifraAkcije + "', akc_broj =  '" + brojAkcije + "', akc_datumOD = '" + datumOD + "', akc_datumDO = '" + datumDO + "', akc_opis = '" + opis + "', po_sifra = '" + sifraTrgovine + "', po_naziv = '" + nazivPoslovnice + "', akc_aktivna = '" + aktivna + "', akc_popust = " + popust + ", akc_vezana = '" + vezana + "', pok_sifravezana = default  where akc_broj = '" + brojAkcije + "'", connection);

                                        comm3.ExecuteNonQuery();

                                        //if (akcijazag.Rows[0][1].ToString() != "16")
                                        //{
                                        //    MySqlCommand comm4 = new MySqlCommand(@"delete from akcije where akc_broj = '" + brojAkcije + "' ", connection);

                                        //    comm4.ExecuteNonQuery();
                                        //}
                                        //transaction.Commit(); 


                                        for (counter = 0; counter < akcija.Rows.Count; counter++)
                                        {
                                            //transaction = connection.BeginTransaction();
                                            pokupiPodatkeAkcije();

                                            //provjeri postoji li stavka akcije s dohvacenim podacima, ako da onda update ako ne onda insert

                                            DataTable akcijaStavka = new DataTable();   

                                            MySqlCommand comm4 = new MySqlCommand(@"select * from akcije where akc_broj  <> '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + " and pok_sifra = 16 ", connection);

                                            MySqlDataAdapter adapter1 = new MySqlDataAdapter(comm4);

                                            adapter1.Fill(akcijaStavka);

                                            comm4.ExecuteNonQuery();

                                            if (akcijaStavka.Rows.Count > 0)
                                            {
                                                //postoji stavka u nekoj od vec dodanih akcija i treba je izbrisati i insertati novu od trenutne akcije
                                               
                                                MySqlCommand comm5 = new MySqlCommand(@"delete from akcije where pok_sifra = '" + sifraAkcije + "' and  ar_sifra = '" + sifraArtikl + "'", connection);

                                                comm5.ExecuteNonQuery();

                                                //insert jer nema u nijedno
                                                MySqlCommand comm8 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv,  pok_kolic,  pok_vaziod, pok_vazido,  akc_aktivna,  ar_sifradob,ar_nazivdob, bk_kod, akc_cijena, pok_vrijedido )
                                                    values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + sifraArtikl + "', " + nazivArtikl + ",  '" + kolicina + "',  '" + vaziOD + "', '" + vaziDO + "',  '" + aktivna + "',  '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + barkod + "', '" + cijena + "'," + vrijediDO + ") ", connection);

                                                comm8.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                //provjeri za trenutnu akciju ako postoji stavka onda update ako ne onda tek insert
                                                DataTable stavkaakcija = new DataTable();
                                                MySqlCommand comm6 = new MySqlCommand(@"select * from akcije where akc_broj  = '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + " and pok_sifra = 16 ", connection);

                                                MySqlDataAdapter adapter2 = new MySqlDataAdapter(comm6);

                                                adapter2.Fill(stavkaakcija);

                                                comm6.ExecuteNonQuery();                                                

                                                if (stavkaakcija.Rows.Count > 0) //postoji za trenutnu akciju - update
                                                {
                                                    MySqlCommand comm7 = new MySqlCommand(@"update akcije set pok_sifra = '" + sifraAkcije + "', akc_broj = '" + brojAkcije + "', pok_opis = '" + opis + "', ar_sifra = '" + sifraArtikl + "', ar_naziv = " + nazivArtikl + ", pok_iznos = '" + iznos + "', pok_kolic = '" + kolicina + "',  pok_vaziod = '" + vaziOD + "', pok_vazido = '" + vaziDO + "', akc_aktivna =  '" + aktivna + "', ar_sifradob = '" + sifraDobavljaca + "',ar_nazivdob = '" + nazivDobavaljaca + "',  bk_kod = '" + barkod + "', akc_cijena = '" + cijena + "', pok_vrijedido = " + vrijediDO + " where akc_broj = '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + "", connection);

                                                    comm7.ExecuteNonQuery();
                                                }
                                                else
                                                { 
                                                    //insert jer nema u nijedno
                                                    MySqlCommand comm8 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv,  pok_kolic,  pok_vaziod, pok_vazido,  akc_aktivna, ar_sifradob,ar_nazivdob, bk_kod, akc_cijena, pok_vrijedido)
                                                    values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + sifraArtikl + "', " + nazivArtikl + ",  '" + kolicina + "',  '" + vaziOD + "', '" + vaziDO + "',  '" + aktivna + "',  '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + barkod + "', '" + cijena + "', " + vrijediDO + ") ", connection);

                                                    comm8.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //transaction = connection.BeginTransaction();
                                        //insert zaglavlja i stavki
                                        pokupiPodatkeAkcijeZag();

                                        MySqlCommand comm9 = new MySqlCommand("insert into akcijezag (pok_sifra, akc_broj, akc_datumOD, akc_datumDO, akc_opis, po_sifra, po_naziv, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana) values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + datumOD + "', '" + datumDO + "','" + opis + "', '" + sifraTrgovine + "', '" + nazivPoslovnice + "', '" + aktivna + "', " + popust + ", '" + vezana + "', default) ", connection);
                                        comm9.ExecuteNonQuery();


                                        for (counter = 0; counter < akcija.Rows.Count; counter++)
                                        {
                                            //transaction = connection.BeginTransaction();
                                            pokupiPodatkeAkcije();

                                            //provjeri postoji li stavka akcije s dohvacenim podacima, ako da onda update ako ne onda insert

                                            DataTable akcijaStavka = new DataTable();

                                            MySqlCommand comm4 = new MySqlCommand(@"select * from akcije where akc_broj  <> '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + " and pok_sifra = 16 ", connection);

                                            MySqlDataAdapter adapter1 = new MySqlDataAdapter(comm4);

                                            adapter1.Fill(akcijaStavka);

                                            comm4.ExecuteNonQuery();

                                            if (akcijaStavka.Rows.Count > 0)
                                            {
                                                //postoji stavka u nekoj od vec dodanih akcija i treba je izbrisati i insertati novu od trenutne akcije

                                                MySqlCommand comm5 = new MySqlCommand(@"delete from akcije where pok_sifra = '" + sifraAkcije + "' and  ar_sifra = '" + sifraArtikl + "'", connection);

                                                comm5.ExecuteNonQuery();

                                                //insert jer nema u nijedno
                                                MySqlCommand comm8 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv,  pok_kolic,  pok_vaziod, pok_vazido,  akc_aktivna,  ar_sifradob,ar_nazivdob, bk_kod, akc_cijena, pok_vrijedido)
                                                    values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + sifraArtikl + "', " + nazivArtikl + ",  '" + kolicina + "',  '" + vaziOD + "', '" + vaziDO + "',  '" + aktivna + "',  '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + barkod + "', '" + cijena + "', " + vrijediDO + ") ", connection);

                                                comm8.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                //provjeri za trenutnu akciju ako postoji stavka onda update ako ne onda tek insert
                                                DataTable stavkaakcija = new DataTable();
                                                MySqlCommand comm6 = new MySqlCommand(@"select * from akcije where akc_broj  = '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + " and pok_sifra = 16 ", connection);

                                                MySqlDataAdapter adapter2 = new MySqlDataAdapter(comm6);

                                                adapter2.Fill(stavkaakcija);

                                                comm6.ExecuteNonQuery();

                                                if (stavkaakcija.Rows.Count > 0) //postoji za trenutnu akciju - update
                                                {
                                                    //MessageBox.Show("update akcije set pok_sifra = '" + sifraAkcije + "', akc_broj = '" + brojAkcije + "', pok_opis = '" + opis + "', ar_sifra = '" + sifraArtikl + "', ar_naziv = '" + nazivArtikl + "', pok_iznos = '" + iznos + "', pok_kolic = '" + kolicina + "',  pok_vaziod = '" + vaziOD + "', pok_vazido = '" + vaziDO + "', akc_aktivna =  '" + aktivna + "', akc_popust = '" + popust + "', ar_sifradob = '" + sifraDobavljaca + "',ar_nazivdob = '" + nazivDobavaljaca + "',  bk_kod = '" + barkod + "' where akc_broj = '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + "");
                                                    MySqlCommand comm7 = new MySqlCommand(@"update akcije set pok_sifra = '" + sifraAkcije + "', akc_broj = '" + brojAkcije + "', pok_opis = '" + opis + "', ar_sifra = '" + sifraArtikl + "', ar_naziv = " + nazivArtikl + ", pok_iznos = '" + iznos + "', pok_kolic = '" + kolicina + "',  pok_vaziod = '" + vaziOD + "', pok_vazido = '" + vaziDO + "', akc_aktivna =  '" + aktivna + "',  ar_sifradob = '" + sifraDobavljaca + "',ar_nazivdob = '" + nazivDobavaljaca + "',  bk_kod = '" + barkod + "', akc_cijena = '" + cijena + "', pok_vrijedido = " + vrijediDO + " where akc_broj = '" + brojAkcije + "' and ar_sifra = " + sifraArtikl + "", connection);

                                                    comm7.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    //insert jer nema u nijedno
                                                    //MessageBox.Show("insert into akcije (pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv,  pok_kolic,  pok_vaziod, pok_vazido,  akc_aktivna,  ar_sifradob,ar_nazivdob, bk_kod, akc_cijena, pok_vrijedido) values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + sifraArtikl + "', " + nazivArtikl + ",  '" + kolicina + "',  '" + vaziOD + "', '" + vaziDO + "',  '" + aktivna + "',  '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + barkod + "', '" + cijena + "', '" + vrijediDO + "') ");
                                                    MySqlCommand comm8 = new MySqlCommand(@"insert into akcije (pok_sifra, akc_broj, pok_opis, ar_sifra, ar_naziv,  pok_kolic,  pok_vaziod, pok_vazido,  akc_aktivna,  ar_sifradob,ar_nazivdob, bk_kod, akc_cijena, pok_vrijedido)
                                                    values ('" + sifraAkcije + "', '" + brojAkcije + "', '" + opis + "', '" + sifraArtikl + "', " + nazivArtikl + ",  '" + kolicina + "',  '" + vaziOD + "', '" + vaziDO + "',  '" + aktivna + "',  '" + sifraDobavljaca + "', '" + nazivDobavaljaca + "', '" + barkod + "', '" + cijena + "', " + vrijediDO + ") ", connection);

                                                    comm8.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    //transakcije();

                                    transaction.Commit();

                                    txtKopiranje.Items.Add("Kopiranje završeno za trgovinu: " + sifraTrgovine);
                                    txtKopiranje.Items.Add("______________________________________");
                                    scrollListBox();

                                    //podesigrid

                                    //refresh grid nakon svake kopirane i stavi "aktivna" = false

                                    connection.Close();

                                    veza.ExecuteQuery("update mpman.akcijatrgovina set akctrg_uspjelo = 1, akctrg_err = '', akctrg_datum_slanja = now() where akc_broj = '" + brojAkcije + "' and po_sifra = " + sifra + "");

                                    dgOdabraneTrgovine.Rows[brojac].Cells[2].Value = false;

                                    dgOdabraneTrgovine.Rows[brojac].Cells[3].Value = DateTime.Now.ToString("dd/MM/yyyy hh:MM:ss ");

                                    dgOdabraneTrgovine.Rows[brojac].Cells[4].Value = "Poslano";
                                }
                                catch (Exception)
                                {
                                    //MessageBox.Show("update mpman.akcijatrgovina set akctrg_err = " + "Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine + "" + ", akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                                    veza.ExecuteQuery("update mpman.akcijatrgovina set akctrg_err = '" + "Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine + "" + "', akctrg_datum_slanja = now(), akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                                    transaction.Rollback();
                                    connection.Close();
                                    txtKopiranje.Items.Add("Dogodila se GREŠKA pri kopiranju podataka za trgovinu: " + sifraTrgovine);
                                    txtKopiranje.Items.Add("______________________________________");
                                    scrollListBox();
                                }
                            }
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("update mpman.akcijatrgovina set akctrg_err = " + "GREŠKA pri spajanju na bazu trgovine: " + sifraTrgovine + "" + ", akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                            veza.ExecuteQuery("update mpman.akcijatrgovina set akctrg_err = '" + "GREŠKA pri spajanju na bazu trgovine: " + sifraTrgovine + "" + "', akctrg_uspjelo = 0 where akc_broj = " + brojAkcije + " and po_sifra = " + sifra + "");
                            txtKopiranje.Items.Add("GREŠKA pri spajanju na bazu trgovine: " + sifraTrgovine + "!");
                            txtKopiranje.Items.Add("______________________________________");
                            scrollListBox();
                        }


                    }
                    scrollListBox();                    
                }
                //btnPrikazi.PerformClick();
            }
        }

        private void scrollListBox()
        {
            //txtKopiranje.DataSource = _items;
            txtKopiranje.SelectedIndex = txtKopiranje.Items.Count - 1;
            txtKopiranje.SelectedIndex = -1;
        }

        private void pokupiPodatkeAkcijeZag()
        {
            try
            {
                //akc_ID, pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana
                
                sifraAkcije = akcijazag.Rows[0][1].ToString();
                brojAkcije = akcijazag.Rows[0][2].ToString();
                datumOD = Convert.ToDateTime(akcijazag.Rows[0][3]).ToString("yyyy-MM-dd");
                datumDO = Convert.ToDateTime(akcijazag.Rows[0][4]).ToString("yyyy-MM-dd");
                opis = akcijazag.Rows[0][5].ToString();

                if (akcijazag.Rows[0][6].ToString() == "True")
                {
                    aktivna = 1;
                }
                else
                {
                    aktivna = 0;
                }

                popust = Convert.ToString(akcijazag.Rows[0][7]).Replace(',', '.');                

                if (akcijazag.Rows[0][8].ToString() == "True")
                {
                    vezana = 1;
                }
                else
                {
                    vezana = 0;
                }

                //sifraVezane = Convert.ToInt32(akcijazag.Rows[0][9]);
                //za sada neka bude defaults

                if (sifraAkcije == "13" || sifraAkcije == "7")
                {
                    if (akcijazag.Rows[0][10].ToString() != "")
                    {
                        partnerSifra = akcijazag.Rows[0][10].ToString();
                    }
                    else
                    {
                        partnerSifra = "default";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatkeAkcije()
        {
            try
            {
                sifraAkcije = akcija.Rows[counter][1].ToString();
                brojAkcije = akcija.Rows[counter][2].ToString();
                opis = akcija.Rows[counter][3].ToString();
                opis2 = akcija.Rows[counter][4].ToString();
                sifraRobneGrupe = akcija.Rows[counter][5].ToString();
                sifraArtikl = akcija.Rows[counter][6].ToString();
                nazivArtikl = '"' + akcija.Rows[counter][7].ToString() + '"';
                iznos = Convert.ToString(akcija.Rows[counter][8]).Replace(',', '.');
                kolicina = Convert.ToString(akcija.Rows[counter][9]).Replace(',', '.');
                if (Convert.ToString(akcija.Rows[counter][18]).Replace(',', '.') == "")
                {
                    cijena = "0";
                }
                else
                {
                    cijena = Convert.ToString(akcija.Rows[counter][18]).Replace(',', '.');
                }
                    komada = Convert.ToString(akcija.Rows[counter][10]).Replace(',', '.');
                vaziOD = Convert.ToDateTime(akcija.Rows[counter][11]).ToString("yyyy-MM-dd");
                vaziDO = Convert.ToDateTime(akcija.Rows[counter][12]).ToString("yyyy-MM-dd");
                if (akcija.Rows[counter][13].ToString() != "")
                {
                    odSat = akcija.Rows[counter][13].ToString();
                    doSat = akcija.Rows[counter][14].ToString();
                }
                else
                {
                    odSat = "default";
                    doSat = "default";
                }

                if (akcija.Rows[counter][15].ToString() == "True")
                {
                    aktivna = 1;
                }
                else
                {
                    aktivna = 0;
                }

                popust = Convert.ToString(akcija.Rows[counter][16]).Replace(',', '.');

                if (akcija.Rows[counter][20].ToString() == "")
                {
                    danUTjednu = "default";
                }
                else
                {

                    danUTjednu = akcija.Rows[counter][20].ToString();
                }


                if (akcija.Rows[counter][21].ToString() == "")
                {
                    statusKupca = "default";
                }
                else
                {

                    statusKupca = akcija.Rows[counter][21].ToString();
                }

                //statusKupca = akcija.Rows[counter][21].ToString();


                if (akcija.Rows[counter][22].ToString() == "")
                {
                    sifraDobavljaca = "default";
                }
                else
                {

                    sifraDobavljaca = akcija.Rows[counter][22].ToString();
                }
                //sifraDobavljaca = akcija.Rows[counter][22].ToString();


                if (akcija.Rows[counter][23].ToString() == "")
                {
                    nazivDobavaljaca = "default";
                }
                else
                {

                    nazivDobavaljaca = akcija.Rows[counter][23].ToString();
                }

                //nazivDobavaljaca = akcija.Rows[counter][23].ToString();
                //string a = akcija.Rows[counter][24].ToString();
                if (akcija.Rows[counter][24].ToString() != "")
                {
                    vrijediOD = "'" +Convert.ToDateTime(akcija.Rows[counter][24]).ToString("yyyy-MM-dd")+"'";
                }
                else
                {
                    vrijediOD = "default";
                }


                if (akcija.Rows[counter][25].ToString() != "")
                {
                    vrijediDO = "'"+Convert.ToDateTime(akcija.Rows[counter][25]).ToString("yyyy-MM-dd")+"'";
                }
                else
                {
                    vrijediDO = "default";
                }

                if (akcija.Rows[counter][26].ToString() != "")
                {
                    barkod = akcija.Rows[counter][26].ToString();
                }
                else
                {
                    barkod = "default";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatke()
        {
            try
            {
                //ako je akcija kategorija 16 onda pokupit samo artikle iz stavki za odabrane trgovine u akcijatrgovine

                //pokupi zaglavlje
                veza.ExecuteQuery("select akc_ID, pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana, partner_pa_sifra from mpman.akcijezag where akc_broj = " + brojAkcije + "", ref akcijazag);
                if (akcijazag.Rows.Count > 0)
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    IDposlovnice = dohvati.DohvatiIDSifra("po_ID","poslovnica","po_sifra = "+sifraTrgovine+"");
                    //select stavke sve ili ako je 16 kategorija onda samo od trenutno odabrane trgovine 

                    if (akcijazag.Rows[0][1].ToString() != "16")
                    {
                        veza.ExecuteQuery("select akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, akc_kune, akc_cijena, akc_bodovi,pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediod, pok_vrijedido, bk_kod from mpman.akcije where akc_broj = '" + brojAkcije + "'", ref akcija);
                    }
                    else
                    {
                        veza.ExecuteQuery("select akc_ID, pok_sifra, akc_broj, pok_opis, pok_opis2, rg_sifra, ar_sifra, ar_naziv, pok_iznos, pok_kolic, pok_komada, pok_vaziod, pok_vazido, pok_odsat, pok_dosat, akc_aktivna, akc_popust, akc_kune, akc_cijena, akc_bodovi,pok_danutjednu, kup_statk, ar_sifradob, ar_nazivdob, pok_vrijediod, pok_vrijedido, bk_kod from mpman.akcije where akc_broj = '" + brojAkcije + "' and poslovnica_po_ID ='" + IDposlovnice + "'", ref akcija);
                    }

                    if (akcija.Rows.Count > 0)
                    {
                        veza.ExecuteQuery("select po_IPadresaPoslovnica , po_katalog , po_naziv from poslovnica where po_sifra = " + sifraTrgovine + "", ref baza);
                        
                        if (baza.Rows.Count > 0) 
                        {

                            akcijaZagID = akcijazag.Rows[0][0].ToString();
                            IP = baza.Rows[0][0].ToString();
                            katalog = baza.Rows[0][1].ToString();
                            if (baza.Rows[0][2].ToString().Length > 20)
                            {
                                nazivPoslovnice = baza.Rows[0][2].ToString().Substring(0, 20);
                            }
                            else
                            {
                                nazivPoslovnice = baza.Rows[0][2].ToString();
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

        private void dgOdabraneTrgovine_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOdabraneTrgovine.CurrentRow.Cells[2].Value == null)
            {
                dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "True";
            }
            else if (dgOdabraneTrgovine.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "False";
            }
            else
            {
                dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "True";

                dgOdabraneTrgovine.CurrentRow.Cells[3].Value = "";

                dgOdabraneTrgovine.CurrentRow.Cells[4].Value = "";
            }
        }

        private void dgOdabraneTrgovine_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    if (dgOdabraneTrgovine.CurrentRow.Cells[2].Value == null)
                    {
                        dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "True";
                    }
                    else if (dgOdabraneTrgovine.CurrentRow.Cells[2].Value.ToString() == "True")
                    {
                        dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "False";
                    }
                    else
                    {
                        dgOdabraneTrgovine.CurrentRow.Cells[2].Value = "True";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAkcijeZaTrgovinu_KeyDown(object sender, KeyEventArgs e)
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
    }
}