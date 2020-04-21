using System;

namespace SystemConfigFacade
{
    public class Client
    {
        public static void Main(string[] args)
        {
            SystemCreationFacade SystemCreated =new SystemCreationFacade();
            SystemCreated.SystemCreation();
            SystemCreated.SystemDisplay();
        }
    }
}
