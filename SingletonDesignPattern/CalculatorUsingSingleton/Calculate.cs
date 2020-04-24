using System;

namespace CalculatorUsingSingleton
{
    public sealed class Calculate  
    {  private Calculate()  
        {  
        }  
        private static Calculate instance = null;  
        public static Calculate Instance  
        {  
            get  
            {  
                if (instance == null)  
                {  
                    instance = new Calculate();  
                }  
                return instance;  
            }  
        }  
        public double FirstNumber{ get; set; }  
        public double SecondNumber { get; set; }  
        public double Add()  
        {  
            return FirstNumber + SecondNumber;  
        }  
        public double Subtract()  
        {  
            return FirstNumber - SecondNumber;  
        }  
        public double Multiply()  
        {  
            return FirstNumber * SecondNumber;  
        }  
  
    }  
} 

