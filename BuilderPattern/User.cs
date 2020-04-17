using System;

namespace BuilderPattern
{
    //Main Class
public class User{

static void Main() {  
    Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");  
    var toyACreator = new ToyCreator(new ToyABuilder());  
    toyACreator.CreateToy();  
    toyACreator.displayToy();
    Console.WriteLine("\n");
    var toyBCreator = new ToyCreator(new ToyBBuilder());  
    toyBCreator.CreateToy();  
    toyBCreator.displayToy();
}  
}
}
