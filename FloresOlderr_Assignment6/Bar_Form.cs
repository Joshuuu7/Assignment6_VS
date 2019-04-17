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
    public partial class Bar_Form : Form
    {
        BarData BD;
        public List<string> data_values;

        public Bar_Form(BarData BD)
        {
            InitializeComponent();
        }

        public Bar_Form(List<string> data_values)
        {
            this.data_values = data_values;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            BD = new BarData();

            Form1 form1 = new Form1();

            Bar_Form bar_Form = new Bar_Form(data_values);
            form1.Show();
            this.Hide();
            bar_Form.Close();
        }

        private void Bar_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
