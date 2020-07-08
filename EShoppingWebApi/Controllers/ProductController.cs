
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.ProductHandler;
using EShoppingWebApi.Service.EmployeeService;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.ProductValidation;
using System.Collections.Specialized;
using System.Web;
namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]/[Action]")]
    
    public class ProductController : Controller
    {
      IProductHandler productHandler;
      IProductValidation productValidation;

      
      public ProductController(IProductHandler productHandler){
        this.productHandler = productHandler;
        this.productValidation = new ProductValidation();
       
      }
      
      [HttpGet]
      public ActionResult Get(){
       if(productHandler.GetProduct()==null)
         return BadRequest(new {message =" There are no product to display" });
      
      return Ok(this.productHandler.GetProduct());    
       
      }
      
      [HttpPost]
      public ActionResult AddToProductList([FromBody] Product product)
      {    
           foreach (var id in EmployeeService.EmployeeList)
        {
            foreach (var Unique in EmployeeService.UniqueEmployeeId)
            {
                if(Unique.Equals(id.UniqueId))
                  { 
                  //return BadRequest(new{ message ="Authnetication SuccessFull"});
                  if(productValidation.ValidateProductId(product.ProductId)== -1)
                       return BadRequest(new{mesage = "Id Field cannot be Null"});  
                  if(productValidation.ValidateProductName(product.ProductName) == -1)
                       return BadRequest(new{mesage = "Name Field cannot be Null"});
                  if(productValidation.ValidateProductCost(product.ProductCost) == -1) 
                       return BadRequest(new{message = "Cost Cannot be 0"});
          
                  if(productValidation.ValidateProductId(product.ProductId)== 1)
                  {
                    if(productValidation.ValidateProductName(product.ProductName) == 1)
                    {
                      if(productValidation.ValidateProductCost(product.ProductCost) == 1)
                       {
                         this.productHandler.AddProduct(product);
                         return Ok(new{message= "Product Added Successfully"});           
                       }
                      else
                       return BadRequest(new{message = "Invalid Input For Cost"});

                    }
                    else
                     return BadRequest(new{message = "Invalid Product Name"});
                  }
                  else
                  { return BadRequest(new{message = "Invalid Product Id"});}
          }     }
        }       
      return BadRequest(new {message = "You Cannot Add Products You Are not Logged in, Only Emloyee Can Add Products!!!"});      
       //-1 - null
       //1 - Success
       // 0 - Invalid
       
      }

      [HttpDelete]
      public ActionResult DeleteProductFromTheList(int id )
     {
             if(productHandler.DeleteProduct(id)==0)
               return BadRequest(new{message = "Product Does not Exist"});
      return Ok(this.productHandler.DeleteProduct(id));
     } 

      
    }
}    