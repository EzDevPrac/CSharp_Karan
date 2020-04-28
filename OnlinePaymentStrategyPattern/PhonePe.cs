using System;

namespace OnlinePaymentStrategyPattern
{ //Concrete strategy PhonePe
    public class PhonePe : OnlinePayment
    {
        
        public override string MakePayment(string CustomerName, double Amount){
         double PayableAmmount = 0;
         PayableAmmount = (2 * Amount)/100;//2% tax for the online payment 
         PayableAmmount = Amount + PayableAmmount;

         return CustomerName + " , your  final payable amount is " + PayableAmmount ;

        }
    }
}
