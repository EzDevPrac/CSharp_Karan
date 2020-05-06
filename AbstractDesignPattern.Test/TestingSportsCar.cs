using System;
using Xunit;
using AbstractDesignPattern;
namespace AbstractDesignPattern.Test
{
    public class TestingSportsCar
    {
      SportsCar _SportsCar = new SportsCar("Ducati M4","320","Automatic");

      [Fact]
      public void CheckSportsCarNameAsDucatiM4()
      {
       Assert.Equal("Sports Car Name :Ducati M4",_SportsCar.Name);
      } 
      
      [Fact]
      public void CheckSportsCarMilageAs320KMPH()
      {
        Assert.Equal("Sports Cars Milage :320 Kmph",_SportsCar.Milage);
      }  
      
      [Fact]
      public void CheckSportsCarTransmissionTypeAsAutomatic()
      {

          Assert.Equal("Transmission :Automatic",_SportsCar.Transmission);
      } 
        
    }
}
