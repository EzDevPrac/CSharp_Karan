using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafetySDP
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintKaranMessage(),
                () => PrintSerenaMessage()
                );
            Console.ReadLine();
        }

        private static void PrintKaranMessage()
        {
            Singleton FromKaran = Singleton.GetInstance;
            FromKaran.PrintMessage("Karan says Hiii");
        }

        private static void PrintSerenaMessage()
        {
            Singleton fromSerena= Singleton.GetInstance;
            fromSerena.PrintMessage("Serena Says Bye !!");
        }
    }
}