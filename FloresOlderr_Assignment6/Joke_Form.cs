/********************************************************************************
 * 
 * Programmers: Joshua Flores, Adam Olderr
 * 
 * z-IDs: 1682720, 1753651
 * 
 * Assignment Number: 6
 * 
 * Due Date: April 25th, 2019
 * 
 * Class: CSCI504
 * 
 * Instructor: Daniel Rogness
 * 
 * Teaching Assistants: Aravind Muvva, Kiranmayi Manukonda
 * 
 * *******************************************************************************/
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
        /********************************************************************************
        * 
        * Constructor: Joke_Form
        * 
        * Arguments: none
        * 
        * Purpose: Calls InitializeComponent. 
        * 
        * *******************************************************************************/
        public Joke_Form()
        {
            InitializeComponent();
        }

        /********************************************************************************
        * 
        * Method: Backbutton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Creates a new Form1 instance, initializes a new Joke_Form instance, 
        *          closes the current form, and opens the main menu (Form1).
        * 
        * *******************************************************************************/
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Joke_Form joke_Form = new Joke_Form();
            form1.Show();
            this.Hide();
            joke_Form.Close();
        }

        /********************************************************************************
        * 
        * Method: Joke_Form_FormClosed
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Creates a new Form1 instance, initializes a new Joke_Form instance, 
        *          closes the current form, and opens the main menu (Form1).
        * 
        * *******************************************************************************/
        private void Joke_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            Joke_Form joke_Form = new Joke_Form();
            form1.Show();
            this.Hide();
            joke_Form.Close();
        }

        /********************************************************************************
        * 
        * Method: NothingButton_Click
        * 
        * Arguments: object sender, EventArgs e
        * 
        * Return Type: void
        * 
        * Purpose: Giggles and/or laughter :).
        * 
        * *******************************************************************************/
        private void NothingButton_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "Ha! You fell for it. Click the other button to exit";
        }
    }
}
