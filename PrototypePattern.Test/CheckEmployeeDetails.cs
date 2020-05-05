using System;
using PrototypePattern;
using Xunit;

namespace PrototypePattern.Test
{
    public class CheckEmployeeDetails
    {
      Employee employee = new Employee();

      //Check the employee name
      [Theory]
      [InlineData("Karan","Karan")]
      [InlineData("Raju","Raju")]
      [InlineData("Shashank","Shashank")]
      [InlineData("Lavanya","Lavanya")]
      [InlineData("Terrena","Terrena")]
      public void CheckTheEmployeeName(String EmployeeName,String Output){

      employee.Name = EmployeeName;

      Assert.Equal(employee.Name,Output);
      }
      
      //Check Employee age

      [Theory]
      [InlineData(21,21)]
      [InlineData(22,22)]
      [InlineData(23,23)]
      [InlineData(18,18)]
      [InlineData(19,19)]
      public void CheckTheEmployeeAge(int EmployeeAge,int Output){

      employee.Age = EmployeeAge;

      Assert.Equal(employee.Age,Output);
      }
    
     //Check the Employee type

      [Theory]
      [InlineData("Principal","Principal")]
      [InlineData("Professor","Professor")]
      [InlineData("Asst. Professor","Asst. Professor")]
      [InlineData("Lab Assistant","Lab Assistant")]
      [InlineData("Attender","Attender")]
      public void CheckTheEmployeeType(String EmployeeType,String Output){

      employee.EmploymentType = EmployeeType;

      Assert.Equal(employee.EmploymentType,Output);
      }
    

    
    
    
    
    }
}
