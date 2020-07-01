using EShoppingWebApi.Models;
using System.Collections.Generic;


namespace EShoppingWebApi.Service.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> CustomerList =new List<Customer>();
        
        public CustomerService()
        {
          CustomerList.Add(new Customer());

        }
        public Customer Authenticate(string name,string Password)
        {
              if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Password))
                return null;

              else
              {
                foreach(var customer in CustomerList)
                  {
                        if(customer.CustomerName == name && customer.CustomerMobileNumber == Password)
                          {

                              return customer;
                          }

                  }

              }

              return null;  

        }

        public List<Customer> GetCustomer(){

            return CustomerList;
        }

        public void AddCustomer(Customer customer){
            CustomerList.Add(customer);
        }
        }
}