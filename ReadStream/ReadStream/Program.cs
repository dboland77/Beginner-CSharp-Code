using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ReadStream";
            string path = "C:\\Users\\David\\Desktop\\TopFive.csv";
            try
            {
                //Statements to be inserted here (Step 5)
                using( StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while(( line = reader.ReadLine()) != null)
                    {
                        //Statements to be inserted here (Steps 6 and 7)
                        if (line.IndexOf("Rank") != 1) line = line.ToUpper();
                        if (line.IndexOf("Sia") != -1) line += "ft.SeanPaul";

                        string[] sub = line.Split(',');
                        line = String.Format("{0,-30}{1,-20}", sub[1], sub[2]);
                        Console.WriteLine(line);
                    }
                }

            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }
    }
}
