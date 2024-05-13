using System;

Console.Write("Enter size of array: ");
int array_size = int.Parse(Console.ReadLine());

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


static double average(int[] arr) {
    double answer = 0;
    foreach (int numbers in arr)
    {
        answer += numbers;
    }
    answer = answer/ arr.Length;

    return Math.Round(answer,2);
    
}

Console.WriteLine("Arithmetic average of array is "+average(createArray(array_size)));