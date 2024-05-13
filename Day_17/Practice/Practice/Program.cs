
//N1
using Practice;

static bool IsBalance(string test)
{
    bool valid = true;
    Stack<char> stack1 = new Stack<char>();
    Dictionary<char, char> dict = new Dictionary<char, char>();
    dict.Add('(', ')');
    dict.Add('{', '}');
    dict.Add('[', ']');

    foreach (var item in test)
    {
        if (dict.ContainsKey(item))
        {
            stack1.Push(dict[item]);
        }
        else { 
            if (stack1.Count == 0|| item != stack1.Pop()) { 
                valid = false;
                break;
            }
            
        }
    }
    return valid&&stack1.Count == 0;

}

//N2

static double PointCalculations((double,double) point1, (double, double) point2) {

    return Math.Sqrt(Math.Pow(point2.Item1-point1.Item1,2)+ Math.Pow(point2.Item2 - point1.Item2, 2));
}

//3

static (double pow2, double pow3, double pow4) Pow234(int element)
{
    return (Math.Pow(element, 2), Math.Pow(element, 3), Math.Pow(element, 4));
}



//4
List<Book> books = new List<Book> {
    new Book("Author1", "Title1", "BookName1", 2020, 123456, Genre.Fiction),
    new Book("Author2", "Title2", "BookName2", 2018, 789012, Genre.Romance),
    new Book("Author3", "Title3", "BookName3", 2021, 345678, Genre.Mystery),
    new Book("Author4", "Title4", "BookName4", 2015, 901234, Genre.Poetry),
    new Book("Author5", "Title5", "BookName5", 2019, 567890, Genre.Horror),
};

//books.Sort(new ReleaseYearComparer());
//foreach (var item in books)
//{
//    Console.WriteLine(item.ToString());
//}

Console.WriteLine(Pow234(2));