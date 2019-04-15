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

        public Area_Form(AreaData AD)
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            AD = new AreaData();

            Form1 form1 = new Form1(AD);

            Area_Form area_Form = new Area_Form(AD);
            form1.Show();
            this.Hide();
            area_Form.Close();
        }
    }
}
