using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CD_Account : SavingsAccount
    {
        //field
        private string _maturityDate;

        //constructor
        public CD_Account()
        {
            _maturityDate = "";
        }

        //maturity date property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
