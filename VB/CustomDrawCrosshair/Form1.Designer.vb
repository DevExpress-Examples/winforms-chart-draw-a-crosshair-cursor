Namespace CustomDrawCrosshair

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((50R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((34R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((55R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(4R, New Object() {(CObj((77R)))})
            Dim splineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(1R, New Object() {(CObj((22R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(2R, New Object() {(CObj((11R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(3R, New Object() {(CObj((9R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(4R, New Object() {(CObj((8R)))})
            Dim splineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Dim pointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
            Dim splineSeriesView3 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.button1 = New System.Windows.Forms.Button()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((222)))))), (CInt(((CByte((57)))))), (CInt(((CByte((205)))))))
            Me.chartControl1.CrosshairOptions.ShowArgumentLabels = True
            Me.chartControl1.CrosshairOptions.ShowArgumentLine = True
            Me.chartControl1.CrosshairOptions.ShowValueLabels = True
            Me.chartControl1.CrosshairOptions.ShowValueLine = True
            Me.chartControl1.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((222)))))), (CInt(((CByte((57)))))), (CInt(((CByte((205)))))))
            xyDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            pointSeriesLabel1.LineVisible = True
            pointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointSeriesLabel1.PointOptions = pointOptions1
            series1.Label = pointSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
            series1.View = splineSeriesView1
            pointSeriesLabel2.LineVisible = True
            pointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointSeriesLabel2.PointOptions = pointOptions2
            series2.Label = pointSeriesLabel2
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series2.View = splineSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            pointSeriesLabel3.LineVisible = True
            pointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
            pointSeriesLabel3.PointOptions = pointOptions3
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel3
            Me.chartControl1.SeriesTemplate.View = splineSeriesView3
            Me.chartControl1.Size = New System.Drawing.Size(473, 316)
            Me.chartControl1.TabIndex = 0
            AddHandler Me.chartControl1.CustomDrawCrosshair, New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(AddressOf Me.chartControl1_CustomDrawCrosshair)
            ' 
            ' button1
            ' 
            Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.button1.Location = New System.Drawing.Point(0, 0)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(473, 64)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Custom Draw Crosshair Cursor"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 313)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(473, 64)
            Me.panel1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(473, 377)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private button1 As System.Windows.Forms.Button

        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace
