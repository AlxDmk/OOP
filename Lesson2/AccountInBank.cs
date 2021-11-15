using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson2
{
    class AccountInBank
    {
        private int _accountId;
        private decimal _balance;
        private AccountType  _accountType;


        static int counter;

        public int AccountID
        {
            get { return _accountId; }

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

        public AccountInBank() : this(0, AccountType.Saving)
        {

        }
        public AccountInBank(AccountType type) : this(0, type)
        {

        }
        public AccountInBank(decimal balance) : this(balance, AccountType.Current)
        {

        }
        public AccountInBank(decimal balance, AccountType type)
        {
            SetAccountNumber();
            Balance = balance;
            TypeOfAccount = type;
        }

        public void Put()
        {
            Console.Write("Введите сумму для зачисления на счет:_ ");
            string sumString = Console.ReadLine();

            CheckSum(sumString, 1);
        }
        public void Withdraw()
        {
            Console.Write("Введите сумму для снятия со счета:_ ");
            string sumString = Console.ReadLine();

            CheckSum(sumString, 0);
        }

        private void CheckSum(string sumString, int i)
        {
            try
            {

                decimal sum = Convert.ToDecimal(sumString);

                if (i == 1)
                {
                    Balance += sum;
                    Console.WriteLine($"Операция выполена успешно!");
                }

                else if (Balance >= sum)
                {
                    Balance -= sum;
                }
                else { Console.WriteLine($"Недостаточно средств для снятия со счета."); }

                Console.WriteLine($"Текущий баланс составляет: {Balance} ");
            }
            catch
            {
                Console.WriteLine("Вы ввели недопустимое значение");
            }

        }

        private void SetAccountNumber()
        {
            counter++;
            _accountId = counter;
        }
    }
}
