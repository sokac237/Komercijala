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
    public partial class frmAzurirajStalniNabavniCjenikStavke : Form
    {
        Upiti veza = new Upiti();

        DataTable artikl_postoji_u_dobavljacartikl = new DataTable();

        string _IDCjenika;

        string _IDCjenikStavke;

        string _IDArtikl;

        string _idDobavljac;

        string cijena;

        string rabat;

        string _oznaka;

        string artikl_ID;

        int artikl_postoji_u_stavkama = 0;
        
        public frmAzurirajStalniNabavniCjenikStavke()
        {
            InitializeComponent();
        }

        public string idCjenika
        {
            get { return _IDCjenika; }
            set { _IDCjenika = value; }
        }

        public string idCjenikaStavke
        {
            get { return _IDCjenikStavke; }
            set { _IDCjenikStavke = value; }
        }

        public string ArtiklID
        {
            get { return _IDArtikl; }
            set { _IDArtikl = value; }
        }

        public string DobavljacID
        {
            get { return _idDobavljac; }
            set { _idDobavljac = value; }
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            //}
        }

        private void frmAzurirajStalniNabavniCjenikStavke_KeyDown(object sender, KeyEventArgs e)
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

        private void frmAzurirajStalniNabavniCjenikStavke_Load(object sender, EventArgs e)
        {
            try
            {
                if (_oznaka == "0")
                {                   
                    txtBarkod.Focus();
                    return;
                }
                else
                {                    
                    //txtBarkod.Visible = false;
                    //label1.Visible = false;
                    veza.ExecuteQuery("select nabavnistavka.*, CONCAT(operater.op_ime,' ' ,operater.op_prezime),  artikl.ar_sifra, artikl.ar_naziv from artikl, nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID  where nabavnistavka.artikl_ar_ID = artikl.ar_ID and nabavnistavka.nas_ID = '" + _IDCjenikStavke + "'", ref artikl_postoji_u_dobavljacartikl);

                    DohvatiSifruID dohvati = new DohvatiSifruID();

                    string sifraArtikla = dohvati.DohvatiIDSifra("ar_sifra", "artikl", "ar_ID = " + artikl_postoji_u_dobavljacartikl.Rows[0][2].ToString()+ "");

                    txtBarkod.Focus();

                    txtBarkod.Text = sifraArtikla;

                    txtCijena.Focus();

                    txtBarkod.Enabled = false;
                    txtSifraKodDobavljaca.Enabled = false;

                    if (artikl_postoji_u_dobavljacartikl.Rows.Count > 0)
                    {
                        lblArtikl.Text = artikl_postoji_u_dobavljacartikl.Rows[0][12].ToString();
                        txtCijena.EditValue = artikl_postoji_u_dobavljacartikl.Rows[0][3];
                        txtRabat.EditValue = artikl_postoji_u_dobavljacartikl.Rows[0][4];
                        txtIzmjena.Text = artikl_postoji_u_dobavljacartikl.Rows[0][7].ToString() + "  "+ artikl_postoji_u_dobavljacartikl.Rows[0][10].ToString();
      
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
            if (txtBarkod.Text != "")
            {
                Upit();

                if (artikl_postoji_u_dobavljacartikl.Rows.Count > 0)
                {
                    lblArtikl.Text = artikl_postoji_u_dobavljacartikl.Rows[0][0].ToString();
                    artikl_ID = artikl_postoji_u_dobavljacartikl.Rows[0][9].ToString();

                    //provjera da li vec nije u stavkama cjenika
                    DataTable dat = new DataTable();

                    veza.ExecuteQuery("select nabavnistavka.*, CONCAT(operater.op_ime,' ' ,operater.op_prezime),  artikl.ar_sifra, artikl.ar_naziv from nabavnicjenik, artikl, nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID  where nabavnistavka.artikl_ar_ID = artikl.ar_ID and nabavnistavka.artikl_ar_ID = '" + artikl_ID + "' and  nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID and nabavnicjenik.nac_ID = '" + _IDCjenika + "'", ref dat);

                    if (dat.Rows.Count > 0)
                    {
                        artikl_postoji_u_stavkama = 1;
                    }
                }
                else if (artikl_postoji_u_dobavljacartikl.Rows.Count == 0)
                {
                    DataTable artikl = new DataTable();
                    //provjeri kao sifru u artiklu da dohvatis ID pa provjeri u dobavljacartikl

                    string sifraArtikla = txtBarkod.Text;

                    veza.ExecuteQuery("select ar_ID from artikl where ar_sifra = '"+sifraArtikla+"'", ref artikl);

                    if (artikl.Rows.Count > 0)
                    {
                        string idDobavljac = _idDobavljac;
                        DataTable artikls = new DataTable();
                        veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_pakiranje, artikl.ar_ID from artikl where artikl.ar_sifra = '" + sifraArtikla + "' ", ref artikls);

                        if (artikls.Rows.Count > 0)
                        {
                            lblArtikl.Text = artikls.Rows[0][0].ToString();
                            artikl_ID = artikls.Rows[0][3].ToString();
                            //provjera da li vec nije u stavkama cjenika
                            DataTable dat = new DataTable();

                            veza.ExecuteQuery("select nabavnistavka.*, CONCAT(operater.op_ime,' ' ,operater.op_prezime),  artikl.ar_sifra, artikl.ar_naziv from nabavnicjenik, artikl, nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID  where nabavnistavka.artikl_ar_ID = artikl.ar_ID and nabavnistavka.artikl_ar_ID = '" + artikl_ID + "' and  nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID and nabavnicjenik.nac_ID = '" + _IDCjenika + "'", ref dat);

                            if (dat.Rows.Count > 0)
                            {
                                artikl_postoji_u_stavkama = 1;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ovaj barkod nije prijavljen!");
                            txtBarkod.Text = "";
                            txtBarkod.Focus();
                            lblArtikl.Text = "___";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ovaj artikl nije u šifarniku!");
                        txtBarkod.Text = "";
                        txtBarkod.Focus();
                        lblArtikl.Text = "___";
                    }
                }
                else
                {
                    MessageBox.Show("Ovaj barkod nije prijavljen!");
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                    lblArtikl.Text = "___";
                }
            }
        }

        private void Upit()
        {
            if (txtBarkod.Text != "")
            {
                string barkod = txtBarkod.Text.Trim();

                string idDobavljac = _idDobavljac;

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref artikl_postoji_u_dobavljacartikl);
            }            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCijena.Text != "" && txtRabat.Text != "" && lblArtikl.Text != "___")
                {
                    cijena = Convert.ToString(txtCijena.Text).Replace(',', '.');
                    rabat = Convert.ToString(txtRabat.Text).Replace(',', '.');
                    string operaterID = Global.KorisnikID;

                    if (_oznaka == "0")
                    {
                        if (artikl_postoji_u_stavkama == 1)
                        {
                            MessageBox.Show("Artikl već postoji u stavkama cjenika! F3 za pregled stavki.");
                            this.Close();
                        }
                        else
                        {
                            azurirajDobavljacArtikl();
                            //MessageBox.Show("insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID, nas_tvornickacijena, nas_postorabata, operater_op_ID) values ('" + _IDCjenika + "', " + artikl_ID + ", '" + cijena + "', '" + rabat + "', '" + operaterID + "')");
                            veza.ExecuteQuery("insert into nabavnistavka (nabavniCjenik_nac_ID, artikl_ar_ID, nas_tvornickacijena, nas_postorabata, operater_op_ID) values ('" + _IDCjenika + "', " + artikl_ID + ", '" + cijena + "', '" + rabat + "', '" + operaterID + "')");
                            MessageBox.Show("Uspješno ste dodali zapis!");
                            frmStalniNabavniCjenik.azurirajStavke.PerformClick();
                            this.Close();

                        }                      
                    }
                    else
                    {
                        azurirajDobavljacArtikl();
                        //MessageBox.Show("update nabavnistavka set nas_tvornickacijena = '" + cijena + "', nas_postorabata = '" + rabat + "', operater_op_ID = '" + operaterID + "' where nas_ID = '" + _IDCjenikStavke + "' ");
                        veza.ExecuteQuery("update nabavnistavka set nas_tvornickacijena = '" + cijena + "', nas_postorabata = '" + rabat + "', operater_op_ID = '" + operaterID + "' where nas_ID = '" + _IDCjenikStavke + "' ");
                        MessageBox.Show("Uspješno ste ažurirali zapis!");
                        frmStalniNabavniCjenik.azurirajStavke.PerformClick();
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja!");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAzurirajStalniNabavniCjenikStavke_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void azurirajDobavljacArtikl()
        {
            try
            {
                //provjeri dali postoji u dobavljac artikl
                DataTable dobar = new DataTable();
                if (_oznaka != "0")
                {
                    
                    veza.ExecuteQuery("select doa_ID, artikl_ar_ID, partneri_pa_ID from dobavljacartikl where artikl_ar_ID = " + _IDArtikl + " and partneri_pa_ID = " + _idDobavljac + "", ref dobar);
                }
                else
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    artikl_ID = dohvati.DohvatiIDSifra("ar_ID", "artikl", "ar_sifra = '"+txtBarkod.Text+"'");

                    if (artikl_ID == null)
                    {
                        artikl_ID = dohvati.DohvatiIDSifra("artikl_ar_ID", "barkod", "bk_kod = '" + txtBarkod.Text + "'");
                    }

                    veza.ExecuteQuery("select doa_ID, artikl_ar_ID, partneri_pa_ID from dobavljacartikl where artikl_ar_ID = " + artikl_ID + " and partneri_pa_ID = " + _idDobavljac + "", ref dobar);
                }

                if (dobar.Rows.Count > 0)
                {
                    string ID = dobar.Rows[0][0].ToString();
                    //ako postoji update
                    veza.ExecuteQuery("update dobavljacartikl set doa_tvornickacijena = '" + cijena + "' ,doa_postorabata = '" + rabat + "' where doa_ID = " + ID + " ");
                }
                else
                {
                    if (_oznaka != "0")
                    {
                        //ako ne postoji insert
                        //veza.ExecuteQuery(@"insert into dobavljacartikl (artikl_ar_ID, partneri_pa_ID, doa_nabcij, doa_tvornickacijena, doa_postorabata)  
                        //                values(" + _IDArtikl + ", " + _idDobavljac + ", '" + cijena + "', '" + cijena + "', '" + rabat + "') ");
                    }
                    else
                    {
                        //veza.ExecuteQuery(@"insert into dobavljacartikl (artikl_ar_ID, partneri_pa_ID, doa_nabcij, doa_tvornickacijena, doa_postorabata)  
                        //                values(" + artikl_ID + ", " + _idDobavljac + ", '" + cijena + "', '" + cijena + "', '" + rabat + "') ");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmArtikl _frm = new frmArtikl();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtBarkod.Text = _frm.sifra_artikl;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }



        private void txtSifraKodDobavljaca_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSifraKodDobavljaca.Text != "")
                {
                    //provjeri u dobavljacartikl i dohvati sifru

                    DataTable podaci = new DataTable();

                    veza.ExecuteQuery("select dobavljacartikl.artikl_ar_ID,artikl.ar_sifra, artikl.ar_naziv from dobavljacartikl left join artikl on artikl.ar_ID = dobavljacartikl.artikl_ar_ID where dobavljacartikl.doa_sifraKodDobavljaca = " + txtSifraKodDobavljaca.Text + " and dobavljacartikl.partneri_PA_ID = " + _idDobavljac + "", ref podaci);

                    if (podaci.Rows.Count > 0)
                    {
                        txtBarkod.Text = podaci.Rows[0][1].ToString();
                        lblArtikl.Text = podaci.Rows[0][2].ToString();
                        //txtCijena.Focus();
                    }
                    else
                    {
                        txtBarkod.Text = "";
                        lblArtikl.Text = "___";
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
