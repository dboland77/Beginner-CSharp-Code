using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            rect.setValues(4, 5);
            cone.setValues(4, 5);

            Console.WriteLine("Rectangle area: " + rect.area());
            Console.WriteLine("\nTriangle Area: " + cone.area());
            Console.ReadKey();

        }

    public class Polygon
        {
            protected int width, height;

            public void setValues(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

        }
    public class Rectangle : Polygon
        {
            public int area() { return (width * height); }
        }

    public class Triangle : Polygon
        {
            public int area() { return ((width * height) / 2); }
        }

    }
}
