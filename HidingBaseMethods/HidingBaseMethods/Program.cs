using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingBaseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Man henry = new Man();
            Hombre enrique = new Hombre();

            henry.speak(); //calls the base speak
            henry.speak("It's a nice day"); //calls the base overloaded speak
            enrique.speak("Hola mia amo enrique"); //calls the new hombre overloaded speak

            //This final statement uses an explicit cast to call the overloaded method
            // in the base class

            ((Man)enrique).speak("Es una tarde hermosa");
            Console.ReadKey();
        }
    }

    public class Man
    {
        public void speak()
        {
            Console.Write("Hello: ");
        }

        public void speak(string message)
        {
            Console.WriteLine(message + "!\n");
        }
    }

    public class Hombre : Man
    {
        //cThe new keyword hear indicates that this is intentionally
        // hiding the overloaded speak method in the base class
        // For this "hiding" to occur the name and parameters must be the same
        public new void speak (string message)
        {
            base.speak(); //calls the base class speak
            Console.WriteLine(message);
        }
    }
}
