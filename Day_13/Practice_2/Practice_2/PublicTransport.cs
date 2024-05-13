using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    enum AllPublicTransport {
        Bus=1,
        Tram
    }
    internal class PublicTransport : Vehicle
    {
        public bool TicketingSystem { get; set; }

        public PublicTransport() : base() {

            Console.Write("Enter Information About TicketingSystem only True/False : ");
            TicketingSystem = bool.Parse(Console.ReadLine());
        }

    public override void ShowAll()
        {
            Console.WriteLine($@"
You can have this models:
1_{AllPublicTransport.Bus}
2_{AllPublicTransport.Tram}
Just Enter the appropriate model number
");
        }


        public override string ToString()
        {
            return $@" 
You Choose Public Trasport {(AllPublicTransport)Type}
Model:{Model}, with MaxSpeed:{MaxSpeed}, Cost:{Cost},
Capacity:{Capacity} and TicketingSystem:{TicketingSystem}";
        }
    }


}
