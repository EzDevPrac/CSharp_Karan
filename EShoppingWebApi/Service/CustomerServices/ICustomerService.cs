using EShoppingWebApi.Models;

namespace EShoppingWebApi.Service.CustomerServices
{
    public interface ICustomerService
    {

        void ExistingCustomer();
        Customer Authenticate(string username, string password);
        //IEnumerable<User> GetAll();
        //Customer GetById(int id);
        //Customer Create(Customer customer, string password);
        //void Update(Customer customer, string password = null);
       // void Delete(int id);
    }
}