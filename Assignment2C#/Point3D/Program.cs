using System;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3d[] points = new Point3d[5];
            points[0] = new Point3d(5, 7, -2);
            points[1] = new Point3d(-5, -7, -2);
            //points[2] = new Point3d(6, 7, 8);
            //points[3] = new Point3d(5,7,8);
            //points[4] = new Point3d(2,9,8);  
            
            
            Console.WriteLine("Distance from Point 1 to Point 2 is : " + points[0].DistanceTo(points[1]));
          
          
            //Console.WriteLine("Distance from Point 1 to Point 3 is : " + points[0].DistanceTo(points[2]));

            //Console.WriteLine("Distance from Point 1 to Point 4 is : " + points[0].DistanceTo(points[3]));

            
            //Console.WriteLine("Distance from Point 1 to Point 5 is : " + points[0].DistanceTo(points[4]));
        }
    }
}
