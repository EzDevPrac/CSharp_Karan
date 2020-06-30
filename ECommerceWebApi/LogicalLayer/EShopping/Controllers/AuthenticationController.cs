using EShopping.Service;
using EShopping.Model;
namespace EShopping.Controllers
{

    [ApiController]
    [Route("[controller]")]
 
    public class AuthenticationController : Controllers
    {
        ICustomerAuthentication _ICustomerAuthentication;

        AuthenticationController(ICustomerAuthentication ICustomerAuthentication)
        {
            _ICustomerAuthentication = ICustomerAuthentication;
        }

        [HttpPost]  
       public CustomerDetails Post([FromBody]Customer customer)  
    {  _ICustomerAuthentication.CustomerLogin(Customer);  
  
        return new Customer {  = person.Id, Name = person.Name };  
    }  
    }
}