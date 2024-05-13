namespace day9s_tasks
{
   class Triangle
    {
        int _side1;
        int _side2;
        int _side3;

        public int side1 {
            get { return _side1; }
            set { 
                if (value < 0 )
                    Console.WriteLine("It is not valid triangle");
                else
                    _side1 = value;
            }
        }

        public int side2 {
            get { return _side2; }
            set { 
                if (value < 0)
                    Console.WriteLine("It is not valid triangle");
                else
                    _side2 = value; }
        }

        public int side3 {
            get { return _side1; }
            set
            {
                if (value < 0 || (_side1 + value <= _side2 || _side1 + _side2 <= value || value + _side2 <= _side1))
                    Console.WriteLine("It is not valid triangle");
                else
                    _side3 = value;
            }

        }

        public int Perimeter() { 
            return _side1+_side2 + _side3;
        }

        public double Area() {
            double s = (_side1 + _side2 + _side3) / 2.0;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }
    }
}
