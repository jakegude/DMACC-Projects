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
//BMI Calculator
//1-25-2017
namespace BMI
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
            weightTextbox.Text = string.Empty;
            heightTexbox.Text = string.Empty;
            bmiLabel.Text = string.Empty;

            //set focus
            weightTextbox.Focus();

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates users BMI based on inputted weight and height
            //variables
            double weight = double.Parse(weightTextbox.Text),
                height = double.Parse(heightTexbox.Text), BMI = (weight * 703) / Math.Pow(height, 2);

            //display
            bmiLabel.Text = "BMI: " + Math.Round(BMI, 2);
        }
    }
}
