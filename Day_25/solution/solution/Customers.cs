
namespace solution
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public Customers(int id,string name)
        {
            CustomerID = id;
            CustomerName = name;
        }
    }
}
