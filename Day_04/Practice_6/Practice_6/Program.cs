using System;

Console.Write("Enter a number: ");
int test_number = int.Parse(Console.ReadLine());
Console.Write("divisors of "+test_number+" are: ");
for (int i = 1; i < test_number/2+1; i++)
{
    if (test_number % i == 0) {
        Console.Write(i+", ");
    }
}
Console.Write(test_number);