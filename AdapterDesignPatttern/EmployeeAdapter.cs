using System;
using System.Collections.Generic;
namespace AdapterDesignPatttern{

// The 'Adapter' class
public class EmployeeAdapter : CompanyDataBase, ITarget
{
 public List<string> GetEmployeeList()
 {
 List<string> employeeList = new List<string>();
 string[][] employees = GetEmployees();
 foreach (string[] employee in employees)
 {
 employeeList.Add(employee[0]);
 employeeList.Add("==>");
 employeeList.Add(employee[1]);
 employeeList.Add("\n");
 }
 
 return employeeList;
 }
}
}
