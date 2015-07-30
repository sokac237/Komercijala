using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using SmartXLS;

namespace blokerX
{
    public partial class frmSnizenjaObracun : Form
    {
        Upiti veza = new Upiti();

        string IDSnizenja;
        string brojSnizenja;
        string poslovnicaID;
        string vrijednost;
        decimal kolicina;
        decimal popust;
        decimal cijena;
        decimal nabavna;
        decimal prodajna;

        decimal iznosTrgovina = 0;
        decimal iznosUkupni = 0;

        public frmSnizenjaObracun()
        {
            InitializeComponent();
        }

        private void frmSnizenjaObracun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pregled_akcija.snizenja' table. You can move, or remove it, as needed.
            this.snizenjaTableAdapter.Fill(this.pregled_akcija.snizenja);

        }

        private void btnPreracunaj_Click(object sender, EventArgs e)
        {
            if (dgSnizenja.RowCount > 0)
            {
                btnPreracunaj.Enabled = false;

                System.Data.DataRow row = dgSnizenja.GetDataRow(dgSnizenja.FocusedRowHandle);

                if (row != null)
                {
                    IDSnizenja = row[0].ToString();
                    brojSnizenja = row[1].ToString();
                    vrijednost = row[8].ToString();

                    //provjeri ako postoji vrijednost onda samo ispis jer je vec obracunan

                    if (vrijednost != "")
                    {
                        //obracunato je vec samo ispis
                    }
                    else
                    {
                        //obracunaj financijsko za trgovine / stavke i ispisi

                        //dohvati podatke o broju trgovina


                        DataTable brojPoslovnica = new DataTable();

                        veza.ExecuteQuery("select poslovnica_po_id from mpman.akcije where akcijezag_akc_id = '" + IDSnizenja + "'  group by poslovnica_po_id", ref brojPoslovnica);

                        if (brojPoslovnica.Rows.Count > 1)
                        {
                            
                            iznosUkupni = 0;
                            //ima vise trgovina , obracunaj za svaku posebno
                            for (int i = 0; i < brojPoslovnica.Rows.Count; i++)
                            { 
                                //za svaki id trgovine dohvati posebno podatke i obracunaj
                                DataTable akcijaStavke = new DataTable();
                                poslovnicaID = brojPoslovnica.Rows[i][0].ToString();

                                veza.ExecuteQuery("select akcije.pok_kolic, akcije.akc_popust,  akc_cijena, poslovnica_po_id, poslovnica.po_sifra, poslovnica.po_naziv, akc_nabavna, akc_prodajnacijena, mpman.akcijezag.akc_broj from mpman.akcije left join poslovnica on poslovnica.po_id = mpman.akcije.poslovnica_po_id left join mpman.akcijezag on mpman.akcijezag.AKC_ID = mpman.akcije.AKCIJEZAG_AKC_ID where mpman.akcijezag.akc_id = akcije.akcijezag_akc_id and akcijezag_akc_id = '" + IDSnizenja + "'  and akcije.poslovnica_po_id = '"+poslovnicaID+"' order by mpman.akcije.poslovnica_po_id", ref akcijaStavke);

                                if (akcijaStavke.Rows.Count > 0)
                                {
                                    //za svaku stavku po poslovnicama napravi obracun

                                    iznosTrgovina = 0;
                                    for (int a = 0; a < akcijaStavke.Rows.Count; a++)
                                    {
                                        popust = Convert.ToDecimal(akcijaStavke.Rows[a][1]);
                                        cijena = Convert.ToDecimal(akcijaStavke.Rows[a][2]);
                                        kolicina = Convert.ToDecimal(akcijaStavke.Rows[a][0]);
                                        nabavna = Convert.ToDecimal(akcijaStavke.Rows[a][6]);
                                        prodajna = Convert.ToDecimal(akcijaStavke.Rows[a][7]);
                                        //ako je popust = 0
                                        //string aaaa = akcijaStavke.Rows[a][1].ToString();
                                        if (akcijaStavke.Rows[a][1].ToString() == "0,00")
                                        {
                                            //moram izracunati postotak snizenja
                                            //formula: (prodajnaCijenaIzTrgovine / unesenacijena) - 1 == %snizenja
                                            popust = (prodajna / cijena) - 1;
                                            //%snizenja * nabavnacijena * kolicina = iznos
                                            iznosTrgovina += popust * kolicina * nabavna;
                                        }
                                        else
                                        {
                                            //postoji postotak snizenja
                                            //formula: %snizenja * nabavnacijena * kolicina = iznos

                                            iznosTrgovina += (popust / 100) * kolicina * nabavna;

                                        }
                                    }

                                    //update gratis vrijednost za taj broj akcije i poslovnicu
                                    veza.ExecuteQuery("update gratis set gr_vrijednostsnizenja = '" + Convert.ToString(iznosTrgovina).Replace(',', '.') + "' where akc_broj = '" + brojSnizenja + "' and poslovnica_po_id ='" + poslovnicaID + "'");


                                }
                                iznosUkupni += iznosTrgovina;
                            }

                           
                            //update zaglavlje akcije vrijednost snizenja za taj id akcije
                            veza.ExecuteQuery("update mpman.akcijezag set akc_vrijednostsnizenja ='" + Convert.ToString(iznosUkupni).Replace(',', '.') + "' where akc_id = '" + IDSnizenja + "'");

                        }
                        else
                        {
                            iznosTrgovina = 0;
                            iznosUkupni = 0;
                            //ima jedna trgovina obracunaj samo za nju

                            DataTable akcijaStavke = new DataTable();

                            veza.ExecuteQuery("select akcije.pok_kolic, akcije.akc_popust,  akc_cijena, poslovnica_po_id, poslovnica.po_sifra, poslovnica.po_naziv, akc_nabavna, akc_prodajnacijena, mpman.akcijezag.akc_broj from mpman.akcije left join poslovnica on poslovnica.po_id = mpman.akcije.poslovnica_po_id left join mpman.akcijezag on mpman.akcijezag.AKC_ID = mpman.akcije.AKCIJEZAG_AKC_ID where akcijezag.akc_id = akcije.akcijezag_akc_id and akcijezag_akc_id = '" + IDSnizenja + "' order by mpman.akcije.poslovnica_po_id", ref akcijaStavke);

                            if (akcijaStavke.Rows.Count > 0)
                            {
                                //za svaku stavku napravi obracun

                                poslovnicaID = akcijaStavke.Rows[0][3].ToString();

                                for (int i = 0; i < akcijaStavke.Rows.Count; i++)
                                {
                                    popust = Convert.ToDecimal(akcijaStavke.Rows[i][1]);
                                    cijena = Convert.ToDecimal(akcijaStavke.Rows[i][2]);
                                    kolicina = Convert.ToDecimal(akcijaStavke.Rows[i][0]);
                                    nabavna = Convert.ToDecimal(akcijaStavke.Rows[i][6]);
                                    prodajna = Convert.ToDecimal(akcijaStavke.Rows[i][7]);
                                    //za svaku stavku racunaj
                                    //ako je popust = 0
                                    if (akcijaStavke.Rows[i][1].ToString() == "0,00")
                                    {
                                        //moram izracunati postotak snizenja
                                        //formula: (prodajnaCijenaIzTrgovine / unesenacijena) - 1 == %snizenja
                                        popust = (prodajna / cijena) - 1;
                                        //%snizenja * nabavnacijena * kolicina = iznos
                                        iznosTrgovina += popust * kolicina * nabavna;
                                    }
                                    else
                                    {
                                        //postoji postotak snizenja
                                        //formula: %snizenja * nabavnacijena * kolicina = iznos
                                        iznosTrgovina += (popust / 100) * kolicina * nabavna;
                                    }

                                }

                                iznosUkupni = iznosTrgovina;

                                //update gratis vrijednost za taj broj akcije i poslovnicu
                                veza.ExecuteQuery("update gratis set gr_vrijednostsnizenja = '" + Convert.ToString(iznosTrgovina).Replace(',', '.') + "' where akc_broj = '" + brojSnizenja + "' and poslovnica_po_id ='" + poslovnicaID + "'");

                                //update zaglavlje akcije vrijednost snizenja za taj id akcije
                                veza.ExecuteQuery("update mpman.akcijezag set akc_vrijednostsnizenja ='" + Convert.ToString(iznosUkupni).Replace(',', '.') + "' where akc_id = '" + IDSnizenja + "'");
                            }
                        }


                       
                    }
                    this.snizenjaTableAdapter.Fill(this.pregled_akcija.snizenja);
                    btnPreracunaj.Enabled = true;
                    //prikazi izvjestaj
                    ispis(brojSnizenja);
           
                }
            }
        }

