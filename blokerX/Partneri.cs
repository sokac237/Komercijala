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
    public partial class frmPartneri : Form
    {

        Upiti veza = new Upiti();

        string ID_partner = "";
        string Sifra_partner = "";

        public frmPartneri()
        {
            InitializeComponent();
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select pa_ID,pa_sifra, pa_naziv from partner";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "partner");
            dgPartner.DataSource = ds;
            dgPartner.DataMember = "partner";

            string[] kolone = new string[5];
            kolone[0] = "ID Partnera";
            kolone[1] = "Sifra partnera";
            kolone[2] = "Naziv partnera";

            for (int i = 0; i < dgPartner.Columns.Count; i++)
            {
                dgPartner.Columns[i].HeaderText = kolone[i];
            }

        }

        private void Partneri_Load(object sender, EventArgs e)
        {
            FillData();
            txtSifra.Focus();
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            veza.ExecuteQuery("select pa_ID, pa_sifra, pa_naziv from partner where pa_naziv like '%" + txtSifra.Text + "%' ", ref dt);

            dgPartner.DataSource = dt;
            string[] kolone = new string[5];
            kolone[0] = "ID Partnera";
            kolone[1] = "Naziv partnera";


            for (int i = 0; i < dgPartner.Columns.Count; i++)
            {
                dgPartner.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgPartner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPartner.Rows.Count > 0)
            {
                ID_partner = dgPartner.CurrentRow.Cells["pa_ID"].Value.ToString();
                Sifra_partner = dgPartner.CurrentRow.Cells["pa_sifra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public string id_partner
        {
            get { return ((ID_partner != null)) ? ID_partner : null; }
        }

        public string sifra_partner
        {
            get { return ((Sifra_partner != null)) ? Sifra_partner : null; }
        }

        private void frmPartneri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (dgPartner.Rows.Count > 0)
                {
                    ID_partner = dgPartner.CurrentRow.Cells["pa_ID"].Value.ToString();
                    Sifra_partner = dgPartner.CurrentRow.Cells["pa_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }            
        }

        private void dgPartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPartner.Rows.Count > 0)
                {
                    ID_partner = dgPartner.CurrentRow.Cells["pa_ID"].Value.ToString();
                    Sifra_partner = dgPartner.CurrentRow.Cells["pa_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
