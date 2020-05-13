using System;
using Autofac;

namespace DependencyInjection
{
    public class ModuleBuilder : Module
    {
       protected override void Load(ContainerBuilder builder)
       {
        builder.RegisterType<ConsoleNotification>().As<INotificationService>();
        builder.RegisterType<UserService>().AsSelf();
       }

    }


}
