using System;

Console.Write("Enter a number: ");
int test_number = int.Parse(Console.ReadLine());
int sum = 0;


for (int i = 0; i < test_number+1; i++)
{
    if (i % 2 == 1) { 
        sum = sum + i;
    }
}

Console.WriteLine("sum of odd numbers from 1 to "+test_number+" is "+sum);
