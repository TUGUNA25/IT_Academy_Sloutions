using System;


static int SumByIndex(int[] arr, int index)
{
    int test_number = arr[index];
    int sum = 0;
    while (test_number != 0) { 
        int digit = test_number % 10;
        sum += digit;
        test_number /= 10;
    }
    return sum;
}

int index = 2;
int[] test_arr = [1, 3, 123, 15, 13, 23, 98];
Console.WriteLine("The sum of the digits of a number at index "+index+" is "+SumByIndex(test_arr, index));