using System;
Console.Write("Enter array size: ");
int array_size = int.Parse(Console.ReadLine());
int[] test_array = new int[array_size];
for (int i = 0; i < array_size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    test_array[i] = int.Parse(Console.ReadLine());
}
Array.Reverse(test_array);
Console.WriteLine("Here is your array!");
foreach (var item in test_array)
{
    Console.WriteLine(item);
}