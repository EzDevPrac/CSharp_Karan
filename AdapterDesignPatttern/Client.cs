using System;
using System.Collections.Generic;
namespace AdapterDesignPatttern{

// The 'Client' class
public class Client
{
 private ITarget employeeSource;
 
 public Client(ITarget employeeSource)
 {
 this.employeeSource = employeeSource;
 }
 
 public void ShowEmployeeList()
 {
 List<string> employee = employeeSource.GetEmployeeList();
  Console.WriteLine("-----Employees In JKT ---------");
 foreach (var item in employee)
 {
 Console.Write(item); 
 }
 
 }
}

}