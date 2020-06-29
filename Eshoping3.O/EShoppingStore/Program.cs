using System;
using System.Collections.Generic;
using Autofac;

namespace EShoppingStore
{
    public class Program
   {    
           
       public static void Main(string[] args)
        {  
            
            var ContainerBuilder = new ContainerBuilder();
            ContainerBuilder.RegisterModule<ModuleBuilder>();
            var container = ContainerBuilder.Build();
            var AuthenticationHandler = container.Resolve<IAuthenticationHandler>();
            var CartHandler= container.Resolve<ICartHandler>();
            var CourierServiceHandler = container.Resolve<ICourierServiceHandler>();
            var CustomerHandler = container.Resolve<ICustomerHandler>();
            var MarketingHandler = container.Resolve<IMarketingPersonHandler>();
            var ProductHandler = container.Resolve<IProductHandler>();
            var SalesPersonHandler = container.Resolve<ISalesPersonHandler>();
            var Ecommerce = container.Resolve<ECommerce>();
            ECommerce _Ecommerce = new ECommerce();
            _Ecommerce.MainMenu();
        
                    
        }
    }
}
