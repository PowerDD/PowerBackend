using DevExpress.XtraEditors;
//using Gecko;

namespace PowerBackend
{
    partial class FmUploadImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch { }*/
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Hide();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            //this.geckoWebBrowser2 = new Gecko.GeckoWebBrowser();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
            this.tileItem9 = new DevExpress.XtraEditors.TileItem();
            this.tileItem10 = new DevExpress.XtraEditors.TileItem();
            this.tileItem11 = new DevExpress.XtraEditors.TileItem();
            this.tileItem12 = new DevExpress.XtraEditors.TileItem();
            this.tileItem13 = new DevExpress.XtraEditors.TileItem();
            this.tileItem14 = new DevExpress.XtraEditors.TileItem();
            this.tileItem15 = new DevExpress.XtraEditors.TileItem();
            this.tileItem16 = new DevExpress.XtraEditors.TileItem();
            this.tileItem17 = new DevExpress.XtraEditors.TileItem();
            this.tileItem18 = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            /*this.geckoWebBrowser1.Location = new System.Drawing.Point(2, -53);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(221, 475);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            this.geckoWebBrowser1.ProgressChanged += new System.EventHandler<Gecko.GeckoProgressEventArgs>(this.geckoWebBrowser1_ProgressChanged);
            // 
            // geckoWebBrowser2
            // 
            this.geckoWebBrowser2.Location = new System.Drawing.Point(8, 182);
            this.geckoWebBrowser2.Name = "geckoWebBrowser2";
            this.geckoWebBrowser2.Size = new System.Drawing.Size(180, 148);
            this.geckoWebBrowser2.TabIndex = 1;
            this.geckoWebBrowser2.UseHttpActivityObserver = false;
            this.geckoWebBrowser2.Visible = false;
            this.geckoWebBrowser2.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser2_DocumentCompleted);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.geckoWebBrowser2);
            this.panelControl1.Controls.Add(this.geckoWebBrowser1);*/
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(776, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 397);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tileControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(776, 397);
            this.panelControl2.TabIndex = 3;
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Silver;
            this.tileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileControl1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.tileControl1.ItemPadding = new System.Windows.Forms.Padding(8);
            this.tileControl1.Location = new System.Drawing.Point(2, 2);
            this.tileControl1.MaxId = 18;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tileControl1.RowCount = 3;
            this.tileControl1.Size = new System.Drawing.Size(772, 393);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            //this.tileControl1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl1_ItemClick);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Items.Add(this.tileItem4);
            this.tileGroup1.Items.Add(this.tileItem5);
            this.tileGroup1.Items.Add(this.tileItem6);
            this.tileGroup1.Items.Add(this.tileItem7);
            this.tileGroup1.Items.Add(this.tileItem8);
            this.tileGroup1.Items.Add(this.tileItem9);
            this.tileGroup1.Items.Add(this.tileItem10);
            this.tileGroup1.Items.Add(this.tileItem11);
            this.tileGroup1.Items.Add(this.tileItem12);
            this.tileGroup1.Items.Add(this.tileItem13);
            this.tileGroup1.Items.Add(this.tileItem14);
            this.tileGroup1.Items.Add(this.tileItem15);
            this.tileGroup1.Items.Add(this.tileItem16);
            this.tileGroup1.Items.Add(this.tileItem17);
            this.tileGroup1.Items.Add(this.tileItem18);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // tileItem1
            // 
            this.tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            this.tileItem2.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            this.tileItem3.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            this.tileItem4.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem4.Id = 3;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem5
            // 
            this.tileItem5.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem5.Id = 4;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileItem6
            // 
            this.tileItem6.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem6.Id = 5;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem7
            // 
            this.tileItem7.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem7.Id = 6;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileItem8
            // 
            this.tileItem8.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem8.Id = 7;
            this.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem8.Name = "tileItem8";
            // 
            // tileItem9
            // 
            this.tileItem9.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem9.Id = 8;
            this.tileItem9.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem9.Name = "tileItem9";
            // 
            // tileItem10
            // 
            this.tileItem10.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem10.Id = 9;
            this.tileItem10.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem10.Name = "tileItem10";
            // 
            // tileItem11
            // 
            this.tileItem11.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem11.Id = 10;
            this.tileItem11.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem11.Name = "tileItem11";
            // 
            // tileItem12
            // 
            this.tileItem12.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem12.Id = 11;
            this.tileItem12.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem12.Name = "tileItem12";
            // 
            // tileItem13
            // 
            this.tileItem13.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem13.Id = 12;
            this.tileItem13.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem13.Name = "tileItem13";
            // 
            // tileItem14
            // 
            this.tileItem14.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem14.Id = 13;
            this.tileItem14.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem14.Name = "tileItem14";
            // 
            // tileItem15
            // 
            this.tileItem15.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem15.Id = 14;
            this.tileItem15.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem15.Name = "tileItem15";
            // 
            // tileItem16
            // 
            this.tileItem16.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem16.Id = 15;
            this.tileItem16.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem16.Name = "tileItem16";
            // 
            // tileItem17
            // 
            this.tileItem17.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem17.Id = 16;
            this.tileItem17.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem17.Name = "tileItem17";
            // 
            // tileItem18
            // 
            this.tileItem18.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            this.tileItem18.Id = 17;
            this.tileItem18.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem18.Name = "tileItem18";
            // 
            // FmUploadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 397);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FmUploadImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmUploadImage";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmUploadImage_FormClosing);
            this.Load += new System.EventHandler(this.FmUploadImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private Gecko.GeckoWebBrowser geckoWebBrowser1;
        //private Gecko.GeckoWebBrowser geckoWebBrowser2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem8;
        private DevExpress.XtraEditors.TileItem tileItem9;
        private DevExpress.XtraEditors.TileItem tileItem10;
        private DevExpress.XtraEditors.TileItem tileItem11;
        private DevExpress.XtraEditors.TileItem tileItem12;
        private DevExpress.XtraEditors.TileItem tileItem13;
        private DevExpress.XtraEditors.TileItem tileItem14;
        private DevExpress.XtraEditors.TileItem tileItem15;
        private DevExpress.XtraEditors.TileItem tileItem16;
        private DevExpress.XtraEditors.TileItem tileItem17;
        private DevExpress.XtraEditors.TileItem tileItem18;
    }
}