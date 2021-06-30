using System;

namespace Logical_Programming
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming!");
            while (true)
            {
                Console.WriteLine("Choose an Option: ");
                Console.WriteLine("Enter 1 for Finonacci Series");
                Console.WriteLine("Enter 2 for Perfect Number");
                Console.WriteLine("Enter 3 for Prime number");
                Console.WriteLine("Enter 4 for Reverse a number");
                Console.WriteLine("Enter 5 for Coupon Number");
                Console.WriteLine("Enter 6 for Stop Watch");
                Console.WriteLine("Enter 7 for Vending machine");
                Console.WriteLine("Enter 8 for Finding day");
                Console.WriteLine("Enter 9 for Temperature Conversion");
                Console.WriteLine("Enter 10 for Monthly Payment");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci.FibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber.PrimeNumberBetweenInterval();
                        break;
                    case 4:
                        ReverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumber.CouponGenerator();
                        break;
                    case 6:
                        StopwatchProgram.TimeElapsed();
                        break;
                    case 7:
                        Vending_Machine.FindNoOfNotes();
                        break;
                    case 8:
                        DayOfWeek.getDate();
                        break;
                    case 9:
                        Temperature.getTemperatures();
                        break;
                    case 10:
                        MonthlyPayment.GetCompoudInterestParameter();
                        break;
                    case 11:
                        return;
                        break;
                }
            }
        }
    }
}
