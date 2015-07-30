using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using blokerX;
using FastReport;

namespace blokirajx
{
    public partial class frmRobneGrupePoKategoriji : Form
    {
        Upiti veza = new Upiti();

        public frmRobneGrupePoKategoriji()
        {
            InitializeComponent();
        }

        private void frmRobneGrupePoKategoriji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kategorija._kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.kategorija._kategorija);
            glKategorija.Focus();
        }


        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glKategorija.Text != "")
            {
                DataTable da = new DataTable();
                string id_kategorije = glKategorija.EditValue.ToString();

                veza.ExecuteQuery("select robnagrupa.rg_sifra, robnagrupa.rg_naziv, CONCAT( operater.op_ime, ' ' , operater.op_prezime) , kategorija.ka_naziv from kategorija, robnagrupa, operater where operater.op_ID = robnagrupa.operater_op_ID and kategorija.ka_ID = robnagrupa.kategorija_ka_ID and robnagrupa.kategorija_ka_ID = '"+id_kategorije+"' ", ref da);

                if (da.Rows.Count > 0)
                {
                    dgRobneGrupe.DataSource = da;

                    string[] kolone = new string[6];
                    kolone[0] = "Šifra robne grupe";
                    kolone[1] = "Naziv robne grupe";
                    kolone[2] = "Operater";
                    kolone[3] = "Naziv kategorije";
                    kolone[4] = "Asortiman";


                    for (int i = 0; i < dgRobneGrupe.Columns.Count; i++)
                    {
                        dgRobneGrupe.Columns[i].HeaderText = kolone[i];
                    }
                }
            }

        }

        private void frmRobneGrupePoKategoriji_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    try
                    {
  
                        DataTable artikli = new DataTable(); 
                        //MessageBox.Show("Select prodajnicjenik.*, partner.pa_naziv, CONCAT( operater.op_ime,' ' ,operater.op_prezime ) , prodajnistavka.*, artikl.AR_SIFRA, artikl.AR_NAZIV from prodajnistavka, artikl,  prodajnicjenik left outer join partner on prodajnicjenik.partner_PA_ID = partner.pa_ID left outer join operater on prodajnicjenik.operater_op_ID = operater.op_ID where  prodajnistavka.prodajnicjenik_prc_ID = prodajnicjenik.prc_ID and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnicjenik.prc_ID = " + cjenikID + " and prodajnicjenik.prc_nivo = " + _nivoCjenika + "");
                        veza.ExecuteQuery("select robnagrupa.rg_sifra, robnagrupa.rg_naziv, CONCAT( operater.op_ime, ' ' , operater.op_prezime) , kategorija.ka_naziv from kategorija, robnagrupa, operater where operater.op_ID = robnagrupa.operater_op_ID and kategorija.ka_ID = robnagrupa.kategorija_ka_ID and robnagrupa.kategorija_ka_ID = '"+glKategorija.EditValue+"'", ref artikli);

                        if (dgRobneGrupe.Rows.Count > 0)
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

                            report.Load(baseDir + "/report/RG_kategorije.frx");

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

                    //string IDkategorije = glKategorija.EditValue.ToString();


                    //System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                    //string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                    //report1.Load(baseDir + "/report/RG_kategorije.frx");

                    //report1.SetParameterValue("katID", IDkategorije);

                    ////report1.Load("C:/Users/IvanS/Documents/Visual Studio 2010/Projects/odobrenja_3.3/Report.frx");
                    //report1.Show();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
