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
using SmartXLS;

namespace blokerX
{
    public partial class frmPregledNarudzbiPoKomercijalistu : Form
    {
        Upiti veza = new Upiti();

        public frmPregledNarudzbiPoKomercijalistu()
        {
            InitializeComponent();
        }

        //upit
        /*
             select robnagrupa.RG_SIFRA, robnagrupa.RG_NAZIV, artikl.AR_SIFRA, artikl.AR_NAZIV,sum(narudzbastavka.nas_kolicina) as 'Naručena',sum( narudzbastavka.nas_odobrenakolicina) as 'Odobrena',sum( narudzbastavka.nas_isporucenakolicina) as 'Isporučena', count(artikl.AR_SIFRA) as 'Broj narudžbi', 
             SUM(IF((narudzbastavka.nas_isporucenakolicina or narudzbastavka.nas_kolicina >0) and  narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  = 0, 1, 0)) as 'neizmjenjene' , 
             SUM(IF( narudzbastavka.nas_isporucenakolicina  = 0, 1, 0)) as 'neisporučene', 
             SUM(IF( narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  < 0 and narudzbastavka.nas_isporucenakolicina<> 0, 1, 0)) as 'manje',
             SUM(IF( narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  > 0, 1, 0)) as 'više'
             from  narudzbastavka
             left outer join narudzba on narudzbastavka.narudzba_na_ID = narudzba.na_ID
             left outer join artikl on narudzbastavka.artikl_ar_ID = artikl.ar_ID
             left outer join robnagrupa on artikl.robnaGrupa_rg_ID = robnagrupa.rg_ID

             where narudzbastavka.narudzba_na_ID in (select  narudzba.na_ID  from narudzba where narudzba.operater_op_IDK =1503 and  narudzba.na_vrsta = 1 and na_potvrdjeno = 1 and na_ponistena = 0 and narudzba.na_vrijemepotrvde between '2013-09-02 00:00:00' and '2013-09-02 23:59:59'  )
             and narudzba.na_vrsta = 1 group by artikl.AR_SIFRA order by robnagrupa.rg_sifra, artikl.ar_naziv 
            
         */



        private void frmPregledNarudzbiPoKomercijalistu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'komercijalist.operater' table. You can move, or remove it, as needed.
            this.operaterTableAdapter.Fill(this.komercijalist.operater);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (glDobavljac.Text != "")
                {
                    DataTable podaci = new DataTable();
                    int komerID = Convert.ToInt32(glDobavljac.EditValue);
                    string datOD = Convert.ToDateTime(dtpOd.Text).ToString("yyyy-MM-dd 00:00:00");
                    string datDO = Convert.ToDateTime(dtpDO.Text).ToString("yyyy-MM-dd 23:59:59");

                    //DateTime datumOD = Convert.ToDateTime(datOD);
                    //DateTime datumDO = Convert.ToDateTime(datDO).AddHours(23).AddMinutes(59).AddSeconds(59);


                    //veza.ExecuteQuery("select robnagrupa.RG_SIFRA, robnagrupa.RG_NAZIV, artikl.AR_SIFRA, artikl.AR_NAZIV, sum(narudzbastavka.nas_kolicina),sum( narudzbastavka.nas_odobrenakolicina),sum( narudzbastavka.nas_isporucenakolicina), count(artikl.AR_SIFRA), "
                    //                 + " SUM(IF((narudzbastavka.nas_isporucenakolicina or narudzbastavka.nas_kolicina >0) and  narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  = 0, 1, 0)) , "
                    //                 + " SUM(IF( narudzbastavka.nas_isporucenakolicina  = 0, 1, 0)), "
                    //                 + " SUM(IF( narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  < 0 and narudzbastavka.nas_isporucenakolicina<> 0, 1, 0)), "
                    //                 + " SUM(IF( narudzbastavka.nas_isporucenakolicina - narudzbastavka.nas_kolicina  > 0, 1, 0)) "
                    //                 + " from  narudzbastavka "
                    //                 + " left outer join narudzba on narudzbastavka.narudzba_na_ID = narudzba.na_ID "
                    //                 + " left outer join artikl on narudzbastavka.artikl_ar_ID = artikl.ar_ID "
                    //                 + " left outer join robnagrupa on artikl.robnaGrupa_rg_ID = robnagrupa.rg_ID "

                    //                 + " where narudzbastavka.narudzba_na_ID in (select  narudzba.na_ID  from narudzba where narudzba.operater_op_IDK =" + komerID + " and  narudzba.na_vrsta = 1 and na_potvrdjeno = 1 and na_ponistena = 0 and narudzba.na_vrijemepotrvde between '"+datOD+"' and '"+datDO+"' ) "
                    //                 + " and narudzba.na_vrsta = 1 group by artikl.AR_SIFRA order by robnagrupa.rg_sifra, artikl.ar_naziv ", ref podaci);



                    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["blokerX.Properties.Settings.boso2011ConnectionString"].ConnectionString);
                    MySqlCommand comm = new MySqlCommand("pregledNarudzbiPoKomercijalisti", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    //string ID = glDobavljac.EditValue.ToString();

                    MySqlParameter prm = new MySqlParameter("@IDkomercijaliste", MySqlDbType.Int16);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = komerID;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("@dat", MySqlDbType.DateTime);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = datOD;
                    comm.Parameters.Add(prm);

                    prm = new MySqlParameter("@dat2", MySqlDbType.DateTime);
                    prm.Direction = ParameterDirection.Input;
                    prm.Value = datDO;
                    comm.Parameters.Add(prm);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

                    if (dgNarudzbeZag.RowCount > 0)
                    {
                        narudzbe_po_komercijalisti.Tables["Table"].Clear();
                        dgNarudzbe.DataSource = narudzbe_po_komercijalisti.Tables["Table"];
                    }

                    adapter.Fill(narudzbe_po_komercijalisti, "Table");
                    dgNarudzbe.DataSource = narudzbe_po_komercijalisti.Tables["Table"];
                    pregledNarudzbiPoKomercijalistiBindingSource = new BindingSource(narudzbe_po_komercijalisti, "Table");
                    dgNarudzbe.DataSource = pregledNarudzbiPoKomercijalistiBindingSource;
                    //dgNarudzbeZag.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgNarudzbe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;

                result = MessageBox.Show("Želite prijenos u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    ExcelExportgridView();
                }
            }
        }

        private void ExcelExportgridView()
        {
            var bindingSource = (BindingSource)this.dgNarudzbeZag.DataSource;

            var dataTable = ((DataView)bindingSource.List).Table;

            WorkBook m_book = new WorkBook();

            //Export DataTable.
            if (this.dgNarudzbeZag != null)
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

            //dgAkcija.ExportToXls("c:\\Podaci\\Podaci.xls");
            dgNarudzbeZag.ExportToExcelOld("c:\\Podaci\\Podaci.xls");
            //dgAkcija..ExportToXlsx("c:\\Podaci\\Podaci.xls");

            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
            }
        }

        private void frmPregledNarudzbiPoKomercijalistu_KeyDown(object sender, KeyEventArgs e)
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
    }
}
