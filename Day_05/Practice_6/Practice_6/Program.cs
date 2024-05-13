using System;

Console.Write("Enter array row size: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter array column size: ");
int column = int.Parse(Console.ReadLine());

int[,] test_array = new int[row, column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number for index "+i+","+j+": ");
        int input_number = int.Parse(Console.ReadLine());
        test_array[i,j] = input_number;
    }
}

Console.WriteLine("Here is matrix view of multidimensional array");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(test_array[i,j]+", ");
    }
    Console.WriteLine("\n");
}