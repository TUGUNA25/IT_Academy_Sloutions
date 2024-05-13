using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    enum AllCombat {
        Tank=1,
        Beteer
    }
     class Combat : Vehicle
    {
        public string ArmourType { get; set; }

        public Combat() : base()
        {
            
            Console.Write("Enter ArmourType: ");
            ArmourType = Console.ReadLine();
        }

        public override void ShowAll()
        {
            Console.WriteLine($@"
You can have this models:
1_{AllCombat.Tank}
2_{AllCombat.Beteer}
Just Enter the appropriate model number
");
        }

        public override string ToString()
        {
            return $@"
You Choose Combat Trasport {(AllCombat)Type} 
Model:{Model}, with MaxSpeed:{MaxSpeed}, Cost:{Cost},
Capacity:{Capacity}, it have Armour type: {ArmourType}";
        }
    }

}
