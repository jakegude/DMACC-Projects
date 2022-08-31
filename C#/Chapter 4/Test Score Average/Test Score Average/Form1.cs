using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //calculate
            //try catch statement
            try
            {
                //constants
                const double HIGHSCORE = 95.0;
                //variables
                double test1, test2, test3, average;
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                //calc average
                average = (test1 + test2 + test3) / 3;
                //display
                averageLabel.Text = average.ToString("n1");
                //if the average is a high score, congradulate the user with a message box
                if (average > HIGHSCORE)
                {
                    MessageBox.Show("Congradulations! Great Job!");
                }
            }
            catch (Exception ex)
            {
                //display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear input and outputs
            test1TextBox.Text = string.Empty;
            test2TextBox.Text = string.Empty;
            test3TextBox.Text = string.Empty;
            averageLabel.Text = string.Empty;

            //focus
            test1TextBox.Focus();

        }
    }
}
