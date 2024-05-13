using System;

int[] test_arr = [1, 3, 4, 15, 13, 23, 98];
Console.WriteLine(productsOfElements(test_arr));


static int productsOfElements(params int[] numbers) {

    if (numbers.Length == 0) { 
        return 0;
    }
    int answer = 1;

    foreach (int item in numbers)
    {
        answer = answer * item;
    }

    return answer;
}