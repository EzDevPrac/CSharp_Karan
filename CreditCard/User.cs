using System;

namespace CreditCard
{ 

//driver function
  public class User  
    {  
   public  static void Main()  
        {  
            CardFactory factory = null;  
            Console.Write("Enter the card type ->");  
            string car = Console.ReadLine();  
  
            switch (car.ToLower())  
            {  
                case "platinum":  
                    factory = new Platinum(20000,0);  
                    break;  
                case "titanium":  
                    factory = new Titanium(200000, 500);  
                    break;  
                default:  
                    break;  
            }  
  
            CreditCard creditCard = factory.GetCreditCard();  
            Console.WriteLine("\nYour card details are below : \n");  
            Console.WriteLine("Card Type -> {0}\nCredit Limit -> {1}\nAnnual Charge ->{2}",  
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);  
             
        }  
    }  

}
