using System;

namespace DependencyInjection
{
    public class ConsoleNotification : INotificationService
    {

     public void NotifyUserChange(string NewUser)
     {
         Console.WriteLine("User Name has been changed to  " + NewUser);

     }   
    }
}
