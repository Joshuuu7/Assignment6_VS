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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloresOlderr_Assignment6
{
    public partial class Form1 : Form
    {
        List<string> data = new List<string>();
        List<string> time_separated_data = new List<string>();

        /********************************************************************************
        * 
        * Constructor: Form1
        * 
        * Arguments: none
        * 
        * Purpose: Calls the functions to read the data from a file. 
        * 
        * *******************************************************************************/
        public Form1()
        {
            InitializeComponent();
            data = CreateChart("data.txt");
        }

        /********************************************************************************
        * 
        * Method: CreateChart
        * 
        * Arguments: string file_name
        * 
        * Return Type: List<string>
        * 
        * Purpose: Reads the data from the file and stores it in a List of string. 
        * 
        * *******************************************************************************/
        List<string> CreateChart(string file_name)
        {
            List<string> data_values = new List<string>();
            using (StreamReader input = new StreamReader(file_name))
            {
                char r;
                string number = "";
                string digits = "0123456789.";
                StringBuilder wordBuilder = new StringBuilder();
                while (!input.EndOfStream)
                {
                    r = (char)input.Read();
                    if (r == ',')
                    {
                        number = wordBuilder.ToString();
                        data_values.Add(number);
                        wordBuilder = new StringBuilder();
                    }
                    else if (digits.IndexOf(r) >= 0)
                    {
                        wordBuilder.Append(r);
                    }
                }
                number = wordBuilder.ToString();
                data_values.Add(number);
            }
            return data_values;
        }

        /********************************************************************************
        * 
        * Method: BarButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Reads only a subset of the data, passes it to a new form, closes Form1,
        *          and opens a new form. 
        * 
        * *******************************************************************************/
        private void BarButton_Click(object sender, EventArgs e)
        {
            List<string> data_values_2017 = new List<string>();

            for (int i = 0; i < 48; i++)
            {
                if (i >= 36 && i < 48)
                {
                    data_values_2017.Add(data.ElementAt(i));
                }
            }

            Form1 form1 = new Form1();
            Bar_Form bar_Form = new Bar_Form(data_values_2017);
            bar_Form.Show();
            this.Hide();
            form1.Close();
        }

        /********************************************************************************
        * 
        * Method: DonutButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Reads only a subset of the data, passes it to a new form, closes Form1,
        *          and opens a new form. 
        * 
        * *******************************************************************************/
        private void DonutButton_Click(object sender, EventArgs e)
        {
            List<string> data_values_2017 = new List<string>();

            for (int i = 0; i < 48; i++)
            {
                if (i >= 36 && i < 48)
                {
                    data_values_2017.Add(data.ElementAt(i));
                }
            }

            Form1 form1 = new Form1();
            Donut_Form donut_Form = new Donut_Form(data_values_2017);
            donut_Form.Show();
            this.Hide();
            form1.Close();
        }

        /********************************************************************************
        * 
        * Method: LineButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Reads the entire set of data from the file, passes it to a new form, 
        *          closes Form1, and opens a new form. 
        * 
        * *******************************************************************************/
        private void LineButton_Click(object sender, EventArgs e)
        {
            List<string> data_values_2014 = new List<string>();
            List<string> data_values_2015 = new List<string>();
            List<string> data_values_2016 = new List<string>();
            List<string> data_values_2017 = new List<string>();

            for (int i = 0; i <= data.Count - 1; i++)
            {
                if (i < 12)
                {
                    data_values_2014.Add(data.ElementAt(i));
                }
                else if (i >= 12 && i < 24)
                {
                    data_values_2015.Add(data.ElementAt(i));
                }
                else if (i >= 24 && i < 36)
                {
                    data_values_2016.Add(data.ElementAt(i));
                }
                else
                {
                    data_values_2017.Add(data.ElementAt(i));
                }
            }

            Form1 form1 = new Form1();
            Line_Form line_Form = new Line_Form(data_values_2014, data_values_2015, data_values_2016, data_values_2017);
            line_Form.Show();
            this.Hide();
            form1.Close();
        }

        /********************************************************************************
        * 
        * Method: AreaButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Reads only a subset of the data, passes it to a new form, closes Form1,
        *          and opens a new form. 
        * 
        * *******************************************************************************/
        private void AreaButton_Click(object sender, EventArgs e)
        {
            List<string> data_values_2017 = new List<string>();

            for (int i = 0; i < 48; i++)
            {
                if (i >= 36 && i < 48)
                {
                    data_values_2017.Add(data.ElementAt(i));
                }
            }
            Form1 form1 = new Form1();
            Area_Form area_Form = new Area_Form(data_values_2017);
            area_Form.Show();
            this.Hide();
            form1.Close();
        }

        /********************************************************************************
        * 
        * Method: ExitButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Exits the main menu (Form1) and stops program execution. 
        * 
        * *******************************************************************************/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Close();
            Environment.Exit(0);
        }

        /********************************************************************************
        * 
        * Method: Form1_Closed
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Exits the main menu (Form1) and stops program execution. 
        * 
        * *******************************************************************************/
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Close();
            Environment.Exit(0);
        }

        /********************************************************************************
        * 
        * Method: JokeButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: To hopefully put a smile on the T.A.'s face :). 
        * 
        * *******************************************************************************/
        private void JokeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Joke_Form joke_Form = new Joke_Form();
            joke_Form.Show();
            this.Hide();
            form1.Close();
        }
    }
}
