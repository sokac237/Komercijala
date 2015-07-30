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
    public partial class frmPregledPozicijaZaTrgovinu : Form
    {
        public frmPregledPozicijaZaTrgovinu()
        {
            InitializeComponent();
        }

        private void frmPregledPozicijaZaTrgovinu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.poslovnica.poslovnica);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glPoslovnica.Text != "")
            {
                int poslovnica = Convert.ToInt32(glPoslovnica.EditValue); 
                string datOD =  Convert.ToDateTime(dtpDatumOD.Text).ToString("yyyy-MM-dd");
                DateTime datumOD = Convert.ToDateTime(datOD);
                this.dodatneTrgovinaTableAdapter.Fill(this.dodatnePozicijeZaTrgovinu.DodatneTrgovina, poslovnica,datumOD);
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = dodatnePozicijeZaTrgovinu.DodatneTrgovina.CopyToDataTable();
                    string datOD =  Convert.ToDateTime(dtpDatumOD.Text).ToString("dd-MM-yyyy");
                    string datDO = Convert.ToDateTime(dtpDatumDO.Text).ToString("dd-MM-yyyy");
                    //string skladisteBroj = txtSkladiste.Text;
                    //string brojNarudzbe = txtBrojNarudzbe.Text;


                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    if (gridView2.RowCount > 0)
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

                        report.Load(baseDir + "/report/DogovorenePozicijeTrgovina.frx");
                        report.SetParameterValue("datumod", datOD);
                        report.SetParameterValue("datumdo", datDO);


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
            }
        }

        private void frmPregledPozicijaZaTrgovinu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void ExcelExport()
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
