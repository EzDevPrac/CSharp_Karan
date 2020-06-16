using System;
namespace Square
{
    public class Location
    {
      private double x;
      private double y;


     public Location(double _x,double _y)
     {
         x = _x;
         y = _y;
     }
      public double xCordinate{

          get {return x;}
          set{x = value;}
      }

      public double yCoordinate{

          get{ return y;}
          set{ y= value;}
      }
  
    }
}