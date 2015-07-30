using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using SmartXLS;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace blokerX
{
    public partial class FrmPregledArtikalaNivelacija : Form
    {
        Upiti veza = new Upiti();
        public static Button azuriraj = new Button();

        DataTable operater = new DataTable();

        string dozvoljenaNivelacija;

        string IDZaglavljaNivelacije;

        int operater_nivo_dozvoljava;

        public FrmPregledArtikalaNivelacija()
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

        private void FrmPregledArtikalaNivelacija_Load(object sender, EventArgs e)
        {
            PravaOperatera();
            azuriraj = btnAzuriraj;
            this.artikliNiveliranjeTableAdapter.Fill(this.artikliKojiSeMoguNivelirati.ArtikliNiveliranje);
            // TODO: This line of code loads data into the 'artikliKojiSeMoguNivelirati.ArtikliNiveliranje' table. You can move, or remove it, as needed.

            //MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

            //MySqlCommand comm = new MySqlCommand("select dozvoljenanivelacijazag.*, operater.op_sifra, concat(operater.op_ime,' ',operater.op_prezime) ,(select distinct(count(dozvoljenanivelacija.artikl_AR_ID )) from dozvoljenanivelacija where dozvoljenanivelacija.dozvoljenaNivelacijaZag_dnz_id = dozvoljenanivelacijazag.dnz_ID group by dozvoljenanivelacija.artikl_AR_ID) from operater, dozvoljenanivelacijazag, dozvoljenanivelacija  where  operater.op_ID =dozvoljenanivelacijazag.operater_OP_ID and dozvoljenanivelacija.dozvoljenaNivelacijaZag_dnz_id = dozvoljenanivelacijazag.dnz_ID group by dozvoljenanivelacija.dozvoljenaNivelacijaZag_dnz_id", conn);


            //MySqlDataAdapter adapter = new MySqlDataAdapter(comm);


            //if (dgArtikl.RowCount > 0)
            //{
            //    artikliKojiSeMoguNivelirati.Tables["Table"].Clear();
            //    dgArtikli.DataSource = artikliKojiSeMoguNivelirati.Tables["Table"];
            //}

            //adapter.Fill(artikliKojiSeMoguNivelirati, "Table");
            //dgArtikli.DataSource = artikliKojiSeMoguNivelirati.Tables["Table"];
            //artikliNiveliranjeBindingSource = new BindingSource(artikliKojiSeMoguNivelirati, "Table");
            //dgArtikli.DataSource = artikliNiveliranjeBindingSource;

        }

        public void PravaOperatera()
        {
            try
            {
                string id = Global.KorisnikID;
                veza.ExecuteQuery("select op_sifra from operater where op_ID = '" + id + "'", ref operater);
                string sifra = operater.Rows[0][0].ToString();
                //int nivo = Convert.ToInt16(operater.Rows[0][0]);

                if (sifra == "TOMISK" || sifra == "TONKAS" || sifra == "IVICAC" || sifra == "PAMELA" || sifra == "MAR5")
                {
                    operater_nivo_dozvoljava = 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPregledArtikalaNivelacija_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    if (dtpOD.Visible)
                    {
                        dtpDO.Visible = false;
                        dtpOD.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else if (e.KeyCode == Keys.F4 && operater_nivo_dozvoljava == 1)
                {
                    if (dgArtikl.RowCount > 0)
                    {
                        System.Data.DataRow row = dgArtikl.GetDataRow(dgArtikl.FocusedRowHandle);
                        if (row != null)
                        {
                            dozvoljenaNivelacija = row[0].ToString();

                            if (row[2].ToString() != "0")
                            {
                                //onda se radi o staroj nivelaciji otvori staru formu

                                frmUnosArtikalaKojimaSeMijenjaCijena UForm = null;
                                if ((UForm = (frmUnosArtikalaKojimaSeMijenjaCijena)IsFormAlreadyOpen(typeof(frmUnosArtikalaKojimaSeMijenjaCijena))) == null)
                                {
                                    frmUnosArtikalaKojimaSeMijenjaCijena _frm = new frmUnosArtikalaKojimaSeMijenjaCijena();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                                    _frm.Show();
                                }
                                else
                                {
                                    UForm.Focus();
                                    return;
                                }
                            }
                            else
                            {
                                //nova nivelacija - diktirana cijena

                                frmDiktiranaCijenaArtikalaZaTrgovine UForm = null;
                                if ((UForm = (frmDiktiranaCijenaArtikalaZaTrgovine)IsFormAlreadyOpen(typeof(frmDiktiranaCijenaArtikalaZaTrgovine))) == null)
                                {
                                    frmDiktiranaCijenaArtikalaZaTrgovine _frm = new frmDiktiranaCijenaArtikalaZaTrgovine();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
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
                    else
                    {
                        MessageBox.Show("Nemate niti jedan zapis koji biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7 && operater_nivo_dozvoljava == 1)
                {
                    dozvoljenaNivelacija = "0";

                    frmDiktiranaCijenaArtikalaZaTrgovine UForm = null;
                    if ((UForm = (frmDiktiranaCijenaArtikalaZaTrgovine)IsFormAlreadyOpen(typeof(frmDiktiranaCijenaArtikalaZaTrgovine))) == null)
                    {
                        frmDiktiranaCijenaArtikalaZaTrgovine _frm = new frmDiktiranaCijenaArtikalaZaTrgovine();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;
                    }

                    //frmUnosArtikalaKojimaSeMijenjaCijena UForm = null;
                    //if ((UForm = (frmUnosArtikalaKojimaSeMijenjaCijena)IsFormAlreadyOpen(typeof(frmUnosArtikalaKojimaSeMijenjaCijena))) == null)
                    //{
                    //    frmUnosArtikalaKojimaSeMijenjaCijena _frm = new frmUnosArtikalaKojimaSeMijenjaCijena();
                    //    _frm.MdiParent = frmMain.ActiveForm;
                    //    _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                    //    _frm.Show();
                    //}
                    //else
                    //{
                    //    UForm.Focus();
                    //    return;
                    //}
                }
                else if (e.KeyCode == Keys.Delete && operater_nivo_dozvoljava == 1)
                {
                    if (dgArtikl.RowCount > 0)
                    {
                        try
                        {
                            DialogResult result;
                            result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            if (result == DialogResult.Yes)
                            {
                                System.Data.DataRow row = dgArtikl.GetDataRow(dgArtikl.FocusedRowHandle);
                                if (row != null)
                                {
                                    IDZaglavljaNivelacije = row[1].ToString();

                                    veza.ExecuteQuery("Delete from dozvoljenanivelacija where dozvoljenanivelacijazag_dnz_ID = " + IDZaglavljaNivelacije + " ");
                                    veza.ExecuteQuery("Delete from dozvoljenanivelacijazag where dnz_ID= " + IDZaglavljaNivelacije + "");
                                    MessageBox.Show("Uspješno ste obrisali odabrani zapis!");
                                    this.artikliNiveliranjeTableAdapter.Fill(this.artikliKojiSeMoguNivelirati.ArtikliNiveliranje);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.artikliNiveliranjeTableAdapter.Fill(this.artikliKojiSeMoguNivelirati.ArtikliNiveliranje);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgArtikl.RowCount > 0 && operater_nivo_dozvoljava == 1)
            {
                try
                {
                    if (operater_nivo_dozvoljava == 1)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            System.Data.DataRow row = dgArtikl.GetDataRow(dgArtikl.FocusedRowHandle);
                            if (row != null)
                            {
                                IDZaglavljaNivelacije = row[0].ToString();

                                veza.ExecuteQuery("Delete from dozvoljenanivelacija where dozvoljenanivelacijazag_dnz_ID = " + IDZaglavljaNivelacije + " ");
                                veza.ExecuteQuery("delete from dozvoljenanivelacijaartikl where dozvoljenanivelacijazag_ID =" + IDZaglavljaNivelacije + " ");
                                veza.ExecuteQuery("delete from dozvoljenanivelacijaposlovnica where dozvoljenanivelacijazag_ID = " + IDZaglavljaNivelacije + "");
                                veza.ExecuteQuery("Delete from dozvoljenanivelacijazag where dnz_ID= " + IDZaglavljaNivelacije + "");
                                MessageBox.Show("Uspješno ste obrisali odabrani zapis!");
                                this.artikliNiveliranjeTableAdapter.Fill(this.artikliKojiSeMoguNivelirati.ArtikliNiveliranje);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
                if (operater_nivo_dozvoljava == 1)
                {
                    dozvoljenaNivelacija = "0";

                    //frmUnosArtikalaKojimaSeMijenjaCijena _frm;

                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmUnosArtikalaKojimaSeMijenjaCijena))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_frm = new frmUnosArtikalaKojimaSeMijenjaCijena();
                    //_frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                    //_frm.ShowDialog();

                    //frmUnosArtikalaKojimaSeMijenjaCijena UForm = null;
                    //if ((UForm = (frmUnosArtikalaKojimaSeMijenjaCijena)IsFormAlreadyOpen(typeof(frmUnosArtikalaKojimaSeMijenjaCijena))) == null)
                    //{
                    //    frmUnosArtikalaKojimaSeMijenjaCijena _frm = new frmUnosArtikalaKojimaSeMijenjaCijena();
                    //    _frm.MdiParent = frmMain.ActiveForm;
                    //    _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                    //    _frm.Show();
                    //}
                    //else
                    //{
                    //    UForm.Focus();
                    //    return;
                    //}

                    frmDiktiranaCijenaArtikalaZaTrgovine UForm = null;
                    if ((UForm = (frmDiktiranaCijenaArtikalaZaTrgovine)IsFormAlreadyOpen(typeof(frmDiktiranaCijenaArtikalaZaTrgovine))) == null)
                    {
                        frmDiktiranaCijenaArtikalaZaTrgovine _frm = new frmDiktiranaCijenaArtikalaZaTrgovine();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;
                    }

                  
                }               
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            if (operater_nivo_dozvoljava == 1)
            {
                if (dgArtikl.RowCount > 0)
                {
                    System.Data.DataRow row = dgArtikl.GetDataRow(dgArtikl.FocusedRowHandle);
                    if (row != null)
                    {
                        dozvoljenaNivelacija = row[0].ToString();

                        if (row[2].ToString() != "0")
                        {
                            //onda se radi o staroj nivelaciji otvori staru formu

                            frmUnosArtikalaKojimaSeMijenjaCijena UForm = null;
                            if ((UForm = (frmUnosArtikalaKojimaSeMijenjaCijena)IsFormAlreadyOpen(typeof(frmUnosArtikalaKojimaSeMijenjaCijena))) == null)
                            {
                                frmUnosArtikalaKojimaSeMijenjaCijena _frm = new frmUnosArtikalaKojimaSeMijenjaCijena();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
                                _frm.Show();
                            }
                            else
                            {
                                UForm.Focus();
                                return;
                            }
                        }
                        else
                        {
                            //nova nivelacija - diktirana cijena

                            frmDiktiranaCijenaArtikalaZaTrgovine UForm = null;
                            if ((UForm = (frmDiktiranaCijenaArtikalaZaTrgovine)IsFormAlreadyOpen(typeof(frmDiktiranaCijenaArtikalaZaTrgovine))) == null)
                            {
                                frmDiktiranaCijenaArtikalaZaTrgovine _frm = new frmDiktiranaCijenaArtikalaZaTrgovine();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.dozvoljenaNivelacija = dozvoljenaNivelacija;
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
                else
                {
                    MessageBox.Show("Nemate niti jedan zapis koji biste ažurirali!");
                }

            }
        }

        private void dgArtikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (dtpOD.Visible)
                {
                    dtpDO.Visible = false;
                    dtpOD.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                }
                else
                {
                    dtpDO.Visible = true;
                    dtpOD.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    dtpOD.Focus();
                }
            }
        }

        private void ExcelExport()
        {
            DateTime datumOD = Convert.ToDateTime(dtpOD.Text);
            DateTime datumDO = Convert.ToDateTime(dtpDO.Text);

            this.pregledNivelacijeTableAdapter.Fill(this.artikliKojiSeMoguNivelirati.pregledNivelacije, datumOD, datumDO);


            //veza.ExecuteQuery("select dozvoljenanivelacijazag.dnz_ID, dozvoljenanivelacijazag.dnz_opis, dozvoljenanivelacijazag.dnz_odkada as 'Od kada', dozvoljenanivelacijazag.dnz_dokada as 'Do kada', artikl.AR_SIFRA, artikl.AR_NAZIV, dozvoljenanivelacija.dn_preporucenacijena,  poslovnica.po_sifra, poslovnica.po_naziv from  dozvoljenanivelacijazag,  dozvoljenanivelacija left join artikl on artikl.ar_ID = dozvoljenanivelacija.artikl_AR_ID  left join poslovnica on poslovnica.po_id= dozvoljenanivelacija.poslovnica_po_ID where   dozvoljenanivelacija.dozvoljenaNivelacijaZag_dnz_id =dozvoljenanivelacijazag.dnz_ID and dozvoljenanivelacijazag.dnz_odkada >= '"+datod+"' and dozvoljenanivelacijazag.dnz_dokada <= '"+datdo+"'", ref podaci);


            var bindingSource = (BindingSource)this.dgPomocni.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();


            //Export DataTable.
            if (this.dgPomocni != null)
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


            dgPomocni.ExportToExcelOld(@"c:\Podaci\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            if (dtpOD.Text != "" && dtpDO.Text != "")
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    ExcelExport();
                }
            }
        }

        private void dtpOD_Enter(object sender, EventArgs e)
        {
            dtpOD.Format = DateTimePickerFormat.Short;
            if (dtpOD.Text == " ")
            {
                dtpOD.Value = DateTime.Now;
            }
        }

        private void dtpDO_Enter(object sender, EventArgs e)
        {
            dtpDO.Format = DateTimePickerFormat.Short;
            if (dtpDO.Text == " ")
            {
                dtpDO.Value = DateTime.Now;
            }
        }
    }
}
