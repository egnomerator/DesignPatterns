using DesignPatterns.Demos;
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
            Adapter.Run();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bridge Demo");
            Console.WriteLine("____________________");
            Console.WriteLine();
            Bridge.Run();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Builder Demo");
            Console.WriteLine("____________________");
            Console.WriteLine();
            Builder.Run();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("________________________________________");
            Console.WriteLine("press a key to stop demos");
            Console.ReadLine();
        }
    }
}
