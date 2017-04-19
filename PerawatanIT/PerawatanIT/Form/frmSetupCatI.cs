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
    public partial class frmSetupCatI : Form
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

        private category c = new category();
        private object _pk = null;

        #endregion

        public frmSetupCatI(object pk = null)
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.FormClosing += myForm_Closing;
            this.KeyDown += myFOrm_KeyDown;

            _pk = pk;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTipe.SelectedIndex != 0)
            {
                if (_pk != null)
                {
                    c.u(cboTipe.Text, txtKategori.Text.Trim(), chkStatus.Checked);
                }
                else
                {
                    c.i(cboTipe.Text, txtKategori.Text.Trim(), chkStatus.Checked);
                }

                this.Close();
            }
            else
            {
                Program.MsgError("Tolong pilih tipe.");
            }
        }

        private void frmSetupCatI_Load(object sender, EventArgs e)
        {
            cboTipe.SelectedIndex = 0;
            if(_pk != null)
            {
                c.v(_pk, cboTipe, chkStatus);
                txtKategori.Text = _pk.ToString();
                txtKategori.Enabled = false;
            }
        }
    }
}
