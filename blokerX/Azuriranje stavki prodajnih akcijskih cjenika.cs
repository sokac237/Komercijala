using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using blokerX.Sifarnik;

namespace blokerX
{
    public partial class frmAzurirajStavkeProdajnihAkcijskihCjenika : Form
    {
        Upiti veza = new Upiti();
        DataTable data = new DataTable();

        string idDobavljac;

        string _idCjenika;
        string _idpartner;
        string _nazivpartner;
        string _oznaka;
        string _IDArtikla;
        string _nivoCjenika;

        int aktiv;
        string cijenaLetka;
        string napomena;
        string cijA;
        string cijB;
        string cijC;
        string cijD;
        string cijX;
        string ima_artikla_u_prodajnistavke;

        DataTable artikl = new DataTable();
        DataTable prodajni = new DataTable();
        DataTable preznaStopa = new DataTable();
        DataTable maloprodCijene = new DataTable();

        decimal povratna;
        decimal nabavnaCijena;
        decimal stopaPoreza;
        string prodajniCjenikID;

        string IDpartnerStavka;

        int IDArt;

        public frmAzurirajStavkeProdajnihAkcijskihCjenika()
        {
            InitializeComponent();
        }

        public string idProdajniCjenik
        {
            get { return _idCjenika; }
            set { _idCjenika = value; }
        }

        public string idPartner
        {
            get { return _idpartner; }
            set { _idpartner = value; }
        }

