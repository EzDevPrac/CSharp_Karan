using System;

namespace RectangleSquare
{
    public class Rectangle : Shape
    {
        protected double Side1;
        protected double Side2;

        public double Length{
            get{return Side1;}
            set{Side1 = value;}
        }

        public double Breadth{
            get{return Side2;}
            set{Side2 = value;}
        }


        public override double Area(){

            return Side1 * Side2;
        }

        public override double Perimeter(){

            return 2*(Side1 + Side2);
        }

        public override string ToString(){

           return "Area: " +  Area().ToString() +  "\n" + "Perimeter: " +  Perimeter().ToString();
    
        
        } 


    }
}