using System;
namespace Vehicle
{
    public class Bus:IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();

        public void SetType(){
            vehicle.Type = "Bus";
        }
        
        public void SetNoOfTyres(){
           vehicle.NoOfTyres = 10;

        }

        public void SetColour(){
            vehicle.color = "Blue";
        }

        public void Display(){
        
        Console.WriteLine("Type:" + vehicle.Type);
        Console.WriteLine("No of Tyres :" + vehicle.NoOfTyres);
        Console.WriteLine("Colour : " + vehicle.color);
        }
    }
}