using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //the getcddate method accepts a cdAccount object as an argurment
        //it assigns the data entered by the user to the object's properties
        private void GetCDData(CD_Account account)
        {
            //temp variables to hold interest rate and balacne
            decimal interestRate;
            decimal balance;

            //get the account number
            account.AccountNumber = accountNumberTextBox.Text;

            //get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;

            //get the interest rate
            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                //get the balace
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    //display error
                    MessageBox.Show("Invalid Balance");
                }
            }
            else
            {
                //display error
                MessageBox.Show("Invalid Interest Rate");
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //create a CDAccount obj
            CD_Account myAccount = new CD_Account();

            //get the cd account data
            GetCDData(myAccount);

            //display the data
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }
    }
}
