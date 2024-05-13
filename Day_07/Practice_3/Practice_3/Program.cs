using System;


Console.Write("Give me a string : ");
string test = Console.ReadLine();
SpaceString(test);

static void SpaceString(string test_string)
{
    foreach (char item in test_string)
    {   if (item != test_string[test_string.Length - 1]) 
            Console.Write(String.Format("{0} ",item));
        else
            Console.Write(String.Format("{0}", item));
    }

}