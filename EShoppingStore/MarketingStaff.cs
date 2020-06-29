using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public  class MarketingStaff
    {
       public static List<Product> ProductList = new List<Product>();
       

        public void AddItems()
         {
          
           ProductList.Add(new Product(1,"Mi Note 7 pro",13999));
           ProductList.Add(new Product(2,"Oven",15000));
           ProductList.Add(new Product(3,"Mi TV",23999));
         }
        
        public int  StaffLogin(string name , int password)
        {

             if(name == "Karan" && password == 1927)
             {
                 Console.WriteLine("Loggin Successfull..");
                 return 1;
             }
             else{
                 Console.WriteLine("Invalid Credentials");
             }
         return 0;
        }

        public void Addproduct()
        {
           Console.WriteLine("Enter the product ID");
           int id = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the Product Name");
           string name = Console.ReadLine();
           Console.WriteLine("Enter the product Cost");
           double cost = Convert.ToDouble(Console.ReadLine());
           ProductList.Add(new Product(id,name,cost));

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
        public  void ShowItem(){
           
           Console.WriteLine("Item ID \t Item Name \t Item Cost");
           Console.WriteLine("-----------------------------------------");
           foreach (var item in ProductList)
           {
               Console.WriteLine(item._ItemId+"\t\t"+item._ItemName+"\t\t"+item._ItemCost);
               Console.WriteLine("----------------------------------------------");
           }
            
        }
        
    }
}