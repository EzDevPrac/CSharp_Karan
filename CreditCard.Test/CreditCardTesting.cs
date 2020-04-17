using Xunit;
using CreditCard;

namespace CreditCard.Test
{
    
    public class CreditCardTesting
    {

        
        [Fact]
    public void WhenInputIsPlaninumTestCase()
    {
    PlatinumCreditCard cType = new PlatinumCreditCard(10000,10);
    Assert.Equal("Platinum",cType.CardType);
    
    }

    [Fact]
    public void CheckPlatinumCardLimit()
    {  

    PlatinumCreditCard cType = new PlatinumCreditCard(10000,10);
    Assert.Equal(10000,cType.CreditLimit);
    
    }

    [Fact]
    public void WhenInputIsNotPlaninum()
    { 
    PlatinumCreditCard cType = new PlatinumCreditCard(20000,10);
    Assert.NotEqual("Silver",cType.CardType);

    }
    [Fact]
    public void WhenInputIsTitaniumTestCase()
   { 
    TitaniumCreditCard cType = new TitaniumCreditCard(20000,10);
    Assert.Equal("Titanium",cType.CardType);

   }


  }
}

