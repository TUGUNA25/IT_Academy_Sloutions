using System;

Console.WriteLine("Enter year: ");
int year = int.Parse(Console.ReadLine());
bool answer;
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    answer = true;
}
else
{
    answer = false;
}
Console.WriteLine(answer);