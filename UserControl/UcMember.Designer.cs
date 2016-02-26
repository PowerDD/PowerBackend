namespace PowerBackend
{
    partial class UcMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMember));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarDataType = new DevExpress.XtraNavBar.NavBarGroup();
            this.navQueue = new DevExpress.XtraNavBar.NavBarItem();
            this.navWaitPack = new DevExpress.XtraNavBar.NavBarItem();
            this.navWaitShipping = new DevExpress.XtraNavBar.NavBarItem();
            this.navNoTracking = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.navCategoryMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navShippingType = new DevExpress.XtraNavBar.NavBarItem();
            this.navPriority = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(204, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(478, 422);
            this.panelControl1.TabIndex = 4;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarDataType;
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
            this.navNoTracking,
            this.navWaitShipping,
            this.navCategoryMapping});
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(204, 422);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarDataType
            // 
            this.navBarDataType.Caption = "ประเภทของข้อมูล";
            this.navBarDataType.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarDataType.Expanded = true;
            this.navBarDataType.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQueue),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navWaitPack),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navWaitShipping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNoTracking)});
            this.navBarDataType.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarDataType.LargeImage")));
            this.navBarDataType.Name = "navBarDataType";
            // 
            // navQueue
            // 
            this.navQueue.Caption = "ลูกค้าทั่วไป";
            this.navQueue.Name = "navQueue";
            this.navQueue.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQueue.SmallImage")));
            // 
            // navWaitPack
            // 
            this.navWaitPack.Caption = "ดีลเลอร์";
            this.navWaitPack.Name = "navWaitPack";
            this.navWaitPack.SmallImage = ((System.Drawing.Image)(resources.GetObject("navWaitPack.SmallImage")));
            // 
            // navWaitShipping
            // 
            this.navWaitShipping.Caption = "ตัวแทนจำหน่าย";
            this.navWaitShipping.Name = "navWaitShipping";
            this.navWaitShipping.SmallImage = ((System.Drawing.Image)(resources.GetObject("navWaitShipping.SmallImage")));
            // 
            // navNoTracking
            // 
            this.navNoTracking.Caption = "พนักงานบริษัท";
            this.navNoTracking.Name = "navNoTracking";
            this.navNoTracking.SmallImage = ((System.Drawing.Image)(resources.GetObject("navNoTracking.SmallImage")));
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "สิทธิ์การใช้งาน";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCategoryMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navShippingType),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPriority)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navCategory
            // 
            this.navCategory.Caption = "โซนการจัดสินค้า";
            this.navCategory.Name = "navCategory";
            this.navCategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCategory.SmallImage")));
            // 
            // navCategoryMapping
            // 
            this.navCategoryMapping.Caption = "แบ่งโซนหมวดหมู่สินค้า";
            this.navCategoryMapping.Name = "navCategoryMapping";
            this.navCategoryMapping.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCategoryMapping.SmallImage")));
            // 
            // navUser
            // 
            this.navUser.Caption = "ผู้รับผิดชอบ";
            this.navUser.Name = "navUser";
            this.navUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("navUser.SmallImage")));
            // 
            // navShippingType
            // 
            this.navShippingType.Caption = "ประเภทการขนส่ง";
            this.navShippingType.Name = "navShippingType";
            this.navShippingType.SmallImage = ((System.Drawing.Image)(resources.GetObject("navShippingType.SmallImage")));
            // 
            // navPriority
            // 
            this.navPriority.Caption = "ลำดับความสำคัญ";
            this.navPriority.Name = "navPriority";
            this.navPriority.SmallImage = ((System.Drawing.Image)(resources.GetObject("navPriority.SmallImage")));
            // 
            // UcMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "UcMember";
            this.Size = new System.Drawing.Size(682, 422);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarDataType;
        private DevExpress.XtraNavBar.NavBarItem navQueue;
        private DevExpress.XtraNavBar.NavBarItem navWaitPack;
        private DevExpress.XtraNavBar.NavBarItem navWaitShipping;
        private DevExpress.XtraNavBar.NavBarItem navNoTracking;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navCategory;
        private DevExpress.XtraNavBar.NavBarItem navCategoryMapping;
        private DevExpress.XtraNavBar.NavBarItem navUser;
        private DevExpress.XtraNavBar.NavBarItem navShippingType;
        private DevExpress.XtraNavBar.NavBarItem navPriority;
    }
}
