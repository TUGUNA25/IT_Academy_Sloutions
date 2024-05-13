using System;

Console.WriteLine("Enter integer number :");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Entered number " + number + " is even");
}
else
{
    Console.WriteLine("Entered number " + number + " is odd");
}
