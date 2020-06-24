using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class Program
   {    
           
       public static void Main(string[] args)
        {  
            int choice =0;
                            
            while(choice<3){
                  
            Console.WriteLine("---Welcome to E-Shopping---");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Create Account");
            Console.WriteLine("3.Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                   case 1:
                          Console.WriteLine("Name:"); 
                          string name = Console.ReadLine();
                          Console.WriteLine("Mobile Number");
                          string number = Console.ReadLine();
                           
                           newclass.LoginToAccount(name,number);
                           break;
                   case 2: 
                           
                           newclass.createAccount();                           
                           break;
                   default: Console.WriteLine("Thank You");
                   break;


            }

            }
        }
    }
}
