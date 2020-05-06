using System;

namespace AbstractDesignPattern
{
    //Concrete factory 1
class BmwVehicles : VehicleFactory
{
 public TwoWheeler GetTwoWheeler(string TwoWheeler)
 {
 switch (TwoWheeler)
 {
 case "Sports":
              
              return new SportsBike();
              
 case "Regular":
             string name = "Bmw X Series";
             string Milage = "123";
             return new RegularBike(name,Milage);
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
