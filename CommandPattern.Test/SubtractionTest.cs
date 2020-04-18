using System;
using CommandPattern;
using Xunit;

namespace CommandPattern.Test
{
    

public class SubtractionTest{
[Fact]
        public void SubtractionOfFiveAndThreeShouldGiveTwo()
        {

            Calculator Sub =new Calculator(5,3);
            Assert.Equal(2,Sub.Substract());
        }
[Theory]
        [InlineData(5,3,2)]
        [InlineData(2,1,1)]
        [InlineData(2,10,-8)]

        public void AddTwoNumber(int Number1,int Number2,int Solution){

            Calculator Subtraction = new Calculator(Number1,Number2);

           

            Assert.Equal(Solution,Subtraction.Substract());

        }

 
        



}
}