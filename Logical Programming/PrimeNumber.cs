using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class PrimeNumber
    {
        /// <summary>
        /// Primes the number between interval.
        /// </summary>

        public static void PrimeNumberBetweenInterval()
        {
            int flag;
            Console.WriteLine("Enter the start Value:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End Value:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime number between {0} and {1}",start,end);
            if (start == 1)
            {
                start++;

            }
            if(start == 2)
            {
                Console.Write(start + " ");

            }
            if(start % 2 == 0)
            {
                start++;
            }
            for(int i = start; i <= end; i += 2)
            {
                flag = 0;
                for(int j = 2; j * j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    Console.Write(i+ " ");
                }
            }
            Console.WriteLine(" ");
        }
    }
}
