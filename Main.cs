using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBackend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
        }

        private void navExit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Dispose();
        }

        private void tileNavPane1_Click(object sender, EventArgs e)
        {

        }

        private void tileNavPane1_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Console.WriteLine(e.Element.Tag);
            //e.Element.Tag
        }
    }
}
