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
    public partial class Area_Form : Form
    {
        AreaData AD;
        public List<string> data_values;

        public Area_Form(AreaData AD)
        {
            InitializeComponent();
        }

        public Area_Form(List<string> data_values)
        {
            this.data_values = data_values;
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            Area_Form area_Form = new Area_Form(data_values);
            form1.Show();
            this.Hide();
            area_Form.Close();
        }

        private void Area_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
