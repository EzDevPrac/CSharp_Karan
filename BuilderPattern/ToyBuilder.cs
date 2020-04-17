using System;

namespace BuilderPattern{

//Builder
public interface ToyBuilder {  
    void SetModel();  
    void SetHead();  
    void SetLimbs();  
    void SetBody();  
    void SetLegs();  
    void display();  
}



}