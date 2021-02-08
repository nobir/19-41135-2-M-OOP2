using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ProblemEight
    {
        public static void ProblemDispaly()
        {
            double physics = 95, chemistry = 70.8, biology = 82.2, math = 97, computer = 90, sum = 0.0;

            sum = physics + chemistry + biology + math + computer;
            sum = (100 * sum) / 500;

            if(sum >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if(sum >= 85 && sum < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if(sum >= 80 && sum < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if(sum >= 75 && sum < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if(sum >= 50 && sum < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine("");
        }
    }
}
