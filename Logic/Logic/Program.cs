using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yes = true, no = false;

            Console.Write("AND Logic:");
            Console.Write("\t(yes&&yes):" + (yes && yes));
            Console.Write("\n\t\t(yes&&no):" + (yes && no));
            Console.Write("\n\t\t(no&&no):" + (no && no));

            Console.Write("\n\nOR Logic:");
            Console.Write("\t(yes || yes):" + (yes || yes));
            Console.Write("\n\t\t(yes || no):" + (yes || no));
            Console.Write("\n\t\t(no || no):" + (no || no));

            Console.Write("\n\nNOT Logic:");
            Console.Write("\t yes = " + yes);
            Console.Write("\t !yes = " + !yes);
            Console.Write("\t\n\t\t no = :" + no);
            Console.Write("\t !no = " + !no);
            Console.ReadKey();



        }
    }
}
