using System;


namespace TeacherStudent
{
    public abstract class Person
    {
        public int _Age;

        public string setAge(int n)
        {
            _Age = n ;
            
            return Convert.ToString(_Age) + " years old";
        }

        public virtual void message(){}

    }
}