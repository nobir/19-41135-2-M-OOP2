using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * reverse the array
             */

            int[] arr1 = new int[]{1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("#  Reverse Array  #");

            for (int i = arr1.Length - 1; i >= 0; i--)
                Console.WriteLine(arr1[i]);

            Console.WriteLine("\n");


            /**
             * sum of all the array elements
             */

            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i < arr2.Length; i++)
                sum += arr2[i];
            Console.WriteLine("Sum of all the array elements: {0}", sum);

            Console.WriteLine("\n");

            /**
             * Find the duplication
             */

            int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrTmp = new int[arr3.Length];

            for (int i = 0; i < arr3.Length; i++)
                arrTmp[i] = arr3[arr3.Length - 1 - i];

            Console.WriteLine("#  Finding Duplication  #");
            for (int i = 0; i < arrTmp.Length; i++)
                Console.WriteLine(arrTmp[i]);

            Console.WriteLine("\n");


            int[] arr4 = new int[] { 0, 0, 1, 1, 2, 2, 5, 4, 3, 3, 6, 6, 8 };
            int max = 0;

            for(int i = 0; i < arr4.Length; i++)
                if(arr4[i] > max)
                    max = arr4[i];

            int[] arrCount = new int[max + 1];

            for (int i = 0; i < arrCount.Length; i++)
                arrCount[i] = 0;

            for (int i = 0; i < arr4.Length; i++)
                arrCount[arr4[i]]++;

            for (int i = 0; i < arrCount.Length; i++)
                if(arrCount[i] != 0)
                    Console.WriteLine("{0} is {1} times", i, arrCount[i]);

            Console.WriteLine("\n");


            /**
             * Find the uniqe
             */

            Console.WriteLine("#  Finding Uniq  #");

            for (int i = 0; i < arrCount.Length; i++)
                if (arrCount[i] == 1)
                    Console.WriteLine("{0} is {1} times", i, arrCount[i]);

            Console.WriteLine("\n");
        }
    }
}
