using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;

namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class CustomerController :ControllerBase
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
           { return BadRequest(new{ message = "Customer List is Empty"});}
        return Ok(this.CustomerService.GetCustomer());
        }
    
        [HttpPut]
        public ActionResult AddCustomers([FromBody] Customer customer){
         //ICustomerInformationValidation returns
         //1-Success,0-Invalid,-1-Null Value

         if(CustomerDataValidation.ValidateName(customer.CustomerName) == -1)
           return BadRequest(new{message = " Inavlid Input for the Customer name "});
         if(CustomerDataValidation.ValidateMobileNumber(customer.CustomerMobileNumber) == -1)
           return BadRequest(new{message = " Inavlid Input for the Customer Mobile number "});
         if(CustomerDataValidation.ValidateEmailId(customer.CustomerEmailId) == -1)
           return BadRequest(new{message = " Inavlid Input for the Customer Email ID "});  
         if(CustomerDataValidation.ValidateAccountNumber(customer.CustomerAccountNumber) == -1)
           return BadRequest(new{message = " Inavlid Input for the Customer Account Number(Eg: XXXX-XXXX-XXXX-XXXX) "});  
         
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
    
        [HttpPost]
        public IActionResult AuthenticateCustomer([FromBody]CustomerAuthenticationData customerData)
        {  
            var _Customer = CustomerService.Authenticate(customerData.UserName,customerData.Password);

            if (_Customer == null)
                return BadRequest(new { message = "Username or password is incorrect" });
           
           return Ok(_Customer);
        }   
    
    
    
    
    }
}