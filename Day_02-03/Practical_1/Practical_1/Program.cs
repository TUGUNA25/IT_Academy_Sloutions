Console.WriteLine("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());

// gacvla mesame cvladit
//int change_value = number1;
//number1 = number2;
//number2 = change_value;

//Console.WriteLine(number1);
//Console.WriteLine(number2);


// gacvla mesame cvladis gareshe
number1 = number1 + number2;
number2 = number1 - number2;
number1 = number1 - number2;

Console.WriteLine(number1);
Console.WriteLine(number2);