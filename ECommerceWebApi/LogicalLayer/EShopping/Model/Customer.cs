
namespace EShopping.Model
{
    public class Customer : Person
    {
        private CreditCard creditCard;
        
        
      
        public Customer(){}
        public Customer(string name,string mobileNumber,string email,string Adress,CreditCard creditCard)
        {     
              this._Name = name;
              this._PhoneNumber = mobileNumber;
              this._Email = email;
              this._Address = Adress;
              this.creditCard = creditCard;
              
        }

        public CreditCard _CreditCard { get => _CreditCard; set => _CreditCard = value; }
        
    }
}