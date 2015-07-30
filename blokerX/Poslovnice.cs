using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace blokerX
{
    public partial class frmPoslovnice : Form
    {

        Upiti veza = new Upiti();

        string poslovnica_sifra = "";

        public frmPoslovnice()
        {
            InitializeComponent();
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select po_sifra, po_naziv from poslovnica";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "poslovnica");
            dgPoslovnice.DataSource = ds;
            dgPoslovnice.DataMember = "poslovnica";

            string[] kolone = new string[5];
            kolone[0] = "Šifra poslovnice";
            kolone[1] = "Naziv poslovnice";

            for (int i = 0; i < dgPoslovnice.Columns.Count; i++)
            {
                dgPoslovnice.Columns[i].HeaderText = kolone[i];
            }
        }

        private void Poslovnice_Load(object sender, EventArgs e)
        {
            FillData();
            txtNaziv.Focus();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            veza.ExecuteQuery("select po_sifra, po_naziv from poslovnica where po_naziv like '%" + txtNaziv.Text + "%'", ref dt);

            dgPoslovnice.DataSource = dt;
            string[] kolone = new string[5];
            kolone[0] = "Šifra poslovnice";
            kolone[1] = "Naziv poslovnice";

            for (int i = 0; i < dgPoslovnice.Columns.Count; i++)
            {
                dgPoslovnice.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgPoslovnice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPoslovnice.Rows.Count > 0)
            {
                poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_sifra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        public string sifra_poslovnice
        {
            get { return ((poslovnica_sifra != null)) ? poslovnica_sifra : null; }
        }

        private void Poslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPoslovnice.Rows.Count > 0)
                {
                    poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgPoslovnice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPoslovnice.Rows.Count > 0)
                {
                    poslovnica_sifra = dgPoslovnice.CurrentRow.Cells["po_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
        }
    }
}
