using System;

namespace AbstractDesignPattern
{// The 'ProductB1' class
public class RegularCar : FourWheeler
{
 public string _Name;
 public string _Milage;
 public string _Transmission;
public string Name{
     get{
         return "Regular Car Name :" + _Name;
     }
     set{
         _Name = value;
     }
 }
public string Milage{
     get{
         return "Regular Cars Milage :" + _Milage + " Kmph"; 
     }
     set{
         _Milage = value;
    }
 }
public string Transmission{
    get {
        return "Transmission :" + _Transmission;
    }
    set{
        _Transmission = value;
    }
}
}
}
