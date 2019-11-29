using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The code below will throw an invalid cast error from bool to char
              bool flag = true;
            IConvertible convertible = flag;
            char letter = convertible.ToChar(null);
            */

            /* The code below will give an index out of range exception. 
            int[] nums = new int[10]; 
            for (int i = 1; i < 20; i++)
            {
                nums[i] = i;
            } */

            /* Debugging step by step
            int pass = 0;
            int unit = 2;

            for (int i = 1; i < 3; i++)
            {
                pass = (pass + 1);
                unit = square(unit);
            }*/



            /* Nested loops to demonstrate breakpoints
            int i, j, k;
            int pass = 0;

            for (i = 1; i < 4; i++)
            {
                for(j = 1; j < 4; j++)
                {
                    for(k = 1; k < 4; k++)
                    {
                        pass++;
                        Console.WriteLine(pass);
                    }
                }
            }
            Console.ReadKey();*/

            /* Catching run-time errors */
            try
            {
                Console.Write("Please Enter a Number: ");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Now Please Enter Another Number: ");
                double num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Total: " + (num1 + num2));

                Console.ReadKey();
            }
            catch (OverflowException)
            {

                Console.WriteLine("\nMaximum: " + Int32.MaxValue);
                Console.ReadKey();
            }
            catch (Exception Error)
            {

                Console.WriteLine("Error encountered: " + Error.Message);
                Console.ReadKey();
            }

        }

        static int square(int num)
        {
            return (num * num);
        }
    }
}
