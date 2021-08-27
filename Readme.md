<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574151/19.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4307)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDrawCrosshairCursor/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawCrosshairCursor/Form1.vb))
<!-- default file list end -->
# How to custom draw a crosshair cursor

This example shows how to use the [ChartControl.CustomDrawCrosshair](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawCrosshair) event to provide a custom appearance for the crosshair cursor. This event is invoked when you select the **Custom Draw Crosshair Cursor** check box.

If you wish to display crosshair axis  lines and labels on a chart before custom drawing the crosshair cursor, set the [CrosshairOptions.ShowArgumentLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowArgumentLine), [CrosshairOptions.ShowArgumentLabels](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLabels) and [CrosshairOptions.ShowValueLine](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.ShowValueLine) properties to  **true**. 

Note that the customization of the crosshair cursor is provided for the [CrosshairOptions.SnapMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.CrosshairOptions.SnapMode) property set to **NearestArgument**.
