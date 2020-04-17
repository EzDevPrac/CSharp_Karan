using System;

namespace BuilderPattern{

//Director  
public class ToyCreator {  
    private ToyBuilder _toyBuilder;  
    public ToyCreator(ToyBuilder toyBuilder) {  
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

    
}