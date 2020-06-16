using System;

namespace TeacherStudent
{
    public class Teacher : Person
    {

        private string Subject;

        public string _Subject{
         
         get{return Subject;}

         set{Subject = value;}
        }

        public void Explain(){

            Console.WriteLine("Explanation Begins");
        }

        public override void message(){

          Console.WriteLine("Teacher  says Hello");
      }
    }
}