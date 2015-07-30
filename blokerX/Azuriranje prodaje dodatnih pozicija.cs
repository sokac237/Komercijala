using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using blokirajx;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace blokerX
{
    public partial class frmAzuriranjeProdajeDodatnihPozicija : Form
    {
        Upiti veza = new Upiti();

        string _pozicijaID;

        int pozicijaID;

        string tipTrgovine;

        string poslovnicaID;

        int brojac;

        string Iznos;

        string odKada;
        string doKada;
        string vrstaPozicije;
        string partnerID;
        string operater;
        string komercijalist;
        string opis1;
        string opis2;

        string datumRacuna;

        string ID_pozicijaRacun;


        string oznaka; //da li se račun pozicije ažurira ili dodaje

        DataTable pozicija = new DataTable();

        public frmAzuriranjeProdajeDodatnihPozicija()
        {
            InitializeComponent();
        }

        public string IDPozicije
        {
            get { return _pozicijaID; }
            set { _pozicijaID = value; }
        }

        private void frmAzuriranjeProdajeDodatnihPozicija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("Izlaz bez spremanja promjena?", this.Text,  MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

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

        }

        private void frmAzuriranjeProdajeDodatnihPozicija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vrstePozicija.vrstapozicije' table. You can move, or remove it, as needed.
            this.vrstapozicijeTableAdapter.Fill(this.vrstePozicija.vrstapozicije);

            try
            {
                // TODO: This line of code loads data into the 'dodatne_pozicije_popis_poslovnica.poslovnica' table. You can move, or remove it, as needed.
                this.poslovnicaTableAdapter.Fill(this.dodatne_pozicije_popis_poslovnica.poslovnica);

                if (_pozicijaID == "0")
                {
                    btnBrisi.Enabled = false;
                    btnDodaj.Enabled = false;
                    btnIzmijeni.Enabled = false;
                    btnDesno.Enabled = false;
                    btnLijevo.Enabled = false;
                    groupBox1.Enabled = false;
                    panel7.Visible = false;
                    panel1.Visible = false;
                    return;
                }
                else
                {
                    veza.ExecuteQuery("select pozicija.*, vrstapozicije.vp_naziv ,CONCAT(operater.op_ime,' ' ,operater.op_prezime) from pozicija left outer join operater on pozicija.operater_OP_ID = operater.op_ID , vrstapozicije where pozicija.vrstapozicije_pz_id = vrstapozicije.vp_id and pozicija.poz_ID =" + _pozicijaID + "", ref pozicija);
                    if (pozicija.Rows.Count > 0)
                    {
                        txtbroj.Text = pozicija.Rows[0][0].ToString();
                        DataTable komer = new DataTable();
                        komercijalist = pozicija.Rows[0][2].ToString();
                        veza.ExecuteQuery("select op_sifra from operater where op_ID ="+komercijalist+"", ref komer);
                        txtKomercijalist.Text = komer.Rows[0][0].ToString();

                        partnerID = pozicija.Rows[0][4].ToString();
                        DataTable partner = new DataTable();
                        veza.ExecuteQuery("select pa_sifra from partner where pa_ID = "+partnerID+"", ref partner);
                        txtDobavljac.Text = partner.Rows[0][0].ToString();
                        
                        txtPozicija.Text = pozicija.Rows[0][10].ToString();
                        txtOpis1.Text = pozicija.Rows[0][6].ToString();
                        txtOpis2.Text = pozicija.Rows[0][7].ToString();
                        txtMijenjao.Text = pozicija.Rows[0][3].ToString() + "  " + pozicija.Rows[0][11].ToString();
                        dtpOdKada.Text = pozicija.Rows[0][8].ToString();
                        dtpDoKada.Text = pozicija.Rows[0][9].ToString();
                        PopuniGrid();
                        panel1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopuniGrid()
        {
            try
            {
                pozicijaID = Convert.ToInt32(_pozicijaID);
                this.pozicijatrgovinaTableAdapter.Fill(this.dodatne_pozicije_trgovina.pozicijatrgovina, pozicijaID);
                this.pozicijaracunTableAdapter.Fill(this.dodatne_pozicije_racuni.pozicijaracun, pozicijaID);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (gridView4.RowCount > 0)
            {
                try
                {
                    DataTable trgovineZaPoziciju = new DataTable();

                    System.Data.DataRow row = gridView4.GetDataRow(gridView4.FocusedRowHandle);
                    if (row != null)
                    {
                        string IDPoslovnice = row[3].ToString();

                        veza.ExecuteQuery("select * from pozicijatrgovina where poslovnica_po_ID = '" + IDPoslovnice + "' and pozicija_poz_ID = '" + _pozicijaID + "'", ref trgovineZaPoziciju);

                        if (trgovineZaPoziciju.Rows.Count > 0)
                        {
                            MessageBox.Show("Poslovnica je već dodana na popis!");
                        }
                        else
                        {
                            veza.ExecuteQuery("insert into pozicijatrgovina (pozicija_poz_ID, poslovnica_po_ID) values ('" + _pozicijaID + "', '" + IDPoslovnice + "')");
                            pozicijatrgovinaTableAdapter.Fill(this.dodatne_pozicije_trgovina.pozicijatrgovina, pozicijaID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (gridView5.RowCount > 0)
            {
                try
                {
                    System.Data.DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
                    if (row != null)
                    {
                        string IDPoslovnice = row[2].ToString();

                        veza.ExecuteQuery("delete from pozicijatrgovina where poslovnica_po_ID = '" + IDPoslovnice + "' and pozicija_poz_ID = '" + _pozicijaID + "'");
                        pozicijatrgovinaTableAdapter.Fill(this.dodatne_pozicije_trgovina.pozicijatrgovina, pozicijaID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DodajPoslovniceTipa()
        {
            DataTable trgovineZaPoziciju = new DataTable();
            try
            {
                veza.ExecuteQuery("SELECT po_sifra, po_naziv, po_asortiman, po_id FROM poslovnica WHERE (po_datumZatvaranja IS NULL) AND (vp_sifra = '300' OR vp_sifra = '200') AND (po_asortiman IS NOT NULL) AND (po_asortiman <> '') and po_asortiman = '" + tipTrgovine + "' ORDER BY po_asortiman", ref trgovineZaPoziciju);

                if (trgovineZaPoziciju.Rows.Count > 0)
                {

                     for (brojac = 0; brojac < trgovineZaPoziciju.Rows.Count; brojac++)
                     {
                
                         poslovnicaID = trgovineZaPoziciju.Rows[brojac][3].ToString();

                         DataTable PoslovnicePoTipu = new DataTable();
                         veza.ExecuteQuery("select * from pozicijatrgovina where poslovnica_po_ID = '" + poslovnicaID + "' and pozicija_poz_ID = '" + _pozicijaID + "'", ref PoslovnicePoTipu);

                         if (PoslovnicePoTipu.Rows.Count > 0)
                         {
                             //MessageBox.Show("Poslovnica je već dodana na popis!");
                         }
                         else
                         {
                             veza.ExecuteQuery("insert into pozicijatrgovina (pozicija_poz_ID, poslovnica_po_ID) values ('" + _pozicijaID + "', '" + poslovnicaID + "')");

                             pozicijatrgovinaTableAdapter.Fill(this.dodatne_pozicije_trgovina.pozicijatrgovina, pozicijaID);
                         }
                     }
                }
                else
                {
                    MessageBox.Show("Trenutno nema poslovnice odabranog tipa u bazi!");
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbA.Checked)
            {
                tipTrgovine = "A";
                DodajPoslovniceTipa();
            }
        }

        private void ckbB_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbB.Checked)
            {
                tipTrgovine = "B";
                DodajPoslovniceTipa();
            }
        }

        private void ckbC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbC.Checked)
            {
                tipTrgovine = "C";
                DodajPoslovniceTipa();
            }
        }

        private void ckbD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbD.Checked)
            {
                tipTrgovine = "D";
                DodajPoslovniceTipa();
            }
        }

        private void ckbX_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbX.Checked)
            {
                tipTrgovine = "X";
                DodajPoslovniceTipa();
            }
        }

        private void txtDobavljac_TextChanged(object sender, EventArgs e)
        {
            DataTable paID = new DataTable();

            if (txtDobavljac.Text != "")
            {
                veza.ExecuteQuery("select pa_naziv from partner where pa_sifra = '" + txtDobavljac.Text + "'", ref paID);

                if (paID.Rows.Count > 0)
                {
                    lblDobavljac.Text = paID.Rows[0][0].ToString();
                }
                else
                {
                    lblDobavljac.Text = "___";
                    txtDobavljac.Text = "";
                }
            }
        }

        private void txtKomercijalist_TextChanged(object sender, EventArgs e)
        {
            DataTable koID = new DataTable();

            if (txtKomercijalist.Text != "")
            {
                veza.ExecuteQuery("select CONCAT(operater.op_ime,' ' ,operater.op_prezime) from operater where op_sifra = '" + txtKomercijalist.Text + "'", ref koID);

                if (koID.Rows.Count > 0)
                {
                    lblKomercijalist.Text = koID.Rows[0][0].ToString();
                }
                else
                {
                    lblKomercijalist.Text = "___";
                    txtKomercijalist.Text = "";
                }
            }
        }

        private void gridView6_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView6.FocusedColumn.Name != "IznosRacuna") return;
            if ((Convert.ToInt64(e.Value) < 0) || (Convert.ToInt64(e.Value) > 1000000))
                e.Valid = false;
        }

        private void gridView6_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
            e.WindowCaption = "Pogrešan unos!";
            e.ErrorText = "Unesena vrijednost mora biti između 0 i 1000000";
            gridView6.HideEditor();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //nakon uspješnog inserta oslobodim tab 2 i 3
            if (_pozicijaID == "0")
            {
                //insert
                if (txtDobavljac.Text != "" && txtKomercijalist.Text != "" && txtOpis1.Text != "" && txtOpis2.Text !="")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    komercijalist = dohvati.DohvatiIDSifra("op_ID", "operater", "op_sifra = '" + txtKomercijalist.Text + "'");
                    operater = Global.KorisnikID;
                    partnerID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + txtDobavljac.Text + "'");
                    opis1 = txtOpis1.Text.Trim();
                    opis2 = txtOpis2.Text.Trim();
                    vrstaPozicije = txtPozicija.SelectedValue.ToString();

                    odKada = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");

                    doKada = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                    //MessageBox.Show("insert into pozicija (operater_op_ID, operater_op_ID1, partner_pa_ID,vrstapozicije_pz_ID,poz_opis, poz_opis2, poz_odkada, poz_dokada) values (" + operater + ", " + komercijalist + "," + partnerID + ",  " + vrstaPozicije + ", '" + opis1 + "', '" + opis2 + "', '" + odKada + "', '" + doKada + "') ");
                    //veza.ExecuteQuery("insert into pozicija (operater_op_ID, operater_op_ID1, partner_pa_ID,vrstapozicije_pz_ID,poz_opis, poz_opis2, poz_odkada, poz_dokada) values ('" + operater + "', '" + komercijalist + "','" + partnerID + "',  " + vrstaPozicije + ", '" + opis1 + "', '" + opis2 + "', '" + odKada + "', '" + doKada + "') ");
                    dodajZapisUBazu();
                    frmDodatnePozicije.osvjezi.PerformClick();
                    MessageBox.Show("Uspješno ste dodali poziciju!");
                    Omoguci();
                    //this.Close();
                }
            }
            else
            {
                //update
                if (txtDobavljac.Text != "" && txtKomercijalist.Text != "" && txtOpis1.Text != "" && txtOpis2.Text != "")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    komercijalist = dohvati.DohvatiIDSifra("op_ID", "operater", "op_sifra = '" + txtKomercijalist.Text + "'");
                    partnerID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + txtDobavljac.Text + "'");
                    operater = Global.KorisnikID;
                    opis1 = txtOpis1.Text.Trim();
                    opis2 = txtOpis2.Text.Trim();
                    vrstaPozicije = txtPozicija.SelectedValue.ToString();

                    odKada = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");

                    doKada = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                    //MessageBox.Show("update pozicija set operater_op_ID = '" + operater + "', operater_op_ID1 = '" + komercijalist + "', partner_pa_ID = '" + partnerID + "',vrstapozicije_pz_ID = '" + vrstaPozicije + "',poz_opis = '" + opis1 + "', poz_opis2 = '" + opis2 + "', poz_odkada = '" + odKada + "', poz_dokada = '" + doKada + "' where poz_ID = " + _pozicijaID + "");
                    veza.ExecuteQuery("update pozicija set operater_op_ID = '" + operater + "', operater_op_ID1 = '" + komercijalist + "', partner_pa_ID = '" + partnerID + "',vrstapozicije_pz_ID = '" + vrstaPozicije + "',poz_opis = '" + opis1 + "', poz_opis2 = '" + opis2 + "', poz_odkada = '" + odKada + "', poz_dokada = '" + doKada + "' where poz_ID = " + _pozicijaID + "");
                    frmDodatnePozicije.osvjezi.PerformClick();
                    MessageBox.Show("Uspješno ste ažurirali poziciju!");
                    //this.Close();
                }
            }
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

        private void btnOdustaniOdRacuna_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (gridView6.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        System.Data.DataRow row = gridView6.GetDataRow(gridView6.FocusedRowHandle);
                        if (row != null)
                        {
                            ID_pozicijaRacun = row[0].ToString();
                            //MessageBox.Show("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                            veza.ExecuteQuery("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                            this.pozicijaracunTableAdapter.Fill(this.dodatne_pozicije_racuni.pozicijaracun, pozicijaID);
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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtIznosRacuna.Focus();
            txtIznosRacuna.Text = "";
            dtpDatumRacuna.Text = DateTime.Now.Date.ToString();
            oznaka = "D"; //d - za "dodaj"
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {

            oznaka = "A"; //a - za "azuriraj"
            if (gridView6.RowCount > 0)
            {
                System.Data.DataRow row = gridView6.GetDataRow(gridView6.FocusedRowHandle);
                if (row != null)
                {
                    ID_pozicijaRacun = row[0].ToString();
                    panel1.Visible = true;
                    txtIznosRacuna.Focus();
                    txtIznosRacuna.Text = row[3].ToString();
                    dtpDatumRacuna.Text = row[2].ToString();
                }
            }
            else
            {
                MessageBox.Show("Nemate zapis koji biste ažurirali!");
            }

        }

        private void btnSpremiRacun_Click(object sender, EventArgs e)
        {
            try
            {               
                if (oznaka == "D" && txtIznosRacuna.Text != "")
                {
                    Iznos = Convert.ToString(txtIznosRacuna.Text).Replace(',', '.');
                    datumRacuna = Convert.ToDateTime(dtpDatumRacuna.Text).ToString("yyyy-MM-dd");
                    //MessageBox.Show("Insert into pozicijaracun (pozicija_ID, pozr_datumracuna, pozr_iznosracuna, operater_op_ID) values (" + _pozicijaID + ", '" + datumRacuna + "','" + txtIznosRacuna.EditValue + "'," + Global.KorisnikID + ")");
                    veza.ExecuteQuery("Insert into pozicijaracun (pozicija_ID, pozr_datumracuna, pozr_iznosracuna, operater_op_ID) values (" + _pozicijaID + ", '" + datumRacuna + "','" + Iznos + "'," + Global.KorisnikID + ")");
                    this.pozicijaracunTableAdapter.Fill(this.dodatne_pozicije_racuni.pozicijaracun, pozicijaID);
                    panel1.Visible = false;
                }
                else if (oznaka == "A" && txtIznosRacuna.Text != "")
                {
                    Iznos = Convert.ToString(txtIznosRacuna.Text).Replace(',', '.');
                    datumRacuna = Convert.ToDateTime(dtpDatumRacuna.Text).ToString("yyyy-MM-dd");
                    veza.ExecuteQuery("update pozicijaracun set pozicija_ID = " + _pozicijaID + ", pozr_datumracuna = '" + datumRacuna + "', pozr_iznosracuna = '" + Iznos + "', operater_op_ID = " + Global.KorisnikID + " where pozr_ID = " + ID_pozicijaRacun + "");
                    this.pozicijaracunTableAdapter.Fill(this.dodatne_pozicije_racuni.pozicijaracun, pozicijaID);
                    panel1.Visible = false;
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

        private void Omoguci()
        {
            btnBrisi.Enabled = true;
            btnDodaj.Enabled = true;
            btnIzmijeni.Enabled = true;
            btnDesno.Enabled = true;
            btnLijevo.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void DohvatiZadnjiUneseni()
        {
            try
            {
                DataTable pozicija = new DataTable();
                veza.ExecuteQuery("Select * from pozicija order by poz_ID desc",ref pozicija);
                if (pozicija.Rows.Count > 0)
                {
                    _pozicijaID = pozicija.Rows[0][0].ToString();
                    pozicijaID = Convert.ToInt32(_pozicijaID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView6.RowCount > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Data.DataRow row = gridView6.GetDataRow(gridView6.FocusedRowHandle);
                            if (row != null)
                            {
                                ID_pozicijaRacun = row[0].ToString();
                                //MessageBox.Show("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                                veza.ExecuteQuery("delete from pozicijaracun where pozr_ID = " + ID_pozicijaRacun + "");
                                this.pozicijaracunTableAdapter.Fill(this.dodatne_pozicije_racuni.pozicijaracun, pozicijaID);
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
            }
        }

        private void txtKomercijalist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmOperater _frm = new frmOperater();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtKomercijalist.Text = _frm.sifra_operater;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void txtDobavljac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmPartneri _frm = new frmPartneri();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtDobavljac.Text = _frm.sifra_partner;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void dodajZapisUBazu()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
            MySqlCommand comm = new MySqlCommand("fOdrediIDDodanePozicije", conn);
            comm.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("operater", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = operater;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("komercijalist", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = komercijalist;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("partnerID", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = partnerID;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("vrstaPozicije", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = vrstaPozicije;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("opis1", MySqlDbType.String);
            prm.Direction = ParameterDirection.Input;
            prm.Value = opis1;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("opis2", MySqlDbType.Text);
            prm.Direction = ParameterDirection.Input;
            prm.Value = opis2;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("odKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = odKada;
            comm.Parameters.Add(prm);
            
            prm = new MySqlParameter("doKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = doKada;
            comm.Parameters.Add(prm);

            MySqlParameter retval = comm.Parameters.Add("@pozicijaID", MySqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            _pozicijaID = (string)comm.Parameters["@pozicijaID"].Value;
            pozicijaID = Convert.ToInt32(_pozicijaID); 
        }

        private void frmAzuriranjeProdajeDodatnihPozicija_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
