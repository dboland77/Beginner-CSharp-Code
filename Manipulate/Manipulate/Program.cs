using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulate";

            Console.Write("Please Enter Text: ");
            string text = Console.ReadLine();

            Console.Write("\nThanks. You Entered:\n'" + text + "'");
            Console.WriteLine("\t\tText Length: " + text.Length);

            text = text.Trim();
            Console.Write("\nTrimmed:\t'" + text + "'");
            Console.WriteLine("\tText Length: " + text.Length);

            string upper = text.ToUpper();
            Console.WriteLine("\nUpper Case:\t'" + upper + "'");

            string lower = text.ToLower();
            Console.WriteLine("LowerCase:\t'" + lower + "'");

            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

            Console.WriteLine("\nPadded Left:\t'" + upper + "'");
            Console.WriteLine("\nPadded Right:\t'" + lower + "'");
            Console.WriteLine("\nPadded Both:\t'" + text + "'");

            Console.WriteLine("\nTrimmed Start:\t'" + upper.TrimStart() + "'");
            Console.WriteLine("\nTrimmed End:\t'" + text.TrimEnd('*') + "'");
            Console.ReadKey();

        }
    }
}
