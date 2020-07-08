using EShoppingWebApi.Models;
using System;
using System.Collections.Generic;
namespace EShoppingWebApi.Service.CartHandler
{
    public interface ICartHandler
    {
           List<Cart> Get(Guid id);
           
           int Remove(Guid id,int productID);

           int Add(Guid id,int productid);

    }
}