using System.Diagnostics;

// !!!!!!!!!!!!!!!!!!!
// zust simulacias aketebs da pasuxis gamotanasac rogorc pirobashia zustad im dros andomebs
// chem magalishi yvelaze didad dasamuxti 90 procentiani ari da shesabamisad 20 wams andomebs
// !!!!!!!!!!!!!!!!!!!
namespace solution2
{
    public class ElectricCar
    {
        public int BatteryLevel { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        static void Charge(ElectricCar car)
        {
            while (car.BatteryLevel < 100)
            {
                Thread.Sleep(10000);
                car.BatteryLevel = car.BatteryLevel + 5;
            }
        }

        public static void ChargeAll(IEnumerable<ElectricCar> cars)
        {
            ElectricCar[] Cars = cars.ToArray();
            Task[] tasks = new Task[Cars.Length]; 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Start Time: {DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss")}" );
            int taskIndex = 0; 
            foreach (ElectricCar car in Cars)
            {
                tasks[taskIndex] = Task.Run(() => Charge(car)); 
                taskIndex++; 
            }
            Task.WaitAll(tasks);
            sw.Stop();
            Console.WriteLine($"End Time: {DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss")}" );
            Console.WriteLine($"Time Needed: " + sw.Elapsed.ToString(@"hh\:mm\:ss"));
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            ElectricCar car1 = new ElectricCar();
            car1.BatteryLevel = 95;
            car1.Model = "Tesla Model S";
            car1.Year = 2022;

            ElectricCar car2 = new ElectricCar();
            car2.BatteryLevel = 100;
            car2.Model = "Nissan Leaf";
            car2.Year = 2023;

            ElectricCar car3 = new ElectricCar();
            car3.BatteryLevel = 90;
            car3.Model = "Chevrolet Bolt";
            car3.Year = 2021;

            List<ElectricCar> cars = new List<ElectricCar>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            ElectricCar.ChargeAll(cars);
        }
    }
}
