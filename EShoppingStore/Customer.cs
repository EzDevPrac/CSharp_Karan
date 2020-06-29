using System;
using System.Collections.Generic;
namespace EShoppingStore
{
    public class Customer : Person
    {
                
        private CreditCard creditCard;
        private List<Cart> _Cart = new List<Cart>();
        
      
        public Customer(){}
        public Customer(string name,string mobileNumber,string email,string Adress,CreditCard creditCard)
        {
              this._Name = name;
              this._PhoneNumber = mobileNumber;
              this._Email = email;
              this._Address = Adress;
              this.creditCard = creditCard;
              
        }

        public CreditCard _CreditCard { get => _CreditCard; set => _CreditCard = value; }
        
      
        public void AddToCart(MarketingStaff _MarketingStaff)
        {   Console.WriteLine("Enter the Item Id to Add it to Your cart");
            int ItemId = Convert.ToInt32(Console.ReadLine()); 
                    
             string name = _MarketingStaff.GetProductName(ItemId);
             double cost = _MarketingStaff.GetProductCost(ItemId);
              
             _Cart.Add(new Cart(ItemId,name,cost));
             
        }
        public int viewCart()
        {    
             int isEmpty = _Cart.Count;          
             if(isEmpty == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            else{
            foreach (var item in _Cart)
            {  
               Console.WriteLine("Item Id   : " + item._ItemId);
               Console.WriteLine("Item Name : " + item._ItemName);
               Console.WriteLine("Item Cost : " + item._ItemCost);
               return 1;                
            }
            
          }
          return 0;
        }
        public void CustomerCheckout(SalesPerson SalesStaff,CourierCompany _Courier)
        {   
            char Choice; 

            Console.WriteLine("Do You Want to Checkout(Y/N)");
            Choice = Convert.ToChar(Console.ReadLine());
            
            if(Choice == 'Y')
            {
                
                 SalesStaff.CheckOut(_Cart,_Courier);
                 _Cart.Clear();
                 
            }
            if(Choice == 'N'){
               Console.WriteLine("You Can Continue Shopping");
            }
        }

        public void ChangeAccountInfo(){
         int Choice = 0;
        while(Choice <= 3){

         Console.WriteLine("1.Change Address");
         Console.WriteLine("2.Change PhoneNumber");
         Console.WriteLine("3.Change Email Id");
         Console.WriteLine("4.Back to shopping menu");
         Choice=Convert.ToInt32(Console.ReadLine());

         switch(Choice)
         {

             case 1 :  Console.WriteLine("Enter the New Address");
                       string newAddress = Console.ReadLine();
                       this._Address = newAddress;
                       Console.WriteLine("Address updated successfully");
                       break;
             case 2 :  Console.WriteLine("Enter the New mobile number");
                       string newNumber = Console.ReadLine();
                       this._PhoneNumber = newNumber;
                       Console.WriteLine("Mobile Number  updated successfully");
                       break;
             case 3 :  Console.WriteLine("Enter the New Email Id");
                       string newEmailId = Console.ReadLine();
                       this._Email = newEmailId;
                       Console.WriteLine("Address updated successfully");
                       break;
            default :break;
         }

        }
       

        }   
        
        
              
    }

    
}


