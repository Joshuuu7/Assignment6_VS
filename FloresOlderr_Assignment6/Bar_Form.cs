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
    public partial class Bar_Form : Form
    {
        public List<string> data_values_2017;

        public Bar_Form(List<string> data_values_2017)
        {
            this.data_values_2017 = data_values_2017;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            Bar_Form bar_Form = new Bar_Form(data_values_2017);
            form1.Show();
            this.Hide();
            bar_Form.Close();
        }

        private void Bar_Form_Load(object sender, EventArgs e)
        {
            Bar_Chart.Series.Clear();

            List<double> double_data_2017 = new List<double>();

            double string_to_number_2017 = 0;

            foreach (string data in data_values_2017)
            {
                string_to_number_2017 = Convert.ToDouble(data);
                double_data_2017.Add(string_to_number_2017);
            }

            //double lowest = double_data.Min();
            //double highest = double_data.Max();
            //double lowest_value = Convert.ToDouble(data_values.Min(x => x.Min()));
            //double highest_value = Convert.ToDouble(data_values.Max(x => x.Max()));

            Title Line_Chart_Title = new Title("Bike Share Statistics (2014 - 2017)" + Environment.NewLine + "(Amount rented per month)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            Bar_Chart.Titles.Add(Line_Chart_Title);

            var series_2017 = new Series("Bike Share 2017");

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"};

            series_2017.ChartType = SeriesChartType.Bar;

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            // Add values to the graph
            series_2017.Points.DataBindXY(months, data_values_2017);

            series_2017.Points.DataBindXY(months, data_values_2017);
            series_2017.IsValueShownAsLabel = true;
            series_2017.LabelFormat = "{ #,0 }";
            series_2017.LabelForeColor = Color.BlueViolet;

            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Maximum = months.Count();
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -45;

            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Minimum = 2500; //lowest - 100;
            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Maximum = 4500; //highest + 100;            

            series_2017.Color = System.Drawing.Color.BlueViolet;

            Bar_Chart.Series.Add(series_2017);
        }
    }
}
