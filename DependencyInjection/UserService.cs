using System;

namespace DependencyInjection
{
    public class UserService
    {
       private INotificationService _INotificationService;

       public UserService(INotificationService notifcationService)
       {
           _INotificationService = notifcationService;
       }
        public void ChangeUserName(User OldUserName, string newUserName)
        {
           OldUserName.UserName = newUserName;
           _INotificationService.NotifyUserChange(OldUserName.UserName);

        }
    
        
    }
}
