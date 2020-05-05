using System;
using PrototypePattern;
using Xunit;

namespace PrototypePattern.Test
{
    public class CheckStudentDetails
    {
      Student _Student = new Student();

      //Check the Student name
      [Theory]
      [InlineData("Karan","Karan")]
      [InlineData("Raju","Raju")]
      [InlineData("Shashank","Shashank")]
      [InlineData("Lavanya","Lavanya")]
      [InlineData("Terrena","Terrena")]
      public void CheckTheStudentName(String StudentName,String Output){

      _Student.Name = StudentName;

      Assert.Equal(_Student.Name,Output);
      }
      
      //Check Student age

      [Theory]
      [InlineData(21,21)]
      [InlineData(22,22)]
      [InlineData(23,23)]
      [InlineData(18,18)]
      [InlineData(19,19)]
      public void CheckTheStudentAge(int StudentAge,int Output){

      

      _Student.Age = StudentAge;

      Assert.Equal(_Student.Age,Output);
      }
    
     //Check the Students Semester

      [Theory]
      [InlineData(8,8)]
      [InlineData(7,7)]
      [InlineData(6,6)]
      [InlineData(5,5)]
      [InlineData(4,4)]
      public void CheckTheStudentsSemester(int Semester,int Output){

      _Student.Semester = Semester;

      Assert.Equal(_Student.Semester,Output);
      }
    

    
    
    
    
    }
}
