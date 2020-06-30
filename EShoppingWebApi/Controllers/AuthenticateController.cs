using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
namespace EShoppingWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        CustomerService CustomerService = new CustomerService();
       


        

        [HttpPost]
        public IActionResult Post(string Name,string Password)
        {  
            var _Customer =CustomerService.Authenticate(Name,Password);

            if (_Customer == null)
                return BadRequest(new { message = "Username or password is incorrect" });
           return Ok(_Customer);
        }

    }
}