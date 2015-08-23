namespace PowerBackend
{
    partial class UcDataProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDataProduct));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarConfig = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.chkIsNotVisible = new DevExpress.XtraEditors.CheckEdit();
            this.chkIsNotActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.navBarProduct = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarDataType = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Active = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Visible = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Sku = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Price = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Price1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Price2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Price3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Price4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Price5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Cost = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Stock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Warranty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Category = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Brand = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PowerBackend.FmWait), true, true, typeof(System.Windows.Forms.UserControl));
            this.bwLoadCategory = new System.ComponentModel.BackgroundWorker();
            this.bwLoadProduct = new System.ComponentModel.BackgroundWorker();
            this.bwPrepareData = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsNotVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsNotActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarProduct;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarProduct,
            this.navBarDataType,
            this.navBarConfig});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem4,
            this.navBarItem5});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 217;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(217, 573);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarConfig
            // 
            this.navBarConfig.Caption = "การตั้งค่า";
            this.navBarConfig.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarConfig.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarConfig.GroupClientHeight = 80;
            this.navBarConfig.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarConfig.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarConfig.LargeImage")));
            this.navBarConfig.Name = "navBarConfig";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.chkIsNotVisible);
            this.navBarGroupControlContainer1.Controls.Add(this.chkIsNotActive);
            this.navBarGroupControlContainer1.Controls.Add(this.txtSearch);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(217, 360);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // chkIsNotVisible
            // 
            this.chkIsNotVisible.Location = new System.Drawing.Point(8, 57);
            this.chkIsNotVisible.Name = "chkIsNotVisible";
            this.chkIsNotVisible.Properties.Caption = "แสดงข้อมูลสินค้าที่ซ่อนในหน้าเว็บ";
            this.chkIsNotVisible.Size = new System.Drawing.Size(189, 19);
            this.chkIsNotVisible.TabIndex = 2;
            this.chkIsNotVisible.CheckedChanged += new System.EventHandler(this.chkIsNotActive_CheckedChanged);
            // 
            // chkIsNotActive
            // 
            this.chkIsNotActive.Location = new System.Drawing.Point(8, 32);
            this.chkIsNotActive.Name = "chkIsNotActive";
            this.chkIsNotActive.Properties.Caption = "แสดงข้อมูลสินค้าที่ยกเลิกแล้ว";
            this.chkIsNotActive.Size = new System.Drawing.Size(189, 19);
            this.chkIsNotActive.TabIndex = 1;
            this.chkIsNotActive.CheckedChanged += new System.EventHandler(this.chkIsNotActive_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Size = new System.Drawing.Size(206, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // navBarProduct
            // 
            this.navBarProduct.Caption = "หมวดหมู่สินค้า";
            this.navBarProduct.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarProduct.Expanded = true;
            this.navBarProduct.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarProduct.LargeImage")));
            this.navBarProduct.Name = "navBarProduct";
            // 
            // navBarDataType
            // 
            this.navBarDataType.Caption = "ประเภทของข้อมูล";
            this.navBarDataType.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarDataType.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarDataType.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarDataType.LargeImage")));
            this.navBarDataType.Name = "navBarDataType";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "ราคาไม่ครบทุกช่อง";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "ยกเลิกการขายแล้ว";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.SmallImage")));
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(217, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(927, 573);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.gridControl1.Location = new System.Drawing.Point(7, 7);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(607, 394);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.Sku,
            this.Name,
            this.Price,
            this.Price1,
            this.Price2,
            this.Price3,
            this.Price4,
            this.Price5,
            this.Warranty,
            this.Brand,
            this.Active,
            this.Visible,
            this.Category,
            this.Stock,
            this.Cost});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.bandedGridView1_RowClick);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "ข้อมูลทั่วไป";
            this.gridBand1.Columns.Add(this.Active);
            this.gridBand1.Columns.Add(this.Visible);
            this.gridBand1.Columns.Add(this.Sku);
            this.gridBand1.Columns.Add(this.Name);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 594;
            // 
            // Active
            // 
            this.Active.AppearanceCell.Options.UseTextOptions = true;
            this.Active.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Active.AppearanceHeader.Options.UseTextOptions = true;
            this.Active.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Active.Caption = "ขาย";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.OptionsColumn.AllowEdit = false;
            this.Active.OptionsColumn.FixedWidth = true;
            this.Active.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Active.Visible = true;
            this.Active.Width = 41;
            // 
            // Visible
            // 
            this.Visible.Caption = "แสดง";
            this.Visible.FieldName = "Visible";
            this.Visible.Name = "Visible";
            this.Visible.OptionsColumn.AllowEdit = false;
            this.Visible.OptionsColumn.FixedWidth = true;
            this.Visible.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Visible.Visible = true;
            this.Visible.Width = 40;
            // 
            // Sku
            // 
            this.Sku.AppearanceCell.Options.UseTextOptions = true;
            this.Sku.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sku.AppearanceHeader.Options.UseTextOptions = true;
            this.Sku.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sku.Caption = "SKU";
            this.Sku.FieldName = "Sku";
            this.Sku.Name = "Sku";
            this.Sku.OptionsColumn.AllowEdit = false;
            this.Sku.OptionsColumn.FixedWidth = true;
            this.Sku.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Sku.Visible = true;
            this.Sku.Width = 70;
            // 
            // Name
            // 
            this.Name.Caption = "ชื่อ";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.OptionsColumn.AllowEdit = false;
            this.Name.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Name.Visible = true;
            this.Name.Width = 443;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "ราคา";
            this.gridBand2.Columns.Add(this.Price);
            this.gridBand2.Columns.Add(this.Price1);
            this.gridBand2.Columns.Add(this.Price2);
            this.gridBand2.Columns.Add(this.Price3);
            this.gridBand2.Columns.Add(this.Price4);
            this.gridBand2.Columns.Add(this.Price5);
            this.gridBand2.Columns.Add(this.Cost);
            this.gridBand2.MinWidth = 360;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.OptionsBand.FixedWidth = true;
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 420;
            // 
            // Price
            // 
            this.Price.Caption = "ปลีก";
            this.Price.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 60;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.OptionsColumn.FixedWidth = true;
            this.Price.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price.Visible = true;
            this.Price.Width = 60;
            // 
            // Price1
            // 
            this.Price1.Caption = "ส่ง 1";
            this.Price1.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price1.FieldName = "Price1";
            this.Price1.MinWidth = 60;
            this.Price1.Name = "Price1";
            this.Price1.OptionsColumn.AllowEdit = false;
            this.Price1.OptionsColumn.FixedWidth = true;
            this.Price1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price1.Visible = true;
            this.Price1.Width = 60;
            // 
            // Price2
            // 
            this.Price2.Caption = "ส่ง 2";
            this.Price2.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price2.FieldName = "Price2";
            this.Price2.MinWidth = 60;
            this.Price2.Name = "Price2";
            this.Price2.OptionsColumn.AllowEdit = false;
            this.Price2.OptionsColumn.FixedWidth = true;
            this.Price2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price2.Visible = true;
            this.Price2.Width = 60;
            // 
            // Price3
            // 
            this.Price3.Caption = "ส่ง 3";
            this.Price3.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price3.FieldName = "Price3";
            this.Price3.MinWidth = 60;
            this.Price3.Name = "Price3";
            this.Price3.OptionsColumn.AllowEdit = false;
            this.Price3.OptionsColumn.FixedWidth = true;
            this.Price3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price3.Visible = true;
            this.Price3.Width = 60;
            // 
            // Price4
            // 
            this.Price4.Caption = "ส่ง 4";
            this.Price4.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price4.FieldName = "Price4";
            this.Price4.MinWidth = 60;
            this.Price4.Name = "Price4";
            this.Price4.OptionsColumn.AllowEdit = false;
            this.Price4.OptionsColumn.FixedWidth = true;
            this.Price4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price4.Visible = true;
            this.Price4.Width = 60;
            // 
            // Price5
            // 
            this.Price5.Caption = "ส่ง 5";
            this.Price5.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Price5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price5.FieldName = "Price5";
            this.Price5.MinWidth = 60;
            this.Price5.Name = "Price5";
            this.Price5.OptionsColumn.AllowEdit = false;
            this.Price5.OptionsColumn.FixedWidth = true;
            this.Price5.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Price5.Visible = true;
            this.Price5.Width = 60;
            // 
            // Cost
            // 
            this.Cost.Caption = "ต้นทุน";
            this.Cost.DisplayFormat.FormatString = "#,##0.00";
            this.Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.OptionsColumn.AllowEdit = false;
            this.Cost.OptionsColumn.FixedWidth = true;
            this.Cost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Cost.Visible = true;
            this.Cost.Width = 60;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "ข้อมูลอื่นๆ";
            this.gridBand3.Columns.Add(this.Stock);
            this.gridBand3.Columns.Add(this.Warranty);
            this.gridBand3.Columns.Add(this.Category);
            this.gridBand3.Columns.Add(this.Brand);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 340;
            // 
            // Stock
            // 
            this.Stock.Caption = "จำนวน";
            this.Stock.DisplayFormat.FormatString = "{0:#,###;;\'-\'}";
            this.Stock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Stock.FieldName = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.OptionsColumn.AllowEdit = false;
            this.Stock.OptionsColumn.FixedWidth = true;
            this.Stock.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Stock.Visible = true;
            this.Stock.Width = 60;
            // 
            // Warranty
            // 
            this.Warranty.AppearanceCell.Options.UseTextOptions = true;
            this.Warranty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Warranty.AppearanceHeader.Options.UseTextOptions = true;
            this.Warranty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Warranty.Caption = "ประกัน";
            this.Warranty.DisplayFormat.FormatString = "{0:#;;\'-\'}";
            this.Warranty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Warranty.FieldName = "Warranty";
            this.Warranty.MinWidth = 60;
            this.Warranty.Name = "Warranty";
            this.Warranty.OptionsColumn.AllowEdit = false;
            this.Warranty.OptionsColumn.FixedWidth = true;
            this.Warranty.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Warranty.Visible = true;
            this.Warranty.Width = 60;
            // 
            // Category
            // 
            this.Category.Caption = "หมวดหมู่สินค้า";
            this.Category.FieldName = "Category";
            this.Category.Name = "Category";
            this.Category.OptionsColumn.AllowEdit = false;
            this.Category.OptionsColumn.FixedWidth = true;
            this.Category.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Category.Visible = true;
            this.Category.Width = 120;
            // 
            // Brand
            // 
            this.Brand.Caption = "ยี่ห้อ";
            this.Brand.FieldName = "Brand";
            this.Brand.MinWidth = 100;
            this.Brand.Name = "Brand";
            this.Brand.OptionsColumn.AllowEdit = false;
            this.Brand.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Brand.Visible = true;
            this.Brand.Width = 100;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(7, 401);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(607, 165);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.propertyGridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(614, 7);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(306, 559);
            this.panelControl2.TabIndex = 0;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(2, 2);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row});
            this.propertyGridControl1.Size = new System.Drawing.Size(302, 555);
            this.propertyGridControl1.TabIndex = 0;
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.Properties.Caption = "gfyguy";
            this.row.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.row.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // bwLoadCategory
            // 
            this.bwLoadCategory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadCategory_DoWork);
            this.bwLoadCategory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadCategory_RunWorkerCompleted);
            // 
            // bwLoadProduct
            // 
            this.bwLoadProduct.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadProduct_DoWork);
            this.bwLoadProduct.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadProduct_RunWorkerCompleted);
            // 
            // bwPrepareData
            // 
            this.bwPrepareData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPrepareData_DoWork);
            this.bwPrepareData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwPrepareData_RunWorkerCompleted);
            // 
            // UcDataProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Size = new System.Drawing.Size(1144, 573);
            this.Load += new System.EventHandler(this.UcDataProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkIsNotVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsNotActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarProduct;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarDataType;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.CheckEdit chkIsNotVisible;
        private DevExpress.XtraEditors.CheckEdit chkIsNotActive;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraNavBar.NavBarGroup navBarConfig;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwLoadCategory;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Active;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Visible;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Sku;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Price5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Warranty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Brand;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Category;
        private System.ComponentModel.BackgroundWorker bwLoadProduct;
        private System.ComponentModel.BackgroundWorker bwPrepareData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Cost;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Stock;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}
