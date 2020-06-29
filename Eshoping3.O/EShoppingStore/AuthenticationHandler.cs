using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class AuthenticationHandler:IAuthenticationHandler
    {
        public  int  CustomerLogin(ICustomerHandler _Customer){
         
        
        CustomerHandler._CustomerList.Add(new Customer("Karan","12345","@xyz","karnataka",null));
         Console.WriteLine("Name:"); 
        string name = Console.ReadLine();
        Console.WriteLine("Mobile Number");
        string number = Console.ReadLine();
        
           foreach(var customer in CustomerHandler._CustomerList)
           {
               if(customer._Name == name && customer._PhoneNumber == number)
               {
                   
                   Console.WriteLine("Logged in succesfully");
                   return 1;
                   
                   
               }
            }
        return 0;
        }
        public int  EmployeeLogin(MarketingPerson _MarketingStaff)
        {
             Console.WriteLine("Enter the Password");
             _MarketingStaff._Password = Convert.ToInt32(Console.ReadLine());
             if(_MarketingStaff._Name == "Karan" && _MarketingStaff._Password == 1927)
             {
                 Console.WriteLine("Loggin Successfull..");
                 return 1;
             }
             else{
                 Console.WriteLine("Invalid Credentials");
             }
         return 0;
        }
    }
}