        private void dgSnizenja_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string vrijednost = View.GetRowCellDisplayText(e.RowHandle, View.Columns["AKC_VRIJEDNOSTSNIZENJA"]);

                if (vrijednost == "")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }


        public void ispis(string broj)
        {
            try
            {
                DataTable finacijsko = new DataTable();

                veza.ExecuteQuery("select partner.pa_sifra, partner.PA_NAZIV, gratis.gr_datum, gratis.akc_broj, gratis.gr_vrijednostsnizenja, gratis.gr_zapisnik, poslovnica.po_sifra, poslovnica.po_naziv from gratis left join poslovnica on poslovnica.po_id=gratis.poslovnica_PO_ID left join partner on partner.PA_ID=gratis.partneri_PA_ID where gratis.akc_broj ='"+broj+"'", ref finacijsko);


                if (finacijsko.Rows.Count > 0)
                {
                    //create dataset 
                    DataSet FDataSet = new DataSet();
                    finacijsko.TableName = "Financijsko";
                    FDataSet.Tables.Add(finacijsko);

                    // create report instance
                    Report report = new Report();

                    // load the existing report
                    System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    report.Load(baseDir + "/report/Financijsko_snizenja.frx");

                    // register the dataset
                    report.RegisterData(FDataSet);
                    report.SetParameterValue("Mjesec", "2");

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
            }
        }

        private void dgSnizenjaObracun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgSnizenja.RowCount > 0)
                {
                    if (e.KeyCode == Keys.F5)
                    {
                        System.Data.DataRow row = dgSnizenja.GetDataRow(dgSnizenja.FocusedRowHandle);

                        if (row != null)
                        {
                            IDSnizenja = row[1].ToString();
                            ispis(IDSnizenja);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ExcelExport()
        {
            var bindingSource = (BindingSource)this.dgSnizenjaObracun.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();


            //Export DataTable.
            if (this.dgSnizenjaObracun != null)
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


            dgSnizenjaObracun.ExportToExcelOld(@"c:\Podaci\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }
    }
}
