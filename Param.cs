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
        public static string ShopId = "1234";
        public static string ApiUrl = "https://xxx.remaxthailand.co.th";
        public static string ApiKey = "1234";
        public static string SecretKey = "ProductInfo";
        public static string token = "";

        public static string[] thaiMonth = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"};

    }
}
