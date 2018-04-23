using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomDrawCrosshairCursor {
    public partial class Form1 : Form {
        bool handleCustomDraw;
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            handleCustomDraw = true;
            chartControl1.CustomDrawCrosshair += chartControl1_CustomDrawCrosshair;
        }

        private void chartControl1_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            if (!handleCustomDraw) return;

            // Specify the crosshair argument line color, dash style and thickness.
            e.CrosshairLineElement.Color = Color.Green;
            e.CrosshairLineElement.LineStyle.DashStyle = DashStyle.DashDot;
            e.CrosshairLineElement.LineStyle.Thickness = 3;

            // Specify  the back color for crosshair argument label. 
            foreach (CrosshairAxisLabelElement axisLabelElement in e.CrosshairAxisLabelElements)
                axisLabelElement.BackColor = Color.Blue;

            foreach (CrosshairElement element in e.CrosshairElements) {

                // Specify the color, dash style and thickness for the crosshair value lines. 
                element.LineElement.Color = Color.DarkViolet;
                element.LineElement.LineStyle.DashStyle = DashStyle.Dash;
                element.LineElement.LineStyle.Thickness = 2;

                // Specify the  text color and back color for the crosshair value labels.
                element.AxisLabelElement.TextColor = Color.Red;
                element.AxisLabelElement.BackColor = Color.Yellow;


                // Specify the text color and marker size for the crosshair  cursor label that shows series. 
                element.LabelElement.TextColor = Color.Red;
                element.LabelElement.MarkerSize = new Size(15, 15);

            }

            foreach (CrosshairGroupHeaderElement groupHeaderElement in e.CrosshairGroupHeaderElements) {

                // Specify the text, text color and font for the crosshair group header element. 
                groupHeaderElement.Text = "Custom draw";
                groupHeaderElement.TextColor = Color.Green;
                groupHeaderElement.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
    }
}
