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
    public partial class frmPoruka : Form
    {
        string vrstaCSV;


        // C - cjenik
        // A -artikli

        public string vrstaCSVa
        {
            get { return vrstaCSV; }
            set { vrstaCSV = value; }
        }

        public frmPoruka()
        {
            InitializeComponent();
        }

        private void frmPoruka_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = screenWidth - this.Width - 100;
            this.Top = screenHeight - this.Height - 100;

            if (vrstaCSV == "C")
            {
                pnlPrijenosCjenika.Visible = true;
            }
            else if (vrstaCSV == "A")
            {
                pnlArtiklCSV.Visible = true;
            }
            else if (vrstaCSV == "MPCA") //maloprodajni akcijski cjenik
            {
                pnlMPCakcija.Visible = true;
            }
            else if (vrstaCSV == "NCA") //nabavni akcijski cjenik
            {
                pnlNabavniAkcijski.Visible = true;
            }
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
