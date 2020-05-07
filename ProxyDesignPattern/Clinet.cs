using System;

namespace ProxyDesignPattern
{
    public class Client
    {
        static void Main(string[] args)
        {  
            Atm user = new Atm();
            Console.WriteLine("--------Welcome to KK Atm -------------");
            user.checkAccount();
            
        }
    }
}
