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


        public Form1()
        {
            InitializeComponent();
            data = createChart("data.txt");            
        }

        List<string> createChart(string file_name)
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
            foreach (string s in data_values) {
                Console.WriteLine("s = " + s);
                Console.WriteLine("s = " + s);
            }
            return data_values;
        }

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
    }
}
