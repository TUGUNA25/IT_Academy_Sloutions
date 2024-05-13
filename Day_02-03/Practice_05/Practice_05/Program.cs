using System;

Console.WriteLine("Enter your day of birth:");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your month of birth");
string month = Console.ReadLine();

if (month.ToUpper() == "DECEMBER")
{
    if (day < 22)
        Console.WriteLine(day + " " + month + " is Sagittarius");
    else
        Console.WriteLine(day + " " + month + " is Capricorn");
}
else if (month.ToUpper() == "JANUARY")
{
    if (day < 20)
        Console.WriteLine(day + " " + month + " is Capricorn");
    else
        Console.WriteLine(day + " " + month + " is Aquarius");
}
else if (month.ToUpper() == "FEBRUARY")
{
    if (day < 19)
        Console.WriteLine(day + " " + month + " is Aquarius");
    else
        Console.WriteLine(day + " " + month + " is Pisces");
}
else if (month.ToUpper() == "MARCH")
{
    if (day < 21)
        Console.WriteLine(day + " " + month + " is Pisces");
    else
        Console.WriteLine(day + " " + month + " is Aries");
}
else if (month.ToUpper() == "APRIL")
{
    if (day < 20)
        Console.WriteLine(day + " " + month + " is Aries");
    else
        Console.WriteLine(day + " " + month + " is Taurus");
}
else if (month.ToUpper() == "MAY")
{
    if (day < 21)
        Console.WriteLine(day + " " + month + " is Taurus");
    else
        Console.WriteLine(day + " " + month + " is Gemini");
}
else if (month.ToUpper() == "JUNE")
{
    if (day < 21)
        Console.WriteLine(day + " " + month + " is Gemini");
    else
        Console.WriteLine(day + " " + month + " is Cancer");
}
else if (month.ToUpper() == "JULY")
{
    if (day < 23)
        Console.WriteLine(day + " " + month + " is Cancer");
    else
        Console.WriteLine(day + " " + month + " is Leo");
}
else if (month.ToUpper() == "AUGUST")
{
    if (day < 23)
        Console.WriteLine(day + " " + month + " is Leo");
    else
        Console.WriteLine(day + " " + month + " is Virgo");
}
else if (month.ToUpper() == "SEPTEMBER")
{
    if (day < 23)
        Console.WriteLine(day + " " + month + " is Virgo");
    else
        Console.WriteLine(day + " " + month + " is Libra");
}
else if (month.ToUpper() == "OCTOBER")
{
    if (day < 23)
        Console.WriteLine(day + " " + month + " is Libra");
    else
        Console.WriteLine(day + " " + month + " is Scorpio");
}
else if (month.ToUpper() == "NOVEMBER")
{
    if (day < 22)
        Console.WriteLine(day + " " + month + " is Scorpio");
    else
        Console.WriteLine(day + " " + month + " is Sagittarius");
}