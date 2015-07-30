using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blokerX
{
    public partial class frmIzmjenaCijena : Form
    {
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

        Upiti veza = new Upiti();

        decimal povratna;
        decimal nabavnaCijena;
        decimal stopaPoreza;
        string _IDArtikla;
        string _forma;
        string _idPartnera;
        string prodajniCjenikID;

        public frmIzmjenaCijena()
        {
            InitializeComponent();
        }

        private void frmIzmjenaCijena_Load(object sender, EventArgs e)
        {
            DohvatiSifruID dohvati = new DohvatiSifruID();
            lblSifra.Text = dohvati.DohvatiIDSifra("ar_sifra", "artikl", "ar_id = '" + _IDArtikla + "'");
            napuniFormu();
            preracunajMarzu();
        }

        public string idArtikla
        {
            get { return _IDArtikla; }
            set { _IDArtikla = value; }
        }

        public string IDPartnera
        {
            get { return _idPartnera; }
            set { _idPartnera = value; }
        }

        public string kojaFormaPoziva
        {
            get { return _forma; }
            set { _forma = value; }
        }

        private void napuniFormu()
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

                if (_forma == "Stalni cjenik po dobavljaču" || _forma == "Artikli dobavljača po barkodu")
                {
                    DataTable zalihe = new DataTable();

                    veza.ExecuteQuery("select  round (dobavljacartikl.doa_tvornickacijena - (dobavljacartikl.doa_tvornickacijena * dobavljacartikl.doa_postorabata)/100, 5) as nabavnaCijena from artikl,dobavljacartikl where dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.artikl_ar_ID = '" + _IDArtikla + "' and dobavljacartikl.partneri_pa_ID = '"+_idPartnera+"'", ref zalihe);
                    //veza.ExecuteQuery("select  nas_tvornickacijena, nas_postorabata, nas_akcijskacijena, nac_vaziod, nac_vazido from nabavnistavka left join nabavnicjenik on nabavnicjenik.nac_ID=nabavnistavka.nabavniCjenik_nac_ID where artikl_ar_id=" + _IDArtikla + " and nabavnicjenik_nac_id in (select nac_id from nabavnicjenik where nac_vaziod<= '" + datum + "'  and nac_vazido IS null  and partneri_pa_id= " + _idPartnera + ") order by nac_vaziod desc LIMIT 1", ref zalihe);
                    //veza.ExecuteQuery("select zaliha.za_nabcij from zaliha, artikl where zaliha.artikl_ar_ID=artikl.ar_ID and zaliha.poslovnica_po_id = artikl.poslovnica_po_id and  zaliha.artikl_ar_ID = '" + _IDArtikla + "'", ref zalihe);

                    if (zalihe.Rows.Count > 0)
                    {
                        string nabavna = zalihe.Rows[0][0].ToString();
                        //decimal tvornicka = Convert.ToDecimal(zalihe.Rows[0][0].ToString());
                        //decimal rabat = Convert.ToDecimal(zalihe.Rows[0][1].ToString());
                        //decimal sve = tvornicka - (tvornicka * rabat) / 100;
                        //string nabavna = sve.ToString();

                        txtNabavna.Text = nabavna;
                    }
                }
                else
                {
                    DataTable zalihe = new DataTable();

                    veza.ExecuteQuery("select  dobavljacartikl.doa_tvornickacijena, dobavljacartikl.doa_postorabata from  dobavljacartikl, artikl where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.artikl_ar_ID = '" + _IDArtikla + "' group by artikl.ar_ID", ref zalihe);
                    
                    //veza.ExecuteQuery("select zaliha.za_nabcij from zaliha, artikl where zaliha.artikl_ar_ID=artikl.ar_ID and zaliha.poslovnica_po_id = artikl.poslovnica_po_id and  zaliha.artikl_ar_ID = '" + _IDArtikla + "'", ref zalihe);

                    if (zalihe.Rows.Count > 0)
                    {
                        //string nabavna = zalihe.Rows[0][0].ToString();

                        decimal tvornicka = Convert.ToDecimal(zalihe.Rows[0][0].ToString());
                        decimal rabat = Convert.ToDecimal(zalihe.Rows[0][1].ToString());
                        decimal sve = tvornicka - (tvornicka * rabat) / 100;
                        string nabavna = sve.ToString();
                        txtNabavna.Text = nabavna;
                    }                   
                }                
            }

            //veza.ExecuteQuery("select prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, prodajnistavka.prc_napomena, prodajnistavka.prc_letak, prodajnistavka.prc_aktivna from prodajnistavka, prodajnicjenik where prodajnicjenik.prc_nivo = 1 and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' ", ref prodajni);
            veza.ExecuteQuery("select prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, prodajnistavka.prc_napomena, prodajnistavka.prc_letak, prodajnistavka.prc_aktivna, prodajnicjenik.prc_ID from prodajnistavka, prodajnicjenik where prodajnicjenik.prc_nivo =1 and prodajnicjenik.prc_aktivan =1 and prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and prodajnicjenik.prc_ID = 1", ref prodajni);
            
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

                 if(prodajni.Rows[0][7].ToString() == "True")
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
                 return;
             }
        }

        private void preracunajMarzu()
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIzmjenaCijena_KeyDown(object sender, KeyEventArgs e)
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                pokupiPodatke();
                if (ima_artikla_u_prodajnistavke == "0")
                {
                    //MessageBox.Show("insert into prodajnistavka set prodajnicjenik_prc_ID = 0, prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "', artikl_ar_ID = '" + _IDArtikla + "'");
                    veza.ExecuteQuery("insert into prodajnistavka set prodajnicjenik_prc_ID = 1, prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "', artikl_ar_ID = '" + _IDArtikla + "'");
                    MessageBox.Show("Uspješno ste spremili podatke!");
                    this.Close();

                    if (_forma == "Stalni cjenik po dobavljaču")
                    {
                        frmStalniCjenikPoDobavljacu.prikazi.PerformClick();
                    }
                    else
                    {
                        frmStalniCjenikPoRG.prikazi.PerformClick();
                    }
                }
                else
                {
                    //MessageBox.Show("update prodajnistavka set prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "' where prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = '" + prodajniCjenikID + "'");
                    veza.ExecuteQuery("update prodajnistavka set prc_aktivna = '" + aktiv + "', prc_napomena = '" + napomena + "', prc_letak = '" + cijenaLetka + "', prc_tipa = '" + cijA + "', prc_tipb = '" + cijB + "', prc_tipc = '" + cijC + "', prc_tipd='" + cijD + "', prc_tipX= '" + cijX + "' where prodajnistavka.artikl_ar_ID = '" + _IDArtikla + "' and prodajnistavka.prodajnicjenik_prc_ID = '" + prodajniCjenikID + "'");
                    MessageBox.Show("Uspješno ste spremili podatke!");
                    this.Close();

                    if (_forma == "Stalni cjenik po dobavljaču")
                    {
                        frmStalniCjenikPoDobavljacu.prikazi.PerformClick();
                    }
                    else
                    {
                        frmStalniCjenikPoRG.prikazi.PerformClick();
                    }
                }
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

                decimal bezPDV = (nabavnaCijena - povratna) * (1 + Math.Round(Convert.ToDecimal(txtMarzaD.Value),2) / 100);

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

                txtCijenaX.Value = Math.Round((bezPDV * (1 + stopaPoreza / 100) + povratna),2);
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
                decimal bezPDVA = (Math.Round(Convert.ToDecimal(txtCijenaA.Value),2) - povratna) / (1 + stopaPoreza / 100);
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

        private void frmIzmjenaCijena_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}