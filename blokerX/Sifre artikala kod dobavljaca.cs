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
    public partial class frmSifreArtikalaKodDobavljaca : Form
    {
        Upiti veza = new Upiti();
        string oznaka; //A - azuriraj, I - insert
        string IdDobar;

        public frmSifreArtikalaKodDobavljaca()
        {
            InitializeComponent();
        }

        private void frmSifreArtikalaKodDobavljaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            panel2.Visible = false;
        }

        private void txtPrikazi_Click(object sender, EventArgs e)
        {
            int IDDObavljac = Convert.ToInt32(glDobavljac.EditValue);
            sifreKodDobavljacaTableAdapter.Fill(this.sifraArtiklaKodDobavljaca.SifreKodDobavljaca, IDDObavljac);
            panel2.Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            lblNaziv.Text = "___";
            txtSifraKodDobavljaca.Text = "";
            txtSifraArtikla.Text = "";
        }

        private void dgSifreKodDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    panel2.Visible = true;
                    oznaka = "A";

                    System.Data.DataRow row = dgSifreDobavljac.GetDataRow(dgSifreDobavljac.FocusedRowHandle);
                    
                    if (row != null)
                    {
                        IdDobar = row[0].ToString();
                        txtSifraArtikla.Text = row[1].ToString();
                        txtSifraKodDobavljaca.Text = row[3].ToString();
                        txtSifraArtikla.Enabled = false;
                        txtIDArtikl.Text = row[4].ToString();
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    //panel2.Visible = true;
                    //oznaka = "I";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSifraArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmSifarnikArtikala _frm = new frmSifarnikArtikala();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifraArtikla.Text = _frm.ArtiklSifra;
                        txtIDArtikl.Text = _frm.id_artikl;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtSifraArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void txtSifraArtikla_TextChanged(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();
            if (txtSifraArtikla.Text != "")
            {
                veza.ExecuteQuery("select ar_naziv from artikl where ar_sifra = '" + txtSifraArtikla.Text + "'", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblNaziv.Text = bar.Rows[0][0].ToString();
                }
                else
                {
                    lblNaziv.Text = "___";
                }
            }
            else
            {
                lblNaziv.Text = "___";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifraArtikla.Text.Trim() != "")
                {
                    if (oznaka == "I")
                    {
                        //insert
                        //veza.ExecuteQuery("insert into dobavljacartikl (artikl_ar_ID,partneri_pa_ID,) values ()");
                    }
                    else
                    {
                        //update
                        //MessageBox.Show("update dobavljacartikl set doa_sifraKodDobavljaca = '" + txtSifraKodDobavljaca.Text.Trim() + "' where doa_ID = " + IdDobar + " and artikl_ar_ID = " + txtIDArtikl.Text.Trim() + " ");
                        veza.ExecuteQuery("update dobavljacartikl set doa_sifraKodDobavljaca = '" + txtSifraKodDobavljaca.Text.Trim() + "' where doa_ID = " + IdDobar + " and artikl_ar_ID = "+txtIDArtikl.Text.Trim()+" ");
                        btnPrikazi.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSifreArtikalaKodDobavljaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
