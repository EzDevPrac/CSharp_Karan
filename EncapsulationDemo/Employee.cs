using System;

namespace EncapsulationDemo
{
    public class Employee
    {
        private string _name;
        private int _age;

       
       public string Name{get{

           return _name;
       }
       
       
       
       set
       
       {
            _name = value;
       }
       
       
       }
       public int Age{
    
       get{

           return _age;
       }
       
       set{
              if(_age == 0 )
              _age = 1;

       }
       }
        public void DisplayDetails(){

            Console.WriteLine(_name);
            Console.WriteLine(_age);}
    }
}