using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an instance named "Fido" of the Dog class

            Dog Fido = new Dog();
            Fido.setAge(3);
            Fido.setColour("Brown");
            Fido.setName("Fido");

            string tagF = String.Format("{0} is a {1} year old {2} dog",
                                Fido.getName(),
                                Fido.getAge(),
                                Fido.getColour());

            Console.WriteLine(tagF + Fido.bark());
            Console.ReadKey();

            Dog Lucy = new Dog();
            Lucy.setAge(2);
            Lucy.setColour("White");
            Lucy.setName("Lucy");

            string tagL = String.Format("{0} is a {1} year old {2} dog",
                                Lucy.getName(),
                                Lucy.getAge(),
                                Lucy.getColour());

            Console.WriteLine(tagL + Lucy.bark());
            Console.ReadKey();


        }
    }

    public class Dog
    {
        //Member variables
        private string name;
        private int age;
        private string colour;

        // Member methods
        //Setter & Getter methods

        public void setName(string tag)
        {
            name = tag; //Store the argument value
        }

        public string getName()
        {
            return name; // Retrieve the stored value
        }

        public void setAge(int yrs) { age = yrs; }
        public int getAge() { return age;}

        public void setColour(string coat) { colour = coat; }
        public string getColour() { return colour; }

        //Other methods
        public string bark() { return "\nWoof, woof!\n"; }
    }
}
