 static int RecNum(int number)
{

    if (number < 10)
        return 1;
    return 1 + RecNum(number / 10);
}


Console.WriteLine(RecNum(999));