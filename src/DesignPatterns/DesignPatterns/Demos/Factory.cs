using DesignPatterns.Implementations.Factory;
using DesignPatterns.Implementations.Factory.Abstract;
using DesignPatterns.Implementations.Factory.Method;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Demos
{
    public class Factory
    {
        public static void Run()
        {
            Console.WriteLine("*FACTORY METHOD*");
            Console.WriteLine();

            var knightFactory = new KnightFactory();
            var archerFactory = new ArcherFactory();
            var army = new List<IFighter>
            {
                GetFighter(knightFactory),
                GetFighter(archerFactory)
            };
            army.ForEach(f => f.Attack());

            Console.WriteLine();
            Console.WriteLine("*ABSTRACT FACTORY*");
            Console.WriteLine();

            var humanBarracks = new HumanBarracks();
            var orcBarracks = new OrcBarracks();
            var humanCommander = new Commander(humanBarracks);
            var orcCommander = new Commander(orcBarracks);

            humanCommander.RecruitArmy();
            orcCommander.RecruitArmy();
            humanCommander.LaunchAttack();
            orcCommander.LaunchAttack();
        }

        private static IFighter GetFighter(FighterFactory fighterFactory)
        {
            return fighterFactory.CreateFighter();
        }
    }
}
