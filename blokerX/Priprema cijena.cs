using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace blokerX
{
    public partial class frmPripremaCijena : Form
    {
        Upiti veza = new Upiti();
        DataTable stavke = new DataTable();
        DataTable zaglavlje = new DataTable();
        string datum;

        string datumOD;
        string datumDO;
        string aktivna;
        string opis;

        public frmPripremaCijena()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPripremi_Click(object sender, EventArgs e)
        {
            try
            {
                btnPripremi.Enabled = false;
                datum = DateTime.Now.Date.ToString("yyyy-MM-dd");
                lblStatus.Text = "Prebacujem zaglavlje....";
                lblStatus.Refresh();
                PrebaciZaglavlje();
                lblStatus.Text = "Završeno prebacivanje zaglavlja!";
                lblStatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                lblStatus.Text = "Prebacujem stavke cjenikaA....";
                lblStatus.Refresh();
                PrebaciStavkeA();
                lblStatus.Text = "Završeno prebacivanje stavki cjenikaA!";
                lblStatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                lblStatus.Text = "Prebacujem stavke cjenikaB....";
                lblStatus.Refresh();
                PrebaciStavkeB();
                lblStatus.Text = "Završeno prebacivanje stavki cjenikaB!";
                lblStatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                lblStatus.Text = "Prebacujem stavke cjenikaC....";
                lblStatus.Refresh();
                PrebaciStavkeC();
                lblStatus.Text = "Završeno prebacivanje stavki cjenikaC!";
                lblStatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                lblStatus.Text = "Prebacujem stavke cjenikaD....";                
                PrebaciStavkeD();
                lblStatus.Refresh();
                lblStatus.Text = "Završeno prebacivanje stavki cjenikaD!";
                lblStatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                lblStatus.Text = "Prebacujem stavke cjenikaX....";
                lblStatus.Refresh();
                PrebaciStavkeX();
                lblStatus.Text = "Završeno prebacivanje cjenika!";
                lblStatus.Refresh();
                prekopirajPripremljeneCjenike();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prekopirajPripremljeneCjenike()
        {
            try
            {
                string fileName = "";
                string sourcePath = @"T:\kartice\tmpcjenici";
                string targetPath = @"T:\kartice";

                // Use Path class to manipulate file and directory paths. 
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                // To copy a folder's contents to a new location: 
                // Create a new target folder, if necessary. 
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist. 
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }

                MessageBox.Show("Priprema cjenika uspješno završena!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrebaciZaglavlje()
        {
            //pokupi stalni cjenik
            veza.ExecuteQuery("select prodajnicjenik.prc_ID, prc_vaziod, prc_vazido, prc_opis, prc_nivo, prc_aktivan from prodajnicjenik where prc_nivo =1", ref zaglavlje);
            //veza.ExecuteQuery("select prodajnicjenik.prc_ID, prc_vaziod, prc_vazido, prc_opis, prc_nivo, prc_aktivan from prodajnicjenik where prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY)", ref zaglavlje);

            pbar.Maximum = zaglavlje.Rows.Count;
            timer1.Interval = zaglavlje.Rows.Count;

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJEZAG.txt");
            int rowcount = zaglavlje.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {

                fn_prbar_("Z");

                if (zaglavlje.Rows[i][3].ToString() != "")
                {
                    opis = Convert.ToString(zaglavlje.Rows[i][3]);
                }
                else
                {
                    opis = "";
                }

                //if (zaglavlje.Rows[i][1].ToString() != "" || zaglavlje.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(zaglavlje.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(zaglavlje.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                datumOD = ".  .";

                //if (zaglavlje.Rows[i][2].ToString() != "" || zaglavlje.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(zaglavlje.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}
                datumDO = ".  .";

                if (zaglavlje.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(zaglavlje.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + "0" + ";" + "" + opis + "" + ";" + zaglavlje.Rows[i][4].ToString() + ";" + aktivna + ";" + "0" + ";" + "0");
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)


            veza.ExecuteQuery("select prodajnicjenik.prc_ID, prc_vaziod, prc_vazido, prc_opis, prc_nivo, prc_aktivan from prodajnicjenik where prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY)", ref zaglavlje);

            pbar.Maximum = zaglavlje.Rows.Count;
            timer1.Interval = zaglavlje.Rows.Count;

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJEZAG.txt");
            rowcount = zaglavlje.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {

                fn_prbar_("Z");

                if (zaglavlje.Rows[i][3].ToString() != "")
                {
                    opis = Convert.ToString(zaglavlje.Rows[i][3]);
                }
                else
                {
                    opis = "";
                }

                if (zaglavlje.Rows[i][1].ToString() != "" || zaglavlje.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(zaglavlje.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(zaglavlje.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }
                

                if (zaglavlje.Rows[i][2].ToString() != "" || zaglavlje.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(zaglavlje.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }


                if (zaglavlje.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(zaglavlje.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + "0" + ";" + "" + opis + "" + ";" + zaglavlje.Rows[i][4].ToString() + ";" + aktivna + ";" + "0" + ";" + "0");
            }
            sw.Close();  
        }
       

        private void PrebaciStavkeA()
        {
            pbar.Value = 0;
            DataTable stavke = new DataTable();
            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipa, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = 1 and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipa > 0", ref stavke);
            //veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipa, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('"+datum+"', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJENIKA.txt");

            int rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("A");

                //if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                datumOD = ".  .";

                //if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}

                datumDO = ".  .";

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)          


            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipa, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipa > 0", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJENIKA.txt");

            rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("A");

                if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }

                if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            sw.Close();     //Don't Forget Close the TextWriter Object(sw)          
        }

        private void PrebaciStavkeB()
        {
            pbar.Value = 0;
            DataTable stavke = new DataTable();

            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipb, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = 1 and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipb > 0", ref stavke);
            //veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipb, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA  from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('"+datum+"', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJENIKB.txt");

            int rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("B");

                //if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                datumOD = ".  .";


                //if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}

                datumDO = ".  .";

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)


            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipb, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA  from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipb > 0", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJENIKB.txt");

            rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("B");

                if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }

                if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            sw.Close();
        }

        private void PrebaciStavkeC()
        {
            pbar.Value = 0;
            DataTable stavke = new DataTable();

            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipc, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = 1 and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipc > 0", ref stavke);
            //veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipc, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('"+datum+"', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJENIKC.txt");

            int rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("C");

                //if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                datumOD = ".  .";

                //if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}

                datumDO = ".  .";

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)

            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipc, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipc > 0", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJENIKC.txt");

            rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("C");

                if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }

                if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            sw.Close();  
        }

        private void PrebaciStavkeD()
        {
            pbar.Value = 0;
            DataTable stavke = new DataTable();


            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipd, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = 1 and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipd > 0", ref stavke);
            //veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipd, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('"+datum+"', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJENIKD.txt");

            int rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("D");

                //if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                datumOD = ".  .";

                //if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}

                datumDO = ".  .";

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)

            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipd, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipd > 0", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJENIKD.txt");

            rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("D");

                if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }

                if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            sw.Close(); 
        }

        private void PrebaciStavkeX()
        {
            pbar.Value = 0;
            DataTable stavke = new DataTable();


            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipx, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_nivo = 1 and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipx > 0", ref stavke);
            //veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipx, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            TextWriter sw = new StreamWriter(@"T:\kartice\tmpcjenici\CJENIKX.txt");

            int rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("X");

                //if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                //{
                //    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumOD = ".  .";
                //}

                //if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                //{
                //    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                //}
                //else
                //{
                //    datumDO = ".  .";
                //}

                datumOD = ".  .";


                datumDO = ".  .";

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            //sw.Close();     //Don't Forget Close the TextWriter Object(sw)

            veza.ExecuteQuery("select prodajnistavka.prodajnicjenik_prc_ID, prodajnicjenik.prc_vaziod, prodajnicjenik.prc_vazido, prodajnistavka.artikl_ar_ID, prodajnistavka.prc_tipx, prodajnistavka.prc_aktivna, prodajnicjenik.prc_nivo, artikl.AR_SIFRA from artikl, prodajnicjenik, prodajnistavka where prodajnicjenik.prc_ID = prodajnistavka.prodajnicjenik_prc_ID and  prodajnicjenik.prc_vazido >= DATE_SUB('" + datum + "', INTERVAL 10 DAY) and artikl.ar_ID = prodajnistavka.artikl_ar_ID and prodajnistavka.prc_tipx > 0", ref stavke);
            if (stavke.Rows.Count > 0)
            {
                pbar.Maximum = stavke.Rows.Count;
                timer1.Interval = stavke.Rows.Count;
            }

            //TextWriter sw = new StreamWriter(@"R:\bajica\CJENIKX.txt");

            rowcount = stavke.Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                fn_prbar_("X");

                if (stavke.Rows[i][1].ToString() != "" || stavke.Rows[i][1].ToString() != "null")
                {
                    datumOD = Convert.ToDateTime(stavke.Rows[i][1].ToString()).ToString("yyyy.MM.dd");
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumOD = ".  .";
                }

                if (stavke.Rows[i][2].ToString() != "" || stavke.Rows[i][2].ToString() != "null")
                {
                    datumDO = Convert.ToDateTime(stavke.Rows[i][2].ToString()).ToString("yyyy.MM.dd");
                }
                else
                {
                    datumDO = ".  .";
                }

                if (stavke.Rows[i][5].ToString() == "True")
                {
                    aktivna = "1";
                }
                else
                {
                    aktivna = "0";
                }
                sw.WriteLine(stavke.Rows[i][0].ToString() + ";" + datumOD + ";" + datumDO + ";" + stavke.Rows[i][7].ToString() + ";" + stavke.Rows[i][4].ToString().Replace(',', '.') + ";" + "0.00" + ";" + aktivna + ";" + stavke.Rows[i][6].ToString());
            }
            sw.Close();     //Don't Forget 
        }



        public void fn_prbar_(string a)
        {            
            pbar.Increment(1);
            lblStatus.Text = "" + pbar.Value.ToString() + "%";
            if (pbar.Value == pbar.Maximum)
            {
                if (a == "Z")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje zaglavlja!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
                else if (a == "A")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje stavkiA!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
                else if (a == "B")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje stavki B!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
                else if (a == "C")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje stavki C!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
                else if (a == "D")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje stavki D!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
                else if (a == "X")
                {
                    timer1.Stop();
                    lblStatus.Text = "Završeno prebacivanje stavki X!";
                    lblStatus.Refresh();
                    timer1.Stop();
                }
            }
        }
    }
}
