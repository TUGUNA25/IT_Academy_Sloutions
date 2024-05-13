static int PawRec(int number, int paw)
{
    if (paw == 1)
    {
        return number;
    }
    return number * PawRec(number, paw - 1);

}


Console.WriteLine(PawRec(2,10));