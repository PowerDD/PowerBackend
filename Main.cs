using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBackend
{
    public partial class Main : Form
    {
        enum Screen { Product, Claim, StockMonitor, Report, Member };
        XtraUserControl _USER_CONTROL;
        UcDataProduct _UC_PRODUCT;
        UcClaim _UC_CLAIM;
        UcStockMonitor _UC_STOCK_MONITOR;
        UcReport _UC_REPORT;
        UcMember _UC_MEMBER;


        public Main()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void navExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Dispose();
        }

        private void tileNavPane1_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (e.Element.Tag != null)
            {
                if (e.Element.Tag.ToString() == "data-product")
                {
                    AddPanel(Screen.Product);
                }
                else if (e.Element.Tag.ToString() == "data-member")
                {
                    AddPanel(Screen.Member);
                }
                else if (e.Element.Tag.ToString() == "system-claim")
                {
                    AddPanel(Screen.Claim);
                }
                else if (e.Element.Tag.ToString() == "system-stock-monitor")
                {
                    AddPanel(Screen.StockMonitor);
                }
                else if (e.Element.Tag.ToString() == "item-report")
                {
                    AddPanel(Screen.Report);
                }
            }
        }

        private void navMinimize_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navSize_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void navMaximize_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        #region Internal Method
        private void AddPanel(Screen screen)
        {
            switch (screen)
            {
                case Screen.Product:
                    if (_UC_PRODUCT == null) _UC_PRODUCT = new UcDataProduct();
                    _USER_CONTROL = _UC_PRODUCT;
                    break;
                case Screen.Claim:
                    if (_UC_CLAIM == null) _UC_CLAIM = new UcClaim();
                    _USER_CONTROL = _UC_CLAIM;
                    break;
                case Screen.StockMonitor:
                    if (_UC_STOCK_MONITOR == null) _UC_STOCK_MONITOR = new UcStockMonitor();
                    _USER_CONTROL = _UC_STOCK_MONITOR;
                    break;
                case Screen.Report:
                    if (_UC_REPORT == null) _UC_REPORT = new UcReport();
                    _USER_CONTROL = _UC_REPORT;
                    break;
                case Screen.Member:
                    if (_UC_MEMBER == null) _UC_MEMBER = new UcMember();
                    _USER_CONTROL = _UC_MEMBER;
                    break;
            }

            if (!pnlMain.Contains(_USER_CONTROL))
            {
                pnlMain.Controls.Clear();
                _USER_CONTROL.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(_USER_CONTROL);
            }
        }
        #endregion
    }
}
