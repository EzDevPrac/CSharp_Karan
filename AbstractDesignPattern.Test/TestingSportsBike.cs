using System;
using Xunit;
using AbstractDesignPattern;
namespace AbstractDesignPattern.Test
{
    public class TestingSportsBike
    {

        SportsBike _sportsBike = new SportsBike();

        [Fact]
        public void TestTheSportsBikeNameAsBmwZXtreamSeries()
        {
        _sportsBike.Name = "BMW Z Xtream Series";
        Assert.Equal("Sports Bikes Name is : BMW Z Xtream Series",_sportsBike.Name);
        }

        [Fact]
        public void TestTheSportsBikeMilageAs250()
        {   
            _sportsBike.Milage = "250 Kmph";
            Assert.Equal("Sports Bikes Milage is : 250 Kmph",_sportsBike.Milage);
             
        }

    }
}
