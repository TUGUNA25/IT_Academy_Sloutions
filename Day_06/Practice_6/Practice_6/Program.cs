using System;
using System.Diagnostics.Metrics;

Console.Write("Enter size of array: ");
int array_size = int.Parse(Console.ReadLine());
char test_symbol = 'a';
int appearTime = ElmentTimes(createArray(array_size), test_symbol);
PrintAnswer(test_symbol, appearTime);



static char[] createArray(int size)
{

    char[] array = new char[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter integer for index " + i + ": ");
        char symbol = char.Parse(Console.ReadLine());
        array[i] = symbol;

    }
    return array;
}

static int ElmentTimes(char[] arr,char symbol) {
    int counter = 0;
    foreach (char item in arr)
    {
        if (item == symbol) {
            counter++;
        }
    }
    return counter;
}


static void PrintAnswer(char symbol,int appearTime) {

    Console.WriteLine("'"+symbol+"' shegvxvda "+appearTime+"-jer");
}