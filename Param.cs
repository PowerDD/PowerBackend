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

        public static string Shop = "88888888";
        public static string ShopId = "POWERDDH-8888-8888-B620-48D3B6489999";
        public static string ApiUrl = "https://api.powerdd.com";
        public static string ApiKey = "27AD365F-FBFF-4994-BB9C-97ABAF80EFBB";

        public static string[] thaiMonth = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"};

    }
}
