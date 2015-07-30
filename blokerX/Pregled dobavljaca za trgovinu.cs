using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;

namespace blokerX
{
    public partial class frmPregledDobavljacaPoTrgovinama : DevExpress.XtraEditors.XtraForm
    {
        Upiti veza = new Upiti();
        int DobavljacID;
        public frmPregledDobavljacaPoTrgovinama()
        {
            InitializeComponent();
        }

        private void frmPregledDobavljacaPoTrgovinama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this.poslovnica.poslovnica);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glDobavljac.Text != "")
            {
                if (gridView1.RowCount > 0)
                {
                    dobavljaci_za_trgovinu.Clear();
                    DobavljacID = Convert.ToInt32(glDobavljac.EditValue);
                    this.dobavZaTrgTableAdapter.Fill(this.dobavljaci_za_trgovinu.DobavZaTrg, DobavljacID);
                }
                else
                {
                    DobavljacID = Convert.ToInt32(glDobavljac.EditValue);
                    this.dobavZaTrgTableAdapter.Fill(this.dobavljaci_za_trgovinu.DobavZaTrg, DobavljacID);
                }
            }
            else
            {
                glDobavljac.Focus();
            }
        }

        private void frmPregledDobavljacaPoTrgovinama_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.F5)
            {
                 try
                    {
                        DataTable artikli = new DataTable();

                        veza.ExecuteQuery("select partner.pa_sifra, partner.pa_naziv, poslovnica.po_naziv from dobavljacposlovnica, partner, poslovnica where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and dobavljacposlovnica.partner_pa_ID = partner.pa_ID and dobavljacposlovnica.poslovnica_po_ID = "+glDobavljac.EditValue+" order by partner.pa_naziv", ref artikli);

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

                            report.Load(baseDir + "/report/dobavljac_trgovina.frx");

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
                //string IDposlovnica = glDobavljac.EditValue.ToString();

                //System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                //string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                //report1.Load(baseDir + "/report/dobavljac_trgovina.frx");

                //report1.SetParameterValue("poslovnicaID", IDposlovnica);
                ////report1.Load("C:/Users/IvanS/Documents/Visual Studio 2010/Projects/odobrenja_3.3/Report.frx");
                //report1.Show();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}