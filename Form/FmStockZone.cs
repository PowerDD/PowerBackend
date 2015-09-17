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
    public partial class FmStockCategory : DevExpress.XtraEditors.XtraForm
    {
        string _TABLE_NAME = "zone";

        public FmStockCategory()
        {
            InitializeComponent();
        }

        private void FmStockCategory_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Param.DataSet.Tables["Data-" + _TABLE_NAME];
        }

        private async void UpdateData(string name)
        {
            dynamic json = JsonConvert.DeserializeObject(await Util.ApiProcessAsync("/warehouse-queue/properties/update",
                string.Format("shop={0}&type={1}&name={2}&priority=0", Param.ShopId, _TABLE_NAME, name)
            ));
            if (!json.success.Value)
            {
                Console.WriteLine("Update Error : shop={0}&type={1}&name={2}&priority=0 : {4}", Param.ShopId, _TABLE_NAME, name, json.error.Value);
                //MessageBox.Show(json.errorMessage.Value, json.error.Value, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void DeleteData(string name)
        {
            dynamic json = JsonConvert.DeserializeObject(await Util.ApiProcessAsync("/warehouse-queue/properties/delete",
                string.Format("shop={0}&type={1}&name={2}", Param.ShopId, _TABLE_NAME, name)
            ));
            if (!json.success.Value)
            {
                Console.WriteLine("Delete Error : shop={0}&type={1}&name={2} : {3}", Param.ShopId, _TABLE_NAME, name, json.error.Value);
                //MessageBox.Show(json.errorMessage.Value, json.error.Value, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim() != "")
            {
                try
                {
                    Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows.Add(txtData.Text.Trim());
                    UpdateData(txtData.Text.Trim());
                }
                catch { }
                txtData.Text = "";
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = gridView1;
            view.GridControl.Focus();
            int index = view.FocusedRowHandle;
            XtraMessageBox.AllowCustomLookAndFeel = true;
            DialogResult dialogResult = XtraMessageBox.Show("คุณต้องการลบข้อมูลนี้ออกจากระบบใช่หรือไม่ ?", "ยืนยันการทำงาน", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                var name = Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows[index]["Name"].ToString();
                DeleteData(name);
                Util.DataTableDeleteRow(Param.DataSet.Tables["Data-" + _TABLE_NAME], "Name", name);
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