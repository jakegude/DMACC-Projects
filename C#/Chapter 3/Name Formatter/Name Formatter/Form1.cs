using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//jake gudenkauf
//name formatter
//1-24-2017

namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputLabel.Text =
            titleTextbox.Text + " " + firstTextbox.Text + " " + middleTextbox.Text + " " + lastTextbox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears inputs
            titleTextbox.Text = string.Empty;
            firstTextbox.Text = string.Empty;
            middleTextbox.Text = string.Empty;
            lastTextbox.Text = string.Empty;
            outputLabel.Text = string.Empty;

            //set focus
            titleTextbox.Focus();
        }
    }
}
