using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Assign Values: ");
            Console.Write("\t a = " + (a = 8));
            Console.WriteLine("\t b = " + (b = 4));

            Console.Write("\n\nAdd and Assign: ");
            Console.Write("\t a += b (8 += 4)\t a = " + (a += b));

            Console.Write("\n\nSubtract and Assign: ");
            Console.Write("\t a -= b (12 -=4)\t a = " + (a -= b));

            Console.Write("\n\nMultiply and Assign: ");
            Console.Write("\t a *= b (8 *= 4)\t a = " + (a *= b));

            Console.Write("\n\nDivide and Assign: ");
            Console.Write("\t a/= b (32 /= 4)\t a = " + (a /= b));

            Console.Write("\n\nModulus and Assign: ");
            Console.Write("\t a %= b (8 %= 4)\t a = " + (a %= b));
            Console.ReadKey();



        }
    }
}
