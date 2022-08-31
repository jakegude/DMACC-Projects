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
namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //oops
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            startingTextbox.Text = "";
            increaseTextbox.Text = "";
            daysTextbox.Text = "";
            outputListbox.Items.Clear();

            //focus
            startingTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculate population of organisms in x days
            //variables
            double startnum, dailyincrease, days, count;

            if (double.TryParse(startingTextbox.Text, out startnum) &&
                (double.TryParse(increaseTextbox.Text, out dailyincrease)) &&
                (double.TryParse(daysTextbox.Text, out days)))
            {
                outputListbox.Items.Clear();
                outputListbox.Items.Add("Day\tApproximate Population");

                count = 1;
                while (count <= days)
                {
                    outputListbox.Items.Add(count + "\t" +
                        startnum * Math.Pow((1 + dailyincrease / 100), count - 1));
                    count ++;
                }
            }
        }
    }
}
