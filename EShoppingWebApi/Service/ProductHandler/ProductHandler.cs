using System.Collections.Generic;
using EShoppingWebApi.Models;

namespace EShoppingWebApi.Service.ProductHandler
{
    public class ProductHandler : IProductHandler
    {
        public static List<Product> ProductList= new List<Product>(){new Product(){ProductId = 123,ProductName= "Watch",ProductCost=12000}};
        
        public List<Product> GetProduct(){
            if(ProductList.Count == 0)
              return null;
        return ProductList;
        }

        public void AddProduct(Product product){

                ProductList.Add(product);

        }
        
        public int DeleteProduct(int Id){
            foreach (var item in ProductList)
            {
                if(item.ProductId == Id)
                   ProductList.Remove(item);
                   return 1;
            }
            
      
          return 0;
        }
    }
}