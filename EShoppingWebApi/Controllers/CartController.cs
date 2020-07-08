using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CartHandler;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;
using System.Web;
namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        private ICartHandler cart;

        public CartController(ICartHandler cart)
        {
            this.cart = cart;
        }
        
        [HttpGet]
        public IActionResult ViewCart()
        {
            Guid customerID = (Guid)TempData["ID"];

            var Items = cart.Get(customerID);
            if(Items == null)
            {
                return BadRequest(new{message = "Cart is empty"});
            }
           return Ok(Items); 
 
        }
        [HttpPost]
        public ActionResult AddToCart(int id)
        {
              Guid customerID = (Guid)TempData["ID"];
              int result = cart.Add(customerID,id); 
              if(result ==1)
               return Ok(new {LoggerMessage="Product Added to the Cart"});

         return BadRequest(new{message = "Product Id not Found"} );  
        }

    }
}
