using System.ComponentModel.DataAnnotations;
using System;
namespace EShoppingWebApi.Models
{
    public class CustomerAuthenticationData
    {
        
        private string userName;
        private string password;
        
        [Required(ErrorMessage = "User name Cannot be Empty ")]
        public string UserName { get => userName; set => userName = value; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get => password; set => password = value; }
    }
}