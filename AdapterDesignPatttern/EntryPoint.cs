using System;
using System.Collections.Generic;
namespace AdapterDesignPatttern
{
 class EntryPoint{
   static void Main(string[] args){
     ITarget Itarget = new EmployeeAdapter();
     Client client = new Client(Itarget);
     client.ShowEmployeeList();
     Console.ReadKey();
    }
 }
}
