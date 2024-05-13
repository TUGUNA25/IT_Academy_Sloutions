static int RecSum(int number)
{

    if (number == 1)
    {
        return 1;
    }
    return number + RecSum(number - 1);
}


Console.WriteLine(RecSum(13));