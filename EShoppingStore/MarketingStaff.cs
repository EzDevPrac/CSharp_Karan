using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public  class MarketingStaff
    {
        private static List<Product> ProductList = new List<Product>();
        public Customer cc =  new Customer();

        

                       
        public void AddItems()
         {
          
           ProductList.Add(new Product(1,"Mi Note 7 pro",13999));
           ProductList.Add(new Product(2,"Oven",15000));
           ProductList.Add(new Product(3,"Mi TV",23999));
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
           Console.WriteLine("Enter the Item Id to Add it to Your cart");
           int ItemId = Convert.ToInt32(Console.ReadLine()); 
           cc.AddToCart(ItemId);

        }
        public void CustomerOptions(string name){
            SalesPerson Sp = new SalesPerson();           
            int choice=0;
            AddItems();
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
                    ShowItem(); 
                    break;
             case 2:
                    cc.viewCart();  
                    break;
             case 3:Sp.ShowOrderStatus();
                     
                    break;
             case 4: 
                    cc.ChangeAccountInfo();  
                    break;

             case 5: 
                     Sp.ReturnItem();                   
                     break;      
             default:break;


            }
            }
         }  


    }
}