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

namespace blokerX.Sifarnik
{
    public partial class frmArtikl : Form
    {
        Upiti veza = new Upiti();

        string ID_artikl = "";
        string ar_sifra;

        public frmArtikl()
        {
            InitializeComponent();
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select ar_ID, ar_sifra, ar_naziv from artikl";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "artikl");
            dgArtikli.DataSource = ds;
            dgArtikli.DataMember = "artikl";

            string[] kolone = new string[5];
            kolone[0] = "ID artikla";
            kolone[1] = "Šifra artikla";
            kolone[2] = "Naziv artikla";

            for (int i = 0; i < dgArtikli.Columns.Count; i++)
            {
                dgArtikli.Columns[i].HeaderText = kolone[i];
            }
        }

                    

        private void Artikl_Load(object sender, EventArgs e)
        {
            FillData();
            txtSifra.Focus();
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            veza.ExecuteQuery("select ar_ID, ar_sifra, ar_naziv from artikl where ar_naziv like '%" + txtSifra.Text + "%' ", ref dt);

            dgArtikli.DataSource = dt;
            string[] kolone = new string[5];
            kolone[0] = "ID artikla";
            kolone[1] = "Šifra artikla";
            kolone[2] = "Naziv artikla";

            for (int i = 0; i < dgArtikli.Columns.Count; i++)
            {
                dgArtikli.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
            {
                ID_artikl = dgArtikli.CurrentRow.Cells["ar_ID"].Value.ToString();
                ar_sifra = dgArtikli.CurrentRow.Cells["ar_sifra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public string id_artikl
        {
            get { return ((ID_artikl != null)) ? ID_artikl : null; }
        }

        public string sifra_artikl
        {
            get { return ((ar_sifra != null)) ? ar_sifra : null; }
        }

        private void Artikl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgArtikli.Rows.Count > 0)
                {
                    ID_artikl = dgArtikli.CurrentRow.Cells["ar_ID"].Value.ToString();
                    ar_sifra = dgArtikli.CurrentRow.Cells["ar_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgArtikli.Rows.Count > 0)
                {
                    ID_artikl = dgArtikli.CurrentRow.Cells["ar_ID"].Value.ToString();
                    ar_sifra = dgArtikli.CurrentRow.Cells["ar_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void txtSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
