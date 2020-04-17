using System;

namespace CreditCard
{ //Product
    abstract public class CreditCard  
    {  
        public abstract string CardType { get; }  
        public abstract int CreditLimit { get; set; }  
        public abstract int AnnualCharge { get; set; }  
    }    
}