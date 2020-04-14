using System;
using System.Collections;
namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            ArrayList array = new ArrayList();
            int count=0;
            Console.WriteLine("Enter the no of Elements");  
            int total = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter the numbers in the array");

            for(int i=0;i<total;i++)
            {
                               
                array.Add(Convert.ToInt16(Console.ReadLine()));
            }

            Console.WriteLine("Enter the sum of the number to be found");
            int Sum =Convert.ToInt16(Console.ReadLine());
            
            for(int i=0;i<total-1;i++)
              for(int j= i+1;j<total;j++)
              {    
                  int first = Convert.ToInt16(array[i]);
                  int next =  Convert.ToInt16(array[j]);
                  if((first + next)  == Sum)
                  {
                      Console.WriteLine("Pair Found At Index " + i +" and "+ j + "(" + array[i] +"+"+ array[j]+")");
                      count++;
                  }

              }
        
            if(count == 0)
            {
                Console.WriteLine("No pairs found !!");
            } 

              
        }
    }
}
