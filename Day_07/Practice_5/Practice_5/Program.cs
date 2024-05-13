using System;

Console.Write("Give me a String: ");
string test = Console.ReadLine();
PrintAnswer(NumbersInString(test), NumberOfLetters(test), test);

static int NumberOfLetters(string test_string) {
    int counter = 0;
    foreach (char item in test_string)
    {
        if (Char.IsLetter(item))
            counter++;
    }
    return counter;
}

static int NumbersInString(string test_string)
{
    int counter = 0;
    foreach (char item in test_string)
    {
        if (Char.IsNumber(item))
            counter++;
    }
    return counter;
}

static void PrintAnswer(int numbers, int letters, string test_string) {
    int others = test_string.Length-numbers-letters;
    Console.WriteLine(String.Format("\"{0}\" -> Letters: {1}, Numbers: {2}, Others: {3}",test_string,letters,numbers,others));
}

