using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBackend
{
    public class Util
    {
        public static void InitialAzureStorage(string DatabaseName, string DatabasePassword)
        {
            Param.AzureStorageAccount = CloudStorageAccount.Parse(string.Format("DefaultEndpointsProtocol=http;AccountName={0};AccountKey={1}", DatabaseName, DatabasePassword));
            Param.AzureTableClient = Param.AzureStorageAccount.CreateCloudTableClient();
        }
    }
}
