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
    public partial class frmConfigComputer : Form
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

        private computers c = new computers();
        private object _pk = null;

        #endregion

        public frmConfigComputer(object pk = null)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.FormClosing += myForm_Closing;
            this.KeyDown += myFOrm_KeyDown;

            _pk = pk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfigComputer_Load(object sender, EventArgs e)
        {
            txtNamaKomputer.Text = Convert.ToString(_pk);

            if (_pk != null)
            {
                c.v(_pk, cboLocation, txtUser, chkStatus);
            }
            else
            {
                cboLocation.SelectedIndex = 0;
            }
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
            if (cboLocation.SelectedIndex != 0)
            {
                if (_pk != null)
                {
                    c.u(txtNamaKomputer.Text, cboLocation.GetItemText(cboLocation.SelectedItem), txtUser.Text, chkStatus.Checked);
                }
                else
                {
                    c.i(txtNamaKomputer.Text, cboLocation.GetItemText(cboLocation.SelectedItem), txtUser.Text, chkStatus.Checked);
                }

                this.Close();
            }
            else
            {
                Program.MsgError("Tolong dipilih lokasinya.");
            }
        }


    }
}
