using System;
using Xunit;
using AbstractDesignPattern;
namespace AbstractDesignPattern.Test
{
    public class TestingRegularCar
    {
        RegularCar _RegularCar = new RegularCar();

      [Fact]
      public void CheckRegualarCarNameAsDucatiSedan()
      {
       _RegularCar.Name = "Ducati Sedan";
       Assert.Equal("Regular Car Name :Ducati Sedan",_RegularCar.Name);
      } 
      
      [Fact]
      public void CheckRegularCarMilageAs200KMPH()
      {
          _RegularCar.Milage = "200";
        Assert.Equal("Regular Cars Milage :200 Kmph",_RegularCar.Milage);
      }  
      
      [Fact]
      public void CheckRegularCarTransmissionTypeAsManual()
      {
          _RegularCar.Transmission = "Manual";
          Assert.Equal("Transmission :Manual",_RegularCar.Transmission);
      } 
}
}
