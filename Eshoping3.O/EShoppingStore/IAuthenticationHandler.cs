using System.Collections.Generic;
namespace EShoppingStore
{
    public interface IAuthenticationHandler
    {
         int  CustomerLogin(ICustomerHandler _Customer);
         int EmployeeLogin(MarketingPerson _MarketingPerson);
    }
}