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
    public partial class frmMain : Form
    {

        #region Function

        private void ShowMdiChild(Form x)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            if (this.MdiChildren.Length < 1)
            {
                x.WindowState = FormWindowState.Maximized;
                x.MinimizeBox = false;
                x.MaximizeBox = false;
                x.ControlBox = false;
                x.MdiParent = this;
                x.Show();
            }
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterData md = new frmMasterData(FormMenu.KategoriItem);
            ShowMdiChild(md);
            
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterData md = new frmMasterData(FormMenu.Items);
            ShowMdiChild(md);
        }

        private void permasalahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterData md = new frmMasterData(FormMenu.KategoriPermasalahan);
            ShowMdiChild(md);
        }

        private void computersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterData md = new frmMasterData(FormMenu.Komputer);
            ShowMdiChild(md);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterData md = new frmMasterData(FormMenu.Users);
            ShowMdiChild(md);
        }

        private void instalasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterInstall fmi = new frmMasterInstall(FormMenu.Instalasi);
//            frmMasterData md = new frmMasterData(FormMenu.Instalasi);
            ShowMdiChild(fmi);
        }

        private void jadwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasterInstall md = new frmMasterInstall(FormMenu.Perawatan);
            ShowMdiChild(md);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Program.MyVersion;
        }

        private void permasalahanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMasterInstall md = new frmMasterInstall(FormMenu.Permasalahan);
            ShowMdiChild(md);
        }

    }
}
