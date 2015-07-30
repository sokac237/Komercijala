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
    public partial class frmSifarnikArtikala : Form
    {
        Upiti veza = new Upiti();

        string ID_artikl = "";
        string sifraArtikla;

        public frmSifarnikArtikala()
        {
            InitializeComponent();
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select ar_ID, ar_sifra, ar_naziv, jedinicaMjere_JM_Sifra from artikl";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "artikl");
            dgArtikli.DataSource = ds;
            dgArtikli.DataMember = "artikl";

            string[] kolone = new string[5];
            kolone[0] = "ID artikla";
            kolone[1] = "Šifra artikla";
            kolone[2] = "Naziv artikla";
            kolone[3] = "Jmj";

            for (int i = 0; i < dgArtikli.Columns.Count; i++)
            {
                dgArtikli.Columns[i].HeaderText = kolone[i];
            }

        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            veza.ExecuteQuery("select ar_ID, ar_sifra, ar_naziv, jedinicaMjere_JM_Sifra from artikl where ar_naziv like '%" + txtSifra.Text + "%' ", ref dt);

            dgArtikli.DataSource = dt;
            string[] kolone = new string[5];
            kolone[0] = "ID artikla";
            kolone[1] = "Šifra artikla";
            kolone[2] = "Naziv artikla";
            kolone[3] = "Jmj";

            for (int i = 0; i < dgArtikli.Columns.Count; i++)
            {
                dgArtikli.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
            {
                ID_artikl = dgArtikli.CurrentRow.Cells[0].Value.ToString();
                sifraArtikla = dgArtikli.CurrentRow.Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public string id_artikl
        {
            get { return ((ID_artikl != null)) ? ID_artikl : null; }
        }

        public string ArtiklSifra
        {
            get { return ((sifraArtikla != null)) ? sifraArtikla : null; }
        }

        private void dgArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgArtikli.Rows.Count > 0)
                {
                    ID_artikl = dgArtikli.CurrentRow.Cells[0].Value.ToString();
                    sifraArtikla = dgArtikli.CurrentRow.Cells[1].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }         
        }

        private void frmSifarnikArtikala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgArtikli.Rows.Count > 0)
                {
                    ID_artikl = dgArtikli.CurrentRow.Cells[0].Value.ToString();
                    sifraArtikla = dgArtikli.CurrentRow.Cells[1].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSifarnikArtikala_Load(object sender, EventArgs e)
        {
            FillData();
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
