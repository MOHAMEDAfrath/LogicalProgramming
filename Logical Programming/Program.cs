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
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci.FibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber.CheckPerfectNumber();
                        break;


                    case 5:
                        return;
                        break;
                }
            }
        }
    }
}
