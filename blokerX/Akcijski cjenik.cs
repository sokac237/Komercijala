    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using MySql.Data.MySqlClient;
using FastReport;
using SmartXLS;
using System.IO;

namespace blokerX
{
    public partial class frmAkcijskiCjenikProdaja : Form
    {
        int obrisan;
        int topRowIndex;
        int focus;

        string flag; //0 - insert novi , ako je 1 - onda update

        Upiti veza = new Upiti();

        string _nivoCjenika;

        int IDcjenika;

        string artikl;

        string cjenikID;

        public static Button azuriraj = new Button();

        public static Button azurirajStavke = new Button();

        int brojac;

        string datumOD;
        string datumDO;
        string IDcjenik;

        public frmAkcijskiCjenikProdaja()
        {
            InitializeComponent();
        }

        public string KojiNivo
        {
            get { return _nivoCjenika; }
            set { _nivoCjenika = value; }
        }

        private void frmAkcijskiCjenikProdaja_Load(object sender, EventArgs e)
        {
            Godina.Value = DateTime.Now.Year;
            azuriraj = btnAzuriraj;
            azurirajStavke = btnAzurirajStavke;

            if (_nivoCjenika == "2")
            {
                this.prodajnicjenikAkcijskiTableAdapter.Fill(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 2);
                this.Text = "Akcijski cjenik - komercijala";
            }
            else
            {
                this.prodajnicjenikAkcijskiTableAdapter.Fill(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 3);
                this.Text = "Akcijski cjenik - marketing";
            }
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

        private void dgCjenici_KeyUp(object sender, KeyEventArgs e)
        {
            topRowIndex = gridView2.TopRowIndex;
            focus = gridView2.FocusedRowHandle;

            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {
                            artikl = row[0].ToString();

                            string korisnik = row[9].ToString();

                            //if (Global.KorisnikID == korisnik || Global.KorisnikID == "1964")
                            //{
                            //frmAzurirajProdajniAkcijskiCjenik _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajProdajniAkcijskiCjenik))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajProdajniAkcijskiCjenik();
                            //_frm.artikl = artikl;
                            //_frm.ShowDialog();

                            frmAzurirajProdajniAkcijskiCjenik UForm = null;
                            if ((UForm = (frmAzurirajProdajniAkcijskiCjenik)IsFormAlreadyOpen(typeof(frmAzurirajProdajniAkcijskiCjenik))) == null)
                            {
                                frmAzurirajProdajniAkcijskiCjenik _frm = new frmAzurirajProdajniAkcijskiCjenik();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.artikl = artikl;
                                _frm.Niov = _nivoCjenika;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }

                            //}
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nemate niti jedan cjenik koji biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    artikl = "0";
                    flag = "0";

                    //frmAzurirajProdajniAkcijskiCjenik _frm;
                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzurirajProdajniAkcijskiCjenik))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_frm = new frmAzurirajProdajniAkcijskiCjenik();
                    //_frm.artikl = artikl;
                    //_frm.ShowDialog();

                    frmAzurirajProdajniAkcijskiCjenik UForm = null;
                    if ((UForm = (frmAzurirajProdajniAkcijskiCjenik)IsFormAlreadyOpen(typeof(frmAzurirajProdajniAkcijskiCjenik))) == null)
                    {
                        frmAzurirajProdajniAkcijskiCjenik _frm = new frmAzurirajProdajniAkcijskiCjenik();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.artikl = artikl;
                        _frm.Niov = _nivoCjenika;
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;
                    }
                }
                else if (e.KeyCode == Keys.F3)
                {
                    try
                    {
                        if (gridView2.SelectedRowsCount > 0)
                        {
                            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                            if (row != null)
                            {
                                string IDcjenik = row[0].ToString();
                                IDcjenika = Convert.ToInt16(IDcjenik);
                                string datum = Convert.ToDateTime(row[1]).ToString("yyyy-MM-dd");
                                DateTime datumPrije = Convert.ToDateTime(datum).AddDays(-1);

                                DateTime stari = Convert.ToDateTime("1899-12-30");
                                string datumKonacni = datumPrije.ToString("yyyy-MM-dd");
           
                                if (_nivoCjenika == "2")
                                {
                                    //this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
                                    this.prodAkcStavkeTableAdapter.FillBy(this.prodajniAkcijskiStavke.prodAkcStavke, IDcjenika,2);
                                }
                                else
                                {
                                    //this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
                                    //this.prodajnicjenikAkcijskiStavkeTableAdapter.FillBy(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, datumKonacni, stari);
                                    this.prodAkcStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodAkcStavke, IDcjenika, datumKonacni, stari);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {
                            IDcjenik = row[0].ToString();
                            IDcjenika = Convert.ToInt16(IDcjenik);

                            DataTable provjera = new DataTable();

                            veza.ExecuteQuery("select prc_ID from prodajnistavka where prodajnicjenik_prc_ID = "+IDcjenik+" ", ref provjera);

                            if (provjera.Rows.Count > 0)
                            {
                                //upitaj za brisanje
                                DialogResult result;

                                result = MessageBox.Show("U ovom cjeniku  postoje stavke, i dalje želite obrisati cjenik??", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                                if (result == DialogResult.Yes)
                                {
                                    flag = "1";
                                    topRowIndex = gridView2.TopRowIndex;
                                    focus = gridView2.FocusedRowHandle;

                                    //pobriši prvo stavke 
                                    veza.ExecuteQuery("delete from prodajnistavka where prodajnicjenik_prc_ID = " + IDcjenik + "");
                                    //pobriši zaglavlje
                                    veza.ExecuteQuery("delete from prodajnicjenik where prc_ID = " + IDcjenik + "");

                                    MessageBox.Show("Uspješno ste izbrisali zapis!");

                                    btnAzuriraj.PerformClick();
                                    btnAzurirajStavke.PerformClick();
                                }
                            }
                            else
                            {
                                //obriši zaglavlje
                                veza.ExecuteQuery("delete from prodajnicjenik where prc_ID = " + IDcjenik + "");
                            }

                            //this.prodajnicjenikAkcijskiTableAdapter.Fill(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 2);
                        }
                    }
                }
                else if (e.KeyCode == Keys.F8)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {

                            IDcjenik = row[0].ToString();
                            string partnerID = row[3].ToString();
                            frmCSVMPCakcija UForm = null;
                            if ((UForm = (frmCSVMPCakcija)IsFormAlreadyOpen(typeof(frmCSVMPCakcija))) == null)
                            {
                                frmCSVMPCakcija _frm = new frmCSVMPCakcija();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.IDcjenika = IDcjenik;
                                _frm.IDpartnera = partnerID;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgCjenici_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (gridView2.SelectedRowsCount > 0)
            //    {
            //        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            //        string IDcjenik = row[0].ToString();
            //        IDcjenika = Convert.ToInt16(IDcjenik);

            //        if (_nivoCjenika == "2")
            //        {
            //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
            //        }
            //        else
            //        {
            //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}            
        }


        private void dgCjenici_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                prodajniAkcijskiStavke.Clear();
            }

            //try
            //{
            //    if (gridView2.DataRowCount > 0)
            //    {
            //        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            //        string IDcjenik = row[0].ToString();
            //        IDcjenika = Convert.ToInt16(IDcjenik);

            //        if (_nivoCjenika == "2")
            //        {
            //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
            //        }
            //        else
            //        {
            //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}            
        }

        private void prodajnicjenikAkcijskiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                prodajniAkcijskiStavke.Clear();
            }
            //try
            //{
            //    if (gridView2.DataRowCount > 0)
            //    {
            //        if (gridView2.SelectedRowsCount > 0)
            //        {
            //            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            //            string IDcjenik = row[0].ToString();
            //            IDcjenika = Convert.ToInt16(IDcjenik);

            //            if (_nivoCjenika == "2")
            //            {
            //                this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
            //            }
            //            else
            //            {
            //                this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}            
        }

