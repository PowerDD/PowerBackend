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

namespace PowerBackend
{
    public partial class UcReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UcReport()
        {
            InitializeComponent();
        }

        private void UcReport_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UcReportMonthlyCategory();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void navHeadSale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UcReportMonthlyHeadSale();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void navSaleByCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UcReportMonthlyCategory();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }
    }
}