        public string NazivPartner
        {
            get { return _nazivpartner; }
            set { _nazivpartner = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string idArtikla
        {
            get { return _IDArtikla; }
            set { _IDArtikla = value; }
        }

        public string KojiNivo
        {
            get { return _nivoCjenika; }
            set { _nivoCjenika = value; }
        }
        private void napuniGrid()
        {
            
            string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

            DateTime dt;

            dt = DateTime.Now.Date.AddDays(-60);
            IDArt = Convert.ToInt32(_IDArtikla);
            this.pregledProdCijTableAdapter.MaloprodajnaCijena(this.pregled_prodajnih_cijena.PregledProdCij, IDArt, dt);
        }

        private void frmAzurirajStavkeProdajnihAkcijskihCjenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
           
            if (_oznaka == "F4")
            {
                //panel3.Visible = true;
                //this.Height = panel2.Height +20;
                panel1.Visible = false;
                Upit();
                napuniFormu();
                preracunajMarzu();
                napuniGrid();
            }
            else //insert
           {
                panel2.Enabled = false;
                cmbAktivna.Text = "Da";
                glDobavljac.EditValue = _idpartner;

                if (_idpartner == "")
                {
                    glDobavljac.EditValue = Global.dobavljacID;
                }
                else
                {
                    glDobavljac.EditValue = _idpartner;
                }
           } 

            if (_idpartner == "")
            {
                lblNazivPartnera.Text = "";
                label7.Visible = false;
            }
            else
            {
                lblNazivPartnera.Text = _nazivpartner;
            }
            
        }

        private void frmAzurirajStavkeProdajnihAkcijskihCjenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("Izlaz bez spremanja promjena?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void Upit()
        {
            try
            {
                DohvatiSifruID dohvati = new DohvatiSifruID();

                if (txtBarkod.Text != "")
                {
                    string barkod = txtBarkod.Text.Trim();

                    if (_idpartner == "")
                    {
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID", ref data);
                    }
                    else
                    {
                        idDobavljac = _idpartner;
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);
                    }
                }
                else if (txtSifArtikl.Text != "")
                {
                    string sifraArtikl = txtSifArtikl.Text.Trim();

                    if (_idpartner == "")
                    {
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where artikl.ar_sifra = '" + sifraArtikl + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID", ref data);
                    }
                    else
                    {
                        string idDobavljac = _idpartner;
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where artikl.ar_sifra = '" + sifraArtikl + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);
                    }
                }
                else if (txtSifKodDobavljac.Text != "")
                {
                    string sifraKodDob = txtSifKodDobavljac.Text.Trim();

                    if (_idpartner == "")
                    {
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,  artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where dobavljacartikl.doa_sifraKodDobavljaca = '" + sifraKodDob + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID", ref data);
                    }
                    else
                    {
                        string idDobavljac = _idpartner;
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,  artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where dobavljacartikl.doa_sifraKodDobavljaca = '" + sifraKodDob + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);
                    }
                }
                if (data.Rows.Count > 0)
                {
                    _IDArtikla = data.Rows[0][9].ToString();
                    napuniGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtSifArtikl_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSifArtikl.Text != "")
                {
                    Upit();
                    if (data.Rows.Count > 0)
                    {
                        lblNaziv.Text = data.Rows[0][0].ToString();
                        txtSifArtikl.Text = data.Rows[0][1].ToString();
                        napuniFormu();
                        preracunajMarzu();
                        panel2.Enabled = true;
                        txtCijenaA.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ova šifra ne postoji!");
                        txtSifArtikl.Text = "";
                        txtSifArtikl.Focus();
                        txtBarkod.Text = "";
                        lblNaziv.Text = "___";
                        panel2.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtSifKodDobavljac_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSifKodDobavljac.Text != "")
                {
                    Upit();
                    if (data.Rows.Count > 0)
                    {
                        lblNaziv.Text = data.Rows[0][0].ToString();
                        txtSifArtikl.Text = data.Rows[0][1].ToString();
                        napuniFormu();
                        preracunajMarzu();
                        panel2.Enabled = true;
                    }
                    else
                    {
                        txtSifKodDobavljac.Text = "";
                        lblNaziv.Text = "___";
                        panel2.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBarkod.Text != "")
                {
                    Upit();
                    if (data.Rows.Count > 0)
                    {
                        lblNaziv.Text = data.Rows[0][0].ToString();
                        txtSifArtikl.Text = data.Rows[0][1].ToString();
                        napuniFormu();
                        preracunajMarzu();
                        panel2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ovaj barkod nije prijavljen!");
                        txtBarkod.Text = "";
                        txtBarkod.Focus();
                        txtSifArtikl.Text = "";
                        lblNaziv.Text = "___";
                        panel2.Enabled = false;
                    }
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

        private void napuniFormu()
        {
            try
            {
                veza.ExecuteQuery("select ar_naziv, poreznaStopa_pzs_ID, ar_povnak from artikl where ar_ID = '" + _IDArtikla + "'", ref artikl);

                if (artikl.Rows.Count > 0)
                {
                    lblNazivArtikla.Text = artikl.Rows[0][0].ToString();
                    string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");
                    veza.ExecuteQuery("select * from porez where poreznaStopa_pzs_ID = '" + artikl.Rows[0][1].ToString() + "' and '" + datum + "' between pz_datumod and pz_datumdo", ref preznaStopa);

                    if (preznaStopa.Rows.Count > 0)
                    {
                        string porez = preznaStopa.Rows[0][1].ToString();

                        txtStopaPoreza.Text = porez;
                        lblNazivArtikla.Text = artikl.Rows[0][0].ToString();
                    }
                    DataTable zalihe = new DataTable();
                    veza.ExecuteQuery("select zaliha.za_nabcij from zaliha, artikl where zaliha.artikl_ar_ID=artikl.ar_ID and zaliha.poslovnica_po_id = artikl.poslovnica_po_id and  zaliha.artikl_ar_ID = '" + _IDArtikla + "'", ref zalihe);

                    if (zalihe.Rows.Count > 0)
                    {
                        string nabavna = zalihe.Rows[0][0].ToString();
                        txtNabavna.Text = nabavna;
                    }
                }

                if (_nivoCjenika == "2")
                {
                    veza.ExecuteQuery("select prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, prodajnistavka.prc_napomena, prodajnistavka.prc_letak, prodajnistavka.prc_aktivna, prodajnicjenik.prc_ID from prodajnistavka, prodajnicjenik where prodajnicjenik.prc_nivo =2 and prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and prodajnistavka.prodajnicjenik_prc_ID = '" + _idCjenika + "'", ref prodajni);
                }
                else if (_nivoCjenika == "3")
                {
                    veza.ExecuteQuery("select prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, prodajnistavka.prc_napomena, prodajnistavka.prc_letak, prodajnistavka.prc_aktivna, prodajnicjenik.prc_ID from prodajnistavka, prodajnicjenik where prodajnicjenik.prc_nivo =3 and prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and prodajnistavka.prodajnicjenik_prc_ID = '" + _idCjenika + "'", ref prodajni);
                    
                }

                veza.ExecuteQuery("select prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx from prodajnistavka, prodajnicjenik where prodajnicjenik.prc_nivo =1 and prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID", ref maloprodCijene);
                if (maloprodCijene.Rows.Count > 0)
                {
                    txtMaloprodajnaA.Text = maloprodCijene.Rows[0][0].ToString();
                    txtMaloprodajnaB.Text = maloprodCijene.Rows[0][1].ToString();
                    txtMaloprodajnaC.Text = maloprodCijene.Rows[0][2].ToString();
                    txtMaloprodajnaD.Text = maloprodCijene.Rows[0][3].ToString();
                    txtMaloprodajnaX.Text = maloprodCijene.Rows[0][4].ToString();
                }
                else
                {
                    txtMaloprodajnaA.Text = "0.00";
                    txtMaloprodajnaB.Text = "0.00";
                    txtMaloprodajnaC.Text = "0.00";
                    txtMaloprodajnaD.Text = "0.00";
                    txtMaloprodajnaX.Text = "0.00";
                }

                if (prodajni.Rows.Count > 0)
                {
                    prodajniCjenikID = prodajni.Rows[0][8].ToString();
                    ima_artikla_u_prodajnistavke = "1";
                    txtCijenaA.Text = prodajni.Rows[0][0].ToString();
                    txtCijenaB.Text = prodajni.Rows[0][1].ToString();
                    txtCijenaC.Text = prodajni.Rows[0][2].ToString();
                    txtCijenaD.Text = prodajni.Rows[0][3].ToString();
                    txtCijenaX.Text = prodajni.Rows[0][4].ToString();
                    txtNapomena.Text = prodajni.Rows[0][5].ToString();
                    txtCijenaLetka.Text = prodajni.Rows[0][6].ToString();

                    if (prodajni.Rows[0][7].ToString() == "True")
                    {
                        cmbAktivna.Text = "Da";
                    }
                    else
                    {
                        cmbAktivna.Text = "Ne";
                    }
                }
                else
                {
                    ima_artikla_u_prodajnistavke = "0";
                    txtCijenaA.Value = "0.00";
                    txtCijenaB.Value = "0.00";
                    txtCijenaC.Value = "0.00";
                    txtCijenaD.Value = "0.00";
                    txtCijenaX.Value = "0.00";
                    txtCijenaLetka.Text = "0.00";
                }

                txtCijenaA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void preracunajMarzu()
        {
            try
            {
                povratna = Convert.ToDecimal(artikl.Rows[0][2].ToString());
                nabavnaCijena = Convert.ToDecimal(txtNabavna.EditValue);
                stopaPoreza = Convert.ToDecimal(txtStopaPoreza.EditValue);


                if (Convert.ToDecimal(txtCijenaA.Value) != 0)
                {
                    decimal bezPDVA = (Convert.ToDecimal(txtCijenaA.Value) - povratna) / (1 + stopaPoreza / 100);
                    decimal RUCA = bezPDVA - nabavnaCijena;
                    decimal marzaA = Math.Round(100 * (RUCA / (nabavnaCijena - povratna)), 2);
                    txtMarzaA.Value = marzaA;
                }
                else
                {
                    txtMarzaA.Value = 0;
                }

                if (Convert.ToDecimal(txtCijenaB.Value) != 0)
                {
                    decimal bezPDVB = (Convert.ToDecimal(txtCijenaB.Value) - povratna) / (1 + stopaPoreza / 100);
                    decimal RUCB = bezPDVB - nabavnaCijena;
                    decimal marzaB = Math.Round(100 * (RUCB / (nabavnaCijena - povratna)), 2);
                    txtMarzaB.Value = marzaB;
                }
                else
                {
                    txtMarzaB.Value = 0;
                }
                if (Convert.ToDecimal(txtCijenaC.Value) != 0)
                {
                    decimal bezPDVC = (Convert.ToDecimal(txtCijenaC.Value) - povratna) / (1 + stopaPoreza / 100);
                    decimal RUCC = bezPDVC - nabavnaCijena;
                    decimal marzaC = Math.Round(100 * (RUCC / (nabavnaCijena - povratna)), 2);
                    txtMarzaC.Value = marzaC;
                }
                else
                {
                    txtMarzaC.Value = 0;
                }
                if (Convert.ToDecimal(txtCijenaD.Value) != 0)
                {
                    decimal bezPDVD = (Convert.ToDecimal(txtCijenaD.Value) - povratna) / (1 + stopaPoreza / 100);
                    decimal RUCD = bezPDVD - nabavnaCijena;
                    decimal marzaD = Math.Round(100 * (RUCD / (nabavnaCijena - povratna)), 2);
                    txtMarzaD.Value = marzaD;
                }
                else
                {
                    txtMarzaD.Value = 0;
                }
                if (Convert.ToDecimal(txtCijenaX.Value) != 0)
                {
                    decimal bezPDVX = (Convert.ToDecimal(txtCijenaX.Value) - povratna) / (1 + stopaPoreza / 100);
                    decimal RUCX = bezPDVX - nabavnaCijena;
                    decimal marzaX = Math.Round(100 * (RUCX / (nabavnaCijena - povratna)), 2);
                    txtMarzaX.Value = marzaX;
                }
                else
                {
                    txtMarzaX.Value = 0;
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
                if (glDobavljac.Text != "")
                {
                    IDpartnerStavka = glDobavljac.EditValue.ToString();
                }
                else
                {
                    IDpartnerStavka = "default";
                }


                if (cmbAktivna.Text == "Da")
                {
                    aktiv = 1;
                }
                else
                {
                    aktiv = 0;
                }

                cijenaLetka = Convert.ToString(txtCijenaLetka.Text).Replace(',', '.');

                napomena = txtNapomena.Text;

                if (Convert.ToDecimal(txtCijenaA.Value) != 0)
                {
                    cijA = Convert.ToString(txtCijenaA.Text).Replace(',', '.');
                }
                else
                {
                    cijA = "0";
                }
                if (Convert.ToDecimal(txtCijenaB.Value) != 0)
                {
                    cijB = Convert.ToString(txtCijenaB.Text).Replace(',', '.');
                }
                else
                {
                    cijB = "0";
                }
                if (Convert.ToDecimal(txtCijenaC.Value) != 0)
                {
                    cijC = Convert.ToString(txtCijenaC.Text).Replace(',', '.');
                }
                else
                {
                    cijC = "0";
                }
                if (Convert.ToDecimal(txtCijenaD.Value) != 0)
                {
                    cijD = Convert.ToString(txtCijenaD.Text).Replace(',', '.');
                }
                else
                {
                    cijD = "0";
                }
                if (Convert.ToDecimal(txtCijenaX.Value) != 0)
                {
                    cijX = Convert.ToString(txtCijenaX.Text).Replace(',', '.');
                }
                else
                {
                    cijX = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void txtMarzaA_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtMarzaA.Value) != 0)
            {
                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaA.Value), 2) / 100);

                txtCijenaA.Value = bezPDV * (1 + stopaPoreza / 100) + povratna;
            }
            else
            {
                txtCijenaA.Value = 0;
            }
        }

        private void txtMarzaB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtMarzaB.Value) != 0)
            {
                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaB.Value), 2) / 100);

                txtCijenaB.Value = bezPDV * (1 + stopaPoreza / 100) + povratna;
            }
            else
            {
                txtCijenaB.Value = 0;
            }
        }

