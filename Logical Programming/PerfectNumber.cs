using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            Console.WriteLine("Enter to number to check perfect number:");
            int perfect = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < perfect; i++)
            {
                if (perfect % i == 0)
                {
                    sum += i;
                }
            }
            string result = sum == perfect ? " is a perfect number" : " is not a perfect number";
            Console.WriteLine(perfect+result);
        }
    }
}
