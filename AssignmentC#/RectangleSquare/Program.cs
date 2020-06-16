using System;

namespace RectangleSquare
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle _rectangle = new Rectangle();
            _rectangle.Length =10;
            _rectangle.Breadth = 20;


            _rectangle.Area();
            _rectangle.Perimeter();
            Console.WriteLine(_rectangle.ToString());
            
            Circle _circle = new Circle();
            _circle._Radius = 10;
            _circle.Area();
            _circle.Perimeter();
            Console.WriteLine(_circle.ToString());
            
        }
    }
}
