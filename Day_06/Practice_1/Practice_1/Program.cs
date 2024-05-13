using System;


static int GetElemenetByIndex(int[] arr, int index) {
    return arr[index];
}


int[] test_arr = [1, 3, 4, 15, 13, 23, 98];
int number = 4;
Console.WriteLine("Number at index " + number + " in the array is " + GetElemenetByIndex(test_arr, number));