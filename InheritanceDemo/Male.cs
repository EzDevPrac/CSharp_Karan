using System;
namespace InheritanceDemo
{
    public class Male : Person
    {
        public Male(int Age,string Name):base(Age,Name){}
        public void AboutMe()
      {   
          Console.WriteLine("I am Boy " + "My name is " + name + ",My Age is "+ age);
      }
    }
}