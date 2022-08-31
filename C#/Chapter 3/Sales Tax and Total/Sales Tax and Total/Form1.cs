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
//sales tax and total program
//1-25-2017
namespace Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears inputs and outputs
            purchaseTextbox.Text = string.Empty;
            resultLabel.Text = string.Empty;

            //set focus
            purchaseTextbox.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates and displays results
            //variables
            double amount = double.Parse(purchaseTextbox.Text);
            double statetax = amount * 0.04;
            double countytax = amount * 0.02;
            double totaltax = statetax + countytax;
            double totalofsales = amount + totaltax;

            //display
            resultLabel.Text = "Amount of Purchase: " + amount.ToString("c") + "\n" +
                "State Tax: " + statetax.ToString("c") + "\n " +
                "County Tax: " + countytax.ToString("c") + "\n" +
                "Total Sales Tax: " + totaltax.ToString("c") + "\n" +
                "Total of the Sale: " + totalofsales.ToString("c");
        }
    }
}
