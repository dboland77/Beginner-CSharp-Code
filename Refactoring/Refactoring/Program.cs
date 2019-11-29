using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            computeFactorials(1, 8);
            Console.ReadKey();
        }

        static int factorial(int num)
        {
            /* int result;
            if (num == 1)
            { result = 1; }
            else
            { result = (factorial(num - 1) * num); }
            return result;
            */
            //The above code can be refactored using the ternary operator into one line - as below
            return (num == 1) ? 1 : factorial(num - 1) * num;
        }
        
        static void computeFactorials(int num, int max)
        {
            while (num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(factorial(num));
                num++;
            }
        }
    }
}
