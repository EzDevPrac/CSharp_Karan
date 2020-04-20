using System;

namespace SystemConfigFacade
{
    class Client
    {
        static void Main(string[] args)
        {
            SystemCreationFacade SystemCreated =new SystemCreationFacade();
            SystemCreated.SystemCreation();
        }
    }
}
