using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{

    enum AllSportCar { 
        Formula1=1,
        Rally,
        OffRoad
    }
    internal class SportCar : Vehicle
    {
        public int AccelerationTime { get; set; }

        public SportCar() :base() {
            Console.Write("Enter Acceleration Time of car: ");
            AccelerationTime = int.Parse(Console.ReadLine());
        }

        public override void ShowAll()
        {
            Console.WriteLine($@"
You can have this models:
1_{AllSportCar.OffRoad}
2_{AllSportCar.Rally}
3_{AllSportCar.Formula1}
Just Enter the appropriate model number
");
        }
        public override string ToString()
        {
            return $@"
You Choose Public Trasport {(AllSportCar)Type} 
Model:{Model}, with MaxSpeed:{MaxSpeed}, Cost:{Cost},
Capacity:{Capacity}, with AccelerationTime{AccelerationTime}";
        }
    }
}
