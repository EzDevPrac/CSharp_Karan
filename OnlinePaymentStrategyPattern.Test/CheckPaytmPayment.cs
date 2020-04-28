using System;
using OnlinePaymentStrategyPattern;
using Xunit;


namespace OnlinePaymentStrategyPattern.Test
{
    public class CheckPaytmPayment
    {
        [Theory]
        [InlineData("karan kumar",1000,"karan kumar , your  final payable amount is 1040")]
        [InlineData("Harshitha",1500,"Harshitha , your  final payable amount is 1560")]
        [InlineData("Riya",2000,"Riya , your  final payable amount is 2080")]
        [InlineData("Rahul Yadav",2500,"Rahul Yadav , your  final payable amount is 2600")]
        [InlineData("Siddharth",500,"Siddharth , your  final payable amount is 520")]
        public void checkThePaytmPaymentMethod(string name,double amount,string output)
        {
          PayTm paytm = new PayTm();
          string answer = paytm.MakePayment(name,amount);

          Assert.Equal(answer,output);

        }

    }
}
