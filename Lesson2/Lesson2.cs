using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson2
{
    
    class Lesson2 
    {
        public static void Main(string[] args)
        {
            // Первое задание
            AccountInBank_V1 account = new();
            account.AccountID = 5;
            account.TypeOfAccount = AccountType.Saving;
            account.Balance = 10;

            Console.WriteLine($" Банковский счет №  \t{account.AccountID }\n " +
                $"Тип счета \t\t{account.TypeOfAccount }\n " +
                $"Баланс счета №  \t{account.Balance }");

            // Второе задание
            AccountInBank firsthirdAccount = new(AccountType.Saving);
            Console.WriteLine($"{firsthirdAccount.AccountID} \t {firsthirdAccount.Balance}\t {firsthirdAccount.TypeOfAccount}");

            AccountInBank secondAccount = new(10);
            Console.WriteLine($"{secondAccount.AccountID} \t {secondAccount.Balance}\t {secondAccount.TypeOfAccount}");

            AccountInBank thirdAccount = new(100, AccountType.Current);
            Console.WriteLine($"{thirdAccount.AccountID} \t {thirdAccount.Balance}\t {thirdAccount.TypeOfAccount}");

            AccountInBank forthAccount = new();
            Console.WriteLine($"{forthAccount.AccountID} \t {forthAccount.Balance}\t {forthAccount.TypeOfAccount}");


            // Задание под (*)
            firsthirdAccount.Transfer();
            firsthirdAccount.Withdraw();

            Console.ReadKey();
        }


    }
    public enum AccountType
    {
        Saving,
        Current
    }

}
