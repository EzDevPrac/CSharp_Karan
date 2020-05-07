using System;

namespace ProxyDesignPattern
{
    public class Bank : IBank
    {   string _AccountNumber;
        string _AccountPin;
           
        string _AccountHolderName;

        int  _MoneyAvailable = 0;

        public string AccountNumber{
         get{return _AccountNumber;}
         set{_AccountNumber = value;}

        }

        public string AccountHolderName{
            get{return _AccountHolderName;}
            set{_AccountHolderName = value;}
        }

        public string AccountPin{
            get{return _AccountPin;}
            set{_AccountPin = value;}
        } 
        
        public int MoneyAvailable{
            get{return _MoneyAvailable;}
            set{_MoneyAvailable = value;}
        }
        public void MakeTransaction(){
            int choice = 0;
          do{
          Console.WriteLine("\n1:Withdraw\n2:Deposit\n3:Check Balance\n4:Exit");
          Console.WriteLine("\nEnter your choice:");
          choice = Convert.ToInt16(Console.ReadLine());

          switch(choice){
                
            case 1 : Console.WriteLine("Enter the Withdraw Ammount");
                     int withdraw = Convert.ToInt16(Console.ReadLine());
                     Console.WriteLine(Withdraw(withdraw));
                     break;
            case 2 : Console.WriteLine("Enter the Amount to Deposit");
                     int deposit = Convert.ToInt16(Console.ReadLine());
                     Deposit(deposit);              
                     break;
            case 3 : CheckBalance();
                     break;
                              
            default : Console.WriteLine("Not a valid option\n");
                     break;         
          }
          }
          while(choice<=3); 
        } 

         public void Deposit(int DepositAmmount)
         { 
             Console.WriteLine("Wait for a minute , Ammount being Deposited to your Account ........");
             Console.WriteLine("Transaction successfull\n");
             _MoneyAvailable = _MoneyAvailable + DepositAmmount;
         }

         public string Withdraw(int WithdraMoney)
         {
              if(_MoneyAvailable == 0)
              {
                 return "Your Balance is Zero , You cannot withdraw anything....\n";
              }
              else if (_MoneyAvailable < WithdraMoney)
              {
                  return "You Dont have enough cash to withdraw\n" + " Balance in Your Account = " + _MoneyAvailable;
                  
              }
              else{

                  _MoneyAvailable = _MoneyAvailable - WithdraMoney;
                  return "Balance in Your Account = " + _MoneyAvailable;
              
              }

        }

        public void CheckBalance(){

            Console.WriteLine("Your Account Balance is : " + _MoneyAvailable + " Rs\n");
        }


   }
}
