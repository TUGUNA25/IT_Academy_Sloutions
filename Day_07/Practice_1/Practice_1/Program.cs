using System.Text;


Console.Write("Give me a string : ");
string test = Console.ReadLine();
Console.WriteLine("if you want vowel input v");
Console.WriteLine("if you want consonant input c");
string input = Console.ReadLine();

Console.WriteLine("Vowel count: "+numberoff(test,input));
PrintAnswer(test,input);
static int numberoff(string test_string,string which = "v") {
    
        int counterForVowel = 0;
        int counterForConsonant = 0;
        foreach (char c in test_string)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') 
                counterForVowel++;
            
            else if (char.IsLetter(c) && c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' &&
               c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U')
            counterForConsonant++; 
        }

        if (which =="v")
           return counterForVowel;
        else
          return counterForConsonant;
    
        
}

static void PrintAnswer(string test_string, string which = "v") {
    StringBuilder sb = new StringBuilder();
    if (which == "v")
    {
        foreach (char c in test_string)
        {
            if ((c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
            {
                sb.Append(String.Format("{0} ", c));
            }
        }
    }

    else {
        foreach (char c in test_string)
        {
            if (char.IsLetter(c) && c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' &&
               c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U')
            {
                sb.Append(String.Format("{0} ", c));
            }
        }

    }

    Console.WriteLine(sb.ToString());
}