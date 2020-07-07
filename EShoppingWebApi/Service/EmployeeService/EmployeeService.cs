using System.Collections.Generic;
using EShoppingWebApi.Models;
namespace EShoppingWebApi.Service.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        public static List<Employee> EmployeeList = new List<Employee>(){new Employee(){EmployeeName ="Karan",EmployeePassword="1927"}};

        public int  Authenticate(string name,string password)
        {
               foreach (var employee in EmployeeList)
               {
                   if(employee.EmployeeName == name && employee.EmployeePassword == password)
                     return 1;
               }
         return 0;
        }
    }
}