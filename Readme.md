<!-- default badges list -->

![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574151/22.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4307)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Chart for WinForms - How to Custom Draw a Crosshair Cursor

This example shows how to use the [ChartControl.CustomDrawCrosshair](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawCrosshair) event to create a custom appearance for the crosshair cursor. This event is invoked when you select the **Custom Draw Crosshair Cursor** check box.

![Chart](images/chart.png)

If you wish to display crosshair axis lines and labels on a chart before custom drawing the crosshair cursor, set the [CrosshairOptions.ShowArgumentLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowArgumentLine), [CrosshairOptions.ShowArgumentLabels](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLabels), and [CrosshairOptions.ShowValueLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLine) properties to  `true`. 

## Files to Review

[Form1.cs](./CS/CustomDrawCrosshairCursor/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawCrosshairCursor/Form1.vb))

## Documentation 

[Crosshair Cursor](https://docs.devexpress.com/WindowsForms/14710/controls-and-libraries/chart-control/end-user-features/tooltip-and-crosshair-cursor/crosshair-cursor?p=netframework)
