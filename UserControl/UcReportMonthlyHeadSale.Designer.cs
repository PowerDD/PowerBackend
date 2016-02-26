namespace PowerBackend
{
    partial class UcReportMonthlyHeadSale
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("aaa", new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("bbb", new object[] {
            ((object)(4.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("ccc", new object[] {
            ((object)(7.7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("ddd", new object[] {
            ((object)(1.6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("eee", new object[] {
            ((object)(8.9D))});
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("aaa", new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("bbb", new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("ccc", new object[] {
            ((object)(7.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("ddd", new object[] {
            ((object)(3.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("eee", new object[] {
            ((object)(7.9D))});
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("aaa", new object[] {
            ((object)(1.2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("bbb", new object[] {
            ((object)(7.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint13 = new DevExpress.XtraCharts.SeriesPoint("ccc", new object[] {
            ((object)(2.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint14 = new DevExpress.XtraCharts.SeriesPoint("ddd", new object[] {
            ((object)(6.9D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint15 = new DevExpress.XtraCharts.SeriesPoint("eee", new object[] {
            ((object)(3.7D))});
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcReportMonthlyHeadSale));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbbDataType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbCategory = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.cbbBackward = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PowerBackend.FmWait), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBackward.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 30);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "มกรา";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5});
            series2.Name = "กุมภา";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10});
            series3.Name = "มีนา";
            series3.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint11,
            seriesPoint12,
            seriesPoint13,
            seriesPoint14,
            seriesPoint15});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartControl1.Size = new System.Drawing.Size(1140, 467);
            this.chartControl1.TabIndex = 2;
            chartTitle1.Font = new System.Drawing.Font("DilleniaUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "กราฟแสดง";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl1.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.cbbDataType);
            this.panelControl1.Controls.Add(this.cbbCategory);
            this.panelControl1.Controls.Add(this.lblTime);
            this.panelControl1.Controls.Add(this.cbbBackward);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1140, 30);
            this.panelControl1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(636, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "ค้นหาข้อมูล";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbDataType
            // 
            this.cbbDataType.EditValue = "ยอดขาย";
            this.cbbDataType.Location = new System.Drawing.Point(211, 0);
            this.cbbDataType.Name = "cbbDataType";
            this.cbbDataType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cbbDataType.Properties.Appearance.Options.UseFont = true;
            this.cbbDataType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDataType.Properties.Items.AddRange(new object[] {
            "ยอดขาย",
            "จำนวนชิ้น",
            "กำไร",
            "ต้นทุนเฉลี่ยต่อชิ้น",
            "ราคาขายเฉลี่ยต่อชิ้น",
            "กำไรเฉลี่ยต่อชิ้น"});
            this.cbbDataType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbDataType.Size = new System.Drawing.Size(130, 22);
            this.cbbDataType.TabIndex = 9;
            // 
            // cbbCategory
            // 
            this.cbbCategory.EditValue = "";
            this.cbbCategory.Location = new System.Drawing.Point(369, 0);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cbbCategory.Properties.Appearance.Options.UseFont = true;
            this.cbbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbCategory.Properties.SelectAllItemCaption = "ทุกหมวดหมู่";
            this.cbbCategory.Size = new System.Drawing.Size(260, 22);
            this.cbbCategory.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblTime.Location = new System.Drawing.Point(3, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "เดือน";
            // 
            // cbbBackward
            // 
            this.cbbBackward.EditValue = "3";
            this.cbbBackward.Location = new System.Drawing.Point(37, 0);
            this.cbbBackward.Name = "cbbBackward";
            this.cbbBackward.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cbbBackward.Properties.Appearance.Options.UseFont = true;
            this.cbbBackward.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbBackward.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbBackward.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbBackward.Size = new System.Drawing.Size(44, 22);
            this.cbbBackward.TabIndex = 3;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // UcReportMonthlyHeadSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcReportMonthlyHeadSale";
            this.Size = new System.Drawing.Size(1140, 497);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBackward.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cbbDataType;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbbCategory;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.ComboBoxEdit cbbBackward;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}
