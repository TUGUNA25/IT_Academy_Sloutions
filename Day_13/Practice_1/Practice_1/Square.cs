using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Square : Shape
    {
        public Point A;
        public Point B;
        public Point C;
        public Point D;


        public Square(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;

        }
        public override double Area()
        {
            double side1 = Point.getDistance(A, B);
            double side2 = Point.getDistance(A, C);
            return side1 * side2;
        }

        public override double Perimeter()
        {
            double side1 = Point.getDistance(A, B);
            double side2 = Point.getDistance(A, C);

            return side1*2 + side2*2;
        }
        public override string ToString()
        {
            double area = Area();
            double perimeter = Perimeter();
            return $"Area of Square is {area}, and perimeter is {perimeter}";
        }
    }
}
