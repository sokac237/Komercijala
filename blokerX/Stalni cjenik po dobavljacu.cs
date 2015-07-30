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
using SmartXLS;

namespace blokerX
{
    public partial class frmStalniCjenikPoDobavljacu : Form
    {
        int brojac;

        public static Button prikazi = new Button();

        public frmStalniCjenikPoDobavljacu()
        {
            InitializeComponent();
        }

        private void frmStalniCjenikPoDobavljacu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            glDobavljac.Focus();            
            prikazi = btnPrikaziArtikle;
        }

        private void btnPrikaziRG_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.RowCount > 0)
                {
                    artikliUStalniCjenikDobavljac.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void frmStalniCjenikPoDobavljacu_KeyDown(object sender, KeyEventArgs e)
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
            }
            else
            {
                Global.Flag = "1";
            }
        }

        private void dgArtikli_KeyUp(object sender, KeyEventArgs e)
        {
            if (Global.Flag == "1")
            {
                if (e.KeyCode == Keys.F4)
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if (row != null)
                    {
                        string IDartikla = row[8].ToString();

                        //frmIzmjenaCijena _frm;
                        //foreach (Form childForm in this.MdiChildren)
                        //{
                        //    if (childForm.GetType() == typeof(frmIzmjenaCijena))
                        //    {
                        //        childForm.Focus();
                        //        return;
                        //    }
                        //}
                        //_frm = new frmIzmjenaCijena();
                        //_frm.idArtikla = IDartikla;  // data.Rows[0][9].ToString();;
                        //_frm.kojaFormaPoziva = this.Text;
                        //_frm.ShowDialog();


                        frmIzmjenaCijena UForm = null;
                        if ((UForm = (frmIzmjenaCijena)IsFormAlreadyOpen(typeof(frmIzmjenaCijena))) == null)
                        {
                            frmIzmjenaCijena _frm = new frmIzmjenaCijena();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.idArtikla = IDartikla;  // data.Rows[0][9].ToString();;
                            _frm.kojaFormaPoziva = this.Text;
                            _frm.IDPartnera = glDobavljac.EditValue.ToString();
                            _frm.Show();
                        }
                        else
                        {
                            UForm.Focus();
                            return;
                        }
                    }
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

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            frmFiltrirajMarze _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmFiltrirajMarze))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmFiltrirajMarze();
            _frm.ShowDialog();
        }

        private void btnPrikaziArtikle_Click(object sender, EventArgs e)
        {
            Global.Flag = "1";

            if (rbArtikliUCjeniku.Checked)
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

                                    provjeriRGDobavljac();
                                }
                            }
                        }

                        string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                        MySqlCommand comm = new MySqlCommand("select artikl.ar_naziv,artikl.ar_sifra, prodajnistavka.prc_aktivna, prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd,prodajnistavka.prc_tipx, artikl.ar_ID, round (dobavljacartikl.doa_tvornickacijena - (dobavljacartikl.doa_tvornickacijena * dobavljacartikl.doa_postorabata)/100, 5) as nabavnaCijena, porez.pz_posto , artikl.ar_povnak from porez, poreznastopa, dobavljacartikl, artikl, prodajnistavka , prodajnicjenik where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID = " + glDobavljac.EditValue + "  and porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>='" + datum + "' and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + ")) and prodajnistavka.artikl_ar_ID = artikl.ar_ID and prodajnistavka.prodajnicjenik_prc_ID = '1' and prodajnicjenik.prc_nivo='1' and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID  group by artikl.AR_SIFRA", conn);
                            
                        //MySqlCommand comm = new MySqlCommand("select artikl.ar_naziv,artikl.ar_sifra, prodajnistavka.prc_aktivna, prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd,prodajnistavka.prc_tipx, artikl.ar_ID,dobavljacartikl.doa_tvornickacijena, porez.pz_posto , artikl.ar_povnak from porez, poreznastopa, dobavljacartikl, artikl, prodajnistavka , prodajnicjenik where  dobavljacartikl.artikl_ar_id = artikl.ar_id and dobavljacartikl.partneri_PA_ID = " + glDobavljac.EditValue + "  and porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>='" + datum + "' and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + ")) and prodajnistavka.artikl_ar_ID = artikl.ar_ID and prodajnistavka.prodajnicjenik_prc_ID = '1' and prodajnicjenik.prc_nivo='1' and prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID  group by artikl.AR_SIFRA", conn);
                                                
                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                        if (gridView2.RowCount > 0)
                        {
                            artikliUStalniCjenikDobavljac.Tables["Table"].Clear();
                            dgArtikli.DataSource = artikliUStalniCjenikDobavljac.Tables["Table"];
                        }

                        adapter.Fill(artikliUStalniCjenikDobavljac, "Table");
                        dgArtikli.DataSource = artikliUStalniCjenikDobavljac.Tables["Table"];
                        stalniCjenikDobavljacBindingSource = new BindingSource(artikliUStalniCjenikDobavljac, "Table");
                        dgArtikli.DataSource = stalniCjenikDobavljacBindingSource;
                        dgArtikli.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite robnu grupu!");
                    glDobavljac.Focus();
                }
            }
            else
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

                                    provjeriRGDobavljac();
                                }
                            }
                        }
                        string datum = Convert.ToDateTime(DateTime.Now.Date).ToString("yyyy-MM-dd");

                        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                        MySqlCommand comm = new MySqlCommand("select artikl.ar_naziv, artikl.AR_SIFRA, prodajnistavka.prc_aktivna, prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, artikl.ar_ID, round (dobavljacartikl.doa_tvornickacijena - (dobavljacartikl.doa_tvornickacijena * dobavljacartikl.doa_postorabata)/100, 5) as nabavnaCijena, porez.pz_posto, artikl.ar_povnak from porez, poreznastopa,  dobavljacartikl left join artikl on dobavljacartikl.artikl_ar_id=artikl.ar_id left outer  join prodajnistavka on artikl.ar_ID=prodajnistavka.artikl_ar_ID  and prodajnistavka.prodajnicjenik_prc_ID = 1 where  dobavljacartikl.partneri_PA_ID = " + glDobavljac.EditValue + "  and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + ")) and porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>='" + datum + "' group by artikl.AR_SIFRA", conn);

                        //MySqlCommand comm = new MySqlCommand("select artikl.ar_naziv, artikl.AR_SIFRA, prodajnistavka.prc_aktivna, prodajnistavka.prc_tipa, prodajnistavka.prc_tipb, prodajnistavka.prc_tipc, prodajnistavka.prc_tipd, prodajnistavka.prc_tipx, artikl.ar_ID, zaliha.ZA_NABCIJ, porez.pz_posto, artikl.ar_povnak from porez, poreznastopa, zaliha,  dobavljacartikl left join artikl on dobavljacartikl.artikl_ar_id=artikl.ar_id left outer  join prodajnistavka on artikl.ar_ID=prodajnistavka.artikl_ar_ID  and prodajnistavka.prodajnicjenik_prc_ID = 1 where  dobavljacartikl.partneri_PA_ID = " + glDobavljac.EditValue + "  and dobavljacartikl.artikl_ar_id in (select ar_id from artikl  where artikl.robnaGrupa_rg_ID  in (" + robneGrupe + "))  and artikl.poslovnica_po_ID = zaliha.poslovnica_po_ID and artikl.ar_ID = zaliha.artikl_ar_ID and porez.poreznaStopa_pzs_ID = artikl.poreznastopa_pzs_ID and artikl.poreznaStopa_pzs_ID = poreznastopa.pzs_ID and porez.PZ_DATUMOD<= '" + datum + "'  and porez.PZ_DATUMDO>='" + datum + "' ", conn);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                        if (gridView2.RowCount > 0)
                        {
                            artikliUStalniCjenikDobavljac.Tables["Table"].Clear();
                            dgArtikli.DataSource = artikliUStalniCjenikDobavljac.Tables["Table"];
                        }

                        adapter.Fill(artikliUStalniCjenikDobavljac, "Table");
                        dgArtikli.DataSource = artikliUStalniCjenikDobavljac.Tables["Table"];
                        stalniCjenikDobavljacBindingSource = new BindingSource(artikliUStalniCjenikDobavljac, "Table");
                        dgArtikli.DataSource = stalniCjenikDobavljacBindingSource;
                        dgArtikli.Focus();

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
        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            artikliUStalniCjenikDobavljac.Clear();
            rGDobavljac.Clear();
            ckbSveGrupe.Checked = false;
        }

    }
}
