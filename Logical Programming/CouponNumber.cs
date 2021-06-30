using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{

    /// <summary>
    /// Coupon problem
    /// </summary>
    class CouponNumber
    {
        public static void CouponGenerator()
        {
            Console.WriteLine("Enter the start range for coupon number:");
            int couponStartRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range for coupon number:");
            int couponEndRange = Convert.ToInt32(Console.ReadLine());
            int numberOfCoupons = couponEndRange - couponStartRange;
            int randomcount = 10;
            //Set does not allow duplicate values within it.
            HashSet<int> distinctCoupon = new HashSet<int>();
            while (distinctCoupon.Count() < numberOfCoupons+1)
            {
                randomcount++;
                distinctCoupon.Add(RandomNumber(couponStartRange,couponEndRange));
            }
            Console.Write("The Distinct Coupon: [ ");
            foreach (int i in distinctCoupon)
            {
                
                Console.Write(i+ ", ");
                
            }
            Console.WriteLine("]");
            Console.WriteLine("The number of times random number generated: "+randomcount);
            Console.WriteLine(" ");
            
        }
       
            public static int RandomNumber(int couponStartRange,int couponEndRange)
        {
            Random random = new Random();
            return random.Next(couponStartRange,couponEndRange+1);
        }
    }
}
