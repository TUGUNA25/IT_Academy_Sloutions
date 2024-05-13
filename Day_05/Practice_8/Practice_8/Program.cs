using System.Drawing;

int n = 8;


int[][] matrix = new int[n][];

for (int i = 0; i < n; i++)
{
    matrix[i] = new int[n];
    for (int j = i + 1; j < n; j++)
    {
        matrix[i][j] = 1;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        matrix[i][j] = matrix[j][i]; // anarekli diagonalze
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        matrix[i][j] = 0;
    }
}




for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}
