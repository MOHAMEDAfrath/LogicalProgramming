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
                    case 7:
                        return;
                        break;
                }
            }
        }
    }
}
