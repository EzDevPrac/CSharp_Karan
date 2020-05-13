using System;
using Autofac;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContainerBuilder = new ContainerBuilder();
            ContainerBuilder.RegisterModule<ModuleBuilder>();
            var container = ContainerBuilder.Build();
            var notificationService = container.Resolve<INotificationService>();
            var UserService = container.Resolve<UserService>();
              
            var user1 = new User("Karan");
            UserService.ChangeUserName(user1,"Karan Kumar");
         }
    }
}
