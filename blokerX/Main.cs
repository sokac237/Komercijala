using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using blokerX;

namespace blokirajx
{
    public partial class frmMain : Form
    {
        Upiti veza = new Upiti();

        int operater_nivo_dozvoljava;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string datum = DateTime.Today.Day.ToString() + "." +
                          DateTime.Today.Month.ToString() + "." +
                          DateTime.Today.Year.ToString();
            ssDatum.Text = "Datum: " + datum;
            ssKorisnik.Text = "Korisnik: " + Global.Korisnik;
            ssFirma.Text = "Copyright © Informatika FORTUNO d.o.o. Vukovar";

            PravaOperatera();
        }

        private void robneGrupePoKategorijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRobneGrupePoKategoriji _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmRobneGrupePoKategoriji))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmRobneGrupePoKategoriji();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void sviArtikliDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmArtikliPoDobavljacu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmArtikliPoDobavljacu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmArtikliPoDobavljacu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void artikliPoRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikliPoRG _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmArtikliPoRG))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmArtikliPoRG();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void artikliPoBarkoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikliDobavljacaPoBarkodu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmArtikliDobavljacaPoBarkodu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmArtikliDobavljacaPoBarkodu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void poDobavljačuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStalniCjenikPoDobavljacu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStalniCjenikPoDobavljacu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmStalniCjenikPoDobavljacu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void poRobnimGrupamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStalniCjenikPoRG _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStalniCjenikPoRG))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmStalniCjenikPoRG();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void akcijeKomercijaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAkcijskiCjenikProdaja _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmAkcijskiCjenikProdaja))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmAkcijskiCjenikProdaja();
            _frm.MdiParent = this;
            _frm.KojiNivo = "2";
            _frm.Show();
        }

        private void akcijeMarketinganivo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAkcijskiCjenikProdaja _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmAkcijskiCjenikProdaja))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmAkcijskiCjenikProdaja();
            _frm.MdiParent = this;
            _frm.KojiNivo = "3";
            _frm.Show();
        }

        private void stalniNabavniCjenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStalniNabavniCjenik _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStalniNabavniCjenik))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmStalniNabavniCjenik();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void akcijskiNabavniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAkcijskiNabavniCjenik _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmAkcijskiNabavniCjenik))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmAkcijskiNabavniCjenik();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void dodatnePozicijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodatnePozicije _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmDodatnePozicije))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmDodatnePozicije();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledPoslovnicaPoKategorijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPoslovnicaPoKategoriji _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledPoslovnicaPoKategoriji))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledPoslovnicaPoKategoriji();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledAkcijskihNabavnihCijenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledAkcijskihNabavnihCijena _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledAkcijskihNabavnihCijena))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledAkcijskihNabavnihCijena();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledAkcijskihCijenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledProdajnihAkcijskihCijena _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledProdajnihAkcijskihCijena))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledProdajnihAkcijskihCijena();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledProdajnihCijenaZaArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledProdajnihCijenaZaArtikl _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledProdajnihCijenaZaArtikl))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledProdajnihCijenaZaArtikl();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void trgovineUKojeIdeDobavljačToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoslovniceUKojeIdeDobavljac _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPoslovniceUKojeIdeDobavljac))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPoslovniceUKojeIdeDobavljac();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledDobavljačaZaTrgovinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledDobavljacaPoTrgovinama _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledDobavljacaPoTrgovinama))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledDobavljacaPoTrgovinama();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void oslobodiCijenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPregledArtikalaNivelacija _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(FrmPregledArtikalaNivelacija))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new FrmPregledArtikalaNivelacija();
            _frm.MdiParent = this;
            _frm.Show();

        }

        private void cSVCijeneOdDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (operater_nivo_dozvoljava == 1)
            {
                frmPrijenosIzCSVDatoteke _frm;
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmPrijenosIzCSVDatoteke))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmPrijenosIzCSVDatoteke();
                _frm.MdiParent = this;
                _frm.Show();
            }          
        }

        public void PravaOperatera()
        {
            try
            {
                DataTable operater = new DataTable();
                string id = Global.KorisnikID;
                veza.ExecuteQuery("select op_sifra from operater where op_ID = '" + id + "'", ref operater);
                string sifra = operater.Rows[0][0].ToString();
                //int nivo = Convert.ToInt16(operater.Rows[0][0]);

                if (sifra == "SM" || sifra == "SANJA" || sifra == "MARIOP")
                {
                    operater_nivo_dozvoljava = 1;
                }
                else if (sifra == "LE" || sifra == "MARIOL" || sifra == "MARIOP")
                {
                    operater_nivo_dozvoljava = 2;
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cSVPodaciOArtiklimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (operater_nivo_dozvoljava == 1)
            {
                frmPrijenosCSV _frm;
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmPrijenosCSV))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmPrijenosCSV();
                _frm.MdiParent = this;
                _frm.Show();
            }  
        }

        private void potvrdiNapravljeneNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPotvrdiNarudzbu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPotvrdiNarudzbu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPotvrdiNarudzbu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void potvrđeneNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStareNarudzbe _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStareNarudzbe))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmStareNarudzbe();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledNarudžbiSaSkladištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNarudzbiSaSkladista _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledNarudzbiSaSkladista))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledNarudzbiSaSkladista();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledPozicijaZaTrgovinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPozicijaZaTrgovinu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledPozicijaZaTrgovinu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledPozicijaZaTrgovinu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void dobavljačiTrgovineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDobavljacTrgovina _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmDobavljacTrgovina))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmDobavljacTrgovina();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void odrediLimitNarudžbePoslovnicePremaDobavljačuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLimitNarudzbe _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmLimitNarudzbe))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmLimitNarudzbe();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void kategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijeAkcija _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmKategorijeAkcija))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmKategorijeAkcija();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledAkcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPregledAkcija _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledAkcija))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledAkcija();
            _frm.MdiParent = this;
            _frm.Show();

        }

        private void odabirAkcijaZaTrgovinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable operaterModul = new DataTable();

            veza.ExecuteQuery("select op_ID from operaterovlast where op_ID = " + Global.KorisnikID + " and opov_modul = 'AKCIJETRGOVINA' ", ref operaterModul);

            if (operaterModul.Rows.Count > 0)
            {
                frmAkcijeZaTrgovinu _frm;
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmAkcijeZaTrgovinu))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmAkcijeZaTrgovinu();
                _frm.MdiParent = this;
                _frm.Show();
            }
        }

        private void pripremaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPripremaCijena _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPripremaCijena))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPripremaCijena();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void šifreArtikalaKodDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSifreArtikalaKodDobavljaca  _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSifreArtikalaKodDobavljaca))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmSifreArtikalaKodDobavljaca();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void stanjeArtikalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledStanjaArtikalauXGrupiZaTrgovinu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledStanjaArtikalauXGrupiZaTrgovinu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledStanjaArtikalauXGrupiZaTrgovinu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unosGratisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosGratisa _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmUnosGratisa))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmUnosGratisa();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledGratisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledGratisa _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledGratisa))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledGratisa();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void sniženjaOdDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSnizenjaOdDobavljaca _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSnizenjaOdDobavljaca))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmSnizenjaOdDobavljaca();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void minimumMaksimumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMinMax _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmMinMax))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmMinMax();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledPoKomercijalistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNarudzbiPoKomercijalistu _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledNarudzbiPoKomercijalistu))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledNarudzbiPoKomercijalistu();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledAkcijskihCijenaNivo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledAkcijskihCijenaNivo3 _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmPregledAkcijskihCijenaNivo3))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmPregledAkcijskihCijenaNivo3();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void sniženjaObračunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSnizenjaObracun _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSnizenjaObracun))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmSnizenjaObracun();
            _frm.MdiParent = this;
            _frm.Show();
        }
    }
}
