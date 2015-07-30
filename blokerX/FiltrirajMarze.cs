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
    public partial class frmFiltrirajMarze : Form
    {
        Upiti veza = new Upiti();

        public frmFiltrirajMarze()
        {
            InitializeComponent();
        }

        private void frmFiltrirajMarze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

        }
    }
}
