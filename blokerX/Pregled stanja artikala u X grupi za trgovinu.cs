using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace blokerX
{
    public partial class frmPregledStanjaArtikalauXGrupiZaTrgovinu : Form
    {
        Upiti veza = new Upiti();
        DataTable RG = new DataTable();

        int brojac;

        public frmPregledStanjaArtikalauXGrupiZaTrgovinu()
        {
            InitializeComponent();
        }

        private void frmPregledStanjaArtikalauXGrupiZaTrgovinu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.poslovnica.poslovnica);
            // TODO: This line of code loads data into the 'komercijalist.operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.komercijalist.operater);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PokupiRG();
        }

        private void PokupiRG()
        {
            try
            {
                string robneGrupe = "";

                veza.ExecuteQuery("select rg_ID from robnaGrupa where operater_op_ID = '"+glKomercijalist.EditValue+"'",ref RG);

                if (RG.Rows.Count > 0)
                {

                    for (brojac = 0; brojac < RG.Rows.Count; brojac++)
                    {
                        if (robneGrupe != "")
                        {
                            robneGrupe = robneGrupe + ",";
                        }
                        robneGrupe = robneGrupe + RG.Rows[brojac][0].ToString();
                    }

                    if (glKomercijalist.EditValue.ToString() != "" && glPoslovnica.EditValue.ToString() != "")
                    {
                        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                        MySqlCommand comm = new MySqlCommand("select zaliha.*, artikl.AR_NAZIV, artikl.AR_SIFRA, poslovnica.po_sifra, robnagrupa.RG_SIFRA from zaliha, artikl, operater, poslovnica, robnagrupa where zaliha.artikl_ar_id = artikl.ar_id and poslovnica.po_id =" + glPoslovnica.EditValue + " and zaliha.poslovnica_po_id = poslovnica.po_id and artikl.robnaGrupa_rg_ID = robnagrupa.rg_ID and operater.op_ID = " + glKomercijalist.EditValue + " and robnagrupa.operater_op_ID = operater.op_ID and zaliha.artikl_ar_ID in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + "))", conn);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                        if (gridView3.RowCount > 0)
                        {
                            stanjeArtikala.Clear();
                        }

                        adapter.Fill(stanjeArtikala, "Table");
                        dgAkcijskiNabavniCjenici.DataSource = stanjeArtikala.Tables["Table"];
                        stanjeArtikalaBindingSource = new BindingSource(stanjeArtikala, "Table");
                        dgAkcijskiNabavniCjenici.DataSource = stanjeArtikalaBindingSource;
                        dgAkcijskiNabavniCjenici.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Morate odabrati poslovnicu i komercijalistu!");
                        glKomercijalist.Focus();
                    }       
                }
                else
                {
                    MessageBox.Show("Odabranom komercijalistu nisu pridružene robne grupe!");
                }

                       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPregledStanjaArtikalauXGrupiZaTrgovinu_KeyDown(object sender, KeyEventArgs e)
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

    }
}
