namespace EShoppingWebApi.Models
{
    public class Customer
    {
        private string customerName;
        private string customerMobileNumber;
        private string customerEmailId;
        private string customerAddress;

        public Customer()
        {
          customerName = "Karan";
          customerMobileNumber = "12345";
          customerEmailId = "@hash.com";
          customerAddress = "Tamil Nadu";
          

        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerMobileNumber { get => customerMobileNumber; set => customerMobileNumber = value; }
        public string CustomerEmailId { get => customerEmailId; set => customerEmailId = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
    }
}