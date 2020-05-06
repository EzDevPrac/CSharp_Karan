using System;

namespace AbstractDesignPattern
{
// The 'AbstractFactory' interface. 
public interface VehicleFactory
{
 TwoWheeler GetTwoWheeler(string TwoWheeler);
 FourWheeler GetFourWheeler(string FourWheeler);
}

}
