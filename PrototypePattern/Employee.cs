using System;

namespace PrototypePattern
{
    // 'ConcretePrototype1' class implements IPrototype interface
    public class Employee : ICollegePerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

        // Implement shallow cloning method
        public ICollegePerson Clone()
        {
            // Shallow Copy
            return this.MemberwiseClone() as ICollegePerson;

        }
    }
}