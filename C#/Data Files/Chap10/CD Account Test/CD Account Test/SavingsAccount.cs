using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        //fields
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        //constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
        }

        //Accountnumber property
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        //interest rate property
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }
        
        //balance prop
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
