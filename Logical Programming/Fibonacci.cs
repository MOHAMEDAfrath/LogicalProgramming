using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    /// <summary>
    /// Fibonacci Series Program.
    /// </summary>
    class Fibonacci
    {
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter the Number of elements in series: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int fib1 = 0, fib2 = 1, sum = 0;
            Console.Write("{0} {1}",fib1,fib2);
            for(int i = 2; i < N; i++)
            {
                sum = fib1 + fib2;
                Console.Write(" "+sum);
                fib1 = fib2;
                fib2 = sum;
            }
            Console.WriteLine(" ");


        }
    }
}
