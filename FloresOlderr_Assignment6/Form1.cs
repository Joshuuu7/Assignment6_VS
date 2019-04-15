using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            barData = new BarData();
            InitializeComponent();
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
            Line_Form line_Form = new Line_Form(lineData);
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
