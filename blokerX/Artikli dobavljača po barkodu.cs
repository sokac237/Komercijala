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
    public partial class frmArtikliDobavljacaPoBarkodu : Form
    {

        Upiti veza = new Upiti();
        
        DataTable data = new DataTable();

        int A;
        int B;
        int C;
        int D;
        int X;

        public frmArtikliDobavljacaPoBarkodu()
        {
            InitializeComponent();
        }

        private void frmArtikliDobavljacaPoBarkodu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            btnStalniCjenik.Enabled = false;
        }

        private void frmArtikliDobavljacaPoBarkodu_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBarkod_Leave(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (data.Rows.Count > 0)
                {
                    lblNaziv.Text = data.Rows[0][0].ToString();
                    txtSifArtikl.Text = data.Rows[0][1].ToString();
                    popuni();
                    provjeriRG();
                }
                else
                {
                    MessageBox.Show("Ovaj barkod nije prijavljen!");
                    txtBarkod.Text = "";
                    txtBarkod.Focus();
                    txtSifArtikl.Text = "";
                    lblNaziv.Text = "___";
                    btnStalniCjenik.Enabled = false;
                }
            }
        }

        private void btnStalniCjenik_Click(object sender, EventArgs e)
        {
            if (lblNaziv.Text != "___")
            {
                frmIzmjenaCijena _frm;
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmIzmjenaCijena))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmIzmjenaCijena();
                _frm.idArtikla = data.Rows[0][9].ToString();
                _frm.IDPartnera = glDobavljac.EditValue.ToString();
                _frm.kojaFormaPoziva = "Artikli dobavljača po barkodu";
                _frm.ShowDialog();           
            }
        }

        private void provjeriRG()
        {
            DataTable da = new DataTable();
            veza.ExecuteQuery("select robnaGrupa_RG_ID from artikl where ar_sifra = '"+txtSifArtikl.Text+"'", ref da);

            if (da.Rows.Count > 0)
            {
                DataTable RG = new DataTable();
                string idRG = da.Rows[0][0].ToString();
                string operaterID = Global.KorisnikID;

                veza.ExecuteQuery("select * from robnagrupa where rg_ID = '"+idRG+"' and operater_op_ID = '"+operaterID+"'", ref RG);
                if (RG.Rows.Count > 0)
                {
                    btnStalniCjenik.Enabled = true;
                }                
            }
        }

        private void txtSifKodDobavljac_Leave(object sender, EventArgs e)
        {            
            if (txtSifKodDobavljac.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (data.Rows.Count > 0) 
                {
                    lblNaziv.Text = data.Rows[0][0].ToString();
                    txtSifArtikl.Text = data.Rows[0][1].ToString();
                    popuni();
                    provjeriRG();
                }
                else
                {
                    txtSifKodDobavljac.Text = "";
                    btnStalniCjenik.Enabled = false;
                    lblNaziv.Text = "___";
                }
            }
        }

        private void txtSifArtikl_Leave(object sender, EventArgs e)
        {
            if (txtSifArtikl.Text != "" && glDobavljac.EditValue.ToString() != "")
            {
                Upit();
                if (data.Rows.Count > 0)
                {
                    lblNaziv.Text = data.Rows[0][0].ToString();
                    txtSifArtikl.Text = data.Rows[0][1].ToString();
                    popuni();
                    provjeriRG();
                }
                else
                {
                    MessageBox.Show("Ova šifra ne postoji! Morate je vezati za trenutnog dobavljača.");
                    txtSifArtikl.Text = "";
                    txtSifArtikl.Focus();
                    txtBarkod.Text = "";
                    lblNaziv.Text = "___";
                    btnStalniCjenik.Enabled = false;
                }
            }
        }

        public void popuni()
        {
            if (data.Rows[0][3].ToString() == "True")
            {
                cmbA.Text = "Da";
            }
            else
            {
                cmbA.Text = "Ne";
            }
            if (data.Rows[0][4].ToString() == "True")
            {
                cmbB.Text = "Da";
            }
            else
            {
                cmbB.Text = "Ne";
            }
            if (data.Rows[0][5].ToString() == "True")
            {
                cmbC.Text = "Da";
            }
            else
            {
                cmbC.Text = "Ne";
            }
            if (data.Rows[0][6].ToString() == "True")
            {
                cmbD.Text = "Da";
            }
            else
            {
                cmbD.Text = "Ne";
            }
            if (data.Rows[0][7].ToString() == "True")
            {
                cmbX.Text = "Da";
            }
            else
            {
                cmbX.Text = "Ne";
            }
            txtPaket.Text = data.Rows[0][8].ToString();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upit()
        {
            if (txtBarkod.Text != "")
            {
                string barkod = txtBarkod.Text.Trim();

                string idDobavljac = glDobavljac.EditValue.ToString();

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,barkod.bk_kod, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID  from dobavljacartikl, artikl, barkod where barkod.bk_kod = '" + barkod + "' and barkod.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.artikl_ar_ID = barkod.artikl_ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);

            }
            else if (txtSifArtikl.Text != "")
            {
                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraArtikl = txtSifArtikl.Text;

                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra, artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where artikl.ar_sifra = '" + sifraArtikl + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);

            }
            else if (txtSifKodDobavljac.Text != "")
            {
                string idDobavljac = glDobavljac.EditValue.ToString();
                string sifraKodDob = txtSifKodDobavljac.Text;


                veza.ExecuteQuery("select artikl.AR_naziv, artikl.ar_sifra,  artikl.ar_aktivan, dobavljacartikl.doa_A, dobavljacartikl.doa_B, dobavljacartikl.doa_C, dobavljacartikl.doa_D, dobavljacartikl.doa_X, artikl.ar_pakiranje, artikl.ar_ID from dobavljacartikl, artikl where dobavljacartikl.doa_sifraKodDobavljaca = '" + sifraKodDob + "' and dobavljacartikl.artikl_ar_ID = artikl.ar_ID and dobavljacartikl.partneri_pa_ID = '" + idDobavljac + "' ", ref data);

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (lblNaziv.Text != "___")
            {
                if (txtPaket.Text != "")
                {
                    string paket = Convert.ToString(txtPaket.Text).Replace(',', '.');
                    veza.ExecuteQuery("update artikl set ar_pakiranje = '" + paket + "' where ar_ID = '"+data.Rows[0][9].ToString()+"'");
                }
                if (cmbA.Text == "Da")
                {
                    A = 1;
                }
                else
                {
                    A = 0;
                }
                if (cmbB.Text == "Da")
                {
                    B = 1;
                }
                else
                {
                    B = 0;
                }
                if (cmbC.Text == "Da")
                {
                    C = 1;
                }
                else
                {
                    C = 0;
                }
                if (cmbD.Text == "Da")
                {
                    D = 1;
                }
                else
                {
                    D = 0;
                }
                if (cmbX.Text == "Da")
                {
                    X = 1;
                }
                else
                {
                    X = 0;
                }
                veza.ExecuteQuery("update dobavljacartikl set doa_A ='" + A + "', doa_B ='" + B + "', doa_C='" + C + "', doa_D='" + D + "', doa_X = '" + X + "' where artikl_ar_ID ='" + data.Rows[0][9].ToString() + "' and partneri_PA_ID = '"+glDobavljac.EditValue.ToString()+"'");
                MessageBox.Show("Uspješno ste dodali podatke!");
            }
        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtPaket.Text = "";
            txtSifArtikl.Text = "";
            txtSifKodDobavljac.Text = "";
            lblNaziv.Text = "___";
        }

        private void txtSifArtikl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            //}
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
            //if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            //}
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
