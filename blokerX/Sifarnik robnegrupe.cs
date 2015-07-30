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
    public partial class frmRobneGrupe : Form
    {
        Upiti veza = new Upiti();

        string sifraArtikla;


        public frmRobneGrupe()
        {
            InitializeComponent();
        }

        public string RGSifra
        {
            get { return ((sifraArtikla != null)) ? sifraArtikla : null; }
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select rg_sifra, rg_naziv from robnagrupa where rg_rg4 <> ''";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "artikl");
            dgRobnaGrupa.DataSource = ds;
            dgRobnaGrupa.DataMember = "artikl";

            string[] kolone = new string[5];
            kolone[0] = "Šifra RG";
            kolone[1] = "Naziv RG";


            for (int i = 0; i < dgRobnaGrupa.Columns.Count; i++)
            {
                dgRobnaGrupa.Columns[i].HeaderText = kolone[i];
            }

        }

        private void frmRobneGrupe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgRobnaGrupa.Rows.Count > 0)
                {
                    sifraArtikla = dgRobnaGrupa.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmRobneGrupe_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            veza.ExecuteQuery("select ar_ID, ar_sifra, ar_naziv, jedinicaMjere_JM_Sifra from artikl where ar_naziv like '%" + txtSifra.Text + "%' ", ref dt);

            dgRobnaGrupa.DataSource = dt;

            string[] kolone = new string[5];
            kolone[0] = "Šifra RG";
            kolone[1] = "Naziv RG";

            for (int i = 0; i < dgRobnaGrupa.Columns.Count; i++)
            {
                dgRobnaGrupa.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgRobnaGrupa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRobnaGrupa.Rows.Count > 0)
            {
                sifraArtikla = dgRobnaGrupa.CurrentRow.Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgRobnaGrupa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgRobnaGrupa.Rows.Count > 0)
                {
                    sifraArtikla = dgRobnaGrupa.CurrentRow.Cells[0].Value.ToString();
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
