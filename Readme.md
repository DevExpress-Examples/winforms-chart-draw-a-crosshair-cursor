<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDrawCrosshairCursor/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawCrosshairCursor/Form1.vb))
<!-- default file list end -->
# How to custom draw a crosshair cursor

This example shows how to use the [ChartControl.CustomDrawCrosshair](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawCrosshair) event to provide a custom appearance for the crosshair cursor. This event is invoked when you select the **Custom Draw Crosshair Cursor** check box.

If you wish to display crosshair axis  lines and labels on a chart before custom drawing the crosshair cursor, set the [CrosshairOptions.ShowArgumentLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowArgumentLine), [CrosshairOptions.ShowArgumentLabels](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLabels) and [CrosshairOptions.ShowValueLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLine) properties to  **true**. 

Note that the customization of the crosshair cursor is provided for the [CrosshairOptions.SnapMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.SnapMode) property set to **NearestArgument**.
