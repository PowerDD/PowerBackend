using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace PowerBackend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Tahoma", 9.5f);
            Util.InitialAzureStorage("powerdb", "dHM08Ey1KkbH+zhLZpr7on32ueMq9WkB0n+hGZ1VKcMBoRhTLbn42LioQP25HKdThVHliK/A6ytSQ5jZPoUO3g==");
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
            string drive = "C";
            ManagementObject dsk = new ManagementObject(
                @"win32_logicaldisk.deviceid=""" + drive + @":""");
            dsk.Get();
            string volumeSerial = dsk["VolumeSerialNumber"].ToString();
        }

        private void navExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Dispose();
        }

        private void tileNavPane1_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (e.Element.Tag.ToString()  == "data-product")
            {
                pnlMain.Controls.Clear();
                UcDataProduct uc = new UcDataProduct();
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);

            }
            //e.Element.Tag
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
    }
}
