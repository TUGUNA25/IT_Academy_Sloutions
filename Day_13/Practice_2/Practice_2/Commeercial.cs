using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    enum AllCommeercial
    {
        Sedan=1, 
        jeep, 
        motorcycle, 
        bicycle
    }
    class Commeercial : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Commeercial() : base() {
            Console.Write("Enter Numbers Of Doors: ");
            NumberOfDoors = int.Parse(Console.ReadLine());
        }

        public override void ShowAll()
        {
            Console.WriteLine($@"
You can have this models:
1_{AllCommeercial.Sedan}
2_{AllCommeercial.jeep}
3_{AllCommeercial.motorcycle}
4_{AllCommeercial.bicycle}
Just Enter the appropriate model number
");
        }

        public override string ToString()
        {
            return $@" 
You Choose Commeercial Trasport {(AllCommeercial)Type}
Model:{Model}, with MaxSpeed:{MaxSpeed}, Cost:{Cost},
Capacity:{Capacity}, NumberOfDoors:{NumberOfDoors}";
        }
    }
}
