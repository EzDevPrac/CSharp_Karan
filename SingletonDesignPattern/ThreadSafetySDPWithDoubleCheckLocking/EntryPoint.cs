using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafetySDPWithDoubleCheckLocking
{
    class EntryPoint

    {
       public static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintKaranMessage(),
                () => PrintSerenaMessage()
                );
            Console.ReadLine();
        }
        private static void PrintKaranMessage()
        {
            Singleton fromKaran = Singleton.GetInstance;
            fromKaran.PrintMessage("Karan says Hii");
        }
        private static void PrintSerenaMessage()
        {
            Singleton fromSerena = Singleton.GetInstance;
            fromSerena.PrintMessage("Serena says Bye!!");
        }
    }
}
