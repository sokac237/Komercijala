using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmStavkeStareNarudzbe : Form
    {
        Upiti veza = new Upiti();

        string _naruID;
        string _skladSifra;
        string _brojNaru;
        string _trgSifra;
        string _trgNaziv;

        public frmStavkeStareNarudzbe()
        {
            InitializeComponent();
        }

        public string NarudzbaID
        {
            get { return _naruID; }
            set { _naruID = value; }
        }

        public string SkladisteSifra
        {
            get { return _skladSifra; }
            set { _skladSifra = value; }
        }

        public string BrojNarudzbe
        {
            get { return _brojNaru; }
            set { _brojNaru = value; }
        }
        public string trgovinaSifra
        {
            get { return _trgSifra; }
            set { _trgSifra = value; }
        }

        public string trgovinaNaziv
        {
            get { return _trgNaziv; }
            set { _trgNaziv = value; }
        }

        private void frmStavkeStareNarudzbe_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                if (_naruID != "")
                {
                    int IDnarudzbe = Convert.ToInt32(_naruID);
                    this.narudzbaStavkaStareTableAdapter.Fill(this.narudzbaStavkaStare._NarudzbaStavkaStare, IDnarudzbe);

                    txtBrojNarudzbe.Text = _brojNaru;
                    txtNazivTrgovine.Text = _trgNaziv;
                    txtSifraTrgovine.Text = _trgSifra;
                    txtSkladiste.Text = _skladSifra;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgStavkeNarudzbe_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string NemaRobe = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ar_nenarucuj"]);

                if (NemaRobe == "Checked")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if (dgStavkeNarudzbe.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = narudzbaStavkaStare._NarudzbaStavkaStare.CopyToDataTable();
                    string skladisteBroj = txtSkladiste.Text;
                    string brojNarudzbe = txtBrojNarudzbe.Text;
                    string trgovina = txtNazivTrgovine.Text;
                    string trgovinasifra = txtSifraTrgovine.Text;

                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    if (dgStavkeNarudzbe.RowCount > 0)
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

                        report.Load(baseDir + "/report/StavkePotvrdjeneNarudzbe.frx");
                        report.SetParameterValue("skladiste", skladisteBroj);
                        report.SetParameterValue("narudzba", brojNarudzbe);
                        report.SetParameterValue("trgovina", trgovina);
                        report.SetParameterValue("sifratrgovina", trgovinasifra);

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

        private void frmStavkeStareNarudzbe_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcelExportgridView()
        {
            var bindingSource = (BindingSource)this.dgStavke.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.dgStavke != null)
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

            dgStavke.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgAkcija..ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void dgStavke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;

                result = MessageBox.Show("Želite prijenos u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    ExcelExportgridView();
                }
            }
        }     
    }
}
