using System;

namespace TeacherStudent
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {

            Student _Student = new Student();
            _Student.message();
            _Student.setAge(21);
            _Student.ShowAge();


            Teacher _Teacher = new Teacher();

            _Teacher.message();
            _Teacher.Explain();
            
        }
    }
}
