using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using SmartXLS;

namespace blokerX
{
    public partial class frmStalniNabavniCjenik : Form
    {
        int topRowIndex;
        int focus;

        Upiti veza = new Upiti();

        DataTable data = new DataTable();

        public static Button azurirajCjenik = new Button();

        public static Button azurirajStavke = new Button();

        int IDcjenika;

        string idCjenika;

        string idCjenikStavke;

        string idArtikl;

        string idDobavljac;

        int operater_nivo_dozvoljava;

        string oznaka; //0 - insert novi , ako je 1 - onda update

        public frmStalniNabavniCjenik()
        {
            InitializeComponent();
        }

        private void ExcelExportgridView2()
        {
            var bindingSource = (BindingSource)this.gridView2.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.gridView2 != null)
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
            }
            else
            {
                MessageBox.Show("Nema podataka za export u excel!", "Error");
                return;
            }

            //Saving the workbook to disk. 
            //m_book.write("C:\\Podaci\\Podaci.xls");

            //gridView2.ExportToXls("c:\\Podaci\\Podaci.xls");

            gridView2.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgGratis.ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }


        private void ExcelExportgridView1()
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
            //m_book.write("C:\\Podaci\\Podaci.xls");

            //gridView1.ExportToXls("c:\\Podaci\\Podaci.xls");

            gridView1.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgGratis.ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }       

        private void Stalni_nabavni_cjenik_Load(object sender, EventArgs e)
        {
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            glDobavljac.Focus();
            azurirajCjenik = btnAzurirajCjenik;
            azurirajStavke = btnAzurirajStavke;
        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                stalniNabavniCjenik.Clear();
                stalniNabavniCjenikStavke.Clear();

                int idDobavljaca = Convert.ToInt16(glDobavljac.EditValue);
                this.nabavnicjenikTableAdapter.Fill(this.stalniNabavniCjenik.nabavnicjenik, idDobavljaca);
            }
            else
            {
                int idDobavljaca = Convert.ToInt16(glDobavljac.EditValue);
                this.nabavnicjenikTableAdapter.Fill(this.stalniNabavniCjenik.nabavnicjenik, idDobavljaca);
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
            try
            {
                topRowIndex = gridView2.TopRowIndex;
                focus = gridView2.FocusedRowHandle;

                string id = Global.KorisnikID;

                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref data);
                int nivo = Convert.ToInt16(data.Rows[0][0]);

                if (nivo >= 4)
                {
                    operater_nivo_dozvoljava = 1;
                }


                if (e.KeyCode == Keys.F4)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {
                            idCjenika = row[0].ToString();

                            if (operater_nivo_dozvoljava == 1)
                            {
                                //frmAzurirajStalniNabavniCjenik _frm;
                                //foreach (Form childForm in this.MdiChildren)
                                //{
                                //    if (childForm.GetType() == typeof(frmAzurirajStalniNabavniCjenik))
                                //    {
                                //        childForm.Focus();
                                //        return;
                                //    }
                                //}
                                //_frm = new frmAzurirajStalniNabavniCjenik();
                                //_frm.idCjenika = idCjenika;
                                //_frm.ShowDialog();

                                frmAzurirajStalniNabavniCjenik UForm = null;
                                if ((UForm = (frmAzurirajStalniNabavniCjenik)IsFormAlreadyOpen(typeof(frmAzurirajStalniNabavniCjenik))) == null)
                                {
                                    frmAzurirajStalniNabavniCjenik _frm = new frmAzurirajStalniNabavniCjenik();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.idCjenika = idCjenika;
                                    _frm.PartnerID = glDobavljac.EditValue.ToString();
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
                    else
                    {
                        MessageBox.Show("Nemate niti jedan cjenik koji biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    oznaka = "0"; 
                    idCjenika = "0";

                    //frmAzurirajStalniNabavniCjenik _frm;
                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzurirajStalniNabavniCjenik))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_frm = new frmAzurirajStalniNabavniCjenik();
                    //_frm.idCjenika = idCjenika ;
                    //_frm.ShowDialog();

                    frmAzurirajStalniNabavniCjenik UForm = null;
                    if ((UForm = (frmAzurirajStalniNabavniCjenik)IsFormAlreadyOpen(typeof(frmAzurirajStalniNabavniCjenik))) == null)
                    {
                        frmAzurirajStalniNabavniCjenik _frm = new frmAzurirajStalniNabavniCjenik();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.idCjenika = idCjenika;
                        _frm.PartnerID = glDobavljac.EditValue.ToString();
                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        string sifra = dohvati.DohvatiIDSifra("pa_sifra", "partner", "pa_ID = '" + glDobavljac.EditValue.ToString() + "'");
                        _frm.PartnerSifra = sifra;
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
                                int idpartnera = Convert.ToInt16(glDobavljac.EditValue);
                                this.nabavnistavkaTableAdapter.Fill(this.stalniNabavniCjenikStavke.nabavnistavka, idpartnera, IDcjenika);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    if (gridView2.RowCount > 0)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            //GetVisibleRowsAsTable(gratis);

                            ExcelExportgridView2();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void nabavnicjenikBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                stalniNabavniCjenikStavke.Clear();
            }
        }

        private void dgCjenici_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                stalniNabavniCjenikStavke.Clear();
            }
        }

        private void btnAzurirajCjenik_Click(object sender, EventArgs e)
        {
            if(glDobavljac.Text != "")
            {
                int idDobavljaca = Convert.ToInt16(glDobavljac.EditValue);
                this.nabavnicjenikTableAdapter.Fill(this.stalniNabavniCjenik.nabavnicjenik, idDobavljaca);
               
                if (oznaka == "0")
                {
                    gridView2.MoveLast();
                }
                else
                {
                    gridView2.TopRowIndex = topRowIndex;
                    gridView2.SelectRow(focus);
                }
                oznaka = "1";
            }           
        }

        private void dgStavke_KeyUp(object sender, KeyEventArgs e)
        {
            topRowIndex = gridView1.TopRowIndex;
            focus = gridView1.FocusedRowHandle;

            try
            {
                string id = Global.KorisnikID;

                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref data);
                int nivo = Convert.ToInt16(data.Rows[0][0]);

                if (nivo >= 4)
                {
                    operater_nivo_dozvoljava = 1;
                }

                if (e.KeyCode == Keys.F4)
                {
                    if (gridView1.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        System.Data.DataRow row1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                        if (row != null || row1 != null)
                        {
                            idCjenika = row[0].ToString();
                           
                            idCjenikStavke = row1[0].ToString();

                            idArtikl = row1[2].ToString();

                            idDobavljac = row[6].ToString();

                            if (operater_nivo_dozvoljava == 1)
                            {
                                //frmAzurirajStalniNabavniCjenikStavke _frm;
                                //foreach (Form childForm in this.MdiChildren)
                                //{
                                //    if (childForm.GetType() == typeof(frmAzurirajStalniNabavniCjenikStavke))
                                //    {
                                //        childForm.Focus();
                                //        return;
                                //    }
                                //}
                                //_frm = new frmAzurirajStalniNabavniCjenikStavke();
                                //_frm.idCjenika = idCjenika;
                                //_frm.ArtiklID = idArtikl;
                                //_frm.idCjenikaStavke = idCjenikStavke;
                                //_frm.ShowDialog();

                                frmAzurirajStalniNabavniCjenikStavke UForm = null;
                                if ((UForm = (frmAzurirajStalniNabavniCjenikStavke)IsFormAlreadyOpen(typeof(frmAzurirajStalniNabavniCjenikStavke))) == null)
                                {
                                    frmAzurirajStalniNabavniCjenikStavke _frm = new frmAzurirajStalniNabavniCjenikStavke();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.idCjenika = idCjenika;
                                    _frm.ArtiklID = idArtikl;
                                    _frm.idCjenikaStavke = idCjenikStavke;
                                    _frm.DobavljacID = idDobavljac;
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
                    else
                    {
                        MessageBox.Show("Nemate niti jednu stavku koju biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    oznaka = "0";

                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        System.Data.DataRow row1 = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                        if (row != null || row1 != null)
                        {
                            idDobavljac = row[6].ToString();
                            
                            idCjenika = row1[0].ToString();

                            //frmAzurirajStalniNabavniCjenikStavke _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajStalniNabavniCjenikStavke))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajStalniNabavniCjenikStavke();
                            //_frm.idCjenika = idCjenika;
                            //_frm.oznaka = oznaka;
                            //_frm.DobavljacID = idDobavljac;
                            //_frm.ShowDialog();


                            frmAzurirajStalniNabavniCjenikStavke UForm = null;
                            if ((UForm = (frmAzurirajStalniNabavniCjenikStavke)IsFormAlreadyOpen(typeof(frmAzurirajStalniNabavniCjenikStavke))) == null)
                            {
                                frmAzurirajStalniNabavniCjenikStavke _frm = new frmAzurirajStalniNabavniCjenikStavke();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.idCjenika = idCjenika;
                                _frm.oznaka = oznaka;
                                _frm.DobavljacID = idDobavljac;
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
                else if (e.KeyCode == Keys.Delete)
                {
                    try
                    {
                        if (gridView1.RowCount > 0)
                        {
                            DialogResult result;
                            result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            System.Data.DataRow row1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                            if (row1 != null)
                            {
                                idCjenikStavke = row1[0].ToString();
                                if (result == DialogResult.Yes)
                                {
                                    veza.ExecuteQuery("delete from nabavnistavka where nas_ID = '" + idCjenikStavke + "'");
                                    MessageBox.Show("Uspješno ste obrisali zapis.");
                                    btnAzurirajStavke.PerformClick();
                                }
                            }
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    if (gridView2.RowCount > 0)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            //GetVisibleRowsAsTable(gratis);

                            ExcelExportgridView1();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void btnAzurirajStavke_Click(object sender, EventArgs e)
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
                        int idpartnera = Convert.ToInt16(glDobavljac.EditValue);
                        this.nabavnistavkaTableAdapter.Fill(this.stalniNabavniCjenikStavke.nabavnistavka, idpartnera, IDcjenika);
                    }
                    gridView1.TopRowIndex = topRowIndex;
                    gridView1.SelectRow(focus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmStalniNabavniCjenik_KeyDown(object sender, KeyEventArgs e)
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
