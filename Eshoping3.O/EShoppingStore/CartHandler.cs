using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class CartHandler : ICartHandler
    {
       public static List<Cart> CustomerCartList = new List<Cart>() ; 
       
        public void AddToCart(IProductHandler _ProductHandler){
            
            Console.WriteLine("Enter the Item Id to Add it to Your cart");
            int ItemId = Convert.ToInt32(Console.ReadLine()); 
                    
             string name = _ProductHandler.GetProductName(ItemId);
             double cost = _ProductHandler.GetProductCost(ItemId);
              
             CustomerCartList.Add(new Cart {_ItemId = ItemId,_ItemName = name,_ItemCost = cost});
            
          
        }
           
        public int ShowCart()
        {    
             int isEmpty = CustomerCartList.Count;          
             if(isEmpty == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            else{
                
            foreach (var item in CustomerCartList)
            {  
               Console.WriteLine("Item Id   : " + item._ItemId);
               Console.WriteLine("Item Name : " + item._ItemName);
               Console.WriteLine("Item Cost : " + item._ItemCost);
                               
            }
            return 1;
            }
          return 0;
        }
    }
}