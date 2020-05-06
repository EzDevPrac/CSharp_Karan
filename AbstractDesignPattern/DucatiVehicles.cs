using System;

namespace AbstractDesignPattern
{
    //Concrete factory 2
class DucatiVehicles : VehicleFactory
{
 public TwoWheeler GetTwoWheeler(string TwoWheeler)
 {
 switch (TwoWheeler)
 {
 case "Sports":return new SportsBike();
 case "Regular":
               string name= "Ducati C Class";
               string milage =  "321";
               return new RegularBike(name,milage);
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", TwoWheeler));
 }
}
public FourWheeler GetFourWheeler(string FourWheeler)
 {
 switch (FourWheeler)
 {
 case "Sports":
             string name = "Ducati Z Series";
             string Milage = "324";
             string Transmission = "Automatic";
             return new SportsCar(name,Milage,Transmission);
 case "Regular":
 return new RegularCar();
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", FourWheeler));
 }

 }
}
    
}
