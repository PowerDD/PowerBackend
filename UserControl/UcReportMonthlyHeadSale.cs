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
using DevExpress.XtraCharts;
using Newtonsoft.Json;
using System.Collections;

namespace PowerBackend
{
    public partial class UcReportMonthlyHeadSale : DevExpress.XtraEditors.XtraUserControl
    {
        Series[] _SERIES;
        dynamic _JSON;

        public UcReportMonthlyHeadSale()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            LoadData(9, 15);
        }
        private async void LoadData(int month, int year)
        {
            _JSON = JsonConvert.DeserializeObject(await Util.ApiProcessAsync("/teamwork/report/headsale-monthly",
                "month=" + ((month < 10) ? "0" + month : "" + month) + "&year=" + year
                + "&month=" + month));
            RenderData(month, year, true);
        }

        private void RenderData(int month, int year, bool firstLoad)
        {
            chartControl1.Titles[0].Text = "กราฟแสดงยอดขายรายเดือน";
            Param.DataSet = new DataSet();
            DataTable data = new DataTable();

            if ((bool)_JSON.success)
            {
                data = new DataTable();
                data.Columns.Add("Name", typeof(string));
                data.Columns.Add("Pay", typeof(double));
                data.Columns.Add("NotPay", typeof(double));
                data.PrimaryKey = new DataColumn[] { data.Columns["Name"] };
                data.TableName = "Data-headSale";

                Hashtable hash = new Hashtable();
                var idx = 0;
                var cnt = _JSON.result.Count;
                for (int i = 0; i < cnt; i++)
                {
                    if (!data.Rows.Contains(_JSON.result[i].headSale.ToString()))
                    {
                        var val = _JSON.result[i].headSale.ToString();
                        data.Rows.Add(val, 0, 0);
                        hash.Add(val, idx++);
                    }
                    var column = (bool)_JSON.result[i].isPay ? "Pay" : "NotPay";
                    var current = data.Rows[hash[_JSON.result[i].headSale.ToString()]][column];
                    data.Rows[hash[_JSON.result[i].headSale.ToString()]][column] = current+(int)_JSON.result[i].totalPrice;
                }

                SideBySideBarSeriesView sideBySideBarSeriesView = new SideBySideBarSeriesView();
                sideBySideBarSeriesView.BarWidth = 10D;

                _SERIES = new Series[idx];
                for (int i = 0; i < idx; i++)
                {
                    _SERIES[i] = new Series();
                    _SERIES[i].Name = data.Rows[i]["Name"].ToString() == "" ? " " : data.Rows[i]["Name"].ToString();
                    _SERIES[i].Points.Clear();
                    SeriesPoint seriesPoint = new SeriesPoint(_SERIES[i].Name, (double)data.Rows[i]["Pay"]);
                    _SERIES[i].Points.Add(seriesPoint);
                    _SERIES[i].View = sideBySideBarSeriesView;
                    //_SERIES[i].CrosshairLabelPattern = "{V:#,#}";
                }

                chartControl1.SeriesSerializable = _SERIES;
                chartControl1.Visible = true;

            }
            else
            {
                chartControl1.Visible = false;
            }

            if (splashScreenManager.IsSplashFormVisible)
                splashScreenManager.CloseWaitForm();
        }

    }
}
