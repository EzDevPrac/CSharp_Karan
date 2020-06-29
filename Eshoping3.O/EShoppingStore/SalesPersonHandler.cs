using System;
using System.Collections.Generic;
using System.Linq;
namespace EShoppingStore
{
    public class SalesPersonHandler : ISalesPersonHandler
    {   
        int checkoutDone = 0;
        double TotalAmmount = 0;
        public  void CheckOutCustomer(ICourierServiceHandler _Courier)
        {  
            
           Console.WriteLine("What kind of packing you need 1:Gift Wrap  2:Normal Wrap");
           int choice = Convert.ToInt32(Console.ReadLine());
           if(choice == 1)
           {
                    _Courier.Packaging("Gift");
                   
           }
           else{
                   _Courier.Packaging("Normal");
           }
            
           checkoutDone = 1;
           Console.WriteLine("Thank You For Shopping with US");  
           
           
        }

        public void CalculateTotalAmount()
        {
            foreach(var item in CartHandler.CustomerCartList)
            {
                
                TotalAmmount = TotalAmmount +  item._ItemCost;
                 
            }

             
           Console.WriteLine("Total Ammount of " + TotalAmmount + " Will be deducted from your registered Credit Card ");
           TotalAmmount = 0;
        }
        
        public int  ShowOrderStatus(){
           if(checkoutDone == 1)
            {Console.WriteLine("Your Product has been sent out for delivery");
            return 1;
            }
           else{

               Console.WriteLine("You dont have any orders to be recieved");
           }
           return 0; 
        }
       
       public void ReturnItem(ICourierServiceHandler _CourierService){
          if(checkoutDone == 1){
              _CourierService.returnPickup(TotalAmmount);
          
          }
          else{
              Console.WriteLine("You have got nothing to return to us");
          }
       }
        
        
    }
}