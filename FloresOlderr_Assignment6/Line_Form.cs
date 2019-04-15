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
    public partial class Line_Form : Form
    {
        LineData LD;

        public Line_Form(LineData LD)
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            LD = new LineData();

            Form1 form1 = new Form1(LD);

            Line_Form line_Form = new Line_Form(LD);
            form1.Show();
            this.Hide();
            line_Form.Close();
        }
    }
}
