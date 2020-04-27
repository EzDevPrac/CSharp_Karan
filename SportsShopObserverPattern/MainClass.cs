using System;

namespace SportsShopObserverPattern
{
    class MainClass
    {
        static void Main(string[] args)
        {
         CricketItems bat = new CricketItems("Bat",1500);
         
         Console.WriteLine("Enter the customer Name");
         String name = Console.ReadLine();

         Console.WriteLine("Enter the Item in the Shop");
         String ItemName = Console.ReadLine();
         Console.WriteLine("Enter the cost of the item");
         int Cost = Convert.ToInt16(Console.ReadLine());
         
         bat.ItemName = ItemName;
         bat.ItemCost = Cost; 
         
         bat.MakeSubscription(new Customer(name));

       }
    }
}