        private void txtMarzaC_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtMarzaC.Value) != 0)
            {
                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaC.Value), 2) / 100);

                txtCijenaC.Value = bezPDV * (1 + stopaPoreza / 100) + povratna;
            }
            else
            {
                txtCijenaC.Value = 0;
            }
        }

        private void txtMarzaD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtMarzaD.Value) != 0)
            {

                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaD.Value), 2) / 100);

                txtCijenaD.Value = bezPDV * (1 + stopaPoreza / 100) + povratna;
            }
            else
            {
                txtCijenaD.Value = 0;
            }
        }

        private void txtMarzaX_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtMarzaX.Value) != 0)
            {
                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaX.Value), 2) / 100);

                txtCijenaX.Value = Math.Round((bezPDV * (1 + stopaPoreza / 100) + povratna), 2);
            }
            else
            {
                txtCijenaX.Value = 0;
            }
        }

        private void txtCijenaA_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtCijenaA.Value) != 0)
            {
                decimal bezPDVA = (Math.Round(Convert.ToDecimal(txtCijenaA.Value), 2) - povratna) / (1 + stopaPoreza / 100);
                decimal RUCA = bezPDVA - nabavnaCijena;
                decimal marzaA = Math.Round(100 * (RUCA / (nabavnaCijena - povratna)), 2);
                txtMarzaA.Value = marzaA;
            }
            else
            {
                txtMarzaA.Value = 0;
            }
        }

        private void txtCijenaB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtCijenaB.Value) != 0)
            {
                decimal bezPDVB = (Math.Round(Convert.ToDecimal(txtCijenaB.Value), 2) - povratna) / (1 + stopaPoreza / 100);
                decimal RUCB = bezPDVB - nabavnaCijena;
                decimal marzaB = Math.Round(100 * (RUCB / (nabavnaCijena - povratna)), 2);
                txtMarzaB.Value = marzaB;
            }
            else
            {
                txtMarzaB.Value = 0;
            }
        }

        private void txtCijenaC_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtCijenaC.Value) != 0)
            {
                decimal bezPDVA = (Math.Round(Convert.ToDecimal(txtCijenaC.Value), 2) - povratna) / (1 + stopaPoreza / 100);
                decimal RUCA = bezPDVA - nabavnaCijena;
                decimal marzaC = Math.Round(100 * (RUCA / (nabavnaCijena - povratna)), 2);
                txtMarzaC.Value = marzaC;
            }
            else
            {
                txtMarzaC.Value = 0;
            }      
        }

        private void txtCijenaD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtCijenaD.Value) != 0)
            {
                decimal bezPDVD = (Math.Round(Convert.ToDecimal(txtCijenaD.Value), 2) - povratna) / (1 + stopaPoreza / 100);
                decimal RUCD = bezPDVD - nabavnaCijena;
                decimal marzaD = Math.Round(100 * (RUCD / (nabavnaCijena - povratna)), 2);
                txtMarzaD.Value = marzaD;
            }
            else
            {
                txtMarzaD.Value = 0;
            }    
        }

        private void txtCijenaX_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtCijenaX.Value) != 0)
            {
                decimal bezPDVX = (Math.Round(Convert.ToDecimal(txtCijenaX.Value), 2) - povratna) / (1 + stopaPoreza / 100);
                decimal RUCX = bezPDVX - nabavnaCijena;
                decimal marzaX = Math.Round(100 * (RUCX / (nabavnaCijena - povratna)), 2);
                txtMarzaX.Value = marzaX;
            }
            else
            {
                txtMarzaX.Value = 0;
            }
        }

        private void btnApreracun_Click(object sender, EventArgs e)
        {
            //string A = System.Convert.ToString(txtCijenaA.Value);
            decimal formatted = Convert.ToDecimal(txtCijenaA.Value);
            string A = formatted.ToString("N2");
            char zadnjaZnamenka = A[A.Length - 1];

            if (zadnjaZnamenka != 9)
            {
                string preracunatiBroj = A.Substring(0, A.Length - 1) + "9";
                txtCijenaA.Value = Convert.ToDecimal(preracunatiBroj);
                txtCijenaA.Focus();
                btnApreracun.Focus();
            }
        }

        private void btnBpreracun_Click(object sender, EventArgs e)
        {
            //string B = System.Convert.ToString(txtCijenaB.Value);
            decimal formatted = Convert.ToDecimal(txtCijenaB.Value);
            string B = formatted.ToString("N2");
            char zadnjaZnamenka = B[B.Length - 1];

            if (zadnjaZnamenka != 9)
            {
                string preracunatiBroj = B.Substring(0, B.Length - 1) + "9";
                txtCijenaB.Value = Convert.ToDecimal(preracunatiBroj);
                txtCijenaB.Focus();
                btnBpreracun.Focus();
            }
        }

        private void btnCpreracun_Click(object sender, EventArgs e)
        {
            //string C = System.Convert.ToString(txtCijenaC.Value);
            decimal formatted = Convert.ToDecimal(txtCijenaC.Value);
            string C = formatted.ToString("N2");
            char zadnjaZnamenka = C[C.Length - 1];

            if (zadnjaZnamenka != 9)
            {
                string preracunatiBroj = C.Substring(0, C.Length - 1) + "9";
                txtCijenaC.Value = Convert.ToDecimal(preracunatiBroj);
                txtCijenaC.Focus();
                btnCpreracun.Focus();
            }
        }

        private void btnDpreracun_Click(object sender, EventArgs e)
        {
            //string D = System.Convert.ToString(txtCijenaD.Value);
            decimal formatted = Convert.ToDecimal(txtCijenaD.Value);
            string D = formatted.ToString("N2");

            char zadnjaZnamenka = D[D.Length - 1];

            if (zadnjaZnamenka != 9)
            {
                string preracunatiBroj = D.Substring(0, D.Length - 1) + "9";
                txtCijenaD.Value = Convert.ToDecimal(preracunatiBroj);
                txtCijenaD.Focus();
                btnDpreracun.Focus();
            }
        }

        private void btnXpreracun_Click(object sender, EventArgs e)
        {
            //string X = System.Convert.ToString(txtCijenaX.Value);
            decimal formatted = Convert.ToDecimal(txtCijenaX.Value);
            string X = formatted.ToString("N2");
            char zadnjaZnamenka = X[X.Length - 1];

            if (zadnjaZnamenka != 9)
            {
                string preracunatiBroj = X.Substring(0, X.Length - 1) + "9";
                txtCijenaX.Value = Convert.ToDecimal(preracunatiBroj);
                txtCijenaX.Focus();
                btnXpreracun.Focus();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                pokupiPodatke();
                if (ima_artikla_u_prodajnistavke == "0")
                {
                    //MessageBox.Show  ("insert into prodajnistavka set prodajnicjenik_prc_ID = '" + _idCjenika + "', prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "', artikl_ar_ID = '" + _IDArtikla + "'");
                    veza.ExecuteQuery("insert into prodajnistavka set prodajnicjenik_prc_ID = '" + _idCjenika + "', prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "', artikl_ar_ID = '" + _IDArtikla + "', partner_pa_ID = "+IDpartnerStavka+"");
                    MessageBox.Show("Uspješno ste spremili podatke!");
                    this.Close();
                    frmAkcijskiCjenikProdaja.azurirajStavke.PerformClick();
                }
                else
                {
                    //MessageBox.Show  ("update prodajnistavka set prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "' where prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = '" + prodajniCjenikID + "'");
                    veza.ExecuteQuery("update prodajnistavka set prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "' where prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = '" + prodajniCjenikID + "'");
                    MessageBox.Show("Uspješno ste spremili podatke!");
                    this.Close();
                    frmAkcijskiCjenikProdaja.azurirajStavke.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtSifArtikl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtSifKodDobavljac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmAzurirajStavkeProdajnihAkcijskihCjenika_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            Global.dobavljacID = glDobavljac.EditValue.ToString();
        }

        private void txtSifArtikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmArtikl _frm = new frmArtikl();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifArtikl.Text = _frm.sifra_artikl;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
