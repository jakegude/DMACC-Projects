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
namespace Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits the program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            secondsTextbox.Text = "";
            outputLabel.Text = "";

            //focus
            secondsTextbox.Focus();

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //converts inputted seconds to minutes, hours, etc
            //variables
            double seconds = double.Parse(secondsTextbox.Text),
                minutes = 60,
                hours = 3600,
                days = 86400;

            //conversion
            if (seconds > minutes && seconds > hours && seconds > days)
            {
                outputLabel.Text = Math.Round((seconds / days)).ToString() + " Days" + "\n" +
                    Math.Round(((seconds % days) / hours)).ToString() + " Hours" + "\n" +
                    Math.Round(((seconds % hours) / minutes)).ToString() + " Minutes" + "\n" +
                    Math.Round(seconds % minutes).ToString() + " Seconds";
            }
            else if (seconds > minutes && seconds > hours && seconds < days)
            {
                outputLabel.Text =Math.Round(((seconds % days) / hours)).ToString() + " Hours" + "\n" +
                    Math.Round(((seconds % hours) / minutes)).ToString() + " Minutes" + "\n" +
                    Math.Round(seconds % minutes).ToString() + " Seconds";
            }
            else if (seconds > minutes && seconds < hours && seconds < days)
            {
                outputLabel.Text = Math.Round(((seconds % hours) / minutes)).ToString() + " Minutes" + "\n" +
                    Math.Round(seconds % minutes).ToString() + " Seconds";
            }
            else if (seconds < minutes && seconds < hours && seconds < days)
            {
                outputLabel.Text = Math.Round(seconds % minutes).ToString() + " Seconds";
            }
        }
    }
}
