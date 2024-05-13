namespace solution
{
    class City : GeographicEntity
    {
        static public List<City> allcity = new List<City>();
        
        public string CountryToBelong { get; set; }
        public bool Capital { get; set; }
        public double Area { get; set; }
        public int NumberOfPopulation { get; set; }
        public City(string name,double area, int numberOfPopulation,string countryToBelong, bool capital) : base(name)
        {
            CountryToBelong = countryToBelong;
            Capital= capital;
            Area= area;
            NumberOfPopulation= numberOfPopulation;
        }

        public static void ShowAll()
        {
            Console.WriteLine("There Is All City");
            Console.WriteLine("Choose One");
            foreach (var item in allcity)
            {
                Console.WriteLine(item.Name);

            }
        }

        public override void ShowInstance()
        {
            Console.WriteLine($"City:{Name}-Area:{Area}-Population:{NumberOfPopulation}-Belongs:{CountryToBelong}-IsCapital:{Capital}");
        }
    }
}
