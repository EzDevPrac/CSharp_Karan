using System;

namespace PrototypePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Employee _Employee = new Employee();
            _Employee.Name = "Karan";
            _Employee.Age = 25;
            _Employee.EmploymentType = "Professor";
            // cloneemployee object with Clone method
            // If you will not set the new value for any field the it will take the default value from original object
            Employee _Employee2 = (Employee)_Employee.Clone();
            _Employee2.Name = "Raju";
            _Employee2.Age = 25;
            Console.WriteLine("Shallow Copy Output");
            Console.WriteLine("Employee Details");
            Console.WriteLine("Name: {0}; Age: {1} Employment Type: {2}", _Employee.Name, _Employee.Age, _Employee.EmploymentType);
            Console.WriteLine("Cloned Employee Details");
            Console.WriteLine("Name: {0}; Age: {1} Employment Type: {2}", _Employee2.Name, _Employee2.Age, _Employee2.EmploymentType);
            // operation for deep copy
             Student _Student =new Student();
             _Student.Name ="Karan";
             _Student.Age = 21;
             _Student.Semester = 5;
            //Clone for the second Student
            Student _Student2 = (Student)_Student.Clone();
             _Student2.Name = "Raju";
            Console.WriteLine("\nDeep Copy Output"); 
            Console.WriteLine("Student Details");
            Console.WriteLine("Name: {0}; Age: {1} Semester: {2}", _Student.Name, _Student.Age, _Student.Semester);
            //Cloned Student Details
            Console.WriteLine("Student Details");
            Console.WriteLine("Name: {0}; Age: {1} Semester: {2}", _Student2.Name, _Student2.Age, _Student2.Semester);
            Console.ReadLine();
        }
    }

}
