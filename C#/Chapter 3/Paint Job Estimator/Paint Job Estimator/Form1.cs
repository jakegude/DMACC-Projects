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
//paint job estimator
namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculate
            //variables
            double wallspace = double.Parse(squarefeetTextbox.Text);
            double pricepergallon = double.Parse(priceTextbox.Text);
            double gallonsreq = wallspace / 115;
            double hoursreq = gallonsreq * 8;
            double paintcost = pricepergallon * gallonsreq;
            double laborcharge = 20 * hoursreq;
            double totalcost = laborcharge + paintcost;

            //display
            resultLabel.Text = "Num Gallons Required: " + Math.Round(gallonsreq, 2) + "\n" +
                "Hours of Labor: " + Math.Round(hoursreq, 2).ToString("C") + "\n" +
                "Paint Cost: " + Math.Round(paintcost, 2).ToString("C") + "\n" +
                "Labor Cost: " + Math.Round(laborcharge, 2).ToString("C") + "\n" +
                "Total Charge: " + Math.Round(totalcost, 2).ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears inputs and outputs
            resultLabel.Text = string.Empty;
            priceTextbox.Text = string.Empty;
            squarefeetTextbox.Text = string.Empty;

            //set focus
            squarefeetTextbox.Text = string.Empty;

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
            //oops
        }
    }
}
