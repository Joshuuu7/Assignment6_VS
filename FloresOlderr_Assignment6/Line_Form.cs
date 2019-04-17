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
    public partial class Line_Form : Form
    {
        LineData LD;
        public List<string> data_values_2014;
        public List<string> data_values_2015;
        public List<string> data_values_2016;
        public List<string> data_values_2017;

        enum Month { January, February, March, April, May, June, July, August, September, October, November, December };

        public Line_Form(LineData LD)
        {
            InitializeComponent();
        }

        public Line_Form(List<string> data_values_2014, List<string> data_values_2015, List<string> data_values_2016, List<string> data_values_2017)
        {
            this.data_values_2014 = data_values_2014;
            this.data_values_2015 = data_values_2015;
            this.data_values_2016 = data_values_2016;
            this.data_values_2017 = data_values_2017;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();

            Line_Form line_Form = new Line_Form(data_values_2014, data_values_2015, data_values_2016, data_values_2017);
            form1.Show();
            this.Hide();
            line_Form.Close();
        }

        private void Line_Form_Load(object sender, EventArgs e)
        {
            Line_Graph.Series.Clear();

            List<double> double_data_2014 = new List<double>();
            List<double> double_data_2015 = new List<double>();
            List<double> double_data_2016 = new List<double>();
            List<double> double_data_2017 = new List<double>();

            double string_to_number_2014 = 0;
            double string_to_number_2015 = 0;
            double string_to_number_2016 = 0;
            double string_to_number_2017 = 0;

            foreach (string data in data_values_2014)
            {
                string_to_number_2014 = Convert.ToDouble(data);
                double_data_2014.Add(string_to_number_2014);
            }
            foreach (string data in data_values_2015)
            {
                string_to_number_2015 = Convert.ToDouble(data);
                double_data_2015.Add(string_to_number_2015);
            }
            foreach (string data in data_values_2016)
            {
                string_to_number_2016 = Convert.ToDouble(data);
                double_data_2016.Add(string_to_number_2016);
            }
            foreach (string data in data_values_2017)
            {
                string_to_number_2017 = Convert.ToDouble(data);
                double_data_2017.Add(string_to_number_2017);
            }

            //double lowest = double_data.Min();
            //double highest = double_data.Max();

            Title Line_Chart_Title = new Title("Bike Share Statistics (2014 - 2017)" + Environment.NewLine + "(Amount rented per month)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            Line_Graph.Titles.Add(Line_Chart_Title);

            //for(int i = 0; i < 48; i++)
            //{
            //    if( i < 12 )
            //    {
            //        data_values_2014.Add(data_values.ElementAt(i));
            //    }
            //    else if ( i >= 12 && i < 24)
            //    {
            //        data_values_2015.Add(data_values.ElementAt(i));
            //    }
            //    else if (i >= 24 && i < 36)
            //    {
            //        data_values_2016.Add(data_values.ElementAt(i));
            //    }
            //    else
            //    {
            //        data_values_2017.Add(data_values.ElementAt(i));
            //    }
            //}      
            
            //double lowest_value = Convert.ToDouble(data_values.Min(x => x.Min()));
            //double highest_value = Convert.ToDouble(data_values.Max(x => x.Max()));

            var series_2014 = new Series("Bike Share 2014");
            var series_2015 = new Series("Bike Share 2015");
            var series_2016 = new Series("Bike Share 2016");
            var series_2017 = new Series("Bike Share 2017");

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"};

            series_2014.ChartType = SeriesChartType.Line;
            series_2015.ChartType = SeriesChartType.Line;
            series_2016.ChartType = SeriesChartType.Line;
            series_2017.ChartType = SeriesChartType.Line;

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            // Add values to the graph
            series_2014.Points.DataBindXY( months, data_values_2014 );
            series_2015.Points.DataBindXY( months, data_values_2015 );
            series_2016.Points.DataBindXY( months, data_values_2016 );
            series_2017.Points.DataBindXY( months, data_values_2017 );

            foreach (var point in series_2014.Points)
            {
                point.ToolTip = "(" + months + ", " + point.YValues[0] + ")";
            }
            //series_2014.Font = this.GetFontForSeries();
            //series_2014.LabelForeColor = this.GetLabelColor();

            series_2014.Points.DataBindXY(months, data_values_2014);
            series_2014.IsValueShownAsLabel = true;
            series_2014.LabelFormat = "{ #,0 }";
            series_2014.LabelForeColor = Color.Green;

            series_2015.Points.DataBindXY(months, data_values_2015);
            series_2015.IsValueShownAsLabel = true;
            series_2015.LabelFormat = "{ #,0 }";
            series_2015.LabelForeColor = Color.Indigo;

            series_2016.Points.DataBindXY(months, data_values_2016);
            series_2016.IsValueShownAsLabel = true;
            series_2016.LabelFormat = "{ #,0 }";
            series_2016.LabelForeColor = Color.Bisque;

            series_2017.Points.DataBindXY(months, data_values_2017);
            series_2017.IsValueShownAsLabel = true;
            series_2017.LabelFormat = "{ #,0 }";
            series_2017.LabelForeColor = Color.BlueViolet;

            Line_Graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Line_Graph.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            Line_Graph.ChartAreas["ChartArea1"].AxisX.Maximum = months.Count();
            Line_Graph.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -45;

            Line_Graph.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
            Line_Graph.ChartAreas["ChartArea1"].AxisY.Minimum = 2500; //lowest - 100;
            Line_Graph.ChartAreas["ChartArea1"].AxisY.Maximum = 4500; //highest + 100;            

            series_2014.Color = System.Drawing.Color.Green;
            series_2015.Color = System.Drawing.Color.Indigo;
            series_2016.Color = System.Drawing.Color.Bisque;
            series_2017.Color = System.Drawing.Color.BlueViolet;

            Line_Graph.Series.Add(series_2014);
            Line_Graph.Series.Add(series_2015);
            Line_Graph.Series.Add(series_2016);
            Line_Graph.Series.Add(series_2017);

            //chart1.Series[0].Points[0].Color = Color.Green;
        }
    }
}
