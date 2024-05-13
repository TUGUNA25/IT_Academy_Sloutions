using System;

Console.Write("Enter size of array: ");
int array_size = int.Parse(Console.ReadLine());

static int[] createArray(int size) {

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter integer for index "+i+": ");
        int number = int.Parse(Console.ReadLine());
        array[i] = number;

    }
    return array;
}


static void MinMax(int[]array,out int min,out int max)
{

    min = array[0];
    max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min) {
            min = array[i];
        }
    }
}

int[] test_array = createArray(array_size);
int min_value;
int max_value;
MinMax(test_array, out min_value, out max_value);
Console.WriteLine("The minimum number in the array is " + min_value);
Console.WriteLine("The maximum number in the array is " + max_value);