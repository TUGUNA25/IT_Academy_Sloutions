static bool IsPal(string test)
{
    if (test.Length <= 1)
        return true;
    if (test[0] == test[test.Length - 1])
        return IsPal(test.Substring(1, test.Length - 2));
    return false;

}

Console.WriteLine("Is palindrome? "+IsPal("abkba"));