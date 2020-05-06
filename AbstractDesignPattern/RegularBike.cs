using System;

namespace AbstractDesignPattern
{//The 'ProductA1' class
public class RegularBike : TwoWheeler
{
    string _Name;
    string _Milage;
    public RegularBike(string name,string milage){

        _Name = name;
        _Milage = milage;
    }
    public string Name{
     get {
         return "Regular Bikes Name is : " + _Name;}
     set{
         _Name = value;
        }
    }
    public string Milage{
     get{return "Regular Bikes Milage is : " + _Milage + " Kmph";}
     set{
        _Milage = value;
     }
    }

}
}
