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
    public partial class frmAzurirajStalniNabavniCjenik : Form
    {
        string _sifraPartner;
        Upiti veza = new Upiti();
        DataTable nabavniCjenik = new DataTable();

        string _IDCjenika;

        int aktivan;

        string _IDpartner;


        public frmAzurirajStalniNabavniCjenik()
        {
            InitializeComponent();
        }

        public string idCjenika
        {
            get { return _IDCjenika; }
            set { _IDCjenika = value; }
        }

        public string PartnerID
        {
            get { return _IDpartner; }
            set { _IDpartner = value; }
        }

        public string PartnerSifra
        {
            get { return _sifraPartner; }
            set { _sifraPartner = value; }
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
                        //partner = _frm.id_partner;
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
                veza.ExecuteQuery("select pa_naziv from partner where pa_sifra = " + txtPartnerSifra.Text + "", ref paID);

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

        private void txtPartnerSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void frmAzurirajStalniNabavniCjenik_KeyDown(object sender, KeyEventArgs e)
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

        private void frmAzurirajStalniNabavniCjenik_Load(object sender, EventArgs e)
        {
            try
            {
                if (_IDCjenika == "0")
                {
                    txtPartnerSifra.Text = _sifraPartner;
                    ckbAktivan.Checked = true;
                    return;
                }
                else
                {
                    veza.ExecuteQuery("select * from nabavnicjenik where nac_ID = '" + _IDCjenika + "'", ref nabavniCjenik);

                    if (nabavniCjenik.Rows.Count > 0)
                    {
                        txtOpis.Text = nabavniCjenik.Rows[0][1].ToString();
                        _IDpartner = nabavniCjenik.Rows[0][6].ToString();

                        dohvatiIDPartnera();

                        txtPartnerSifra.Text = _sifraPartner;

                        if (nabavniCjenik.Rows[0][4].ToString() == "True")
                        {
                            ckbAktivan.Checked = true;
                        }
                        else
                        {
                            ckbAktivan.Checked = false;
                        }

                        dtpDatumOd.Text = nabavniCjenik.Rows[0][2].ToString();                        
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IDCjenika == "0")
                {
                    if (txtOpis.Text != "" && txtPartnerSifra.Text != "" && lblPartnerNaziv.Text != "___" )
                    {
                        string opis = txtOpis.Text.Trim();
                        string datumOD = Convert.ToDateTime(dtpDatumOd.Text).ToString("yyyy-MM-dd");
                        if (ckbAktivan.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }
                        //dohvatiIDPartnera();
                        veza.ExecuteQuery("insert into nabavnicjenik (nac_opis, nac_vaziod, nac_aktivan, partneri_pa_ID) values ('" + opis + "', '" + datumOD + "','" + aktivan + "', '" + _IDpartner + "')");
                        this.Close();
                        frmStalniNabavniCjenik.azurirajCjenik.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Morate odabrati partnera i opis!");
                    }
                }
                else
                {
                    if (txtOpis.Text != "" && txtPartnerSifra.Text != "" && lblPartnerNaziv.Text != "___")
                    {
                        string opis = txtOpis.Text.Trim();
                        string datumOD = Convert.ToDateTime(dtpDatumOd.Text).ToString("yyyy-MM-dd");
                        if (ckbAktivan.Checked)
                        {
                            aktivan = 1;
                        }
                        else
                        {
                            aktivan = 0;
                        }
                        //dohvatiIDPartnera();
                        veza.ExecuteQuery("update nabavnicjenik set nac_opis = '" + opis + "', nac_vaziod = '" + datumOD + "', nac_aktivan = " + aktivan + ", partneri_pa_ID = '" + _IDpartner + "' where nac_ID = '" + _IDCjenika + "'");
                        this.Close();
                        frmStalniNabavniCjenik.azurirajCjenik.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Morate odabrati partnera i opis!");
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAzurirajStalniNabavniCjenik_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dohvatiIDPartnera()
        {
            try
            {
                DataTable IDpartnera = new DataTable();

                veza.ExecuteQuery("select pa_ID, pa_sifra from partner where pa_ID = " + _IDpartner + "", ref IDpartnera);

                if (IDpartnera.Rows.Count > 0)
                {
                    _sifraPartner = IDpartnera.Rows[0][1].ToString();
                    _IDpartner = IDpartnera.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
