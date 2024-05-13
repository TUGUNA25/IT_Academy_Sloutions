using System;

Console.Write("Give me a string to reverse : ");
string test = Console.ReadLine();
Reverse(test);

static void Reverse(string test_string) {
    char [] char_str= test_string.ToCharArray();
    Array.Reverse(char_str);
    foreach (char item in char_str)
    {
        Console.Write(item);
    }

}
