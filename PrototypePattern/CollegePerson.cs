using System;

namespace PrototypePattern
{
    
    // 'IPrototype' interface
    public interface ICollegePerson
    {
        // Method for cloning
        ICollegePerson Clone();
    }
}