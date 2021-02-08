using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        private static void Devider(int i)
        {
            Console.WriteLine("\n======================= " + i + " =======================\n");
        }
        static void Main(string[] args)
        {
            Program.Devider(1);
            ProblemOne.ProblemDispaly();

            Program.Devider(4);
            ProblemFour.ProblemDisplay();

            Program.Devider(8);
            ProblemEight.ProblemDispaly();
        }
    }
}
