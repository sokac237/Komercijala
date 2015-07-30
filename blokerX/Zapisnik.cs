using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokirajx;

namespace blokerX
{
    public partial class frmZapisnik : Form
    {
        Upiti veza = new Upiti();

        int nivo;
        string _oznaka;
        string _IDgratis;
        string poslovodja;


        string vrijednost;
        string akcBroj;

        string datum;

        string nabavnavrijednost;
        string prodajnavrijednost;
        int zavrsen;    

        public frmZapisnik()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string oznaka
        {
            get { return _oznaka; }
            set { _oznaka = value; }
        }

        public string gratisID
        {
            get { return _IDgratis; }
            set { _IDgratis = value; }
        }

        public void PravaOperatera()
        {
            try
            {
                DataTable operater = new DataTable();

                string id = Global.KorisnikID;

                veza.ExecuteQuery("select op_nivo from operater where op_ID = '" + id + "'", ref operater);

                nivo = Convert.ToInt16(operater.Rows[0][0]);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmZapisnik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poslovnica.poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.FillBy1(this.poslovnica.poslovnica);
            // TODO: This line of code loads data into the 'dobavljac.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.dobavljac.partner);


            if (_oznaka == "F4") //update
            {
                PravaOperatera();

                if (nivo == 9)
                {
                    txtBrojAkcije.Enabled = true;
                }
                else 
                {
                    txtBrojAkcije.Enabled = false;
                }
                
                DataTable gratis = new DataTable(); ;
                veza.ExecuteQuery("select partner.PA_ID, gratis.gr_datum, gratis.gr_zapisnik, gratis.gr_odobrenje, gratis.gr_nabavnavrijednost, gratis.gr_prodajnavrijednost, gratis.gr_napomena, poslovnica.po_ID, gratis.gr_zavrsen, gratis.akc_broj, gratis.gr_vrijednostsnizenja from gratis left join poslovnica on poslovnica.po_id= gratis.poslovnica_PO_ID left  join partner on partner.PA_ID= gratis.partneri_PA_ID  where gratis.gr_id = '"+_IDgratis+"'", ref gratis);
                
                if (gratis.Rows.Count > 0)
                {
                    string partnerID = gratis.Rows[0][0].ToString();
                    string poslovnicaID = gratis.Rows[0][7].ToString();
                    glPoslovnica.EditValue = poslovnicaID;
                    glPartner.EditValue = partnerID;

                    dtpDatum.Text = gratis.Rows[0][1].ToString();
                    txtZapisnik.Text = gratis.Rows[0][2].ToString();
                    TxtOdobrenje.Text = gratis.Rows[0][3].ToString();
                    txtNabavnaVrijednost.Text = gratis.Rows[0][4].ToString();
                    txtProdajnaVrij.Text = gratis.Rows[0][5].ToString();
                    txtNapomena.Text = gratis.Rows[0][6].ToString();


                    if(gratis.Rows[0][8].ToString() == "True")
                    {
                        ckbZakljucen.Checked = true;
                    }
                    else
                    {
                        ckbZakljucen.Checked = false;
                    }


                    txtBrojAkcije.Text = gratis.Rows[0][9].ToString();


                    txtVrijednost.Text = gratis.Rows[0][10].ToString();
                }
            }
            else //insert
            {
                return;
            }
        }

        private void btnZapisi_Click(object sender, EventArgs e)
        {
            try
            {
                pokupiPodatkeZapisnik();
                if (_oznaka == "F4") //update
                {
                    //MessageBox.Show("update gratis set partneri_pa_ID = " + glPartner.EditValue + ", gr_datum ='" + datum + "', gr_zapisnik = '" + txtZapisnik.Text + "', gr_odobrenje = '" + TxtOdobrenje.Text + "', gr_nabavnavrijednost = " + nabavnavrijednost + ", gr_prodajnavrijednost = " + prodajnavrijednost + ", gr_napomena = '" + txtNapomena.Text + "', poslovnica_po_ID = '" + glPoslovnica.EditValue + "', operater_op_ID = '" + poslovodja + "', gr_zavrsen = " + zavrsen + ", operater_op_ID_izmjena = " + Global.KorisnikID + ", akc_broj = " + akcBroj + ", gr_vrijednostsnizenja = " + vrijednost + "   where gr_ID = " + _IDgratis + " ");
                    veza.ExecuteQuery("update gratis set partneri_pa_ID = " + glPartner.EditValue + ", gr_datum ='" + datum + "', gr_zapisnik = '" + txtZapisnik.Text + "', gr_odobrenje = '" + TxtOdobrenje.Text + "', gr_nabavnavrijednost = " + nabavnavrijednost + ", gr_prodajnavrijednost = " + prodajnavrijednost + ", gr_napomena = '" + txtNapomena.Text + "', poslovnica_po_ID = '" + glPoslovnica.EditValue + "', operater_op_ID = '" + poslovodja + "', gr_zavrsen = " + zavrsen + ", operater_op_ID_izmjena = " + Global.KorisnikID + ", akc_broj = "+akcBroj+", gr_vrijednostsnizenja = "+vrijednost+"   where gr_ID = " + _IDgratis + " ");
                }
                else //insert
                {
                    veza.ExecuteQuery(@"insert into gratis (partneri_pa_ID, gr_datum, gr_zapisnik, gr_odobrenje, gr_nabavnavrijednost, gr_prodajnavrijednost, gr_napomena, poslovnica_po_ID,operater_op_ID, gr_zavrsen, gr_vrsta, operater_op_ID_izmjena, akc_broj, gr_vrijednostsnizenja) 
                                        values('" + glPartner.EditValue + "', '" + datum + "' , '" + txtZapisnik.Text + "', '" + TxtOdobrenje.Text + "', " + nabavnavrijednost + ", " + prodajnavrijednost + ", '" + txtNapomena.Text + "','" + glPoslovnica.EditValue + "','" + poslovodja + "', " + zavrsen + ", 'OG' , " + Global.KorisnikID + ", "+akcBroj+", "+vrijednost+")");
                }
                this.Close();
                frmUnosGratisa.osvjezi.PerformClick();
                
                MessageBox.Show("Uspješno ste ažurirali zapisnik!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pokupiPodatkeZapisnik()
        {
            try
            {
                if (glPartner.Text != "" && glPoslovnica.Text != "")
                {
                    DohvatiSifruID dohvati = new DohvatiSifruID();
                    poslovodja = dohvati.DohvatiIDSifra("po_ImePoslovodje","poslovnica","po_ID = "+glPoslovnica.EditValue+"");

                    datum = Convert.ToDateTime(dtpDatum.Text).ToString("yyyy-MM-dd");

                    if (txtNabavnaVrijednost.Text != "")
                    {
                        nabavnavrijednost = Convert.ToString(txtNabavnaVrijednost.Text).Replace(',', '.');
                    }
                    else
                    {
                        nabavnavrijednost = "default";
                    }

                    if (txtProdajnaVrij.Text != "")
                    {
                        prodajnavrijednost = Convert.ToString(txtProdajnaVrij.Text).Replace(',', '.');
                    }
                    else
                    {
                        prodajnavrijednost = "default";
                    }

                    if (ckbZakljucen.Checked)
                    {
                        zavrsen = 1;
                    }
                    else
                    {
                        zavrsen = 0;
                    }


                    if (txtVrijednost.Text != "")
                    {
                        vrijednost = Convert.ToString(txtVrijednost.Text).Replace(',', '.');
                    }
                    else
                    {
                        vrijednost = "0";
                    }


                    if (txtBrojAkcije.Text != "")
                    {
                        akcBroj = Convert.ToString(txtBrojAkcije.Text).Replace(',', '.');
                    }
                    else
                    {
                        akcBroj = "default";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmZapisnik_KeyDown(object sender, KeyEventArgs e)
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

        private void txtZapisnik_Leave(object sender, EventArgs e)
        {
            if (txtZapisnik.Text != "" && _oznaka != "F4")
            {
                DataTable provjera = new DataTable();

                veza.ExecuteQuery("select gr_zapisnik from gratis where gr_zapisnik = '"+txtZapisnik.Text.Trim()+"'", ref provjera);

                if (provjera.Rows.Count > 0)
                {
                    MessageBox.Show("Već postoji taj broj zapisnika dodan u bazu!");
                    txtZapisnik.Text = "";
                    txtZapisnik.Focus();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
