using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson3
{
    
    class AccountInBank
    {
        
        private int _accountId;
        private decimal _balance;
        private AccountType _accountType;

        
        static int counter;

        public int AccountID {
            get { return _accountId;}
            
        }
        public decimal Balance
        {
            get {return _balance;}
            set {_balance = value; }
        }

        public AccountType TypeOfAccount
        {
            get { return _accountType; }
            set { _accountType = value;}
        }
       
        public AccountInBank():this(0, AccountType.Saving)
        {
       
        }
        public AccountInBank(AccountType type):this(0, type)
        {

        }
        public AccountInBank(decimal balance):this(balance, AccountType.Current)
        {

        }
        public AccountInBank(decimal balance, AccountType type)
        {
            SetAccountNumber();
            Balance = balance;
            TypeOfAccount = type;
        }

       
        public void Put ()
        {
            Console.Write("Введите сумму для зачисления на счет:_ ");
            string sumString = Console.ReadLine();

            Balance =+ CheckSum(sumString);

            Console.WriteLine(Messages.success);
            BalanceInfo(this);

            
        }
        public void Withdraw()
        {
            Console.Write("Введите сумму для снятия со счета:_ ");
            string sumString = Console.ReadLine();

            decimal sum =  CheckSum(sumString);
            
            if(MoneyEnough(Balance, sum))
            {
                Balance -= sum;
                Console.WriteLine(Messages.success);
                BalanceInfo(this);
            }
            else
            {
                Console.WriteLine(Messages.failure);
                Console.WriteLine(new Exception("Недостаточно средств для выполнения операции"));
            }

            
        }

        public void Transfer (AccountInBank acc2 )
        {
            Console.WriteLine("Введите сумму для перевода со счета 1 на счет 2");
            string sumString = Console.ReadLine();

            decimal sum = CheckSum(sumString);

            if (MoneyEnough(Balance, sum))
            {
                Balance -= sum;
                Console.WriteLine(Messages.success); 
                BalanceInfo(this);

                acc2.Balance += sum;
                BalanceInfo(acc2);               
            }


        }

        private decimal CheckSum(string sumString)
        {
            decimal sum = 0;
            try
            {                  
                 sum = Convert.ToDecimal (sumString);                
            }
            catch 
            {
                Console.WriteLine(new WrongDataFormatException().Message); 
                                
            }
            
            return sum;
        }   

        private void SetAccountNumber()
        {
            counter++;
            _accountId = counter;
        }
        private void GetBalance()
        {
            Console.WriteLine($"Текущий баланс составляет {Balance} у.е.");
        }

        private bool MoneyEnough (decimal balance, decimal sum)
        {
            return  balance >= sum ? true : false;
        }

        public void BalanceInfo(AccountInBank account)
        {
            Console.WriteLine($"Баланc по счету# {account.AccountID} составляет {account.Balance}");
        }

    }
    
}
