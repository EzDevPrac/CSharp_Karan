using System;
using System.Collections.Generic;
using EShoppingWebApi.Models;
using EShoppingWebApi.Service.ProductHandler;
namespace EShoppingWebApi.Service.CartHandler
{
    public class CartHandler:ICartHandler
    {  
        IProductHandler productHandler;
        public static List<Cart> CustomerCartList = new List<Cart>();
        public List<Cart> Get(Guid id){
          
         foreach (var item in CustomerCartList)
         {
             if(id == item.CustomerCartId)
             {
                 return CustomerCartList;
             }
             
         }
         return null; 
        }
        public CartHandler(IProductHandler productHandler){
            this.productHandler =productHandler;
        }
           
        public  int Remove(Guid id,int Productid)
        {
           foreach (var item in CustomerCartList)
           {
               if(item.ProductId == Productid && item.CustomerCartId == id)
               {

                   CustomerCartList.Remove(item);
                   return 1;
               }
               
           }
        return 0;

        }
        public int Add(Guid id,int productid)
        {
            
            
          foreach (var item in productHandler.GetProduct())
            {
             if(item.ProductId == productid)
              {
                   CustomerCartList.Add(new Cart(){ProductId = item.ProductId , ProductName = item.ProductName, ProductCost = item.ProductCost, CustomerCartId = id});

                   return 1;
              }   
            }
          return 0;  
        }

    }
}