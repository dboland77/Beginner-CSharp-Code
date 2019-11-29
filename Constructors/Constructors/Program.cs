using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat tigger = new Cat();

            string tagT = String.Format("{0} is a {1} year old {2} cat",
                                tigger.getName(),
                                 tigger.getAge(),
                                tigger.getColour());

            Console.WriteLine(tagT + tigger.cry()) ;

            Cat smokey = new Cat();

            smokey.setAge(5);
            smokey.setColour("Grey");
            smokey.setName("Smokey");


            string tagS = String.Format("{0} is a {1} year old {2} cat",
                                smokey.getName(),
                                smokey.getAge(),
                                smokey.getColour());

            Console.WriteLine(tagS + smokey.cry());
            Console.WriteLine(tagS + smokey.cry());
            Console.ReadKey();
        }
    }

    public class Cat
    {
        private string name, colour;
        private int age;
        
        //Constructor method
        public Cat()
        {
            name = "Tigger";
            age = 3;
            colour = "Brown";

        }

        public void setName(string name) { this.name = name; }
        public void setAge(int age) { this.age = age; }
        public void setColour(string colour) { this.colour = colour; }

        public string getName() { return name; }
        public int getAge() { return age; }
        public string getColour() { return colour; }

        //Random method
        public string cry() { return "\nMeow, meow!\n"; }
    }
}
