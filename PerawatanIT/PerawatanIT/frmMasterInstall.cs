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
    public partial class frmMasterInstall : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CustomParam = base.CreateParams;
                CustomParam.ExStyle |= 0x02000000;
                return CustomParam;
            }
        }

        #region Declare

        private FormMenu _menu;
        private computers C = new computers();
        private installation I = new installation();
        private maintenance M = new maintenance();
        private troubles T = new troubles();

        #endregion

        #region Function

        private void LoadHeader()
        {
            DataSet ds = new DataSet();
            C.DAShow().Fill(ds, "HEADER");
            dgvMaster.DataSource = ds.Tables["HEADER"];
            if (dgvMaster.RowCount >= 1)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }

            LoadDetail();
        }

        private void LoadDetail()
        {
            DataSet ds = new DataSet();
            object pk = Convert.ToString(dgvMaster.Rows[dgvMaster.SelectedCells[0].RowIndex].Cells[0].Value);

            switch (_menu)
            {
                case FormMenu.Instalasi:
                    lblHeader.Text = "DATA INSTALASI";
                    I.DAShow(pk).Fill(ds, "DATA");
                    goto default;
                case FormMenu.Perawatan:
                    lblHeader.Text = "DATA PERAWATAN";
                    M.DAShow(pk).Fill(ds, "DATA");
                    goto default;
                case FormMenu.Permasalahan:
                    lblHeader.Text = "DATA PERMASALAHAN";
                    T.DAShow(pk).Fill(ds, "DATA");
                    goto default;
                default:
                    this.Text = lblHeader.Text;
                    dgvDetail.DataSource = ds.Tables["DATA"];
                    if (dgvDetail.RowCount >= 1)
                    {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    break;
            }
        }

        private void MyData(object sender, EventArgs e)
        {
            LoadHeader();
        }

        #endregion

        public frmMasterInstall(FormMenu curMenu)
        {
            InitializeComponent();
            
            _menu = curMenu;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            frmConfigComputer cc = new frmConfigComputer();
            cc.MyData += MyData;
            Program.ShowBox(cc);
        }

        private void btnEditMaster_Click(object sender, EventArgs e)
        {
            object pk = dgvMaster.Rows[dgvMaster.SelectedCells[0].RowIndex].Cells[0].Value;
            frmConfigComputer cc = new frmConfigComputer(pk);
            cc.MyData += MyData;
            Program.ShowBox(cc);                    

        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            string r = Program.MsgYesNo("Yakin ?").ToString();
            object pk = dgvMaster.Rows[dgvMaster.SelectedCells[0].RowIndex].Cells[0].Value;

            if (r == "Yes")
            {
                C.d(pk);
                LoadHeader();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmMasterInstall_Load(object sender, EventArgs e)
        {
            LoadHeader();
        }

        private void dgvMaster_SelectionChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }

    }
}
