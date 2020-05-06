using System;

namespace AbstractDesignPattern{
// The 'Client' class 
public class VehicleClient
{
 public TwoWheeler bike;
 public FourWheeler car;

 public VehicleClient(VehicleFactory factory, string type)
 {
 bike = factory.GetTwoWheeler(type);
 car = factory.GetFourWheeler(type);
 }

 public string GetBikeName()
 {
 return bike.Name;}
 public string GetBikeMilage()
 {
     return bike.Milage;}
 public string GetCarName()
 {
 return car.Name;}
 public string GetCarMilage(){
     return car.Milage;}
public string GetCarTransmission(){

     return car.Transmission;}

}
}

