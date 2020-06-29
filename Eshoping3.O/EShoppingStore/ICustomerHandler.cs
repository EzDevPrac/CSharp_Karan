using System.Collections.Generic;

namespace EShoppingStore
{
    public interface ICustomerHandler
    {
         void CreateAccount();
         void UpdateCustomerInformation(Customer _Customer);
         void CustomerCheckout(ISalesPersonHandler SalesStaff,ICourierServiceHandler _Courier);
    }
}