        //private void dgCjenici_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    if (gridView2.DataRowCount > 0)
        //    //    {
        //    //        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

        //    //        string IDcjenik = row[0].ToString();
        //    //        IDcjenika = Convert.ToInt16(IDcjenik);

        //    //        if (_nivoCjenika == "2")
        //    //        {
        //    //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
        //    //        }
        //    //        else
        //    //        {
        //    //            this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}           
        //}

        private void dgStavke_KeyUp(object sender, KeyEventArgs e)
        {
            topRowIndex = gridView1.TopRowIndex;
            focus = gridView1.FocusedRowHandle;

            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    if (gridView1.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                        System.Data.DataRow row2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null || row2 != null)
                        {
                            string partner = row2[7].ToString();
                            string partnerID = row2[3].ToString();
                            artikl = row2[0].ToString();
                            string korisnik = row2[9].ToString();
                            string artiklID = row[10].ToString();
                            cjenikID = row2[0].ToString();

                            //if (Global.KorisnikID == korisnik || Global.KorisnikID == "1964")
                            //{
                            //frmAzurirajStavkeProdajnihAkcijskihCjenika _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajStavkeProdajnihAkcijskihCjenika))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajStavkeProdajnihAkcijskihCjenika();
                            //_frm.idPartner = partnerID;
                            //_frm.NazivPartner = partner;
                            //_frm.idProdajniCjenik = cjenikID;
                            //_frm.oznaka = "F4";
                            //_frm.KojiNivo = _nivoCjenika;
                            //_frm.idArtikla = artiklID;
                            //_frm.ShowDialog();

                            frmAzurirajStavkeProdajnihAkcijskihCjenika UForm = null;
                            if ((UForm = (frmAzurirajStavkeProdajnihAkcijskihCjenika)IsFormAlreadyOpen(typeof(frmAzurirajStavkeProdajnihAkcijskihCjenika))) == null)
                            {
                                frmAzurirajStavkeProdajnihAkcijskihCjenika _frm = new frmAzurirajStavkeProdajnihAkcijskihCjenika();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.idPartner = partnerID;
                                _frm.NazivPartner = partner;
                                _frm.idProdajniCjenik = cjenikID;
                                _frm.oznaka = "F4";
                                _frm.KojiNivo = _nivoCjenika;
                                _frm.idArtikla = artiklID;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }
                            //}
                        }
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        System.Data.DataRow row2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        System.Data.DataRow row3 = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        System.Data.DataRow row4 = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                        if (row != null || row2 != null || row3 != null || row4 != null)
                        {
                            cjenikID = row[0].ToString();
                            string partner = row2[7].ToString();
                            string partnerID = row3[3].ToString();
                            artikl = row4[0].ToString();
                            string korisnik = row4[9].ToString();

                            //if (Global.KorisnikID == korisnik || Global.KorisnikID == "1964")
                            //{
                            //frmAzurirajStavkeProdajnihAkcijskihCjenika _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajStavkeProdajnihAkcijskihCjenika))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajStavkeProdajnihAkcijskihCjenika();
                            //_frm.idProdajniCjenik = cjenikID;
                            //_frm.idPartner = partnerID;
                            //_frm.NazivPartner = partner;
                            //_frm.oznaka = "F7";
                            //_frm.KojiNivo = _nivoCjenika;
                            //_frm.ShowDialog();

                            frmAzurirajStavkeProdajnihAkcijskihCjenika UForm = null;
                            if ((UForm = (frmAzurirajStavkeProdajnihAkcijskihCjenika)IsFormAlreadyOpen(typeof(frmAzurirajStavkeProdajnihAkcijskihCjenika))) == null)
                            {
                                frmAzurirajStavkeProdajnihAkcijskihCjenika _frm = new frmAzurirajStavkeProdajnihAkcijskihCjenika();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.idProdajniCjenik = cjenikID;
                                _frm.idPartner = partnerID;
                                _frm.NazivPartner = partner;
                                _frm.oznaka = "F7";
                                _frm.KojiNivo = _nivoCjenika;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }
                            //}
                        }
                    }
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    System.Data.DataRow row2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                    if (row2 != null)
                    {
                        string korisnik = row2[9].ToString();

                        //if (Global.KorisnikID == korisnik || Global.KorisnikID == "1964")
                        //{
                        if (gridView1.RowCount > 0)
                        {

                            DialogResult result;

                            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                            if (row != null || row2 != null)
                            {
                                string idProdajnistavke = row[0].ToString();
                                result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                                if (result == DialogResult.Yes)
                                {
                                    obrisan = 1;
                                    topRowIndex = gridView1.TopRowIndex;
                                    focus = gridView1.FocusedRowHandle;

                                    veza.ExecuteQuery("delete from prodajnistavka where prc_ID = '" + idProdajnistavke + "'");
                                    MessageBox.Show("Uspješno ste izbrisali zapis!");
                                    btnAzurirajStavke.PerformClick();
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        //}
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        //gridView1.ExportToXls(@"c:\Podaci\Podaci.xls");
                        ExcelExport();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (_nivoCjenika == "2")
            {
                this.prodajnicjenikAkcijskiTableAdapter.Fill(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 2);
                //dgCjenici.Focus();
            }
            else
            {
                this.prodajnicjenikAkcijskiTableAdapter.Fill(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 3);
            }

            if (flag == "0")
            {
                gridView2.MoveFirst();
            }
            else
            {
                gridView2.TopRowIndex = topRowIndex;
                gridView2.SelectRow(focus);
            }
            flag = "1";           
        }

        private void btnAzurirajStavke_Click(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount > 0)
            {
                System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    string IDcjenik = row[0].ToString();
                    IDcjenika = Convert.ToInt16(IDcjenik);


                    string datum = Convert.ToDateTime(row[1]).ToString("yyyy-MM-dd");
                    DateTime datumPrije = Convert.ToDateTime(datum).AddDays(-1);

                    DateTime stari = Convert.ToDateTime("1899-12-30");
                    string datumKonacni = datumPrije.ToString("yyyy-MM-dd");

                    /*if (_nivoCjenika == "2")
                    {
                        this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 2);
                    }
                    else
                    {
                        this.prodajnicjenikAkcijskiStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodajnicjenikAkcijskiStavke, IDcjenika, 3);
                    }*/


                    if (_nivoCjenika == "2")
                    {
                        this.prodAkcStavkeTableAdapter.FillBy(this.prodajniAkcijskiStavke.prodAkcStavke, IDcjenika, 2);
                    }
                    else
                    {
                        this.prodAkcStavkeTableAdapter.Fill(this.prodajniAkcijskiStavke.prodAkcStavke, IDcjenika, datumKonacni, stari);
                    }
                }

                if (obrisan == 1)
                {
                    gridView1.TopRowIndex = topRowIndex;
                }
                else
                {
                    gridView1.TopRowIndex = topRowIndex;
                    gridView1.SelectRow(focus);
                }
            }
        }

        private void frmAkcijskiCjenikProdaja_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.F5)
            {
                if (gridView1.RowCount > 0)
                {
                    try
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                        //if (row != null)
                        //{
                            cjenikID = row[0].ToString();

                            string datum = Convert.ToDateTime(row[1]).ToString("yyyy-MM-dd");
                            DateTime datumPrije = Convert.ToDateTime(datum).AddDays(-1);

                            DateTime stari = Convert.ToDateTime("1899-12-30");
                            string datumKonacni = datumPrije.ToString("yyyy-MM-dd");
                            string staridat = "1899-12-30";
                        //}
                        DataTable artikli = new DataTable();
                        //MessageBox.Show("select prodajnicjenik.*,prodajnistavka.*, artikl.ar_sifra, artikl.AR_NAZIV, partner.PA_NAZIV  , x.tipa from prodajnistavka left join prodajnicjenik on prodajnistavka.prodajnicjenik_prc_ID=prodajnicjenik.prc_ID left join artikl on artikl.ar_ID = prodajnistavka.artikl_ar_ID left join robnagrupa on robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID left join operater on  operater.op_ID = robnagrupa.operater_op_ID left outer join partner on prodajnistavka.partner_pa_id = partner.pa_ID left outer join (select  prodajnistavka.artikl_ar_ID, prc_tipa as tipa from prodajnistavka left join prodajnicjenik on prodajnistavka.prodajnicjenik_prc_ID= prodajnicjenik.prc_ID where  prodajnicjenik.prc_aktivan=1 and (" + datumKonacni + " between prodajnicjenik.prc_vaziod and prodajnicjenik.prc_vazido or prc_vazido =" + staridat + ")  group by artikl_ar_id order by prc_nivo desc, prodajnistavka.prc_tipa  asc  )  as x on x.artikl_ar_id=prodajnistavka.artikl_ar_id where prodajnicjenik.prc_ID=" + cjenikID + "");
                        //veza.ExecuteQuery("Select prodajnicjenik.*, partner.pa_naziv, CONCAT( operater.op_ime,' ' ,operater.op_prezime ) , prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV from prodajnistavka, artikl,  prodajnicjenik left outer join partner on prodajnicjenik.partner_PA_ID = partner.pa_ID left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where  prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = "+cjenikID+" and prodajnicjenik.prc_nivo = "+_nivoCjenika+"", ref artikli);
                        //Select prodajnicjenik.* , prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, partner.PA_NAZIV from prodajnicjenik, artikl,  prodajnistavka left outer join partner on prodajnistavka.partner_pa_id = partner.pa_ID  where  prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = 2492 and prodajnicjenik.prc_nivo = 3
                        //veza.ExecuteQuery("Select prodajnicjenik.* , prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, partner.PA_NAZIV from prodajnicjenik, artikl,  prodajnistavka left outer join partner on prodajnistavka.partner_pa_id = partner.pa_ID  where  prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = " + cjenikID + " and prodajnicjenik.prc_nivo = " + _nivoCjenika + "", ref artikli);
                        veza.ExecuteQuery("select prodajnicjenik.*,prodajnistavka.*, artikl.ar_sifra, artikl.AR_NAZIV, partner.PA_NAZIV  , x.tipa from prodajnistavka left join prodajnicjenik on prodajnistavka.prodajnicjenik_prc_ID=prodajnicjenik.prc_ID left join artikl on artikl.ar_ID = prodajnistavka.artikl_ar_ID left join robnagrupa on robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID left join operater on  operater.op_ID = robnagrupa.operater_op_ID left outer join partner on prodajnistavka.partner_pa_id = partner.pa_ID left outer join (select  prodajnistavka.artikl_ar_ID, prc_tipa as tipa from prodajnistavka left join prodajnicjenik on prodajnistavka.prodajnicjenik_prc_ID= prodajnicjenik.prc_ID where  prodajnicjenik.prc_aktivan=1 and ('" + datumKonacni + "' between prodajnicjenik.prc_vaziod and prodajnicjenik.prc_vazido or prc_vazido ='" + staridat + "') and prodajnistavka.prc_aktivna = 1   order by prc_nivo desc, prodajnistavka.prc_tipa  asc  )  as x on x.artikl_ar_id=prodajnistavka.artikl_ar_id where prodajnicjenik.prc_ID=" + cjenikID + " group by artikl_ar_id", ref artikli);
                        
                        if (artikli.Rows.Count > 0)
                        {
                            //create dataset 
                            DataSet FDataSet = new DataSet();
                            artikli.TableName = "Artikli";
                            FDataSet.Tables.Add(artikli);

                            // create report instance
                            Report report = new Report();

                            // load the existing report
                            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                            if (_nivoCjenika == "2")
                            {
                                //komercijala
                                report.Load(baseDir + "/report/AkcijskiCjenik_2.frx");
                            }
                            else
                            {
                                //marketing
                                report.Load(baseDir + "/report/AkcijskiCjenik_3.frx");
                            }
                           

                            // register the dataset
                            report.RegisterData(FDataSet);

                            //dizajn
                            //report.Design();

                            // run the report
                            report.Show();

                            // free resources used by report
                            report.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    //string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    //report1.Load(baseDir + "/report/AkcijskiCjenik.frx");

                    //report1.SetParameterValue("IDNivo", _nivoCjenika);
                    //report1.SetParameterValue("IDCjenik", IDcjenika);

                    ////report1.Load("C:/Users/IvanS/Documents/Visual Studio 2010/Projects/odobrenja_3.3/Report.frx");
                    //report1.Show();
                }
            }
        }
            
