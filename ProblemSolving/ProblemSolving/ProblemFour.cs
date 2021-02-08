using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ProblemFour
    {
        public static void ProblemDisplay()
        {
            int oddSum = 0, evenSum = 0;

            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }

            Console.WriteLine("Even number summation from 1 to 100: " + evenSum);
            Console.WriteLine("Odd number summation from 1 to 100: " + oddSum);
        }
    }
}
