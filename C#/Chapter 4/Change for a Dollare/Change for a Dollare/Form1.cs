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
//change for a dollar
namespace Change_for_a_Dollare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears inputs and outputs
            qTextbox.Text = string.Empty;
            dTextbox.Text = string.Empty;
            nTextbox.Text = string.Empty;
            pTextbox.Text = string.Empty;
            resultLabel.Text = string.Empty;

            //focus
            qTextbox.Focus();

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //determines whether the inputted coins are greater than,
            //less than, or equal to a dollar

            try
            {
                //variables
                double total = double.Parse(qTextbox.Text) * 0.25 +
                    double.Parse(dTextbox.Text) * 0.1 +
                    double.Parse(nTextbox.Text) * 0.05 +
                    double.Parse(pTextbox.Text) * 0.01;

                if (total == 1)
                {
                    resultLabel.Text = "Congradulations! You Won!";
                }
                else if (total < 1)
                {
                    resultLabel.Text = "Haha you lost! The amount entered was less than a dollar!";
                }
                else
                {
                    resultLabel.Text = "Haha you lost! The amount entered was more than a dollar!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Fucked UP!");
            }
        }
    }
}
