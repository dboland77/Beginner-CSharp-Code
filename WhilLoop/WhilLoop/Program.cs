using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WhileLoop";
            int[] nums = new int[10];
            int i = 0;

            while( i < nums.Length)
            {
                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            }
            Console.Write("\n\n");

            do
            {
                i--;
                //Statements to be inserted here (Step 6).
                Console.Write(" | " + nums[i]);
                if(i==8)
                {
                    Console.Write(" | Skipped"); continue;
                }
                if(i==3)
                {
                    Console.Write(" | Done"); break;
                }
            }
            while (i > 0);
            Console.ReadKey();
        }
    }
}
