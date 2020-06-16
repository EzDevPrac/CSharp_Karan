using System;
namespace Vehicle
{
    public class MiniVan : IVehicleBuilder
    {
         Vehicle vehicle = new Vehicle();

        public void SetType(){
            vehicle.Type = "Mini Van";
        }
        
        public void SetNoOfTyres(){
           vehicle.NoOfTyres = 8;

        }

        public void SetColour(){
            vehicle.color = "red";
        }

        public string doors(){
            
            return "Has double sliding doors";

        }

        public void Display(){
        
        Console.WriteLine("Type:" + vehicle.Type);
        Console.WriteLine("No of Tyres :" + vehicle.NoOfTyres);
        Console.WriteLine("Colour : " + vehicle.color);
        Console.WriteLine("Mini Van " + doors() );
        }
    }
    
}