namespace PowerBackend
{
    partial class UcStockMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStockMonitor));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.navUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navShippingType = new DevExpress.XtraNavBar.NavBarItem();
            this.navPriority = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDataType = new DevExpress.XtraNavBar.NavBarGroup();
            this.navQueue = new DevExpress.XtraNavBar.NavBarItem();
            this.navWaitPack = new DevExpress.XtraNavBar.NavBarItem();
            this.navWaitShipping = new DevExpress.XtraNavBar.NavBarItem();
            this.navNoTracking = new DevExpress.XtraNavBar.NavBarItem();
            this.navWaitConfirm = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.navBarControl1.Appearance.Item.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarDataType,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navQueue,
            this.navWaitPack,
            this.navUser,
            this.navShippingType,
            this.navPriority,
            this.navCategory,
            this.navWaitConfirm,
            this.navNoTracking,
            this.navWaitShipping});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(204, 495);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "จัดการข้อมูล";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navShippingType),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPriority)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navCategory
            // 
            this.navCategory.Caption = "หมวดหมู่การจัดสินค้า";
            this.navCategory.Name = "navCategory";
            this.navCategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCategory.SmallImage")));
            this.navCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCategory_LinkClicked);
            // 
            // navUser
            // 
            this.navUser.Caption = "ผู้รับผิดชอบ";
            this.navUser.Name = "navUser";
            this.navUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("navUser.SmallImage")));
            this.navUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navUser_LinkClicked);
            // 
            // navShippingType
            // 
            this.navShippingType.Caption = "ประเภทการขนส่ง";
            this.navShippingType.Name = "navShippingType";
            this.navShippingType.SmallImage = ((System.Drawing.Image)(resources.GetObject("navShippingType.SmallImage")));
            this.navShippingType.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navShippingType_LinkClicked);
            // 
            // navPriority
            // 
            this.navPriority.Caption = "ลำดับความสำคัญ";
            this.navPriority.Name = "navPriority";
            this.navPriority.SmallImage = ((System.Drawing.Image)(resources.GetObject("navPriority.SmallImage")));
            this.navPriority.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navPriority_LinkClicked);
            // 
            // navBarDataType
            // 
            this.navBarDataType.Caption = "ประเภทของข้อมูล";
            this.navBarDataType.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarDataType.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQueue),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navWaitPack),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navWaitShipping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNoTracking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navWaitConfirm)});
            this.navBarDataType.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarDataType.LargeImage")));
            this.navBarDataType.Name = "navBarDataType";
            // 
            // navQueue
            // 
            this.navQueue.Caption = "คิวการจัดสินค้า";
            this.navQueue.Name = "navQueue";
            this.navQueue.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQueue.SmallImage")));
            // 
            // navWaitPack
            // 
            this.navWaitPack.Caption = "รอบรรจุลงกล่อง";
            this.navWaitPack.Name = "navWaitPack";
            this.navWaitPack.SmallImage = ((System.Drawing.Image)(resources.GetObject("navWaitPack.SmallImage")));
            // 
            // navWaitShipping
            // 
            this.navWaitShipping.Caption = "รอจัดส่งสินค้า";
            this.navWaitShipping.Name = "navWaitShipping";
            this.navWaitShipping.SmallImage = ((System.Drawing.Image)(resources.GetObject("navWaitShipping.SmallImage")));
            // 
            // navNoTracking
            // 
            this.navNoTracking.Caption = "ยังไม่มีเลขที่การจัดส่ง";
            this.navNoTracking.Name = "navNoTracking";
            this.navNoTracking.SmallImage = ((System.Drawing.Image)(resources.GetObject("navNoTracking.SmallImage")));
            // 
            // navWaitConfirm
            // 
            this.navWaitConfirm.Caption = "รอยืนยันคำสั่งซื้อ";
            this.navWaitConfirm.Name = "navWaitConfirm";
            this.navWaitConfirm.SmallImage = ((System.Drawing.Image)(resources.GetObject("navWaitConfirm.SmallImage")));
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(204, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(876, 495);
            this.panelControl1.TabIndex = 2;
            // 
            // UcStockMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "UcStockMonitor";
            this.Size = new System.Drawing.Size(1080, 495);
            this.Load += new System.EventHandler(this.UcStockMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarDataType;
        private DevExpress.XtraNavBar.NavBarItem navQueue;
        private DevExpress.XtraNavBar.NavBarItem navWaitPack;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navCategory;
        private DevExpress.XtraNavBar.NavBarItem navUser;
        private DevExpress.XtraNavBar.NavBarItem navShippingType;
        private DevExpress.XtraNavBar.NavBarItem navPriority;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarItem navWaitShipping;
        private DevExpress.XtraNavBar.NavBarItem navNoTracking;
        private DevExpress.XtraNavBar.NavBarItem navWaitConfirm;
    }
}
