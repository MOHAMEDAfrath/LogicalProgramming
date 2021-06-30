using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    /// <summary>
    /// to find day for the given date
    /// </summary>
    class DayOfWeek
    {
        public static void getDate()
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter the date:");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The day for this date "+date+" - "+month+" - "+year+" - is: "+days[DayFromDate(date, month, year)]);
        } 
        public static int DayFromDate(int date,int month,int year)
        {
            int yo = year - (14 - month) / 12;
            int x = yo + yo / 4 - yo / 100 + yo / 400;
            int mo = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (date + x + 31* mo/12) % 7;
            return d0;
  
        }
    }
}
