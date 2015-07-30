using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using blokirajx;

namespace blokerX
{
    public partial class frmStareNarudzbe : Form
    {
        Upiti veza = new Upiti();
        string narudzbaID;
        string brojNarudzbe;
        string skladisteSifra;
        string sifraTrgovine;
        string nazivTrgovine;


        public frmStareNarudzbe()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void frmStareNarudzbe_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'komercijalist.operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.komercijalist.operater);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.Text != "")
                {
                    int komerID = Convert.ToInt32(glDobavljac.EditValue);
                    string datOD = Convert.ToDateTime(dtpOd.Text).ToString("yyyy-MM-dd");
                    string datDO = Convert.ToDateTime(dtpDO.Text).ToString("yyyy-MM-dd");


                    DateTime datumOD = Convert.ToDateTime(datOD);
                    DateTime datumDO = Convert.ToDateTime(datDO).AddHours(23).AddMinutes(59).AddSeconds(59);

                    this.potvrdjeneNarudzbeTableAdapter.Fill(this.potvrdjeneNarudzbe._PotvrdjeneNarudzbe, komerID, datumOD, datumDO);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgNarudzbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (dgNarudzbeZag.RowCount > 0)
                {
                    System.Data.DataRow row = dgNarudzbeZag.GetDataRow(dgNarudzbeZag.FocusedRowHandle);
                    if (row != null)
                    {
                        narudzbaID = row[0].ToString();
                        brojNarudzbe = row[2].ToString();
                        skladisteSifra = row[17].ToString();
                        nazivTrgovine = row[14].ToString();
                        sifraTrgovine = row[18].ToString();

                        //frmStavkeStareNarudzbe _frm;
                        //foreach (Form childForm in this.MdiChildren)
                        //{
                        //    if (childForm.GetType() == typeof(frmStavkeStareNarudzbe))
                        //    {
                        //        childForm.Focus();
                        //        return;
                        //    }
                        //}
                        //_frm = new frmStavkeStareNarudzbe();
                        //_frm.NarudzbaID = narudzbaID;
                        //_frm.BrojNarudzbe = brojNarudzbe;
                        //_frm.SkladisteSifra = skladisteSifra;
                        //_frm.trgovinaSifra = sifraTrgovine;
                        //_frm.trgovinaNaziv = nazivTrgovine;
                        //_frm.ShowDialog();

                        frmStavkeStareNarudzbe UForm = null;
                        if ((UForm = (frmStavkeStareNarudzbe)IsFormAlreadyOpen(typeof(frmStavkeStareNarudzbe))) == null)
                        {
                            frmStavkeStareNarudzbe _frm = new frmStavkeStareNarudzbe();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.NarudzbaID = narudzbaID;
                            _frm.BrojNarudzbe = brojNarudzbe;
                            _frm.SkladisteSifra = skladisteSifra;
                            _frm.trgovinaSifra = sifraTrgovine;
                            _frm.trgovinaNaziv = nazivTrgovine;
                            _frm.Show();
                        }
                        else
                        {
                            UForm.Focus();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nemate niti jedan cjenik koji biste ažurirali!");
                }
            }
        }

        private void frmStareNarudzbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
