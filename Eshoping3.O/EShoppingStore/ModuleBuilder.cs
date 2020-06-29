using Autofac;

namespace EShoppingStore
{
    public class ModuleBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
       {
        builder.RegisterType<ECommerce>().AsSelf();
       // builder.RegisterType<UserService>().AsSelf();
       builder.RegisterType<AuthenticationHandler>().As<IAuthenticationHandler>();
       builder.RegisterType<CartHandler>().As<ICartHandler>();
       builder.RegisterType<CourierServiceHandler>().As<ICourierServiceHandler>();
       builder.RegisterType<CustomerHandler>().As<ICustomerHandler>();
       builder.RegisterType<MarketingPersonHandler>().As<IMarketingPersonHandler>();
       builder.RegisterType<ProductHandler>().As<IProductHandler>();
       builder.RegisterType<SalesPersonHandler>().As<ISalesPersonHandler>(); 

       }

    }
}