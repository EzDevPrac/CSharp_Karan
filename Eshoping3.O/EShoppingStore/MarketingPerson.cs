namespace EShoppingStore
{
    public class MarketingPerson : Person
    {
        public MarketingPerson(){
            _Name = "Karan";
        }
        private int Password;
        public int _Password { get => Password; set => Password = value; }
    }
}