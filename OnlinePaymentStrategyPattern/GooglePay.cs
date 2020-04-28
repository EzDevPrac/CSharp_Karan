using System;

namespace OnlinePaymentStrategyPattern
{ //Conrete strategy GooglePay
    public class GooglePay : OnlinePayment
    {
        public override string MakePayment(string CustomerName, double Amount){
         double PayableAmmount = 0;
         PayableAmmount = (5 * Amount)/100;//5% tax for the online payment 
         PayableAmmount = Amount + PayableAmmount;

         return CustomerName + " , your  final payable amount is " + PayableAmmount ;

        }
        
    }
}
