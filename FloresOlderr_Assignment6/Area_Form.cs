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
    public partial class Area_Form : Form
    {
        public List<string> data_values_2017;

        public Area_Form(List<string> data_values_2017)
        {
            this.data_values_2017 = data_values_2017;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            Area_Form area_Form = new Area_Form(data_values_2017);
            form1.Show();
            this.Hide();
            area_Form.Close();
        }

        private void Area_Form_Load(object sender, EventArgs e)
        {
            Area_Chart.Series.Clear();

            List<double> double_data_2017 = new List<double>();

            double string_to_number_2017 = 0;

            foreach (string data in data_values_2017)
            {
                string_to_number_2017 = Convert.ToDouble(data);
                double_data_2017.Add(string_to_number_2017);
            }

            Title Area_Chart_Title = new Title("Bike Share Statistics (2014 - 2017)" + Environment.NewLine + "(Amount rented per month)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            Area_Chart.Titles.Add(Area_Chart_Title);

            var series_2017 = new Series("Bike Share 2017");

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"};

            series_2017.ChartType = SeriesChartType.Area;

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            // Add values to the graph
            series_2017.Points.DataBindXY(months, data_values_2017);

            series_2017.Points.DataBindXY(months, data_values_2017);
            series_2017.IsValueShownAsLabel = true;
            series_2017.LabelFormat = "{ #,0 }";
            series_2017.LabelForeColor = Color.BlueViolet;

            Area_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Area_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            Area_Chart.ChartAreas["ChartArea1"].AxisX.Maximum = months.Count();
            Area_Chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -45;

            Area_Chart.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
            Area_Chart.ChartAreas["ChartArea1"].AxisY.Minimum = 2500; //lowest - 100;
            Area_Chart.ChartAreas["ChartArea1"].AxisY.Maximum = 4500; //highest + 100;            

            series_2017.Color = System.Drawing.Color.Aquamarine;

            Area_Chart.Series.Add(series_2017);
        }
    }
}
