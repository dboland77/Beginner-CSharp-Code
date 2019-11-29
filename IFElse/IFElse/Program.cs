using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "IfElse";
            Console.Write("Please Enter a Number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Thanks. Now Enter a Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (num >= 6)
            {
                Console.WriteLine("\nNumber exceeds 5");
                    // Nested statement to be inserted here (Step 5)
                if (letter =='C')
                    {
                    Console.WriteLine("Letter is C");
                }
            }
            else
            {
                Console.WriteLine("\n Number is 5 or Less");
            }

            Console.ReadKey();

        }
    }
}
