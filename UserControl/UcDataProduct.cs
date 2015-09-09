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
using DevExpress.XtraNavBar;
using System.IO;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

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
        //Image _STREAM_IMAGE;
        string _STREAM_IMAGE_URL;
        //FmUploadImage _FORM_UPLOAD_IMAGE;

        dynamic _JSON_CATEGORY;
        dynamic _JSON_PRODUCT;

        DataTable _TABLE_PRODUCT;

        public UcDataProduct()
        {
            InitializeComponent();
        }

        private void UcDataProduct_Load(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            navBarControl1.Enabled = false;
            _GRID_VIEW = (GridView) gridControl1.MainView;
            //_FORM_UPLOAD_IMAGE = new FmUploadImage();
            Param.DataSet = new DataSet();

            bwLoadCategory.RunWorkerAsync();
        }

        private void bwLoadCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            _JSON_CATEGORY = JsonConvert.DeserializeObject(Util.GetApiData("/category/info", "shop=" + Param.ShopId));

            DataTable data = new DataTable();
            dynamic json = JsonConvert.DeserializeObject(Util.GetApiData("/properties/info", "shop=" + Param.ShopId + "&type=common"));
            for (int i = 0; i < json.result.Count; i++)
            {
                data = new DataTable();
                data.Columns.Add("Name", typeof(string));
                data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
                data.TableName = "Data-" + json.result[i].entityKey.Value;
                string[] ex = json.result[i].entityValue.Value.Split(',');
                for (int j = 0; j < ex.Length; j++)
                    data.Rows.Add(ex[j]);
                Param.DataSet.Tables.Add(data);
            }

            /*json = JsonConvert.DeserializeObject(Util.GetApiData("/properties/info", "shop=" + Param.ShopId + "&type=category"));
            for (int i = 0; i < json.result.Count; i++)
            {
                data = new DataTable();
                data.Columns.Add("Name", typeof(string));
                data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
                data.TableName = "Data-" + json.result[i].entityKey.Value;
                string[] ex = json.result[i].entityValue.Value.Split(',');
                for (int j = 0; j < ex.Length; j++)
                    data.Rows.Add(ex[j]);
                Param.DataSet.Tables.Add(data);
            }*/

            json = JsonConvert.DeserializeObject(Util.GetApiData("/brand/info", "shop=" + Param.ShopId));
            data = new DataTable();
            data.Columns.Add("Name", typeof(string));
            data.TableName = "Data-Brand";
            _BRAND = new SortedDictionary<string, string>();
            for (int i = 0; i < json.result.Count; i++)
            {
                data.Rows.Add(json.result[i].name.Value);
                _BRAND.Add(json.result[i].brand.Value, json.result[i].name.Value);
            }
            Param.DataSet.Tables.Add(data);

            /*
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
            */

        }

        private void bwLoadCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!_JSON_CATEGORY.success.Value)
            {
                MessageBox.Show(_JSON_CATEGORY.error, _JSON_CATEGORY.errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable data = new DataTable();
                data.Columns.Add("Name", typeof(string));
                data.TableName = "Data-Category";

                _CATEGORY = new SortedDictionary<string, string>();
                navBarProduct.ItemLinks.Clear();
                NavBarItem item;
                for (int i = 0; i < _JSON_CATEGORY.result.Count; i++)
                {
                    item = new NavBarItem(_JSON_CATEGORY.result[i].name.Value);
                    item.SmallImage = global::PowerBackend.Properties.Resources.boproduct_16x16;
                    item.LinkClicked += new NavBarLinkEventHandler(navBarCategory_LinkClicked);
                    navBarProduct.ItemLinks.Add(item);
                    if (navBarProduct.ItemLinks.Count == 1)
                    {
                        _CATEGORY_SELECTED = _JSON_CATEGORY.result[i].name.Value;
                    }
                    data.Rows.Add(_JSON_CATEGORY.result[i].name.Value);
                    _CATEGORY.Add(_JSON_CATEGORY.result[i].category.Value, _JSON_CATEGORY.result[i].name.Value);
                    //category.Add(data.Value, data.Key);
                }
                Param.DataSet.Tables.Add(data);
                bwLoadProduct.RunWorkerAsync();
            }

            Util.SetComboboxDataSource(cbbCategory, Param.DataSet.Tables["Data-Category"], "Name");
            Util.SetComboboxDataSource(cbbBrand, Param.DataSet.Tables["Data-Brand"], "Name");
            Util.SetComboboxDataSource(cbbMadeIn, Param.DataSet.Tables["Data-makerCountry"], "Name");
            Util.SetOptionDataSource(cbbDevice, Param.DataSet.Tables["Data-device"], "Name");
            Util.SetOptionDataSource(cbbStandard, Param.DataSet.Tables["Data-standard"], "Name");
            Util.SetOptionDataSource(cbbLabel, Param.DataSet.Tables["Data-label"], "Name");
            Util.SetComboboxDataSource(cbbCapacity, Param.DataSet.Tables["Data-capacity"], "Name");
            Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");

            Util.SetComboboxDataSource(cbbCapacity, Param.DataSet.Tables["Data-capacity"], "Name");
            Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
            /*
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

            Util.SetComboboxDataSource(cbbBrand, Param.DataSet.Tables["Data-Brand"], "Name");

            */
        }

        private void bwLoadProduct_DoWork(object sender, DoWorkEventArgs e)
        {
            _JSON_PRODUCT = JsonConvert.DeserializeObject(Util.GetApiData("/product/info", 
                string.Format("shop={0}&type=byCategoryName&value={1}", Param.ShopId, _CATEGORY_SELECTED)
            ));

            if (_JSON_PRODUCT.success.Value)
            {
                if (_JSON_PRODUCT.result.Count > 0)
                {
                    _TABLE_PRODUCT = new DataTable();
                    List<string> columnName = new List<string>();
                    foreach (var pair in _JSON_PRODUCT.result[0])
                    {
                        try {
                            Type type;
                            if (pair.Value.Value != null)
                            {
                                if (pair.Value.Value.GetType().Name == "Double")
                                    type = typeof(Double);
                                else if (pair.Value.Value.GetType().Name == "Int32")
                                    type = typeof(Int32);
                                else if (pair.Value.Value.GetType().Name == "Int64")
                                    type = typeof(Int64);
                                else if (pair.Value.Value.GetType().Name == "Boolean")
                                    type = typeof(Boolean);
                                else if (pair.Value.Value.GetType().Name == "DateTime")
                                    type = typeof(DateTime);
                                else
                                    type = typeof(String);
                            }
                            else
                                type = typeof(String);

                            _TABLE_PRODUCT.Columns.Add(pair.Name, type);
                            columnName.Add(pair.Name);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Add column type error ({0}) : {1}", pair.Name, ex.Message);
                        }
                    }

                    _TABLE_PRODUCT.Columns.Add("hasCoverImageIcon", typeof(Image));
                    columnName.Add("hasCoverImageIcon");

                    for (int i=0; i< _JSON_PRODUCT.result.Count; i++)
                    {
                        object[] values = new object[columnName.Count];
                        for (int j = 0; j < columnName.Count; j++)
                        {
                            if(columnName[j] == "hasCoverImageIcon")
                                values[j] = _JSON_PRODUCT.result[i]["hasCoverImage"].Value ? global::PowerBackend.Properties.Resources.picture : global::PowerBackend.Properties.Resources.picture_empty;
                            else
                                values[j] = _JSON_PRODUCT.result[i][columnName[j]].Value == null ? "" : _JSON_PRODUCT.result[i][columnName[j]].Value;                                
                        }
                        _TABLE_PRODUCT.Rows.Add(values);
                    }

                }
            }

            /*   dynamic d = _JSON_PRODUCT.result[0];
           Dictionary<string, object> values = JsonConvert.DeserializeObject<Dictionary<string, object>>(_JSON_PRODUCT.result[0].ToString());
           foreach (var pair in d)
           {
               Console.WriteLine("{0}:{1}", pair.Name, pair.Value);
           }*/





            /*var azureTable = Param.AzureTableClient.GetTableReference("Product");
            TableQuery<DynamicTableEntity> query = new TableQuery<DynamicTableEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "88888888"));
            List<DynamicTableEntity> list = azureTable.ExecuteQuery(query).ToList();

            //Image has = global::PowerBackend.Properties.Resources.picture;

            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    var categoryName = list[i].Properties.ContainsKey("Category") ? _CATEGORY[list[i].Properties["Category"].StringValue] : "";
                    Param.DataSet.Tables[categoryName].Rows.Add(list[i].RowKey,
                        list[i].Properties.Contain
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
                        list[i].Properties.ContainsKey("Label") ? list[i].Properties["Label"].StringValue : "",
                        list[i].Properties.ContainsKey("ChargeType") ? list[i].Properties["ChargeType"].StringValue : "",
                        list[i].Properties.ContainsKey("HowToUse") ? list[i].Properties["HowToUse"].StringValue : "",
                        list[i].Properties.ContainsKey("Standard") ? list[i].Properties["Standard"].StringValue : "",
                        list[i].Properties.ContainsKey("InBox") ? list[i].Properties["InBox"].StringValue : ""                    
                    );
                }
                catch(Exception ex)
                {
                    Console.WriteLine("{0} : {1}", list[i].RowKey, ex.Message);
                }*/
            //}
        }

        private void bwLoadProduct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                splashScreenManager.CloseWaitForm();
            }
            catch { }
            navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl;
            LoadProductCategoryData();
        }

        private void navBarCategory_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            _CATEGORY_SELECTED = e.Link.Caption;
            try
            {
                splashScreenManager.ShowWaitForm();
            }
            catch { }
            navBarControl1.Enabled = false;
            gridControl1.Enabled = false;
            bwLoadProduct.RunWorkerAsync();
            //LoadProductCategoryData();
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
            //gridControl1.DataSource = Param.DataSet.Tables[_CATEGORY_SELECTED];
            gridControl1.DataSource = _TABLE_PRODUCT;

            StringBuilder sb = new StringBuilder();
            if(!chkIsNotActive.Checked && !chkIsNotVisible.Checked)
                sb.Append("[active] = true AND [visible] = true");
            else if (chkIsNotActive.Checked && !chkIsNotVisible.Checked)
                sb.Append("[visible] = true");
            else if (!chkIsNotActive.Checked && chkIsNotVisible.Checked)
                sb.Append("[active] = true");
            if (txtSearch.Text.Trim() != "")
            {
                sb.Append( (sb.ToString() != "" ? " AND " : "") + string.Format(" (name] LIKE '%{0}%' OR [sku] LIKE '%{0}%')",txtSearch.Text.Trim()) );
            }

            //GridView view = ((GridView)gridControl1.DefaultView);
            _GRID_VIEW.ActiveFilterString = sb.ToString();
            gridControl1.Update();

            navBarControl1.Enabled = true;
            gridControl1.Enabled = true;
            /*for(int i=0; i< _GRID_VIEW.RowCount; i++)
            {
                DataRow dr = _GRID_VIEW.GetDataRow(i);
                if ((bool)dr["hasCoverImage"])
                {
                    _GRID_VIEW.SetRowCellValue(i, "HasCoverImage", Image.FromFile(@"D:\Projects\Resources\Free Icons\famfamfam\accept.png"));
                }
            }*/
        }

        private async void UpdateProductData(string id, string key, string value)
        {

            dynamic json = JsonConvert.DeserializeObject(await Util.UpdateApiData("/product/update",
                string.Format("shop={0}&id={1}&entity={2}&value={3}", Param.ShopId, id, key, value)
            ));
            if (!json.success.Value)
            {
                MessageBox.Show(json.errorMessage.Value, json.error.Value, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Util.UpdateData("Product", Param.ShopId, _PRODUCT_PROPERTIES.Rows[0]["ID"].ToString(), key, value, type);
        }


        #region Edit Properties

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["name"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "name", ((TextEdit)sender).Text);
            //UpdateProductData("Name", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtModel_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["model"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "model", ((TextEdit)sender).Text);
            //UpdateProductData("Model", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtMaterial_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["material"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "material", ((TextEdit)sender).Text);
            //UpdateProductData("Material", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtMadeIn_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["madeIn"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "madeIn", ((TextEdit)sender).Text);
            //UpdateProductData("MadeIn", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtWarranty_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["warranty"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "warranty", ((TextEdit)sender).Text);
            //UpdateProductData("Warranty", ((TextEdit)sender).Text, Param.AzureDataType.Int);
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice1_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price1"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price1", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price1", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice2_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price2"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price2", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price2", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice3_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price3"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price3", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price3", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice4_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price4"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price4", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price4", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtPrice5_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["price5"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "price5", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Price5", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtDetail_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["detail"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "detail", ((TextEdit)sender).Text);
            //UpdateProductData("Detail", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtSpecial_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["specialProperties"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "specialProperties", ((TextEdit)sender).Text);
            //UpdateProductData("SpecialProperties", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtWidth_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["width"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "width", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Width", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtLength_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["length"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "length", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Length", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtHeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["height"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "height", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Height", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtWeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["weight"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "weight", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("Weight", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtGrossWeight_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["grossWeight"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "grossWeight", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("GrossWeight", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void color_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["color"] = ((ColorEdit)sender).EditValue;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "color", ColorTranslator.ToHtml(Color.FromArgb(int.Parse(((ColorEdit)sender).EditValue.ToString()))));
            //UpdateProductData("Color", ColorTranslator.ToHtml(Color.FromArgb(int.Parse(((ColorEdit)sender).EditValue.ToString()))), Param.AzureDataType.String);
        }

        private void txtPricePromotion_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["pricePromotion"] = double.Parse(((TextEdit)sender).Text.Replace(",", ""));
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "pricePromotion", ((TextEdit)sender).Text.Replace(",", ""));
            //UpdateProductData("PricePromotion", ((TextEdit)sender).Text, Param.AzureDataType.Double);
        }

        private void txtAdviceCode_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["buyerCode1"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "buyerCode1", ((TextEdit)sender).Text);
            //UpdateProductData("AdviceCode", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtTrueCode_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["buyerCode2"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "buyerCode2", ((TextEdit)sender).Text);
            //UpdateProductData("TrueCode", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtChargeType_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["chargeType"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "chargeType", ((TextEdit)sender).Text);
            //UpdateProductData("ChargeType", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtHowToUse_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["howToUse"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "howToUse", ((TextEdit)sender).Text);
            //UpdateProductData("HowToUse", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void txtInBox_EditValueChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["inBox"] = ((TextEdit)sender).Text;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "inBox", ((TextEdit)sender).Text);
            //UpdateProductData("InBox", ((TextEdit)sender).Text, Param.AzureDataType.String);
        }

        private void cbbDevice_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["deviceSupport"] = sb.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "deviceSupport", ((TextEdit)sender).Text);
            //UpdateProductData("DeviceSupport", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbLabel_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["label"] = sb.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "label", ((TextEdit)sender).Text);
            //UpdateProductData("Label", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbStandard_EditValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var data = ((CheckedComboBoxEdit)sender).Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (data[i].CheckState == CheckState.Checked)
                    sb.Append(string.Format("{0}{1}", sb.ToString() == "" ? "" : ", ", data[i].Value));

            ((TextEdit)sender).Text = sb.ToString();
            _PRODUCT_ROW_SELECTED["standard"] = sb.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "standard", ((TextEdit)sender).Text);
            //UpdateProductData("Standard", sb.ToString(), Param.AzureDataType.String);
        }

        private void cbbDevice_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["deviceSupport"].ToString().Replace(", ", "|"));
            CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
            var data = checkedComboBoxEdit.Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (checkedData.IndexOf(string.Format("|{0}|", data[i].Value)) != -1)
                    checkedComboBoxEdit.Properties.Items[i].CheckState = CheckState.Checked;
        }

        private void cbbLabel_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["label"].ToString().Replace(", ", "|"));
            CheckedComboBoxEdit checkedComboBoxEdit = (CheckedComboBoxEdit)sender;
            var data = checkedComboBoxEdit.Properties.Items;
            for (int i = 0; i < data.Count; i++)
                if (checkedData.IndexOf(string.Format("|{0}|", data[i].Value)) != -1)
                    checkedComboBoxEdit.Properties.Items[i].CheckState = CheckState.Checked;
        }

        private void cbbStandard_QueryPopUp(object sender, CancelEventArgs e)
        {
            var checkedData = string.Format("|{0}|", _PRODUCT_ROW_SELECTED["standard"].ToString().Replace(", ", "|"));
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
                _PRODUCT_PROPERTIES.Rows[0]["pricePromotion"] = _PRODUCT_PROPERTIES.Rows[0]["price4"];
                UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "isPromotion", "1");
                //UpdateProductData("IsPromotion", "1", Param.AzureDataType.Boolean);
            }
            else
            {
                _PRODUCT_PROPERTIES.Rows[0]["pricePromotion"] = 0;
                UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "isPromotion", "0");
                //UpdateProductData("IsPromotion", "0", Param.AzureDataType.Boolean);
            }
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "pricePromotion", _PRODUCT_PROPERTIES.Rows[0]["pricePromotion"].ToString());
            //UpdateProductData("PricePromotion", _PRODUCT_PROPERTIES.Rows[0]["PricePromotion"].ToString(), Param.AzureDataType.Double);
            _PRODUCT_ROW_SELECTED["pricePromotion"] = _PRODUCT_PROPERTIES.Rows[0]["pricePromotion"];

            //_PRODUCT_PROPERTIES.Rows[0]["IsPromotion"] = checkedEdit.CheckState;
            _PRODUCT_ROW_SELECTED["isPromotion"] = checkedEdit.CheckState == CheckState.Checked;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkedEdit = (CheckEdit)sender;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "visible", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0");
            //UpdateProductData("Visible", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0", Param.AzureDataType.Boolean);
            _PRODUCT_ROW_SELECTED["visible"] = checkedEdit.CheckState == CheckState.Checked;
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkedEdit = (CheckEdit)sender;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "active", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0");
            //UpdateProductData("Active", (checkedEdit.CheckState == CheckState.Checked) ? "1" : "0", Param.AzureDataType.Boolean);
            _PRODUCT_ROW_SELECTED["active"] = checkedEdit.CheckState == CheckState.Checked;
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
            _PRODUCT_ROW_SELECTED["category"] = name;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "category", id);
            //UpdateProductData("Category", id, Param.AzureDataType.String);
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
            _PRODUCT_ROW_SELECTED["brand"] = name;
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "brand", id);
            //UpdateProductData("Brand", id, Param.AzureDataType.String);
        }

        private void cbbMadeIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["madeIn"] = ((ComboBoxEdit)sender).SelectedItem.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "madeIn", ((ComboBoxEdit)sender).SelectedItem.ToString());
            //UpdateProductData("MadeIn", ((ComboBoxEdit)sender).SelectedItem.ToString(), Param.AzureDataType.String);
        }

        private void cbbCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["capacity"] = ((ComboBoxEdit)sender).SelectedItem.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "capacity", ((ComboBoxEdit)sender).SelectedItem.ToString());
        }

        private void cbbBatteryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PRODUCT_ROW_SELECTED["batteryType"] = ((ComboBoxEdit)sender).SelectedItem.ToString();
            UpdateProductData(_PRODUCT_ROW_SELECTED["product"].ToString(), "batteryType", ((ComboBoxEdit)sender).SelectedItem.ToString());
        }

        #endregion

        private async void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try {
                BandedGridView bandedGridView = (BandedGridView)sender;
                _PRODUCT_ROW_SELECTED = bandedGridView.GetFocusedDataRow();
                _PRODUCT_PROPERTIES = new DataTable();
                _PRODUCT_PROPERTIES = _TABLE_PRODUCT.Clone();
                _PRODUCT_PROPERTIES.Rows.Add(_PRODUCT_ROW_SELECTED.ItemArray);
                vGridControl1.DataSource = _PRODUCT_PROPERTIES;
                vGridControl1.Enabled = true;

                tileGroup1.Items.Clear();
                if ((bool)_PRODUCT_ROW_SELECTED["hasCoverImage"])
                {
                    //http://src.powerdd.com/img/product/88888888/D1400010/1.jpg
                    //api-test.powerdd.com/img/remax/product/88888888/D1400010/300/300/1.jpg
                    _STREAM_IMAGE_URL = "http://src.powerdd.com/img/product/" + Param.Shop + "/" + _PRODUCT_ROW_SELECTED["sku"].ToString() + "/" + _PRODUCT_ROW_SELECTED["image"].ToString().Split(',')[0];
                    TileItem itmImg = new TileItem();
                    TileItemElement tileItemElement1 = new TileItemElement();
                    tileItemElement1.Text = "กำลังโหลดรูปภาพ";
                    itmImg.Elements.Add(tileItemElement1);
                    itmImg.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
                    itmImg.Id = 0;
                    itmImg.ItemSize = TileItemSize.Medium;
                    itmImg.Name = "CoverImage";
                    itmImg.AppearanceItem.Normal.ForeColor = Color.DarkGray;
                    itmImg.Checked = true;
                    tileGroup1.Items.Add(itmImg);
                    /*bwLoadImage.CancelAsync();
                    while (bwLoadImage.IsBusy)
                    {
                        Application.DoEvents();
                    }
                    bwLoadImage.RunWorkerAsync();*/


                    tileGroup1.Items[0].BackgroundImage = await DownloadImage("http://src.powerdd.com/img/product/" + Param.Shop + "/" +
                        _PRODUCT_ROW_SELECTED["sku"].ToString() + "/" + _PRODUCT_ROW_SELECTED["image"].ToString().Split(',')[0]);
                    tileGroup1.Items[0].Elements[0].Text = "ภาพหลัก";

                    //tileGroup1.Items.Add(GenerateAddImageItem());

                }
                else
                {
                    //tileGroup1.Items.Add(GenerateAddImageItem());
                }

                int idx = 1;
                string[] image = _PRODUCT_ROW_SELECTED["image"].ToString().Split(',');
                for(int i=1; i< image.Length; i++)
                {
                    if (image[i] != image[0] && image[i].Substring(0,1).ToLower() != "d")
                    {
                        try {
                            TileItem itmImg = new TileItem();
                            TileItemElement tileItemElement1 = new TileItemElement();
                            tileItemElement1.Text = "ภาพที่ " + idx; //"กำลังโหลดรูปภาพ";
                            itmImg.Elements.Add(tileItemElement1);
                            itmImg.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
                            itmImg.Id = idx;
                            itmImg.ItemSize = TileItemSize.Medium;
                            itmImg.Name = "Image" + idx;
                            itmImg.AppearanceItem.Normal.ForeColor = Color.DarkGray;
                            tileGroup1.Items.Add(itmImg);

                            tileGroup1.Items[idx].BackgroundImage = await DownloadImage("http://src.powerdd.com/img/product/" + Param.Shop + "/" +
                                _PRODUCT_ROW_SELECTED["sku"].ToString() + "/" + image[i]);
                        }
                        catch
                        {

                        }
                        //tileGroup1.Items[idx].Elements[0].Text = "ภาพที่ " + idx;

                        //tileGroup1.Items.Add(GenerateAddImageItem());
                        idx++;
                    }
                }


            }
            catch
            {
                vGridControl1.DataSource = null;
                vGridControl1.Enabled = false;
            }
        }

        private async Task<Image> DownloadImage(string url)
        {
            try {
                WebRequest requestPic = WebRequest.Create(url);
                WebResponse responsePic = await requestPic.GetResponseAsync();
                //DoIndependentWork();
                return Image.FromStream(responsePic.GetResponseStream());
            }
            catch
            {
                return null;
            }
        }


        private void DoIndependentWork()
        {
            tileGroup1.Items[0].Elements[0].Text = "กำลังโหลดข้อมูล";
        }
        private TileItem GenerateAddImageItem()
        {
            TileItem itmAdd = new TileItem();
            TileItemElement tileItemElement = new TileItemElement();
            tileItemElement.Text = "เพิ่มรูปภาพ";
            tileItemElement.TextAlignment = TileItemContentAlignment.MiddleCenter;
            itmAdd.Elements.Add(tileItemElement);
            itmAdd.BackgroundImageScaleMode = TileItemImageScaleMode.Stretch;
            itmAdd.Id = 99;
            itmAdd.ItemSize = TileItemSize.Medium;
            itmAdd.Name = "AddImage";
            itmAdd.AppearanceItem.Normal.ForeColor = Color.DarkGray;
            return itmAdd;
        }



        private void navDevice_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmDevice fm = new FmDevice();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbDevice, Param.DataSet.Tables["Data-device"], "Name");
        }

        private void navMadeIn_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmMadeIn fm = new FmMadeIn();
            fm.ShowDialog(this);
            Util.SetComboboxDataSource(cbbMadeIn, Param.DataSet.Tables["Data-makerCountry"], "Name");
        }

        private void navStandard_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmStandard fm = new FmStandard();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbStandard, Param.DataSet.Tables["Data-standard"], "Name");
        }

        private void navLabel_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmLabel fm = new FmLabel();
            fm.ShowDialog(this);
            Util.SetOptionDataSource(cbbLabel, Param.DataSet.Tables["Data-label"], "Name");
        }

        #region Tile Image
        private void tileControl1_ItemCheckedChanged(object sender, TileItemEventArgs e)
        {
            //ITileItem i = (ITileItem)tileControl1.Groups[0].Items[e.Item.CurrentFrameIndex];
            //FmLabel fm = new FmLabel();
        }

        private void tileControl1_EndItemDragging(object sender, TileItemDragEventArgs e)
        {
            /*
            var count = ((TileControl)sender).Groups[0].Items.Count;
            ITileItem item;
            for (int i = 0; i < count; i++)
            {
                item = (ITileItem)((TileControl)sender).Groups[0].Items[i];
                item.Elements[0].Text = (i == 0) ? "ภาพหลัก" : "ภาพที่ " + i;
            }
            */
        }

        private void tileControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Delete))
            {
                //tileControl1.SelectedItem.Visible = false;
                //btnAdd_Click(sender, e);
            }
        }

        private void navCapacity_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmCapacity fm = new FmCapacity();
            fm.ShowDialog(this);
            Util.SetComboboxDataSource(cbbCapacity, Param.DataSet.Tables["Data-capacity"], "Name");
        }

        private void navBatteryType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            FmBatteryType fm = new FmBatteryType();
            fm.ShowDialog(this);
            Util.SetComboboxDataSource(cbbBatteryType, Param.DataSet.Tables["Data-batteryType"], "Name");
        }

        #endregion
    }
}
