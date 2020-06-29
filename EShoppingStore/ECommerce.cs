using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class ECommerce
    {  
        private List<Customer> _Customer;
        private MarketingStaff _MarketingStaff  = new MarketingStaff(); 

        private SalesPerson _SalesPerson = new SalesPerson();

        private Customer ShopCustomer = new Customer();

        private CourierCompany _CourierComany = new CourierCompany();
        public ECommerce(){
         _Customer  = new List<Customer>();
         _MarketingStaff.AddItems(); 
        } 
        
       public int EmployeeLogin(string name , int password)
       {
        return _MarketingStaff.StaffLogin(name,password);
       } 

       public void StaffAddProduct(){

           _MarketingStaff.Addproduct();
       }         
        
        public void createAccount(CreditCard creditCard){
         
          
 
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
         creditCard._CardNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the card holder name");
         creditCard._CardHolderName = Console.ReadLine();
         ShopCustomer = new Customer(customerName,customerMobileNumbre,email,address,creditCard);
         _Customer.Add(ShopCustomer); 
         Console.WriteLine("Account created..............");        

        }

       public void LoginToAccount(string name,string MobileNumber)
       {  
           _Customer.Add(new Customer("Karan","12345","@xyz","karnataka",null));
           int success =0;
           foreach(var customer in _Customer)
           {
               if(customer._Name == name && customer._PhoneNumber == MobileNumber)
               {
                   
                   Console.WriteLine("Logged in succesfully");
                   success = 1;
                   CustomerOptions(customer._Name);
                   
               }
               
         
           }
           if(success == 0)
           {
              Console.WriteLine("Account doesnot exist , Please create one account");
           }              

       }

       public void CustomerOptions(string name){
                      
            int choice=0;
            
            while(choice<=5){
            Console.WriteLine("name :" + name );
            Console.WriteLine("----------------------");
      
            Console.WriteLine("1.Shop");
            Console.WriteLine("2.View Cart");
            Console.WriteLine("3.Check Order status");
            Console.WriteLine("4.Change account Information");
            Console.WriteLine("5.Return Product");
            Console.WriteLine("6.Logout");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
               
             case 1:
                    _MarketingStaff. ShowItem();
                    ShopCustomer.AddToCart(_MarketingStaff);
                     
                    break;
             case 2:
                    int cartVAlue = ShopCustomer.viewCart();
                    if(cartVAlue == 1){
                    ShopCustomer.CustomerCheckout(_SalesPerson,_CourierComany);}  
                    break;
             case 3:int orderValue = _SalesPerson.ShowOrderStatus();
                    if(orderValue == 1){
                    _CourierComany.Deliver(ShopCustomer._Address);
                    }
                    break;
             case 4: 
                    ShopCustomer.ChangeAccountInfo();  
                    break;
             case 5: 
                    _SalesPerson.ReturnItem(_CourierComany);                   
                    break;      
             default:break;


            }
            }
         }  



        


    }
}