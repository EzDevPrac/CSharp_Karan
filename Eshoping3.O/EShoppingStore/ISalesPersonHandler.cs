using System.Collections.Generic;

namespace EShoppingStore
{
    public interface ISalesPersonHandler
    {
         void CheckOutCustomer(ICourierServiceHandler _Courier);
         int  ShowOrderStatus();
         void ReturnItem(ICourierServiceHandler _Courier);

         void CalculateTotalAmount();
    }
}