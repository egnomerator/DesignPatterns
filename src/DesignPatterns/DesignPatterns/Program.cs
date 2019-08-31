using DesignPatterns.PatternDemos;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Demo");
            Console.WriteLine("____________________");
            Console.WriteLine();
            AdapterDemo.Run();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bridge Demo");
            Console.WriteLine("____________________");
            Console.WriteLine();
            BridgeDemo.Run();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Builder Demo");
            Console.WriteLine("____________________");
            Console.WriteLine();
            BuilderDemo.Run();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press a key to stop demos");
            Console.ReadLine();
        }
    }
}
