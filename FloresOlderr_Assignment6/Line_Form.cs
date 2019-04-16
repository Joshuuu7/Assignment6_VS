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
            var series14 = new Series("Bike Share 2014");
            var series15 = new Series("Bike Share 2015");
            string[] months = { "Jan", "Feb", "March", "April", "May", "June",
                                 "July", "Sep", "Oct", "Nov", "Dec"};
            series14.ChartType = SeriesChartType.Line;
            series15.ChartType = SeriesChartType.Line;
            // Frist parameter is X-Axis and Second is Collection of Y- Axis

            //foreach(string data in data_values)
            //{
            //    series.Points.DataBindXY(new<List>  data );
            //}
            //series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
            series14.Points.DataBindXY(
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 
                new[] { 3224, 3546.2, 2872.5, 3188, 3212.8, 3205.7, 3124.2, 3160.7, 3400.1, 3490, 3373, 3328 }
                );

            series15.Points.DataBindXY(
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                new[] { 2891.6, 2798.8, 3266, 3681, 3582, 3328.2, 3487, 3579, 3791, 4234, 3910, 4175 });



            chart1.Series.Add(series14);
            chart1.Series.Add(series15);
        }
    }
}
