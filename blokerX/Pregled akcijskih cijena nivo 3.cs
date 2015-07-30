using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartXLS;

namespace blokerX
{
    public partial class frmPregledAkcijskihCijenaNivo3 : Form
    {
        public frmPregledAkcijskihCijenaNivo3()
        {
            InitializeComponent();
        }

        private void frmPregledAkcijskihCijenaNivo3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glDobavljac.Text == "" && ckbSvi.Checked)
            {
                DateTime odKad = Convert.ToDateTime(dtpODkada.Text);
                DateTime doKad = Convert.ToDateTime(dtpDokada.Text);

                this.akcijeskeCijeneNivo3TableAdapter.FillBy(this.akcCijeneNivo3.akcijeskeCijeneNivo3, odKad, doKad);
            }
            else if (glDobavljac.Text != "")
            {
                DateTime odKad = Convert.ToDateTime(dtpODkada.Text);
                DateTime doKad = Convert.ToDateTime(dtpDokada.Text);

                this.akcijeskeCijeneNivo3TableAdapter.Fill(this.akcCijeneNivo3.akcijeskeCijeneNivo3, odKad, doKad, Convert.ToInt32(glDobavljac.EditValue));
            }
        }

        private void frmPregledAkcijskihCijenaNivo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgCjenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    var bindingSource = (BindingSource)this.dgCjenici.DataSource;

                    var dataTable = ((DataView)bindingSource.List).Table;

                    WorkBook m_book = new WorkBook();


                    //Export DataTable.
                    if (this.dgCjenici != null)
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


                    dgCjenici.ExportToExcelOld(@"c:\Podaci\Podaci.xls");

                    //Message box confirmation to view the created spreadsheet.
                    if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                        System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
                    }
                }
            }
        }

        private void glDobavljac_KeyDown(object sender, KeyEventArgs e)
        {
            glDobavljac.EditValue = 0;
        }
    }
}
