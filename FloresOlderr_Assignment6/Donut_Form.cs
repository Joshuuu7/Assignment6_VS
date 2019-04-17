using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FloresOlderr_Assignment6
{
    public partial class Donut_Form : Form
    {
        public List<string> data_values_2017;

        public Donut_Form(List<string> data_values_2017)
        {
            this.data_values_2017 = data_values_2017;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            Donut_Form donut_Form = new Donut_Form(data_values_2017);
            form1.Show();
            this.Hide();
            donut_Form.Close();
        }

        private void Donut_Form_Load(object sender, EventArgs e)
        {
            Donut_Chart.Series.Clear();

            List<double> double_data_2017 = new List<double>();
            double string_to_number = 0;

            Title Donut_Chart_Title = new Title("Bike Share Statistics (2017)" + Environment.NewLine + "(Amount rented per month)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            Donut_Chart.Titles.Add(Donut_Chart_Title);

            foreach (string data in data_values_2017)
            {
                string_to_number = Convert.ToDouble(data);
                double_data_2017.Add(string_to_number);
            }

            var series_2017 = new Series("Bike Share 2017");

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"};

            series_2017.ChartType = SeriesChartType.Doughnut;

            series_2017.Points.DataBindXY(months, double_data_2017);
            series_2017.IsValueShownAsLabel = true;
            series_2017.LabelFormat = "{ #,0 }";
            series_2017.LabelForeColor = Color.White;         

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            series_2017.Points[0].Color = System.Drawing.Color.Orange;
            series_2017.Points[1].Color = System.Drawing.Color.Green;
            series_2017.Points[2].Color = System.Drawing.Color.SpringGreen;
            series_2017.Points[3].Color = System.Drawing.Color.Maroon;
            series_2017.Points[4].Color = System.Drawing.Color.Gold;
            series_2017.Points[5].Color = System.Drawing.Color.Gray;
            series_2017.Points[6].Color = System.Drawing.Color.Moccasin;
            series_2017.Points[7].Color = System.Drawing.Color.Indigo;
            series_2017.Points[8].Color = System.Drawing.Color.HotPink;
            series_2017.Points[9].Color = System.Drawing.Color.Olive;
            series_2017.Points[10].Color = System.Drawing.Color.Red;
            series_2017.Points[11].Color = System.Drawing.Color.Turquoise;

            Donut_Chart.Series.Add(series_2017);
        }

        private void Donut_Chart_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = Donut_Chart.HitTest(e.X, e.Y);
            System.Drawing.Point p = new System.Drawing.Point(e.X, e.Y);

            Donut_Chart.ChartAreas[0].CursorX.Interval = 0;
            Donut_Chart.ChartAreas[0].CursorX.SetCursorPixelPosition(p, true);
            Donut_Chart.ChartAreas[0].CursorY.SetCursorPixelPosition(p, true);

            for (int n = 0; n < 12; n++)
            {
                Donut_Chart.Series[0].Points[n].ToolTip = "#VALX : " + string.Format("{0: #,0}", "#VALY");
            }
        }
    }
}
