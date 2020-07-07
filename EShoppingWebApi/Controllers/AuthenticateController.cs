using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Service.EmployeeService;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;

namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]/[action]")]
    public class AuthenticateController : Controller
    {


        ICustomerService CustomerService ;
        IEmployeeService employeeService;   
        public AuthenticateController(ICustomerService customerService,IEmployeeService employeeService)
        {
            CustomerService = customerService;
            this.employeeService = employeeService;
        }

        [HttpPost]
        [ActionName("CustomerLogin")]
        public IActionResult CustomerLogin([FromBody]CustomerAuthenticationData customerData)
        {  
            var _Customer = CustomerService.Authenticate(customerData.UserName,customerData.Password);

            if (_Customer == null)
                return BadRequest(new { message = " Username or password is incorrect " });
           
          return Ok(_Customer);
        
        }
        [HttpPost]
        [ActionName("EmployeeLogin")]
        
        public IActionResult EmployeeLogin([FromBody]Employee employee)
        {
           
           var data =employeeService.Authenticate(employee.EmployeeName,employee.EmployeePassword);
           if(data == null)
            return BadRequest(new { message = " Username or password is incorrect " });
           
         // return Ok(data);
          return RedirectToRoute(new
                                 {controller = "Product",
                                 action = "AddToProductList"}); 

        }

        
    }
}