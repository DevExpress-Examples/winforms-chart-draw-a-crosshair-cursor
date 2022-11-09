using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraCharts;

namespace CustomDrawCrosshairCursor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void OnCheckEditCheckedChanged(object sender, EventArgs e) {
            if (checkEdit1.Checked)
                chartControl1.CustomDrawCrosshair += OnChartControlCustomDrawCrosshair;
            else 
                chartControl1.CustomDrawCrosshair -= OnChartControlCustomDrawCrosshair;               
        }

        private void OnChartControlCustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            // Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Color = Color.Green;
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyle.DashDot;
            e.CrosshairLineElement.LineStyle.Thickness = 3;

            // Specify the back color for the crosshair argument axis label. 
            foreach (CrosshairAxisLabelElement axisLabelElement in e.CrosshairAxisLabelElements)
                axisLabelElement.BackColor = Color.Blue;

            foreach (CrosshairElementGroup group in e.CrosshairElementGroups) {
                CrosshairGroupHeaderElement groupHeaderElement = group.HeaderElement;

                // Specify the text, text color and font for the crosshair group header element. 
                groupHeaderElement.Text = "Custom draw";
                groupHeaderElement.TextColor = Color.Green;
                groupHeaderElement.DXFont = new DXFont("SegoeUI", 12, DXFontStyle.Bold);

                // Obtain the first series.
                CrosshairElement element = group.CrosshairElements[0];

                // Specify the color, dash style and thickness for the crosshair value lines. 
                element.LineElement.Color = Color.DarkViolet;
                element.LineElement.LineStyle.DashStyle = DashStyle.Dash;
                element.LineElement.LineStyle.Thickness = 2;

                // Specify the text color and back color for the crosshair value labels.
                element.AxisLabelElement.TextColor = Color.Red;
                element.AxisLabelElement.BackColor = Color.Yellow;

                // Format the text shown for the series in the crosshair cursor label. Specify the text color and marker size. 
                element.LabelElement.TextColor = Color.Red;
                element.LabelElement.MarkerSize = new Size(15, 15);
                element.LabelElement.Text = string.Format("{0}: A={1}; V={2}", element.Series.Name, element.SeriesPoint.Argument, element.SeriesPoint.Values[0]);
            }
        }
    }
}