using EShoppingWebApi.Models;

namespace EShoppingWebApi.Service.EmployeeService
{
    public interface IEmployeeService
    {
       Employee Authenticate(string name,string password);  
    }
}