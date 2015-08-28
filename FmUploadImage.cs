using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gecko;
using System.IO;
using System.Net;

namespace PowerBackend
{
    public partial class FmUploadImage : DevExpress.XtraEditors.XtraForm
    {
        public string imageURL = string.Empty;
        public FmUploadImage()
        {
            Xpcom.Initialize(@"D:\Github\PowerDD\PowerBackend\bin\Debug\xulrunner"); // Directory.GetCurrentDirectory()+@"\xulrunner");
            InitializeComponent();
        }

        private void FmUploadImage_Load(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://photos.google.com/");
        }

        private void FmUploadImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*geckoWebBrowser1.Dispose();
            geckoWebBrowser1 = null;
            Xpcom.Shutdown();*/

            this.Hide();
            e.Cancel = true;
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if(e.Uri.AbsoluteUri.IndexOf("google.com/photos/about") != -1)
            {
                geckoWebBrowser1.Navigate("https://photos.google.com/login");
            }
            else if (e.Uri.AbsoluteUri.IndexOf("accounts.google.com/ServiceLogin") != -1)
            {
                var input = (Gecko.DOM.GeckoInputElement)geckoWebBrowser1.Document.GetElementById("Email");
                input.Value = "powerddshop@gmail.com";
                input = (Gecko.DOM.GeckoInputElement)geckoWebBrowser1.Document.GetElementById("Passwd");
                input.Value = "P@ssw0rd@Power";
                var button = (Gecko.DOM.GeckoInputElement)geckoWebBrowser1.Document.GetElementById("signIn");
                button.Click();
            }
            else if (e.Uri.AbsoluteUri == "https://photos.google.com/")
            {
                /*GeckoNodeCollection nod = geckoWebBrowser1.Document.GetElementsByClassName("SmZ4Wd");
                foreach (GeckoNode node in nod)
                {
                    if (NodeType.Element == node.NodeType)
                    {
                        GeckoHtmlElement ele = (GeckoHtmlElement)node;
                        ele.SetAttribute("style", "display: none");
                    }
                }*/

                geckoWebBrowser2.Navigate("https://photos.google.com/search/_tra_");
            }
            Console.WriteLine(e.Uri.AbsoluteUri);
        }

        private void geckoWebBrowser1_ProgressChanged(object sender, GeckoProgressEventArgs e)
        {
            /*var input = geckoWebBrowser1.Document.GetElementsByTagName("span");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].InnerHtml == "ดูรูปภาพ") // .GetAttribute("aria -label") == "ปิดข้อความโต้ตอบ")
                {*/
            //_ACTION = "Upload Finished";

            if (geckoWebBrowser1.Document.Body.InnerHtml.IndexOf("transform: translateX(100%)") != -1)
            {

                geckoWebBrowser1.Navigate("https://photos.google.com/");
                geckoWebBrowser2.Navigate("https://photos.google.com/search/_tra_");
            }
                    //search/_tra_ //transform: translateX(100%);
               /* }
            }*/
        }

        private void geckoWebBrowser2_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (e.Uri.AbsoluteUri == "https://photos.google.com/search/_tra_")
            {
                var html = geckoWebBrowser2.Document.Body.InnerHtml.Split(new string[] { "data:function(){return" }, StringSplitOptions.RemoveEmptyEntries)[1];

                string[] sp = html.Split(new string[] { "[\"" }, StringSplitOptions.RemoveEmptyEntries);
                var index = 0;
                List<string> track = new List<string>();
                for (int i = 0; i < sp.Length && index < 18; i++)
                {
                    string[] sp2 = sp[i].Split('"');
                    if (sp2[0].IndexOf("googleusercontent") != -1)
                    {
                        WebRequest requestPic = WebRequest.Create(sp2[0]);
                        WebResponse responsePic = requestPic.GetResponse();

                        tileGroup1.Items[index].BackgroundImage = Image.FromStream(responsePic.GetResponseStream());
                        tileGroup1.Items[index].Text = sp2[0];
                        //((PictureBox)this.Controls.Find("pictureBox" + index, true)[0]).ImageLocation = sp2[0];
                        index++;
                        Console.WriteLine(sp2[0]);
                        //pictureBox1.ImageLocation = sp2[0];
                        //Console.WriteLine(sp2[0]);
                    }
                }
                /*var html = geckoWebBrowser1.Document.Body.InnerHtml.Split(new string[] { "data-media-key=\"" + _MEDIA_KEY + "\"data-url=" }, StringSplitOptions.RemoveEmptyEntries)[1].Split('"')[0];
                Console.WriteLine(html+"=w1000");
                pictureBox15.ImageLocation = html + "=w1000";
                lblImage.Text = html + "=w1000";*/
            }
            Console.WriteLine(e.Uri.AbsoluteUri);
        }

        private void tileControl1_ItemClick(object sender, TileItemEventArgs e)
        {
            imageURL = ((TileControl)sender).SelectedItem.Text;
            this.DialogResult = DialogResult.OK;
            //Console.WriteLine( ((TileControl)sender).SelectedItem.Text );
        }
    }
}