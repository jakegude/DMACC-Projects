using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //the cups to punces method accepts a number of cups as an argument and
        //returns the equivalent number of fluid ounces

        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //variables to hold cups and ounces
            double cups, ounces;

            //get the number of cups
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                //convert the cups to ounces
                ounces = CupsToOunces(cups);

                //display the ounces
                ouncesLabel.Text = ounces.ToString("n1");
            }
            else
            {
                //display an error message
                MessageBox.Show("Enter a valid number");
            }
        }
    }
}
