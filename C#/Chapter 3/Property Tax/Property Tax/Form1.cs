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
//property tax calculator
namespace Property_Tax
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
            //clears input and outputs
            valueTextbox.Text = string.Empty;
            resultLabel.Text = string.Empty;

            //set focus
            valueTextbox.Focus();

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the property tax
            double value = double.Parse(valueTextbox.Text);
            double tax = value / 100 * 0.64;

            //display
            resultLabel.Text = "Sales Tax is: " + Math.Round(tax, 2).ToString("c");

        }
    }
}
