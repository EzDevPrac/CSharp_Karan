using EShoppingWebApi.Models;
using System.Collections.Generic;
using System;
namespace EShoppingWebApi.Service.CustomerServices
{
    public interface ICustomerService
    {

        
        Guid Authenticate(string username, string password);
        List<Customer> GetCustomer();

        void AddCustomer(Customer customer);
        
        int Delete(CustomerAuthenticationData userData);
        
    }
}