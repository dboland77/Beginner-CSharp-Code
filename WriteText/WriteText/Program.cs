using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteText";

            //Edit the line below to include your user name
            string path = "C:\\Users\\David\\Desktop\\poem.txt";
            string poem = "\r\n\tI never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists:" + path);
            }
            else
            {
                // Statements to be inserted here (Step 5)
                try
                {
                    File.WriteAllText(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.ReadKey();

        }
    }
}
