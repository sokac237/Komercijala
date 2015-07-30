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
using blokirajx;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmArtikliPoDobavljacu : Form
    {
        Upiti veza = new Upiti();
        int brojac;
        string RG;
        string TipTrg;
        private DataSet FDataSet;
        string upit;
        int saveRow = 0;
        int focus = 0;

        public frmArtikliPoDobavljacu()
        {
            InitializeComponent();
        }

        public static Button a = new Button();

        public void frmArtikliPoDobavljacu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            glDobavljac.Focus();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            a = btnPrikaziArtikle;
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

        public void btnPrikaziRG_Click(object sender, EventArgs e)
        {
            if (glDobavljac.EditValue.ToString() != "")
            {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
                MySqlCommand comm = new MySqlCommand("robnaGrupa_za_dobavljaca", conn);
                comm.CommandType = CommandType.StoredProcedure;

                string ID = glDobavljac.EditValue.ToString();

                MySqlParameter prm = new MySqlParameter("@partner", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = ID;
                comm.Parameters.Add(prm);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                if (dgRG.Rows.Count > 0)
                {
                    rGDobavljac.Tables["Table"].Clear();
                    dgRG.DataSource = rGDobavljac.Tables["Table"];
                }

                adapter.Fill(rGDobavljac, "Table");
                dgRG.DataSource = rGDobavljac.Tables["Table"];
                robnaGrupazadobavljacaBindingSource = new BindingSource(rGDobavljac, "Table");
                dgRG.DataSource = robnaGrupazadobavljacaBindingSource;
                dgRG.Focus();

            }
            else
            {
                MessageBox.Show("Odaberite dobavljača");
                glDobavljac.Focus();
            }
           
        }

        public void dgRG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        public void ckbSveGrupe_CheckedChanged(object sender, EventArgs e)
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

        public void dgArtikli_KeyUp(object sender, KeyEventArgs e)
        {
            saveRow = dgArtikli.FirstDisplayedScrollingRowIndex;
            focus = dgArtikli.CurrentCell.RowIndex;

            if (Global.Flag == "1")
            {
                string IDDobArtik = dgArtikli.CurrentRow.Cells[0].Value.ToString();

                string IDArtikl = dgArtikli.CurrentRow.Cells[21].Value.ToString();

                if (e.KeyCode == Keys.F8)
                {
                    if (dgArtikli.CurrentRow.Cells["ostrik"].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells["ostrik"].Value = "True";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (dgArtikli.CurrentRow.Cells["ostrik"].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells["ostrik"].Value = "False";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells["ostrik"].Value = "True";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Green;
                    }
                }
                else if (e.KeyCode == Keys.A)
                {
                    if (dgArtikli.CurrentRow.Cells[4].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[4].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_A = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[4].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[4].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_A = false where doa_ID = '" + IDDobArtik + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[4].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_A = true where doa_ID = '" + IDDobArtik + "'");
                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    if (dgArtikli.CurrentRow.Cells[5].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[5].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_B = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[5].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[5].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_B = false where doa_ID = '" + IDDobArtik + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[5].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_B = true where doa_ID = '" + IDDobArtik + "'");
                    }
                }
                else if (e.KeyCode == Keys.C)
                {
                    if (dgArtikli.CurrentRow.Cells[6].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[6].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_C = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[6].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[6].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_C = false where doa_ID = '" + IDDobArtik + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[6].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_C = true where doa_ID = '" + IDDobArtik + "'");
                    }
                }
                else if (e.KeyCode == Keys.D)
                {
                    if (dgArtikli.CurrentRow.Cells[7].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[7].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_D = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[7].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[7].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_D = false where doa_ID = '" + IDDobArtik + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[7].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_D = true where doa_ID = '" + IDDobArtik + "'");
                    }
                }
                else if (e.KeyCode == Keys.X)
                {
                    if (dgArtikli.CurrentRow.Cells[8].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[8].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_X = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[8].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[8].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_X = false where doa_ID = '" + IDDobArtik + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[8].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_X = true where doa_ID = '" + IDDobArtik + "'");
                    }
                }
                else if (e.KeyCode == Keys.V)
                {
                    if (dgArtikli.CurrentRow.Cells[11].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[11].Value = "True";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                        veza.ExecuteQuery("update dobavljacartikl set doa_skladiste = true where doa_ID = '" + IDDobArtik + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[11].Value.ToString() == "True")
                    {
                        if (dgArtikli.CurrentRow.Cells[18].Value.ToString() == "True")
                        {
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.LightSlateGray;
                            dgArtikli.CurrentRow.Cells[11].Value = "False";
                            veza.ExecuteQuery("update dobavljacartikl set doa_skladiste = false where doa_ID = '" + IDDobArtik + "'"); 
                        }
                        else
                        {
                            dgArtikli.CurrentRow.Cells[11].Value = "False";
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                            veza.ExecuteQuery("update dobavljacartikl set doa_skladiste = false where doa_ID = '" + IDDobArtik + "'"); 
                        }                                               
                    }
                    else
                    {
                        if (dgArtikli.CurrentRow.Cells[18].Value.ToString() == "True")
                        {
                            dgArtikli.CurrentRow.Cells[11].Value = "True";
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.LightSlateGray;
                            veza.ExecuteQuery("update dobavljacartikl set doa_skladiste = true where doa_ID = '" + IDDobArtik + "'");
                        }
                        else
                        {
                            dgArtikli.CurrentRow.Cells[11].Value = "True";
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                            veza.ExecuteQuery("update dobavljacartikl set doa_skladiste = true where doa_ID = '" + IDDobArtik + "'");
                        }                      
                    }
                }
                else if (e.KeyCode == Keys.Z)
                {
                    if (dgArtikli.CurrentRow.Cells[20].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[20].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_zabrana = 1 where artikl_ar_ID = '" + IDArtikl + "' and partneri_pa_ID = "+glDobavljac.EditValue+"");

                    }
                    else if (dgArtikli.CurrentRow.Cells[20].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[20].Value = "False";
                        veza.ExecuteQuery("update dobavljacartikl set doa_zabrana = 0 where artikl_ar_ID = '" + IDArtikl + "' and partneri_pa_ID = " + glDobavljac.EditValue + "");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[20].Value = "True";
                        veza.ExecuteQuery("update dobavljacartikl set doa_zabrana = 1 where artikl_ar_ID = '" + IDArtikl + "'and partneri_pa_ID = " + glDobavljac.EditValue + "");
                    }
                }
                else if (e.KeyCode == Keys.D1)
                {
                    if (dgArtikli.CurrentRow.Cells[12].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[12].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_A = true where ar_ID = '" + IDArtikl + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[12].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[12].Value = "False";
                        veza.ExecuteQuery("update artikl set ar_A = false where ar_ID = '" + IDArtikl + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[12].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_A = true where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.D2)
                {
                    if (dgArtikli.CurrentRow.Cells[13].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[13].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_B = true where ar_ID = '" + IDArtikl + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[13].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[13].Value = "False";
                        veza.ExecuteQuery("update artikl set ar_B = false where ar_ID = '" + IDArtikl + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[13].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_B = true where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.D3)
                {
                    if (dgArtikli.CurrentRow.Cells[14].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[14].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_C = true where ar_ID = '" + IDArtikl + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[14].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[14].Value = "False";
                        veza.ExecuteQuery("update artikl set ar_C = false where ar_ID = '" + IDArtikl + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[14].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_C = true where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.D4)
                {
                    if (dgArtikli.CurrentRow.Cells[15].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[15].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_    D = true where ar_ID = '" + IDArtikl + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[15].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[15].Value = "False";
                        veza.ExecuteQuery("update artikl set ar_D = false where ar_ID = '" + IDArtikl + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[15].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_D = true where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.D5)
                {
                    if (dgArtikli.CurrentRow.Cells[16].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[16].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_X = true where ar_ID = '" + IDArtikl + "'");

                    }
                    else if (dgArtikli.CurrentRow.Cells[16].Value.ToString() == "True")
                    {
                        dgArtikli.CurrentRow.Cells[16].Value = "False";
                        veza.ExecuteQuery("update artikl set ar_X = false where ar_ID = '" + IDArtikl + "'");
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[16].Value = "True";
                        veza.ExecuteQuery("update artikl set ar_X = true where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.N)
                {
                    if (dgArtikli.CurrentRow.Cells[18].Value == null)
                    {
                        dgArtikli.CurrentRow.Cells[18].Value = "True";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.LightSlateGray;
                        veza.ExecuteQuery("update artikl set ar_nenarucuj = true where ar_ID = '" + IDArtikl + "'");
                    }
                    else if (dgArtikli.CurrentRow.Cells[18].Value.ToString() == "True")
                    {
                        if (dgArtikli.CurrentRow.Cells[11].Value.ToString() == "True")
                        {
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                            dgArtikli.CurrentRow.Cells[18].Value = "False";
                            veza.ExecuteQuery("update artikl set ar_nenarucuj = false where ar_ID = '" + IDArtikl + "'");
                        }
                        else
                        {
                            dgArtikli.CurrentRow.Cells[18].Value = "False";
                            dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                            veza.ExecuteQuery("update artikl set ar_nenarucuj = false where ar_ID = '" + IDArtikl + "'");
                        }                                                                   
                    }
                    else
                    {
                        dgArtikli.CurrentRow.Cells[18].Value = "True";
                        dgArtikli.CurrentRow.DefaultCellStyle.ForeColor = Color.LightSlateGray;
                        veza.ExecuteQuery("update artikl set ar_nenarucuj = True where ar_ID = '" + IDArtikl + "'");
                    }
                }
                else if (e.KeyCode == Keys.F4)
                {
                    Global.oznaci = "1";

                    string artiklID = dgArtikli.CurrentRow.Cells[21].Value.ToString();

                    //frmAzuriranjePaketa _Form;
                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzuriranjePaketa))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_Form = new frmAzuriranjePaketa();

                    //_Form.ShowDialog();        

                    frmAzuriranjePaketa UForm = null;
                    if ((UForm = (frmAzuriranjePaketa)IsFormAlreadyOpen(typeof(frmAzuriranjePaketa))) == null)
                    {
                        frmAzuriranjePaketa  _frm = new frmAzuriranjePaketa();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.broj = artiklID;
                        _frm.tipka = "F4";
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;                       
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    Global.oznaci = "1";

                    string artiklID = dgArtikli.CurrentRow.Cells[21].Value.ToString();

                    //frmAzuriranjePaketa _Form;

                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzuriranjePaketa))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_Form = new frmAzuriranjePaketa();
                    //_Form.broj = artiklID;
                    //_Form.tipka = "F6";
                    //_Form.ShowDialog();

                    frmAzuriranjePaketa UForm = null;
                    if ((UForm = (frmAzuriranjePaketa)IsFormAlreadyOpen(typeof(frmAzuriranjePaketa))) == null)
                    {
                        frmAzuriranjePaketa _frm = new frmAzuriranjePaketa();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.broj = artiklID;
                        _frm.tipka = "F6";
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;
                    }
                }
            }
            
            if (e.KeyCode == Keys.F9 && dgArtikli.Rows.Count > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    ExcelExport();
                }
            }
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

        public void Provjeri_stanje()
        {
            if (dgArtikli.Rows.Count > 0)
            {
                for (brojac = 0; brojac < dgArtikli.Rows.Count; brojac++)
                {
                    if (dgArtikli.Rows[brojac].Cells[18].Value.ToString() == "True")
                    {
                        dgArtikli.Rows[brojac].DefaultCellStyle.ForeColor = Color.LightSlateGray;
                    }
                }

                for (brojac = 0; brojac < dgArtikli.Rows.Count; brojac++)
                {
                    if (dgArtikli.Rows[brojac].Cells[11].Value.ToString() == "True")
                    {
                        dgArtikli.Rows[brojac].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }


        public void btnPrikaziArtikle_Click(object sender, EventArgs e)
        {
            Global.Flag = "1";
            if (dgRG.Rows.Count > 0)
            {
                try
                {
                    RG = "";

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
                                if (RG != "")
                                {
                                    RG = RG + ",";

                                }
                                RG = RG + dgRG.Rows[brojac].Cells[0].Value.ToString();

                                provjeriRGDobavljac();
                            }
                        }
                    }

                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                    MySqlCommand comm = new MySqlCommand("select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod, partner.PA_NAZIV, artikl.ar_sifra from partner, dobavljacartikl, artikl left outer  join barkod on  (artikl.ar_ID=barkod.artikl_ar_ID and barkod.bk_zanarudzbu = 1 ) where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID =  " + glDobavljac.EditValue.ToString() + " and partner.PA_ID = dobavljacartikl.partneri_PA_ID and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in  (" + RG + ")) order by artikl.ar_naziv", conn);
                    //prije upit - "select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod from dobavljacartikl, artikl left outer  join barkod on artikl.ar_ID=barkod.artikl_ar_ID where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID = " + glDobavljac.EditValue.ToString() + " and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + a + "))"
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    if (dgArtikli.Rows.Count > 0)
                    {
                        artiklipoRGDobavljac.Tables["Table"].Clear();
                        dgArtikli.DataSource = artiklipoRGDobavljac.Tables["Table"];
                    }

                    adapter.Fill(artiklipoRGDobavljac, "Table");
                    dgArtikli.DataSource = artiklipoRGDobavljac.Tables["Table"];
                    artiklipoRGzadobavljacaBindingSource = new BindingSource(artiklipoRGDobavljac, "Table");
                    dgArtikli.DataSource = artiklipoRGzadobavljacaBindingSource;
                    dgArtikli.Focus();
                    dgArtikli.FirstDisplayedScrollingRowIndex = saveRow;
                    dgArtikli.CurrentCell = dgArtikli[1, focus];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Provjeri_stanje();
            }
            else
            {
                MessageBox.Show("Odaberite robnu grupu!");
            }
            
        }

        public void provjeriRGDobavljac()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
            MySqlCommand comm = new MySqlCommand("fRG_je_od_komercijaliste", conn);
            comm.CommandType = CommandType.StoredProcedure;

            MySqlParameter prm = new MySqlParameter("rgID", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = dgRG.Rows[brojac].Cells[0].Value;
            comm.Parameters.Add(prm);

            prm = new MySqlParameter("operaterID", MySqlDbType.Int16);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Global.KorisnikID;
            comm.Parameters.Add(prm);

            MySqlParameter retval = comm.Parameters.Add("@asd", MySqlDbType.VarChar);
            retval.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            string retunvalue = (string)comm.Parameters["@asd"].Value;

            if (retunvalue == "0")
            {
                Global.Flag = "0";
                return;
            }
            else if (retunvalue == "1" && Global.Flag == "0")
            {
                return;
                //if (Global.Flag == "0" && brojac > 1)
                //{
                //    return;
                //}
                //else if (retunvalue == "1")
                //{
                //    Global.Flag = "1";
                //}
            }
            else
            {
                Global.Flag = "1";
            }
        }

        private void frmArtikliPoDobavljacu_KeyDown(object sender, KeyEventArgs e)
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

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            if (dgRG.Rows.Count > 0)
            {             
                rGDobavljac.Tables["Table"].Clear();
                dgRG.DataSource = rGDobavljac.Tables["Table"];
                ckbSveGrupe.Checked = false;
            }
            if (dgArtikli.RowCount > 0)
            {
                artiklipoRGDobavljac.Tables["Table"].Clear();
                dgArtikli.DataSource = artiklipoRGDobavljac.Tables["Table"];
                ckbSveGrupe.Checked = false;
            }
        }

        private void btnListaUkupno_Click(object sender, EventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    veza.ExecuteQuery("select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod, partner.PA_NAZIV, artikl.ar_sifra from partner, dobavljacartikl, artikl left outer  join barkod on  (artikl.ar_ID=barkod.artikl_ar_ID and barkod.bk_zanarudzbu = 1 ) where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID =  " + glDobavljac.EditValue.ToString() + " and partner.PA_ID = dobavljacartikl.partneri_PA_ID and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in  (" + RG + ")) and (dobavljacartikl.doa_A = 1 or dobavljacartikl.doa_B  or dobavljacartikl.doa_C  or dobavljacartikl.doa_D  or dobavljacartikl.doa_X )", ref artikli);

                    if (artikli.Rows.Count > 0)
                    {
                        //create dataset 
                        FDataSet = new DataSet();
                        artikli.TableName = "Artikli";
                        FDataSet.Tables.Add(artikli);

                        // create report instance
                        Report report = new Report();

                        // load the existing report
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/ArtikliDobavljac.frx");

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

        private void ListaTrgovina_Click(object sender, EventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
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
                        upit = "dobavljacartikl.doa_A = 1";
                    }
                    else if (TipTrg == "B")
                    {
                        upit = "dobavljacartikl.doa_B = 1";
                    }
                    else if (TipTrg == "C")
                    {
                        upit = "dobavljacartikl.doa_C = 1";
                    }
                    else if (TipTrg == "D")
                    {
                        upit = "dobavljacartikl.doa_B = 1";
                    }
                    else if (TipTrg == "X")
                    {
                        upit = "dobavljacartikl.doa_X = 1";
                    }


                    DataTable artikli = new DataTable();

                    veza.ExecuteQuery("select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod, partner.PA_NAZIV, artikl.ar_sifra from partner, dobavljacartikl, artikl left outer  join barkod on  (artikl.ar_ID=barkod.artikl_ar_ID and barkod.bk_zanarudzbu = 1 ) where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID =  " + glDobavljac.EditValue.ToString() + " and partner.PA_ID = dobavljacartikl.partneri_PA_ID and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in  (" + RG + ")) and " + upit + "", ref artikli);

                    if (artikli.Rows.Count > 0)
                    {
                        //create dataset 
                        FDataSet = new DataSet();
                        artikli.TableName = "Artikli";
                        FDataSet.Tables.Add(artikli);

                        // create report instance
                        Report report = new Report();

                        // load the existing report
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/ListaGrupaTrgovina.frx");

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

        private void ListaUkupnoVeleprodaja_Click(object sender, EventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();

                    veza.ExecuteQuery("select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod, partner.PA_NAZIV, artikl.ar_sifra from partner, dobavljacartikl, artikl left outer  join barkod on  (artikl.ar_ID=barkod.artikl_ar_ID and barkod.bk_zanarudzbu = 1 ) where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID =  " + glDobavljac.EditValue.ToString() + " and partner.PA_ID = dobavljacartikl.partneri_PA_ID and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in  (" + RG + ")) and (artikl.ar_A = 1 or artikl.ar_B  or artikl.ar_C  or artikl.ar_D  or artikl.ar_X )", ref artikli);

                    if (artikli.Rows.Count > 0)
                    {
                        //create dataset 
                        FDataSet = new DataSet();
                        artikli.TableName = "Artikli";
                        FDataSet.Tables.Add(artikli);

                        // create report instance
                        Report report = new Report();

                        // load the existing report
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/ListaUkupnoVeleprodaja.frx");

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

        private void ListaTrgovinaVeleprodaja_Click(object sender, EventArgs e)
        {
            if (dgArtikli.Rows.Count > 0)
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
                        upit = " artikl.ar_A = 1";
                    }
                    else if (TipTrg == "B")
                    {
                        upit = " artikl.ar_B = 1";
                    }
                    else if (TipTrg == "C")
                    {
                        upit = " artikl.ar_C = 1";
                    }
                    else if (TipTrg == "D")
                    {
                        upit = " artikl.ar_D = 1";
                    }
                    else if (TipTrg == "X")
                    {
                        upit = " artikl.ar_X = 1";
                    }


                    DataTable artikli = new DataTable();

                    veza.ExecuteQuery("select dobavljacartikl.*,artikl.ar_naziv,artikl.AR_PAKiranje,artikl.ar_a,artikl.ar_b,artikl.ar_c,artikl.ar_d,artikl.ar_x,artikl.ar_pakiranjetrgovina,artikl.ar_nenarucuj,barkod.bk_kod, partner.PA_NAZIV, artikl.ar_sifra from partner, dobavljacartikl, artikl left outer  join barkod on  (artikl.ar_ID=barkod.artikl_ar_ID and barkod.bk_zanarudzbu = 1 ) where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID =  " + glDobavljac.EditValue.ToString() + " and partner.PA_ID = dobavljacartikl.partneri_PA_ID and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in  (" + RG + ")) and " + upit + "", ref artikli);

                    if (artikli.Rows.Count > 0)
                    {
                        //create dataset 
                        FDataSet = new DataSet();
                        artikli.TableName = "Artikli";
                        FDataSet.Tables.Add(artikli);

                        // create report instance
                        Report report = new Report();

                        // load the existing report
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/ListaGrupaTrgovinaVeleprodaja.frx");

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
