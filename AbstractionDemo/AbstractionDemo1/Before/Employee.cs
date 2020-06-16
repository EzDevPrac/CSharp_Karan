using System;

namespace Before
{
    class Employee
    {
        static void Main(string[] args)
        {
           Implemetation _Employee = new Implemetation();

           _Employee.VerifyEmployeeName("Karan");
           _Employee.VerifyEmployeeId(10);
           _Employee.AddEmployee("Karan",10);    
        }
    }
}
