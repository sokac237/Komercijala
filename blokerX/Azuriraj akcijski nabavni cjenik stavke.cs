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
    public partial class frmAzurirajAkcijskiNabavniStavke : Form
    {
        Upiti veza = new Upiti();

        DataTable artikl_postoji_u_obavljacartikl = new DataTable();

        DataTable nabavnistavka = new DataTable();

        string _IDcjenika;

        string _oznaka;

        string _artiklID;

        string _partnerID;

        int artikl_postoji_u_stavkama = 0;

        string tvornickaCijena;

        string akcijskaCijena;

        string rabat;

        string akcijskiRabat;

        string _idStavkeCjenika;

        string artikl_ID;

        string maxkoeficijent;

        public frmAzurirajAkcijskiNabavniStavke()
        {
            InitializeComponent();
        }

        public string cjenikID
        {
            get { return _IDcjenika; }
            set { _IDcjenika = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string artiklID
        {
            get { return _artiklID; }
            set { _artiklID = value; }
        }

        public string partnerID
        {
            get { return _partnerID; }
            set { _partnerID = value; }
        }

        public string stavkaID
        {
            get { return _idStavkeCjenika; }
            set { _idStavkeCjenika = value; }
        }

        int IDcjenika;
        int IDartikla;


        private void frmAzurirajAkcijskiNabavniStavke_Load(object sender, EventArgs e)
        {
            IDcjenika = Convert.ToInt32(_IDcjenika);
            IDartikla = Convert.ToInt32(_artiklID);

            try
            {
                // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
                this.partnerTableAdapter.Fill(this.dobavljac.partner);

                if (_oznaka == "0") //insert
                {
                    tabcontrol.TabPages.Remove(tabPage2);
                    lblCjenik.Text = "Dodavanje stavki za cjenik broj:  "+ _IDcjenika;
                    glDobavljac.Properties.ReadOnly = true;

                    if (_partnerID == "")
                    {
                        glDobavljac.EditValue = Global.dobavljacID; 
                    }
                    else
                    {
                        glDobavljac.EditValue = _partnerID;
                    }
                    label10.Visible = false;    
                    txtIzmjena.Visible = false;
                    return;
                }
                else  //update
                {
                    veza.ExecuteQuery(" select nabavnistavka.*,artikl.ar_sifra, CONCAT(operater.op_ime,' ' ,operater.op_prezime)  from artikl, nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID  where nabavnistavka.nabavniCjenik_nac_ID = '" + _IDcjenika + "' and nabavnistavka.artikl_ar_ID = '" + _artiklID + "' and artikl.ar_ID = nabavnistavka.artikl_ar_ID", ref nabavnistavka);

                    if (nabavnistavka.Rows.Count > 0)
                    {                        
                        lblCjenik.Text = "Akcijski nabavni cjenik broj:  " + nabavnistavka.Rows[0][1].ToString();
                        lblCjenik2.Text = "Akcijski nabavni cjenik broj:  " + nabavnistavka.Rows[0][1].ToString();
                        
                        glDobavljac.EditValue = _partnerID;
                        txtSifArtikl.Text = nabavnistavka.Rows[0][10].ToString();
                        txtTvornickaCijena.Text = nabavnistavka.Rows[0][3].ToString();
                        txtRabat.Text = nabavnistavka.Rows[0][4].ToString();
                        txtAkcijskaCijena.Text = nabavnistavka.Rows[0][5].ToString();
                        txtAkcijskiRabat.Text = nabavnistavka.Rows[0][6].ToString();
                        txtMaxKoeficijent.Text = nabavnistavka.Rows[0][9].ToString();  
                        txtIzmjena.Text = nabavnistavka.Rows[0][7].ToString() + "  " + nabavnistavka.Rows[0][11].ToString();

                        lblNaziviSifraArtikla.Text = "Artikl: " + txtSifArtikl.Text + " - " + lblNaziv.Text;
                    }

                    txtSifArtikl.ReadOnly = true;   
                    glDobavljac.Properties.ReadOnly = true;
                    txtBarkod.ReadOnly = true;
                    txtSifKodDobavljac.ReadOnly = true;

                    Upit();

                    this.partnerTableAdapter.Fill(this.dobavljac.partner);
                    this.tipPoslovniceMaksimumTableAdapter.Fill(this.tipMaksimum.tipPoslovniceMaksimum, IDcjenika, IDartikla);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }        
        

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtSifArtikl.Text = "";
            txtSifKodDobavljac.Text = "";
            lblNaziv.Text = "___";
            Global.dobavljacID = glDobavljac.EditValue.ToString();
        }

        private void Upit()
        {
            int IDArtikl;
            int pa_ID;
            DohvatiSifruID dohvati = new DohvatiSifruID();
            if (txtBarkod.Text != "")
            {                
                string barkod = txtBarkod.Text.Trim();
                string idDobavljac = glDobavljac.EditValue.ToString();
                pa_ID = Convert.ToInt32(glDobavljac.EditValue);

                IDArtikl = Convert.ToInt32(dohvati.DohvatiIDSifra("artikl_ar_ID", "barkod", "bk_kod = " + barkod + ""));

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref artikl_postoji_u_obavljacartikl);

                if (lblNaziv.Text != "___")
                {
                    this.nabavnistavkaTableAdapter.Fill(this.nabavneCijenePoCjenicima.nabavnistavka, pa_ID, IDArtikl);
                }
            }
            else if (txtSifArtikl.Text != "")
            {
                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraArtikl = txtSifArtikl.Text.Trim();

                IDArtikl = Convert.ToInt32(dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = " + sifraArtikl + ""));
                pa_ID = Convert.ToInt32(glDobavljac.EditValue);

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where artikl.ar_sifra = '" + sifraArtikl + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref artikl_postoji_u_obavljacartikl);

                if (lblNaziv.Text != "___")
                {
                    this.nabavnistavkaTableAdapter.Fill(this.nabavneCijenePoCjenicima.nabavnistavka, pa_ID, IDArtikl);
                }
            }
            else if (txtSifKodDobavljac.Text != "")
            {              

                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraKodDob = txtSifKodDobavljac.Text.Trim();

                IDArtikl = Convert.ToInt32(dohvati.DohvatiIDSifra("artikl_ar_ID", "dobavljacartikl", "doa_sifraKodDobavljaca = " + sifraKodDob + ""));
                pa_ID = Convert.ToInt32(glDobavljac.EditValue);

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,  artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where dobavljacartikl.doa_sifraKodDobavljaca = '" + sifraKodDob + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref artikl_postoji_u_obavljacartikl);

                if (lblNaziv.Text != "___")
                {
                    this.nabavnistavkaTableAdapter.Fill(this.nabavneCijenePoCjenicima.nabavnistavka, pa_ID, IDArtikl);
                }
            }
        }

        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (artikl_postoji_u_obavljacartikl.Rows.Count > 0)
                {
                    lblNaziv.Text = artikl_postoji_u_obavljacartikl.Rows[0][0].ToString();
                    txtSifArtikl.Text = artikl_postoji_u_obavljacartikl.Rows[0][1].ToString();
                    artikl_ID = artikl_postoji_u_obavljacartikl.Rows[0][9].ToString();
                    ArtiklJeUStavkamCjenika();
                }
                else
                {
                    MessageBox.Show("Ovaj barkod nije prijavljen!");
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                    txtSifArtikl.Text = "";
                    lblNaziv.Text = "___";
                    isprazniFormu();
                }
            }
        }

        private void txtSifKodDobavljac_Leave(object sender, EventArgs e)
        {
            if (txtSifKodDobavljac.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (artikl_postoji_u_obavljacartikl.Rows.Count > 0)
                {
                    lblNaziv.Text = artikl_postoji_u_obavljacartikl.Rows[0][0].ToString();
                    txtSifArtikl.Text = artikl_postoji_u_obavljacartikl.Rows[0][1].ToString();
                    artikl_ID = artikl_postoji_u_obavljacartikl.Rows[0][9].ToString();
                    ArtiklJeUStavkamCjenika();
                }
                else
                {
                    txtSifKodDobavljac.Text = "";
                    lblNaziv.Text = "___";
                    isprazniFormu();
                }
            }
        }

        private void txtSifArtikl_Leave(object sender, EventArgs e)
        {
            if (txtSifArtikl.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (artikl_postoji_u_obavljacartikl.Rows.Count > 0)
                {
                    lblNaziv.Text = artikl_postoji_u_obavljacartikl.Rows[0][0].ToString();
                    txtSifArtikl.Text = artikl_postoji_u_obavljacartikl.Rows[0][1].ToString();
                    artikl_ID = artikl_postoji_u_obavljacartikl.Rows[0][9].ToString();
                    ArtiklJeUStavkamCjenika();
                }
                else
                {
                    MessageBox.Show("Ova šifra ne postoji! Morate je vezati za trenutnog dobavljača!");
                    txtSifArtikl.Text = "";
                    txtSifArtikl.Focus();
                    txtBarkod.Text = "";
                    lblNaziv.Text = "___";
                    isprazniFormu();
                }
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

        private void txtSifKodDobavljac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.Text != "" && lblNaziv.Text != "___" || txtSifArtikl.Text != "")
                {
                    if (txtTvornickaCijena.Text != "" || txtAkcijskaCijena.Text != "")
                    {
                        maxkoeficijent = Convert.ToString(txtMaxKoeficijent.Text).Replace(',', '.');

                        if (txtTvornickaCijena.Text != "")
                        {
                            tvornickaCijena = Convert.ToString(txtTvornickaCijena.Text).Replace(',', '.');
                        }
                        else
                        {
                            tvornickaCijena = "0";
                        }

                        if (txtAkcijskaCijena.Text != "")
                        {
                            akcijskaCijena = Convert.ToString(txtAkcijskaCijena.Text).Replace(',', '.');
                        }
                        else
                        {
                            akcijskaCijena = "0";
                        }

                        if (txtRabat.Text != "")
                        {
                            rabat = Convert.ToString(txtRabat.Text).Replace(',', '.');
                        }
                        else
                        {
                            rabat = "0";
                        }

                        if (txtAkcijskiRabat.Text != "")
                        {
                            akcijskiRabat = Convert.ToString(txtAkcijskiRabat.Text).Replace(',', '.');
                        }
                        else
                        {
                            akcijskiRabat = "0";
                        }
                      

                        string operaterID = Global.KorisnikID;     

                        if (_oznaka == "0")
                        {
                            if (artikl_postoji_u_stavkama == 1)
                            {
                                MessageBox.Show("Astikl već postoji u stavkama cjenika! F3 za pregled stavki.");
                                this.Close();
                            }
                            else
                            {
                                //MessageBox.Show("insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID, nas_tvornickacijena, nas_postorabata, nas_akcijskacijena, nas_akcijskirabat, operater_op_ID) values (" + _IDcjenika + ", " + artikl_ID + ", " + tvornickaCijena + ", " + rabat + ", "+akcijskaCijena+", "+akcijskiRabat+", " + operaterID + ")");
                                veza.ExecuteQuery("insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID, nas_tvornickacijena, nas_postorabata, nas_akcijskacijena, nas_akcijskirabat, operater_op_ID, nas_maxkoeficijent) values (" + _IDcjenika + ", " + artikl_ID + ", " + tvornickaCijena + ", " + rabat + ", "+akcijskaCijena+", "+akcijskiRabat+", " + operaterID + ", '"+maxkoeficijent+"')");
                                MessageBox.Show("Uspješno ste dodali zapis!");
                                frmAkcijskiNabavniCjenik.azurirajStavke.PerformClick();
                                //this.Close();


                                //DohvatiSifruID dohvati = new DohvatiSifruID();

                                //string cjenikID = dohvati.DohvatiIDSifra("","","");
             
                                lblCjenik2.Text = "Akcijski nabavni cjenik broj:   " + _IDcjenika;
                                

                                lblNaziviSifraArtikla.Text = "Artikl:  " + txtSifArtikl.Text + " - " + lblNaziv.Text;

                                this.tipPoslovniceMaksimumTableAdapter.Fill(this.tipMaksimum.tipPoslovniceMaksimum, IDcjenika, IDartikla);

                                tabcontrol.TabPages.Add(tabPage2);

                                if (tabcontrol.SelectedTab == tabPage1)
                                    tabcontrol.SelectedTab = tabPage2;
                                else
                                    tabcontrol.SelectedTab = tabPage1;
                            }
                        }
                        else
                        {
                            //MessageBox.Show("update nabavnistavka set nas_tvornickacijena = '" + cijena + "', nas_postorabata = '" + rabat + "', operater_op_ID = '" + operaterID + "' where nas_ID = '" + _IDCjenikStavke + "' ");
                            veza.ExecuteQuery("update nabavnistavka set nas_tvornickacijena = '"+tvornickaCijena+"', nas_postorabata = '"+rabat+"', nas_akcijskacijena = '"+akcijskaCijena+"', nas_akcijskirabat = '"+akcijskiRabat+"', operater_op_ID = "+operaterID+", nas_maxkoeficijent = '"+maxkoeficijent+"' where nas_ID = '"+_idStavkeCjenika+"'");
                            MessageBox.Show("Uspješno ste ažurirali zapis!");
                            frmAkcijskiNabavniCjenik.azurirajStavke.PerformClick();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Morate upisati tvorničku ili akcijsku cijenu!");
                    }                                
                }
                else
                {
                    MessageBox.Show("Morate popuniti cijenu i rabat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAzurirajAkcijskiNabavniStavke_KeyDown(object sender, KeyEventArgs e)
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

        private void isprazniFormu()
        {
            txtTvornickaCijena.Text = "";
            txtRabat.Text = "";
            txtAkcijskiRabat.Text = "";
            txtAkcijskaCijena.Text = "";
            return;
        }

        private void ArtiklJeUStavkamCjenika()
        {
            //provjera da li vec nije u stavkama cjenika
            DataTable dat = new DataTable();

            veza.ExecuteQuery("select nabavnistavka.*, CONCAT(operater.op_ime,' ' ,operater.op_prezime),  artikl.ar_sifra, artikl.ar_naziv from nabavnicjenik, artikl, nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID  where nabavnistavka.artikl_ar_ID = artikl.ar_ID and nabavnistavka.artikl_ar_ID = '" + artikl_ID + "' and  nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID and nabavnicjenik.nac_ID = '" + _IDcjenika + "'", ref dat);

            if (dat.Rows.Count > 0)
            {
                artikl_postoji_u_stavkama = 1;
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "") 
            {
                DataTable barkod = new DataTable();

                string barKOD = txtBarkod.Text.Trim();
                string idDobavljac = glDobavljac.EditValue.ToString();

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref barkod);

                if (barkod.Rows.Count > 0)
                {
                    lblNaziv.Text = barkod.Rows[0][0].ToString();
                }
            }
        }

        private void txtSifArtikl_TextChanged(object sender, EventArgs e)
        {
            if (txtSifArtikl.Text != "")
            {
                DataTable artiklSifra = new DataTable();
                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraArtikl = txtSifArtikl.Text.Trim();

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where artikl.ar_sifra = '" + sifraArtikl + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref artiklSifra);

                if (artiklSifra.Rows.Count > 0)
                {
                    lblNaziv.Text = artiklSifra.Rows[0][0].ToString();
                }
            }
        }

        private void txtSifKodDobavljac_TextChanged(object sender, EventArgs e)
        {
            if (txtSifKodDobavljac.Text != "")
            {
                DataTable sifDobavljac = new DataTable();
                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraKodDob = txtSifKodDobavljac.Text.Trim();

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,  artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where dobavljacartikl.doa_sifraKodDobavljaca = '" + sifraKodDob + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref sifDobavljac);

                if (sifDobavljac.Rows.Count > 0)
                {
                    lblNaziv.Text = sifDobavljac.Rows[0][0].ToString();
                }
            }
        }

        private void frmAzurirajAkcijskiNabavniStavke_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAkcRab_Leave(object sender, EventArgs e)
        {
            try
            {
                //prepračun nabavne cijene
                //txtAkcijskaCijena.EditValue = Convert.ToInt32(txtTvornickaCijena.EditValue) * (((100 - Convert.ToInt32(txtRabat.EditValue))*(100 - Convert.ToInt32(txtAkcijskiRabat.EditValue))) / 10000);
                //txtAkcijskaCijena.EditValue = Convert.ToInt32(txtTvornickaCijena.EditValue) * (((100 - Convert.ToInt32(txtRabat.EditValue)) / 100) * ((100 - Convert.ToInt32(txtAkcijskiRabat.EditValue))/100));
                decimal prvirabat = Convert.ToDecimal(txtRabat.Value);
                decimal drugirabat = Convert.ToDecimal(txtAkcijskiRabat.Value);
                decimal a = (100 - prvirabat) / 100;
                decimal b = (100 - drugirabat) / 100;
                txtAkcijskaCijena.Value = Convert.ToDecimal(txtTvornickaCijena.Value) * a * b;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTvor_Enter(object sender, EventArgs e)
        {
            txtTvornickaCijena = sender as Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit;
            if (txtTvornickaCijena != null)
                txtTvornickaCijena.SelectAll();
        }

        private void txtRab_Enter(object sender, EventArgs e)
        {
            txtRabat = sender as Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit;
            if (txtRabat != null)
                txtRabat.SelectAll();
        }

        private void txtAkcRab_Enter(object sender, EventArgs e)
        {
            txtAkcijskiRabat = sender as Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit;
            if (txtAkcijskiRabat != null)
                txtAkcijskiRabat.SelectAll();
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

        private void dgMaksPoTipu_MouseWheel(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DevExpress.XtraEditors.TextEdit edit = dgMaksPoTipu.ActiveEditor as DevExpress.XtraEditors.TextEdit;


            //view.CloseEditor();
            if (e.Delta < 0)
            {
                view.MoveNext();
                dgMaksPoTipu.FocusedColumn = dgMaksPoTipu.VisibleColumns[1];

                dgMaksPoTipu.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }
            else if (e.Delta > 0)
            {
                view.MovePrev();
                dgMaksPoTipu.FocusedColumn = dgMaksPoTipu.VisibleColumns[1];

                dgMaksPoTipu.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }

            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }

        private void dgMaksPoTipu_GotFocus(object sender, EventArgs e)
        {
            dgMaksPoTipu.FocusedColumn = dgMaksPoTipu.VisibleColumns[1];

            dgMaksPoTipu.ShowEditor();

            DevExpress.XtraEditors.TextEdit edit = dgMaksPoTipu.ActiveEditor as DevExpress.XtraEditors.TextEdit;

            if (edit != null)
                edit.SelectAll();
        }

        private void dgMaksPoTipu_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    dgMaksPoTipu.FocusedColumn = dgMaksPoTipu.VisibleColumns[1];

                    dgMaksPoTipu.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgMaksPoTipu.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgMaksPoTipu.FocusedColumn = dgMaksPoTipu.VisibleColumns[1];

                    dgMaksPoTipu.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgMaksPoTipu.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgMaksPoTipu_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DohvatiSifruID dohvati = new DohvatiSifruID();
                string IDArtikla = dohvati.DohvatiIDSifra("ar_ID","artikl","ar_sifra  = "+txtSifArtikl.Text+"");

                int IDStavke;
                System.Data.DataRow row = dgMaksPoTipu.GetDataRow(dgMaksPoTipu.FocusedRowHandle);
                if (row != null)
                {
                    if (row["nas_ID"].ToString() != "")
                    {
                        IDStavke = Convert.ToInt32(row["nas_ID"].ToString());
                    }
                    else
                    {
                        IDStavke = 0;
                    }
                    string tipPoslovniceid = row[5].ToString();
                    decimal postotak = 0;

                    if (row["nas_maxkoeficijent"] != DBNull.Value)
                    {
                        postotak = Convert.ToDecimal(row["nas_maxkoeficijent"]);
                                                
                        if (IDStavke != 0)
                        {
                            if (postotak == 0)
                            {
                                //obrisi iz baze ovaj zapis
                                veza.ExecuteQuery("delete from nabavnistavkatip where nas_ID = "+IDStavke+"");
                                int artiklID = Convert.ToInt32(IDArtikla);
                                this.tipPoslovniceMaksimumTableAdapter.Fill(this.tipMaksimum.tipPoslovniceMaksimum, IDcjenika, artiklID);
                            }
                            else
                            {                                
                                //update

                                veza.ExecuteQuery("update nabavnistavkatip set operater_op_ID = " + Global.KorisnikID + ", nas_maxkoeficijent = " + postotak + " where nas_ID = " + IDStavke + "");
                                int artiklID = Convert.ToInt32(IDArtikla);
                                this.tipPoslovniceMaksimumTableAdapter.Fill(this.tipMaksimum.tipPoslovniceMaksimum, IDcjenika, artiklID);
                            }
                        }
                        else // insert
                        {
                            if (postotak != 0)
                            {

                                veza.ExecuteQuery("insert into nabavnistavkatip (nabavnicjenik_nac_ID, artikl_ar_ID, operater_op_ID, nas_maxkoeficijent, tipposlovnice_tip_ID) values (" + _IDcjenika + ", " + IDArtikla + ", '" + Global.KorisnikID + "'," + postotak + ", '" + tipPoslovniceid + "') ");

                                int artiklID = Convert.ToInt32(IDArtikla);
                                this.tipPoslovniceMaksimumTableAdapter.Fill(this.tipMaksimum.tipPoslovniceMaksimum, IDcjenika, artiklID);
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
    }
}
