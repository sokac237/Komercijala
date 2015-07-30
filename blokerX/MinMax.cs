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
    public partial class frmMinMax : Form
    {
        Upiti veza = new Upiti();

        DataTable podaci = new DataTable();


        public frmMinMax()
        {
            InitializeComponent();
        }

        private void frmMinMax_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glPartner.Text != "")
            {
                //string a = dtpDatum.EditValue.ToString();
            }
        }
    }
}
