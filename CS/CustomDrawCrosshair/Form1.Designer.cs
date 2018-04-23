namespace CustomDrawCrosshair {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(50D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(34D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(55D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(77D))});
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions2 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(22D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(11D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(9D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions3 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            this.chartControl1.CrosshairOptions.ShowArgumentLabels = true;
            this.chartControl1.CrosshairOptions.ShowArgumentLine = true;
            this.chartControl1.CrosshairOptions.ShowValueLabels = true;
            this.chartControl1.CrosshairOptions.ShowValueLine = true;
            this.chartControl1.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            xyDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisible = true;
            pointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel1.PointOptions = pointOptions1;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4});
            series1.View = splineSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            pointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel2.PointOptions = pointOptions2;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            series2.View = splineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            pointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel3.PointOptions = pointOptions3;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel3;
            this.chartControl1.SeriesTemplate.View = splineSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(473, 316);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.chartControl1_CustomDrawCrosshair);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Custom Draw Crosshair Cursor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 64);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(473, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

