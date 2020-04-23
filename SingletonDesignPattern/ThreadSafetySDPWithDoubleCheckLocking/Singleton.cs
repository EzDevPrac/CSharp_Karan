using System;

namespace ThreadSafetySDPWithDoubleCheckLocking
{


   public sealed class Singleton
    {
        private static int NoOfInstances = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {
            NoOfInstances++;
            Console.WriteLine("Instance Created = " + NoOfInstances);
        }
        private static Singleton instance = null;
       
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }


}