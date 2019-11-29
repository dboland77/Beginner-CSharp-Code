using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    // We can spread class definitions across several files by using the *keyword*
    // This can allow multiple programmers to work on the same project at the same time
    // Note that if *ANY* part of a class is declared as *abstract* or *sealed* then this 
    // will apply to the entire class.
    // Partial classes are part of the same *Namespace*

    class Program
    {
        static void Main(string[] args)
        {
            Sailboat boat = new Sailboat("Laser", "Classic");

            boat.describe();
            Console.ReadKey();
        }
    }

    public partial class Sailboat
    {
        public void describe()
        {
            Console.WriteLine("Sailboat: {0} {1}", make, model);
        }
    }
}
