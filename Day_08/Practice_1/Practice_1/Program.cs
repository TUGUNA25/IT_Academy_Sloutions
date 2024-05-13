static void RecFunction(int number)
{
    if (number == 0)
    {
        return;
    }

    RecFunction(number - 1);
    Console.Write(number + " ");
}

RecFunction(13);
