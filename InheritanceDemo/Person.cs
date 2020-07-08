using System;
namespace InheritanceDemo
{
    public class Person
    {
    public int age;
    public string name;
    
    public Person(int Age,string Name){
        age = Age;
        name = Name;
    }
    public void AboutMe(){
        
        Console.WriteLine("HEy i am person");
    }
            
    }
}