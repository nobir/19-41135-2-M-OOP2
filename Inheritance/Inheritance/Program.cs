using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("############################");
            Console.WriteLine("#          Savings         #");
            Console.WriteLine("############################");

                Savings s1 = new Savings("Nobir", "1234", 5000);
                Savings s2 = new Savings("Samuel", "4321", 4000);
                s1.Withdraw(500);
                s1.Deposit(1000);
                s1.Transfer(1000, s2);

                s1.ShowInfo();
                s2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("############################");
            Console.WriteLine("#          Special         #");
            Console.WriteLine("############################");

                SpecialCurrent sc1 = new SpecialCurrent("Nobir", "1234", 5000);
                SpecialCurrent sc2 = new SpecialCurrent("Samuel", "4321", 4000);
                sc1.Withdraw(500);
                sc1.Deposit(1000);
                sc1.Transfer(5000, sc2);

                sc1.ShowInfo();
                sc2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("############################");
            Console.WriteLine("#           Fixed          #");
            Console.WriteLine("############################");

                Fixed f1 = new Fixed("Nobir", "1234", 5000, 4);
                Fixed f2 = new Fixed("Samuel", "4321", 4000, 3);
                f1.Withdraw(500);
                f1.Deposit(1000);
                f1.Transfer(5000, f2);

                f1.ShowInfo();
                f2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("############################");
            Console.WriteLine("#         OverDraft        #");
            Console.WriteLine("############################");

                OverDraft od1 = new OverDraft("Nobir", "1234", 5000);
                OverDraft od2 = new OverDraft("Samuel", "4321", 4000);
                od1.Withdraw(500);
                od1.Deposit(1000);
                od1.Transfer(5000, od2);

                od1.ShowInfo();
                od2.ShowInfo();
        }
    }
}
