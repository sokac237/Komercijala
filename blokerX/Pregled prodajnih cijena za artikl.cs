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
    public partial class frmPregledProdajnihCijenaZaArtikl : Form
    {
        Upiti veza = new Upiti();

        string IDartikla;

        public frmPregledProdajnihCijenaZaArtikl()
        {
            InitializeComponent();
        }

        private void frmPregledProdajnihCijenaZaArtikl_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void txtSifraArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmSifarnikArtikala _frm = new frmSifarnikArtikala();

                    if (_frm.ShowDialog() == DialogResult.OK)
                    {
                        txtSifraArtikla.Text = _frm.ArtiklSifra;
                        IDartikla = _frm.id_artikl;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtSifraArtikla_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSifraArtikla_TextChanged(object sender, EventArgs e)
        {
            DataTable bar = new DataTable();
            if (txtSifraArtikla.Text != "")
            {
                veza.ExecuteQuery("select ar_naziv from artikl where ar_sifra = '" + txtSifraArtikla.Text + "'", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblNaziv.Text = bar.Rows[0][0].ToString();
                }
                else
                {
                    lblNaziv.Text = "___";
                }
            }

            if (txtSifraArtikla.Text.Length > 6)
            {
                veza.ExecuteQuery("select ar_naziv from artikl, barkod where barkod.bk_kod = '" + txtSifraArtikla.Text + "' and barkod.artikl_ar_ID = artikl.ar_ID", ref bar);

                if (bar.Rows.Count > 0)
                {
                    lblNaziv.Text = bar.Rows[0][0].ToString();
                }
                else
                {
                    lblNaziv.Text = "___";
                }
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifraArtikla.Text != "")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    string IDD = dohvati.DohvatiIDSifra("ar_ID","artikl","ar_sifra = '"+txtSifraArtikla.Text+"'");

                    if (IDD == null)
                    {
                        IDD = dohvati.DohvatiIDSifra("artikl_ar_ID","barkod","bk_kod = "+txtSifraArtikla.Text+"");
                    }
                    int ID = Convert.ToInt32(IDD);
                    this.pregledProdCijTableAdapter.Fill(this.pregled_prodajnih_cijena.PregledProdCij, ID);
                    this.pregledProdCij2TableAdapter.Fill(this.pregled_prodajnih_cijena_2.PregledProdCij2, ID);
                    //this.dozvoljenanivelacijaTableAdapter.Fill(this.dozvoljenaNivelacija.dozvoljenanivelacija, ID);
                    this.dozvoljenanivelacijaNovaTableAdapter.FillNovo(this.dozvoljenaNivelacija.dozvoljenanivelacijaNova , ID);
                }
                else
                {
                    txtSifraArtikla.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;

                result = MessageBox.Show("Želite prijenos u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    ExcelExportgridView("gridView3");
                }
            }
        }

        private void ExcelExportgridView(string nazivGrida)
        {
            var bindingSource = (BindingSource)this.gridView3.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.gridView3 != null && nazivGrida == "gridView3")
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
                gridView3.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            }
            else if (this.gridView1 != null && nazivGrida == "gridView1")
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
                gridView1.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            }
            else if (this.gridView2 != null && nazivGrida == "gridView2")
            {
                m_book.ImportDataTable((DataTable)dataTable, true, 1, 1, -1, -1);
                gridView2.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            }
            else
            {
                MessageBox.Show("Nema podataka za export u excel!", "Error");
                return;
            }

            //Saving the workbook to disk. 
            //m_book.write("C:\\Podaci\\Podaci.xls");

            //dgAkcija.ExportToXls("c:\\Podaci\\Podaci.xls");

            //dgAkcija..ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            //gridView1
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;

                result = MessageBox.Show("Želite prijenos u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    ExcelExportgridView("gridView1");
                }
            }
        }

        private void dgCjenici_KeyDown(object sender, KeyEventArgs e)
        {
            //gridView2
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;

                result = MessageBox.Show("Želite prijenos u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    ExcelExportgridView("gridView2");
                }
            }
        }

    }
}
