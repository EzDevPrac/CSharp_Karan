using System;
namespace EShoppingWebApi.Models
{
    public class Employee
    {
        private string employeeName;
        private string employeePassword;
        
        private Guid uniqueId = new Guid();
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePassword { get => employeePassword; set => employeePassword = value; }
        
        public Guid UniqueId { get => uniqueId;}
        
    }
}    
    