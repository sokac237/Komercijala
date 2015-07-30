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
    public partial class frmAzurirajProdajniAkcijskiCjenik : Form
    {
        Upiti veza = new Upiti();

        DataTable prodajnicjenik = new DataTable();

        string _Artikl;

        string _nivo;

        int aktivan;

        string nivo;

        string partnerID;

        public frmAzurirajProdajniAkcijskiCjenik()
        {
            InitializeComponent();
        }

        private void frmAzurirajProdajniAkcijskiCjenik_Load(object sender, EventArgs e)
        {
            try
            {
                if (artikl == "0")
                {
                    if (_nivo == "2")
                    {
                        ckbNivo.Text = "2";
                    }
                    else
                    {
                        ckbNivo.Text = "3";
                    }

                    ckbAktivna.Text = "Da";

                    txtBroj.Visible = false;
                    label1.Visible = false;

                    txtIzmjenaDatum.Visible = false;
                    label11.Visible = false;
                    return;
                }
                else 
                {
                    veza.ExecuteQuery("Select prodajnicjenik.*,CONCAT(operater.op_ime,' ' ,operater.op_prezime)  from prodajnicjenik left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where prc_ID = " + _Artikl + "", ref prodajnicjenik);

                    if (prodajnicjenik.Rows.Count > 0)
                    {
                        txtBroj.Text = prodajnicjenik.Rows[0][0].ToString();
                        txtNaziv.Text = prodajnicjenik.Rows[0][4].ToString();
                        partnerID = prodajnicjenik.Rows[0][3].ToString();

                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        txtPartnerSifra.Text = dohvati.DohvatiIDSifra("pa_sifra", "partner", " pa_ID = '" + partnerID + "'");
                        dtpDoKada.Text = prodajnicjenik.Rows[0][2].ToString();
                        dtpOdKada.Text = prodajnicjenik.Rows[0][1].ToString();

                        txtIzmjenaDatum.Text = prodajnicjenik.Rows[0][9].ToString() + "  " + prodajnicjenik.Rows[0][7].ToString();

                        //string a = prodajnicjenik.Rows[0][6].ToString();
                        if (prodajnicjenik.Rows[0][6].ToString() == "True")
                        {
                            ckbAktivna.Text = "Da";
                        }
                        else
                        {
                            ckbAktivna.Text = "Ne";
                        }

                        if (prodajnicjenik.Rows[0][5].ToString() == "1")
                        {
                            ckbNivo.Text = "1";
                        }
                        else if (prodajnicjenik.Rows[0][5].ToString() == "2")
                        {
                            ckbNivo.Text = "2";
                        }
                        else
                        {
                            ckbNivo.Text = "3";
                        }
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string artikl
        {
            get { return _Artikl; }
            set { _Artikl = value; }
        }


        public string Niov
        {
            get { return _nivo; }
            set { _nivo = value; }
        }

        private void txtPartnerSifra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmPartneri _frm = new frmPartneri();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                       txtPartnerSifra.Text = _frm.sifra_partner;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtPartnerSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable paID = new DataTable();

            if (txtPartnerSifra.Text != "")
            {
                veza.ExecuteQuery("select pa_naziv from partner where pa_sifra = '" + txtPartnerSifra.Text + "'", ref paID);

                if (paID.Rows.Count > 0)
                {
                    lblPartnerNaziv.Text = paID.Rows[0][0].ToString();
                }
                else
                {
                    lblPartnerNaziv.Text = "___";
                    txtPartnerSifra.Text = "";
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (artikl == "0")
            {
                if (txtNaziv.Text != "" && ckbAktivna.Text != "" && ckbNivo.Text != "")
                {
                    try
                    {
                        string datumOD = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                        string datumDO = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                        if (txtPartnerSifra.Text != "")
                        {
                            DohvatiSifruID dohvati = new DohvatiSifruID();
                            partnerID = dohvati.DohvatiIDSifra("pa_ID", "partner", " pa_sifra = '" + txtPartnerSifra.Text + "'");
                        }
                        else
                        {
                            partnerID = "default";
                        }
                        string opis = txtNaziv.Text;

                        if (ckbNivo.Text != "")
                        {
                            nivo = ckbNivo.Text;
                        }

                        if (ckbAktivna.Text == "Da")
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }

                        string operater = Global.KorisnikID;

                        //MessageBox.Show("insert into prodajnicjenik (prc_vaziod, prc_vazido, partner_pa_ID, prc_opis, prc_nivo, prc_aktivan, operater_op_ID) values ('" + datumOD + "', '" + datumDO + "', " + partnerID + ", '" + opis + "', '" + nivo + "', '" + aktivan + "', '" + operater + "')");
                        veza.ExecuteQuery("insert into prodajnicjenik (prc_vaziod, prc_vazido, partner_pa_ID, prc_opis, prc_nivo, prc_aktivan, operater_op_ID) values ('" + datumOD + "', '" + datumDO + "', " + partnerID + ", '" + opis + "', '" + nivo + "', '" + aktivan + "', '" + operater + "')");
                        MessageBox.Show("Uspješno ste dodali cjenik!");

                        this.Close();

                        frmAkcijskiCjenikProdaja.azuriraj.PerformClick();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                    
                }
                else
                {
                    MessageBox.Show("Morate popuniti polja Naziv,Nivo, Aktivan!");
                }
            }
            else
            {
                if (txtNaziv.Text != "" && ckbAktivna.Text != "" && ckbNivo.Text != "")
                {
                    try
                    {
                        string datumOD = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                        string datumDO = Convert.ToDateTime(dtpDoKada.Text).ToString("yyyy-MM-dd");
                        if (txtPartnerSifra.Text != "")
                        {
                            DohvatiSifruID dohvati = new DohvatiSifruID();
                            partnerID = dohvati.DohvatiIDSifra("pa_ID", "partner", " pa_sifra = '" + txtPartnerSifra.Text + "'");
                        }
                        else
                        {
                            partnerID = "default";
                        }
                        string opis = txtNaziv.Text;

                        if (ckbNivo.Text != "")
                        {
                            nivo = ckbNivo.Text;
                        }

                        if (ckbAktivna.Text == "Da")
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }
                        if (lblPoruka.Text != "")
                        {
                            promjeniAktivnostStavki();
                        }
                        
                        //MessageBox.Show("update prodajnicjenik set prc_vaziod = '" + datumOD + "' , prc_vazido = '" + datumDO + "', partner_pa_ID = " + partnerID + ", prc_opis = '" + opis + "', prc_nivo = '" + nivo + "', prc_aktivan = '" + aktivan + "' where prc_ID = " + _Artikl + "");
                        veza.ExecuteQuery("update prodajnicjenik set prc_vaziod = '" + datumOD + "' , prc_vazido = '" + datumDO + "', partner_pa_ID = " + partnerID + ", prc_opis = '" + opis + "', prc_nivo = '" + nivo + "', prc_aktivan = '" + aktivan + "' where prc_ID = " + _Artikl + "");
                        MessageBox.Show("Uspješno ste ažurirali cjenik!");
                       
                        this.Close();

                        frmAkcijskiCjenikProdaja.azuriraj.PerformClick();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti polja Naziv,Nivo, Aktivan!");
                }          
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPartnerSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmAzurirajProdajniAkcijskiCjenik_KeyDown(object sender, KeyEventArgs e)
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

        private void frmAzurirajProdajniAkcijskiCjenik_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDoKada_Leave(object sender, EventArgs e)
        {
            //dat dokada ne smije biti manji od odkada
            DialogResult result;
            if (dtpDoKada.Value < dtpOdKada.Value)
            {
                result = MessageBox.Show("Datum dokada nesmije biti manji od datuma odkada!!", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    dtpDoKada.Focus();
                }
            }
        }

        private void ckbAktivna_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ažuriranje artikla

                if (prodajnicjenik.Rows.Count > 0)
                {
                    if (prodajnicjenik.Rows[0][6].ToString() == "True")
                    {
                        if (artikl != "0")
                        {
                            if (ckbAktivna.Text == "Ne")
                            {
                                lblPoruka.Text = "Ukoliko promjenite aktivnost zaglavlja to će se primjeniti \r\nna sve njegove stavke stavke prilikom spremanja.";
                            }
                            else 
                            {
                                lblPoruka.Text = "";
                            }
                        }
                    }
                    else
                    {
                        if (artikl != "0")
                        {
                            if (ckbAktivna.Text == "Da")
                            {
                                lblPoruka.Text = "Ukoliko promjenite aktivnost zaglavlja to će se primjeniti \r\nna sve njegove stavke stavke prilikom spremanja.";
                            }
                            else
                            {
                                lblPoruka.Text = "";
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

        private void promjeniAktivnostStavki()
        {
            try
            {
                   if (ckbAktivna.Text == "Da")
                   {
                       aktivan = 1;
                   }
                   else
                   {
                       aktivan = 0;
                   }


                if (prodajnicjenik.Rows.Count > 0)
                {
                    if (prodajnicjenik.Rows[0][6].ToString() == "True")
                    {
                        if (artikl != "0")
                        {
                            if (ckbAktivna.Text == "Ne")
                            {
                                // ažuriraj sve stavke akcije sa "Da" (1)
                                veza.ExecuteQuery("update prodajnistavka set prc_aktivna = " + aktivan + " where prodajnicjenik_prc_ID = " + _Artikl + "");
                            }
                        }
                    }
                    else
                    {
                        if (artikl != "0")
                        {
                            if (ckbAktivna.Text == "Da")
                            {
                                //ažuriraj sve stavke akcije sa "Ne" (0)
                                veza.ExecuteQuery("update prodajnistavka set prc_aktivna = "+aktivan+" where prodajnicjenik_prc_ID = "+_Artikl+"");
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
