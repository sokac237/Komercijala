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
    public partial class frmKategorijeAkcija : Form
    {
        public frmKategorijeAkcija()
        {
            InitializeComponent();
        }

        private void frmKategorijeAkcija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kategorijeAkcija.kategorijeAkcija' table. You can move, or remove it, as needed.
            this.kategorijeAkcijaTableAdapter.Fill(this.kategorijeAkcija.kategorijeAkcija);

        }
    }
}
