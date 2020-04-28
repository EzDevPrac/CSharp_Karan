using System;

namespace OnlinePaymentStrategyPattern
{  //Strategy
    public abstract class OnlinePayment
    {
    public abstract string MakePayment(String CustomerName,double Amount);
    
    }
}
