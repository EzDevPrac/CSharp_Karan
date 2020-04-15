﻿using System;

namespace BuilderPattern_Example
{

//Builder
public interface IToyBuilder {  
    void SetModel();  
    void SetHead();  
    void SetLimbs();  
    void SetBody();  
    void SetLegs();  
    void display();  
}
//Product Class
public class Toy {  
    public string Model {  
        get;  
        set;  
    }  
    public string Head {  
        get;  
        set;  
    }  
    public string Limbs {  
        get;  
        set;  
    }  
    public string Body {  
        get;  
        set;  
    }  
    public string Legs {  
        get;  
        set;  
    }
    
      

}
//Concrete builder for Toy A
public class ToyABuilder: IToyBuilder {  
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
//concrete Builder class for ToyB
public class ToyBBuilder: IToyBuilder {  
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

//Director  
public class ToyCreator {  
    private IToyBuilder _toyBuilder;  
    public ToyCreator(IToyBuilder toyBuilder) {  
        _toyBuilder = toyBuilder;  
    }  
    public void CreateToy() {  
        _toyBuilder.SetModel();  
        _toyBuilder.SetHead();  
        _toyBuilder.SetLimbs();  
        _toyBuilder.SetBody();  
        _toyBuilder.SetLegs();
         
      
    } 
    public void displayToy(){
      _toyBuilder.display();

    }
      
} 
//Main Class
public class Entry{

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