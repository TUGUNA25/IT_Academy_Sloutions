using System;

Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
int test_number = int.Parse(Console.ReadLine());

for (int i = 0; i < test_number; i++)
{
    if (i % 2 == 1)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write(0 +" ");
            }
            else { Console.Write(1 + " "); }
        }
    }
    else {
        for (int j = 0; j <= i; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write(1 + " ");
            }
            else { Console.Write(0 + " "); }
        }

    }

    Console.WriteLine("\n");
    
}