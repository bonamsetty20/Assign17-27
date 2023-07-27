using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
    {
        ShapeType = "Triangle";
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Area
    {
        get
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
    public override double Perimeter => SideA + SideB + SideC;

    public void PrintInfo()
    {
        Console.WriteLine($"Shape: {ShapeType}, SideA: {SideA}, SideB: {SideB}, SideC: {SideC}, Area: {Area}, Perimeter: {Perimeter}");
    }
}
}
