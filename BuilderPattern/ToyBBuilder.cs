using System;

namespace BuilderPattern{

//concrete Builder class for ToyB
public class ToyBBuilder: ToyBuilder {  
    Toy toy = new Toy();  
    public void SetModel() {  
        toy.Model = "Toy B";  
    }  
    public void SetHead() {  
        toy.Head = "1";  
    }  
    public void SetLimbs() {  
        toy.Limbs = "2";  
    }  
    public void SetBody() {  
        toy.Body = "Synthetic";  
    }  
    public void SetLegs() {  
        toy.Legs = "4";  
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