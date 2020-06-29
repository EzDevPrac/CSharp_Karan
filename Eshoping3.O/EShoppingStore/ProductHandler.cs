using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class ProductHandler: IProductHandler
    {
        public static List<Product> ProductList = new List<Product>();

        public  void DisplayProduct(){
           
           Console.WriteLine("Item ID \t Item Name \t Item Cost");
           Console.WriteLine("-----------------------------------------");
           foreach (var item in ProductList)
           {
               Console.WriteLine(item._ItemId+"\t\t"+item._ItemName+"\t\t"+item._ItemCost);
               Console.WriteLine("----------------------------------------------");
           }
            
        }

        public void ShowExisting()
        {
            ProductList.Add(new Product(1,"Mobile",12999));
            ProductList.Add(new Product(2,"Watch",1500));
            ProductList.Add(new Product(3,"Led Tv",25000));
        }

       public string GetProductName(int id)
        {
           foreach (var item in ProductList)
           {
               if(item._ItemId == id)
               {  
                   return item._ItemName;
               }
           }
         return "";
        } 

       public double GetProductCost(int id){
            foreach (var item in ProductList)
            {
                if(item._ItemId == id)
                {
                    return item._ItemCost;
                }
            }
            return 0;
        }
    
       public void AddProduct(int itemId,string ItemName,double ItemCost)
       {

           ProductList.Add(new Product(itemId,ItemName,ItemCost));
       }
    }
}