using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person(20,"Karan");
            Male male = new Male(21,"Karan");
            Female female = new Female(23,"Kim","Married");

            person.AboutMe();
            male.AboutMe();
            female.AboutMe();
        }
    }
}
