using System;

namespace AbstractDesignPattern
{// The 'ProductB2' class
public class SportsCar : FourWheeler
{
 public string _Name;
 public string _Milage;
 public string _Transmission;

 public SportsCar(string name,string milage,string transmission){

     _Name = name;
     _Milage = milage;
     _Transmission =transmission;
 }
public string Name{
     get{
         return "Sports Car Name :" + _Name;}
     set{
         _Name = value;}
 }
public string Milage{
     get{
         return "Sports Cars Milage :" + _Milage + " Kmph"; }
     set{
         _Milage = value;}
 }
public string Transmission{
    get {
        return "Transmission :" + _Transmission;}
    set{
        _Transmission = value;}
}
}
}
