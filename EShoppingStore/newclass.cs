using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public static class newclass
    {   
        private static List<Customer> _Customer = new List<Customer>();
        
        private static  MarketingStaff mp = new MarketingStaff();
        public static void createAccount(){
         CreditCard cc = new CreditCard();
         Customer newCustomer = new Customer();
 
         Console.WriteLine("Enter the name");  
         string customerName = Console.ReadLine();
         Console.WriteLine("Enter the Mobile Number");
         string customerMobileNumbre = Console.ReadLine();
         Console.WriteLine("Enter the Address");
         string address = Console.ReadLine();
         Console.WriteLine("Enter the Email Address");
         string email = Console.ReadLine();
         Console.WriteLine("Enter the credit card Details");
         Console.WriteLine("Enter the card Number");
         cc._CardNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the card holder name");
         cc._CardHolderName = Console.ReadLine();
         newCustomer = new Customer(customerName,customerMobileNumbre,email,address,cc);
         _Customer.Add(newCustomer); 
         Console.WriteLine("Account created..............");        

        }

       public static void LoginToAccount(string name,string MobileNumber)
       {  int success =0;
           foreach(var c in _Customer)
           {
               if(c._Name == name && c._PhoneNumber == MobileNumber)
               {
                   
                   Console.WriteLine("Logged in succesfully");
                   success = 1;
                   mp.CustomerOptions(c._Name);
                   
               }
               
         
           }
           if(success == 0)
           {
              Console.WriteLine("Account doesnot exist , Please create one account");
           }              

       }

        


    }
}