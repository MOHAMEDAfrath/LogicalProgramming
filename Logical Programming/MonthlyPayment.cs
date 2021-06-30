using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class MonthlyPayment
    {
        /// <summary>
        /// Compunt interest Program
        /// </summary>
        public static void GetCompoudInterestParameter()
        {
            Console.WriteLine("Enter the Principal amount:");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Year to payoff:");
            double Y= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest:");
            double R = Convert.ToDouble(Console.ReadLine());
            CalculateTotalAmountToBePaid(P, Y, R);

        }
        public static void CalculateTotalAmountToBePaid(double p,double y,double r)
        {

            double rate =Math.Round(1 + (r / 1200) , 4);
            double payment = p *(Math.Pow(rate,12*y))-p;
            
            Console.WriteLine("The Amount to be paid monthly: "+Math.Round(payment));

        }
    }
}
