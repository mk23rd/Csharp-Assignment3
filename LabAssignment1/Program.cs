using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    abstract class Shape {
        abstract public double CalculateArea();
        abstract public double Perimeter();
        private double _radius;
        private double _length;
        private double _width;
       public double radius { get; set; }
       public double length { get; set; }
       public double width { get; set; }

    }
    class Circle : Shape {
        static readonly double PI = 3.14;
        

        public override double CalculateArea()
        {
            return (PI * radius * radius);
        }

        public override double Perimeter()
        {
            return (2 * PI * radius);  
        }
    }
    class Rectangle : Shape {
        public override double CalculateArea()
        {
            return (length*width);
        }

        public override double Perimeter()
        {
            return (2 * length + width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.radius = 23;

            Rectangle r = new Rectangle();
            r.length = 6;
            r.width = 2;
            Console.WriteLine("Area of Circle: "+c.CalculateArea());
            Console.WriteLine("Perimeter of Circle: "+c.Perimeter());
            Console.WriteLine("Area of Rectangle: "+r.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: "+r.Perimeter());



        }
    }
}
