using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers Number1 = new ComplexNumbers(2,3);
            ComplexNumbers Number2 = new ComplexNumbers(3,4);
            ComplexNumbers Sum = new ComplexNumbers();              
            ComplexNumbers Subtract = new ComplexNumbers();
           
           Sum = Number1 + Number2;
           Subtract =Number1 - Number2;
           //Sum.AddComplexNumbers(Number1,Number2);
           //Subtract.SubtractComplexNumbers(Number1,Number2);

           Console.WriteLine(Sum.ToString());
           Console.WriteLine(Subtract.ToString());


          
           
        }
    }
}
