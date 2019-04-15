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
    public partial class Donut_Form : Form
    {
        DonutData DD;

        public Donut_Form(DonutData DD)
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            DD = new DonutData();

            Form1 form1 = new Form1(DD);

            Donut_Form donut_Form = new Donut_Form(DD);
            form1.Show();
            this.Hide();
            donut_Form.Close();
        }
    }
}
