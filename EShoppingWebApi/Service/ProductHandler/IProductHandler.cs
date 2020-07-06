using System.Collections.Generic;
using EShoppingWebApi.Models;

namespace EShoppingWebApi.Service.ProductHandler
{
    public interface IProductHandler
    {
        
        List<Product> GetProduct();

        void AddProduct(Product prouct);
        
        int DeleteProduct(int Id);


    }
}