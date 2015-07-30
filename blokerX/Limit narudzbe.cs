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
    public partial class frmLimitNarudzbe : Form
    {
        Upiti veza = new Upiti();

        public frmLimitNarudzbe()
        {
            InitializeComponent();
        }

        private void frmLimitNarudzbe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partner.partner' table. You can move, or remove it, as needed.
            this.partnerTableAdapter.Fill(this.partner.partner);
        }

        private void frmLimitNarudzbe_KeyDown(object sender, KeyEventArgs e)
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
      
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (glDobavljac.Text != "")
            {
                int paID = Convert.ToInt32(glDobavljac.EditValue);

                this.limitTableAdapter.Fill(this.limitTrgovinaZaPartnera.limit, paID);
            }
        }

        private void dgStavkeNarudzbe_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                System.Data.DataRow row = dgLimitTrgovine.GetDataRow(dgLimitTrgovine.FocusedRowHandle);
                if (row != null)
                {
                    int ID = Convert.ToInt32(row["dop_ID"].ToString());
                    int opID = Convert.ToInt32(Global.KorisnikID);

                    decimal limit = 0;

                    if (row["dop_limit"] != DBNull.Value)
                    {
                        limit = Convert.ToDecimal(row["dop_limit"]);
                    }


                    if (ID != 0)
                    {
                        this.limitTableAdapter.update(this.limitTrgovinaZaPartnera.limit,limit, opID, ID);

                        int paID = Convert.ToInt32(glDobavljac.EditValue);

                        this.limitTableAdapter.Fill(this.limitTrgovinaZaPartnera.limit, paID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgLimitTrgovine_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    dgLimitTrgovine.FocusedColumn = dgLimitTrgovine.VisibleColumns[2];

                    dgLimitTrgovine.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgLimitTrgovine.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgLimitTrgovine.FocusedColumn = dgLimitTrgovine.VisibleColumns[2];

                    dgLimitTrgovine.ShowEditor();

                    DevExpress.XtraEditors.TextEdit edit = dgLimitTrgovine.ActiveEditor as DevExpress.XtraEditors.TextEdit;

                    if (edit != null)
                        edit.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgLimitTrgovine_Click(object sender, EventArgs e)
        {
            dgLimitTrgovine.FocusedColumn = dgLimitTrgovine.VisibleColumns[2];

            dgLimitTrgovine.ShowEditor();

            DevExpress.XtraEditors.TextEdit edit = dgLimitTrgovine.ActiveEditor as DevExpress.XtraEditors.TextEdit;

            if (edit != null)
                edit.SelectAll();
        }

        private void dgLimitTrgovine_MouseWheel(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DevExpress.XtraEditors.TextEdit edit = dgLimitTrgovine.ActiveEditor as DevExpress.XtraEditors.TextEdit;


            //view.CloseEditor();
            if (e.Delta < 0)
            {
                view.MoveNext();
                dgLimitTrgovine.FocusedColumn = dgLimitTrgovine.VisibleColumns[2];

                dgLimitTrgovine.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }
            else if (e.Delta > 0)
            {
                view.MovePrev();
                dgLimitTrgovine.FocusedColumn = dgLimitTrgovine.VisibleColumns[2];

                dgLimitTrgovine.ShowEditor();
                if (edit != null)
                    edit.SelectAll();
            }

            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }

        private void glDobavljac_EditValueChanged(object sender, EventArgs e)
        {
            this.limitTrgovinaZaPartnera.Clear();
        }
    }
}
