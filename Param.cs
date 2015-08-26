using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBackend
{
    public class Param
    {
        public enum AzureDataType { String, Boolean, Binary, Double, Int };
        //public static String

        public static CloudStorageAccount AzureStorageAccount;
        public static CloudTableClient AzureTableClient;
        //public static CloudTable AzureTable;

        public static DataTable DataTableProduct;
        public static DataSet DataSet;

        public static string ShopId = "88888888";



    }
}
