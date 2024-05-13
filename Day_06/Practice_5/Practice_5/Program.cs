using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int array_size = int.Parse(Console.ReadLine());

        int[] array = createArray(array_size);

        int test_number = 5;    //   ricxvi romelsac vamowmeb aris tu ara masivshi
        int result = FindNumberFact(array, test_number);

        if (result == -1)
        {
            Console.WriteLine("Number " + test_number + " was not found in the given array");
        }
        else
        {
            Console.WriteLine("Factorial of " + test_number + " is " + result);
        }
    }

    static int[] createArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter integer for index " + i + ": ");
            int number = int.Parse(Console.ReadLine());
            array[i] = number;
        }
        return array;
    }

    static int Fact(int number)
    {
        int answer = 1;

        for (int i = 1; i <= number; i++)
        {
            answer = answer * i;
        }

        return answer;
    }

    static int FindNumberFact(int[] arr, int number)
    {
        foreach (int item in arr)
        {
            if (item == number)
            {
                return Fact(number);
            }
        }

        return -1;
    }
}
