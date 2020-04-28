using System;
using OnlinePaymentStrategyPattern;
using Xunit;


namespace OnlinePaymentStrategyPattern.Test
{
    public class CheckPhonePayPayment
    {
        [Theory]
        [InlineData("karan kumar",1000,"karan kumar , your  final payable amount is 1020")]
        [InlineData("Harshitha",1500,"Harshitha , your  final payable amount is 1530")]
        [InlineData("Riya",2000,"Riya , your  final payable amount is 2040")]
        [InlineData("Rahul Yadav",2500,"Rahul Yadav , your  final payable amount is 2550")]
        [InlineData("Siddharth",500,"Siddharth , your  final payable amount is 510")]
        public void checkTheGooglePayPaymentMethod(string name,double amount,string output)
        {
          PhonePe phonepay = new PhonePe();
          string answer = phonepay.MakePayment(name,amount);

          Assert.Equal(answer,output);

        }

    }
}
