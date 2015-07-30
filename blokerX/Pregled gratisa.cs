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
using DevExpress.XtraGrid.Views.Grid;
using blokirajx;

namespace blokerX
{
    public partial class frmPregledGratisa : Form
    {
        DataTable table = new DataTable();
        Upiti veza = new Upiti();
        int nivo;
        public frmPregledGratisa()
        {
            InitializeComponent();
        }


        public void PravaOperatera()
        {
            try
            {
                DataTable operater = new DataTable();
                
                string id = Global.KorisnikID;

                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref operater);
      
                nivo = Convert.ToInt16(operater.Rows[0][0]);

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PravaOperatera();

            string datOD = Convert.ToDateTime(dtpOD.Text).ToString("yyyy-MM-dd");
            string datDO = Convert.ToDateTime(dtpDO.Text).ToString("yyyy-MM-dd");
            DateTime datumDO = Convert.ToDateTime(datDO);
            DateTime datumOD = Convert.ToDateTime(datOD);

            //od 1.1.2014-30.09.2014 svi nivoi vide sve.
            //Od 01.10.2014 pa dalje nivo 9 vidi sve, a sve ispod tog nivoa vidi sve osim akcije.


            //ako je datum_do veci ili jednak od 1.10.2014 onda nivo  9 vidi sve, a ispod vidi sve osim akcije
            
            string datum2 = "2014-10-01"; 
            if (DateTime.Parse(datOD) < DateTime.Parse(datum2) && DateTime.Parse(datDO) >= DateTime.Parse(datum2) && nivo < 9)
            {
                lblUpozorenje.Text = "Podaci neće biti ispravni za odabrano razdoblje, pretražujte podatke do 30.9.2014 ili od 1.10.2014, za detalje kontaktirajte Sanju Mijoković";
            }
            else
            {
                lblUpozorenje.Text = "";
            }

            if (DateTime.Parse(datDO) >= DateTime.Parse(datum2))
            {
                if (nivo == 9)
                {
                    this.pregledGratisTableAdapter.Fill(this.pregled_gratisa.PregledGratis, datumOD, datumDO);
                }
                else
                {
                    this.pregledGratisTableAdapter.FillNivo9(this.pregled_gratisa.PregledGratis, datumOD, datumDO);
                }
            }
            else if (DateTime.Parse(datDO) < DateTime.Parse(datum2))
            {
                //ako je datum manji ili jednak 30.9.2014 svi vide sve
                this.pregledGratisTableAdapter.Fill(this.pregled_gratisa.PregledGratis, datumOD, datumDO);

            }
            
        }

        private void frmPregledGratisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (gratis.RowCount > 0)
            {
                if (e.KeyCode == Keys.F5)
                {
                    try
                    {
                        DataTable gratisi = new DataTable();
                        string datumOD = Convert.ToDateTime(dtpOD.Text).ToString("yyyy-MM-dd");
                        string datumDO = Convert.ToDateTime(dtpDO.Text).ToString("yyyy-MM-dd");

                        //MessageBox.Show("Select poslovnica.po_sifra, poslovnica.po_naziv, sum(gratis.gr_nabavnavrijednost ) as 'nabavna vrijednost', sum(gratis.gr_prodajnavrijednost) as 'pordajna vrijednost' from gratis join poslovnica on poslovnica.po_id=gratis.poslovnica_PO_ID where gr_datum between '"+datumOD+"' and '"+datumDO+"' group by gratis.poslovnica_PO_ID");
                        veza.ExecuteQuery("Select poslovnica.po_sifra, poslovnica.po_naziv, sum(gratis.gr_nabavnavrijednost ) as 'nabavna vrijednost', sum(gratis.gr_prodajnavrijednost) as 'pordajna vrijednost' from gratis join poslovnica on poslovnica.po_id=gratis.poslovnica_PO_ID where gr_datum between '"+datumOD+"' and '"+datumDO+"' group by gratis.poslovnica_PO_ID", ref gratisi);

                        if (gratisi.Rows.Count > 0)
                        {
                            string datOD = Convert.ToDateTime(dtpOD.Text).ToString("dd.MM.yyyy");
                            string datDO = Convert.ToDateTime(dtpDO.Text).ToString("dd.MM.yyyy");
                            //create dataset 
                            DataSet FDataSet = new DataSet();
                            gratisi.TableName = "Artikli";
                            FDataSet.Tables.Add(gratisi);

                            // create report instance
                            Report report = new Report();

                            // load the existing report
                            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                            string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                            report.Load(baseDir + "/report/TotalGratis.frx");

                            report.SetParameterValue("datumOD", datOD);
                            report.SetParameterValue("datumDO", datDO);

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
                else if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void btnPrebaciUExcel_Click(object sender, EventArgs e)
        {
            if (gratis.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {                    
                    //GetVisibleRowsAsTable(gratis);
                    ExcelExport();                    
                }
            }
        }
             
        private void ExcelExport()
        {
            var bindingSource = (BindingSource)this.dgGratis.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;
            
            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.dgGratis != null)
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

            //dgGratis.ExportToXls("c:\\Podaci\\Podaci.xls");

            dgGratis.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgGratis.ExportToXlsx("c:\\Podaci\\Podaci.xls");
       
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }
       
    }
}
