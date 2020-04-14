using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int total,count=0;
            int[] Array = new int[100];  
            Console.WriteLine("Enter the no of elements in the array");
            total = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            for(int i=0;i<total;i++)
            {
               Array[i]= Convert.ToInt16(Console.ReadLine());
             

            }
            
            Console.WriteLine("Enter the sum of the number to be found");
            int Sum =Convert.ToInt16(Console.ReadLine());
            
            for(int i=0;i<total-1;i++)
           {
            if(Array[i]<Sum)
             { for(int j= i+1;j<total;j++)
              {
                  if(Array[i]+Array[j]==Sum)
                  {
                      Console.WriteLine("Pair Found At Index " + i +" and "+ j + "(" + Array[i] +"+"+ Array[j]+")");
                      count++;
                  }

              }
             }
             else
             { 
                 continue;
             } 
           }
           if(count==0)
           {
               Console.WriteLine("No pIars Found in the given array");
           }


        }
        
    }
}


