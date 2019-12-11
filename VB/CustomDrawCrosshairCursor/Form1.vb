Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomDrawCrosshairCursor
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnCheckEditCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			If checkEdit1.Checked Then
				AddHandler chartControl1.CustomDrawCrosshair, AddressOf OnChartControlCustomDrawCrosshair
			Else
				RemoveHandler chartControl1.CustomDrawCrosshair, AddressOf OnChartControlCustomDrawCrosshair
			End If
		End Sub

		Private Sub OnChartControlCustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
			' Specify the crosshair argument line color, dash style and thickness.
			e.CrosshairLineElement.Color = Color.Green
			e.CrosshairLineElement.LineStyle.DashStyle = DashStyle.DashDot
			e.CrosshairLineElement.LineStyle.Thickness = 3

			' Specify the back color for the crosshair argument axis label. 
			For Each axisLabelElement As CrosshairAxisLabelElement In e.CrosshairAxisLabelElements
				axisLabelElement.BackColor = Color.Blue
			Next axisLabelElement

			For Each group As CrosshairElementGroup In e.CrosshairElementGroups
				Dim groupHeaderElement As CrosshairGroupHeaderElement = group.HeaderElement

				' Specify the text, text color and font for the crosshair group header element. 
				groupHeaderElement.Text = "Custom draw"
				groupHeaderElement.TextColor = Color.Green
				groupHeaderElement.Font = New Font(Me.Font, FontStyle.Bold)

				' Obtain the first series.
				Dim element As CrosshairElement = group.CrosshairElements(0)

				' Specify the color, dash style and thickness for the crosshair value lines. 
				element.LineElement.Color = Color.DarkViolet
				element.LineElement.LineStyle.DashStyle = DashStyle.Dash
				element.LineElement.LineStyle.Thickness = 2

				' Specify the text color and back color for the crosshair value labels.
				element.AxisLabelElement.TextColor = Color.Red
				element.AxisLabelElement.BackColor = Color.Yellow

				' Format the text shown for the series in the crosshair cursor label. Specify the text color and marker size. 
				element.LabelElement.TextColor = Color.Red
				element.LabelElement.MarkerSize = New Size(15, 15)
				element.LabelElement.Text = String.Format("{0}: A={1}; V={2}", element.Series.Name, element.SeriesPoint.Argument, element.SeriesPoint.Values(0))
			Next group
		End Sub
	End Class
End Namespace