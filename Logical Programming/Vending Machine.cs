using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    /// <summary>
    /// Vending machine program.
    /// </summary>
    class Vending_Machine
    {
        public static void FindNoOfNotes()
        {
            Console.WriteLine("Enter the amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notesAvailable = { 1000,500,100,50,10,5,2,1};
            int[] notesCounter = new int[notesAvailable.Length];
            for(int i = 0; i < notesAvailable.Length; i++)
            {
                if (amount >= notesAvailable[i])
                {
                    notesCounter[i] = amount / notesAvailable[i];
                    amount = amount - (notesAvailable[i] * notesCounter[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }
            for(int i = 0; i < notesCounter.Length; i++)
            {
                if (notesCounter[i] != 0)
                {
                    Console.WriteLine("The "+notesCounter[i]+" of Rs."+notesAvailable[i]+" is required!");
                }
            }
        }
    }
}
