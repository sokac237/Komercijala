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
    public partial class frmPregledNarudzbiSaSkladista : Form
    {
        public frmPregledNarudzbiSaSkladista()
        {
            InitializeComponent();
        }

        private void Pregled_narudzbi_sa_skladista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);

        }
    }
}
