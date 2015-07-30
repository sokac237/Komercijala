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

namespace blokerX
{
    public partial class frmNovaAkcija : Form
    {
        int obrisan = 0;
        int topRowIndex;
        int focus;

        public static Button osvjezi = new Button();
        Upiti veza = new Upiti();

        string _oznaka;
        int brojAkcije;
        string noviRedniBroj;
        string datumOD;
        string datumDO;
        int aktivna;
        string popust;
        string sifraVezane;
        int brojVezane;
        string _akcijaID;
        string _akcijabroj;
        string _SifraAkcije;
        string partnerID;
        string partnerSifra;

        public frmNovaAkcija()
        {
            InitializeComponent();
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string akcijaID
        {
            get { return _akcijaID; }
            set { _akcijaID = value; }
        }

        public string akcijaBroj
        {
            get { return _akcijabroj; }
            set { _akcijabroj = value; }
        }

        public string sifraAkcije
        {
            get { return _SifraAkcije; }
            set { _SifraAkcije = value; }
        }


        private void frmNovaAkcija_Load(object sender, EventArgs e)
        {
            this.partnerTableAdapter.Fill(this.dobavljac.partner);
            glPartner.Enabled = false;
            osvjezi = btnRefresh;
            if (_SifraAkcije == "13" || _SifraAkcije == "7")
            {
                btnPosalji.Visible = true;
            }

            if (_oznaka == "A") //azuriraj
            {
                this.kategorijeAkcijaTableAdapter.Fill(this.kategorijeAkcija.kategorijeAkcija);
                DataTable podaci = new DataTable();
                veza.ExecuteQuery("select pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana, partner_pa_ID from mpman.akcijezag where akc_ID = " + _akcijaID + "", ref podaci);

                this.akcijeTableAdapter.Fill(this.nova_akcija_stavke.akcije, Convert.ToInt32(_akcijaID),_SifraAkcije,_akcijabroj);

                if (podaci.Rows.Count > 0)
                {
                    glKategorija.EditValue = podaci.Rows[0][0];
                    txtBrojAkcije.Text = podaci.Rows[0][1].ToString();
                    dtpODKada.Text = podaci.Rows[0][2].ToString();
                    dtpDOKada.Text = podaci.Rows[0][3].ToString();
                    txtOpis.Text = podaci.Rows[0][4].ToString();

                    string a = podaci.Rows[0][5].ToString();
                    if (podaci.Rows[0][5].ToString() == "True")
                    {
                        cmbAktivna.Text = "Da";
                    }
                    else
                    {
                        cmbAktivna.Text = "Ne";
                    }
                    txtPopust.Text = podaci.Rows[0][6].ToString();

                    if (podaci.Rows[0][7].ToString() == "True")
                    {
                        cmbAkcijaVezana.Text = "Da";
                    }
                    else
                    {
                        cmbAkcijaVezana.Text = "Ne";
                    }

                    glSifraVezane.EditValue = podaci.Rows[0][8];

                    //provjeriti postoji li partner i ako je akcija sifra 13 onda prikaži partnera

                    if (podaci.Rows[0][0].ToString() == "13" || podaci.Rows[0][0].ToString() == "7")
                    {
                        //provjeri partnera

                        if (podaci.Rows[0][9].ToString() != "")
                        {
                            //postoji partner u kaciji 13 prikaži ga
                            glPartner.Enabled = true;
                            glPartner.EditValue = podaci.Rows[0][9];

                            Global.akcija13dobavljac = glPartner.EditValue.ToString();
                        }
                        else
                        {
                            Global.akcija13dobavljac = "";
                        }
                    }
                   
                }

                glKategorija.Enabled = false;
                txtBrojAkcije.Enabled = false;        

            }
            else //insert
            {
                this.kategorijeAkcijaTableAdapter.Fill(this.kategorijeAkcija.kategorijeAkcija);
                txtBrojAkcije.Visible = false;
                label2.Visible = false;
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

        private void dgAkcijeStavke_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                topRowIndex = dgAkcijaStavka.TopRowIndex;
                focus = dgAkcijaStavka.FocusedRowHandle;

                if (e.KeyCode == Keys.F4)
                {
                    if (dgAkcijaStavka.RowCount > 0)
                    {
                        System.Data.DataRow row = dgAkcijaStavka.GetDataRow(dgAkcijaStavka.FocusedRowHandle);
                        if (row != null)
                        {
                            if (txtBrojAkcije.Text != "")
                            {
                                frmNovaAkcijaStavke UForm = null;
                                if ((UForm = (frmNovaAkcijaStavke)IsFormAlreadyOpen(typeof(frmNovaAkcijaStavke))) == null)
                                {
                                    frmNovaAkcijaStavke _frm = new frmNovaAkcijaStavke();
                                    _frm.MdiParent = frmMain.ActiveForm;
                                    _frm.oznaka = "A";
                                    _frm.IDstavka = row[0].ToString();
                                    _frm.sifraAkcije = row[2].ToString();
                                    _frm.brojAkcije = row[3].ToString();
                                    //_frm.IDZaglavlja = _akcijaID;
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
                        MessageBox.Show("Nemate niti jednu stavku koju biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    if (txtBrojAkcije.Text != "")
                    {
                        DohvatiSifruID dohvati = new DohvatiSifruID();
                        string IDZAG = dohvati.DohvatiIDSifra("akc_ID", "mpman.akcijezag", "akc_broj = " + txtBrojAkcije.Text.Trim() + "");
                        frmNovaAkcijaStavke UForm = null;
                        if ((UForm = (frmNovaAkcijaStavke)IsFormAlreadyOpen(typeof(frmNovaAkcijaStavke))) == null)
                        {
                            frmNovaAkcijaStavke _frm = new frmNovaAkcijaStavke();
                            _frm.MdiParent = frmMain.ActiveForm;
                            _frm.sifraAkcije = glKategorija.EditValue.ToString();
                            _frm.brojAkcije = txtBrojAkcije.Text.Trim();
                            _frm.popust = txtPopust.Text;
                            _frm.OD = dtpODKada.Text;
                            _frm.DO = dtpDOKada.Text;
                            _frm.opisZag = txtOpis.Text.Trim();
                            _frm.oznaka = "I";
                            _frm.IDZaglavlja = IDZAG;
                            _frm.Show();
                        }
                        else
                        {
                            UForm.Focus();
                            return;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F9)
                {
                    DialogResult result;
                    result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        //gridView1.ExportToXls(@"c:\Podaci\Podaci.xls");
                        ExcelExport();
                    }
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    if (dgAkcijaStavka.RowCount > 0)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Želite obrisati odabrani podatak!?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            System.Data.DataRow row = dgAkcijaStavka.GetDataRow(dgAkcijaStavka.FocusedRowHandle);
                            if (row != null)
                            {
                                string IDstavke = row[0].ToString();

                                veza.ExecuteQuery("delete from mpman.akcije where akc_ID ="+IDstavke+"");
                                this.akcijeTableAdapter.Fill(this.nova_akcija_stavke.akcije, Convert.ToInt32(_akcijaID), _SifraAkcije, _akcijabroj);
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }


        private void ExcelExport()
        {
            var bindingSource = (BindingSource)this.dgAkcijaStavka.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();


            //Export DataTable.
            if (this.dgAkcijaStavka != null)
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


            dgAkcijaStavka.ExportToExcelOld(@"c:\Podaci\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void odrediBrojAkcije()
        {
            try
            {
                DataTable broj = new DataTable();

                veza.ExecuteQuery("select se_trenutnibr from serija where dokumentVrsta_dv_ID = 9", ref broj);

                if (broj.Rows.Count == 0)
                {
                    int godina = DateTime.Now.Year;
                    veza.ExecuteQuery("insert into serija (dokumentVrsta_dv_ID , PG_GODINA) values (9, "+godina+")");
                }
                else
                {
                    veza.ExecuteQuery("update serija set se_trenutnibr = se_trenutnibr +1 where dokumentVrsta_dv_ID = 9");
                }
                veza.ExecuteQuery("select se_trenutnibr from serija where dokumentVrsta_dv_ID = 9", ref broj);

                brojAkcije = Convert.ToInt32(broj.Rows[0][0].ToString());

                if(broj.Rows[0][0].ToString().Length == 1)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2,2) + "0000" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 2)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2,2) + "000" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 3)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2,2) + "00" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 4)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2,2) + "0" + brojAkcije;
                }
                else if (broj.Rows[0][0].ToString().Length == 5)
                {
                    noviRedniBroj = DateTime.Now.Year.ToString().Substring(2,2) + brojAkcije;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {            
            try
            {
                if (_oznaka == "A") //ažuriranje
                {
                    pokupiPodatke();

                    veza.ExecuteQuery("update mpman.akcijezag set akc_datumod = '" + datumOD + "', akc_datumdo = '" + datumDO + "', akc_opis = '" + txtOpis.Text.Trim() + "', akc_aktivna = " + aktivna + " , akc_popust = " + popust + " , akc_vezana = " + brojVezane + ", pok_sifravezana = " + sifraVezane + ", operater_op_ID = "+Global.KorisnikID+", partner_pa_ID = "+partnerID+", partner_pa_sifra = "+partnerSifra+" where akc_ID = " + _akcijaID + "");

                    MessageBox.Show("Uspješno ste ažurirali podatke!");

                    dtpDOKada.Enabled = false;
                    glKategorija.Enabled = false;
                    dtpDOKada.Enabled = false;
                    cmbAktivna.Enabled = false;
                    cmbAkcijaVezana.Enabled = false;

                    frmPregledAkcija.refresh.PerformClick();
                }
                else //insert
                {
                    if (glKategorija.Text != "")
                    {
                        odrediBrojAkcije();

                        pokupiPodatke();
                        
                        //MessageBox.Show("insert into akcijezag (pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana ) values (" + glKategorija.EditValue + "," + noviRedniBroj + ",'" + datumOD + "','" + datumDO + "', '" + txtOpis.Text.Trim() + "'," + aktivna + ", " + popust + ", " + txtBrojVezaneAkcije.Text.Trim() + ", " + sifraVezane + ")");

                        veza.ExecuteQuery("insert into mpman.akcijezag (pok_sifra, akc_broj, akc_datumod, akc_datumdo, akc_opis, akc_aktivna, akc_popust, akc_vezana, pok_sifravezana , operater_op_ID, partner_pa_ID, partner_pa_sifra) values (" + glKategorija.EditValue + "," + noviRedniBroj + ",'" + datumOD + "','" + datumDO + "', '" + txtOpis.Text.Trim() + "'," + aktivna + ", " + popust + ", " + brojVezane + ", " + sifraVezane + ", '"+Global.KorisnikID+"', "+partnerID+", "+partnerSifra+")");
                        
                        MessageBox.Show("Uspješno ste dodali zaglavlje nove akcije!");


                        dtpDOKada.Enabled = false;
                        dtpODKada.Enabled = false;
                        glKategorija.Enabled = false;
                        dtpDOKada.Enabled = false;
                        cmbAktivna.Enabled = false;
                        cmbAkcijaVezana.Enabled = false;
                        txtPopust.Enabled = false;
                        txtOpis.Enabled = false;
                        glPartner.Enabled = false;

                                                
                        txtBrojAkcije.Visible = true;
                        label2.Visible = true;
                        txtBrojAkcije.Text = noviRedniBroj;
                        txtBrojAkcije.Enabled = false;
                        btnSpremi.Visible = false;
                        frmPregledAkcija.refresh.PerformClick();
                    }
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatke()
        {
            if (cmbAktivna.Text == "Da")
            {
                aktivna = 1;
            }
            else
            {
                aktivna = 0;
            }

            if (txtPopust.Text.ToString() == "")
            {
                popust = "0";
            }
            else
            {
                popust = Convert.ToString(txtPopust.Text).Replace(',', '.');
            }

            datumOD = Convert.ToDateTime(dtpODKada.Text).ToString("yyyy-MM-dd");

            datumDO = Convert.ToDateTime(dtpDOKada.Text).ToString("yyyy-MM-dd");

            if (glSifraVezane.Text != "")
            {
                sifraVezane = glSifraVezane.EditValue.ToString();
            }
            else
            {
                sifraVezane = "null";
            }

            if (cmbAkcijaVezana.Text == "Da")
            {
                brojVezane = 1;
            }
            else
            {
                brojVezane = 0;
            }

            if (glPartner.Enabled == true && glPartner.Text == "")
            {
                //ako nema odabranog partnera postavi default vrijednost
                partnerID = "null";
                partnerSifra = "null";
                Global.akcija13dobavljac = "";
            }
            else if (glPartner.Enabled == true && glPartner.Text != "")
            {
                partnerID = glPartner.EditValue.ToString();

                DohvatiSifruID dohvati = new DohvatiSifruID();

                partnerSifra = dohvati.DohvatiIDSifra("pa_sifra", "partner", "pa_ID = " + partnerID + "");


                //spremi u globalnu varijablu da u stavkama znam što omoguciti

                Global.akcija13dobavljac = partnerID;
            }
            else
            {
                partnerID = "null";
                partnerSifra = "null";
                Global.akcija13dobavljac = "";
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovaAkcija_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbAkcijaVezana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAkcijaVezana.Text == "Da") 
            {
                glSifraVezane.Enabled = true;
                glSifraVezane.Focus();
            }
            else if (cmbAkcijaVezana.Text == "Ne") 
            {
                glSifraVezane.Enabled = false;
                glSifraVezane.EditValue = 0;
            }
        }

        private void glSifraVezane_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                glSifraVezane.EditValue = 0;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_oznaka == "A")
            {
                this.akcijeTableAdapter.Fill(this.nova_akcija_stavke.akcije, Convert.ToInt32(_akcijaID), _SifraAkcije, _akcijabroj);
            }
            else
            {
                //insert
                this.akcijeTableAdapter.Fill(this.nova_akcija_stavke.akcije, Convert.ToInt32(Global.akcijaZagID), Global.akcijaSifra, Global.akcijaBroj);
            }

            if (obrisan == 1)
            {
                dgAkcijaStavka.TopRowIndex = topRowIndex;
            }
            else
            {
                dgAkcijaStavka.TopRowIndex = topRowIndex;
                dgAkcijaStavka.SelectRow(focus);
            }
        }

        private void glKategorija_EditValueChanged(object sender, EventArgs e)
        {
            //ako je akcija 13 omogući dodavanje dobavljaca
            if (glKategorija.EditValue.ToString() == "13")
            {
                glPartner.Enabled = true;

                lblPoruka.Text = "<--- Ako je nagradna igra uvjetovana \niznosom odaberite dobavljača!";
                
            }
            else if(glKategorija.EditValue.ToString() == "7")
            {
                glPartner.Enabled = true;

                lblPoruka.Text = "<--- Ako je kupon na količinu uvjetovan \niznosom odaberite dobavljača!";
            }
            else
            {
                glPartner.Enabled = false;
                lblPoruka.Text = "";
            }
        }

        private void glPartner_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    //ako nema dodane stavke omogući dodavanje i brisanje dobavljaca

                    if (dgAkcijaStavka.RowCount > 0)
                    {
                        
                        glPartner.Enabled = false;
                    }
                    else
                    {
                        glPartner.EditValue = 0;
                    }

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            DataTable operaterModul = new DataTable();

            veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = " + Global.KorisnikID + " and opov_modul = 'AKCIJETRGOVINA' ", ref operaterModul);

            if (operaterModul.Rows.Count > 0)
            {
                if (dgAkcijaStavka.RowCount > 0)
                {
                    frmAkcijeZaTrgovinu _frm;
                    foreach (Form childForm in frmMain.ActiveForm.MdiChildren)
                    {
                        if (childForm.GetType() == typeof(frmAkcijeZaTrgovinu))
                        {
                            childForm.Focus();
                            return;
                        }
                    }
                    _frm = new frmAkcijeZaTrgovinu();
                    _frm.MdiParent = frmMain.ActiveForm;
                    _frm.oznaka = "S"; //S - sniženi artikli od dobavljača
                    _frm.AkcijaBroj = txtBrojAkcije.Text.Trim();
                    _frm.Show();

                    this.Close();
                }
            }
        }
    }
}
