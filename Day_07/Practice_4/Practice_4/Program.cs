using System;

Console.Write("give me a string : ");
string test = Console.ReadLine();
Console.WriteLine(numberOfWords(test));

static int numberOfWords(string test_string) {
    var split_result = test_string.Split(' ');
    return split_result.Length;
}
