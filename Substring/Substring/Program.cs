using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Substring";
            string text = "My dog is a cute dog";
            Console.WriteLine(text + "\tLength: " + text.Length);

            Console.WriteLine("\nPlease Enter a substring to seek: ");
            string sub = Console.ReadLine();

            char[] arr = new char[sub.Length];
            sub.CopyTo(0, arr, 0, sub.Length);

            int pos = text.IndexOf(sub);
            report(pos, sub);

            pos = text.LastIndexOf(sub);
            report(pos, sub);

            pos = text.IndexOfAny(arr);
            report(pos, text.Substring(pos, 1));

            pos = text.LastIndexOfAny(arr);
            report(pos, text.Substring(pos, 1));
            Console.ReadKey();
            
        }
        static void report(int pos, string sub)
        {
            if (pos != -1)
            {
                Console.WriteLine("'" + sub + "' Found At " + pos);
            }
            else
            { 
                Console.WriteLine("'" + sub + "' Not Found!");
            }
        }
    }
}
