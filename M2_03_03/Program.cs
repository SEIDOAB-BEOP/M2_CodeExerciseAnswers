using System;

namespace Exercise_3_03_02a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nesting for
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"i: {i}");
                for (int k = 1; k <= 10; k++)
                {
                    Console.WriteLine($"k: {k}");
                }
                Console.WriteLine();
            }

            //Nesting while
            int j=0;
            while (j < 10)
            {
                Console.WriteLine();
                Console.WriteLine($"j: {j++}");

                int k = 0;
                while (k < 10)
                {
                    Console.WriteLine($"k: {k++}");
                }
            }
        }
    }
}
//2.	Write two nested for-loops (a for-loop in a for-loop). The outer loop counts down from 50 to 0, and for each count down the 
//		inner loop counts up 1..10. Print out in below form:
//		50: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
//		49: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
//		...
//		0: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
