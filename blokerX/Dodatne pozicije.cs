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

namespace blokerX
{
    public partial class frmDodatnePozicije : Form
    {
        public static Button osvjezi = new Button();
        Upiti veza = new Upiti();
        string upit;
        string mjesec;
        string godina;

        int operater_nivo_dozvoljava;

        DataTable operater = new DataTable();

        string IDpozicije;

        public frmDodatnePozicije()
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

        private void frmDodatnePozicije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dodatne_pozicije.DodatnePozicije' table. You can move, or remove it, as needed.
            this.dodatnePozicijeTableAdapter.Fill(this.dodatne_pozicije.DodatnePozicije);
            osvjezi = btnOsvjezi;
            PravaOperatera();
        }

        public void PravaOperatera()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDodatnePozicije_KeyDown(object sender, KeyEventArgs e)
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

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            this.dodatnePozicijeTableAdapter.Fill(this.dodatne_pozicije.DodatnePozicije);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0 && operater_nivo_dozvoljava == 1)
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {
                            IDpozicije = row[0].ToString();

                            veza.ExecuteQuery("Delete from pozicijaracun where pozicija_ID = " + IDpozicije + " ");
                            veza.ExecuteQuery("Delete from pozicijatrgovina where pozicija_poz_ID = " + IDpozicije + "");
                            veza.ExecuteQuery("Delete from pozicija where poz_ID = " + IDpozicije + "");
                            MessageBox.Show("Uspješno ste obrisali odabrani zapis!");
                            this.dodatnePozicijeTableAdapter.Fill(this.dodatne_pozicije.DodatnePozicije);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (operater_nivo_dozvoljava == 1)
            {
                IDpozicije = "0";

                //frmAzuriranjeProdajeDodatnihPozicija _frm;

                //foreach (Form childForm in this.MdiChildren)
                //{
                //    if (childForm.GetType() == typeof(frmAzuriranjeProdajeDodatnihPozicija))
                //    {
                //        childForm.Focus();
                //        return;
                //    }
                //}
                //_frm = new frmAzuriranjeProdajeDodatnihPozicija();
                //_frm.IDPozicije = IDpozicije;
                //_frm.ShowDialog();

                frmAzuriranjeProdajeDodatnihPozicija UForm = null;
                if ((UForm = (frmAzuriranjeProdajeDodatnihPozicija)IsFormAlreadyOpen(typeof(frmAzuriranjeProdajeDodatnihPozicija))) == null)
                {
                    frmAzuriranjeProdajeDodatnihPozicija _frm = new frmAzuriranjeProdajeDodatnihPozicija();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.IDPozicije = IDpozicije;
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
            if (gridView2.RowCount > 0 && operater_nivo_dozvoljava == 1)
            {
                System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    IDpozicije = row[0].ToString();

                    //frmAzuriranjeProdajeDodatnihPozicija _frm;
                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzuriranjeProdajeDodatnihPozicija))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_frm = new frmAzuriranjeProdajeDodatnihPozicija();
                    //_frm.IDPozicije = IDpozicije;
                    //_frm.ShowDialog();

                    frmAzuriranjeProdajeDodatnihPozicija UForm = null;
                    if ((UForm = (frmAzuriranjeProdajeDodatnihPozicija)IsFormAlreadyOpen(typeof(frmAzuriranjeProdajeDodatnihPozicija))) == null)
                    {
                        frmAzuriranjeProdajeDodatnihPozicija _frm = new frmAzuriranjeProdajeDodatnihPozicija();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.IDPozicije = IDpozicije;
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
                MessageBox.Show("Nemate niti jedanu poziciju koju biste ažurirali!");
            }
        }

        private void dgCjenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && operater_nivo_dozvoljava == 1)
            {
                if (gridView2.RowCount > 0)
                {
                    try
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite obrisati odabrani zapis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                            if (row != null)
                            {
                                IDpozicije = row[0].ToString();

                                veza.ExecuteQuery("Delete from pozicijaracun where pozicija_ID = " + IDpozicije + " ");
                                veza.ExecuteQuery("Delete from pozicijatrgovina where pozicija_poz_ID = " + IDpozicije + "");
                                veza.ExecuteQuery("Delete from pozicija where poz_ID = " + IDpozicije + "");
                                MessageBox.Show("Uspješno ste obrisali odabrani zapis!");
                                this.dodatnePozicijeTableAdapter.Fill(this.dodatne_pozicije.DodatnePozicije);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (e.KeyCode == Keys.F4 && operater_nivo_dozvoljava == 1)
            {
                if (gridView2.RowCount > 0)
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if (row != null)
                    {
                        IDpozicije = row[0].ToString();

                        //frmAzuriranjeProdajeDodatnihPozicija _frm;
                        //foreach (Form childForm in this.MdiChildren)
                        //{
                        //    if (childForm.GetType() == typeof(frmAzuriranjeProdajeDodatnihPozicija))
                        //    {
                        //        childForm.Focus();
                        //        return;
                        //    }
                        //}
                        //_frm = new frmAzuriranjeProdajeDodatnihPozicija();
                        //_frm.IDPozicije = IDpozicije;
                        //_frm.ShowDialog();

                        frmAzuriranjeProdajeDodatnihPozicija UForm = null;
                        if ((UForm = (frmAzuriranjeProdajeDodatnihPozicija)IsFormAlreadyOpen(typeof(frmAzuriranjeProdajeDodatnihPozicija))) == null)
                        {
                            frmAzuriranjeProdajeDodatnihPozicija _frm = new frmAzuriranjeProdajeDodatnihPozicija();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.IDPozicije = IDpozicije;
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
                    MessageBox.Show("Nemate niti jednu poziciju koju biste ažurirali!");
                }
            }
            else if (e.KeyCode == Keys.F7 && operater_nivo_dozvoljava == 1)
            {
                IDpozicije = "0";

                //frmAzuriranjeProdajeDodatnihPozicija _frm;

                //foreach (Form childForm in this.MdiChildren)
                //{
                //    if (childForm.GetType() == typeof(frmAzuriranjeProdajeDodatnihPozicija))
                //    {
                //        childForm.Focus();
                //        return;
                //    }
                //}
                //_frm = new frmAzuriranjeProdajeDodatnihPozicija();
                //_frm.IDPozicije = IDpozicije;
                //_frm.ShowDialog();

                frmAzuriranjeProdajeDodatnihPozicija UForm = null;
                if ((UForm = (frmAzuriranjeProdajeDodatnihPozicija)IsFormAlreadyOpen(typeof(frmAzuriranjeProdajeDodatnihPozicija))) == null)
                {
                    frmAzuriranjeProdajeDodatnihPozicija _frm = new frmAzuriranjeProdajeDodatnihPozicija();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.IDPozicije = IDpozicije;
                    _frm.Show();
                }
                else
                {
                    UForm.Focus();
                    return;
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (gridView2.RowCount > 0)
                {
                    try
                    {
                        DataTable artikli = new DataTable();
                        artikli = dodatne_pozicije.DodatnePozicije.CopyToDataTable();
                        //string skladisteBroj = txtSkladiste.Text;
                        //string brojNarudzbe = txtBrojNarudzbe.Text;
                        //string trgovina = txtNazivTrgovine.Text;
                        //string trgovinasifra = txtSifraTrgovine.Text;

                        //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                        if (gridView2.RowCount > 0)
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

                            report.Load(baseDir + "/report/DodatnePozicije.frx");
                            //report.SetParameterValue("skladiste", skladisteBroj);
                            //report.SetParameterValue("narudzba", brojNarudzbe);
                            //report.SetParameterValue("trgovina", trgovina);
                            //report.SetParameterValue("sifratrgovina", trgovinasifra);

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
            else if (e.KeyCode == Keys.F6)
            {
                if (gridView2.RowCount > 0)
                {
                    try
                    {
                        string value = "1";
                        if (InputBox.Input("Upišite mjesec", "Upišite za koji mjesec fakturirate:", ref value) == DialogResult.OK)
                        {
                            mjesec = value;
                        }
                        else
                        {
                            return;
                        }                         

                        string value2 = "2012";
                        if (InputBox.Input("Upišite godinu", "Upišite za koju godinu fakturirate:", ref value2) == DialogResult.OK)
                        {
                            godina = value2;
                        }
                        else
                        {
                            return;
                        }

                        upit = "'"+godina+"-" + mjesec + "-01' and '"+godina+"-" + mjesec + "-31'";


                        DataTable artikli = new DataTable();
                        //MessageBox.Show("select pozicijaracun.*,pozicija.poz_odkada, pozicija.poz_dokada, pozicija.poz_opis, pozicija.poz_opis2,operater.op_sifra, CONCAT(operater.op_ime,' ' ,operater.op_prezime), vrstapozicije.vp_naziv, partner.pa_sifra, partner.pa_naziv  from partner, vrstapozicije, operater, pozicija, pozicijaracun where operater.op_ID = pozicija.operater_OP_ID1 and vrstapozicije.vp_id = pozicija.vrstapozicije_pz_id and pozicija.partner_PA_ID = partner.pa_ID    and   pozicija.poz_ID = pozicijaracun.pozicija_ID and pozicijaracun.pozr_datumracuna between " + upit + "");
                        veza.ExecuteQuery("select pozicijaracun.*,pozicija.poz_odkada, pozicija.poz_dokada, pozicija.poz_opis, pozicija.poz_opis2,operater.op_sifra, CONCAT(operater.op_ime,' ' ,operater.op_prezime), vrstapozicije.vp_naziv, partner.pa_sifra, partner.pa_naziv  from partner, vrstapozicije, operater, pozicija, pozicijaracun where operater.op_ID = pozicija.operater_OP_ID1 and vrstapozicije.vp_id = pozicija.vrstapozicije_pz_id and pozicija.partner_PA_ID = partner.pa_ID    and   pozicija.poz_ID = pozicijaracun.pozicija_ID and pozicijaracun.pozr_datumracuna between "+upit+"", ref artikli);

                       
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

                            report.Load(baseDir + "/report/DogovorenePozicijeZaMjesec.frx");

                            // register the dataset
                            report.RegisterData(FDataSet);
                            report.SetParameterValue("Mjesec", mjesec);

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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGodina.Text != "")
                {
                    string god = txtGodina.Text;

                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime("" + god + "-12-31");
                    this.dodatnePozicijeTableAdapter.FillBy(this.dodatne_pozicije.DodatnePozicije, prvi, drugi);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false & char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Dozvoljeni su samo brojevi!", "Validion", MessageBoxButtons.OK);
            }
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            this.dodatnePozicijeTableAdapter.Fill(this.dodatne_pozicije.DodatnePozicije);
        }
    }
}
