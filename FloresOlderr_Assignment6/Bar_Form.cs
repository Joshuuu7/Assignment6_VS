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

        public Bar_Form(BarData BD)
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            BD = new BarData();

            Form1 form1 = new Form1(BD);

            Bar_Form bar_Form = new Bar_Form(BD);
            form1.Show();
            this.Hide();
            bar_Form.Close();
        }
    }
}
