using System;

namespace CreditCard
{ //Product
    abstract class CreditCard  
    {  
        public abstract string CardType { get; }  
        public abstract int CreditLimit { get; set; }  
        public abstract int AnnualCharge { get; set; }  
    }    
    
    //concrete product platinum card
    class PlatinumCreditCard : CreditCard  
    {  
        private readonly string _cardType;  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public PlatinumCreditCard(int creditLimit, int annualCharge)  
        {  
            _cardType = "Platinum";  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override string CardType  
        {  
            get { return _cardType; }  
        }  
  
        public override int CreditLimit  
        {  
            get { return _creditLimit; }  
            set { _creditLimit = value; }  
        }  
  
        public override int AnnualCharge  
        {  
            get { return _annualCharge; }  
            set { _annualCharge = value; }  
        }  
    }
   //concrete product titanium
   class TitaniumCreditCard : CreditCard  
    {  
        private readonly string _cardType;  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public TitaniumCreditCard(int creditLimit, int annualCharge)  
        {  
            _cardType = "Titanium";  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override string CardType  
        {  
            get { return _cardType; }  
        }  
  
        public override int CreditLimit  
        {  
            get { return _creditLimit; }  
            set { _creditLimit = value; }  
        }  
  
        public override int AnnualCharge  
        {  
            get { return _annualCharge; }  
            set { _annualCharge = value; }  
        }      
    }  
   //creator
   abstract class CardFactory  
    {  
        public abstract CreditCard GetCreditCard();  
    }  
   //concrete creator moneyBack
   class Platinum: CardFactory  
    {  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public Platinum(int creditLimit, int annualCharge)  
        {  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override CreditCard GetCreditCard()  
        {  
            return new PlatinumCreditCard(_creditLimit, _annualCharge);  
        }  
    }  
   //concrete creator titanium
   class Titanium: CardFactory      
    {      
        private int _creditLimit;      
        private int _annualCharge;      
      
        public Titanium(int creditLimit, int annualCharge)      
        {      
            _creditLimit = creditLimit;      
            _annualCharge = annualCharge;      
        }      
      
        public override CreditCard GetCreditCard()      
        {      
            return new TitaniumCreditCard(_creditLimit, _annualCharge);      
        }      
    }     
  //driver function
  public class Client  
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
