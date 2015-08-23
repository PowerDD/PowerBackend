using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBackend
{
    public class Param
    {
        //public static String

        public static CloudStorageAccount AzureStorageAccount;
        public static CloudTableClient AzureTableClient;
        public static CloudTable AzureTable;

    }
}
