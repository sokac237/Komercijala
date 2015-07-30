using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace blokerX
{
    public partial class frmUnosArtikalaKojimaSeMijenjaCijena : Form
    {
        Upiti veza = new Upiti();
        DataTable dozvoljenaNivel = new DataTable();
        string dozvoljenanivelacijaID;

        int DozvoljNivelID;

        string _dozvoljenaID;

        string oznaka;

        string IDstavkaDozvoljenaNivelacija;

        string PrepCijena;

        string artiklID;

        int aktivan;

        string operater;
        string poslovnica;
        string opis;
        string datumOD;
        string datumDO;

        string artiklJeVecDodan;

        public frmUnosArtikalaKojimaSeMijenjaCijena()
        {
            InitializeComponent();
        }

        private void frmUnosArtikalaKojimaSeMijenjaCijena_Load(object sender, EventArgs e)
        {
            try
            {
                if (_dozvoljenaID == "0") //novi
                {
                    panel1.Visible = false;
                    panel4.Visible = false;
                    btnAzuriraj.Enabled = false;
                    btnDodaj.Enabled = false;
                }
                else //update
                {
                    panel4.Visible = false;

                    veza.ExecuteQuery("Select * from dozvoljenanivelacijazag where dnz_ID = " + _dozvoljenaID + "", ref dozvoljenaNivel);

                    if (dozvoljenaNivel.Rows.Count > 0)
                    {
                        txtBroj.Text = dozvoljenaNivel.Rows[0][0].ToString();
                        txtOpisCjenika.Text = dozvoljenaNivel.Rows[0][5].ToString();
                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        operater = dozvoljenaNivel.Rows[0][1].ToString();
                        txtSifraOperatera.Text = dohvati.DohvatiIDSifra("op_sifra","operater","op_ID = "+operater+"");

                        poslovnica = dozvoljenaNivel.Rows[0][2].ToString();
                        txtSifraPoslovnice.Text = dohvati.DohvatiIDSifra("po_sifra", "poslovnica", "po_ID = " + poslovnica + "");

                        dtpOdKada.Text = dozvoljenaNivel.Rows[0][3].ToString();
                        dtpDoKada.Text = dozvoljenaNivel.Rows[0][4].ToString();
                    }
                    PopuniGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string dozvoljenaNivelacija
        {
            get { return _dozvoljenaID; }
            set { _dozvoljenaID = value; }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            txtArtiklSifra.Focus();
            txtPreporucenaCijena.Text = "";
            txtArtiklSifra.Text = "";
            lblNazivArtikla.Text = "___";
            oznaka = "D"; //d - za "dodaj"
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            if (gridView2.RowCount > 0)
            {
                panel4.Visible = true;
                oznaka = "A"; //a - za "azuriraj"

                System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    IDstavkaDozvoljenaNivelacija = row[1].ToString();
                    panel1.Visible = true;
                    txtArtiklSifra.Focus();
                    txtArtiklSifra.Text = row[8].ToString();
                    txtPreporucenaCijena.Text = row[4].ToString();
                    artiklID = row[2].ToString();

                    string aktivan = row[3].ToString();
                    if (aktivan == "True")
                    {
                        ckbAktivna.Checked = true;
                    }
                    else
                    {
                        ckbAktivna.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nemate zapis koji biste ažurirali!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
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

        private void frmUnosArtikalaKojimaSeMijenjaCijena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
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
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (gridView2.RowCount > 0)
                {
                    try
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                                if (row != null)
                                {
                                    dozvoljenanivelacijaID = row[0].ToString();
                                    //MessageBox.Show("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                                    veza.ExecuteQuery("delete from dozvoljenanivelacija where dn_ID = " + dozvoljenanivelacijaID + "");
                                    this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void PopuniGrid()
        {
            try
            {
                DozvoljNivelID = Convert.ToInt32(_dozvoljenaID);
                this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSifraOperatera_TextChanged(object sender, EventArgs e)
        {
            DataTable koID = new DataTable();

            if (txtSifraOperatera.Text != "")
            {
                veza.ExecuteQuery("select CONCAT(operater.op_ime,' ' ,operater.op_prezime) from operater where op_sifra = '" + txtSifraOperatera.Text + "'", ref koID);

                if (koID.Rows.Count > 0)
                {
                    lblNazivOperatera.Text = koID.Rows[0][0].ToString();
                }
                else
                {
                    lblNazivOperatera.Text = "___";
                }
            }
        }

        private void txtSifraPoslovnice_TextChanged(object sender, EventArgs e)
        {
            DataTable poID = new DataTable();

            if (txtSifraPoslovnice.Text != "")
            {
                veza.ExecuteQuery("select po_naziv from poslovnica where po_sifra = '" + txtSifraPoslovnice.Text + "'", ref poID);

                if (poID.Rows.Count > 0)
                {
                    lblNazivPoslovnice.Text = poID.Rows[0][0].ToString();
                }
                else
                {
                    lblNazivPoslovnice.Text = "___";
                }
            }
        }

        private void txtSifraOperatera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmOperater _frm = new frmOperater();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifraOperatera.Text = _frm.sifra_operater;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtSifraPoslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmPoslovnice _frm = new frmPoslovnice();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifraPoslovnice.Text = _frm.sifra_poslovnice;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtArtiklSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();
            if (txtArtiklSifra.Text != "")
            {
                veza.ExecuteQuery("select ar_naziv,ar_ID from artikl where ar_sifra = '" + txtArtiklSifra.Text + "'", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblNazivArtikla.Text = bar.Rows[0][0].ToString();
                    artiklID = bar.Rows[0][1].ToString();
                }
                else
                {
                    lblNazivArtikla.Text = "___";
                }
            }      
        }

        private void txtArtiklSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtArtiklSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmSifarnikArtikala _frm = new frmSifarnikArtikala();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtArtiklSifra.Text = _frm.ArtiklSifra;
                        artiklID = _frm.id_artikl;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnSpremiArtikl_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeriPostojiLiVecDodanTajArtikl();

                if (oznaka == "D" && txtArtiklSifra.Text != "" && txtPreporucenaCijena.Text != "")
                {
                    if (artiklJeVecDodan == "1")
                    {
                        //update
                        PrepCijena = Convert.ToString(txtPreporucenaCijena.Text).Replace(',', '.');

                        if (ckbAktivna.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }
                        veza.ExecuteQuery("update dozvoljenanivelacija set artikl_ar_ID = " + artiklID + ", dn_aktivna = '" + aktivan + "', dn_preporucenacijena = '" + PrepCijena + "', operater_op_ID = " + Global.KorisnikID + " where dn_ID = " + IDstavkaDozvoljenaNivelacija + "");
                        this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
                        panel4.Visible = false;
                    }
                    else
                    {
                        //insert
                        PrepCijena = Convert.ToString(txtPreporucenaCijena.Text).Replace(',', '.');

                        if (ckbAktivna.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }
                        //MessageBox.Show("Insert into pozicijaracun (pozicija_ID, pozr_datumracuna, pozr_iznosracuna, operater_op_ID) values (" + _pozicijaID + ", '" + datumRacuna + "','" + txtIznosRacuna.EditValue + "'," + Global.KorisnikID + ")");
                        veza.ExecuteQuery("insert into dozvoljenanivelacija (dozvoljenanivelacijaZag_dnz_ID, artikl_ar_ID, dn_aktivna, dn_preporucenacijena, operater_op_ID) values (" + _dozvoljenaID + ", " + artiklID + "," + aktivan + "," + PrepCijena + ", " + Global.KorisnikID + ")");
                        this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
                        panel4.Visible = false;
                    }
                    
                }
                else if (oznaka == "A" && txtArtiklSifra.Text != "" && txtPreporucenaCijena.Text != "")
                {
                    PrepCijena = Convert.ToString(txtPreporucenaCijena.Text).Replace(',', '.');

                    if (ckbAktivna.Checked)
                    {
                        aktivan = 1;
                    }
                    else
                    {
                        aktivan = 0;
                    }
                    veza.ExecuteQuery("update dozvoljenanivelacija set artikl_ar_ID = " + artiklID + ", dn_aktivna = '" + aktivan + "', dn_preporucenacijena = '" + PrepCijena + "', operater_op_ID = " + Global.KorisnikID + " where dn_ID = " + IDstavkaDozvoljenaNivelacija + "");
                    this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
                    panel4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DohvatiSifruID dohvati = new DohvatiSifruID();

            poslovnica = dohvati.DohvatiIDSifra("po_ID","poslovnica","po_sifra = '"+txtSifraPoslovnice.Text+"'");
            operater = dohvati.DohvatiIDSifra("op_ID","operater","op_sifra = '"+txtSifraOperatera.Text+"'");
            //nakon uspješnog inserta oslobodim za dodavanje artikala koji se mogu nivelirati
            if (_dozvoljenaID == "0")
            {
                //insert
                if ( txtSifraOperatera.Text != "" && txtSifraPoslovnice.Text != "" && txtOpisCjenika.Text != "")
                {
                    opis = txtOpisCjenika.Text;

                    datumOD = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");

                    datumDO = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                    //MessageBox.Show("insert into pozicija (operater_op_ID, operater_op_ID1, partner_pa_ID,vrstapozicije_pz_ID,poz_opis, poz_opis2, poz_odkada, poz_dokada) values (" + operater + ", " + komercijalist + "," + partnerID + ",  " + vrstaPozicije + ", '" + opis1 + "', '" + opis2 + "', '" + odKada + "', '" + doKada + "') ");
                    //veza.ExecuteQuery("insert into dozvoljenanivelacijazag (operater_op_ID, poslovnica_po_ID, dnz_odKada,dnz_doKada,dnz_opis) values ('" + operater + "', '" + poslovnica + "','" + datumOD + "',  '" + datumDO + "', '" + opis + "') ");
                    dodajZapisUBazu();
                    FrmPregledArtikalaNivelacija.azuriraj.PerformClick();
                    MessageBox.Show("Uspješno ste ažurirali podatak!");
                    Omoguci();
                    //this.Close();
                }
            }
            else
            {
                //update
                if (txtSifraOperatera.Text != "" && txtSifraPoslovnice.Text != "" && txtOpisCjenika.Text != "")
                {
                    opis = txtOpisCjenika.Text;

                    datumOD = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");

                    datumDO = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                    //MessageBox.Show("update pozicija set operater_op_ID = '" + operater + "', operater_op_ID1 = '" + komercijalist + "', partner_pa_ID = '" + partnerID + "',vrstapozicije_pz_ID = '" + vrstaPozicije + "',poz_opis = '" + opis1 + "', poz_opis2 = '" + opis2 + "', poz_odkada = '" + odKada + "', poz_dokada = '" + doKada + "' where poz_ID = " + _pozicijaID + "");
                    veza.ExecuteQuery("update dozvoljenanivelacijazag set operater_op_ID = '" + operater + "', poslovnica_po_ID = '" + poslovnica + "', dnz_odKada = '" + datumOD + "',dnz_doKada = '" + datumDO + "', dnz_opis = '" + opis + "'where dnz_ID = " + _dozvoljenaID + "");
                    FrmPregledArtikalaNivelacija.azuriraj.PerformClick();
                    MessageBox.Show("Uspješno ste ažurirali podatak!");
                    //this.Close();
                }
            }
        }

        private void dodajZapisUBazu()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
            MySqlCommand comm = new MySqlCommand("fOdrediIDDozvoljeneNivelacije", conn);
            comm.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("operater", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = operater;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("poslovnica", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = poslovnica;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("opis", MySqlDbType.String);
            prm.Direction = ParameterDirection.Input;
            prm.Value = opis;
            comm.Parameters.Add(prm);


            prm = new MySqlParameter("odKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = datumOD;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("doKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = datumDO;
            comm.Parameters.Add(prm);

            MySqlParameter retval = comm.Parameters.Add("@nivelacijalID", MySqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            _dozvoljenaID = (string)comm.Parameters["@nivelacijalID"].Value;
            DozvoljNivelID = Convert.ToInt32(_dozvoljenaID);
        }

        private void Omoguci()
        {
            //ako je dodano zaglavlje omogući dodavanje stavki - artikala
            panel4.Visible = true;
            btnAzuriraj.Enabled = true;
            btnDodaj.Enabled = true;
            txtArtiklSifra.Focus();
            oznaka = "D"; //D- dodavanje- insert
        }
        public void ProvjeriPostojiLiVecDodanTajArtikl()
        {
            try
            {
                DataTable artikli = new DataTable();
                veza.ExecuteQuery("select * from dozvoljenanivelacija where dozvoljenanivelacijaZag_dnz_ID = " + _dozvoljenaID + "  and artikl_ar_ID = " + artiklID + " ", ref artikli);
                if (artikli.Rows.Count > 0)
                {
                    artiklJeVecDodan = "1";
                    IDstavkaDozvoljenaNivelacija = artikli.Rows[0][1].ToString();
                }
                else
                {
                    artiklJeVecDodan = "0";
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                            if (row != null)
                            {
                                dozvoljenanivelacijaID = row[0].ToString();
                                //MessageBox.Show("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                                veza.ExecuteQuery("delete from dozvoljenanivelacija where dn_ID = " + dozvoljenanivelacijaID + "");
                                this.artikliZaNivelacijuTableAdapter.Fill(this.artikliZaNivelaciju._ArtikliZaNivelaciju, DozvoljNivelID);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmUnosArtikalaKojimaSeMijenjaCijena_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
