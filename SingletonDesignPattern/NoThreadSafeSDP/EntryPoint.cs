using System;

namespace NoThreadSafeSDP
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            Singleton MessageFromKaran = Singleton.GetInstance;
            MessageFromKaran.PrintMessage("Karan says Hii");
            Singleton MessageFromSerena = Singleton.GetInstance;
            MessageFromSerena.PrintMessage("Serena Says bye !!");
            Console.ReadLine();
        }
    }
}
