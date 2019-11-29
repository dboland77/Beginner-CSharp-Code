using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //An abstract class is sometimes called a "Capability Class"
    // It's sole purpose is to allow other classes to be derived from them.
    // We declare them using the *abstract* keyword
    // We use the *sealed* keyword in a class (derived or otherwise) to indicate that class *cannot be used*
    // as a base class. We cannot seal an abstract class (obviously!)
    // You cannot actually create an instance of an abstract class 

    class Program
    {
        static void Main(string[] args)
        {
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();
            Caller call = new Caller();

            call.describe(joey);
            call.describe(lola);
            Console.ReadKey();
        }
    }

    // First define a capability class
    public abstract class Bird
    {
        //Note that we end these methods with a semicolon because they are abstract
        //They don't actually do anything they just provide a framework
        public abstract void talk();
        public abstract void fly();
    }

    // We use the sealed keyword in the Bird class to show that 
    // It cannot be used as a base class
    public sealed class Pigeon : Bird
    {
        // We inherit from the base abstract class
        // And then we override the method
        public override void talk()
        {
            Console.WriteLine("Pigeon says: Coo! Coo!");
        }

        public override void fly()
        {
            Console.WriteLine("A Pigeon Flies Away...");

        }
    }

    public sealed class Chicken : Bird
    {
        // We inherit from the base abstract class
        // And then we override the method
        public override void talk()
        {
            Console.WriteLine("Chicken says: Cluck! Cluck!");
        }

        public override void fly()
        {
            Console.WriteLine("I'm a chicken - I can't fly!!...");

        }
    }

    //finally we add a third class to describe the object 
    public sealed class Caller
    {
        public void describe (Bird obj)
        {
            obj.talk();
            obj.fly();
        }
    }
}
