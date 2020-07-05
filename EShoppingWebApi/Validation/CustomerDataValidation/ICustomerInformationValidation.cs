using System.Collections.Generic;
using EShoppingWebApi.Models;

namespace EShoppingWebApi.Validation.CustomerDataValidation
{
    public interface ICustomerInformationValidation
    {
         int ValidateName(string name);
         int ValidateMobileNumber(string mobileNumber);
         int ValidateAccountNumber(string accountNumber);
         int ValidateEmailId(string mailId);

         int CheckExistingCustomer(List<Customer> data);
    }
}