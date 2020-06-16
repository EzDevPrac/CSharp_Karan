using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {   
            Square square = new Square(new Location(10,7),10);
            square._Side = 10;
            
            Console.WriteLine(square.ToString());
            square.move(3,4);
            Console.WriteLine(square.ToString());
            square.Scale(3);
            Console.WriteLine(square.ToString());
            
        }
    }
}
