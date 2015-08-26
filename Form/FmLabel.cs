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
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.WindowsAzure.Storage.Table;

namespace PowerBackend
{
    public partial class FmLabel : DevExpress.XtraEditors.XtraForm
    {
        string _TABLE_NAME = "Label";
        public FmLabel()
        {
            InitializeComponent();
        }

        private void FmLabel_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Param.DataSet.Tables["Data-" + _TABLE_NAME];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
                TableBatchOperation batchOperation = new TableBatchOperation();
                DynamicTableEntity data = new DynamicTableEntity(Param.ShopId + "-" + _TABLE_NAME, txtData.Text.Trim());
                batchOperation.InsertOrMerge(data);
                azureTable.ExecuteBatch(batchOperation);
                Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows.Add(txtData.Text.Trim());
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
                    var azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
                    TableBatchOperation batchOperation = new TableBatchOperation();
                    DynamicTableEntity data = new DynamicTableEntity(Param.ShopId + "-" + _TABLE_NAME, dr["Name"].ToString());
                    data.ETag = "*";
                    batchOperation.Delete(data);
                    azureTable.ExecuteBatch(batchOperation);

                    view.DeleteRow(row[0]);
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