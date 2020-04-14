using System;
using System.Collections;
namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int j,count=0;
            ArrayList array = new ArrayList();
            ArrayList newArray = new ArrayList();
            Console.WriteLine("Enter the no of Elements");  
            int total = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter the numbers in the array");

            for(int i=0;i<total;i++)
            {
                               
                array.Add(Convert.ToInt16(Console.ReadLine()));
            }

            Console.WriteLine("Enter the sum of the number to be found");
            int Sum =Convert.ToInt16(Console.ReadLine());
            newArray=array;
            array.Sort();
            j=0;  
            int first = Convert.ToInt16(array[j]);           
            while(first < Sum){

              for(int i = j+1;i<total;i++){
                  if(first + Convert.ToInt16(array[i]) == Sum ){

                    Console.WriteLine("Pair Found At Index " + newArray.IndexOf(array[first]) +" and "+ newArray.IndexOf(array[i]) + "(" + array[first] +"+"+ array[i]+")");
                    count++;
                  }
              }
              j++;
              first = Convert.ToInt16(array[j]);
             }
              if(count == 0)
              {
                Console.WriteLine("No pairs Found");
              }
              
        }

    }
}
