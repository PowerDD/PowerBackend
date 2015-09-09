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

        //blic static CloudStorageAccount AzureStorageAccount;
        //blic static CloudTableClient AzureTableClient;
        //public static CloudTable AzureTable;

        public static DataTable DataTableProduct;
        public static DataSet DataSet;

        public static string Shop = "xxx";
        public static string ShopId = "yyy";
        public static string ApiUrl = "zzz";
        public static string ApiKey = "aaa";



    }
}
