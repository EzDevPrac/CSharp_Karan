using System.ComponentModel.DataAnnotations;

namespace EShoppingWebApi.Models
{
    public class Customer
    {
        private string customerName;
        private string customerMobileNumber;
        private string customerEmailId;
        private string customerAddress;
        private string password;
        private string customerAccountNumber;
        public Customer()
        {
        }
        [Required(ErrorMessage = "Customer name Cannot be Empty ")]
        public string CustomerName { get => customerName; set => customerName = value; }
        
        [Required(ErrorMessage = "Customer Mobile Number be Empty ")]
        [StringLength(10,ErrorMessage = "Mobile number should of length 10 ")]
        public string CustomerMobileNumber { get => customerMobileNumber; set => customerMobileNumber = value; }
        
        
        [Required(ErrorMessage = "Customer Email Cannot be Empty ")]
        public string CustomerEmailId { get => customerEmailId; set => customerEmailId = value; }
        
        
        [Required(ErrorMessage = "Customer Address Cannot be Empty ")]
        [StringLength(200)]
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get => password; set => password = value; }

        [Required(ErrorMessage = "Card Number Cannot be Empty")]
        public string CustomerAccountNumber { get => customerAccountNumber; set => customerAccountNumber = value; }
    }
        
}