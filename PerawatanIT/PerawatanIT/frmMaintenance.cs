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
    public partial class frmMaintenance : Form
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

        private maintenance M = new maintenance();
        private object _pk = null;
        private object tglUpdate;

        #endregion

        public frmMaintenance(object PK = null)
        {
            InitializeComponent();

            this._pk = PK;
            this.FormClosing += myForm_Closing;
            this.KeyDown += myFOrm_KeyDown;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            tglUpdate = (!dtUpdate.Checked) ? null : Convert.ToDateTime(dtUpdate.Value).ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(txtKompName.Text))
            {
                if (_pk != null)
                {
                    M.u(_pk, txtKompName.Text, dtLapor.Value, chkMB.Checked, chkProces.Checked,
                        chkHarddisk.Checked, chkDVD.Checked, chkVGA.Checked, chkPS.Checked,
                        chkCasing.Checked, chkKeyboard.Checked, chkMouse.Checked, chkNetworkCard.Checked,
                        chkOS.Checked, chkAV.Checked, tglUpdate, txtNotes.Text, "Admin");
                }
                else
                {
                    M.i(txtKompName.Text, dtLapor.Value, chkMB.Checked, chkProces.Checked,
                        chkHarddisk.Checked, chkDVD.Checked, chkVGA.Checked, chkPS.Checked,
                        chkCasing.Checked, chkKeyboard.Checked, chkMouse.Checked, chkNetworkCard.Checked,
                        chkOS.Checked, chkAV.Checked, tglUpdate, txtNotes.Text, "Admin");
                }

                this.Close();
            }
            else
            {
                Program.MsgError("Tolong pilih komputer");
            }
        }

        private void btnSelectKomp_Click(object sender, EventArgs e)
        {
            frmViewData fvd = new frmViewData(FormMenu.Komputer) { MySelected = txtKompName.Text };
            Program.ShowBox(fvd);
            txtKompName.Text = Convert.ToString(fvd.MySelected);
        }

        private void chkAV_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAV.Checked)
                dtUpdate.Checked = false;
            else
                dtUpdate.Checked = true;
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            if (_pk != null)
            {
                M.v(_pk, txtKompName, dtLapor, chkMB, chkProces, 
                    chkHarddisk, chkDVD, chkVGA, chkPS, chkCasing, chkKeyboard, chkMouse,
                    chkNetworkCard, chkOS, chkAV, dtUpdate, txtNotes);
            }
        }
    }
}
