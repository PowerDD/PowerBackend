namespace PowerBackend
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navMaximize = new DevExpress.XtraBars.Navigation.NavButton();
            this.navMinimize = new DevExpress.XtraBars.Navigation.NavButton();
            this.navSize = new DevExpress.XtraBars.Navigation.NavButton();
            this.navExit = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavItem1 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavSubItem1 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavSubItem2 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavItem3 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.tileNavSubItem3 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceSelected.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.navMaximize);
            this.tileNavPane1.Buttons.Add(this.navMinimize);
            this.tileNavPane1.Buttons.Add(this.navSize);
            this.tileNavPane1.Buttons.Add(this.navExit);
            this.tileNavPane1.ContinuousNavigation = true;
            // 
            // tileNavCategory1
            // 
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "ข้อมูล";
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem2.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            this.tileNavItem2.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.tileNavSubItem1,
            this.tileNavSubItem2});
            this.tileNavItem2.Tag = "item-data";
            // 
            // 
            // 
            this.tileNavItem2.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "ข้อมูล";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement4);
            this.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem2.Tile.Name = "tileBarItem2";
            this.tileNavItem2.Tile.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem2.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavPane1.DefaultCategory.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem1,
            this.tileNavItem2,
            this.tileNavItem3});
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1205, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            this.tileNavPane1.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tileNavPane1_TileClick);
            // 
            // navButton2
            // 
            this.navButton2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navButton2.Caption = "เมนูหลัก";
            this.navButton2.Glyph = ((System.Drawing.Image)(resources.GetObject("navButton2.Glyph")));
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // navMaximize
            // 
            this.navMaximize.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navMaximize.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navMaximize.Caption = "";
            this.navMaximize.Glyph = ((System.Drawing.Image)(resources.GetObject("navMaximize.Glyph")));
            this.navMaximize.Name = "navMaximize";
            this.navMaximize.Visible = false;
            this.navMaximize.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navMaximize_ElementClick);
            // 
            // navMinimize
            // 
            this.navMinimize.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navMinimize.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navMinimize.Caption = "";
            this.navMinimize.Glyph = ((System.Drawing.Image)(resources.GetObject("navMinimize.Glyph")));
            this.navMinimize.Name = "navMinimize";
            this.navMinimize.Visible = false;
            this.navMinimize.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navMinimize_ElementClick);
            // 
            // navSize
            // 
            this.navSize.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navSize.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navSize.Caption = "";
            this.navSize.Glyph = ((System.Drawing.Image)(resources.GetObject("navSize.Glyph")));
            this.navSize.Name = "navSize";
            this.navSize.Visible = false;
            this.navSize.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navSize_ElementClick);
            // 
            // navExit
            // 
            this.navExit.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navExit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navExit.Caption = "ออกจากระบบ";
            this.navExit.Glyph = ((System.Drawing.Image)(resources.GetObject("navExit.Glyph")));
            this.navExit.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navExit.Name = "navExit";
            this.navExit.Visible = false;
            this.navExit.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navExit_ElementClick);
            // 
            // tileNavItem1
            // 
            this.tileNavItem1.Caption = "รายงาน";
            this.tileNavItem1.Name = "tileNavItem1";
            this.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem1.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            this.tileNavItem1.Tag = "item-report";
            // 
            // 
            // 
            this.tileNavItem1.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavItem1.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "รายงาน";
            this.tileNavItem1.Tile.Elements.Add(tileItemElement1);
            this.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem1.Tile.Name = "tileBarItem1";
            this.tileNavItem1.Tile.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem1.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileNavSubItem1
            // 
            this.tileNavSubItem1.Caption = "สินค้า";
            this.tileNavSubItem1.Name = "tileNavSubItem1";
            this.tileNavSubItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavSubItem1.Tag = "data-product";
            // 
            // 
            // 
            this.tileNavSubItem1.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavSubItem1.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavSubItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "สินค้า";
            this.tileNavSubItem1.Tile.Elements.Add(tileItemElement2);
            this.tileNavSubItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavSubItem1.Tile.Name = "tileBarItem3";
            this.tileNavSubItem1.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileNavSubItem2
            // 
            this.tileNavSubItem2.Caption = "สมาชิก";
            this.tileNavSubItem2.Name = "tileNavSubItem2";
            this.tileNavSubItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.tileNavSubItem2.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavSubItem2.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavSubItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "สมาชิก";
            this.tileNavSubItem2.Tile.Elements.Add(tileItemElement3);
            this.tileNavSubItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavSubItem2.Tile.Name = "tileBarItem2";
            this.tileNavSubItem2.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileNavItem3
            // 
            this.tileNavItem3.Caption = "ระบบ";
            this.tileNavItem3.Name = "tileNavItem3";
            this.tileNavItem3.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem3.OwnerCollection = this.tileNavPane1.DefaultCategory.Items;
            this.tileNavItem3.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.tileNavSubItem3});
            // 
            // 
            // 
            this.tileNavItem3.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "ระบบ";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileNavItem3.Tile.Elements.Add(tileItemElement6);
            this.tileNavItem3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem3.Tile.Name = "tileBarItem1";
            this.tileNavItem3.Tile.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem3.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1205, 558);
            this.pnlMain.TabIndex = 1;
            // 
            // tileNavSubItem3
            // 
            this.tileNavSubItem3.Caption = "เครม";
            this.tileNavSubItem3.Name = "tileNavSubItem3";
            this.tileNavSubItem3.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavSubItem3.Tag = "system-claim";
            // 
            // tileBarItem1
            // 
            this.tileNavSubItem3.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("DilleniaUPC", 22F, System.Drawing.FontStyle.Bold);
            this.tileNavSubItem3.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavSubItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "เครม";
            this.tileNavSubItem3.Tile.Elements.Add(tileItemElement5);
            this.tileNavSubItem3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavSubItem3.Tile.Name = "tileBarItem1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 598);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "Main";
            this.Text = "Power Backend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navExit;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem1;
        private DevExpress.XtraBars.Navigation.NavButton navMinimize;
        private DevExpress.XtraBars.Navigation.NavButton navSize;
        private DevExpress.XtraBars.Navigation.NavButton navMaximize;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem1;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem2;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem3;
    }
}

