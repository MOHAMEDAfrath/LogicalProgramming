using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class BinaryNibbles
    {
        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        public static void SwapNibbles()
        {
            Console.WriteLine("Enter the number:");
            int x = Convert.ToInt32(Console.ReadLine());
            ///Shifting bits left | Shifting bits right
            int result = ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
            Console.WriteLine("After nibble swaps: "+result);
            int temp = result;
            int flag = 1;
            while (temp != 1)
            {
                if (temp % 2 != 0)
                {
                    flag = 0;
                }
                temp /= 2;
                
            }
            if (flag == 1)
            {
                Console.WriteLine("The number " + result + " is power of 2");
            }
            else
            {
                Console.WriteLine("The number " + result + " is not power of 2");
            }

        
            
        

        }
    }
}
