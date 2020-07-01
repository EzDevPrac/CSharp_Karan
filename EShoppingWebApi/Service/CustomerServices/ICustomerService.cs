using EShoppingWebApi.Models;
using System.Collections.Generic;

namespace EShoppingWebApi.Service.CustomerServices
{
    public interface ICustomerService
    {

        
        Customer Authenticate(string username, string password);
        List<Customer> GetCustomer();

        void AddCustomer(Customer customer);
        
    }
}