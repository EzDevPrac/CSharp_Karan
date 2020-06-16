using System;

namespace AbstractionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
           Permanent _PermanentEmployee = new Permanent();

            _PermanentEmployee.EmployeeName = "Karan";
            _PermanentEmployee.EmployeeId = 730120;

            Console.WriteLine("Permanent Employee");  
            Console.WriteLine(_PermanentEmployee.DisplayName());
            _PermanentEmployee.GetTheMonthlySalary();
            
            Console.WriteLine("\n");

           Temperary _TemperaryEmployee = new Temperary(); 
            _TemperaryEmployee.EmployeeName="Ash";
            _TemperaryEmployee.EmployeeId = 741211;

            Console.WriteLine("Temperary Employee");
            Console.WriteLine(_TemperaryEmployee.DisplayName());
            _TemperaryEmployee.GetTheMonthlySalary();
            

            
        }
    }
}
