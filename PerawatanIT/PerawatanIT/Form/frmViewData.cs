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
    public partial class frmViewData : Form
    {

        private computers C = new computers();
        private FormMenu _formMenu;

        internal object MySelected;

        public frmViewData(FormMenu FormMenu)
        {
            InitializeComponent();
            this._formMenu = FormMenu;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            switch (_formMenu)
            {
                case FormMenu.Komputer:
                    MySelected = dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value;
                    break;
            }

            this.Close();
        }

        private void frmViewData_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            switch(_formMenu)
            {
                case FormMenu.Komputer:
                    C.DAShow().Fill(ds, "DATA");
                    dgvData.DataSource = ds.Tables["DATA"];
                    break;
            }
        }
    }
}
