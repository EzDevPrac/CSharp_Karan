using System;

namespace OnlinePaymentStrategyPattern
{
    class PaymentMethod
    {   //Context
        private String CustomerName;
        private double Ammount;
        OnlinePayment _OnlinePayment;
        public void SetOnlinePayment(OnlinePayment onlinePayment)
        {
           this._OnlinePayment = onlinePayment;}
        public String SetCustomerName(string _CustomerName)
        {
                CustomerName = _CustomerName;
                return CustomerName;}
        public double SetAmount(double _Ammount)
        {
            Ammount = _Ammount;
            return Ammount;}
        public void Pay()
        {
            Console.WriteLine(_OnlinePayment.MakePayment(CustomerName,Ammount));
            Console.WriteLine("Do you Want to Pay(Y/N) ??");
            char option = Convert.ToChar(Console.ReadLine());
            if(option == 'Y'|| option == 'y')
            {
                Console.WriteLine("Payement under process.................");
                Console.WriteLine();
                Console.WriteLine("Payement Successfull .............:)");
            }
            else if ( option == 'N' || option == 'n'){
                Console.WriteLine("Transaction Cancelled...");
            }
            else{
                Console.WriteLine("Not a Valid Option.");
            }

        }
    }
}
