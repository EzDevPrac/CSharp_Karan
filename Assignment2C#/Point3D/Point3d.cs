using System;
namespace Point3D
{
    public class Point3d
    {
        private int x;
        private int y;
        private int z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Point3d(){}

        public Point3d(int x,int y,int z){
           MoveTo(x, y, z);
        }
        
        public void MoveTo(int _x,int _y,int _z){

            x = _x;
            y = _y;
            z = _z;

            Console.WriteLine("New Coordinates are (" + x +"," + y +", " + z +")" );
        } 

        public double DistanceTo(Point3d p2)
        { 
          return Math.Sqrt( (x - p2.X * x - p2.X) +
             (y - p2.Y * y - p2.Y) + (z - p2.Z * z - p2.Z) );
        }

        public new string ToString(){

            return "(" + x +"," + y +", " + z +")" ;
        } 

    }
}