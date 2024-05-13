using solution;
using System.Linq;

try
{
    string path = @"C:\Users\Lenovo\Documents\TBC\Day_20\solution\solution\Cities.txt";
    var arr = File.ReadAllLines(path);

    foreach (var item in arr)
    {
        City.allcity.Add(new City(
            area: double.Parse(item.Split("|")[1]),
            numberOfPopulation: int.Parse(item.Split("|")[2]),
            name: item.Split("|")[0],
            countryToBelong: item.Split("|")[4],
            capital: bool.Parse(item.Split("|")[3])
        ));
    }

    foreach (var item in arr)
    {
        bool testcheck = true;
        for (int i = 0; i < Country.allcountry.Count; i++)
        {
            if (item.Split("|")[4] == Country.allcountry[i].Name)
            {
                testcheck = false;
                break;
            }
        }
        if (testcheck)
        {
            List<City> belongs = new List<City>();
            foreach (var citys in City.allcity)
            {
                if (citys.CountryToBelong == item.Split("|")[4])
                    belongs.Add(citys);
            }
            Country.allcountry.Add(new Country(
                name: item.Split("|")[4],
                belongcity: belongs
            ));
        }
    }

    Console.WriteLine("Choose one:");
    Console.WriteLine("1. Search Country");
    Console.WriteLine("2. Search City");

    int test = int.Parse(Console.ReadLine());

    if (test != 1 && test != 2)
    {
        throw new MyExceptions.NotValidInput("Invalid input. Please choose 1 or 2.");
    }

    bool check = false;

    if (test == 1)
    {
        Country.ShowAll();
        Console.WriteLine("Choose One Of Them");
        Console.WriteLine("Input The Name Of Your Country");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !input.All(char.IsLetter))
        {
            throw new MyExceptions.NotValidCountry("Invalid country input. Please enter a valid country name.");
        }

        string upperinput = char.ToUpper(input[0]) + input.Substring(1);

        foreach (Country country in Country.allcountry)
        {
            if (country.Name == upperinput)
            {
                check = true;
                country.ShowInstance();
            }
        }
    }
    else if (test == 2)
    {
        City.ShowAll();
        Console.WriteLine("Choose One Of Them");
        Console.WriteLine("Input The Name Of Your City");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !input.All(char.IsLetter))
        {
            throw new MyExceptions.NotValidCity("Invalid city input. Please enter a valid city name.");
        }

        string upperinput = char.ToUpper(input[0]) + input.Substring(1);

        foreach (City city in City.allcity)
        {
            if (city.Name == upperinput)
            {
                check = true;
                city.ShowInstance();
            }
        }
    }

    if (!check)
    {
        throw new MyExceptions.InstanceDontExist("Instance does not exist.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("Invalid input format. Please enter a valid integer. " + ex.Message);
}
catch (MyExceptions.NotValidInput ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("Invalid input. Please choose 1 or 2. " + ex.Message);
}
catch (MyExceptions.NotValidCountry ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("Invalid country input. Please enter a valid country name. " + ex.Message);
}
catch (MyExceptions.NotValidCity ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("Invalid city input. Please enter a valid city name. " + ex.Message);
}
catch (MyExceptions.InstanceDontExist ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("Instance does not exist. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    MyExceptions.Logger("An unexpected error occurred. " + ex.Message);
}








