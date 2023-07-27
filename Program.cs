using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Triangle triangle = new Triangle(3.0, 4.0, 5.0);

            circle.PrintInfo();
            rectangle.PrintInfo();
            triangle.PrintInfo();
        }
    }
}
