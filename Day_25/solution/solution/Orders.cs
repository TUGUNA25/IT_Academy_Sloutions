
namespace solution
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int CustomerID { get; set; }

        public Orders(int id,string date, string product, double price, int custumerid)
        {
            OrderId = id;
            Date = date;
            Product = product;
            Price = price;
            CustomerID = custumerid;
        }
    }
}
