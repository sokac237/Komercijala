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
    public partial class frmAzurirajAkcijskiNabavniCjenik : Form
    {
        string ID_partnera;
        string sifra_partnera;

        Upiti veza = new Upiti();

        DataTable AkcijskinabavniCjenik = new DataTable();

        string _cjenik;

        string opis;

        string vaziod;

        string vazido;

        int aktivan;

        string parterID;

        string nivo;

        public frmAzurirajAkcijskiNabavniCjenik()
        {
            InitializeComponent();
        }

        public string IDCjenika
        {
            get { return _cjenik; }
            set { _cjenik = value; }
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
                        ID_partnera =  _frm.id_partner;
                        txtPartnerSifra.Text = _frm.sifra_partner;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtPartnerSifra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAzurirajAkcijskiNabavniCjenik_Load(object sender, EventArgs e)
        {
            try
            {
                if (_cjenik == "0")
                {
                    panel1.Visible = false;
                    return;
                }
                else
                {
                    veza.ExecuteQuery("select * from nabavnicjenik where nac_ID = '" + _cjenik + "'", ref AkcijskinabavniCjenik);

                    if (AkcijskinabavniCjenik.Rows.Count > 0)
                    {
                        txtBroj.Text = AkcijskinabavniCjenik.Rows[0][0].ToString();
                        txtOpis.Text = AkcijskinabavniCjenik.Rows[0][1].ToString();
                        ID_partnera = AkcijskinabavniCjenik.Rows[0][6].ToString();

                        dohvatiIDPartnera();

                        txtPartnerSifra.Text = sifra_partnera;

                        if (AkcijskinabavniCjenik.Rows[0][4].ToString() == "True")
                        {
                            ckbAktivan.Checked = true;
                        }
                        else
                        {
                            ckbAktivan.Checked = false;
                        }

                        dtpOdKada.Text = AkcijskinabavniCjenik.Rows[0][2].ToString();
                        dtpDokada.Text = AkcijskinabavniCjenik.Rows[0][3].ToString();

                        //provjeri da li je novi 8 ili 9 ovisno o tome označi diskonti / trgovine

                        if (AkcijskinabavniCjenik.Rows[0][5].ToString() == "8")
                        {
                            ckbDiskont.Checked = true;
                        }
                        else if (AkcijskinabavniCjenik.Rows[0][5].ToString() == "9")
                        {
                            ckbTrgovina.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void frmAzurirajAkcijskiNabavniCjenik_KeyDown(object sender, KeyEventArgs e)
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
                if (_cjenik == "0")
                {
                    //insert
                    if (txtOpis.Text != "" && txtPartnerSifra.Text != "" && lblPartnerNaziv.Text != "___")
                    {
                        opis = txtOpis.Text;
                        vaziod = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                        vazido = Convert.ToDateTime(dtpDokada.Text).ToString("yyyy-MM-dd");
                        if (ckbAktivan.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }

                        if (ckbDiskont.Checked)
                        {
                            nivo = "8";
                        }
                        else if (ckbTrgovina.Checked)
                        {
                            nivo = "9";
                        }
                        else
                        {
                            nivo = "default";
                        }


                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        parterID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + txtPartnerSifra.Text.Trim() + "'");
                        //MessageBox.Show("insert into nabavnicjenik (nac_opis, nac_vaziod, nac_vazido , nac_aktivan, partneri_pa_ID, nac_nivo) values ('" + opis + "', '" + vaziod + "','" + vazido + "',  " + aktivan + ", " + parterID + ", '"+nivo+"') ");
                        veza.ExecuteQuery("insert into nabavnicjenik (nac_opis, nac_vaziod, nac_vazido , nac_aktivan, partneri_pa_ID, nac_nivo) values ('" + opis + "', '" + vaziod + "','" + vazido + "',  " + aktivan + ", " + parterID + ", "+nivo+") ");
                        MessageBox.Show("Uspješno ste dodali cjenik!");
                        frmAkcijskiNabavniCjenik.azurirajcjenik.PerformClick();
                        this.Close();
                    }

                }
                else
                {
                    //update
                    if (txtOpis.Text != "" && txtPartnerSifra.Text != "" && lblPartnerNaziv.Text != "___")
                    {
                        opis = txtOpis.Text;
                        vaziod = Convert.ToDateTime(dtpOdKada.Text).ToString("yyyy-MM-dd");
                        vazido = Convert.ToDateTime(dtpDokada.Text).ToString("yyyy-MM-dd");
                        if (ckbAktivan.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }

                        if (ckbDiskont.Checked)
                        {
                            nivo = "8";
                        }
                        else if (ckbTrgovina.Checked)
                        {
                            nivo = "9";
                        }
                        else
                        {
                            nivo = "default";
                        }

                        //dohvatiIDPartnera();
                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        parterID = dohvati.DohvatiIDSifra("pa_ID", "partner", "pa_sifra = '" + txtPartnerSifra.Text.Trim() + "'");
                        //MessageBox.Show("update nabavnicjenik set nac_opis = '" + opis + "', nac_vaziod = '" + vaziod + "', nac_vazido ='" + vazido + "', nac_aktivan = " + aktivan + ", partneri_pa_ID= " + parterID + ", nac_nivo = " + nivo + "  where nac_ID = '" + _cjenik + "'");
                        veza.ExecuteQuery("update nabavnicjenik set nac_opis = '" + opis + "', nac_vaziod = '" + vaziod + "', nac_vazido ='" + vazido + "', nac_aktivan = " + aktivan + ", partneri_pa_ID= " + parterID + ", nac_nivo = "+nivo+"  where nac_ID = '" + _cjenik + "'");
                        MessageBox.Show("Uspješno ste ažurirali cjenik!");
                        frmAkcijskiNabavniCjenik.azurirajcjenik.PerformClick();
                        this.Close();
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAzurirajAkcijskiNabavniCjenik_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatiIDPartnera()
        {
            try
            {
                DataTable IDpartnera = new DataTable();

                veza.ExecuteQuery("select pa_ID, pa_sifra from partner where pa_ID = " + ID_partnera + "", ref IDpartnera );

                if (IDpartnera.Rows.Count > 0)
                {
                    parterID = IDpartnera.Rows[0][0].ToString();
                    sifra_partnera = IDpartnera.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDokada_Leave(object sender, EventArgs e)
        {
            DialogResult result;
            if (dtpDokada.Value < dtpOdKada.Value)
            {
                result = MessageBox.Show("Datum dokada nesmije biti manji od datuma odkada!!", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    dtpDokada.Focus();
                }
            }
        }

        private void ckbDiskont_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbDiskont.Checked)
            {
                ckbTrgovina.Checked = false;
                ckbDiskont.Checked = true;
            }
            else
            {
                ckbTrgovina.Checked = false;
                ckbDiskont.Checked = false;
            }
        }

        private void ckbTrgovina_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbTrgovina.Checked)
            {
                ckbDiskont.Checked = false;
                ckbTrgovina.Checked = true;
            }
            else
            {
                ckbDiskont.Checked = false;
                ckbTrgovina.Checked = false;
            }
        }

    }
}
