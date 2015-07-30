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
    public partial class frmDiktiranaCijenaArtikalaZaTrgovine : Form
    {
        string oznaka;
        string artiklJeVecDodan;
        string artiklID;
        int dozvoljenaID;
        Upiti veza = new Upiti();
        string _dozvoljenaID;
        string opis;
        string odkada;
        string dokada;

        string PrepCijena;

        int aktivan;

        string poID;

        string dozvoljenanivelacijaartiklID;

        public frmDiktiranaCijenaArtikalaZaTrgovine()
        {
            InitializeComponent();
        }

        public string dozvoljenaNivelacija
        {
            get { return _dozvoljenaID; }
            set { _dozvoljenaID = value; }
        }

        private void frmDiktiranaCijenaArtikalaZaTrgovine_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (_dozvoljenaID == "0") //novi
                {
                    this.poslovnicaTableAdapter.Fill(this.poslovnica.poslovnica);
                    panel3.Visible = false;
                    panel1.Enabled = false;
                    panel8.Visible = false;
                    btnAzuriraj.Enabled = false;
                    btnDodaj.Enabled = false;
                    btnBrisi.Enabled = false;
                    panel6.Enabled = false;
                    panel9.Enabled = false;
                    panel7.Enabled = false;
                }
                else //update
                {
                    this.poslovnicaTableAdapter.FillBy(this.poslovnica.poslovnica, Convert.ToInt32(_dozvoljenaID));
                    panel8.Visible = false;
                    dtpOdKada.Format = DateTimePickerFormat.Short;
                    dtpDoKada.Format = DateTimePickerFormat.Short;

                  //popuni sve podatke
                    //zaglavlje
                    DataTable zaglavlje = new DataTable();
                    veza.ExecuteQuery("select dnz_ID,dnz_odkada, dnz_dokada, dnz_opis from dozvoljenanivelacijazag where dnz_ID = "+_dozvoljenaID+"", ref zaglavlje);

                    txtBroj.Text = _dozvoljenaID;
                    txtOpisCjenika.Text = zaglavlje.Rows[0][3].ToString();
                    dtpOdKada.Text = zaglavlje.Rows[0][1].ToString();
                    dtpDoKada.Text = zaglavlje.Rows[0][2].ToString();

                    //već odabrane artikle za to zaglavlje
                    diktiranacijenaArtikliTableAdapter.Fill(this.diktiranaCijenaArtikli.diktiranacijenaArtikli, Convert.ToInt32(_dozvoljenaID));


                    //osvježi popis odabranih poslovnica
                    this.odabranePoslovniceTableAdapter.Fill(this.poslovnica.OdabranePoslovnice, Convert.ToInt32(_dozvoljenaID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustaniZag_Click(object sender, EventArgs e)
        {
            try
            {
                //provjeri ako je dodano zaglavlje a nema artikl barem jedan ne daj zatvoriti

                //if (_dozvoljenaID != "0") //zaglavlje je spremljeno mora biti barem jedan artikl dodan
                //{
                //    if (dgArtikliOdabrani.RowCount == 0)
                //    {
                //        //nema artikl ne daj zatvoriti
                //        MessageBox.Show("Morate dodati barem jedan artikl!");
                //        panel8.Visible = true; ;
                //        txtArtiklSifra.Focus();
                //    }
                //    else
                //    {
                //        this.Close();
                //    }
                //}

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpremiZaglavlje_Click(object sender, EventArgs e)
        {
            try
            {
                opis = txtOpisCjenika.Text;

                odkada = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");

                dokada = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");

                if (_dozvoljenaID == "0") //novi
                {
                    if (dtpDoKada.Text != "" && dtpOdKada.Text != "")
                    {
                        dodajZapisUBazu();
                        panel1.Enabled = true;
                        panel8.Visible = true;
                        panel6.Enabled = true;
                        panel9.Enabled = true;
                        btnAzuriraj.Enabled = true;
                        btnDodaj.Enabled = true;
                        btnBrisi.Enabled = true;
                        panel7.Enabled = true;
                        oznaka = "D";
                        txtArtiklSifra.Focus();
                        FrmPregledArtikalaNivelacija.azuriraj.PerformClick();
                    }

                }
                else //update
                {
                    if (dtpDoKada.Text != "" && dtpOdKada.Text != "")
                    {
                        veza.ExecuteQuery("update dozvoljenanivelacijazag set operater_op_ID = " + Global.KorisnikID + ", dnz_odkada = '" + odkada + "', dnz_dokada='" + dokada + "', dnz_opis= '" + opis + "' where dnz_ID = " + _dozvoljenaID + "");
                        FrmPregledArtikalaNivelacija.azuriraj.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dodajZapisUBazu()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
            MySqlCommand comm = new MySqlCommand("fOdrediIDDozvoljeneNivelacije", conn);
            comm.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("operater", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Convert.ToInt32(Global.KorisnikID);
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("opis", MySqlDbType.String);
            prm.Direction = ParameterDirection.Input;
            prm.Value = opis;
            comm.Parameters.Add(prm);


            prm = new MySqlParameter("odKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = odkada;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("doKada", MySqlDbType.Date);
            prm.Direction = ParameterDirection.Input;
            prm.Value = dokada;
            comm.Parameters.Add(prm);

            MySqlParameter retval = comm.Parameters.Add("@nivelacijalID", MySqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            _dozvoljenaID = (string)comm.Parameters["@nivelacijalID"].Value;
            dozvoljenaID = Convert.ToInt32(_dozvoljenaID);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            txtArtiklSifra.Enabled = true;
            panel8.Visible = true;
            txtArtiklSifra.Focus();
            txtPreporucenaCijena.Text = "";
            txtArtiklSifra.Text = "";
            lblNazivArtikla.Text = "___";
            oznaka = "D"; //d - za "dodaj"
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgArtikliOdabrani.RowCount > 0)
            {
                panel3.Visible = true;
                oznaka = "A"; //a - za "azuriraj"
                txtArtiklSifra.Enabled = false;

                System.Data.DataRow row = dgArtikliOdabrani.GetDataRow(dgArtikliOdabrani.FocusedRowHandle);
                if (row != null)
                {
                    //IDstavkaDozvoljenaNivelacija = row[1].ToString();
                    panel8.Visible = true;
                    txtArtiklSifra.Focus();
                    txtArtiklSifra.Text = row[3].ToString();
                    txtPreporucenaCijena.Text = row[5].ToString();
                    artiklID = row[2].ToString();

                    string aktivan = row[6].ToString();
                    
                    if (aktivan == "True")
                    {
                        ckbAktivna.Checked = true;
                    }
                    else
                    {
                        ckbAktivna.Checked = false;
                    }
                }

                txtPreporucenaCijena.Focus();
            }
            else
            {
                MessageBox.Show("Nemate zapis koji biste ažurirali!");
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgArtikliOdabrani.RowCount > 0)
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabrani artikl?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Data.DataRow row = dgArtikliOdabrani.GetDataRow(dgArtikliOdabrani.FocusedRowHandle);

                            if (row != null)
                            {
                                dozvoljenanivelacijaartiklID = row[0].ToString();
                                artiklID = row[2].ToString();

                                //obriši artikl s popisa za to zaglavlje
                                veza.ExecuteQuery("delete from dozvoljenanivelacijaartikl where dna_ID = " + dozvoljenanivelacijaartiklID + "");

                                //provjeri ima li u nekoj od poslovnica taj artikl, a ko ima i njega obriši
                                DataTable provjera = new DataTable();

                                veza.ExecuteQuery("select dn_id from dozvoljenanivelacija where artikl_ar_ID = " + artiklID + " and dozvoljenanivelacijazag_dnz_ID ="+_dozvoljenaID+"", ref provjera);
                                if (provjera.Rows.Count > 0)
                                {
                                    //taj artikl postoji vezan na poslovnici i treba ga obrisati

                                    for(int i = 0; i < provjera.Rows.Count; i++)
                                    {
                                        string IDDozNivel = provjera.Rows[i][0].ToString();
                                        veza.ExecuteQuery("delete from dozvoljenanivelacija where dn_ID = " + IDDozNivel + " ");
                                    }
                                }

                                diktiranacijenaArtikliTableAdapter.Fill(this.diktiranaCijenaArtikli.diktiranacijenaArtikli, Convert.ToInt32(_dozvoljenaID));
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

        public void ProvjeriPostojiLiVecDodanTajArtikl()
        {
            try
            {
                DataTable artikli = new DataTable();
                veza.ExecuteQuery("select * from dozvoljenanivelacijaartikl where dozvoljenanivelacijaZag_ID = " + _dozvoljenaID + "  and artikl_ar_ID = " + artiklID + " ", ref artikli);
                if (artikli.Rows.Count > 0)
                {
                    artiklJeVecDodan = "1";
                    //IDstavkaDozvoljenaNivelacija = artikli.Rows[0][1].ToString();
                }
                else
                {
                    artiklJeVecDodan = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtArtiklSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
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

        private void frmDiktiranaCijenaArtikalaZaTrgovine_KeyDown(object sender, KeyEventArgs e)
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            txtArtiklSifra.Enabled = true;
            txtArtiklSifra.Text = "";
            txtPreporucenaCijena.Text = "0";
        }

        private void dtpOdKada_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpOdKada.Text != "")
            //{
            //    SendKeys.Send("{RIGHT}");
            //}
        }

        private void dtpOdKada_Enter(object sender, EventArgs e)
        {
            dtpOdKada.Format = DateTimePickerFormat.Short;
            if (dtpOdKada.Text == " ")
            {
                dtpOdKada.Value = DateTime.Now;
            }
        }

        private void dtpDoKada_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpDoKada.Text != "")
            //{
            //    SendKeys.Send("{RIGHT}");
            //}            
        }

        private void dtpDoKada_Enter(object sender, EventArgs e)
        {
            dtpDoKada.Format = DateTimePickerFormat.Short;
            if (dtpDoKada.Text == " ")
            {
                dtpDoKada.Value = DateTime.Now;
            }
        }

        private void btnSpremiArtikl_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeriPostojiLiVecDodanTajArtikl();

                //provjeri da li je ažuriranje ili novo spremanje

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

                        //update artikl
                        veza.ExecuteQuery("update dozvoljenanivelacijaartikl set  dna_aktivna="+aktivan+" ,dna_preporucenacijena= "+PrepCijena+" , operater_op_ID ="+Global.KorisnikID+" where dozvoljenanivelacijazag_ID ="+_dozvoljenaID+" and artikl_ar_ID = "+artiklID+"");

                        //update sve artikle za poslovnice
                        veza.ExecuteQuery("update dozvoljenanivelacija set  dn_aktivna=" + aktivan + " ,dn_preporucenacijena= " + PrepCijena + " , operater_op_ID =" + Global.KorisnikID + " where dozvoljenanivelacijazag_dnz_ID =" + _dozvoljenaID + " and artikl_ar_ID = " + artiklID + " ");

                        diktiranacijenaArtikliTableAdapter.Fill(this.diktiranaCijenaArtikli.diktiranacijenaArtikli, Convert.ToInt32(_dozvoljenaID));
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


                        veza.ExecuteQuery("insert into dozvoljenanivelacijaartikl (dozvoljenanivelacijazag_ID, artikl_ar_ID, dna_aktivna, dna_preporucenacijena, operater_op_ID) values (" + _dozvoljenaID + ", " + artiklID + ", " + aktivan + ","+PrepCijena+", " + Global.KorisnikID + ")");

                        //dodaj za sve poslovnice s popisa

                        DataTable poslovnice = new DataTable();

                        veza.ExecuteQuery("select poslovnica_po_ID from dozvoljenanivelacijaposlovnica where dozvoljenanivelacijazag_ID = " + _dozvoljenaID + "", ref poslovnice);
                        if (poslovnice.Rows.Count > 0)
                        {
                            //taj artikl postoji vezan na poslovnici i treba ga obrisati

                            for (int i = 0; i < poslovnice.Rows.Count; i++)
                            {
                                string IDposlovnice = poslovnice.Rows[i][0].ToString();
                                veza.ExecuteQuery("insert into dozvoljenanivelacija (dozvoljenanivelacijazag_dnz_ID, artikl_ar_ID,dn_aktivna,dn_preporucenacijena, operater_op_ID, poslovnica_po_ID) values (" + _dozvoljenaID + ", " + artiklID + ", " + aktivan + ", " + PrepCijena + ","+Global.KorisnikID+" ," + IDposlovnice + ")");
                            }
                        }
     
                        
                        diktiranacijenaArtikliTableAdapter.Fill(this.diktiranaCijenaArtikli.diktiranacijenaArtikli, Convert.ToInt32(_dozvoljenaID));
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

                    //update artikl
                    veza.ExecuteQuery("update dozvoljenanivelacijaartikl set  dna_aktivna=" + aktivan + " ,dna_preporucenacijena= " + PrepCijena + " , operater_op_ID =" + Global.KorisnikID + " where dozvoljenanivelacijazag_ID =" + _dozvoljenaID + " and artikl_ar_ID = " + artiklID + "");

                    //update sve artikle za poslovnice
                    veza.ExecuteQuery("update dozvoljenanivelacija set  dn_aktivna=" + aktivan + " ,dn_preporucenacijena= " + PrepCijena + " , operater_op_ID =" + Global.KorisnikID + " where dozvoljenanivelacijazag_dnz_ID =" + _dozvoljenaID + " and artikl_ar_ID = " + artiklID + " ");

                    diktiranacijenaArtikliTableAdapter.Fill(this.diktiranaCijenaArtikli.diktiranacijenaArtikli, Convert.ToInt32(_dozvoljenaID));
                }


                panel8.Visible = false;
                txtArtiklSifra.Text = "";
                lblNazivArtikla.Text = "";
                txtPreporucenaCijena.Text = "0";
                FrmPregledArtikalaNivelacija.azuriraj.PerformClick();
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
                btnDesno.Enabled = false;
                if (dgPoslovniceSve.RowCount > 0)
                {
                    //provjeri da li odabrana poslovnica ima desno ako ima ništa ne radi, ako ne prebaci je 

                    System.Data.DataRow row = dgPoslovniceSve.GetDataRow(dgPoslovniceSve.FocusedRowHandle);
                      if (row != null)
                      {
                          poID = row[2].ToString();
                      }


                    DataTable provjera = new DataTable();
                    veza.ExecuteQuery("select poslovnica_po_ID from dozvoljenanivelacijaposlovnica where dozvoljenanivelacijazag_ID = "+_dozvoljenaID+" and poslovnica_po_ID = "+poID+"", ref provjera);

                    if (provjera.Rows.Count > 0)
                    {
                        //ta poslovnica postoji, ništa ne radi
                        MessageBox.Show("Poslovnica postoji na popisu odabranih!");
                    }
                    else
                    {
                        //umetni poslovnicu  u dozvoljenanivelacijaposlovnica za trenutno zaglavlje
                        veza.ExecuteQuery("insert into dozvoljenanivelacijaposlovnica (dozvoljenanivelacijazag_ID, poslovnica_po_ID) values ("+_dozvoljenaID+", "+poID+" )");

                        //osvježi popis odabranih
                        this.odabranePoslovniceTableAdapter.Fill(this.poslovnica.OdabranePoslovnice, Convert.ToInt32(_dozvoljenaID));

                        //osvježi popis preostalih
                        this.poslovnicaTableAdapter.FillBy(this.poslovnica.poslovnica, Convert.ToInt32(_dozvoljenaID));

                        //provjeri broj artikla u dozvoljenanivelacijaartikl te za svaki u tom zaglavlju dodaj vezu u dozvoljenanivelacija
                        DataTable artikli = new DataTable();

                        veza.ExecuteQuery("select artikl_ar_ID, dna_aktivna, dna_preporucenacijena from dozvoljenanivelacijaartikl where dozvoljenanivelacijazag_ID = "+_dozvoljenaID+"", ref artikli);

                        if (artikli.Rows.Count > 0)
                        {
                            //dodaj vezu u dozvoljenanivelacija

                            for (int i = 0; i < artikli.Rows.Count; i++)
                            {
                                artiklID = artikli.Rows[i][0].ToString();
                                string a = artikli.Rows[i][1].ToString();
                                if (artikli.Rows[i][1].ToString() == "True")
                                {
                                    aktivan = 1;
                                }
                                else
                                {
                                    aktivan = 0;
                                }

                                PrepCijena = Convert.ToString(artikli.Rows[i][2]).Replace(',', '.');

                                veza.ExecuteQuery("insert into dozvoljenanivelacija (dozvoljenanivelacijazag_dnz_ID, artikl_ar_ID,dn_aktivna,dn_preporucenacijena, operater_op_ID, poslovnica_po_ID) values (" + _dozvoljenaID + ", " + artiklID + ", " + aktivan + ", " + PrepCijena + "," + Global.KorisnikID + " ," + poID + ")");
                            }
                        }

                    }
                }
                btnDesno.Enabled = true;
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
                btnLijevo.Enabled = false;
                if (dgPoslovniceOdabraneDizajn.RowCount > 0) 
                {
                    System.Data.DataRow row = dgPoslovniceOdabraneDizajn.GetDataRow(dgPoslovniceOdabraneDizajn.FocusedRowHandle);
                      if (row != null)
                      {
                          poID = row[0].ToString();
                      }

                    //ukloni poslovnicu iz dozvoljenanivelacijaposlovnica

                      veza.ExecuteQuery("delete from dozvoljenanivelacijaposlovnica where dozvoljenanivelacijazag_ID = " + _dozvoljenaID + " and poslovnica_po_ID = " + poID + "");

                      //osvježi popis odabranih
                      this.odabranePoslovniceTableAdapter.Fill(this.poslovnica.OdabranePoslovnice, Convert.ToInt32(_dozvoljenaID));
                    //osvježi popis preostalih
                      this.poslovnicaTableAdapter.FillBy(this.poslovnica.poslovnica, Convert.ToInt32(_dozvoljenaID));

                    //pobrisi artikle iz dozvoljenenivelacija za tu poslovnicu i to zaglavlje

                      veza.ExecuteQuery("Delete from dozvoljenanivelacija where dozvoljenanivelacijazag_dnz_ID = "+_dozvoljenaID+" and poslovnica_po_ID = "+poID+"");
                }

                btnLijevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDiktiranaCijenaArtikalaZaTrgovine_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    //provjeri ako je dodano zaglavlje a nema artikl barem jedan ne daj zatvoriti

            //    if (_dozvoljenaID != "0") //zaglavlje je spremljeno mora biti barem jedan artikl dodan
            //    {
            //        if (dgArtikliOdabrani.RowCount == 0)
            //        {
            //            //nema artikl ne daj zatvoriti
            //            MessageBox.Show("Morate dodati barem jedan artikl!");
            //            e.Cancel = true;
            //            panel8.Visible = true; ;
            //            txtArtiklSifra.Focus();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
