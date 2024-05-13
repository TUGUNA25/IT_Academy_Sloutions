using System.Text;

namespace solution
{
     class Country : GeographicEntity
    {
        static public List<Country> allcountry = new List<Country>();

        private List<City> Belongcity = new List<City>();

        private double Area = 0;
        private int NumberOfPopulation;


        public Country(string name, List<City> belongcity) : base(name)
        {
           Belongcity=belongcity;
           foreach(City city in Belongcity) {
                Area = Area + city.Area;
                NumberOfPopulation = NumberOfPopulation+ city.NumberOfPopulation;
            }
 

        }


        public static void ShowAll()
        {
            Console.WriteLine("There Is All Country");
            Console.WriteLine("Choose One");
            foreach (var item in allcountry)
            {
                Console.WriteLine(item.Name);
            }
        }

        public override void ShowInstance()
        {
            string cityes = "";
            foreach (City city in Belongcity) {
                if (city.Capital)
                    cityes = cityes + city.Name + "(IsCapital)" + ",";
                else
                    cityes = cityes + city.Name + ",";
            }
            string answer = $"Country:{Name}-Area:{Area}-Population:{NumberOfPopulation}-City's:{cityes}";
            Console.WriteLine(answer.Substring(0,answer.Length-1));
        }
    }
}
