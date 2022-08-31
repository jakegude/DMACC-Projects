using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Ending_Balance
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
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailsListbox.Items.Clear();
            //focus
            startingBalTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //calc
            //constants
            const decimal interestrate = 0.005m;

            //variables
            decimal balance;
            int months,
                count = 1;

            //get start balance
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                //get months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    //loop calc the ending balance
                    while (count <= months)
                    {
                        //add this months interest to the balace
                        balance = balance + (interestrate * balance);

                        //display this months ending balance
                        detailsListbox.Items.Add("The ending balace " + "for month " + count +
                            " is " + balance.ToString("C"));

                        //add one to the loop counter
                        count = count + 1;
                    }
                    //display the end balace
                    endingBalanceLabel.Text = balance.ToString("C");
                }
                else
                {
                    //invaid number of months was entered
                    MessageBox.Show("Invalid value for months");
                }
            }
            else
            {
                //invalid start balance
                MessageBox.Show("Invalid value for start balace");
            }
        }
    }
}
