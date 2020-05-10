using System;
using System.Collections.Generic;
namespace AdapterDesignPatttern{
// The 'Adaptee' class
public class CompanyDataBase
{
 public string[][] GetEmployees()
 {
 string[][] employees = new string[5][];
 
 employees[0] = new string[] {"Karan Kumar", "Trainee" };
 employees[1] = new string[] {"Raju ", "Back End Developer" };
 employees[2] = new string[] {"Shashank", "Front End Developer" };
 employees[3] = new string[] {"Lavanya", "Full Stack Developer"};
 employees[4] = new string[] {"Terrena", "Tester" };
 
 return employees;
 }
}
}