using System;
using Xunit;
using SportsShopObserverPattern;

namespace SportsShopObserverPattern.Test
{
    public class CheckCusomerName
    {
        [Theory]
        [InlineData("Karan","Karan")]
        [InlineData("Raju","Raju")]
        [InlineData("Shashank","Shashank")]

        public void CheckNameOfTheCustomer(String customerName,string Answer)
        {
               
               Assert.Equal(customerName,Answer);

        }
    }
}
