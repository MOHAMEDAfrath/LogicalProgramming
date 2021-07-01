using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class BinaryConversion
    {
        /// <summary>
        /// Binary Conversion.
        /// </summary>
        public static void Binary()
        {
            Console.WriteLine("Enter the number to be converted to binary:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] binaryResult = new int[32];
            int length = 0;
            for(int i = 31; i >= 0; i--)
            {
                //left shifts the bit
                int shift = number >> i;
                binaryResult[length] = (shift & 1) > 0 ? 1 : 0;
                length++;
                
            }
            foreach(int i in binaryResult)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
            
        }
    }
}
