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
    public partial class frmInstallation : Form
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

        private list l = new list();
        private installation ins = new installation();
        private object _pk = null;
        private object _computerid = null;
        private object tglUninstall = null;

        #endregion

        public frmInstallation(object computerid, object pk = null)
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.FormClosing += myForm_Closing;
            this.KeyDown += myFOrm_KeyDown;

            _pk = pk;
            _computerid = computerid;
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
            tglUninstall = (!dtUninstall.Checked) ? null : dtUninstall.Value.ToString();

            if (_pk != null)
            {
                ins.u(_pk, txtSerialNo.Text, dtInstall.Value, tglUninstall);
            }
            else
            {

                ins.i(txtID.Text, cboItems.SelectedValue, txtSerialNo.Text, dtInstall.Value, tglUninstall);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInstallation_Load(object sender, EventArgs e)
        {
            l.ListCategory(cboKategori);
            l.ListItem(cboItems, cboKategori.SelectedValue);
            txtID.Text = _computerid.ToString();
            if(_pk !=null)
            {
                ins.v(_pk, cboKategori, cboItems, txtSerialNo, dtInstall, dtUninstall);
            }
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            l.ListItem(cboItems, cboKategori.SelectedValue);
        }

        private void dtUninstall_ValueChanged(object sender, EventArgs e)
        {
            dtUninstall.CustomFormat = "dd - MMM - yyyy";
        }

    }
}
