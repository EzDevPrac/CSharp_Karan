using System;
using ProxyDesignPattern;
using Xunit;

namespace ProxyDesignPattern.Test
{
    public class CheckBankAccountDetails
    {
        Bank _Bank = new Bank();
        
        [Theory]
        [InlineData(0,"Your Balance is Zero , You cannot withdraw anything....\n")]
        public void CheckTheWithdrawAmmount(int Ammount,String Output)
        {
            string _Amount = _Bank.Withdraw(Ammount);
            Assert.Equal(_Amount,Output);
        }

        [Theory]
        [InlineData("KK1234","KK1234")]
        [InlineData("KK3456","KK3456")]
        [InlineData("KK4536","KK4536")]

        public void CheckAccountNumber(string _AccountNumber,string Output)
        {
           _Bank.AccountNumber = _AccountNumber;
           Assert.Equal(_Bank.AccountNumber,Output);     
               
        }

        [Theory]
        [InlineData("Karan Kumar","Karan Kumar")]
        [InlineData("Raju","Raju")]
        [InlineData("Shashank","Shashank")]

        public void CheckAccountHolderName(string _AccountHolderName,string Output)
        {
           _Bank.AccountHolderName = _AccountHolderName;
           Assert.Equal(_Bank.AccountHolderName,Output);     
               
        }


    }
}
