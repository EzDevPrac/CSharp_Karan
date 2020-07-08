using System;

namespace InheritanceDemo
{
    public class Female : Person
    {
        string status;
      public Female (int age, string name,string status) : base(age,name){
       this.status = status;
      }

      public  void AboutMe()
      {
          Console.WriteLine("I am Girl,and I am " + status + " , My Name is " + name);
      }

        
    }
}