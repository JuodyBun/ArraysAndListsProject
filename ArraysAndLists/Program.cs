using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            int i, e = 0, o = 0;

             for(i= 0; i <= 9; i++)
            {
                if (arr[i] % 2 == 0) {

                    evens.Add(arr[i]);
                    e++;
                } else {
                    odds.Add(arr[i]);
                    o++;
                }
            }

            Console.WriteLine("Even Numbers: ");
            for (i = 0; i < e; i++)
            {
                Console.WriteLine(evens[i]);
            }

            Console.WriteLine("Odd Numbers: ");
            for (i = 0; i < o; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }   

    }
}
