using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Newtonsoft.Json;

namespace PowerBackend
{
    public partial class UcStockMonitor : DevExpress.XtraEditors.XtraUserControl
    {
        public UcStockMonitor()
        {
            InitializeComponent();
        }

        private void UcStockMonitor_Load(object sender, EventArgs e)
        {
            initialData();
        }

        private async void initialData()
        {
            Param.DataSet = new DataSet();
            DataTable data = new DataTable();

            dynamic json = JsonConvert.DeserializeObject(await Util.ApiProcessAsync("/warehouse-queue/properties/info", "shop=" + Param.ShopId));

            // Shipping Type //
            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Priority", typeof(int));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-shippingType";
            var count = json.shippingType.Count;
            for (int i = 0; i < count; i++)
            {
                data.Rows.Add(json.shippingType[i].name, json.shippingType[i].priority);
            }
            Param.DataSet.Tables.Add(data);

            // Priority //
            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Priority", typeof(int));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-priority";
            for (int i = 0; i < json.priority.Count; i++)
            {
                data.Rows.Add(json.priority[i].name, json.priority[i].priority);
            }
            Param.DataSet.Tables.Add(data);

            // Category //
            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Priority", typeof(int));
            data.Columns.Add("Description", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-category";
            for (int i = 0; i < json.category.Count; i++)
            {
                data.Rows.Add(json.category[i].name, json.category[i].priority, json.category[i].description);
            }
            Param.DataSet.Tables.Add(data);

            // User //
            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-user";
            for (int i = 0; i < json.user.Count; i++)
            {
                data.Rows.Add(json.user[i].name);
            }
            Param.DataSet.Tables.Add(data);
        }

        private void navCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FmStockCategory fm = new FmStockCategory();
            fm.ShowDialog(this);
            //Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
        }

        private void navUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FmStockUser fm = new FmStockUser();
            fm.ShowDialog(this);
            //Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
        }

        private void navShippingType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FmStockShippingType fm = new FmStockShippingType();
            fm.ShowDialog(this);
            //Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
        }

        private void navPriority_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FmStockPriority fm = new FmStockPriority();
            fm.ShowDialog(this);
            //Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
        }
        
    }
}
