using System;
using Xunit;
using SportsShopObserverPattern;

namespace SportsShopObserverPattern.Test
{
    public class CheckShop
    {
        [Theory]
        [InlineData("Bat",1000,"Bat")]
        [InlineData("Ball",350,"Ball")]
        [InlineData("Stumps",500,"Stumps")]
        [InlineData("Caps",250,"Caps")]

        public void CheckShopItems(String ItemName,int ItemCost, string Answer)
        {
               CricketItems cricketItems = new CricketItems(ItemName,ItemCost);
               Assert.Equal(cricketItems.ItemName,Answer);

        }
        
        [Theory]
        [InlineData("Bat",1000,1000)]
        [InlineData("Ball",350,350)]
        [InlineData("Stumps",500,500)]
        [InlineData("Caps",250,250)]
        public void CheckShopItemsCost(String ItemName,int ItemCost, int  Answer)
        {
            CricketItems cricketItems = new CricketItems(ItemName,ItemCost);
            Assert.Equal(cricketItems.ItemCost,Answer);
        }
    }
}
