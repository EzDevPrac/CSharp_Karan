using System;
using Xunit;
using CommandPattern;

namespace CommandPattern.Test
{
    public class AdditionTest
    {
       [Fact]
        public void AddOneAndTwoShouldGiveThree()
        {
         Calculator Add = new Calculator(1,2);
        
        Assert.Equal(3,Add.Add());
        }
        
        
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(5,3,8)]
        [InlineData(26,3,29)]

        public void AddTwoNumber(int Number1,int Number2,int Solution){

            Calculator Addition = new Calculator(Number1,Number2);

           

            Assert.Equal(Solution,Addition.Add());

        }
        
    

    }
}
