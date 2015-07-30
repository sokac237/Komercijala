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
    public partial class frmAzuriranjePaketa : Form
    {
        Upiti veza = new Upiti();

        string _broj;
        string _F;

        public frmAzuriranjePaketa()
        {
            InitializeComponent();
        }

        public string broj
        {
            get { return _broj; }
            set { _broj = value; }
        }

        public string tipka
        {
            get { return _F; }
            set { _F = value; }
        }

        public void frmAzuriranjePaketa_Load(object sender, EventArgs e)
        {
            DataTable dat = new DataTable();
            try
            {
                if (_F == "F4")
                {
                    Text = "Ažuriranje količine u paketu";
                    veza.ExecuteQuery("select ar_sifra, ar_naziv, ar_pakiranje from artikl where ar_ID = '"+_broj+"' " , ref dat);

                    if (dat.Rows.Count > 0)
                    {
                        lblSifra.Text = dat.Rows[0][0].ToString();
                        lblNaziv.Text = dat.Rows[0][1].ToString();
                        txtKolicina.Text = dat.Rows[0][2].ToString();
                    }
                }
                else
                {
                    Text = "Ažuriranje količine za trgovinu";
                    veza.ExecuteQuery("select ar_sifra, ar_naziv, ar_pakiranjeTrgovina from artikl where ar_ID = '"+_broj+"' ", ref dat);

                    if (dat.Rows.Count > 0)
                    {
                        lblSifra.Text = dat.Rows[0][0].ToString();
                        lblNaziv.Text = dat.Rows[0][1].ToString();
                        txtKolicina.Text = dat.Rows[0][2].ToString();
                    }
                
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                string pakiranje;

                if (txtKolicina.Text == "")
                {
                    pakiranje = "0.0";
                }
                else
                {
                    pakiranje = Convert.ToString(txtKolicina.Text).Replace(',', '.');
                }

                if (_F == "F4")
                {
                    veza.ExecuteQuery("Update artikl set ar_pakiranje = '" + pakiranje + "' where ar_ID = '" + _broj + "'");
                    this.Close();
                    if(Global.oznaci =="1")
                    {
                        frmArtikliPoDobavljacu.a.PerformClick();
                    }
                    if (Global.oznaci == "0")
                    {
                        frmArtikliPoRG.a.PerformClick();
                    }                                   
                }
                else
                {
                    veza.ExecuteQuery("Update artikl set ar_pakiranjeTrgovina = '" + pakiranje + "' where ar_ID = '" + _broj + "'");
                    this.Close();

                    if (Global.oznaci == "1")
                    {
                        frmArtikliPoDobavljacu.a.PerformClick();
                    }
                    if (Global.oznaci == "0")
                    {
                        frmArtikliPoRG.a.PerformClick();
                    }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmAzuriranjePaketa_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void frmAzuriranjePaketa_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
