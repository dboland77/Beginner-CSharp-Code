using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            string num;

            num = getWeight(out weight);
            Console.WriteLine(num + "lb = " + lbToKg(weight) + "kg");
            kgtoLb(ref weight);
            Console.WriteLine(num + "kg = " + weight + "lb");
            Console.ReadKey();

        }
        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }

        static double lbToKg(double pounds =5)
        {
            return (pounds * 0.45359237);
        }

        static void kgtoLb (ref double weight)
        {
            weight = (weight / 0.45359237);
        }
    }
}
