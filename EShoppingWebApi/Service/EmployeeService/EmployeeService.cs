using System.Collections.Generic;
using EShoppingWebApi.Models;
using System;
namespace EShoppingWebApi.Service.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {  public static List<Guid> UniqueEmployeeId = new List<Guid>();
       public static List<Employee> EmployeeList = new List<Employee>(){new Employee(){EmployeeName ="Karan",EmployeePassword="1927"}};

        public Employee Authenticate(string name,string password)
        {
               foreach (var employee in EmployeeList)
               {
                   if(employee.EmployeeName == name && employee.EmployeePassword == password)
                   { 
                     Guid id;
                     id = employee.UniqueId;
                     //EmployeeList.Add(employee);
                     UniqueEmployeeId.Add(id);    
                     return employee;
                   }  
               }
         return null;
        }
    }
}