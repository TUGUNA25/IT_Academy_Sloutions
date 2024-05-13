using System;



Decomposite(getInput());


static int getInput() {
    Console.Write("Enter a positive number: ");
    int number = int.Parse(Console.ReadLine());

    return number;
}

static void Decomposite(int number) {
    Console.Write(number+" = ");
    int length = (int)Math.Log10(number) + 1;
    for (int i = length-1; i >= 0 ; i--)
    {
        int digit = number / (int)Math.Pow(10, i);
        number %= (int)Math.Pow(10, i);

        Console.Write(digit+"* 10^"+i);

        if (i > 0) {
            Console.Write(" + ");
        }
    }

}