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
using DevExpress.DXCore.Controls.XtraEditors.Repository;
using DevExpress.DXCore.Controls.XtraEditors.Mask;
using System.Globalization;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace PowerBackend
{
    public partial class UcDataProduct : DevExpress.XtraEditors.XtraUserControl
    {
        SortedDictionary<string, string> _CATEGORY;
        SortedDictionary<string, string> _BRAND;

        DataTable _PRODUCT_PROPERTIES;
        DataRow _PRODUCT_ROW_SELECTED;
        string _CATEGORY_SELECTED;
        GridView _GRID_VIEW;

        public UcDataProduct()
        {
            InitializeComponent();
        }

        private void UcDataProduct_Load(object sender, EventArgs e)
        {
            navBarControl1.Enabled = false;
            _GRID_VIEW = (GridView) gridControl1.MainView;
            _GRID_VIEW.Appearance.Row.Font = new Font("Tahoma", 9.5f);
            Param.DataSet = new DataSet();
            Util.SetProductStructure();

            splashScreenManager.ShowWaitForm();
            bwLoadCategory.RunWorkerAsync();
        }

        private void bwLoadCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            var azureTable = Param.AzureTableClient.GetTableReference("Category");
            TableQuery<DynamicTableEntity> query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId));
            List<DynamicTableEntity> list = azureTable.ExecuteQuery(query).ToList();

            //## หมวดหมู่ ##//
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["ID"] };
            data.TableName = "Data-Category";

            _CATEGORY = new SortedDictionary<string, string>();
            for (int i = 0; i < list.Count; i++)
            {
                data.Rows.Add(list[i].RowKey, list[i].Properties["Name"].StringValue);
                _CATEGORY.Add(list[i].Properties["Name"].StringValue, list[i].RowKey);
                DataTable dt = Param.DataTableProduct.Clone();
                dt.TableName = list[i].Properties["Name"].StringValue;
                Param.DataSet.Tables.Add(dt);
            }
            Param.DataSet.Tables.Add(data);

            azureTable = Param.AzureTableClient.GetTableReference("Brand");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId));
            list = azureTable.ExecuteQuery(query).ToList();

            //## ยี่ห้อ ##//
            data = new DataTable();
            data.Columns.Add("ID", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["ID"] };
            data.TableName = "Data-Brand";

            _BRAND = new SortedDictionary<string, string>();
            for (int i = 0; i < list.Count; i++)
            {
                data.Rows.Add(list[i].RowKey, list[i].Properties["Name"].StringValue);
                _BRAND.Add(list[i].RowKey, list[i].Properties["Name"].StringValue);
            }
            Param.DataSet.Tables.Add(data);

            //## ประเทศผู้ผลิต ##//
            azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId+ "-MakerCountry"));
            list = azureTable.ExecuteQuery(query).ToList();

            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-MakerCountry";
            for (int i = 0; i < list.Count; i++)
                data.Rows.Add(list[i].RowKey);
            Param.DataSet.Tables.Add(data);

            //## อุปกรณ์ที่รองรับ ##//
            azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId + "-Device"));
            list = azureTable.ExecuteQuery(query).ToList();

            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-Device";
            for (int i = 0; i < list.Count; i++)
                data.Rows.Add(list[i].RowKey);
            Param.DataSet.Tables.Add(data);

            //## มาตรฐาน ##//
            azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId + "-Standard"));
            list = azureTable.ExecuteQuery(query).ToList();

            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-Standard";
            for (int i = 0; i < list.Count; i++)
                data.Rows.Add(list[i].RowKey);
            Param.DataSet.Tables.Add(data);

            //## ป้ายกำกับ ##//
            azureTable = Param.AzureTableClient.GetTableReference("PropertiesOption");
            query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, Param.ShopId + "-Label"));
            list = azureTable.ExecuteQuery(query).ToList();

            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
            data.TableName = "Data-Label";
            for (int i = 0; i < list.Count; i++)
                data.Rows.Add(list[i].RowKey);
            Param.DataSet.Tables.Add(data);

        }

        private void bwLoadCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            navBarProduct.ItemLinks.Clear();
            NavBarItem item;
            SortedDictionary<string, string> category = new SortedDictionary<string, string>();
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

            Util.SetComboboxDataSource(cbbCategory, Param.DataSet.Tables["Data-Category"], "Name");
            Util.SetComboboxDataSource(cbbBrand, Param.DataSet.Tables["Data-Brand"], "Name");
            Util.SetComboboxDataSource(cbbMadeIn, Param.DataSet.Tables["Data-MakerCountry"], "Name");
            Util.SetOptionDataSource(cbbDevice, Param.DataSet.Tables["Data-Device"], "Name");
            Util.SetOptionDataSource(cbbStandard, Param.DataSet.Tables["Data-Standard"], "Name");
            Util.SetOptionDataSource(cbbLabel, Param.DataSet.Tables["Data-Label"], "Name");

            bwLoadProduct.RunWorkerAsync();
        }

        private void bwLoadProduct_DoWork(object sender, DoWorkEventArgs e)
        {
            var azureTable = Param.AzureTableClient.GetTableReference("Product");
            TableQuery<DynamicTableEntity> query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "88888888"));
            List<DynamicTableEntity> list = azureTable.ExecuteQuery(query).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    var categoryName = list[i].Properties.ContainsKey("Category") ? _CATEGORY[list[i].Properties["Category"].StringValue] : "";
                    Param.DataSet.Tables[categoryName].Rows.Add(list[i].RowKey,
                        list[i].Properties.ContainsKey("SKU") ? list[i].Properties["SKU"].StringValue : "",
                        list[i].Properties.ContainsKey("AdviceCode") ? list[i].Properties["AdviceCode"].StringValue : "",
                        list[i].Properties.ContainsKey("TrueCode") ? list[i].Properties["TrueCode"].StringValue : "",
                        list[i].Properties.ContainsKey("Name") ? list[i].Properties["Name"].StringValue : "",
                        list[i].Properties.ContainsKey("Price") ? list[i].Properties["Price"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Price1") ? list[i].Properties["Price1"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Price2") ? list[i].Properties["Price2"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Price3") ? list[i].Properties["Price3"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Price4") ? list[i].Properties["Price4"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Price5") ? list[i].Properties["Price5"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Cost") ? list[i].Properties["Cost"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Stock") ? list[i].Properties["Stock"].Int32Value : 0,
                        list[i].Properties.ContainsKey("Active") ? list[i].Properties["Active"].BooleanValue : false,
                        list[i].Properties.ContainsKey("Visible") ? list[i].Properties["Visible"].BooleanValue : false,
                        list[i].Properties.ContainsKey("BrandId") ? list[i].Properties["Brand"].StringValue : "",
                        list[i].Properties.ContainsKey("Brand") ? _BRAND[list[i].Properties["Brand"].StringValue] : "",
                        list[i].Properties.ContainsKey("CategoryId") ? list[i].Properties["Category"].StringValue : "",
                        categoryName,
                        list[i].Properties.ContainsKey("Warranty") ? list[i].Properties["Warranty"].Int32Value : 0,
                        list[i].Properties.ContainsKey("Material") ? list[i].Properties["Material"].StringValue : "",
                        list[i].Properties.ContainsKey("Model") ? list[i].Properties["Model"].StringValue : "",
                        list[i].Properties.ContainsKey("Detail") ? list[i].Properties["Detail"].StringValue : "",
                        list[i].Properties.ContainsKey("SpecialProperties") ? list[i].Properties["SpecialProperties"].StringValue : "",
                        list[i].Properties.ContainsKey("MadeIn") ? list[i].Properties["MadeIn"].StringValue : "",
                        list[i].Properties.ContainsKey("Color") && list[i].Properties["Color"].StringValue != "" ? ColorTranslator.FromHtml(list[i].Properties["Color"].StringValue).ToArgb() : 0,
                        list[i].Properties.ContainsKey("DeviceSupport") ? list[i].Properties["DeviceSupport"].StringValue : "",
                        list[i].Properties.ContainsKey("Width") ? list[i].Properties["Width"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Length") ? list[i].Properties["Length"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Height") ? list[i].Properties["Height"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("Weight") ? list[i].Properties["Weight"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("GrossWeight") ? list[i].Properties["GrossWeight"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("CoverImage") ? list[i].Properties["CoverImage"].StringValue : "",
                        list[i].Properties.ContainsKey("Image1") ? list[i].Properties["Image1"].StringValue : "",
                        list[i].Properties.ContainsKey("Image2") ? list[i].Properties["Image2"].StringValue : "",
                        list[i].Properties.ContainsKey("Image3") ? list[i].Properties["Image3"].StringValue : "",
                        list[i].Properties.ContainsKey("Image4") ? list[i].Properties["Image4"].StringValue : "",
                        list[i].Properties.ContainsKey("Image5") ? list[i].Properties["Image5"].StringValue : "",
                        list[i].Properties.ContainsKey("Image6") ? list[i].Properties["Image6"].StringValue : "",
                        list[i].Properties.ContainsKey("Image7") ? list[i].Properties["Image7"].StringValue : "",
                        list[i].Properties.ContainsKey("Image8") ? list[i].Properties["Image8"].StringValue : "",
                        list[i].Properties.ContainsKey("Image9") ? list[i].Properties["Image9"].StringValue : "",
                        list[i].Properties.ContainsKey("Image10") ? list[i].Properties["Image10"].StringValue : "",
                        list[i].Properties.ContainsKey("Label") ? list[i].Properties["Label"].StringValue : "",
                        list[i].Properties.ContainsKey("IsPromotion") ? list[i].Properties["IsPromotion"].BooleanValue : false,
                        list[i].Properties.ContainsKey("PricePromotion") ? list[i].Properties["PricePromotion"].DoubleValue : 0,
                        list[i].Properties.ContainsKey("ChargeType") ? list[i].Properties["ChargeType"].StringValue : "",
                        list[i].Properties.ContainsKey("HowToUse") ? list[i].Properties["HowToUse"].StringValue : "",
                        list[i].Properties.ContainsKey("Standard") ? list[i].Properties["Standard"].StringValue : "",
                        list[i].Properties.ContainsKey("InBox") ? list[i].Properties["InBox"].StringValue : ""                    
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
            splashScreenManager.CloseWaitForm();
            navBarProduct.ItemLinks[0].PerformClick();
            navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl;
            navBarControl1.Enabled = true;
        }

        private void navBarCategory_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _CATEGORY_SELECTED = e.Link.Caption;
            LoadProductCategoryData();
        }

        private void chkIsNotActive_CheckedChanged(object sender, EventArgs e)
        {
            LoadProductCategoryData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadProductCategoryData();
        }

        private void LoadProductCategoryData()
        {
            gridControl1.DataSource = Param.DataSet.Tables[_CATEGORY_SELECTED];

            StringBuilder sb = new StringBuilder();
            if(!chkIsNotActive.Checked && !chkIsNotVisible.Checked)
                sb.Append("[Active] = true AND [Visible] = true");
            else if (chkIsNotActive.Checked && !chkIsNotVisible.Checked)
                sb.Append("[Visible] = true");
            else if (!chkIsNotActive.Checked && chkIsNotVisible.Checked)
                sb.Append("[Active] = true");
            if (txtSearch.Text.Trim() != "")
            {
                sb.Append( (sb.ToString() != "" ? " AND " : "") + string.Format(" ([Name] LIKE '%{0}%' OR [SKU] LIKE '%{0}%')",txtSearch.Text.Trim()) );
            }
            ((GridView)gridControl1.DefaultView).ActiveFilterString = sb.ToString();
            gridControl1.Update();
        }

        private void UpdateProductData(string key, string value, Param.AzureDataType type)
        {
            Util.UpdateData("Product", Param.ShopId, _PRODUCT_PROPERTIES.Rows[0]["ID"].ToString(), key, value, type);
        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Name"] = ((TextEdit)sender).Text;
            UpdateProductData("Name", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtModel_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Model"] = ((TextEdit)sender).Text;
            UpdateProductData("Model", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtMaterial_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Material"] = ((TextEdit)sender).Text;
            UpdateProductData("Material", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtMadeIn_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["MadeIn"] = ((TextEdit)sender).Text;
            UpdateProductData("MadeIn", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtWarranty_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Warranty"] = ((TextEdit)sender).Text;
            UpdateProductData("Warranty", ((TextEdit)sender).Text, Param.AzureDataType.Int);
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price"] = ((TextEdit)sender).Text;
            UpdateProductData("Price", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice1_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price1"] = ((TextEdit)sender).Text;
            UpdateProductData("Price1", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice2_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price2"] = ((TextEdit)sender).Text;
            UpdateProductData("Price2", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice3_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price3"] = ((TextEdit)sender).Text;
            UpdateProductData("Price3", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice4_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price4"] = ((TextEdit)sender).Text;
            UpdateProductData("Price4", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice5_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Price5"] = ((TextEdit)sender).Text;
            UpdateProductData("Price5", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtDetail_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Detail"] = ((TextEdit)sender).Text;
            UpdateProductData("Detail", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtSpecial_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["SpecialProperties"] = ((TextEdit)sender).Text;
            UpdateProductData("SpecialProperties", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtWidth_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Width"] = ((TextEdit)sender).Text;
            UpdateProductData("Width", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtLength_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Length"] = ((TextEdit)sender).Text;
            UpdateProductData("Length", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtHeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Height"] = ((TextEdit)sender).Text;
            UpdateProductData("Height", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtWeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Weight"] = ((TextEdit)sender).Text;
            UpdateProductData("Weight", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtGrossWeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["GrossWeight"] = ((TextEdit)sender).Text;
            UpdateProductData("GrossWeight", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void color_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["Color"] = ((ColorEdit)sender).EditValue;
            UpdateProductData("Color", ColorTranslator.ToHtml(Color.FromArgb(int.Parse(((ColorEdit)sender).EditValue.ToString()))), Param.AzureDataType.String);
        }

        private void txtPricePromotion_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["PricePromotion"] = ((TextEdit)sender).Text;
            UpdateProductData("PricePromotion", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtAdviceCode_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["AdviceCode"] = ((TextEdit)sender).Text;
            UpdateProductData("AdviceCode", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtTrueCode_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["TrueCode"] = ((TextEdit)sender).Text;
            UpdateProductData("TrueCode", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtChargeType_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["ChargeType"] = ((TextEdit)sender).Text;
            UpdateProductData("ChargeType", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtHowToUse_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["HowToUse"] = ((TextEdit)sender).Text;
            UpdateProductData("HowToUse", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtInBox_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["InBox"] = ((TextEdit)sender).Text;
            UpdateProductData("InBox", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void cbbDevice_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for(int i=0; i<data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["DeviceSupport"] = sb.ToString();
            UpdateProductData("DeviceSupport", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbLabel_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["Label"] = sb.ToString();
            UpdateProductData("Label", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbStandard_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["Standard"] = sb.ToString();
            UpdateProductData("Standard", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbDevice_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["DeviceSupport"].ToString().Replace(", ", "|"));
            CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
            var data = checkedComboBoxEdit.Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (checkedData.IndexOf(string.Format("|{0}|", data[i].Value)) != -1)
                    checkedComboBoxEdit.Properties.Items[i].CheckState = CheckState.Checked;
        }

        private void cbbLabel_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["Label"].ToString().Replace(", ", "|"));
            CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
            var data = checkedComboBoxEdit.Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (checkedData.IndexOf(string.Format("|{0}|", data[i].Value)) != -1)
                    checkedComboBoxEdit.Properties.Items[i].CheckState = CheckState.Checked;
        }

        private void cbbStandard_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["Standard"].ToString().Replace(", ", "|"));
            CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
            var data = checkedComboBoxEdit.Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (checkedData.IndexOf(string.Format("|{0}|", data[i].Value)) != -1)
                    checkedComboBoxEdit.Properties.Items[i].CheckState = CheckState.Checked;
        }

        private void chkPromotion_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkedEdit = (CheckEdit)sender;
            if (checkedEdit.CheckState == CheckState.Checked)
            {
                _PRODUCT_PROPERTIES.Rows[0]["PricePromotion"] = _PRODUCT_PROPERTIES.Rows[0]["Price4"];
                UpdateProductData("IsPromotion", "1", Param.AzureDataType.Boolean);
            }
            else
            {
                _PRODUCT_PROPERTIES.Rows[0]["PricePromotion"] = 0;
                UpdateProductData("IsPromotion", "0", Param.AzureDataType.Boolean);
            }
            UpdateProductData("PricePromotion", _PRODUCT_PROPERTIES.Rows[0]["PricePromotion"].ToString(), Param.AzureDataType.Double);
            _PRODUCT_ROW_SELECTED["PricePromotion"] = _PRODUCT_PROPERTIES.Rows[0]["PricePromotion"];

            //_PRODUCT_PROPERTIES.Rows[0]["IsPromotion"] = checkedEdit.CheckState;
            _PRODUCT_ROW_SELECTED["IsPromotion"] = checkedEdit.CheckState == CheckState.Checked;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkedEdit = (CheckEdit)sender;
            UpdateProductData("Visible", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0", Param.AzureDataType.Boolean);
            _PRODUCT_ROW_SELECTED["Visible"] = checkedEdit.CheckState == CheckState.Checked;
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkedEdit = (CheckEdit)sender;
            UpdateProductData("Active", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0", Param.AzureDataType.Boolean);
            _PRODUCT_ROW_SELECTED["Active"] = checkedEdit.CheckState == CheckState.Checked;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = ((ComboBoxEdit)sender).SelectedItem.ToString();
            string id = string.Empty;
            foreach (var data in _CATEGORY)
            {
                if (data.Value == name)
                {
                    id = data.Key;
                    break;
                }
            }
            _PRODUCT_ROW_SELECTED["Category"] = name;
            UpdateProductData("Category", id, Param.AzureDataType.String);
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = ((ComboBoxEdit)sender).SelectedItem.ToString();
            string id = string.Empty;
            foreach (var data in _BRAND)
            {
                if (data.Value == name)
                {
                    id = data.Key;
                    break;
                }
            }
            _PRODUCT_ROW_SELECTED["Brand"] = name;
            UpdateProductData("Brand", id, Param.AzureDataType.String);
        }

        private void cbbMadeIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["MadeIn"] = ((ComboBoxEdit)sender).SelectedItem.ToString();
            UpdateProductData("MadeIn", ((ComboBoxEdit)sender).SelectedItem.ToString(), Param.AzureDataType.String);
        }

        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try {
                BandedGridView bandedGridView = (BandedGridView)sender;
                _PRODUCT_ROW_SELECTED = bandedGridView.GetFocusedDataRow();
                _PRODUCT_PROPERTIES = new DataTable();
                _PRODUCT_PROPERTIES = Param.DataTableProduct.Clone();
                _PRODUCT_PROPERTIES.Rows.Add(_PRODUCT_ROW_SELECTED.ItemArray);
                vGridControl1.DataSource = _PRODUCT_PROPERTIES;
                vGridControl1.Enabled = true;
            }
            catch
            {
                vGridControl1.DataSource = null;
                vGridControl1.Enabled = false;
            }
        }

        private void navDevice_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmDevice fm = new FmDevice();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbDevice, Param.DataSet.Tables["Data-Device"], "Name");
        }

        private void navMadeIn_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmMadeIn fm = new FmMadeIn();
            fm.ShowDialog(this);
            Util.SetComboboxDataSource(cbbMadeIn, Param.DataSet.Tables["Data-MakerCountry"], "Name");
        }

        private void navStandard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmStandard fm = new FmStandard();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbStandard, Param.DataSet.Tables["Data-Standard"], "Name");
        }

        private void navLabel_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmLabel fm = new FmLabel();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbLabel, Param.DataSet.Tables["Data-Label"], "Name");
        }
    }
}
