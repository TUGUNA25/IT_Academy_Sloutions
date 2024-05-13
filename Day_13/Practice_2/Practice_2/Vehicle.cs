using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{

      public enum AllVehicle { 
        Combat=1,
        Commeercial,
        PublicTransport,
        SportCar
        
     }

    abstract class Vehicle
    {

        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Cost { get; set; }
        public int Capacity { get; set; }
        public int Type { get; set; }

        public Vehicle()
        {
            ShowAll();
            Type = int.Parse(Console.ReadLine());
            Console.Write("Enter Model:");
            Model = Console.ReadLine();

            Console.Write("Enter MaxSpeed:");
            MaxSpeed = int.Parse(Console.ReadLine());
        
            Console.Write("Enter Cost:");
            Cost = int.Parse(Console.ReadLine());

            Console.Write("Enter Capacity:");
            Capacity = int.Parse(Console.ReadLine());

        }

        public abstract void ShowAll();

       
    }

 }
    
