using System;

namespace ProxyDesignPattern
{
    public class Atm 
    {

        private Bank user = new Bank();

        public  void checkAccount(){

           Console.WriteLine("Enter the Account Number");
           string accNumber= Console.ReadLine();
           Console.WriteLine("Enter the Account Holder Name");
           string accHolderName = Console.ReadLine();
           Console.WriteLine("Enter the Pin  number");
           string pin = Console.ReadLine();

           if(accNumber == "KK1234" && accHolderName == "Karan Kumar" && pin == "1429")
           {
               user.MakeTransaction();
           }
           else{
               Console.WriteLine("Credentials Are wrong");
           }
        }
    }
    
}
