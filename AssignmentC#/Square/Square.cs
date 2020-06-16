using System;

namespace Square
{
    public class Square : Shapes
    {
        protected  double side;

        public double _Side{
            get{return side;}
            set{side =value;}
        }
        public Location _c;
        public Square(Location c , double _side)
        {
                 side = _side;
                 _c = c;

        }

        public void move(double x,double y){
            _c.xCordinate =x;
            _c.yCoordinate =y;
        }

        public double Scale(int factor)
        {
            side = side*factor;
             
             return side;
        }

        public override double GetArea(){

            return side * side;
        }

        public override double GetPerimeter(){

            return 4*side;
        }

        public override string ToString(){

           return "Corner : (" + _c.xCordinate.ToString() + "," + _c.yCoordinate.ToString() + ") , Side " + side.ToString();   
    
        
        } 

  
    }
}