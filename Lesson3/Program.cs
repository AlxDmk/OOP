using System;

namespace OOP2.Lesson3
{
    public enum AccountType
    {
        Saving,
        Current
    }
    class Program
    {
        static void Main(string[] args)
        {
            AccountInBank account1 = new(AccountType.Current);
            AccountInBank account2 = new(AccountType.Current);

            account1.Put();
            account2.Put();
            account1.Withdraw();
            account1.Transfer(account2);


            //Задание №2 на перевертыш слова

            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();

            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
    }
}
