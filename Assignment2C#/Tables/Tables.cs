using System;

namespace Tables
{
    public class Tables
    {

        public int breadth;
        public int width;

        public Tables(int Breadth,int Width)
        {
            breadth = Breadth;
            width = Width;
        }

        public virtual void ShowData()
        {
          Console.WriteLine("Breadth = " + breadth.ToString() +" , Width = " + width.ToString());

        }
        
    }
}