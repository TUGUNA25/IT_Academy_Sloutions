using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    internal class Triangle : Shape
    {
        public Point A;
        public Point B;
        public Point C;
       

        public Triangle(Point a,Point b,Point c) { 
            this.A = a;
            this.B = b;
            this.C = c;
            
            
        }

        public override double Area()
        {
            double side1 = Point.getDistance(A, B);
            double side2 = Point.getDistance(B, C);
            double side3 = Point.getDistance(A, C);

            double s = (side1 + side2 + side3) / 2;

            return Math.Sqrt(s*(s-side1)* (s - side2)* (s - side3));
                    
        }

        public override double Perimeter()
        {
            double side1 = Point.getDistance(A, B);
            double side2 = Point.getDistance(B, C);
            double side3 = Point.getDistance(A, C);

            return side1+ side2 + side3;
        }

        public override string ToString()
        {
            double area = Area();
            double perimeter = Perimeter();
            return $"Area of Triangle is {area}, and perimeter is {perimeter}";
        }
    }
}
