using Xunit;
using CreditCard;

namespace CreditCard.Test{
public class CreditCardTest
{
 [Fact]
 public void PlaninumInputTestCase()
 {
    PlatinumCreditCard cType = new PlatinumCreditCard(10000,10);
    Assert.Equal("Platinum",cType.CardType);
    
 }

 [Fact]
 public void PlaninumInputCheckLimit()
 {  

    PlatinumCreditCard cType = new PlatinumCreditCard(10000,10);
    Assert.Equal(10000,cType.CreditLimit);
    
 }

[Fact]
public void PlaninumInputTestCaseFails()
{ 
    PlatinumCreditCard cType = new PlatinumCreditCard(20000,10);
    Assert.NotEqual("Silver",cType.CardType);

}
[Fact]
public void TitaniumInputTestCase()
{ 
    TitaniumCreditCard cType = new TitaniumCreditCard(20000,10);
    Assert.Equal("Titanium",cType.CardType);

}


}
}