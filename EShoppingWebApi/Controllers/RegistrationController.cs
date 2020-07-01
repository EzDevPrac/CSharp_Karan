using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
namespace EShoppingWebApi.Controllers
{[  ApiController]
    [Route("[controller]")]
    
    public class RegistrationController :ControllerBase
    {
       ICustomerService CustomerService ;
       
        public RegistrationController (ICustomerService customerService)
        {
            CustomerService = customerService;
        }

        [HttpPost]

       public ActionResult Post([FromBody] Customer customer){
         this.CustomerService.AddCustomer(customer);
        return Ok();
    }    

    }
}