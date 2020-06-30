using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;

namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class CustomerController :ControllerBase
    {
       CustomerService customerService = new CustomerService();
    public CustomerController()
    {
      customerService.ExistingCustomer();

    }    
    [HttpGet]
    public ActionResult Get(){
          
          return Ok(this.customerService.GetCustomer());
    }


    }
}