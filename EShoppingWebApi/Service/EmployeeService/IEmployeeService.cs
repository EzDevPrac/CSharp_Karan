using EShoppingWebApi.Models;
using System;
namespace EShoppingWebApi.Service.EmployeeService
{
    public interface IEmployeeService
    {
     Employee Authenticate(string name,string password);  
    }
}