        private void ExcelExport()
        {
            var bindingSource = (BindingSource)this.gridView1.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();


            //Export DataTable.
            if (this.gridView1 != null)
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
            }
            else
            {
                MessageBox.Show("Nema podataka za export u excel!", "Error");
                return;
            }

            //Saving the workbook to disk. 
            m_book.write("C:\\Podaci\\Podaci.xls");


            //gridView1.ExportToXls(@"c:\Podaci\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void ckbFiltriraj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiltriraj.Checked)
            {
                try
                {
                    string god = Godina.Value.ToString();

                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime(String.Format("{0}-12-31", god));
                    //this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
                    if (_nivoCjenika == "2")
                    {
                        this.prodajnicjenikAkcijskiTableAdapter.SelectPremaGodini(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 2, prvi, drugi);
                    }
                    else
                    {
                        this.prodajnicjenikAkcijskiTableAdapter.SelectPremaGodini(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 3, prvi, drugi);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //DateTime prvi = Convert.ToDateTime("1999-01-01");
                //DateTime drugi = Convert.ToDateTime("2050-12-31");
                ////this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
            }
        }

        private void Godina_ValueChanged(object sender, EventArgs e)
        {
            if (ckbFiltriraj.Checked)
            {
                try
                {
                    string god = Godina.Value.ToString();

                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime("" + god + "-12-31");
                    if (_nivoCjenika == "2")
                    {
                        this.prodajnicjenikAkcijskiTableAdapter.SelectPremaGodini(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 2, prvi, drugi);
                    }
                    else
                    {
                        this.prodajnicjenikAkcijskiTableAdapter.SelectPremaGodini(this.akcijskiCjenikProdajni.prodajnicjenikAkcijski, 3, prvi, drugi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }



        private void btnProdaja_Click(object sender, EventArgs e)
        {
            //pokupi prodaju po trgovinama
            
            //preiraj string artikala iz akcije sa šiframa
            //selektiraj iz baze mpman tablice promet podatke koji trebaju

            if (gridView1.RowCount > 0)
            {
                string sifre = "";

                 System.Data.DataRow row1 = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                 if (row1 != null)
                 {
                     datumOD = Convert.ToDateTime(row1[1]).ToString("yyyy-MM-dd");
                     datumDO = Convert.ToDateTime(row1[2]).ToString("yyyy-MM-dd");
                 }
                

                for (brojac = 0; brojac < gridView1.RowCount; brojac++)
                {

                    System.Data.DataRow row = gridView1.GetDataRow(brojac);

                    if (row != null)
                    {
                        if (sifre != "")
                        {
                            sifre = sifre + ",";

                        }
                        sifre = sifre + row[10];
                    }
                   
                }

                DataTable podaci = new DataTable();

                veza.ExecuteQuery("select artikl .ar_sifra, artikl.AR_NAZIV, sum(promet.pr_izlaz) as 'izlaz', sum(promet.pr_izlazvr) as 'vrijednost', sum(promet.pr_ruc) as 'RUC' from promet left join artikl on artikl.ar_ID = promet.artikl_ar_id where promet.artikl_ar_ID in ( " + sifre + ") and promet.pr_datumizrade >= '" + datumOD + "' and promet.pr_datumizrade <= '" + datumDO + "' group by 1,2  ", ref podaci);

                //MessageBox.Show("select artikl .ar_sifra, artikl.AR_NAZIV, sum(promet.pr_izlaz) as 'izlaz', sum(promet.pr_izlazvr) as 'vrijednost', sum(promet.pr_ruc) as 'RUC' from promet left join artikl on artikl.ar_ID = promet.artikl_ar_id where promet.artikl_ar_ID in ( " + sifre + ") and promet.pr_datumizrade >= " + datumOD + " and promet.pr_datumizrade <= " + datumDO + "");

                if (podaci.Rows.Count > 0)
                {

                    //export podataka

                    var dataTable = podaci;

                    WorkBook m_book = new WorkBook();


                    //Export DataTable.
                    if (this.gridView1 != null)
                    {
                        m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
                    }
                    else
                    {
                        MessageBox.Show("Nema podataka za export u excel!", "Error");
                        return;
                    }


                    //method 1 to set date value
                    //set cell value with formatted text(mm/dd/yy).
                    //m_book.setEntry(3, 2, "08/08/2009");

                    //method 2 to set date value
                    //set the cell with number value.
                    //m_book.setNumber(3, 2, 40033.0);
                    //formatting the value to date 'yyyy/mm/dd'

                    RangeStyle rs = m_book.getRangeStyle();
                    rs.CustomFormat = "yyyy-mm-dd";
                    m_book.setRangeStyle(rs);



                    //Saving the workbook to disk. 
                    m_book.write("C:\\Podaci\\Podaci.xls");                   
                    

                    //gridView1.ExportToXls(@"c:\Podaci\Podaci.xls");

                    //Message box confirmation to view the created spreadsheet.
                    if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                        System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
                    }
                }
            }
        }
    }   
}
