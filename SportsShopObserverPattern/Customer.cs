using System;

namespace SportsShopObserverPattern
{
 /// The 'ConcreteObserver' class
public class Customer : ICustomer

  {
    private string _CustomerName;
    private SportShop _sportShop;
    // Constructor
    public Customer(string CustomerName)
    {
      this._CustomerName = CustomerName;
      
    }
    public void Update(SportShop sportShop)
    {
      Console.WriteLine("Notified the customer Name :  " + _CustomerName + "\nItem Available : " + sportShop.ItemName + "\nCost : " + sportShop.ItemCost);
    }
 
    // Gets or sets the SportsShop
    public SportShop sportShop
    {
      get { return _sportShop; }
      set { _sportShop = value; }
    }
  }
}
    

