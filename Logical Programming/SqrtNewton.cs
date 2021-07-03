using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class SqrtNewton
    {
        /// <summary>
        /// SQRTs the using newton.
        /// </summary>
        public static void SqrtUsingNewton()
        {
            Console.WriteLine("Enter the Number:");
            double number = Convert.ToDouble(Console.ReadLine());
            double t = number;
            double root;
            while (true)
            {
                root = 0.5 * (t + (number / t));
                if (Math.Abs(root - t) < 0.00001)
                    break;
                t = root;
            }

            Console.WriteLine("The sqrt using newtons law: "+Math.Round(root,3));

        }
    }
}
