using System;

namespace CreditCard{

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



}