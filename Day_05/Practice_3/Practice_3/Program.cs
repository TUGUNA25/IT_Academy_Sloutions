using System;
Console.Write("Enter array size: ");
int array_size = int.Parse(Console.ReadLine());
int[] test_array = new int[array_size];
for (int i = 0; i < array_size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    test_array[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
foreach (var item in test_array)
{
    sum = sum + item;
}
Console.WriteLine("Sum of array elements is "+sum);