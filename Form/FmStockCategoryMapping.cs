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
using DevExpress.XtraEditors.Repository;
using Newtonsoft.Json;

namespace PowerBackend
{
    public partial class FmStockCategoryMapping : DevExpress.XtraEditors.XtraForm
    {
        string _TABLE_NAME = "category";

        public FmStockCategoryMapping()
        {
            InitializeComponent();
        }

        private void FmStockCategoryMapping_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Param.DataSet.Tables["Data-" + _TABLE_NAME];
            repositoryItemLookUpEdit1.DataSource = Param.DataSet.Tables["Data-zone"];
            repositoryItemLookUpEdit1.ValueMember = "Name";
            repositoryItemLookUpEdit1.DisplayMember = "Name";
            repositoryItemLookUpEdit1.PopulateColumns();
        }

        private async void UpdateData(string name, string zone)
        {
            dynamic json = JsonConvert.DeserializeObject(await Util.ApiProcessAsync("/warehouse-queue/properties/update",
                string.Format("shop={0}&type={1}&name={2}&priority={3}", Param.ShopId, _TABLE_NAME, name, zone)
            ));
            if (!json.success.Value)
            {
                Console.WriteLine("Update Error : shop={0}&type={1}&name={2}&priority={3} : {4}", Param.ShopId, _TABLE_NAME, name, zone, json.error.Value);
                //MessageBox.Show(json.errorMessage.Value, json.error.Value, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int index = e.RowHandle;
            Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows[index]["Name"].ToString();
            UpdateData(Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows[index]["Name"].ToString(), Param.DataSet.Tables["Data-" + _TABLE_NAME].Rows[index]["Zone"].ToString());
        }
    }
}