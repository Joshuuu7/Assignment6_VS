/********************************************************************************
 * 
 * Programmers: Joshua Flores, Adam Olderr
 * 
 * z-IDs: 1682720, 1753651
 * 
 * Assignment Number: 6
 * 
 * Due Date: April 25th, 2019
 * 
 * Class: CSCI504
 * 
 * Instructor: Daniel Rogness
 * 
 * Teaching Assistants: Aravind Muvva, Kiranmayi Manukonda
 * 
 * *******************************************************************************/

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

        /********************************************************************************
        * 
        * Constructor: Bar_Form
        * 
        * Arguments: List<string> data_values_2017
        * 
        * Purpose: Creates and initializes an Area_Form object with a List of string. 
        * 
        * *******************************************************************************/
        public Bar_Form(List<string> data_values_2017)
        {
            this.data_values_2017 = data_values_2017;
            InitializeComponent();
        }

        /********************************************************************************
        * 
        * Method: Backbutton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Creates a new Form1 instance, initializes a new Bar_Form instance, 
        *          closes the current form, and opens the main menu (Form1).
        * 
        * *******************************************************************************/
        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Bar_Form bar_Form = new Bar_Form(data_values_2017);
            form1.Show();
            this.Hide();
            bar_Form.Close();
        }

        /********************************************************************************
        * 
        * Method: Bar_Form_Load
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Initalizes the List of double with the passed in the form, converts the
        *          list to string, and uses data as input for chart. X-axis display also
        *          depends on the count of elements. Chart formats labels, axes, and
        *          colors accordinlgy and differently by color.
        * 
        * *******************************************************************************/
        private void Bar_Form_Load(object sender, EventArgs e)
        {
            Bar_Chart.Series.Clear();

            List<double> double_data_2017 = new List<double>();
            List<string> time_string = new List<string>();
            double seconds = 0;
            string time = "";

            double string_to_number_2017 = 0;

            foreach (string data in data_values_2017)
            {
                string_to_number_2017 = Convert.ToDouble(data);
                double_data_2017.Add(string_to_number_2017);
                seconds = Convert.ToInt32(Convert.ToDouble(data));
                time = TimeDisplay(seconds);
                time_string.Add(time);
            }

            foreach (string time_iteration in time_string)
            {
                Console.WriteLine(time_iteration);
            }

            Title Line_Chart_Title = new Title("Bike Share Statistics (2017)" + Environment.NewLine + "(Amount rented per month in seconds)", Docking.Top, new Font("Yu Gothic", 8, FontStyle.Bold), Color.Black);

            Bar_Chart.Titles.Add(Line_Chart_Title);

            var series_2017 = new Series("Bike Share 2017");

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December"};

            series_2017.ChartType = SeriesChartType.Bar;

            // Frist parameter is X-Axis and Second is Collection of Y- Axis. Values added to graph. 

            series_2017.Points.DataBindXY(months, data_values_2017);
            series_2017.IsValueShownAsLabel = true;
            string [] format_string_label = new string[12];
            string format_string = "";
            string mins_secs = "";
            for (int i = 0; i < time_string.Count(); i++)
            {
                format_string_label[i] = time_string[i];
                format_string =  "Total (seconds) = " + "{ #,0.# }" + " Mins : Secs = " + format_string_label[i];
                mins_secs = " Mins : Secs = " + format_string_label[i];
                //Bar_Chart.ChartAreas[0].AxisX.CustomLabels.Add(format_string);
                CustomLabel label = new CustomLabel( 0, 0, mins_secs, 0,LabelMarkStyle.None);
                Bar_Chart.ChartAreas[i].AxisX.CustomLabels.Add(label);

                //series_2017.LabelFormat = format_string;
            }

            //series_2017.LabelFormat = "{ #,0.# }";

            series_2017.LabelForeColor = Color.Firebrick;
            //series_2017.Font = new Font(base.Font, FontStyle.Bold);

            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.Maximum = months.Count();
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -45;
            Bar_Chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;

            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Minimum = 2500; //lowest - 100;
            Bar_Chart.ChartAreas["ChartArea1"].AxisY.Maximum = 4500; //highest + 100;            

            series_2017["PointWidth"] = ".5";
            series_2017.Color = System.Drawing.Color.BlueViolet;

            Bar_Chart.Series.Add(series_2017);
        }

        /********************************************************************************
        * 
        * Method: Bar_Form_MouseMove
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Takes the mouse coordinates and generates a tooltip with just the 
        *          data hovered on.
        * 
        * *******************************************************************************/
        private void Bar_Graph_MouseMove(object sender, MouseEventArgs e)
        {
            DataPoint point = new DataPoint();
            point.SetValueXY(e.X, e.Y);

            for (int n = 0; n < 12; n++)
            {
                Bar_Chart.Series[0].Points[n].ToolTip = "#VALX : " + string.Format("{0: #,0}", "#VALY");
            }
        }

        /********************************************************************************
        * 
        * Method: BarForm_Closed
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Creates a new Form1 instance, initializes a new Bar_Form instance, 
        *          closes the current form, and opens the main menu (Form1).
        * 
        * *******************************************************************************/
        private void BarForm_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            Bar_Form bar_Form = new Bar_Form(data_values_2017);
            form1.Show();
            this.Hide();
            bar_Form.Close();
        }

        int[] MinutesAndSeconds(double seconds)
        {
            return new int[] { Convert.ToInt32(seconds / 60), Convert.ToInt32(seconds % 60) };
        }

        string TimeDisplay(double seconds)
        {
            int[] minutesAndSeconds = MinutesAndSeconds(seconds);
            return minutesAndSeconds[0] + ":" + minutesAndSeconds[1];
        }
    }
}
