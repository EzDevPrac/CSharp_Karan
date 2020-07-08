using System;
using PolymorohismDemo;
namespace PolymorohismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition add = new Addition();
            
            Console.WriteLine(add.AddNumbers(1,2));
            Console.WriteLine(add.AddNumbers(1,2,3));
        }
    }

    
    public class Addition
    {
        public int AddNumbers(int number1, int number2)
        {
            return (number1 + number2);
        }

        public int AddNumbers(int number1,int number2,int number3)
        {             
            return  (number1+number2+number3);
        }
    }
}
