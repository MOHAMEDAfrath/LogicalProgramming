using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class ReverseNumber
    {
        /// <summary>
        /// Reverses the number.
        /// </summary>
        public static void Reverse()
        {
            Console.WriteLine("Enter the number to reverse:");
            int reverse = Convert.ToInt32(Console.ReadLine());
            int result = 0,remainder = 0;
            while(reverse != 0)
            {
                remainder = reverse % 10;
                result = result * 10 + remainder;
                reverse /= 10;

            }
            Console.WriteLine("The reversed number = "+result);

        }
    }
}
