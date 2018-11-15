<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDrawCrosshair/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawCrosshair/Form1.vb))
<!-- default file list end -->
# How to custom draw a crosshair cursor


<p>This example shows how to provide custom appearance of the crosshair cursor using the  <strong>ChartControl.CustomDrawCrosshair </strong>event. This event is invoked when you click the <strong>Custom Draw Crosshair Cursor</strong> button on the form. </p><p>If you wish to display crosshair axis  lines and labels on a chart before custom drawing the crosshair cursor, set the <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowArgumentLinetopic"><u>CrosshairOptions.ShowArgumentLine</u></a>, <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowArgumentLabelstopic"><u>CrosshairOptions.ShowArgumentLabels</u></a>, <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowValueLabelstopic"><u>CrosshairOptions.ShowValueLabels</u></a> and <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowValueLinetopic"><u>CrosshairOptions.ShowValueLine</u></a> properties to<strong> true</strong>. </p><p>Note that the customization of the crosshair cursor is provided for the <a href="http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_SnapModetopic"><u>CrosshairOptions.SnapMode</u></a> property set to <strong>NearestArgument</strong>.</p>

<br/>


