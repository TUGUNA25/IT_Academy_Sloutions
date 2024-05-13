namespace solution
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }   
        public decimal? Price { get; set; }
    }
}
