using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace PowerBackend
{
    public partial class FmStockShippingType : DevExpress.XtraEditors.XtraForm
    {
        string _TABLE_NAME = "shippingType";
        const string OrderFieldName = "Name";

        public FmStockShippingType()
        {
            InitializeComponent();
        }

        private void FmStockShippingType_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Param.DataSet.Tables["Data-" + _TABLE_NAME];
        }

        private void UpdateData(string value)
        {
            dynamic json = JsonConvert.DeserializeObject(Util.ApiProcess("/properties/update",
                string.Format("shop={0}&type=common&key={1}&value={2}", Param.ShopId, _TABLE_NAME, value)
            ));
            if (!json.success.Value)
            {
                MessageBox.Show(json.errorMessage.Value, json.error.Value, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim() != "")
            {
                try
                {
                    Param.DataSet.Tables["Data-" + _TABLE_NAME].PrimaryKey = new DataColumn[] { Param.DataSet.Tables["Data-" + _TABLE_NAME].Columns["Name"] };
                    Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows.Add(txtData.Text.Trim());
                    UpdateData(Util.DataTableToString(Param.DataSet.Tables["Data-" + _TABLE_NAME], "Name"));
                }
                catch { }
                txtData.Text = "";
            }
            else
            {
                for(int i=0; i<Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows.Count; i++)
                {
                    Console.WriteLine(Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows[i]["Name"]);
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = (GridView)sender;
            int[] row = view.GetSelectedRows();
            if (e.KeyData == Keys.Delete && row.Length > 0)
            {
                DataRow dr = view.GetFocusedDataRow();
                XtraMessageBox.AllowCustomLookAndFeel = true;
                DialogResult dialogResult = XtraMessageBox.Show("คุณต้องการลบข้อมูลนี้ออกจากระบบใช่หรือไม่ ?", "ยืนยันการทำงาน", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Util.DataTableDeleteRow(Param.DataSet.Tables["Data-" + _TABLE_NAME], "Name", dr["Name"].ToString());
                    UpdateData(Util.DataTableToString(Param.DataSet.Tables["Data-" + _TABLE_NAME], "Name"));
                }
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return) || e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            GridView view = gridView1;
            view.GridControl.Focus();
            int index = view.FocusedRowHandle;
            if (index <= 0)
                return;

            Param.DataSet.Tables["Data-" + _TABLE_NAME].PrimaryKey = null;
            DataRow row1 = view.GetDataRow(index);
            DataRow row2 = view.GetDataRow(index - 1);
            object val1 = row1[OrderFieldName];
            object val2 = row2[OrderFieldName];
            row1[OrderFieldName] = val2;
            row2[OrderFieldName] = val1;

            view.FocusedRowHandle = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            GridView view = gridView1;
            view.GridControl.Focus();
            int index = view.FocusedRowHandle;
            if (index >= view.DataRowCount - 1)
                return;

            Param.DataSet.Tables["Data-" + _TABLE_NAME].PrimaryKey = null;
            DataRow row1 = view.GetDataRow(index);
            DataRow row2 = view.GetDataRow(index + 1);
            object val1 = row1[OrderFieldName];
            object val2 = row2[OrderFieldName];
            row1[OrderFieldName] = val2;
            row2[OrderFieldName] = val1;

            view.FocusedRowHandle = index + 1;
        }
    }
}