using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class CustomerHandler : ICustomerHandler
    {
        public static List<Customer> _CustomerList = new List<Customer>();

    

         public void CreateAccount(){
         Console.WriteLine("Enter the name");  
         string Name = Console.ReadLine();
         Console.WriteLine("Enter the Mobile Number");
         string PhoneNumber = Console.ReadLine();
         Console.WriteLine("Enter the Address");
         string Address = Console.ReadLine();
         Console.WriteLine("Enter the Email Address");
         string Email = Console.ReadLine();
         Console.WriteLine("Enter the credit card Details");
         Console.WriteLine("Enter the card Number");
         int CardNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the card holder name");
         string CardHolderName = Console.ReadLine();
         
         _CustomerList.Add(new Customer(Name,PhoneNumber,Email,Address,new CreditCard(CardNumber,CardHolderName)));
         
         Console.WriteLine("Account created..............");        

        }

        public void UpdateCustomerInformation(Customer _Customer){
         int Choice = 0;
         while(Choice <= 3){
         
         Console.WriteLine("1.Change Address");
         Console.WriteLine("2.Change PhoneNumber");
         Console.WriteLine("3.Change Email Id");
         Console.WriteLine("4.Back to shopping menu");
         Choice=Convert.ToInt32(Console.ReadLine());

         switch(Choice){

             case 1 :  Console.WriteLine("Enter the New Address");
                       _Customer._Address = Console.ReadLine();
                       Console.WriteLine("Address updated successfully");
                       break;
             case 2 :  Console.WriteLine("Enter the New mobile number");
                       _Customer._PhoneNumber= Console.ReadLine();
                       Console.WriteLine("Mobile Number  updated successfully");
                       break;
             case 3 :  Console.WriteLine("Enter the New Email Id");
                       _Customer._Email = Console.ReadLine();
                       Console.WriteLine("Address updated successfully");
                       break;
            default :break;
            }

         }
        }   
        
        public void CustomerCheckout(ISalesPersonHandler SalesStaff,ICourierServiceHandler _Courier)
        {   
            char Choice; 

            Console.WriteLine("Do You Want to Checkout(Y/N)");
            Choice = Convert.ToChar(Console.ReadLine());
            
            if(Choice == 'Y')
            {
                
                 SalesStaff.CheckOutCustomer(_Courier);
                 SalesStaff.CalculateTotalAmount();
                 CartHandler.CustomerCartList.Clear();
                 
                 
            }
            if(Choice == 'N'){
               Console.WriteLine("You Can Continue Shopping");
            }
        }

    }
}