﻿using DesignPatterns.Demos;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDemo("Adapter Demo", Adapter.Run);
            RunDemo("Bridge Demo", Bridge.Run);
            RunDemo("Builder Demo", Builder.Run);
            RunDemo("Chain Of Responsibility Demo", ChainOfResponsibility.Run);
            EndDemos();
        }

        private static void RunDemo(string demoTitle, Action demo)
        {
            Console.WriteLine(demoTitle);
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();
            demo();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void EndDemos()
        {
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine("press a key to stop demos");
            Console.ReadLine();
        }
    }
}
