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
    public partial class frmPregledAkcija : Form
    {
        public static Button refresh = new Button();

        public frmPregledAkcija()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPregledAkcija_KeyDown(object sender, KeyEventArgs e)
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

        private void ExcelExportgridView()
        {
            var bindingSource = (BindingSource)this.dgAkcija.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.dgAkcija != null)
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

            //dgAkcija.ExportToXls("c:\\Podaci\\Podaci.xls");

            dgAkcija.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgAkcija..ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }       

        private void frmPregledAkcija_Load(object sender, EventArgs e)
        {
            refresh = btnRefresh;
            // TODO: This line of code loads data into the 'pregled_akcija.Akcije' table. You can move, or remove it, as needed.
            this.akcijeTableAdapter.Fill(this.pregled_akcija.Akcije);
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

        private void dgAkcije_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    if (dgAkcija.RowCount > 0)
                    {
                        System.Data.DataRow row = dgAkcija.GetDataRow(dgAkcija.FocusedRowHandle);
                        if (row != null)
                        {
                            if (row[9].ToString() != "16")
                            {
                                frmNovaAkcija UForm = null;
                                if ((UForm = (frmNovaAkcija)IsFormAlreadyOpen(typeof(frmNovaAkcija))) == null)
                                {
                                    frmNovaAkcija _frm = new frmNovaAkcija();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.oznaka = "A";
                                    _frm.akcijaID = row[0].ToString();
                                    _frm.akcijaBroj = row[1].ToString();
                                    _frm.sifraAkcije = row[9].ToString();
                                    _frm.Show();
                                }
                                else
                                {
                                    UForm.Focus();
                                    return;
                                }
                            }
                            else
                            {

                                frmSnizenjaOdDobavljaca UForm = null;
                                if ((UForm = (frmSnizenjaOdDobavljaca)IsFormAlreadyOpen(typeof(frmSnizenjaOdDobavljaca))) == null)
                                {
                                    frmSnizenjaOdDobavljaca _frm = new frmSnizenjaOdDobavljaca();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.akcijaID = row[0].ToString();
                                    _frm.oznaka = "F4";
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
                        MessageBox.Show("Nemate niti jedna akcija koju biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    frmNovaAkcija UForm = null;
                    if ((UForm = (frmNovaAkcija)IsFormAlreadyOpen(typeof(frmNovaAkcija))) == null)
                    {
                        frmNovaAkcija _frm = new frmNovaAkcija();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.oznaka = "I";
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
                    System.Data.DataRow row = dgAkcija.GetDataRow(dgAkcija.FocusedRowHandle);
                    if (row != null)
                    {
                        string brojAkcije = row[1].ToString();

                        this.poslovnicaTableAdapter.PoslanaAkcija(this.pregled_akcija.poslovnica, brojAkcije);
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    if (dgAkcija.RowCount > 0)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            //GetVisibleRowsAsTable(gratis);

                            ExcelExportgridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.akcijeTableAdapter.Fill(this.pregled_akcija.Akcije);
        }
    }
}
