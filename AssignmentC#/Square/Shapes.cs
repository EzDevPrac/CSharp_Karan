using System;
namespace Square
{
    public abstract class Shapes
    {
        protected Location c;
        
        public abstract new string ToString();
        public abstract double GetArea();
        public abstract double GetPerimeter();

        
    }
}