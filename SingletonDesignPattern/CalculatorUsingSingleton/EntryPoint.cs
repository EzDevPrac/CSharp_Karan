using System;

namespace CalculatorUsingSingleton
{
    
    class EntryPoint  
    {  
        static void Main(string[] args)  
        {  
            Calculate Numbers = Calculate.Instance;
           
            Numbers.FirstNumber=10;
            Numbers.SecondNumber=20;
            
            Console.WriteLine("Added Value is  : " + Numbers.Add());  
            Console.WriteLine("Subtracted Value is  : " + Numbers.Subtract());  
            Console.WriteLine("Multipliplied Value is  : " + Numbers.Multiply());  
              
            Console.WriteLine("\n----------------------\n");  
            
            Numbers.SecondNumber = 10;  
            Console.WriteLine("Added value is  : " + Numbers.Add());  
            Console.WriteLine("Subtracted value is : " + Numbers.Subtract());  
            Console.WriteLine("Multiplied value is  : " + Numbers.Multiply());  
              
            Console.ReadLine();  
        }  
    }  
      
      
} 

