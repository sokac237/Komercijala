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
using SmartXLS;

namespace blokerX
{
    public partial class frmPregledProdajnihAkcijskihCijena : Form
    {
        Upiti veza = new Upiti();

        string datumOD;
        string datumDO;

        string nivo;

        string UpitZaJednogDobavljaca;
        string UpitBezDobavljaca;

        public frmPregledProdajnihAkcijskihCijena()
        {
            InitializeComponent();
        }

        private void frmPregledProdajnihAkcijskihCijena_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
        }

        private void btnPrikaziArtikle_Click(object sender, EventArgs e)
        {
            upiti();
            try
            {
                if (glDobavljac.EditValue.ToString() != "" && cmbNivo.Text != "" && ckbBezDobavljaca.Checked == false)
                {
                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                    MySqlCommand comm = new MySqlCommand(UpitZaJednogDobavljaca, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    if (gridView2.RowCount > 0)
                    {
                        pregled_akcijskih_prodajnih_cijena.Clear();
                    }
                    adapter.Fill(pregled_akcijskih_prodajnih_cijena, "Table");
                    dgArtikli.DataSource = pregled_akcijskih_prodajnih_cijena.Tables["Table"];
                    pregledAkcProdCijenaBindingSource = new BindingSource(pregled_akcijskih_prodajnih_cijena, "Table");
                    dgArtikli.DataSource = pregledAkcProdCijenaBindingSource;

                }
                else if (ckbBezDobavljaca.Checked && cmbNivo.Text != "")
                {
                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                    MySqlCommand comm = new MySqlCommand(UpitBezDobavljaca, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    if (gridView2.RowCount > 0)
                    {
                        pregled_akcijskih_prodajnih_cijena.Clear();
                    }
                    adapter.Fill(pregled_akcijskih_prodajnih_cijena, "Table");
                    dgArtikli.DataSource = pregled_akcijskih_prodajnih_cijena.Tables["Table"];
                    pregledAkcProdCijenaBindingSource = new BindingSource(pregled_akcijskih_prodajnih_cijena, "Table");
                    dgArtikli.DataSource = pregledAkcProdCijenaBindingSource;
                }
                else
                {
                    MessageBox.Show("Morate odabrati partnera ili 'bez dobavljača' te nivo.");
                    glDobavljac.Focus();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upiti()
        {
            if (glDobavljac.EditValue.ToString() != "" && cmbNivo.Text != "" && ckbBezDobavljaca.Checked == false)
            {
                nivo = cmbNivo.Text;
                datumOD = Convert.ToDateTime(dtpODkada.Text).ToString("yyyy-MM-dd");
                datumDO = Convert.ToDateTime(dtpDokada.Text).ToString("yyyy-MM-dd");
                //MessageBox.Show("select prodajnicjenik.prc_ID,  prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnicjenik.prc_nivo , partner.pa_naziv, CONCAT(operater.op_ime,' ' ,operater.op_prezime), prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, robnagrupa.RG_NAZIV, robnagrupa.RG_SIFRA from prodajnistavka, artikl, robnagrupa, prodajnicjenik  left outer join partner on prodajnicjenik.partner_PA_ID = partner.pa_ID   left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID and  artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = '" + nivo + "' and prodajnicjenik.partner_PA_ID = " + glDobavljac.EditValue + " and prodajnicjenik.prc_vaziod between '" + datumOD + "' and '" + datumDO + "' and prodajnicjenik.prc_vazido between '" + datumOD + "' and '" + datumDO + "'");
                UpitZaJednogDobavljaca = "select prodajnicjenik.prc_ID,  prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnicjenik.prc_nivo , partner.pa_naziv, CONCAT(operater.op_ime,' ' ,operater.op_prezime), prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, robnagrupa.RG_NAZIV, robnagrupa.RG_SIFRA from  artikl, robnagrupa,prodajnistavka  left outer join partner on prodajnistavka.partner_PA_ID = partner.pa_ID , prodajnicjenik    left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID and  artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = '" + nivo + "' and prodajnistavka.partner_PA_ID = " + glDobavljac.EditValue + " and prodajnicjenik.prc_vaziod between '" + datumOD + "' and '" + datumDO + "' and prodajnicjenik.prc_vazido between '" + datumOD + "' and '" + datumDO + "'";

            }
            else if (ckbBezDobavljaca.Checked && cmbNivo.Text != "")
            {
                nivo = cmbNivo.Text;
                datumOD = Convert.ToDateTime(dtpODkada.Text).ToString("yyyy-MM-dd");
                datumDO = Convert.ToDateTime(dtpDokada.Text).ToString("yyyy-MM-dd");
                //MessageBox.Show("select prodajnicjenik.prc_ID,  prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnicjenik.prc_nivo , partner.pa_naziv, CONCAT(operater.op_ime,' ' ,operater.op_prezime), prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, robnagrupa.RG_NAZIV, robnagrupa.RG_SIFRA from prodajnistavka, artikl, robnagrupa, prodajnicjenik  left outer join partner on prodajnicjenik.partner_PA_ID = partner.pa_ID   left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID and  artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = '" + nivo + "' and prodajnicjenik.prc_vaziod between '2009-09-01' and '2012-09-30' and prodajnicjenik.prc_vazido between '2009-09-01' and '2011-12-30'");
                UpitBezDobavljaca = "select prodajnicjenik.prc_ID,  prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnicjenik.prc_nivo , partner.pa_naziv, CONCAT(operater.op_ime,' ' ,operater.op_prezime), prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV, robnagrupa.RG_NAZIV, robnagrupa.RG_SIFRA from prodajnistavka, artikl, robnagrupa, prodajnicjenik  left outer join partner on prodajnicjenik.partner_PA_ID = partner.pa_ID   left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where robnagrupa.rg_ID = artikl.robnaGrupa_rg_ID and  artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = '"+nivo+"' and prodajnicjenik.prc_vaziod between '"+datumOD+"' and '"+datumDO+"' and prodajnicjenik.prc_vazido between '"+datumOD+"' and '"+datumDO+"'";
            }
        }

        private void frmPregledProdajnihAkcijskihCijena_KeyDown(object sender, KeyEventArgs e)
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
