using Practice_1;
Console.WriteLine("Enter triangle cordinates !!!");

Console.WriteLine("Enter x-coordinate for point A:");
double tax = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point A:");
double tay = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point B:");
double tbx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point B:");
double tby = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point C:");
double tcx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point C:");
double tcy = double.Parse(Console.ReadLine());

Point pointTA = new Point { x = tax, y = tay };
Point pointTB = new Point { x = tbx, y = tby };
Point pointTC = new Point { x = tcx, y = tcy };

Triangle triangle1 = new Triangle(pointTA, pointTB, pointTC);

Console.WriteLine("Enter square cordinates !!!");

Console.WriteLine("Enter x-coordinate for point A:");
double sax = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point A:");
double say = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point B:");
double sbx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point B:");
double sby = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point C:");
double scx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point C:");
double scy = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point D:");
double sdx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point D:");
double sdy = double.Parse(Console.ReadLine());

Point pointSA = new Point { x = sax, y = say };
Point pointSB = new Point { x = sbx, y = sby };
Point pointSC = new Point { x = scx, y = scy };
Point pointSD = new Point { x = sdx, y = sdy };

Square square1 = new Square(pointSA, pointSB, pointSC, pointSD);

Console.WriteLine("Enter circle cordinates !!!");

Console.WriteLine("Enter x-coordinate for point A:");
double cax = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point A:");
double cay = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x-coordinate for point B:");
double cbx = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y-coordinate for point B:");
double cby = double.Parse(Console.ReadLine());

Point pointCA = new Point { x = cax, y = cay };
Point pointCB = new Point { x = cbx, y = cby };

Circle circle1 = new Circle(pointCA, pointCB);

Shape[] shapes = { triangle1, square1, circle1 };
foreach (var item in shapes)
{
    Console.WriteLine(item.ToString());
}