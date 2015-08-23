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
using Microsoft.WindowsAzure.Storage.Table;
using DevExpress.XtraNavBar;
using System.IO;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace PowerBackend
{
    public partial class UcDataProduct : DevExpress.XtraEditors.XtraUserControl
    {
        SortedDictionary<string, string> _CATEGORY;
        SortedDictionary<string, string> _BRAND;
        DataTable _PRODUCT;
        DataTable _PRODUCT_RENDER;
        string _CATEGORY_SELECTED;
        GridView _GRID_VIEW;

        public UcDataProduct()
        {
            InitializeComponent();
        }

        private void UcDataProduct_Load(object sender, EventArgs e)
        {
            navBarControl1.Enabled = false;
            splashScreenManager1.ShowWaitForm();
            bwLoadCategory.RunWorkerAsync();

            _GRID_VIEW = (GridView) gridControl1.MainView;
            _GRID_VIEW.OptionsView.ShowGroupPanel = false;
        }

        private void bwLoadCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            var azureTable = Param.AzureTableClient.GetTableReference("Category");
            TableQuery<DynamicTableEntity> query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "88888888"));
            List<DynamicTableEntity> list = azureTable.ExecuteQuery(query).ToList();

            _CATEGORY = new SortedDictionary<string, string>();
            for (int i = 0; i < list.Count; i++)
            {
                _CATEGORY.Add(list[i].Properties["Name"].StringValue, list[i].RowKey);
            }

            azureTable = Param.AzureTableClient.GetTableReference("Brand");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "88888888"));
            list = azureTable.ExecuteQuery(query).ToList();

            _BRAND = new SortedDictionary<string, string>();
            for (int i = 0; i < list.Count; i++)
            {
                _BRAND.Add(list[i].RowKey, list[i].Properties["Name"].StringValue);
            }
        }

        private void bwLoadCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            navBarProduct.ItemLinks.Clear();
            NavBarItem item;
            SortedDictionary<string, string> category = new SortedDictionary<string, string>(); ;
            foreach (var data in _CATEGORY)
            {
                item = new NavBarItem(data.Key);
                item.SmallImage = global::PowerBackend.Properties.Resources.boproduct_16x16;
                item.LinkClicked += new NavBarLinkEventHandler(navBarCategory_LinkClicked);
                navBarProduct.ItemLinks.Add(item);
                if (navBarProduct.ItemLinks.Count == 1)
                {
                    _CATEGORY_SELECTED = data.Key;
                }
                category.Add(data.Value, data.Key);
            }
            _CATEGORY = category;

            navBarControl1.Enabled = true;
            bwLoadProduct.RunWorkerAsync();
        }

        private void bwLoadProduct_DoWork(object sender, DoWorkEventArgs e)
        {
            var azureTable = Param.AzureTableClient.GetTableReference("Product");
            TableQuery<DynamicTableEntity> query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "88888888"));
            List<DynamicTableEntity> list = azureTable.ExecuteQuery(query).ToList();

            _PRODUCT = new DataTable();
            _PRODUCT.Columns.Add("ID", typeof(string));
            _PRODUCT.Columns.Add("Sku", typeof(string));
            _PRODUCT.Columns.Add("Name", typeof(string));
            _PRODUCT.Columns.Add("Price", typeof(int));
            _PRODUCT.Columns.Add("Price1", typeof(int));
            _PRODUCT.Columns.Add("Price2", typeof(int));
            _PRODUCT.Columns.Add("Price3", typeof(int));
            _PRODUCT.Columns.Add("Price4", typeof(int));
            _PRODUCT.Columns.Add("Price5", typeof(int));
            _PRODUCT.Columns.Add("Cost", typeof(double));
            _PRODUCT.Columns.Add("Stock", typeof(int));
            _PRODUCT.Columns.Add("Active", typeof(bool));
            _PRODUCT.Columns.Add("Visible", typeof(bool));
            _PRODUCT.Columns.Add("Brand", typeof(string));
            _PRODUCT.Columns.Add("Category", typeof(string));
            _PRODUCT.Columns.Add("Warranty", typeof(int));

            for (int i = 0; i < list.Count; i++)
            {
                try {
                    _PRODUCT.Rows.Add(list[i].RowKey,
                        list[i].Properties["SKU"].StringValue,
                        list[i].Properties["Name"].StringValue,
                        list[i].Properties["Price"].DoubleValue,
                        list[i].Properties["Price1"].DoubleValue,
                        list[i].Properties["Price2"].DoubleValue,
                        list[i].Properties["Price3"].DoubleValue,
                        list[i].Properties["Price4"].DoubleValue,
                        list[i].Properties["Price5"].DoubleValue,
                        list[i].Properties["Cost"].DoubleValue,
                        list[i].Properties["Stock"].Int32Value,
                        list[i].Properties["Active"].BooleanValue,
                        list[i].Properties["Visible"].BooleanValue,
                        _BRAND[list[i].Properties["Brand"].StringValue],
                        _CATEGORY[list[i].Properties["Category"].StringValue],
                        list[i].Properties["Warranty"].Int32Value
                    );
                }
                catch(Exception ex)
                {
                    Console.WriteLine("{0} : {1}", list[i].RowKey, ex.Message);
                }
            }
        }

        private void bwLoadProduct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splashScreenManager1.CloseWaitForm();
            navBarProduct.ItemLinks[0].PerformClick();
            navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl;
        }

        private void navBarCategory_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _CATEGORY_SELECTED = e.Link.Caption;
            bwPrepareData.RunWorkerAsync();
        }

        private void bwPrepareData_DoWork(object sender, DoWorkEventArgs e)
        {
            _PRODUCT_RENDER = _PRODUCT.Copy();
            for (int i = 0; i < _PRODUCT_RENDER.Rows.Count; i++)
            {
                if (_PRODUCT_RENDER.Rows[i]["Category"].ToString() != _CATEGORY_SELECTED)
                {
                    _PRODUCT_RENDER.Rows.RemoveAt(i);
                    i--;
                }
                else if (!chkIsNotActive.Checked && !(bool)_PRODUCT_RENDER.Rows[i]["Active"])
                {
                    _PRODUCT_RENDER.Rows.RemoveAt(i);
                    i--;
                }
                else if (!chkIsNotVisible.Checked && !(bool)_PRODUCT_RENDER.Rows[i]["Visible"])
                {
                    _PRODUCT_RENDER.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void bwPrepareData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridControl1.DataSource = _PRODUCT_RENDER;
        }

        private void chkIsNotActive_CheckedChanged(object sender, EventArgs e)
        {
            bwPrepareData.RunWorkerAsync();
        }

        private void bandedGridView1_RowClick(object sender, RowClickEventArgs e)
        {
            int[] rows = _GRID_VIEW.GetSelectedRows();
            Console.WriteLine(rows[0]);
        }
    }
}
