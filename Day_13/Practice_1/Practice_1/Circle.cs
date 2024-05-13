using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    internal class Circle : Shape
    {
        const double p  = 3.14;
        public Point A;
        public Point B;
        double r;

        public Circle(Point a, Point b) { 
            this.A = a;
            this.B = b;
        }

        public override double Area()
        {
            double r = Point.getDistance(A,B);
            return p * Math.Pow(r,2);
        }

        public override double Perimeter()
        {
            double r = Point.getDistance(A, B);
            return 2 * p * r;
        }

        public override string ToString()
        {   
            double area = Area();
            double perimeter = Perimeter();
            return $"Area of Circle is {area}, and perimeter is {perimeter}";
        }
    }
}
