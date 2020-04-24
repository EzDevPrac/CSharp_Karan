using System;

namespace NoThreadSafeSDP
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            Singleton MessageFromKaran = Singleton.GetInstance;
            Console.WriteLine(MessageFromKaran.PrintMessage("Karan says Hii"));
            Singleton MessageFromSerena = Singleton.GetInstance;
            Console.WriteLine(MessageFromSerena.PrintMessage("Serena Says bye !!"));
            Console.ReadLine();
        }
    }
}
