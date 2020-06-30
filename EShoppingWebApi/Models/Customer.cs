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
          customerMobileNumber = "41432w235";
          customerEmailId = "@hash.com";
          customerAddress = "Jharkand";

        }

        /*public Customer(string customerName,string customerMobileNumber,string customerEmailId,string customerAddress)
        {
          this.CustomerName = customerName;
          this.customerMobileNumber = customerMobileNumber;
          this.customerEmailId = customerEmailId;
          this.customerAddress = customerAddress;

        }*/

        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerMobileNumber { get => customerMobileNumber; set => customerMobileNumber = value; }
        public string CustomerEmailId { get => customerEmailId; set => customerEmailId = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
    }
}