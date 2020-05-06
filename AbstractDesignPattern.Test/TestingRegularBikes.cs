using System;
using Xunit;
using AbstractDesignPattern;
namespace AbstractDesignPattern.Test
{
    public class TestingRegularBikes
    {
        
        RegularBike _regularBike = new RegularBike("Bmw X Series","231");

        [Fact]
        public void TestTheRegulaBikeNameAsBmwXSeries()
        {
        
        Assert.Equal("Regular Bikes Name is : Bmw X Series",_regularBike.Name);
        }

        [Fact]
        public void TestTheMilageOfTheBikeAs321()
        {
            Assert.Equal("Regular Bikes Milage is : 231 Kmph",_regularBike.Milage);
             
        }

        
    }
}
