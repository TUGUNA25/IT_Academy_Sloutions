using System;
using System.Security.AccessControl;


printAnswer(sumMatrixs(createMatrix(), createMatrix()));


static int[,] createMatrix() {
    Console.Write("Enter count of rows: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Enter count of columns: ");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine("=====================================================");


    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write("Enter integer for index "+i+","+j+": ");
            int test_number = int.Parse(Console.ReadLine());
            arr[i,j] = test_number;
        }
    }
    Console.WriteLine("=====================================================");


    return arr;
}


static int[,] sumMatrixs(int[,] matrix1, int[,] matrix2) {
    int[,] new_arr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            new_arr[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    return new_arr;
}


static void printAnswer(int[,] matrix) {
    Console.WriteLine("Here is sum of matrices");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+", ");
        }
        Console.WriteLine();
    }
}





// pirobashi ewera rompirveli metodi unda abrunebdes shevsebul  masivs da ara masivebs  
// aseve ewera rom tviton funqciashi unda xdebodes useristvis ganzomilebebis motxovna
// amitom orive masivistvis calcalke kxeda es chems kodshi 
// anu magaliti pirobis sheusabamo iyo