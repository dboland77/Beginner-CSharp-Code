using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        //Add a method to call both overriding methods
        static void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }

        static void Main(string[] args)
        {
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();

            describe(joey);
            describe(lola);
            Console.ReadKey();
        }

        // Base class Bird
        public class Bird
        {
            //Declaring the method as virtual allows it to be overridden
            // in a derived class
            public virtual void talk()
            {
                Console.WriteLine("A Bird talks... \n");
            }

            public virtual void fly()
            {
                Console.WriteLine("A Bird Flies ... \n");
            }
        }

        //Now we add a derived class containing two methods
        // that will override the base methods
        // This is polymorphism (from Greek meaning "many forms"
        // This is sometimes called "One interface multiple functions"
        public class Pigeon : Bird
        {
            public override void talk()
            {
               // base.talk();
                Console.WriteLine("Pigeon says Coo Coo!");
            }
            public override void fly()
            {
              //  base.fly();
                Console.WriteLine("A Pigeon flies away ... ");
            }
        }

        // Another example with a chicken
        public class Chicken : Bird
        {
            public override void talk()
            {
              //  base.talk();
                Console.WriteLine("Chicken says: Cluck Cluck!");
            }
            public override void fly()
            {
              //  base.fly();
                Console.WriteLine("I'm a chicken I can't fly");
            }
        }
    }
}
