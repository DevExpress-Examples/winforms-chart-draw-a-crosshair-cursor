Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomDrawCrosshairCursor

    Public Partial Class Form1
        Inherits Form

        Private handleCustomDraw As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            handleCustomDraw = True
            AddHandler chartControl1.CustomDrawCrosshair, AddressOf chartControl1_CustomDrawCrosshair
        End Sub

        Private Sub chartControl1_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            If Not handleCustomDraw Then Return
            ' Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Color = Color.Green
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyle.DashDot
            e.CrosshairLineElement.LineStyle.Thickness = 3
            ' Specify  the back color for crosshair argument label. 
            For Each axisLabelElement As CrosshairAxisLabelElement In e.CrosshairAxisLabelElements
                axisLabelElement.BackColor = Color.Blue
            Next

            For Each group As CrosshairElementGroup In e.CrosshairElementGroups
                Dim element As CrosshairElement = group.CrosshairElements(0)
                ' Specify the color, dash style and thickness for the crosshair value lines. 
                element.LineElement.Color = Color.DarkViolet
                element.LineElement.LineStyle.DashStyle = DashStyle.Dash
                element.LineElement.LineStyle.Thickness = 2
                ' Specify the  text color and back color for the crosshair value labels.
                element.AxisLabelElement.TextColor = Color.Red
                element.AxisLabelElement.BackColor = Color.Yellow
                ' Specify the text color and marker size for the crosshair  cursor label that shows series. 
                element.LabelElement.TextColor = Color.Red
                element.LabelElement.MarkerSize = New Size(15, 15)
            Next

            For Each group As CrosshairElementGroup In e.CrosshairElementGroups
                Dim groupHeaderElement As CrosshairGroupHeaderElement = group.HeaderElement
                ' Specify the text, text color and font for the crosshair group header element. 
                groupHeaderElement.Text = "Custom draw"
                groupHeaderElement.TextColor = Color.Green
                groupHeaderElement.Font = New Font(Font, FontStyle.Bold)
            Next
        End Sub
    End Class
End Namespace
