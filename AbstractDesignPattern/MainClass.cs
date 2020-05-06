using System;

namespace AbstractDesignPattern
{
public class Program
{
 public static void Main(string[] args)
 {
 VehicleFactory bmw = new BmwVehicles();
 VehicleClient Bmwclient = new VehicleClient(bmw, "Regular");
 Console.WriteLine("******* BMW **********");
 Console.WriteLine(Bmwclient.GetBikeName());
 Console.WriteLine(Bmwclient.GetBikeMilage());
 
 
 
 VehicleFactory Ducati = new DucatiVehicles();
 VehicleClient Ducaticlient = new VehicleClient(Ducati, "Sports");
 
 Console.WriteLine("\n******* Ducati **********");
 Console.WriteLine(Ducaticlient.GetCarName());
 Console.WriteLine(Ducaticlient.GetCarMilage());
 Console.WriteLine(Ducaticlient.GetCarTransmission());
 
 
 Console.ReadKey();
 }
}

}
