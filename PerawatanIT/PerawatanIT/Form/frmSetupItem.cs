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
    public partial class frmSetupItem : Form
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

        private items i = new items();
        private list l = new list();
        private object _pk = null;

        #endregion

        public frmSetupItem(object pk = null)
        {
            InitializeComponent();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboKategori.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(txtNama.Text))
                {
                    if (_pk != null)
                    {
                        i.u(_pk, cboKategori.SelectedValue, txtNama.Text.Trim(), chkAvailable.Checked);
                    }
                    else
                    {
                        i.i(txtID.Text.Trim(), cboKategori.SelectedValue, txtNama.Text.Trim(), chkAvailable.Checked);
                    }

                    this.Close();
                }
                else
                {
                    Program.MsgError("Tolong isi namanya");
                }
            }
            else
            {
                Program.MsgError("Tolong dipilih kategorinya.");
            }
        }

        private void frmSetupItem_Load(object sender, EventArgs e)
        {
//            Program.ClearText(this);
            l.ListCategory(cboKategori);

            if (_pk != null)
            {
                txtID.Text = _pk.ToString();
                i.v(_pk, cboKategori, txtNama, chkAvailable);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKategori.SelectedIndex != 0)
                txtID.Text = (_pk != null) ? _pk.ToString() : i.a(cboKategori.SelectedValue);
            else
                txtID.Text = null;
        }

    }
}
