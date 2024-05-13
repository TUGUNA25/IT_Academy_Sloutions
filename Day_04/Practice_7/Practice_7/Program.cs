using System;

Console.Write("Enter a number: ");
int test_number = int.Parse(Console.ReadLine());

if (test_number == 0)
{
    Console.Write(0);
}
else if (test_number == 1)
{
    Console.Write("0, 1");
}
else
{
    Console.Write("0, 1");
    int first_number = 0;
    int second_number = 1;
    int next_number;

    for (int i = 2; i < test_number+1; i++)
    {
        next_number = first_number + second_number;
        first_number = second_number;
        second_number = next_number;

        Console.Write(", " + next_number);
    }
}
