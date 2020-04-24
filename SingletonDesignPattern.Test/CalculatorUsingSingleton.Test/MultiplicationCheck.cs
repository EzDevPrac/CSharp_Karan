using System;
using Xunit;
using CalculatorUsingSingleton;

namespace CalculatorUsingSingleton.Test
{
   
    public class MultiplicationCheck{

    Calculate Numbers = Calculate.Instance;
    [Fact]
    public void MultiplyingSevenAndTwoGivesFourteen()
    {
          
           
            Numbers.FirstNumber=7;
            Numbers.SecondNumber=2;

            Assert.Equal(14,Numbers.Multiply());
               
    }
    [Theory]
    [InlineData(4,3,12)]
    [InlineData(10,10,100)]
    [InlineData(10,3,30)]
    [InlineData(12,3,36)]

    public void CheckTheMultiplicationMethod(double number1,  double number2, double Solution){
     Numbers.FirstNumber=number1;
     Numbers.SecondNumber=number2;

     Assert.Equal(Solution,Numbers.Multiply());


    }

    } 
}
