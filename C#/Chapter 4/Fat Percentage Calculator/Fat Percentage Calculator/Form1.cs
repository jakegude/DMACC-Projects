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
namespace Fat_Percentage_Calculator
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
            //clears form
            totalcalTextbox.Text = "";
            fatgramsTextbox.Text = "";
            outputLabel.Text = "";
            lowfatCheckbox.Checked = false;

            //focus
            totalcalTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates fat and calories
            //variables
            double totalcal = double.Parse(totalcalTextbox.Text),
                fatgrams = double.Parse(fatgramsTextbox.Text),
                calsfromfat,
                percentcalfromfat;

            calsfromfat = fatgrams * 9;
            percentcalfromfat = calsfromfat / totalcal;

            //display
            outputLabel.Text = "The number of calories from fat: " + calsfromfat.ToString() + "\n" +
                "Percent of calories from fat: " + percentcalfromfat.ToString("p1") + "\n";

                if (lowfatCheckbox.Checked)
            {
                outputLabel.Text = "The number of calories from fat: " + calsfromfat.ToString() + "\n" +
                "Percent of calories from fat: " + percentcalfromfat.ToString("p1") + "\n" +
                "This food is considered low fat";
            }
        }
    }
}
