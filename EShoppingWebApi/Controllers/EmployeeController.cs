using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingWebApi.Service.CustomerServices;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;
using EShoppingWebApi.Service.EmployeeService;
using System.Web;
 

namespace EShoppingWebApi.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
           this._employeeService = _employeeService;

        }
        [HttpPost]
        public IActionResult AuthenticateEmployee(string EmployeeName,string EmployeePassword)
        {
           
           int data =_employeeService.Authenticate(EmployeeName,EmployeePassword);
           TempData["mydata"] = data;
           //return RedirectToAction("Product/AddToProductList");
           return RedirectToAction("AddToProductList","Product"); 
        }
    }
}