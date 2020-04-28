using System;

namespace OnlinePaymentStrategyPattern
{ //Conrete Strategy paytm
    public class PayTm : OnlinePayment
    {
        public override string MakePayment(string CustomerName, double Amount){
         double PayableAmmount = 0;
         PayableAmmount = (4 * Amount)/100;//4% tax for the online payment 
         PayableAmmount = Amount + PayableAmmount;

         return CustomerName + " , your  final payable amount is " + PayableAmmount ;

        }
       
    }
}
