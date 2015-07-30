using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmPoslovniceUKojeIdeDobavljac : Form
    {
        Upiti veza = new Upiti();
        int DobavljacID;

        public frmPoslovniceUKojeIdeDobavljac()
        {
            InitializeComponent();
        }

        private void frmPoslovniceUKojeIdeDobavljac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glDobavljac.Text != "")
            {
                if (gridView1.RowCount > 0)
                {
                    poslovnice_u_koje_ide_dobavljac.Clear();
                    DobavljacID = Convert.ToInt32(glDobavljac.EditValue);
                    this.poslUKojuIdeDobavljacTableAdapter.Fill(this.poslovnice_u_koje_ide_dobavljac.PoslUKojuIdeDobavljac, DobavljacID);
                }
                else
                {
                    DobavljacID = Convert.ToInt32(glDobavljac.EditValue);
                    this.poslUKojuIdeDobavljacTableAdapter.Fill(this.poslovnice_u_koje_ide_dobavljac.PoslUKojuIdeDobavljac, DobavljacID);
                }
            }
            else
            {
                glDobavljac.Focus();
            }
        }

        private void frmPoslovniceUKojeIdeDobavljac_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    try
                    {
                        DataTable artikli = new DataTable();

                        veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman, partner.pa_naziv from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = "+glDobavljac.EditValue+" and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_asortiman", ref artikli);

                        if (gridView1.RowCount > 0)
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

                            report.Load(baseDir + "/report/poslovnice_dobavljac.frx");

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

                    //string IDpartnera = glDobavljac.EditValue.ToString();

                    //System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    //string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    //report1.Load(baseDir + "/report/poslovnice_dobavljac.frx");

                    //report1.SetParameterValue("IDpartnera", IDpartnera);
                    ////report1.Load("C:/Users/IvanS/Documents/Visual Studio 2010/Projects/odobrenja_3.3/Report.frx");
                    //report1.Show();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                else if (e.KeyCode == Keys.F9)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        ExcelExport();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }
    }
}
