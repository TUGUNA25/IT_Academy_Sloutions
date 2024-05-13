using System;

Console.Write("Enter a numebr: ");
int test_number = int.Parse(Console.ReadLine());
for (int i = 1; i < test_number+1; i++)
{
    Console.WriteLine(i+" cubed is " + Math.Pow(i,3));
}