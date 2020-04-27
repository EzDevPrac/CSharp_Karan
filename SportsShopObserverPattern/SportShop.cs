using System;
using System.Collections;

namespace SportsShopObserverPattern
{//Subject
public abstract class SportShop
{
 private ArrayList customers = new ArrayList();
  private string _Item;
 private int _Cost;
 public SportShop(String Item , int Cost)
 {
   this._Item = Item;
   this._Cost = Cost;
 }
 public void MakeSubscription(ICustomer _Customer)
 {
 customers.Add(_Customer);
 Notify();
 }
 public void UnSubscribe(ICustomer _Customer)
 {
  customers.Remove(_Customer);
 }

 public void Notify()
 {
 foreach (ICustomer _Customer in customers)
 {
    _Customer.Update(this);
 }
 }
 public String ItemName{
     
     get{
         return _Item;
         }

     set{
         
         this._Item = value;
         Notify();
        }
}
public int ItemCost{

    get { return _Cost;}
    set {  this._Cost =value;
            Notify();
           
      
     }
}
}


}
