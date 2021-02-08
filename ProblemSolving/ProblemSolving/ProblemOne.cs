using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ProblemOne
    {
        public static void ProblemDispaly()
        {
            int n = 100;

            Console.Write("Even Numebrs: ");
            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    if (i == n)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
