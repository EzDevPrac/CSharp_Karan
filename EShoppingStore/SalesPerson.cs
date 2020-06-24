using System;
using System.Collections.Generic;
namespace EShoppingStore
{
    public class SalesPerson
    {   public static CourierCompany courier = new CourierCompany();
        static  int checkoutDone = 0;
        static double TotalAmmount = 0;
        public  void CheckOut(List<Cart> cart)
        {  
            
           Console.WriteLine("What kind of packing you need 1:Gift Wrap  2:Normal Wrap");
           int choice = Convert.ToInt32(Console.ReadLine());
           if(choice == 1)
           {
                    courier.Packaging("Gift");

           }
           else{
                   courier.Packaging("Normal");
           }
            foreach(var item in cart)
            {
                
                TotalAmmount = TotalAmmount + item._ItemCost;

            }
             
           Console.WriteLine("Total Ammount of " + TotalAmmount + " Will be deducted from your registered Credit Card ");
           //courier.Deliver(Address);
           checkoutDone =1;
           Console.WriteLine("Thank You For Shopping with US");  
           
           
        }
        
        public void ShowOrderStatus(){
           if(checkoutDone == 1)
            Console.WriteLine("Your Product has been sent out for delivery");
           else{

               Console.WriteLine("You dont have any orders to be recieved");
           } 
        }
       
       public void ReturnItem(){
          if(checkoutDone == 1){
          courier.returnPickup(TotalAmmount);
          }
          else{
              Console.WriteLine("You have got nothing to return to us");
          }
       }
        
        
    }
}