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

        BarData barData;
        DonutData donutData;
        LineData lineData;
        AreaData areaData;
        List<string> data = new List<string>();

        public Form1()
        {
            barData = new BarData();
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


        public Form1(DonutData DD)
        {
            donutData = DD;
            InitializeComponent();
        }

        public Form1(LineData LD)
        {
            lineData = LD;
            InitializeComponent();
        }

        public Form1(BarData BD)
        {
            barData = BD;
            InitializeComponent();
        }

        public Form1(AreaData AD)
        {
            areaData = AD;
            InitializeComponent();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Bar_Form bar_Form = new Bar_Form(barData);
            bar_Form.Show();
            this.Hide();
            form1.Close();
        }

        private void DonutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Donut_Form donut_Form = new Donut_Form(donutData);
            donut_Form.Show();
            this.Hide();
            form1.Close();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Line_Form line_Form = new Line_Form(data);
            line_Form.Show();
            this.Hide();
            form1.Close();
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Area_Form area_Form = new Area_Form(areaData);
            area_Form.Show();
            this.Hide();
            form1.Close();
        }
    }

    public class BarData
    {
        public Bar_Form bar_Form;
        public BarData()
        {

        }
    }

    public class DonutData
    {
        public Donut_Form bar_Form;
        public DonutData()
        {

        }
    }

    public class LineData
    {
        public Line_Form bar_Form;
        public LineData()
        {

        }
    }

    public class AreaData
    {
        public Area_Form bar_Form;
        public AreaData()
        {

        }
    }
}
