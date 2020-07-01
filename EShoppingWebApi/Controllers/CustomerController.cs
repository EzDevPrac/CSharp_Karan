using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class CustomerController :ControllerBase
    {
        ICustomerService CustomerService ;
       
        public CustomerController (ICustomerService customerService)
        {
            CustomerService = customerService;
            Customer _Customer =new Customer();
        }
    [HttpGet]
    public ActionResult Get(){
          
          return Ok(this.CustomerService.GetCustomer());
    }


    }
}