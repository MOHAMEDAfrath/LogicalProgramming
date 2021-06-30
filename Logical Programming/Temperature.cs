using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    class Temperature
    {
        /// <summary>
        /// Gets the temperatures and converts to celsius and fahrenheit.
        /// </summary>
        public static void getTemperatures()
        {
            Console.WriteLine("Enter the Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            TemperatureConversion(celsius,fahrenheit);

        }
        public static void TemperatureConversion(double celsius,double fahrenheit)
        {
            double celsiusToFahrenheit = (celsius * 9 / 5) + 32;
            double fahrenheitToCelsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The value after converting celsius to fahrenheit is: "+celsiusToFahrenheit);
            Console.WriteLine("The value after converting fahrenheit to celsius is: " + fahrenheitToCelsius);
        }
    }
}
