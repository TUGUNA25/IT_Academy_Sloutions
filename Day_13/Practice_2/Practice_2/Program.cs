using Practice_2;
using System.Numerics;

Console.WriteLine
($@"
Hello,there is all type of transports, 
you can choose the one you want:
1_{AllVehicle.Combat}
2_{AllVehicle.Commeercial}
3_{AllVehicle.PublicTransport}
4_{AllVehicle.SportCar}
Just Enter the appropriate transport number
");
int input = int.Parse(Console.ReadLine());
switch (input) {

    case 1:
        Combat combat1 = new Combat();
        Console.WriteLine(combat1.ToString());
        break;
    case 2:
        Commeercial commeercial1 = new Commeercial();
        Console.WriteLine(commeercial1.ToString());
        break;
    case 3:
        PublicTransport publicTransport1 = new PublicTransport();
        Console.WriteLine(publicTransport1.ToString());
        break;
    case 4:
        SportCar sportCar1 = new SportCar();
        Console.WriteLine(sportCar1.ToString());
        break;
    default:
        Console.WriteLine("Wrong Input");
        break;
}