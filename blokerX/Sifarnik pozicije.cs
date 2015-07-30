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
    public partial class frmVrstePozicije : Form
    {
        string ID_pozicija;
        public frmVrstePozicije()
        {
            InitializeComponent();
        }

        private void Sifarnik_pozicije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vrstePozicija.vrstapozicije' table. You can move, or remove it, as needed.
            this.vrstapozicijeTableAdapter.Fill(this.vrstePozicija.vrstapozicije);

        }

        private void gridControl4_DoubleClick(object sender, EventArgs e)
        {
            if ( gridView5.RowCount > 0)
            {
                System.Data.DataRow row = gridView5.GetDataRow(gridView5.FocusedRowHandle);
                ID_pozicija = row[0].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
