using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class Program
   {    
           
       public static void Main(string[] args)
        {  
            int Choice =0,CustomerChoice=0;
            
            ECommerce shopping = new ECommerce();
            
            while(Choice<=2){
            Console.WriteLine("Welcome to the Shop");
            Console.WriteLine("1:Staff");
            Console.WriteLine("2:Customer");
            Console.WriteLine("3:Exit");
            Choice = Convert.ToInt32(Console.ReadLine());
            
            switch(Choice){

            case 1: 
                    Console.WriteLine("Enter the Name"); 
                    string StaffName = Console.ReadLine();
                    Console.WriteLine("Enter the Password");
                    int Password = Convert.ToInt32(Console.ReadLine());
                           
                    int value = shopping.EmployeeLogin(StaffName,Password);
                    if(value == 1)
                    {  Console.WriteLine("1:Add Product");
                       Console.WriteLine("2:Logout");
                       int StaffChoice = Convert.ToInt32(Console.ReadLine());
                        
                       switch(StaffChoice){ 
                        case 1: shopping.StaffAddProduct();
                                break;
                        case 2 :break;
                        default :Console.WriteLine("Give a valid option");
                                  break;
                        
                        }
                    }   
                     break;    
                            
            case 2 : {
                  
                         Console.WriteLine("---Welcome to E-Shopping---");
                         Console.WriteLine("1.Login");
                         Console.WriteLine("2.Create Account");
                         Console.WriteLine("3.Exit");
                         CustomerChoice = Convert.ToInt32(Console.ReadLine());
        
                          switch(CustomerChoice)
                          {
                          case 1:
                                  Console.WriteLine("Name:"); 
                                  string name = Console.ReadLine();
                                  Console.WriteLine("Mobile Number");
                                  string number = Console.ReadLine();
                                  shopping.LoginToAccount(name,number);
                                  break;
                          case 2: 
                                  shopping.createAccount(new CreditCard());                           
                                   break;
                          default: Console.WriteLine("Thank You");
                                   break;


                            }

                        }
                        break;
            default : break;            
            }
            }
        
        
        }
    }
}
