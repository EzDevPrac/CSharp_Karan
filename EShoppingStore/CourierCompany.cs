using System;

namespace EShoppingStore
{
    public class CourierCompany
    {
        public void Packaging(string PackingType){
            
            Console.WriteLine("Your Delivery Has been " + PackingType + "Wrapped");


        }

        public void Deliver(string _Address){

            Console.WriteLine("the Delivery Will be Made by the Courier Company To the Following address");
            Console.WriteLine("Address" + _Address);
        }

        public void returnPickup(double Cost){

            Console.WriteLine("Item will be Picked up within 2 days");
            Console.WriteLine("Ammount of " + Cost + " Will be refunded to the customer Account");
        }
    }
}