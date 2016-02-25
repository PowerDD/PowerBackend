namespace PowerBackend
{
    partial class UcReport
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcReport));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navSale = new DevExpress.XtraNavBar.NavBarGroup();
            this.navSaleByCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.navHeadSale = new DevExpress.XtraNavBar.NavBarItem();
            this.navSaleByCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navSale;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.navBarControl1.Appearance.Item.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navSale,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navSaleByCategory,
            this.navSaleByCustomer,
            this.navHeadSale,
            this.navBarItem4,
            this.navBarItem5});
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(204, 495);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navSale
            // 
            this.navSale.Caption = "ยอดขาย";
            this.navSale.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navSale.Expanded = true;
            this.navSale.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSaleByCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navHeadSale)});
            this.navSale.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSale.LargeImage")));
            this.navSale.Name = "navSale";
            this.navSale.SelectedLinkIndex = 0;
            // 
            // navSaleByCategory
            // 
            this.navSaleByCategory.Caption = "แยกตามหมวดหมู่";
            this.navSaleByCategory.Name = "navSaleByCategory";
            this.navSaleByCategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSaleByCategory.SmallImage")));
            this.navSaleByCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSaleByCategory_LinkClicked);
            // 
            // navHeadSale
            // 
            this.navHeadSale.Caption = "แยกตามหัวหน้าเซลล์";
            this.navHeadSale.Name = "navHeadSale";
            this.navHeadSale.SmallImage = ((System.Drawing.Image)(resources.GetObject("navHeadSale.SmallImage")));
            this.navHeadSale.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navHeadSale_LinkClicked);
            // 
            // navSaleByCustomer
            // 
            this.navSaleByCustomer.Caption = "แยกตามประเภทลูกค้า";
            this.navSaleByCustomer.Name = "navSaleByCustomer";
            this.navSaleByCustomer.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSaleByCustomer.SmallImage")));
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "จัดการข้อมูล";
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "navBarItem4";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "navBarItem5";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(204, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(733, 495);
            this.pnlMain.TabIndex = 3;
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navBarControl1);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(937, 495);
            this.Load += new System.EventHandler(this.UcReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navSale;
        private DevExpress.XtraNavBar.NavBarItem navSaleByCategory;
        private DevExpress.XtraNavBar.NavBarItem navSaleByCustomer;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navHeadSale;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraEditors.PanelControl pnlMain;
    }
}
