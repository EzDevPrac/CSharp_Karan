using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public  class MarketingPersonHandler : IMarketingPersonHandler
    {
        
        public void AddItemToProductCatalog(IProductHandler _ProductHandler)
        {
            
           Console.WriteLine("Enter the product ID");
           int Id = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the Product Name");
           string Name = Console.ReadLine();
           Console.WriteLine("Enter the product Cost");
           double Cost = Convert.ToDouble(Console.ReadLine());
           
           _ProductHandler.AddProduct(Id,Name,Cost);
        }
         
        
    }
}