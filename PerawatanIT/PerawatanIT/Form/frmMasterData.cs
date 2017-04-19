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
    public partial class frmMasterData : Form
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
        private category MyCat = new category();
        private trouble MyT = new trouble();
//        private computers MyC = new computers();
        private items MyI = new items();

        #endregion

        #region Function

        private void LoadData()
        {
            DataSet ds = new DataSet();

            switch (_menu)
            {
                case FormMenu.Items:
                    lblHeader.Text = "DATA ITEMS";
                    MyI.DAShow().Fill(ds, "DATA");
                    goto default;
                case FormMenu.KategoriItem:
                    lblHeader.Text = "DATA KATEGORI ITEM";
                    MyCat.DAShow().Fill(ds, "DATA");
                    goto default;
                case FormMenu.KategoriPermasalahan:
                    lblHeader.Text = " DATA KATEGORI PERMASALAHAN";
                    MyT.DAShow().Fill(ds, "DATA");
                    goto default;
                case FormMenu.Users:
                    lblHeader.Text = "DATA USER";
                    goto default;
                default:
                    this.Text = lblHeader.Text;
                    dgvData.DataSource = ds.Tables["DATA"];
                    if (dgvData.RowCount >= 1)
                    {
//                        dgvData.Columns[0].Visible = false;
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
            LoadData();
        }

        #endregion

        public frmMasterData(FormMenu curMenu)
        {
            InitializeComponent();

            _menu = curMenu;

        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_menu)
            {
                case FormMenu.Items:
                    frmSetupItem si = new frmSetupItem();
                    si.MyData += MyData;
                    Program.ShowBox(si);
                    break;
                case FormMenu.KategoriItem:
                    frmSetupCatI sci = new frmSetupCatI();
                    sci.MyData += MyData;
                    Program.ShowBox(sci);
                    break;
                case FormMenu.KategoriPermasalahan:
                    frmSetupCatP scp = new frmSetupCatP();
                    scp.MyData += MyData;
                    Program.ShowBox(scp);
                    break;
/*                case FormMenu.Komputer:
                    frmConfigComputer cc = new frmConfigComputer();
                    cc.MyData += MyData;
                    Program.ShowBox(cc);
                    break;
                case FormMenu.Perawatan:
                    frmMaintenance fm = new frmMaintenance();
                    fm.MyData += MyData;
                    Program.ShowBox(fm);
                    break;
                case FormMenu.Permasalahan:
                    frmTrouble ft = new frmTrouble();
                    ft.MyData += MyData;
                    Program.ShowBox(ft);
                    break;*/
                case FormMenu.Users:
                    lblHeader.Text = "DATA USER";
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string r = Program.MsgYesNo("Yakin ?").ToString();
            object[] pk = new object[] { dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value };

            //            Program.MsgInfo(pk);

            if (r == "Yes")
            {
                switch (_menu)
                {
                    case FormMenu.Items:
                        MyI.d(pk[0]);
                        goto default;
                    case FormMenu.KategoriItem:
                        MyCat.d(pk[0]);
                        goto default;
                    case FormMenu.KategoriPermasalahan:
                        MyT.d(pk[0]);
                        goto default;
                    case FormMenu.Users:
                        lblHeader.Text = "DATA USER";
                        goto default;
                    default:
                        LoadData();
                        break;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            object pk = null;

            switch (_menu)
            {
                case FormMenu.Instalasi:
                    lblHeader.Text = "DATA INSTALASI";
                    break;
                case FormMenu.Items:
                    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                    frmSetupItem si = new frmSetupItem(pk);
                    si.MyData += MyData;
                    Program.ShowBox(si);
                    break;
                case FormMenu.KategoriItem:
                    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[1].Value;
                    frmSetupCatI sci = new frmSetupCatI(pk);
                    sci.MyData += MyData;
                    Program.ShowBox(sci);
                    break;
                case FormMenu.KategoriPermasalahan:
                    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                    frmSetupCatP scp = new frmSetupCatP(pk);
                    scp.MyData += MyData;
                    Program.ShowBox(scp);
                    break;
                //case FormMenu.Komputer:
                //    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                //    frmConfigComputer cc = new frmConfigComputer(pk);
                //    cc.MyData += MyData;
                //    Program.ShowBox(cc);                    
                //    break;
                //case FormMenu.Perawatan:
                //    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                //    frmMaintenance fm = new frmMaintenance(pk);
                //    fm.MyData += MyData;
                //    Program.ShowBox(fm);                    
                //    break;
                //case FormMenu.Permasalahan:
                //    pk = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                //    frmTrouble ft = new frmTrouble(pk);
                //    ft.MyData += MyData;
                //    Program.ShowBox(ft);
                //    break;
                case FormMenu.Users:
                    lblHeader.Text = "DATA USER";
                    break;
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

    }
}
