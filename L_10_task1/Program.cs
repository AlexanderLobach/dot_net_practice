using System;
using System.Collections.Generic;
namespace L_10_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int side;
            for (side = 1; side <= 10; side++)
            {
                List<Figure> figures = new List<Figure>()
                {
                new Circle(side),
                new Square(side),
                new Triangle(side)
                };
                foreach (Figure f in figures)
                {
                Console.WriteLine($"This is '{f.Name()}' SLR Type is '{f.GetType().ToString()}' Sqwere is '{f.Area()}'");
                }
            }
            Console.ReadKey();
        }
    }
}
