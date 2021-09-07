using System;
using System.Collections.Generic;
using System.Text;

namespace bank1
{
    class Operation
    {
        public static void ShowBalance(Account acc)
        {
            Console.WriteLine(acc.Balance);
        }
        public static void Transaction(Account acc, Account acc1, double sum)
        {
            acc.Balance -= sum;
            acc1.Balance += sum;
            Console.WriteLine("Transaction completed");
        }
        public static int Widthraw()
        {
            return 0;
        }
        public static int Deposit()
        {
            return 0;
        }
        public static void GetCredit(Account acc, double creditSum)
        {

        }
    }
}
