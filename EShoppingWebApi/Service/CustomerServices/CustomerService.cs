using EShoppingWebApi.Models;
using System.Collections.Generic;


namespace EShoppingWebApi.Service.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> CustomerList =new List<Customer>();
        public static List<CustomerAuthenticationData> AuthenticationDataList = new List<CustomerAuthenticationData>();
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
                        if(customer.CustomerName == name && customer.Password == Password)
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

            AuthenticationDataList.Add(new CustomerAuthenticationData(){UserName = customer.CustomerName,Password =customer.Password});
            CustomerList.Add(customer);
        }

        public int Delete(CustomerAuthenticationData userData){
         
         
          foreach (var data in AuthenticationDataList)
          {
              if(data.UserName == userData.UserName && data.Password == userData.Password)
                {
                   foreach(var Customer in CustomerList)
                   {
                     if(Customer.CustomerName == userData.UserName && Customer.Password == userData.Password)
                     { 
                       CustomerList.Remove(Customer);
                       AuthenticationDataList.Remove(data);
                       return 1;
                     } 
                   }
                }
              
          }
         return 0;
        }


        }
}