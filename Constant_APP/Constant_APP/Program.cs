using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_APP
{
    class Program
    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri};
        static void Main(string[] args)
        {
            const double pi = 3.14159265358979;
            var daysType = typeof(Days);

            Console.WriteLine("Pi Type: " + pi.GetType());
            Console.WriteLine("Circumference: " + (pi * 3));

            Console.WriteLine("\nFirst Name: " + Days.Sat);
            Console.WriteLine("1st Index: " + (int)Days.Sat);

            string name = Enum.GetName(daysType, 2);
            Console.WriteLine("\n3rd Index: " + name);
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon?: " + flag);
            Console.ReadKey();
        }
    }
}
