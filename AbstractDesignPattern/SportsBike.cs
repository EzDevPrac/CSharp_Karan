using System;

namespace AbstractDesignPattern
{
    
/// The 'ProductA2' class
public class SportsBike : TwoWheeler
{
 string _Name;
    string _Milage;
public string Name{
     get {
         return "Sports Bikes Name is : " + _Name;}
     set{
         _Name = value;
     }
 }
public string Milage{
    get{
        return "Sports Bikes Milage is : " + _Milage;}
    set{
        
        _Milage = value;
    }
}
}

}
