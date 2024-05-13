class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Choose One Of Them With Suitable Index  -> 1)Start Test or  2)Add Test ");
            string path = @"C:\Users\Lenovo\Documents\TBC\Day_21\solution\solution\Test.txt";
            var questions = File.ReadAllLines(path);
            string input = Console.ReadLine();

            if (input == "1")
            {
                int point = 0;
                foreach (var item in questions)
                {
                    try
                    {
                        string correct_answer = "";
                        var test_arr = item.Split('|');    // kitxva maqvs dasplituli
                        foreach (var element in test_arr)
                        {
                            if (element[element.Length - 1] == '*')
                            {
                                Console.WriteLine(element.Substring(0, element.Length - 1));
                                correct_answer = element.Substring(0, 1);
                            }
                            else
                            {
                                Console.WriteLine(element);
                            }
                        }

                        Console.WriteLine("Give Me Your Answer Like: A,B,C or D");
                        string inputAnswer = Console.ReadLine();
                        if (inputAnswer == correct_answer)
                            point++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing a question: {ex.Message}");
                    }
                }

                Console.WriteLine($"Your result is : {point}/{questions.Length}");
            }
            else if (input == "2")
            {
                Console.WriteLine("Enter the question:");
                string question = Console.ReadLine();
                Console.WriteLine("Now Enter 4 answers. If the correct answer, mark it with '*' symbol at the end.");
                Console.WriteLine("Enter answer1:");
                string answer1 = Console.ReadLine();
                Console.WriteLine("Enter answer2:");
                string answer2 = Console.ReadLine();
                Console.WriteLine("Enter answer3:");
                string answer3 = Console.ReadLine();
                Console.WriteLine("Enter answer4:");
                string answer4 = Console.ReadLine();
                string fullQuestion = $"{questions.Length + 1}){question}|a){answer1}|b){answer2}|c){answer3}|d){answer4}";

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    try
                    {
                        writer.WriteLine(fullQuestion.Trim());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error writing the new question: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}