using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fixed : Account
    {
        int tenureYear = 5, year;

        public Fixed() { }
        public Fixed(string accName, string accid, int balance, int year)
            : base(accName, accid, balance)
        {
            this.year = year;
        }

        new public void Withdraw(int amount)
        {
            if (tenureYear == this.year)
                base.Withdraw(amount);
            else
                Console.WriteLine("Account need to mature."); Console.WriteLine();
        }

        new public void Deposit(int amount) { base.Deposit(amount); }

        new public void Transfer(int amount, Account acc)
        {
            if (tenureYear == this.year)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Account need to mature."); Console.WriteLine();
        }
    }
}
