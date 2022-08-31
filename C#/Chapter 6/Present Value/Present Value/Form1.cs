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
namespace Present_Value
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
            futureTextbox.Text = "";
            rateTextbox.Text = "";
            yearsTextbox.Text = "";
            //focus
            futureTextbox.Focus();
        }

        private void PresentValue()
        {
            //calculates formula
            //variables
            double presentamount, futureamount, rate, years;
            double.TryParse(futureTextbox.Text, out futureamount);
            double.TryParse(rateTextbox.Text, out rate);
            double.TryParse(yearsTextbox.Text, out years);

            presentamount = futureamount / Math.Pow((1 + rate / 100), years);

            //display
            outputLabel.Text = presentamount.ToString("C2");
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates present value
            PresentValue();
        }
    }
}
