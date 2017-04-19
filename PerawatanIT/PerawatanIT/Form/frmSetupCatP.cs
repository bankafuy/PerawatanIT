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
    public partial class frmSetupCatP : Form
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

        private trouble t = new trouble();
        private object _pk = null;

        #endregion

        public frmSetupCatP(object pk = null)
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

        private void frmSetupCatP_Load(object sender, EventArgs e)
        {
            if (_pk != null)
            {
                t.v(_pk, txtKategori);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_pk != null)
            {
                t.u(_pk, txtKategori.Text.Trim());
            }
            else
            {
                t.i(txtKategori.Text.Trim());
            }

            this.Close();
        }
    }
}
