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
        public List<string> data_values;
        enum Month { January, February, March, April, May, June, July, August, September, October, November, December };

        public Line_Form(LineData LD)
        {
            InitializeComponent();
        }

        public Line_Form(List<string> data_values)
        {
            this.data_values = data_values;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1(LD);

            Line_Form line_Form = new Line_Form(LD);
            form1.Show();
            this.Hide();
            line_Form.Close();
        }

        private void Line_Form_Load(object sender, EventArgs e)
        {
            List<string> data_values_2014 = new List<string>();
            List<string> data_values_2015 = new List<string>();
            List<string> data_values_2016 = new List<string>();
            List<string> data_values_2017 = new List<string>();

            Title Line_Chart_Title = new Title("Bike Share Statistics" + Environment.NewLine + "(Amount rented per month)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            chart1.Titles.Add(Line_Chart_Title);

            for(int i = 0; i < 48; i++)
            {
                if( i < 12 )
                {
                    data_values_2014.Add(data_values.ElementAt(i));
                }
                else if ( i >= 12 && i < 24)
                {
                    data_values_2015.Add(data_values.ElementAt(i));
                }
                else if (i >= 24 && i < 36)
                {
                    data_values_2016.Add(data_values.ElementAt(i));
                }
                else
                {
                    data_values_2017.Add(data_values.ElementAt(i));
                }
            }
           

            var series14 = new Series("Bike Share 2014");
            var series15 = new Series("Bike Share 2015");
            var series16 = new Series("Bike Share 2016");
            var series17 = new Series("Bike Share 2017");

            string[] months = { "Jan", "Feb", "March", "April", "May", "June",
                                 "July", "Sep", "Oct", "Nov", "Dec"};

            int[] month_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            series14.ChartType = SeriesChartType.Line;
            series15.ChartType = SeriesChartType.Line;
            series16.ChartType = SeriesChartType.Line;
            series17.ChartType = SeriesChartType.Line;

            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            series14.Points.DataBindXY( month_numbers, data_values_2014 );
            series15.Points.DataBindXY( month_numbers, data_values_2015 );
            series16.Points.DataBindXY( month_numbers, data_values_2016 );
            series17.Points.DataBindXY( month_numbers, data_values_2017 );

            chart1.Series.Add(series14);
            chart1.Series.Add(series15);
            chart1.Series.Add(series16);
            chart1.Series.Add(series17);
        }
    }
}
