using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("-------------------------------List Of vehicles--------------------------------------------");  
    var Bus = new VehicleCreator(new Bus());  
    Bus.CreatVehicle();
    Bus.displayVehicle();
    Console.WriteLine("\n");
    var MiniVan = new VehicleCreator(new MiniVan());  
    MiniVan.CreatVehicle();
    MiniVan.displayVehicle();
        }
    }
}
