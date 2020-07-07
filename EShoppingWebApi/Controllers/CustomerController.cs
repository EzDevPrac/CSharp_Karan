using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;
using System.Web;
namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class CustomerController :Controller
    {
        ICustomerService CustomerService ;
        ICustomerInformationValidation CustomerDataValidation;
        public CustomerController (ICustomerService customerService,ICustomerInformationValidation customerDataValidation)
        {
            CustomerService = customerService;
            CustomerDataValidation = customerDataValidation;
            
        }
        [HttpGet]
        public ActionResult Get(){
          if(CustomerService.GetCustomer() == null)
           { return BadRequest(new{ message = " Customer List is Empty "});}
        return Ok(this.CustomerService.GetCustomer());
        }
    
        [HttpPost]
        public ActionResult AddCustomers([FromBody] Customer customer){
         //ICustomerInformationValidation returns
         //1-Success,0-Invalid,-1-Null Value
         if(CustomerDataValidation.CheckExistingCustomer(customer)==0)
          return BadRequest(new{message = "Customer Already exists"});
         if(CustomerDataValidation.ValidateName(customer.CustomerName) == -1)
           return BadRequest(new{message = " Customer name cannot be Empty"});
         if(CustomerDataValidation.ValidateMobileNumber(customer.CustomerMobileNumber) == -1)
           return BadRequest(new{message = " Customer Mobile number cannot be Empty "});
         if(CustomerDataValidation.ValidateEmailId(customer.CustomerEmailId) == -1)
           return BadRequest(new{message = " Customer Email ID Cannot be Empty "});  
         if(CustomerDataValidation.ValidateCustomerAddress(customer.CustomerAddress) == -1)
           return BadRequest(new{message = " Customer Address cannot be Empty "});
         if(CustomerDataValidation.ValidatePassword(customer.Password) == -1)
           return BadRequest(new{message = " Customer Password cannot be Empty "});
         if(CustomerDataValidation.ValidateAccountNumber(customer.CustomerAccountNumber) == -1)
           return BadRequest(new{message = " Customer Account Number(Eg: XXXX-XXXX-XXXX-XXXX) cannot be empty "});  
         
         if(CustomerDataValidation.ValidateName(customer.CustomerName) == 1)
          {
               if(CustomerDataValidation.ValidateMobileNumber(customer.CustomerMobileNumber) == 1)
               { 
                   if(CustomerDataValidation.ValidateEmailId(customer.CustomerEmailId) == 1)
                    {
                        if(CustomerDataValidation.ValidateAccountNumber(customer.CustomerAccountNumber) == 1)
                        {
                            this.CustomerService.AddCustomer(customer);
                            return Ok(new  {message = "Customer Added Sucessfully"});              
                        }
                        else
                         return BadRequest(new{message = "Entered Customer Account Number not Proper(Eg:XXXX-XXXX-XXXX-XXXX)"});   

                    }
                    else
                     return BadRequest(new{message = "Entered Customer Email id is not Proper "});     
               }
               else
                return BadRequest(new{message = "Entered Customer Mobile Number is not Proper "});       

          }
        return BadRequest(new{message = "Entered Customer name is not Proper "});
         
        }
    
           
    
        [HttpDelete]
        public ActionResult RemoveCustomer([FromBody] CustomerAuthenticationData userData)
        {
          if(CustomerService.Delete(userData) == 0)
           {return BadRequest(new{message ="Customer Does not Exist"});}
        
        
        return Ok(this.CustomerService.Delete(userData));
        

        }
    
    
    }
}