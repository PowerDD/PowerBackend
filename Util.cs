using DevExpress.XtraEditors.Repository;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Collections.Generic;
using System.Data;
using System;
using System.Drawing;

namespace PowerBackend
{
    public class Util
    {
        public static void InitialAzureStorage(string DatabaseName, string DatabasePassword)
        {
            Param.AzureStorageAccount = CloudStorageAccount.Parse(string.Format("DefaultEndpointsProtocol=http;AccountName={0};AccountKey={1}", DatabaseName, DatabasePassword));
            Param.AzureTableClient = Param.AzureStorageAccount.CreateCloudTableClient();
        }

        public static object UpdateData(string table, string partitionKey, string rowKey, string key, string value, Param.AzureDataType type)
        {
            DynamicTableEntity data = new DynamicTableEntity()
            {
                PartitionKey = partitionKey,
                RowKey = rowKey,
                ETag = "*",
            };

            Dictionary<string, EntityProperty> properties = new Dictionary<string, EntityProperty>();
            if (type == Param.AzureDataType.Int) properties.Add(key, new EntityProperty(int.Parse(value.ToString())));
            else if (type == Param.AzureDataType.Double) properties.Add(key, new EntityProperty(double.Parse(value.ToString())));
            else if (type == Param.AzureDataType.Boolean) properties.Add(key, new EntityProperty(value.ToString() == "1"));
            else if (type == Param.AzureDataType.String) properties.Add(key, new EntityProperty(value.ToString()));
            data.Properties = properties;

            var azureTable = Param.AzureTableClient.GetTableReference(table);
            TableOperation updateOperation = TableOperation.Merge(data);
            azureTable.Execute(updateOperation);

            return data.Properties[key];
        }

        public static void SetProductStructure()
        {
            Param.DataTableProduct = new DataTable();
            Param.DataTableProduct.Columns.Add("ID", typeof(string));
            Param.DataTableProduct.Columns.Add("Sku", typeof(string));
            Param.DataTableProduct.Columns.Add("AdviceCode", typeof(string));
            Param.DataTableProduct.Columns.Add("TrueCode", typeof(string));
            Param.DataTableProduct.Columns.Add("Name", typeof(string));
            Param.DataTableProduct.Columns.Add("Price", typeof(double));
            Param.DataTableProduct.Columns.Add("Price1", typeof(double));
            Param.DataTableProduct.Columns.Add("Price2", typeof(double));
            Param.DataTableProduct.Columns.Add("Price3", typeof(double));
            Param.DataTableProduct.Columns.Add("Price4", typeof(double));
            Param.DataTableProduct.Columns.Add("Price5", typeof(double));
            Param.DataTableProduct.Columns.Add("Cost", typeof(double));
            Param.DataTableProduct.Columns.Add("Stock", typeof(int));
            Param.DataTableProduct.Columns.Add("Active", typeof(bool));
            Param.DataTableProduct.Columns.Add("Visible", typeof(bool));
            Param.DataTableProduct.Columns.Add("BrandId", typeof(string));
            Param.DataTableProduct.Columns.Add("Brand", typeof(string));
            Param.DataTableProduct.Columns.Add("CategoryId", typeof(string));
            Param.DataTableProduct.Columns.Add("Category", typeof(string));
            Param.DataTableProduct.Columns.Add("Warranty", typeof(int));
            Param.DataTableProduct.Columns.Add("Material", typeof(string));
            Param.DataTableProduct.Columns.Add("Model", typeof(string));
            Param.DataTableProduct.Columns.Add("Detail", typeof(string));
            Param.DataTableProduct.Columns.Add("SpecialProperties", typeof(string));
            Param.DataTableProduct.Columns.Add("MadeIn", typeof(string));
            Param.DataTableProduct.Columns.Add("Color", typeof(int));
            Param.DataTableProduct.Columns.Add("DeviceSupport", typeof(string));
            Param.DataTableProduct.Columns.Add("Width", typeof(double));
            Param.DataTableProduct.Columns.Add("Length", typeof(double));
            Param.DataTableProduct.Columns.Add("Height", typeof(double));
            Param.DataTableProduct.Columns.Add("Weight", typeof(double));
            Param.DataTableProduct.Columns.Add("GrossWeight", typeof(double));
            Param.DataTableProduct.Columns.Add("CoverImage", typeof(string));
            Param.DataTableProduct.Columns.Add("hasCoverImage", typeof(Image));
            Param.DataTableProduct.Columns.Add("Image1", typeof(string));
            Param.DataTableProduct.Columns.Add("Image2", typeof(string));
            Param.DataTableProduct.Columns.Add("Image3", typeof(string));
            Param.DataTableProduct.Columns.Add("Image4", typeof(string));
            Param.DataTableProduct.Columns.Add("Image5", typeof(string));
            Param.DataTableProduct.Columns.Add("Image6", typeof(string));
            Param.DataTableProduct.Columns.Add("Image7", typeof(string));
            Param.DataTableProduct.Columns.Add("Image8", typeof(string));
            Param.DataTableProduct.Columns.Add("Image9", typeof(string));
            Param.DataTableProduct.Columns.Add("Image10", typeof(string));
            Param.DataTableProduct.Columns.Add("Label", typeof(string));
            Param.DataTableProduct.Columns.Add("IsPromotion", typeof(bool));
            Param.DataTableProduct.Columns.Add("PricePromotion", typeof(double));
            Param.DataTableProduct.Columns.Add("ChargeType", typeof(string));
            Param.DataTableProduct.Columns.Add("HowToUse", typeof(string));
            Param.DataTableProduct.Columns.Add("Standard", typeof(string));
            Param.DataTableProduct.Columns.Add("InBox", typeof(string));
        }

        public static void SetOptionDataSource(RepositoryItemCheckedComboBoxEdit control, DataTable table, string columnName)
        {
            table = Sort(table, columnName, "ASC");
            control.Items.Clear();
            for(int i=0; i<table.Rows.Count; i++)
            {
                control.Items.Add(table.Rows[i][columnName].ToString());
            }
        }

        public static void SetComboboxDataSource(RepositoryItemComboBox control, DataTable table, string columnName)
        {
            table = Sort(table, columnName, "ASC");
            control.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                control.Items.Add(table.Rows[i][columnName].ToString());
            }
        }

        public static DataTable Sort(DataTable dt, string colName, string direction)
        {
            dt.DefaultView.Sort = colName + " " + direction;
            dt = dt.DefaultView.ToTable();
            return dt;
        }
    }
}
