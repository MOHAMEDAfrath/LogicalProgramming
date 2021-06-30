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
                Console.WriteLine("Enter 1 for Finonacci Series / Enter 2 to Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci.FibonacciSeries();
                        break;
                    case 2:
                        return;
                        break;
                }
            }
        }
    }
}
