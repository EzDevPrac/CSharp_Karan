using System.Text.RegularExpressions;
using System.Collections.Generic;
using EShoppingWebApi.Models;
 
namespace EShoppingWebApi.Validation.CustomerDataValidation
{
    public class CustomerInformationValidation : ICustomerInformationValidation
    {  //return -1 for Empty Input
       //return 1 for valid Input
       //return 0 for Invalid input
        string match;
         public int ValidateName(string name){
          
          match = @"^[a-zA-z\s]+$";

          if(name == null)
            return -1;
          if(Regex.IsMatch(name,match))
           { return 1;}
        return 0;  
              
        }
        public  int ValidateMobileNumber(string mobileNumber){
           match = @"^\d{10}$";

           if(mobileNumber == null)
            return -1;
           if(Regex.IsMatch(mobileNumber,match))
           { return 1;} 
        return 0;
        }
        public int ValidateAccountNumber(string accountNumber){
           match = @"^[1-9]{1}[0-9]{3}-[0-9]{4}-[0-9]{4}-[0-9]{4}$";
           if(accountNumber == " ")
            return -1;
           if(Regex.IsMatch(accountNumber,match)) 
            return 1;
        return 0;
        }
        public  int ValidateEmailId(string mailId){
          match = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                
          if(mailId == " ")
           return -1;
          if(Regex.IsMatch(mailId,match,RegexOptions.IgnoreCase))
           return 1;
        return 0;          

        }

        public int CheckExistingCustomer(List<Customer> data){

         return 0;
        }
    }
}