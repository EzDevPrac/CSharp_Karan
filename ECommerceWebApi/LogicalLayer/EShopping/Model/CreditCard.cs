namespace EShopping.Model
{
    public class CreditCard
    {
        private int CardNumber;
        private string CardHolderName;

        public CreditCard(int cardNumber, string cardHolderName)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            
        }

        public int _CardNumber { get => CardNumber; set => CardNumber = value; }
        public string _CardHolderName { get => CardHolderName; set => CardHolderName = value; }

 
    }
}