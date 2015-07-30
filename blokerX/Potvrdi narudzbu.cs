using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;

namespace blokerX
{
    public partial class frmPotvrdiNarudzbu : Form
    {
        public static Button osvjezi = new Button();
        Upiti veza = new Upiti();
        string narudzbaID;
        string brojNarudzbe;
        string sifraTrgovine;
        string nazivTrgovine;
        string skladisteSifra;
        string poslovnicaID;
        string skladisteID;
        string brojDana;

        public frmPotvrdiNarudzbu()
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

        private void frmPotvrdiNarudzbu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'komercijalist.operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(komercijalist.operater);
            osvjezi = btnPrikazi;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.Text != "")
                {
                    int IDkomer = Convert.ToInt32(glDobavljac.EditValue);
                    this.nepotvrdjeneNarudzbeTableAdapter.Fill(this.nepotvrdjeneNarudzbe._NepotvrdjeneNarudzbe, IDkomer);
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
                if ( dgNarudzbeZag.RowCount > 0)
                {
                    System.Data.DataRow row = dgNarudzbeZag.GetDataRow(dgNarudzbeZag.FocusedRowHandle);
                    if (row != null)
                    {
                        narudzbaID = row[0].ToString();
                        brojNarudzbe = row[2].ToString();
                        skladisteSifra = row[15].ToString();
                        nazivTrgovine = row[14].ToString();
                        sifraTrgovine = row[16].ToString();
                        poslovnicaID = row[4].ToString();
                        brojDana = row[21].ToString();
                        skladisteID = row[3].ToString();
                                                
                        //frmStavkeNarudzbe _frm;
                        //foreach (Form childForm in this.MdiChildren)
                        //{
                        //    if (childForm.GetType() == typeof(frmStavkeNarudzbe))
                        //    {
                        //        childForm.Focus();
                        //        return;
                        //    }
                        //}
                        //_frm = new frmStavkeNarudzbe();
                        //_frm.NarudzbaID = narudzbaID;
                        //_frm.BrojNarudzbe = brojNarudzbe;
                        //_frm.SkladisteSifra = skladisteSifra;
                        //_frm.trgovinaSifra = sifraTrgovine;
                        //_frm.trgovinaNaziv = nazivTrgovine;
                        //_frm.ShowDialog();

                        frmStavkeNarudzbe _frm;
                        foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmStavkeNarudzbe))
                            {
                                childForm.Focus();
                                return;
                            }
                        }
                        _frm = new frmStavkeNarudzbe();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.NarudzbaID = narudzbaID;
                        _frm.BrojNarudzbe = brojNarudzbe;
                        _frm.SkladisteSifra = skladisteSifra;
                        _frm.trgovinaSifra = sifraTrgovine;
                        _frm.trgovinaNaziv = nazivTrgovine;
                        _frm.PoslovnicaID = poslovnicaID;
                        _frm.brojDana = brojDana;
                        _frm.SkladisteID = skladisteID;
                        _frm.Show();

                        //frmStavkeNarudzbe _frm;
                        //foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                        //{
                        //    if (childForm.GetType() == typeof(frmStavkeNarudzbe))
                        //    {
                        //        childForm.Focus();
                        //        return;
                        //    }
                        //}

                        //_frm = new frmStavkeNarudzbe();
                        //_frm.NarudzbaID = narudzbaID;
                        //_frm.BrojNarudzbe = brojNarudzbe;
                        //_frm.SkladisteSifra = skladisteSifra;
                        //_frm.trgovinaSifra = sifraTrgovine;
                        //_frm.trgovinaNaziv = nazivTrgovine;
                        //_frm.PoslovnicaID = poslovnicaID;
                        //_frm.brojDana = brojDana;
                        //_frm.ShowDialog();

                        //frmStavkeNarudzbe UForm = null;
                        //if ((UForm = (frmStavkeNarudzbe)IsFormAlreadyOpen(typeof(frmStavkeNarudzbe))) == null)
                        //{
                        //    frmStavkeNarudzbe _frm = new frmStavkeNarudzbe();
                        //    _frm.MdiParent = frmMain.ActiveForm;
                        //    _frm.NarudzbaID = narudzbaID;
                        //    _frm.BrojNarudzbe = brojNarudzbe;
                        //    _frm.SkladisteSifra = skladisteSifra;
                        //    _frm.trgovinaSifra = sifraTrgovine;
                        //    _frm.trgovinaNaziv = nazivTrgovine;
                        //    _frm.PoslovnicaID = poslovnicaID;
                        //    _frm.brojDana = brojDana;
                        //    _frm.Show();
                        //}
                        //else
                        //{
                        //    UForm.Focus();
                        //    return;
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Nemate niti jedan cjenik koji biste ažurirali!");
                }
            }
        }

        private void frmPotvrdiNarudzbu_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgNarudzbeZag.RowCount > 0)
                {
                    System.Data.DataRow row = dgNarudzbeZag.GetDataRow(dgNarudzbeZag.FocusedRowHandle);
                    DialogResult result;
                    brojNarudzbe = row[2].ToString();

                    result = MessageBox.Show("Želite poništiti narudžbu broj : " +brojNarudzbe+ " ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        if (row != null)
                        {
                            narudzbaID = row[0].ToString();
                            
                            //MessageBox.Show("update narudzba set na_potvrdjeno = 1, na_ediObradjeno = 1 where na_ID = '" + narudzbaID + "'");
                            veza.ExecuteQuery("update narudzba set na_ponistena = 1, na_ediObradjeno = 1  where na_ID = '" + narudzbaID + "'");
                            MessageBox.Show("Uspješno ste poništili narudžbu!");
                            btnPrikazi.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
