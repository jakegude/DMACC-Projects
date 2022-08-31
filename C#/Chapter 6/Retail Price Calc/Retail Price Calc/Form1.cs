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
namespace Retail_Price_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            itempriceTextbox.Text = "";
            markupTextbox.Text = "";
            outputLabel.Text = "";
            //focus
            itempriceTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the items retail price
            double cost, percent;
            if (double.TryParse(itempriceTextbox.Text, out cost) && 
                double.TryParse(markupTextbox.Text, out percent))
            {
                CalulateRetail(cost, percent);
            }

        }

        private void CalulateRetail(double cost, double percent)
        {
            outputLabel.Text = "Retail Price: " + (cost * (1 + percent / 100)).ToString("C");
        }
    }
}