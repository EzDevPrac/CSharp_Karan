namespace EShoppingWebApi.Models
{
    public class Employee
    {
        private string employeeName;
        private string employeePassword;

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePassword { get => employeePassword; set => employeePassword = value; }
    }
}