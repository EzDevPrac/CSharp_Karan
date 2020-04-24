using System;
using Xunit;
using CalculatorUsingSingleton;

namespace CalculatorUsingSingleton.Test
{
   
    public class SubtractionCheck{

    Calculate Numbers = Calculate.Instance;
    [Fact]
    public void SubtractingsixAndTwoGivesFour()
    {
          
           
            Numbers.FirstNumber=6;
            Numbers.SecondNumber=2;

            Assert.Equal(4,Numbers.Subtract());
               
    }
    [Theory]
    [InlineData(2,3,-1)]
    [InlineData(10,10,0)]
    [InlineData(13,3,10)]
    [InlineData(12,3,9)]

    public void CheckTheSubtractionMethod(double number1,  double number2, double Solution){
     Numbers.FirstNumber=number1;
     Numbers.SecondNumber=number2;

     Assert.Equal(Solution,Numbers.Subtract());


    }

    } 
}
