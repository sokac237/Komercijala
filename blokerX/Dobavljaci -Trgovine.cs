using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blokerX
{
    public partial class frmDobavljacTrgovina : Form
    {
        Upiti veza = new Upiti();

        int brojac;

        public frmDobavljacTrgovina()
        {
            InitializeComponent();
        }

        private void Dobavljaci__Trgovine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);

        }

        private void odabraneTrgovine()
        {
            DataTable dat = new DataTable();
            veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman,poslovnica.tipposlovnice_tip_sifra from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

            if (dat.Rows.Count > 0)
            {
                dgOdabraneTrgovine.DataSource = dat;

                string[] kolone = new string[6];
                kolone[0] = "Šifra";
                kolone[1] = "Naziv";
                kolone[2] = "Asortiman";
                kolone[3] = "Tip";

                for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                {
                    dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                }
            }
            else
            {
                DataTable prazno = new DataTable();
                dgOdabraneTrgovine.DataSource = prazno;
            }
        }

        private void nerasporedeneTrgovine()
        {
            DataTable posl = new DataTable();
            //veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman from poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref posl);
            veza.ExecuteQuery("select po_sifra, po_naziv, po_asortiman, poslovnica.tipposlovnice_tip_sifra from poslovnica where po_ID not in (select poslovnica_po_ID from dobavljacposlovnica where partner_pa_ID = '" + glDobavljac.EditValue + "') and  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref posl);

            if (posl.Rows.Count > 0)
            {
                dgNeraspoređeneTrgovine.DataSource = posl;
                string[] kolone = new string[6];
                kolone[0] = "Šifra";
                kolone[1] = "Naziv";
                kolone[2] = "Asortiman";
                kolone[3] = "Tip";

                for (int i = 0; i < dgNeraspoređeneTrgovine.Columns.Count; i++)
                {
                    dgNeraspoređeneTrgovine.Columns[i].HeaderText = kolone[i];
                }
            }
            else 
            {
                DataTable prazno = new DataTable();
                dgNeraspoređeneTrgovine.DataSource = prazno;
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glDobavljac.Text != "")
            {
                odabraneTrgovine();

                nerasporedeneTrgovine();
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (dgNeraspoređeneTrgovine.Rows.Count > 0)
            {
                try
                {
                    DataTable sif = new DataTable();
                    string sifra = dgNeraspoređeneTrgovine.CurrentRow.Cells[0].Value.ToString();

                    veza.ExecuteQuery("select po_ID from poslovnica where po_sifra = '" + sifra + "'", ref sif);
                    string po_ID = sif.Rows[0][0].ToString();

                    sif.Clear();
                    veza.ExecuteQuery("select * from dobavljacposlovnica where poslovnica_po_ID = '" + po_ID + "' and partner_pa_ID = '" + glDobavljac.EditValue + "'", ref sif);

                    if (sif.Rows.Count > 0)
                    {
                        MessageBox.Show("Trgovina je već dodana na popis dobavljača!");
                    }
                    else
                    {
                        veza.ExecuteQuery("insert into dobavljacposlovnica (poslovnica_po_ID, partner_pa_ID) values ('" + po_ID + "', '" + glDobavljac.EditValue + "')");

                        //DataTable dat = new DataTable();
                        //veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

                        //if (dat.Rows.Count > 0)
                        //{
                        //    dgOdabraneTrgovine.DataSource = dat;

                        //    string[] kolone = new string[6];
                        //    kolone[0] = "Šifra";
                        //    kolone[1] = "Naziv";
                        //    kolone[2] = "Asortiman";


                        //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                        //    {
                        //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                        //    }
                        //}
                        //else
                        //{
                        //    DataTable prazno = new DataTable();
                        //    dgOdabraneTrgovine.DataSource = prazno;
                        //}
                        odabraneTrgovine();
                        nerasporedeneTrgovine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (dgOdabraneTrgovine.Rows.Count > 0)
            {
                try
                {
                    DataTable sif = new DataTable();
                    string sifra = dgOdabraneTrgovine.CurrentRow.Cells[0].Value.ToString();

                    veza.ExecuteQuery("select po_ID from poslovnica where po_sifra = '" + sifra + "'", ref sif);
                    string po_ID = sif.Rows[0][0].ToString();

                    veza.ExecuteQuery("delete from dobavljacposlovnica where partner_pa_ID = '" + glDobavljac.EditValue + "' and poslovnica_po_ID = '" + po_ID + "'");

                    //DataTable dat = new DataTable();
                    //veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

                    //if (dat.Rows.Count > 0)
                    //{
                    //    dgOdabraneTrgovine.DataSource = dat;

                    //    string[] kolone = new string[6];
                    //    kolone[0] = "Šifra";
                    //    kolone[1] = "Naziv";
                    //    kolone[2] = "Asortiman";

                    //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                    //    {
                    //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                    //    }
                    //}
                    //else
                    //{
                    //    DataTable prazno = new DataTable();
                    //    dgOdabraneTrgovine.DataSource = prazno;
                    //}

                    odabraneTrgovine();
                    nerasporedeneTrgovine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSveDesno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Odabrati ćete sve poslovnice za dobavljača! Želite nastaviti?",this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                if (dgOdabraneTrgovine.Rows.Count > 0 && dgOdabraneTrgovine.Rows.Count != dgNeraspoređeneTrgovine.Rows.Count)
                {
                    DataTable ostaliID = new DataTable();
                    veza.ExecuteQuery("select poslovnica.po_ID from poslovnica where poslovnica.po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') and poslovnica.po_ID not in (select dobavljacposlovnica.poslovnica_po_ID from dobavljacposlovnica where partner_pa_ID = '" + glDobavljac.EditValue + "' ) ", ref ostaliID);

                    for (brojac = 0; brojac < ostaliID.Rows.Count; brojac++)
                    {
                        string po_ID = ostaliID.Rows[brojac][0].ToString();
                        veza.ExecuteQuery("insert into dobavljacposlovnica (partner_pa_ID, poslovnica_po_ID) values ('" + glDobavljac.EditValue + "', '" + po_ID + "')");
                    }

                    //DataTable dat = new DataTable();
                    //veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

                    //if (dat.Rows.Count > 0)
                    //{
                    //    dgOdabraneTrgovine.DataSource = dat;

                    //    string[] kolone = new string[6];
                    //    kolone[0] = "Šifra";
                    //    kolone[1] = "Naziv";
                    //    kolone[2] = "Asortiman";


                    //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                    //    {
                    //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                    //    }
                    //}
                    //else
                    //{
                    //    DataTable prazno = new DataTable();
                    //    dgOdabraneTrgovine.DataSource = prazno;
                    //}
                    odabraneTrgovine();
                    nerasporedeneTrgovine();
                }
                else
                {
                    DataTable posID = new DataTable();
                    veza.ExecuteQuery("select po_ID from poslovnica where  po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref posID);

                    for (brojac = 0; brojac < posID.Rows.Count; brojac++)
                    {
                        string po_ID = posID.Rows[brojac][0].ToString();

                        veza.ExecuteQuery("insert into dobavljacposlovnica (partner_pa_ID, poslovnica_po_ID) values ('" + glDobavljac.EditValue + "','" + po_ID + "') ");
                    }

                    //DataTable dat = new DataTable();
                    //veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

                    //if (dat.Rows.Count > 0)
                    //{
                    //    dgOdabraneTrgovine.DataSource = dat;

                    //    string[] kolone = new string[6];
                    //    kolone[0] = "Šifra";
                    //    kolone[1] = "Naziv";
                    //    kolone[2] = "Asortiman";


                    //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                    //    {
                    //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                    //    }
                    //}
                    //else
                    //{
                    //    DataTable prazno = new DataTable();
                    //    dgOdabraneTrgovine.DataSource = prazno;
                    //}
                    odabraneTrgovine();
                    nerasporedeneTrgovine();
                }
            }
        }

        private void btnSveLijevo_Click(object sender, EventArgs e)
        {

            if (dgOdabraneTrgovine.Rows.Count > 0)
            {
                veza.ExecuteQuery("delete from dobavljacposlovnica where partner_pa_ID = '" + glDobavljac.EditValue + "'");

                //DataTable dat = new DataTable();
                //veza.ExecuteQuery("select poslovnica.po_sifra, poslovnica.po_naziv, poslovnica.po_asortiman from poslovnica, dobavljacposlovnica, partner where dobavljacposlovnica.poslovnica_po_ID = poslovnica.po_ID and partner.pa_ID = '" + glDobavljac.EditValue + "' and dobavljacposlovnica.partner_pa_ID = partner.pa_ID  and po_datumZatvaranja is null and (vp_sifra = '300' or  vp_sifra ='200') ORDER BY po_naziv", ref dat);

                //if (dat.Rows.Count > 0)
                //{
                //    dgOdabraneTrgovine.DataSource = dat;

                //    string[] kolone = new string[6];
                //    kolone[0] = "Šifra";
                //    kolone[1] = "Naziv";
                //    kolone[2] = "Asortiman";


                //    for (int i = 0; i < dgOdabraneTrgovine.Columns.Count; i++)
                //    {
                //        dgOdabraneTrgovine.Columns[i].HeaderText = kolone[i];
                //    }
                //}
                //else
                //{
                //    DataTable prazno = new DataTable();
                //    dgOdabraneTrgovine.DataSource = prazno;
                //}
                odabraneTrgovine();
                nerasporedeneTrgovine();
            }
        }

        private void Dobavljaci__Trgovine_KeyDown(object sender, KeyEventArgs e)
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
