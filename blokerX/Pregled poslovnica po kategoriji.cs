using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmPregledPoslovnicaPoKategoriji : Form
    {
        Upiti veza = new Upiti();
        DataTable operater = new DataTable();
        int operater_nivo_dozvoljava;
        string IDPoslovnice;
        int brojac;
        string upit;
        string TipTrg;

        public static Button azuriraj = new Button();


        public frmPregledPoslovnicaPoKategoriji()
        {
            InitializeComponent();
        }

        private void Pregled_poslovnica_po_kategoriji_Load(object sender, EventArgs e)
        {
            azuriraj = btnAzurirajPregledPoslovnicaPoKategoriji;
            // TODO: This line of code loads data into the 'poslovnicePoKategoriji._PoslovnicePoKategoriji' table. You can move, or remove it, as needed.
            this.poslovnicePoKategorijiTableAdapter.Fill(this.poslovnicePoKategoriji._PoslovnicePoKategoriji);
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

        private void Pregledaj()
        {
            if (gridView2.RowCount > 0)
            {
                for (brojac = 0; brojac < gridView2.RowCount; brojac++)
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    IDPoslovnice = row[5].ToString();

                    if (row[3].ToString() != "")
                    {

                    }
                }                
            }
        }

        private void dgAkcijskiNabavniCjenici_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string id = Global.KorisnikID;
                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref operater);
                int nivo = Convert.ToInt16(operater.Rows[0][0]);

                if (nivo >= 4)
                {
                    operater_nivo_dozvoljava = 1;
                }

                if (e.KeyCode == Keys.F4)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        IDPoslovnice = row[5].ToString();

                        if (operater_nivo_dozvoljava == 1)
                        {
                            frmAzurirajPoslovnicePoKategoriji _frm;
                            foreach (Form childForm in this.MdiChildren)
                            {
                                if (childForm.GetType() == typeof(frmAzurirajPoslovnicePoKategoriji))
                                {
                                    childForm.Focus();
                                    return;
                                }
                            }
                            _frm = new frmAzurirajPoslovnicePoKategoriji();
                            _frm.IDPoslovnice = IDPoslovnice;
                            _frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Odaberite poslovnicu!");
                    }
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

        private void btnAzurirajPregledPoslovnicaPoKategoriji_Click(object sender, EventArgs e)
        {
            this.poslovnicePoKategorijiTableAdapter.Fill(this.poslovnicePoKategoriji._PoslovnicePoKategoriji);
        }

        private void frmPregledPoslovnicaPoKategoriji_KeyDown(object sender, KeyEventArgs e)
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

        private void btnUkupno_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.RowCount > 0)
                {
                    try
                    {
                        DataTable artikli = new DataTable();
                        veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

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

                            report.Load(baseDir + "/report/PoslovnicePremaKategoriji.frx");

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsortimanCjenik_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

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

                        report.Load(baseDir + "/report/ListaAsortimanCjenik.frx");

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

        private void button1_Click(object sender, EventArgs e)
        {
            if ( gridView2.RowCount > 0)
            {
                try
                {
                    string value = "A";
                    if (InputBox.Input("Upišite grupu", "Za trgovine pod oznakom:", ref value) == DialogResult.OK)
                    {
                        TipTrg = value;
                    }
                    else
                    {
                        return;
                    }

                    if (TipTrg == "A")
                    {
                        upit = "A";
                    }
                    else if (TipTrg == "B")
                    {
                        upit = "B";
                    }
                    else if (TipTrg == "C")
                    {
                        upit = "C";
                    }
                    else if (TipTrg == "D")
                    {
                        upit = "D";
                    }
                    else if (TipTrg == "X")
                    {
                        upit = "X";
                    }


                    DataTable artikli = new DataTable();
                    //MessageBox.Show("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and ( poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '')  and poslovnica.po_asortiman = '" + upit + "' order by poslovnica.po_sifra asc");
                    veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '')  and poslovnica.po_asortiman = '" + upit + "' order by poslovnica.po_sifra asc", ref artikli);

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

                        report.Load(baseDir + "/report/PoslovniceZaGrupaTrgovina.frx");

                        // register the dataset
                        report.RegisterData(FDataSet);
                        report.SetParameterValue("TipTrg", TipTrg);

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
    }
}
