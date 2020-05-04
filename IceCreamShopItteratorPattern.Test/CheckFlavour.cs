using System;
using IceCreamShopItteratorPattern;
using Xunit;

namespace IceCreamShopItteratorPattern.Test
{
    public class CheckFlavour
    {
        
        [Theory]
        [InlineData("Chocolate","Chocolate")]
        [InlineData("Strawberry","Strawberry")]
        [InlineData("Vanilla","Vanilla")]
        [InlineData("Black Current","Black Current")]
        [InlineData("Cola","Cola")]

        public void CheckTheIceCreamFlavour(String Flavour,String Output){

            IceCream iceCream = new IceCream(Flavour);
            Assert.Equal(iceCream.Flavor,Output);
           }
   
   
    }
}
