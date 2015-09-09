using DevExpress.XtraEditors.Repository;
using System.Collections.Generic;
using System.Data;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Text;

namespace PowerBackend
{
    public class Util
    {

        public static string GetApiData(string method, string parameter)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.Encoding = System.Text.Encoding.UTF8;
                return wc.UploadString(new Uri(Param.ApiUrl + method), parameter + "&apiKey=" + Param.ApiKey);
            }
        }
        public static async Task<string> UpdateApiData(string method, string parameter)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                wc.Encoding = System.Text.Encoding.UTF8;
                var html = await wc.UploadStringTaskAsync(new Uri(Param.ApiUrl + method), parameter + "&apiKey=" + Param.ApiKey);
                return html;
            }
        }

        public static string DataTableToString(DataTable dataTable, string columnName)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                sb.Append(((sb.ToString() == "") ? "" : ",") + dataTable.Rows[i][columnName].ToString());
            }
            return sb.ToString();
        }

        public static void DataTableDeleteRow(DataTable dataTable, string columnName, string key)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][columnName].ToString() == key)
                {
                    dataTable.Rows[i].Delete();
                    i--;
                }
            }
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
