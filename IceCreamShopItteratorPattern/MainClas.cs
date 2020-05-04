using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShopItteratorPattern
{
    class MainClass
    {
        static void Main(string[] args)
{
    // Build a collection of Different flavous of IceCreams
    
    IceCreamCollection collection = new IceCreamCollection();
    collection[0] = new IceCream("Strawberry");
    collection[1] = new IceCream("Chocolate");
    collection[2] = new IceCream("Black Current");
    collection[3] = new IceCream("Vanilla");
    collection[4] = new IceCream("Butter Scotch");
    collection[5] = new IceCream("Badam");
    collection[6] = new IceCream("Grapes");


    // Create iterator
    IceCreams iterator = collection.CreateIterator();

    Console.WriteLine("All The Flavours Available Are:");

    for (IceCream item = iterator.First();
        !iterator.IsDone; item = iterator.Next())
    {
        Console.WriteLine(item.Flavor);
    }

    Console.ReadKey();
}
    }
}
