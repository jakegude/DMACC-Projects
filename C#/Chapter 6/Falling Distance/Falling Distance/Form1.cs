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
namespace Falling_Distance
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
            //clears the form
            timeTextbox.Text = "";
            outputLabel.Text = "";
            //focus
            timeTextbox.Focus();
        }

        private void FallingDistance(double time)
        {
            //falling distance formula
            outputLabel.Text = "Distance (m): " + (Math.Pow(time, 2) * 9.8 / 2);
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the falling distance for the inputted amount of time
            //variables
            double time;

            if (double.TryParse(timeTextbox.Text, out time))
            {
                FallingDistance(time);
            }
        }
    }
}
