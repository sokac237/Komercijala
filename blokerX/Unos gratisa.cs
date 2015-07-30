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
using MySql.Data.MySqlClient;

namespace blokerX
{
    public partial class frmUnosGratisa : Form
    {
        int top;
        int focus;
        Upiti veza = new Upiti();
        public static Button osvjezi = new Button();
        string IDGratisa;
        public frmUnosGratisa()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }

        private void btnZapisnik_Click(object sender, EventArgs e)
        {
            frmZapisnik UForm = null;
            if ((UForm = (frmZapisnik)IsFormAlreadyOpen(typeof(frmZapisnik))) == null)
            {
                frmZapisnik _frm = new frmZapisnik();
                _frm.MdiParent = frmMain.ActiveForm;
                _frm.oznaka = "F7";
                _frm.Show();
            }
            else
            {
                UForm.Focus();
                return;
            }
        }

        private void dgCjenici_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F4)
                {
                    top = gratis.TopRowIndex;
                    focus = gratis.FocusedRowHandle;


                    if (gratis.RowCount > 0)
                    {
                        System.Data.DataRow row = gratis.GetDataRow(gratis.FocusedRowHandle);
                        if (row != null)
                        {
                            IDGratisa = row["gr_ID"].ToString();
                            frmZapisnik UForm = null;
                            if ((UForm = (frmZapisnik)IsFormAlreadyOpen(typeof(frmZapisnik))) == null)
                            {
                                frmZapisnik _frm = new frmZapisnik();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.oznaka = "F4";
                                _frm.gratisID = IDGratisa;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Nemate niti jednu stavku koju biste ažurirali!");
                    }


                   
                } 
                else if (e.KeyCode == Keys.Delete)
                {
                    if (gratis.RowCount > 0)
                    {
                        DialogResult result;
                        System.Data.DataRow row = gratis.GetDataRow(gratis.FocusedRowHandle);
                        if (row != null)
                        {
            
                            result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            if (result == DialogResult.Yes)
                            {
                                string gr_ID = row[16].ToString();
                                veza.ExecuteQuery("delete from gratis where gr_ID = " + gr_ID + "");
                                MessageBox.Show("Uspješno ste obrisali odabrani zapis!");
                                osvjezi.PerformClick();
                            }
                           
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void frmUnosGratisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gratis1.gratis' table. You can move, or remove it, as needed.
            this.gratisTableAdapter.Fill(this.gratis1.gratis);
            osvjezi= button1;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.gratisTableAdapter.Fill(this.gratis1.gratis);

      
            gratis.TopRowIndex = top;
            gratis.SelectRow(focus);
        }

        private void btnDodajKalkul_Click(object sender, EventArgs e)
        {
            frmDodajSKalkulacije UForm = null;
            if ((UForm = (frmDodajSKalkulacije)IsFormAlreadyOpen(typeof(frmDodajSKalkulacije))) == null)
            {
                frmDodajSKalkulacije _frm = new frmDodajSKalkulacije();
                _frm.MdiParent = frmMain.ActiveForm;
                //_frm.oznaka = "F7";
                _frm.Show();
            }
            else
            {
                UForm.Focus();
                return;
            }
        }

        private void btnNezaduzene_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable gratis = new DataTable();

                veza.ExecuteQuery("select uf_broj, uf_datum, poslovnica_po_ID, uf_memo, uf_iznos  from ufaifa where partner_pa_ID ='  5061' AND uf_STATUS <>'S' and uf_broj not in (select ufaifa_uf_broj  from gratis where ufaifa_uf_broj is not null and ufaifa_uf_broj <>'')", ref gratis);

                if (gratis.Rows.Count > 0)
                {
                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    gratis.TableName = "Artikli";
                    FDataSet.Tables.Add(gratis);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Gratis.frx");

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
}
