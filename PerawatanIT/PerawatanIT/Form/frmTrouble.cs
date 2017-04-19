using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerawatanIT
{
    public partial class frmTrouble : Form
    {
        #region EventHandler

        internal event EventHandler MyData;
        protected virtual void SendData(EventArgs e)
        {
            EventHandler MyHandler = MyData;
            if (MyHandler != null)
                MyHandler(this, e);
        }

        #endregion

        #region Declare

        private troubles T = new troubles();
        private list L = new list();
        private object _pk = null;
        private object tglFinish = null;

        #endregion

        public frmTrouble(object PK = null)
        {
            InitializeComponent();
            this.FormClosing += myForm_Closing;
            this.KeyDown += myFOrm_KeyDown;

            _pk = PK;
        }

        void myFOrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        void myForm_Closing(object sender, FormClosingEventArgs e)
        {
            SendData(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tglFinish = (!dtFinish.Checked) ? null : Convert.ToDateTime(dtFinish.Value).ToString("yyyy-MM-dd");

            if (cboKategori.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(txtKompName.Text))
                {
                    if (_pk != null)
                    {
                        T.u(_pk, txtKompName.Text, cboKategori.SelectedValue, txtPelapor.Text, dtLapor.Value, tglFinish, txtTroubles.Text, txtSolusi.Text, "Admin");
                    }
                    else
                    {
                        T.i(txtKompName.Text, cboKategori.SelectedValue, txtPelapor.Text, dtLapor.Value, tglFinish, txtTroubles.Text, txtSolusi.Text, "Admin");
                    }

                    this.Close();
                }
                else
                {
                    Program.MsgError("Tolong pilih komputer");
                }
            }
            else
            {
                Program.MsgError("Tolong dipilih kategorinya.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrouble_Load(object sender, EventArgs e)
        {
            //            Program.ClearText(this);
            L.ListTrouble(cboKategori);

            if (_pk != null)
            {
                T.v(_pk, cboKategori, txtPelapor, txtKompName, dtLapor, dtFinish, txtTroubles, txtSolusi);
            }
        }

        private void btnSelectKomp_Click(object sender, EventArgs e)
        {
            frmViewData fvd = new frmViewData(FormMenu.Komputer) { MySelected = txtKompName.Text };
            Program.ShowBox(fvd);
            txtKompName.Text = Convert.ToString(fvd.MySelected);
        }
    }
}
