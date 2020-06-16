using System;


namespace TeacherStudent
{
    public class Student : Person
    {
      public void GoToClass(){

          Console.WriteLine("I am going to class");
      }

      public void ShowAge(){
         Console.WriteLine("My Age is: " + setAge(_Age));
      } 

      public override void message(){

          Console.WriteLine("Student says Hello");
      } 
    }
}