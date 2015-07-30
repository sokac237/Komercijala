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
    public partial class frmAkcijskiNabavniCjenik : Form
    {
        int obrisan = 0;
        int topRowIndex;
        int focus;

        string flag; //0 - insert novi , ako je 1 - onda update

        //gridView1 = dgAkcijskiNabavniStavke
        //gridView2 = dgAkcijskiNabavniCjenici
        Upiti veza = new Upiti();

        string IDcjenika;

        string oznaka;

        public static Button azurirajcjenik = new Button();

        public static Button azurirajStavke = new Button();

        string partnerID;
        string IDZaglavljeProdajniAkcijskiCjenik;
        public frmAkcijskiNabavniCjenik()
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

        private void frmAkcijskiNabavniCjenik_Load(object sender, EventArgs e)
        {
            try
            {
                azurirajcjenik = btnAzurirajCjenike;
                azurirajStavke = btnAzurirajStavke;
                // TODO: This line of code loads data into the 'akcijskiNabavniCjenik.nabavnicjenik' table. You can move, or remove it, as needed.
                DateTime prvi = Convert.ToDateTime("1999-01-01");
                DateTime drugi = Convert.ToDateTime("2050-12-31");               
                this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
                Godina.Value = DateTime.Now.Year;
            }
            catch
            { 
            }
        }            

        private void ckbFiltriraj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiltriraj.Checked)
            {
                try
                {
                    string god = Godina.Value.ToString();

                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime(String.Format("{0}-12-31", god));
                    this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DateTime prvi = Convert.ToDateTime("1999-01-01");
                DateTime drugi = Convert.ToDateTime("2050-12-31");
                this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
            }
        }

        private void Godina_ValueChanged(object sender, EventArgs e)
        {
            if (ckbFiltriraj.Checked)
            {
                try
                {
                    string god = Godina.Value.ToString();

                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime("" + god + "-12-31");
                    this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DateTime prvi = Convert.ToDateTime("1999-01-01");
                DateTime drugi = Convert.ToDateTime("2050-12-31");
                this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
            }
        }

        private void dgAkcijskiNabavniCjenici_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                topRowIndex = gridView2.TopRowIndex;
                focus = gridView2.FocusedRowHandle;

                if (e.KeyCode == Keys.F4)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {
                            IDcjenika = row[0].ToString();

                            //frmAzurirajAkcijskiNabavniCjenik _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajAkcijskiNabavniCjenik))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajAkcijskiNabavniCjenik();
                            //_frm.IDCjenika = IDcjenika;
                            //_frm.ShowDialog();

                            frmAzurirajAkcijskiNabavniCjenik UForm = null;
                            if ((UForm = (frmAzurirajAkcijskiNabavniCjenik)IsFormAlreadyOpen(typeof(frmAzurirajAkcijskiNabavniCjenik))) == null)
                            {
                                frmAzurirajAkcijskiNabavniCjenik _frm = new frmAzurirajAkcijskiNabavniCjenik();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.IDCjenika = IDcjenika;
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
                        MessageBox.Show("Nemate niti jedan cjenik koji biste ažurirali!");
                    }
                }
                else if (e.KeyCode == Keys.F7)
                {
                    IDcjenika = "0";
                    flag = "0"; 

                    //frmAzurirajAkcijskiNabavniCjenik _frm;
                    //foreach (Form childForm in this.MdiChildren)
                    //{
                    //    if (childForm.GetType() == typeof(frmAzurirajAkcijskiNabavniCjenik))
                    //    {
                    //        childForm.Focus();
                    //        return;
                    //    }
                    //}
                    //_frm = new frmAzurirajAkcijskiNabavniCjenik();
                    //_frm.IDCjenika = IDcjenika;
                    //_frm.ShowDialog();

                    frmAzurirajAkcijskiNabavniCjenik UForm = null;
                    if ((UForm = (frmAzurirajAkcijskiNabavniCjenik)IsFormAlreadyOpen(typeof(frmAzurirajAkcijskiNabavniCjenik))) == null)
                    {
                        frmAzurirajAkcijskiNabavniCjenik _frm = new frmAzurirajAkcijskiNabavniCjenik();
                        _frm.MdiParent = frmMain.ActiveForm;
                        _frm.IDCjenika = IDcjenika;
                        _frm.Show();
                    }
                    else
                    {
                        UForm.Focus();
                        return;
                    }
                }
                else if (e.KeyCode == Keys.F3)
                {
                    try
                    {
                        if (gridView2.SelectedRowsCount > 0)
                        {
                            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                            if (row != null)
                            {
                                string IDcjenik = row[0].ToString();
                                int cjenikID = Convert.ToInt16(IDcjenik);

                                this.nabavnistavkaTableAdapter.Fill(this.akcijskiNabavniStavke.nabavnistavka, cjenikID);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.F8)
                {
                    if (gridView2.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if (row != null)
                        {

                            IDcjenika = row[0].ToString();
                            partnerID = row[6].ToString();

                            frmCSVnabavniakcija UForm = null;
                            if ((UForm = (frmCSVnabavniakcija)IsFormAlreadyOpen(typeof(frmCSVnabavniakcija))) == null)
                            {
                                frmCSVnabavniakcija _frm = new frmCSVnabavniakcija();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.IDcjenika = IDcjenika;
                                _frm.IDpartnera = partnerID;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dgAkcijskiNabavniCjenici_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                akcijskiNabavniStavke.Clear();
            }
        }

        private void nabavnicjenikBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                akcijskiNabavniStavke.Clear();
            }
        }

        private void btnAzurirajCjenike_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckbFiltriraj.Checked)
                {
                    string god = Godina.Value.ToString();
                    DateTime prvi = Convert.ToDateTime("" + god + "-01-01");
                    DateTime drugi = Convert.ToDateTime("" + god + "-12-31");
                    this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);

                }
                else
                {
                    DateTime prvi = Convert.ToDateTime("1999-01-01");
                    DateTime drugi = Convert.ToDateTime("2050-12-31");
                    this.nabavnicjenikTableAdapter.Fill(this.akcijskiNabavniCjenik.nabavnicjenik, prvi, drugi);
                }

                if (flag == "0")
                {
                    gridView2.MoveFirst();
                }
                else
                {
                    gridView2.TopRowIndex = topRowIndex;
                    gridView2.SelectRow(focus);
                }
                flag = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void dgAkcijskiNabavniStavke_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                topRowIndex = gridView1.TopRowIndex;
                focus = gridView1.FocusedRowHandle;

                if (e.KeyCode == Keys.F4)
                {
                    if (gridView1.RowCount > 0)
                    {
                        System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);//stavke
                        System.Data.DataRow row2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);//cjenici

                        if (row != null || row2 != null)
                        {
                            string artiklID = row[2].ToString();

                            string partnerID = row2[6].ToString();

                            IDcjenika = row2[0].ToString();

                            string IDstavkeCjenika = row[0].ToString();

                            //frmAzurirajAkcijskiNabavniStavke _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajAkcijskiNabavniStavke))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajAkcijskiNabavniStavke();
                            //_frm.cjenikID = IDcjenika;
                            //_frm.artiklID = artiklID;
                            //_frm.partnerID = partnerID;
                            //_frm.stavkaID = IDstavkeCjenika;
                            //_frm.ShowDialog();

                            frmAzurirajAkcijskiNabavniStavke UForm = null;
                            if ((UForm = (frmAzurirajAkcijskiNabavniStavke)IsFormAlreadyOpen(typeof(frmAzurirajAkcijskiNabavniStavke))) == null)
                            {
                                frmAzurirajAkcijskiNabavniStavke _frm = new frmAzurirajAkcijskiNabavniStavke();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.cjenikID = IDcjenika;
                                _frm.artiklID = artiklID;
                                _frm.partnerID = partnerID;
                                _frm.stavkaID = IDstavkeCjenika;
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
                else if (e.KeyCode == Keys.F7)
                {
                    if (gridView2.RowCount > 0)
                    {
                        oznaka = "0";

                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);//stavke
                        System.Data.DataRow row2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);//cjenici

                        if (row != null || row2 != null)
                        {
                            IDcjenika = row[0].ToString();

                            string partnerID = row2[6].ToString();

                            //frmAzurirajAkcijskiNabavniStavke _frm;
                            //foreach (Form childForm in this.MdiChildren)
                            //{
                            //    if (childForm.GetType() == typeof(frmAzurirajAkcijskiNabavniStavke))
                            //    {
                            //        childForm.Focus();
                            //        return;
                            //    }
                            //}
                            //_frm = new frmAzurirajAkcijskiNabavniStavke();
                            //_frm.cjenikID = IDcjenika;
                            //_frm.oznaka = oznaka;
                            //_frm.partnerID = partnerID;
                            //_frm.ShowDialog();

                            frmAzurirajAkcijskiNabavniStavke UForm = null;
                            if ((UForm = (frmAzurirajAkcijskiNabavniStavke)IsFormAlreadyOpen(typeof(frmAzurirajAkcijskiNabavniStavke))) == null)
                            {
                                frmAzurirajAkcijskiNabavniStavke _frm = new frmAzurirajAkcijskiNabavniStavke();
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.cjenikID = IDcjenika;
                                _frm.oznaka = oznaka;
                                _frm.partnerID = partnerID;
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
                else if (e.KeyCode == Keys.F3)
                {
                    try
                    {
                        if (gridView1.RowCount > 0)
                        {
                            System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                            System.Data.DataRow row1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                            if (row != null || row1 != null)
                            {
                                string partner = row[6].ToString();
                                int partnerID = Convert.ToInt16(partner);


                                string artikl = row1[2].ToString();
                                int artiklID = Convert.ToInt32(artikl);

                                this.nabavnistavkaTableAdapter1.Fill(this.nabavneCijenePoCjenicima.nabavnistavka, partnerID, artiklID);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    DialogResult result;
                    try
                    {
                        if (gridView1.RowCount > 0)
                        {
                            result = MessageBox.Show("Želite obrisati odabranu stavku?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            if (result == DialogResult.Yes)
                            {
                                System.Data.DataRow row1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                                if (row1 != null)
                                {
                                    string IDcjeni = row1[0].ToString();
                                    veza.ExecuteQuery("delete from nabavnistavka where nas_ID = " + IDcjeni + "");

                                    if (gridView2.SelectedRowsCount > 0)
                                    {
                                        System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                                        if (row != null)
                                        {
                                            string IDcjenik = row[0].ToString();
                                            int cjenikID = Convert.ToInt16(IDcjenik);

                                            this.nabavnistavkaTableAdapter.Fill(this.akcijskiNabavniStavke.nabavnistavka, cjenikID);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.KeyCode == Keys.F5)
                {
                    //kreiranje prodajnog cjenika na osnovu nabavnog , prebacivanje zaglavlja i stavki                     
                    //pokupi podatke zaglavlja i spremi u prodajni akcijski cjenik
                    if (gridView1.RowCount > 0)
                    {
                        System.Data.DataRow row1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                        if (row1 != null)
                        {
                            IDcjenika = row1[1].ToString();
                        }


                        DialogResult result;

                        result = MessageBox.Show("Sigurno želite napraviti akcijski prodajni cjenik na osnovu odabranog nabavnog cjenika??", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            DataTable zaglavlja = new DataTable();

                            veza.ExecuteQuery("select nac_opis, nac_vaziod, nac_vazido,partneri_pa_ID from nabavnicjenik where nac_ID =" + IDcjenika + "", ref zaglavlja);

                            if (zaglavlja.Rows.Count > 0)
                            {
                                if (zaglavlja.Rows[0][3].ToString() != "")
                                {
                                    partnerID = zaglavlja.Rows[0][3].ToString();
                                }
                                else
                                {
                                    partnerID = "default";
                                }

                                //MessageBox.Show("insert into prodajnicjenik (prc_vaziod, prc_vazido, partner_pa_ID, prc_opis, prc_nivo, operater_op_ID) values (" + Convert.ToDateTime(zaglavlja.Rows[0][1]).ToString("yyyy-MM-dd") + ", " + Convert.ToDateTime(zaglavlja.Rows[0][2]).ToString("yyyy-MM-dd") + ", " + partnerID + ", " + zaglavlja.Rows[0][0].ToString() + ", 2, " + Global.KorisnikID + " )");
                                veza.ExecuteQuery("insert into prodajnicjenik (prc_vaziod, prc_vazido, partner_pa_ID, prc_opis, prc_nivo, operater_op_ID) values ('" + Convert.ToDateTime(zaglavlja.Rows[0][1]).ToString("yyyy-MM-dd") + "', '" + Convert.ToDateTime(zaglavlja.Rows[0][2]).ToString("yyyy-MM-dd") + "', " + partnerID + ", '" + zaglavlja.Rows[0][0].ToString() + "', 2, " + Global.KorisnikID + " )");

                                DataTable cjenik = new DataTable();
                                veza.ExecuteQuery("select max(prodajnicjenik.prc_ID) from prodajnicjenik", ref cjenik);

                                if (cjenik.Rows.Count > 0)
                                {
                                    IDZaglavljeProdajniAkcijskiCjenik = cjenik.Rows[0][0].ToString();
                                }

                                //pokupi podatke stavki i spremi u stavke prodajnog cjenika 

                                for (int i = 0; i < gridView1.RowCount; i++)
                                {
                                    System.Data.DataRow row = gridView1.GetDataRow(i);

                                    if (row != null)
                                    {
                                        string artiklID = row[2].ToString();

                                        //MessageBox.Show("insert into prodajnistavka (prodajnicjenik_prc_ID, artikl_ar_ID, partner_pa_id) values ( " + IDZaglavljeProdajniAkcijskiCjenik + ", " + artiklID + ", " + partnerID + ")");
                                        veza.ExecuteQuery("insert into prodajnistavka (prodajnicjenik_prc_ID, artikl_ar_ID, partner_pa_id, prc_aktivna) values ( " + IDZaglavljeProdajniAkcijskiCjenik + ", " + artiklID + ", " + partnerID + ", 0)");
                                    }
                                }

                                this.Close();

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
                                _frm.MdiParent = frmMain.ActiveForm;
                                _frm.KojiNivo = "2";
                                _frm.Show();

                            }
                            
                            //otvori akcijski cjenik nivo 2 da može pregledat artikle i prepraviti
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dgAkcijskiNabavniStavke_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            if (gridView3.RowCount > 0)
            {
                nabavneCijenePoCjenicima.Clear();
            }
        }

        private void nabavnistavkaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (gridView3.RowCount > 0)
            {
                nabavneCijenePoCjenicima.Clear();
            }
        }

        private void btnAzurirajStavke_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    System.Data.DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if (row != null)
                    {
                        string IDcjenik = row[0].ToString();
                        int cjenikID = Convert.ToInt16(IDcjenik);

                        this.nabavnistavkaTableAdapter.Fill(this.akcijskiNabavniStavke.nabavnistavka, cjenikID);
                    }

                    if (obrisan == 1)
                    {
                        gridView1.TopRowIndex = topRowIndex;
                    }
                    else
                    {
                        gridView1.TopRowIndex = topRowIndex;
                        gridView1.SelectRow(focus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAkcijskiNabavniCjenik_KeyDown(object sender, KeyEventArgs e)
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
    }
}
