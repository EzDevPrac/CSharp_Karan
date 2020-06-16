using System;
namespace RectangleSquare
{
    public class Circle : Shape
    {
        protected double Radius;

        
        public double _Radius{

            get{return Radius;}
            set{Radius = value;}
        }
        public override double Area(){

            return 3.14 * Radius * Radius;
        }
        
        public override double Perimeter(){
            return 2*3.14*Radius;
        }

        public override string ToString(){

           return "Area: " +  Area().ToString() +  "\n" + "Perimeter: " +  Perimeter().ToString();
    
        
        } 


    }
}