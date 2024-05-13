using solution;


class Program {
    public delegate void LogMessage(string message);
    public delegate decimal MathOperation(decimal element1, decimal element2);
    public delegate bool Validator(Book book);



    static void Main(String[] args)
    {
        //1
        LogMessage logger = ForConsole;
        logger += ForFile;

        logger("test1");

        //2
        MathOperation sum = (e1, e2) => e1 + e2;
        MathOperation subtract = (e1, e2) => e1 - e2;
        MathOperation multiplication = (e1, e2) => e1 * e2;
        MathOperation division = (e1, e2) => e1 / e2;

        MathOperation mydel = sum+subtract+multiplication;
        // am shemtxvevashi dabewdvas azri ar aqvs radganac mocemuli delegate chain daabrunebs 
        // mxolod bolo gadacemuli metodis pasuxs anu gamravleba am shemtxvavashi


        //3
        Book book1 = new Book
        {
            Title = "SampleBook32",
            Author = "JohnDoe",
            ISBN = "123456789012",
            Publisher = "ABC Publishing",
            PublicationDate = new DateTime(2020, 1, 1),
            Genre = Genre.Fiction,
            NumberOfPages = -3,
            IsAvailable = true,
            Price = 19.99m
        };
        Func<Book, bool> validTitle = (book) => (1 < book.Title.Length && book.Title.Length < 225 && book.Title.All(char.IsLetter)&& !String.IsNullOrEmpty(book.Title));
        Func<Book, bool> validAuthor = (book) => (3 < book.Author.Length && book.Author.Length < 128 && book.Author.All(char.IsLetter) && !String.IsNullOrEmpty(book.Author));
        Func<Book, bool> validISBN = (book) => (book.ISBN.Length < 13 && book.ISBN.All(char.IsNumber));
        Func<Book, bool> validPublisher = (book) => (!String.IsNullOrEmpty(book.Publisher) && book.Publisher.Length > 2 && book.Publisher.Length < 64);
        Func<Book, bool> validPublicationDate = (book) => (book.PublicationDate < DateTime.Now);
        Func<Book, bool> validGenre = (book) => (Array.IndexOf(Enum.GetValues(typeof(Genre)),book.Genre) != -1);
        Func<Book, bool> validNumberOfPages = (book) => (book.NumberOfPages > 0);
        Func<Book, bool> validPrice = (book) => (book.Price > 0);

        Validator MainValidator = delegate (Book book)  // mtavari validatori
        {
            return validTitle(book) && validAuthor(book) && validISBN(book) && validPublisher(book)
             && validPublicationDate(book) && validGenre(book) && validNumberOfPages(book)
             && validPrice(book);
        };

        Console.WriteLine(MainValidator(book1));

        //nawili sadac ibewdreba ara validuri velebi
        Dictionary<string, Func<Book, bool>> validations = new Dictionary<string, Func<Book, bool>>();
        validations["Title"] = validTitle;
        validations["Author"] = validAuthor;
        validations["ISBN"] = validISBN;
        validations["Publisher"] = validPublisher;
        validations["PublicationDate"] = validPublicationDate;
        validations["Genre"] = validGenre;
        validations["NumberOfPages"] = validNumberOfPages;
        validations["Price"] = validPrice;

        foreach (var item in validations)
        {
            if (item.Value.Invoke(book1) == false) {
                Console.WriteLine(item.Key);
            }
        }

        //4
        List<Book> mylist = new List<Book>();
        mylist.Add(new Book
        {
            Title = "EternalEchoes",
            Author = "JaneSmith",
            ISBN = "987654321098",
            Publisher = "XYZBooks",
            PublicationDate = new DateTime(2022, 5, 15),
            Genre = Genre.Romance,
            NumberOfPages = 250,
            IsAvailable = true,
            Price = 24.99m
        });

        mylist.Add(new Book
        {
            Title = "QuantumOdyssey",
            Author = "RobertJohnson",
            ISBN = "456789012345",
            Publisher = "PegasusPublications",
            PublicationDate = new DateTime(2021, 8, 10),
            Genre = Genre.ScienceFiction,
            NumberOfPages = 300,
            IsAvailable = true,
            Price = 29.99m

        });

        mylist.Add(new Book
        {
                Title = "WhispersintheShadows",
                Author = "EmilyDavis",
                ISBN = "234567890123",
                Publisher = "SunrisePress",
                PublicationDate = new DateTime(2019, 12, 3),
                Genre = Genre.Fantasy,
                NumberOfPages = 180,
                IsAvailable = true,
                Price = 17.99m
        });

        DataPipeline<Book> dataPipeline = new DataPipeline<Book>();
        var answer = dataPipeline.fillerByGenre(mylist, Genre.Fantasy);
        foreach (var item in answer)
        {
            Console.WriteLine(item.Title);
        }
        var answe1 = dataPipeline.transform(mylist);
        foreach (var item in answe1)
        {
            Console.WriteLine(item.Title);
        }





    }
    public static void ForConsole(string message)
    {
        Console.WriteLine(message);
    }

    public static void ForFile(string message)
    {
        string path = "test.txt";
        using (StreamWriter stm = new StreamWriter(path, true))
        {
            stm.WriteLine(message);
        }
    }

    
}