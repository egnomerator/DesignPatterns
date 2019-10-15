using DesignPatterns.Implementations.Flyweight;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Demos
{
    public class Flyweight
    {
        public static void Run()
        {
            const int limit = 10000;

            Console.WriteLine($"ADDING {limit:N0} RANDOM ONE'S AND TWO'S ...");
            Console.WriteLine("(2 overly-complex, bad approaches to a simple problem, just to demonstrate the pattern)");
            Console.WriteLine();
            Console.WriteLine("1st approach: create a new object for each random 1 or 2 that is added");
            Console.WriteLine();

            var rnd = new Random();
            var ones = new List<Addend>();
            var twos = new List<Addend>();
            var result = 0;

            for (var i = 0; i < limit; i++)
            {
                var next = new Addend(rnd);
                next.SetValue();
                result = next.Add(result);

                if (next.AddendValue == 1) ones.Add(next);
                if (next.AddendValue == 2) twos.Add(next);
                PrintProgress(result, i + 1, limit, ones.Count, twos.Count, Addend.InstanceCount);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2nd approach: use flyweight pattern to reduce number of instances created");
            Console.WriteLine();
            var fwOnes = new List<IFlyweightAddend>();
            var fwTwos = new List<IFlyweightAddend>();
            var addendFactory = new FlyweightAddendFactory();
            result = 0;

            for (var i = 0; i < limit; i++)
            {
                var addendValue = rnd.Next(1, 3);
                var next = addendFactory.GetAddend(addendValue);
                result = next.Add(result);

                if (addendValue == 1) fwOnes.Add(next);
                if (addendValue == 2) fwTwos.Add(next);
                PrintProgress(result, i + 1, limit, fwOnes.Count, fwTwos.Count, FlyweightAddend.InstanceCount);
            }
        }

        private static void PrintProgress(int sum, int iterations, int limit, int ones, int twos, int instances)
        {
            const string P = " | ";
            var limitStr = $"{limit:N0}";
            var sumStr = GetDisplayValue(sum, limitStr.Length);
            var itrStr = $"{GetDisplayValue(iterations, limitStr.Length)}/{limitStr}";
            var onesStr = GetDisplayValue(ones, limitStr.Length);
            var twosStr = GetDisplayValue(twos, limitStr.Length);
            var instCountStr = GetDisplayValue(instances, limitStr.Length);
            Console.Write($"\rIteration {itrStr}{P}Addends Added - ONE'S: {onesStr} TWO'S: {twosStr}{P}Sum = {sumStr}{P}Instances Created {instCountStr}");
        }

        private static string GetDisplayValue(int val, int maxLength)
        {
            var valStr = $"{val:N0}";
            var padding = new string(' ', maxLength - valStr.Length);
            return string.Concat(padding, valStr);
        }
    }
}
