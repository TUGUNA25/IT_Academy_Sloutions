using System;

Console.WriteLine("Enter first number :");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number :");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number :");
int third = int.Parse(Console.ReadLine());

if (first + second > third && second + third > first && third + first > second)
{
    Console.WriteLine("This should be a triangle !");
}
else
{
    Console.WriteLine("This should not be a triangle !");
}
