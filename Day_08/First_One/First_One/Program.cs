// n3
static string ToBinaryWithFor(int n) // for ciklit
{
    if (n == 0)
    {
       return "0";
    }

   string answer = "";
       while (n > 0)
       {
           int rem = n % 2;
           answer = (char)(rem + '0') + answer;
           n /= 2;
       }

       return answer;
}

    
static string ToBinaryWithRec(int n)  /// rekursit
{
     if (n == 0)
         return "0";
     if(n == 1)
         return "1";
     else
         return ToBinaryWithRec(n / 2) + (n % 2);
}



// n1
static void FindDuo(int n, int[] arr)
{
     int left = 0;
     int right = arr.Length - 1;

     while (left < right)
     {
          int currentSum = arr[left] + arr[right];
          if (currentSum == n)
           {
               Console.WriteLine($"Pair found: ({arr[left]}, {arr[right]})");
               left++;
               right--;
           }
          else if (currentSum < n)
           {
               left++;
           }
           else
           {
               right--;
           }
      }
}



// n2
static int FindNemo(int[] arr)
{       
      int n = arr.Length + 1;
      int sumWithOutNemo = 0;
      int sumWithNemo = (n * (n + 1)) / 2; //progresiaaa
      foreach (int num in arr)
       {
            sumWithOutNemo += num;
       }
       int nemo = sumWithNemo - sumWithOutNemo;
       return nemo;
}

// n4
static void Main()
{
    Console.WriteLine("To turn off the program type \"exit\" otherwise enter the directory path:");

    while (true)
    {
        string input = Console.ReadLine();

        if (input == "exit")
        {
            Console.WriteLine("exiting the program");
            break;
        }

        if (Directory.Exists(input))
        {
            Console.WriteLine($"files under directory: {input}");
            PrintFiles(input);
        }
        else
        {
            Console.WriteLine($"The directory '{input}' does not exist!");
        }

    }

    static void PrintFiles(string path)
    {

        if (!Directory.Exists(path))
        {
            Console.WriteLine($"The directory '{path}' does not exist!");
            return;
        }

        Console.WriteLine($"Files in directory '{path}':");

        foreach (string file in Directory.GetFiles(path))
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        foreach (string item in Directory.GetDirectories(path))
        {
            Console.WriteLine($"Files in subdirectory '{item}':");
            PrintFiles(item);
        }
    }
}

















