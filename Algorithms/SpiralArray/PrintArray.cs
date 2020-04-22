using System;

namespace SpiralArray
{
    class PrintArray
    {
        static void PrintSpiralArray(int RowEnd, int ColoumnEnd, int[,] array) 
    { 
        int i, RowStart = 0, ColoumnStart = 0; 
        while (RowStart < RowEnd && ColoumnStart < ColoumnEnd) { 
            // Print the first row  
             
            for (i = ColoumnStart; i < ColoumnEnd; ++i) { 
                Console.Write(array[RowStart, i] + " "); 
            } 
            RowStart++; 
  
            // Print the last column  
             
            for (i = RowStart; i < RowEnd; ++i) { 
                Console.Write(array[i, ColoumnEnd- 1] + " "); 
            } 
            ColoumnEnd--; 
  
            // Print the last row   
              
            if (RowStart < RowEnd) { 
                for (i = ColoumnEnd - 1; i >= ColoumnStart; --i) { 
                    Console.Write(array[RowEnd - 1, i] + " "); 
                } 
                RowEnd--; 
            } 
  
            // Print the first column   
            if (ColoumnStart< ColoumnEnd) { 
                for (i = RowEnd - 1; i >= RowStart; --i) { 
                    Console.Write(array[i, ColoumnStart] + " "); 
                } 
                ColoumnStart++; 
            } 
        } 
    } 
  
    // Driver program 
    public static void Main() 
    { 
        int[,] array = new int[10,10]; 

        Console.WriteLine("Enter the number of rows");
        int Row = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the number of Column");
        int Coloumn = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the array elements");
        for(int i=0;i<Row;i++)
         {for(int j=0;j<Coloumn;j++)
          {
              array[i,j]=Convert.ToInt16(Console.ReadLine());
              }
          
         }  
        
        PrintSpiralArray(Row, Coloumn, array); 
    } 
} 
}

