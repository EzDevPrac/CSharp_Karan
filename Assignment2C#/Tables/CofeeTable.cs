using System;

namespace Tables
{
    public class CofeeTable : Tables
    {

        public CofeeTable(int b,int w) : base(b,w){}
        public override void ShowData(){
            
            Console.WriteLine("Breadth = " + breadth.ToString() +" , Width = " + width.ToString() + " (CofeeTable)");

        }
    }
}