using System;

namespace BuilderPattern{

//Concrete builder for Toy A
public class ToyABuilder: ToyBuilder {  
    Toy toy = new Toy();  
    public void SetModel() {  
        toy.Model = "TOY A";  
    }  
    public void SetHead() {  
        toy.Head = "1";  
    }  
    public void SetLimbs() {  
        toy.Limbs = "4";  
    }  
    public void SetBody() {  
        toy.Body = "Plastic";  
    }  
    public void SetLegs() {  
        toy.Legs = "2";  
    }
    public void display()
    {
      Console.WriteLine("Model == " + toy.Model);
      Console.WriteLine("Head  == " + toy.Head);
      Console.WriteLine("Limbs == " + toy.Limbs);
      Console.WriteLine("Body  == " + toy.Body);
      Console.WriteLine("Legs  == " + toy.Legs);


   }  
     
}



    
}