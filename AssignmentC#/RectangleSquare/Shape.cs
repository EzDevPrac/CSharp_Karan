namespace RectangleSquare
{
    public abstract class Shape
    {
        protected Location c;
        
        public abstract new string ToString();
        public abstract double Area();
        public abstract double Perimeter();

    }
}