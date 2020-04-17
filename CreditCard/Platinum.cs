using System;

namespace CreditCard{

//concrete creator platinum
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
   

    
}