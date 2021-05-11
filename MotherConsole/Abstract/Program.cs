using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myShape = new Circle();

            myShape.Radius = 5;

            ProcessShape(myShape);


            Square square = new Square();
            square.Side = 6;

            ProcessShape(square);

            Console.ReadLine();
        }


        public static void ProcessShape(Shape shape)
        {
            var area = shape.CalculateArea();

            Console.WriteLine(area);
        }
    }


    class StudentEmployee : Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override double CalculateWage()
        {
            return 8000;
        }

        public override string ToString()
        {
            return "bla";
        }


    }


    class RegularEmplyoyee : Employee
    {
        public override double CalculateWage()
        {
            return 5000;
        }
    }

    abstract class Employee
    {
        public abstract double CalculateWage();

        public int CalculateHolidays()
        {
            return 5;
        }
    }


    public abstract class Shape
    {
        public int Color { get; set; }

        public abstract double CalulateLength();
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalulateLength()
        {
            return 2 * Math.PI * Radius;
        }
    }


    class Square : Shape
    {
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override double CalulateLength()
        {
            return 4 * Side;
        }
    }

}
