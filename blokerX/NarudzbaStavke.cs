using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace blokerX
{
    public partial class frmStavkeNarudzbe : Form
    {
        Upiti veza = new Upiti();
        string _naruID;
        string _skladSifra;
        string _brojNaru;
        string _trgSifra;
        string _trgNaziv;
        string _poID;
        int brojac;
        string _brojDana;
        string _skladID;

        int poID = 0;
        int skladID = 0;
        int IDnarudzbe = 0;

        string datum;

        public frmStavkeNarudzbe()
        {
            InitializeComponent();
        }

        public string NarudzbaID
        {
            get { return _naruID; }
            set { _naruID = value; }
        }

        public string PoslovnicaID
        {
            get { return _poID; }
            set { _poID = value; }
        }

        public string SkladisteSifra
        {
            get { return _skladSifra; }
            set { _skladSifra = value; }
        }
        
        public string SkladisteID
        {
            get { return _skladID; }
            set { _skladID = value; }
        }

        public string BrojNarudzbe
        {
            get { return _brojNaru; }
            set { _brojNaru = value; }
        }
        public string trgovinaSifra
        {
            get { return _trgSifra; }
            set { _trgSifra = value; }
        }

        public string trgovinaNaziv
        {
            get { return _trgNaziv; }
            set { _trgNaziv = value; }
        }

        public string brojDana
        {
            get { return _brojDana; }
            set { _brojDana = value; }
        }

        private void frmStavkeNarudzbe_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                if (_naruID != "")
                {
                    poID = Convert.ToInt32(_poID);
                    skladID = Convert.ToInt32(_skladID);
                    //dohvati tip poslovnice za parametar procedure koja dohvaca stavke narudzbe

                    DataTable tipPoslovniceID = new DataTable();
                    veza.ExecuteQuery("select tipposlovnice.tip_ID ,tipposlovnice.tip_sifra, poslovnica.po_asortiman  from tipposlovnice, poslovnica where tipposlovnice.tip_sifra = poslovnica.tipposlovnice_tip_sifra and poslovnica.po_ID = " + poID + " ", ref tipPoslovniceID);

                    if (tipPoslovniceID.Rows.Count > 0)
                    {
                        poID = int.Parse(tipPoslovniceID.Rows[0][0].ToString());
                    }
                    else
                    {
                        poID = 0;
                    }

                    IDnarudzbe = Convert.ToInt32(_naruID);
                    //this.narudzbaStavkeTableAdapter.Fill(this.narudzbaStavke.narudzbaStavke,poID, IDnarudzbe);

                    prikaziArtikleNarudzbe();

                    txtBrojNarudzbe.Text = _brojNaru;
                    txtNazivTrgovine.Text = _trgNaziv;
                    txtSifraTrgovine.Text = _trgSifra;
                    txtSkladiste.Text = _skladSifra;
                    txtBrojDana.Text = _brojDana;
                    txtTip.Text = tipPoslovniceID.Rows[0][1].ToString() + " / " + tipPoslovniceID.Rows[0][2].ToString();
                    dgStavkeNarudzbe.Focus();
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

        private void frmStavkeNarudzbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private string danUTjednu(int skladiste, int poslovnica)
        {
            int danOD, isporukaDat, brojcanik;

            //dohvati dan u tjednu kad je isporuka iz tablice danzanarudzbu

            danOD = Convert.ToInt32(DateTime.Now.Date.DayOfWeek);
            DataTable isporuka = new DataTable();
            veza.ExecuteQuery("select dn_danutjednu from danzanarudzbu where poslovnica_po_id_skladista = '" + skladiste + "' and poslovnica_po_ID = '" + poslovnica + "'", ref isporuka);

            
            if (isporuka.Rows.Count > 0)
            {
                isporukaDat = Convert.ToInt32(isporuka.Rows[0][0]);


                //usporedi ta dva datuma
                if (isporukaDat < danOD)
                {
                    brojcanik = 7 - danOD;
                    datum =(DateTime.Now.Date.AddDays(brojcanik).AddDays(isporukaDat)).ToString("yyyy-MM-dd");
                }
                else if (isporukaDat == danOD)
                {
                    datum = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else if (isporukaDat > danOD)
                {
                    brojcanik = isporukaDat - danOD;
                    datum = (DateTime.Now.Date.AddDays(brojcanik)).ToString("yyyy-MM-dd");
                }
            }
            else
            {
                //ako nema datuma u tablici nadatum onda ostavi današnji
                datum = "";


                //ako nema dan za narudzbu za tu posl i sklad ne dozvoli zakljucivanje
                MessageBox.Show("Morate dodati dan za narudžbu za poslovnicu "+_trgSifra + " " + _trgNaziv+" i skladište  "+_skladSifra+" !!! ");
            }

            return datum;
        }
        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgStavkeNarudzbe.RowCount > 0)
                {

                    danUTjednu(skladID, Convert.ToInt32(_poID));

                    if (datum != "")
                    {
                        DialogResult result;

                        result = MessageBox.Show("Želite potvrditi narudžbu?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes)
                        {
                            btnZakljuci.Enabled = false;




                            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);

                            conn.Open();


                            MySqlTransaction transaction = conn.BeginTransaction();
                            MySqlCommand comm = new MySqlCommand();
                            

                            try
                            {
                                for (brojac = 0; brojac < dgStavkeNarudzbe.RowCount; brojac++)
                                {
                                    System.Data.DataRow row = dgStavkeNarudzbe.GetDataRow(brojac);
                                    string ar_ID = row[0].ToString();
                                    decimal odobreno = 0;
                                    string IDStavke = row["nas_ID"].ToString();
                                    decimal naruceno = 0;

                                    if (row["odobreno"].ToString() != "")
                                    {
                                        odobreno = Convert.ToDecimal(row["odobreno"]);
                                        string odobren = Convert.ToString(row["odobreno"]).Replace(',', '.');

                                        comm = new MySqlCommand(@"UPDATE narudzbastavka set nas_odobrenakolicina = '" + odobren + "' where nas_ID = " + IDStavke + "", conn);
                                        comm.ExecuteNonQuery();

                                        //veza.ExecuteQuery("UPDATE narudzbastavka set nas_odobrenakolicina = '" + odobren + "' where nas_ID = " + IDStavke + "");
                                        //veza.ExecuteQuery("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + odobren + " where ar_ID = " + ar_ID + "");
                                    }
                                    else if (row["odobreno"].ToString() == "" && row["narucena"].ToString() != "")
                                    {
                                        naruceno = Convert.ToDecimal(row["narucena"]);
                                        string narucen = Convert.ToString(row["narucena"]).Replace(',', '.');

                                        comm = new MySqlCommand(@"UPDATE narudzbastavka set nas_odobrenakolicina = '" + narucen + "' where nas_ID = " + IDStavke + "", conn);
                                        comm.ExecuteNonQuery();

                                        //veza.ExecuteQuery("UPDATE narudzbastavka set nas_odobrenakolicina = '" + narucen + "' where nas_ID = " + IDStavke + "");
                                        //veza.ExecuteQuery("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + narucen + " where ar_ID = " + ar_ID + "");
                                    }
  
                                }

                                transaction.Commit();
                                pobrisiNepotrebno();



                                veza.ExecuteQuery("Update narudzba set operater_op_IDP = " + Global.KorisnikID + ", na_potvrdjeno = 1, na_vrijemepotrvde = now(), na_datum = '" + datum + "' where na_ID = " + _naruID + "");

                                //provjeri ima li stavki u narudžbi
                                DataTable provjera = new DataTable();
                                veza.ExecuteQuery("select nas_ID from narudzbastavka where narudzba_na_ID = " + _naruID + "", ref provjera);

                                if (provjera.Rows.Count > 0)
                                {
                                    //ima stavke, ne treba brisati zaglavlje
                                }
                                else
                                {
                                    //briši zaglavlje jer je narudžba prazna
                                    veza.ExecuteQuery("Update narudzba set na_potvrdjeno = 1, na_ediObradjeno = 1 where na_ID = " + _naruID + " ");
                                }

                                MessageBox.Show("Narudžba je potvrđena!");
                                this.Close();
                                frmPotvrdiNarudzbu.osvjezi.PerformClick();

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                conn.Close();
                                MessageBox.Show("Zaključivanje nije uspjelo, pokušajte ponovno!");
                                btnZakljuci.Enabled = true;
                            }


                            //upisiNaruceneKolicine();
                            //pobrisiNepotrebno();

                        }
                    }
                }
                else
                {
                    veza.ExecuteQuery(String.Format("update narudzba set na_potvrdjeno = 1, na_ediObradjeno = 1 where na_ID = {0}", _naruID));
                    MessageBox.Show("Narudžba je potvrđena!");
                    this.Close();
                    frmPotvrdiNarudzbu.osvjezi.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgStavkeNarudzbe_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //try
            //{
            //    System.Data.DataRow row = dgStavkeNarudzbe.GetDataRow(dgStavkeNarudzbe.FocusedRowHandle);
            //     if (row != null)
            //     {
            //         int IDStavke = Convert.ToInt32(row["nas_ID"].ToString());

            //         decimal kolicina = 0;

            //         if (row["nas_odobrenakolicina"] != DBNull.Value)
            //         {
            //             kolicina = Convert.ToDecimal(row["nas_odobrenakolicina"]);
            //         }   

                    
            //         if (IDStavke != 0)
            //         {
            //             this.narudzbaStavkeTableAdapter.UpdateKolicina(kolicina, IDStavke);
            //             //dgStavkeNarudzbe.SetRowCellValue(dgStavkeNarudzbe.FocusedRowHandle, dgStavkeNarudzbe.Columns[20], "Da");
            //         }
            //     }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgStavkeNarudzbe_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string NemaRobe = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ar_nenarucuj"]);
                string datum = View.GetRowCellDisplayText(e.RowHandle, View.Columns["prc_vazido"]);
                //string oznaka = View.GetRowCellDisplayText(e.RowHandle, View.Columns["prepravi"]);

                if (NemaRobe == "Checked")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else if (datum != "")
                {
                    e.Appearance.ForeColor = Color.Green;
                }
                //else if (oznaka != "")
                //{
                //    e.Appearance.BackColor = Color.Azure;
                //}
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if (dgStavkeNarudzbe.RowCount > 0)
            {
                try
                {
                    DataTable artikli = new DataTable();
                    artikli = narudzbaStavke.narudzbaStavke.CopyToDataTable(); 
                    string skladisteBroj = txtSkladiste.Text;
                    string brojNarudzbe = txtBrojNarudzbe.Text;
                    string trgovina = txtNazivTrgovine.Text;
                    string trgovinasifra = txtSifraTrgovine.Text;

                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    if (dgStavkeNarudzbe.RowCount > 0)
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

                        report.Load(baseDir + "/report/StavkeNepotvrdjeneNarudzbe.frx");
                        report.SetParameterValue("skladiste", skladisteBroj);
                        report.SetParameterValue("narudzba", brojNarudzbe);
                        report.SetParameterValue("trgovina", trgovina);
                        report.SetParameterValue("sifratrgovina", trgovinasifra);

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

        private void frmStavkeNarudzbe_Deactivate(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void upisiNaruceneKolicine()
        {
            try
            {
                for (brojac = 0; brojac < dgStavkeNarudzbe.RowCount; brojac++)
                {
                    System.Data.DataRow row = dgStavkeNarudzbe.GetDataRow(brojac);
                    string ar_ID = row[0].ToString();
                    decimal odobreno = 0;
                    string IDStavke = row["nas_ID"].ToString();
                    decimal naruceno = 0;
                     
                    if (row["odobreno"].ToString() != "")
                    {
                        odobreno = Convert.ToDecimal(row["odobreno"]);
                        string odobren = Convert.ToString(row["odobreno"]).Replace(',', '.');

                        veza.ExecuteQuery("UPDATE narudzbastavka set nas_odobrenakolicina = '" + odobren + "' where nas_ID = " + IDStavke + "");
                        veza.ExecuteQuery("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + odobren + " where ar_ID = " + ar_ID + "");
                    }
                    else if (row["odobreno"].ToString() == "" && row["narucena"].ToString() != "")
                    {
                        naruceno =  Convert.ToDecimal(row["narucena"]);
                        string narucen = Convert.ToString(row["narucena"]).Replace(',', '.');

                        veza.ExecuteQuery("UPDATE narudzbastavka set nas_odobrenakolicina = '" + narucen + "' where nas_ID = " + IDStavke + "");
                        veza.ExecuteQuery("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + narucen + " where ar_ID = " + ar_ID + "");
                    }

                    //string ar_ID = row[0].ToString();
                    //if (row["odobreno"].ToString() != "")
                    //{
                    //    odob = Convert.ToString(row["odobreno"]).Replace(',', '.');
                    //}
                    //else
                    //{
                    //    odob = "0";
                    //}
                   
                    ////MessageBox.Show("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + odob + " where ar_ID = " + ar_ID + "");
                    //veza.ExecuteQuery("UPDATE artikl set ar_dnevnoodobreno = ar_dnevnoodobreno + " + odob + " where ar_ID = "+ar_ID+"");
                    //if (naruceno == 0 && odobreno == 0)
                    //{
                       
                    //}
                    //else if (naruceno != 0 && odobreno == 0)
                    //{

                    //}
                    //else if(naruceno == 0 && odobreno != 0)
                    //{
                    //    if (row != null)
                    //    {
                    //        if (row["prepravi"].ToString() != "Da")
                    //        {                                           
                    //            //MessageBox.Show("UPDATE narudzbastavka set nas_odobrenakolicina = '" + narucenaKolicina + "' where nas_ID = " + IDStavke + "");
                    //        }
                    //    }
                    //}                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pobrisiNepotrebno()
        {
            try
            {
                //int ponisti = 1;

                for (brojac = 0; brojac < dgStavkeNarudzbe.RowCount; brojac++)
                {
                    System.Data.DataRow row = dgStavkeNarudzbe.GetDataRow(brojac);
                    string IDnarudzbe = row["narudzba_na_ID"].ToString();

                    veza.ExecuteQuery("Delete from narudzbastavka where narudzba_na_ID = " + IDnarudzbe + " and  nas_odobrenakolicina = 0 and nas_kolicina = 0");

                    //if (row != null)
                    //{

                    //provjeri stavke ukoliko sve odobreno 0 onda poništi zaglavlje
                    //decimal odobreno = 0;

                    //if (row["odobreno"] != DBNull.Value)
                    //{
                    //    odobreno = Convert.ToDecimal(row["odobreno"]);
                    //    if (odobreno > 0)
                    //    {
                    //        //ako i jedna stavka ima odobreno > 0 onda  ne poništavaj
                    //        ponisti = 0;
                    //    }
                    //}

                    //    decimal naruceno = Convert.ToDecimal(row["nas_kolicina"]);
                    //    if (naruceno == 0 && odobreno == 0)
                    //    {
                    //        //string IDStavke = row["nas_ID"].ToString();
                    //        //MessageBox.Show("UPDATE narudzbastavka set nas_odobrenakolicina = '" + narucenaKolicina + "' where nas_ID = " + IDStavke + "");
                    //        veza.ExecuteQuery("delete from narudzbastavka  where nas_ID = " + IDStavke + "");
                    //    }
                    //}

                    
                }

                //ako je ponisti = 1 znaci sve stavke imaju odobrenu kolicinu 0 - posnisti narudzbu
                //if (ponisti == 1)
                //{
                //    //veza.ExecuteQuery("update narudzba set na_ponistena = 1 where na_ID = " + _naruID + "");
                //}                

                //provjeri ima li stavki, ako ne zaglavnje ponisteno = 1
                DataTable podaci = new DataTable();

                veza.ExecuteQuery("select nas_ID from narudzbastavka where narudzba_na_ID = " + _naruID + "" , ref podaci);

                if (podaci.Rows.Count > 0)
                {
                    //postoje stavke narudzbe
                    //provjeri da li sve stavke imaju odobrenu količinu < 0 ili da barem jedna ima > 0 

                    DataTable provjera = new DataTable();

                    veza.ExecuteQuery("select * from narudzbastavka where narudzbastavka.narudzba_na_ID = " + _naruID + " and narudzbastavka.nas_odobrenakolicina > 0 ", ref provjera);

                    if (provjera.Rows.Count > 0)
                    {
                        //postoji stavka kojoj je odobrena količina veća od 0 ne poništavaj zaglavlje
                    }
                    else
                    {
                        //sve stavke imaju odobrenu količinu 0, poništi zaglavlje
                        veza.ExecuteQuery("update narudzba set na_ponistena = 1 where na_ID = " + _naruID + "");
                    }

                }
                else
                {
                    veza.ExecuteQuery("update narudzba set na_ponistena = 1 where na_ID = " + _naruID + "");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgStavkeNarudzbe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption != "Ispravljena količina") return;
            //string cellValue = dgStavkeNarudzbe.GetRowCellValue(e.RowHandle,dgStavkeNarudzbe.Columns["LastName"];
            dgStavkeNarudzbe.SetRowCellValue(e.RowHandle, dgStavkeNarudzbe.Columns["prepravi"], "Da");
        }

        private void dgStavkeNarudzbe_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    dgStavkeNarudzbe.FocusedColumn = dgStavkeNarudzbe.VisibleColumns[4];

                    dgStavkeNarudzbe.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgStavkeNarudzbe.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgStavkeNarudzbe.FocusedColumn = dgStavkeNarudzbe.VisibleColumns[4];

                    dgStavkeNarudzbe.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgStavkeNarudzbe.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgStavkeNarudzbe_GotFocus(object sender, EventArgs e)
        {
            dgStavkeNarudzbe.FocusedColumn = dgStavkeNarudzbe.VisibleColumns[4];

            dgStavkeNarudzbe.ShowEditor();

            DevExpress.XtraEditors.TextEdit edit = dgStavkeNarudzbe.ActiveEditor as DevExpress.XtraEditors.TextEdit;

            if (edit != null)
                edit.SelectAll();
        }

        private void dgStavkeNarudzbe_MouseWheel(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DevExpress.XtraEditors.TextEdit edit = dgStavkeNarudzbe.ActiveEditor as DevExpress.XtraEditors.TextEdit;


            //view.CloseEditor();
            if (e.Delta < 0)
            {
                view.MoveNext();
                dgStavkeNarudzbe.FocusedColumn = dgStavkeNarudzbe.VisibleColumns[4];

                dgStavkeNarudzbe.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }
            else if (e.Delta > 0)
            {
                view.MovePrev();
                dgStavkeNarudzbe.FocusedColumn = dgStavkeNarudzbe.VisibleColumns[4];

                dgStavkeNarudzbe.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }

            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }
            
        public void prikaziArtikleNarudzbe()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
                MySqlCommand comm = new MySqlCommand("dohvatiStavkeNarudzbe2", conn);
                comm.CommandType = CommandType.StoredProcedure;


                MySqlParameter prm = new MySqlParameter("@poslovnicaID", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = poID;
                comm.Parameters.Add(prm);


                prm = new MySqlParameter("@narudzbaID", MySqlDbType.Int16);
                prm.Direction = ParameterDirection.Input;
                prm.Value = IDnarudzbe;
                comm.Parameters.Add(prm);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                if (dgStavkeNarudzbe.RowCount > 0)
                {
                    narudzbaStavke.Tables["Table"].Clear();
                    dgStavke.DataSource = narudzbaStavke.Tables[""];
                }

                adapter.Fill(narudzbaStavke, "Table");
                dgStavke.DataSource = narudzbaStavke.Tables["Table"];
                narudzbaStavkeBindingSource = new BindingSource(narudzbaStavke, "Table");
                dgStavke.DataSource = narudzbaStavkeBindingSource;
                dgStavke.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }               
        }
    }
}
