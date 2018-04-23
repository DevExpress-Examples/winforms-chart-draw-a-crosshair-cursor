// Developer Express Code Central Example:
// How to custom draw a crosshair cursor
// 
// This example shows how to provide custom appearance of the crosshair cursor
// using the ChartControl.CustomDrawCrosshair event. This event is invoked when you
// click the Custom Draw Crosshair Cursor button on the form. If you wish to
// display crosshair axis lines and labels on a chart before custom drawing the
// crosshair cursor, set the CrosshairOptions.ShowArgumentLine
// (http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowArgumentLinetopic),
// CrosshairOptions.ShowArgumentLabels
// (http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowArgumentLabelstopic),
// CrosshairOptions.ShowValueLabels
// (http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowValueLabelstopic)
// and CrosshairOptions.ShowValueLine
// (http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_ShowValueLinetopic)
// properties to true. Note that the customization of the crosshair cursor is
// provided for the CrosshairOptions.SnapMode
// (http://documentation.devexpress.com/#XtraCharts/DevExpressXtraChartsCrosshairOptions_SnapModetopic)
// property set to NearestArgument.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4307

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CustomDrawCrosshairCursor")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CustomDrawCrosshairCursor")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("f106e0ba-43be-4484-aba6-1d78de2199ca")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
