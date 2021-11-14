using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson2
{
    
    class AccountInBank_V1
    {
        private int _accountId;
        private decimal _balance;
        private AccountType _accountType;

        public int AccountID
        {
            get { return _accountId; }
            set { _accountId = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public AccountType TypeOfAccount
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

    }
}
