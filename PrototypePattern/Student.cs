using System;

namespace PrototypePattern
{
    public class Student : ICollegePerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int  Semester { get; set; }

        // Implement shallow cloning method
        public ICollegePerson Clone()
        {
            // Deep Copy 
            Student cloned = this.MemberwiseClone() as Student;
            cloned.Semester =2;
            return cloned as ICollegePerson;     


                   }
    }

 
}
