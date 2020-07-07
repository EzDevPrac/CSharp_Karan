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
    [Route("[controller]/[action]")]
    public class AuthenticateController : Controller
    {


        ICustomerService CustomerService ;

        public AuthenticateController(ICustomerService customerService)
        {
            CustomerService = customerService;
        }

        [HttpPost]
        public IActionResult AuthenticateCustomer([FromBody]CustomerAuthenticationData customerData)
        {  
            var _Customer = CustomerService.Authenticate(customerData.UserName,customerData.Password);

            if (_Customer == null)
                return BadRequest(new { message = " Username or password is incorrect " });
           
          return Ok(_Customer);
        
        }
    }
}