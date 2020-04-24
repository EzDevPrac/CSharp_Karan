using System;
using Xunit;
using CalculatorUsingSingleton;

namespace CalculatorUsingSingleton.Test
{
   
    public class AdditionCheck{

    Calculate Numbers = Calculate.Instance;
    [Fact]
    public void AddingOneAndTwoGivesThree()
    {
          
           
            Numbers.FirstNumber=1;
            Numbers.SecondNumber=2;

            Assert.Equal(3,Numbers.Add());
               
    }
    [Theory]
    [InlineData(2,3,5)]
    [InlineData(10.2,10,20.2)]
    [InlineData(10,3,13)]
    [InlineData(12,3,15)]

    public void CheckTheAdditionMethod(double number1,  double number2, double Solution){
     Numbers.FirstNumber=number1;
     Numbers.SecondNumber=number2;

     Assert.Equal(Solution,Numbers.Add());


    }

    } 
}
