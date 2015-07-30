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
    public partial class frmOperater : Form
    {
        Upiti veza = new Upiti();

        string ID_operatera = "";
        string sifra_operatera;

        public frmOperater()
        {
            InitializeComponent();
        }

        void FillData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString;

            string commandString = "select op_ID, op_sifra, op_ime, op_prezime from operater";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandString, connectionString);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "operater");
            dgOperater.DataSource = ds;
            dgOperater.DataMember = "operater";

            string[] kolone = new string[5];
            kolone[0] = "ID operatera";
            kolone[1] = "Šifra";
            kolone[2] = "Ime operatera";

            for (int i = 0; i < dgOperater.Columns.Count; i++)
            {
                dgOperater.Columns[i].HeaderText = kolone[i];
            }

        }

        private void Operateri_Load(object sender, EventArgs e)
        {
            FillData();
            txtOperater.Focus();
        }

        private void txtOperater_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            veza.ExecuteQuery("select op_ID, op_sifra, op_ime, op_prezime from operater where CONCAT( op_ime, ' ' , op_prezime) like '%" + txtOperater.Text + "%' ", ref dt);

            dgOperater.DataSource = dt;
            string[] kolone = new string[5];
            kolone[0] = "ID operatera";
            kolone[1] = "Šifra";
            kolone[2] = "Ime operatera";

            for (int i = 0; i < dgOperater.Columns.Count; i++)
            {
                dgOperater.Columns[i].HeaderText = kolone[i];
            }
        }

        private void dgOperater_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOperater.Rows.Count > 0)
            {
                ID_operatera = dgOperater.CurrentRow.Cells["op_ID"].Value.ToString();
                sifra_operatera = dgOperater.CurrentRow.Cells["op_sifra"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        public string id_operater
        {
            get { return ((ID_operatera != null)) ? ID_operatera : null; }
        }

        public string sifra_operater
        {
            get { return ((sifra_operatera != null)) ? sifra_operatera : null; }
        }

        private void Operateri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgOperater.Rows.Count > 0)
                {
                    ID_operatera = dgOperater.CurrentRow.Cells["op_ID"].Value.ToString();
                    sifra_operatera = dgOperater.CurrentRow.Cells["op_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgOperater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgOperater.Rows.Count > 0)
                {
                    ID_operatera = dgOperater.CurrentRow.Cells["op_ID"].Value.ToString();
                    sifra_operatera = dgOperater.CurrentRow.Cells["op_sifra"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
        }
    }
}
