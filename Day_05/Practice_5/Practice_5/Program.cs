using System;
Console.Write("Enter array size: ");
int array_size = int.Parse(Console.ReadLine());
int[] test_array = new int[array_size];
for (int i = 0; i < array_size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    test_array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array_size; i++)
{
    bool isUnique = true;

    
    for (int j = 0; j < array_size; j++)
    {
        if (i != j && test_array[i] == test_array[j])
        {
            isUnique = false;
            break;
        }
    }

    
    if (isUnique)
    {
        Console.WriteLine(test_array[i]);
    }
}
