
namespace solution
{
    public class DataPipeline<T>
    {

        public Func<IEnumerable<Book>, int, IEnumerable<Book>> fillerByPage = (elements, value) =>
        {
            var result = from b in elements
                         where b.NumberOfPages < value
                         select b;
            return result;
        };

        public Func<IEnumerable<Book>, Genre, IEnumerable<Book>> fillerByGenre = (elements, genre) =>
        {
            var result = from b in elements
                         where b.Genre == genre
                         select b;
            return result;
        };

        public Func<IEnumerable<Book>, decimal, IEnumerable<Book>> fillerByPrice = (elements, price) =>
        {
            var result = from b in elements
                         where b.Price < price
                         select b;
            return result;
        };

        public Func<IEnumerable<Book>, IEnumerable<Book>> fillerByAviable = (elements) =>
        {
            var result = from b in elements
                         where b.IsAvailable == true
                         select b;
            return result;
        };

        public Func<IEnumerable<Book>, IEnumerable<BookDto>> transform = (element) =>
        {
            var result = element.Select(book => new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                IsAvailable = book.IsAvailable,
                Price = book.Price
            });
            return result;
        };
    }
}
