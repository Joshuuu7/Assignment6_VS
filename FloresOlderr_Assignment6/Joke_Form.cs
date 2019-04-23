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
    public partial class Joke_Form : Form
    {
        public Joke_Form()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Joke_Form joke_Form = new Joke_Form();
            form1.Show();
            this.Hide();
            joke_Form.Close();
        }

        private void Joke_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            Joke_Form joke_Form = new Joke_Form();
            form1.Show();
            this.Hide();
            joke_Form.Close();
        }

        private void NothingButton_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "Ha! You fell for it. Click the other button to exit";
        }
    }
}
