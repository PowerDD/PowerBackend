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

namespace PowerBackend
{
    public partial class FmCapacity : DevExpress.XtraEditors.XtraForm
    {
        string _TABLE_NAME = "capacity";
        public FmCapacity()
        {
            InitializeComponent();
        }

        private void FmCapacity_Load(object sender, EventArgs e)
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
            try
            {
                Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows.Add(txtData.Text.Trim());
                UpdateData(Util.DataTableToString(Param.DataSet.Tables["Data-" + _TABLE_NAME], "Name"));
            }
            catch { }
            txtData.Text = "";
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
    }
}