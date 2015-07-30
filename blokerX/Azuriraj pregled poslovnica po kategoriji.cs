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
    public partial class frmAzurirajPoslovnicePoKategoriji : Form
    {
        Upiti veza = new Upiti();

        string _idPoslovnice;

        DataTable poslovnica = new DataTable();

        public frmAzurirajPoslovnicePoKategoriji()
        {
            InitializeComponent();
        }

        public string IDPoslovnice
        {
            get { return _idPoslovnice; }
            set { _idPoslovnice = value; }
        }

        private void txtAsortiman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAsortiman.Text == "")
            {
                string charset = "ABCDX";
                {
                    if (charset.Contains(e.KeyChar.ToString()))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Dozvoljeni su samo znakovi ABCDX!", "Validion", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtCjenik_KeyPress(object sender, KeyPressEventArgs e)
        {
            string charset = "ABCDX";
            {
                if (txtCjenik.Text == "")
                {
                    if (charset.Contains(e.KeyChar.ToString()))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Dozvoljeni su samo znakovi ABCDX!", "Validion", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void frmAzurirajPoslovnicePoKategoriji_KeyDown(object sender, KeyEventArgs e)
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

        private void frmAzurirajPoslovnicePoKategoriji_Load(object sender, EventArgs e)
        {
            try
            {
                txtCjenik.Focus();
                if (_idPoslovnice != "")
                {
                    veza.ExecuteQuery("select po_sifra,po_naziv, po_asortiman, po_cjenik from poslovnica where po_ID ="+_idPoslovnice+"", ref poslovnica);

                    if (poslovnica.Rows.Count > 0)
                    {
                        txtAsortiman.Text = poslovnica.Rows[0][2].ToString();
                        txtCjenik.Text = poslovnica.Rows[0][3].ToString();
                        txtSifra.Text = poslovnica.Rows[0][0].ToString();
                        lblNazivPoslovnice.Text = poslovnica.Rows[0][1].ToString();
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
                veza.ExecuteQuery("update poslovnica set po_cjenik = '"+txtCjenik.Text+"' where po_ID = "+_idPoslovnice+"");
                frmPregledPoslovnicaPoKategoriji.azuriraj.PerformClick();
                MessageBox.Show("Uspješno ste ažurirali podatak.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
