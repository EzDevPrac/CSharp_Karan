using System;
using OnlinePaymentStrategyPattern;
using Xunit;


namespace OnlinePaymentStrategyPattern.Test
{
    public class CheckGooglePayPayment
    {
        [Theory]
        [InlineData("karan kumar",1000,"karan kumar , your  final payable amount is 1050")]
        [InlineData("Harshitha",1500,"Harshitha , your  final payable amount is 1575")]
        [InlineData("Riya",2000,"Riya , your  final payable amount is 2100")]
        [InlineData("Rahul Yadav",2500,"Rahul Yadav , your  final payable amount is 2625")]
        [InlineData("Siddharth",500,"Siddharth , your  final payable amount is 525")]
        public void checkTheGooglePayPaymentMethod(string name,double amount,string output)
        {
          GooglePay googlepay = new GooglePay();
          string answer = googlepay.MakePayment(name,amount);

          Assert.Equal(answer,output);

        }

    }
}
