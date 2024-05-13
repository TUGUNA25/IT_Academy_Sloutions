using System;

Console.Write("Enter a number: ");
int test_number = int.Parse(Console.ReadLine());
String answer = "";
while (!(test_number == 1)) {
    if (test_number % 2 == 0) {
        answer = answer + "0";
    }
    else { answer = answer + "1"; }
    test_number = test_number / 2;
}
answer = answer + "1";

char[] charArray = answer.ToCharArray();
Array.Reverse(charArray);
answer = new string(charArray);
Console.WriteLine(answer);