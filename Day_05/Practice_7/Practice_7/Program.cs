using System;

Console.Write("Enter array row size: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter array column size: ");
int column = int.Parse(Console.ReadLine());

int[,] test_array1 = new int[row, column];

Console.WriteLine("Full first matrix");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number for index " + i + "," + j + ": ");
        int input_number = int.Parse(Console.ReadLine());
        test_array1[i, j] = input_number;
    }
}
int[,] test_array2 = new int[row, column];
Console.WriteLine("Full second matrix");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number for index " + i + "," + j + ": ");
        int input_number = int.Parse(Console.ReadLine());
        test_array2[i, j] = input_number;
    }
}

int[,] new_array = new int[row, column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        new_array[i,j] = test_array1[i, j] + test_array2[i,j];;
    }
    
}


Console.WriteLine("Here is sum of two matrices");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(new_array[i, j] + ", ");
    }
    Console.WriteLine("\n");
}