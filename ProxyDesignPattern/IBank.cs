using System;

namespace ProxyDesignPattern
{
    public interface IBank
    {
        string AccountNumber{get;set;}
        string AccountHolderName{get;set;}

        string AccountPin{get;}
        int MoneyAvailable{get;set;}
        void MakeTransaction();
        void CheckBalance();

    }
}
