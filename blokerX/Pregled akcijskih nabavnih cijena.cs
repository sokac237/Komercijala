using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmPregledAkcijskihNabavnihCijena : Form
    {
        Upiti veza = new Upiti();
        int brojac;

        public frmPregledAkcijskihNabavnihCijena()
        {
            InitializeComponent();
        }

        private void frmPregledAkcijskihNabavnihCijena_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);

        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            if ( dgRG.Rows.Count > 0)
            {
                pregled_akcijskih_nabavnih_cijena.Clear();
                rGDobavljac.Clear();
                ckbSveGrupe.Checked = false;

                int a = Convert.ToInt16(glDobavljac.EditValue);
                this.robnaGrupa_za_dobavljacaTableAdapter.Fill(this.rGDobavljac.robnaGrupa_za_dobavljaca, a);
            }
            else
            {
                int a = Convert.ToInt16(glDobavljac.EditValue);
                this.robnaGrupa_za_dobavljacaTableAdapter.Fill(this.rGDobavljac.robnaGrupa_za_dobavljaca, a);
            }
        }

        private void ckbSveGrupe_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSveGrupe.Checked)
            {
                for (brojac = 0; brojac < dgRG.Rows.Count; brojac++)
                {
                    dgRG.Rows[brojac].Cells["odabir"].Value = "True";
                }
            }
            else
            {
                for (brojac = 0; brojac < dgRG.Rows.Count; brojac++)
                {
                    dgRG.Rows[brojac].Cells["odabir"].Value = "False";
                }
            }
        }

        private void dgRG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRG.CurrentRow.Cells["odabir"].Value == null)
            {
                dgRG.CurrentRow.Cells["odabir"].Value = "True";
            }
            else if (dgRG.CurrentRow.Cells["odabir"].Value.ToString() == "True")
            {
                dgRG.CurrentRow.Cells["odabir"].Value = "False";
            }
            else
            {
                dgRG.CurrentRow.Cells["odabir"].Value = "True";
            }
        }

        private void btnPrikaziArtikle_Click(object sender, EventArgs e)
        {
            if (dgRG.Rows.Count > 0)
            {
                try
                {
                    string robneGrupe = "";

                    for (brojac = 0; brojac < dgRG.Rows.Count; brojac++)
                    {

                        if (dgRG.Rows[brojac].Cells["odabir"].Value == null)
                        {
                            //
                        }
                        else
                        {
                            if (dgRG.Rows[brojac].Cells["odabir"].Value.ToString() == "True")
                            {
                                if (robneGrupe != "")
                                {
                                    robneGrupe = robneGrupe + ",";
                                }
                                robneGrupe = robneGrupe + dgRG.Rows[brojac].Cells[0].Value.ToString();
                            }
                        }
                    }

                    if (glDobavljac.EditValue.ToString() != "" && robneGrupe.ToString() != "")
                    {
                        string datumOD = Convert.ToDateTime(dtpODkada.Text).ToString("yyyy-MM-dd");
                        string datumDO = Convert.ToDateTime(dtpDokada.Text).ToString("yyyy-MM-dd");

                        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                        MySqlCommand comm = new MySqlCommand("select nabavnistavka.*, artikl.ar_sifra , ar_naziv, CONCAT(operater.op_ime,' ' ,operater.op_prezime), nabavnicjenik.nac_vaziod, nabavnicjenik.nac_vazido, dobavljacartikl.doa_skladiste, dobavljacartikl.doa_nabcij from nabavnicjenik , partner, artikl left outer join dobavljacartikl on artikl.ar_ID = dobavljacartikl.artikl_ar_ID , nabavnistavka left outer join operater on nabavnistavka.operater_op_ID = operater.op_ID where nabavnicjenik.nac_ID = nabavnistavka.nabavniCjenik_nac_ID and artikl.ar_ID = nabavnistavka.artikl_ar_ID  and nabavnistavka.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + ")) and nabavnicjenik.nac_vazido is not null and nabavnicjenik.nac_vaziod between '" + datumOD + "'  and '" + datumDO + "' and nabavnicjenik.nac_vazido between '" + datumOD + "'  and '" + datumDO + "'  and nabavnicjenik.partneri_PA_ID = partner.PA_ID and partner.PA_ID= " + glDobavljac.EditValue + "", conn);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                        if (dgArtikli.Rows.Count > 0)
                        {
                            pregled_akcijskih_nabavnih_cijena.Clear();
                        }

                        adapter.Fill(pregled_akcijskih_nabavnih_cijena, "Table");
                        dgArtikli.DataSource = pregled_akcijskih_nabavnih_cijena.Tables["Table"];
                        pregledAkcNabCijenaBindingSource = new BindingSource(pregled_akcijskih_nabavnih_cijena, "Table");
                        dgArtikli.DataSource = pregledAkcNabCijenaBindingSource;
                    }
                    else
                    {
                        MessageBox.Show("Odaberite dobavljača i robnu grupu!");
                        glDobavljac.Focus();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Odaberite robnu grupu!");
            }
        }

        private void ExcelExport()
        {

            var bindingSource = (BindingSource)this.dgArtikli.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.dgArtikli != null)
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

        private void frmPregledAkcijskihNabavnihCijena_KeyDown(object sender, KeyEventArgs e)
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

        private void btnListaUkupno_Click(object sender, EventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = pregled_akcijskih_nabavnih_cijena.Tables["Table"].Copy();
                    string partner = glDobavljac.Text;
                    string datumOD = Convert.ToDateTime(dtpODkada.Text).ToString("dd-MM-yyyy");
                    string datumDO = Convert.ToDateTime(dtpDokada.Text).ToString("dd-MM-yyyy");

                    //pregled_akcijskih_nabavnih_cijena.PregledAkcNabCijena.Copy();
                    //pregled_akcijskih_nabavnih_cijena.PregledAkcNabCijena.CopyToDataTable(artikli,LoadOption.Upsert);

                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    if (dgArtikli.Rows.Count > 0)
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

                        report.Load(baseDir + "/report/PregledAkcNabCijena.frx");

                        // register the dataset
                        report.RegisterData(FDataSet);
                        report.SetParameterValue("Partner", partner);
                        report.SetParameterValue("DatumOD", datumOD);
                        report.SetParameterValue("DatumDO", datumDO);

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
