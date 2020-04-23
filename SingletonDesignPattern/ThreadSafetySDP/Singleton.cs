using System;

namespace ThreadSafetySDP
{
     public sealed class Singleton
    {
        private static int NoOfInstance = 0;     
        private static Singleton instance = null;  
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }  
        private Singleton()
        {
            NoOfInstance++;
            Console.WriteLine("Instance Created = " + NoOfInstance);
        }    
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
