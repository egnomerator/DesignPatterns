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
                knightFactory.CreateFighter(),
                archerFactory.CreateFighter()
            };
            var commander = new Commander(army);
            commander.LaunchAttack();

            Console.WriteLine();
            Console.WriteLine("*ABSTRACT FACTORY*");
            Console.WriteLine();

            var humanBarracks = new HumanBarracks();
            var orcBarracks = new OrcBarracks();
            var humanArmy = new List<IFighter>
            {
                humanBarracks.TrainMelee(),
                humanBarracks.TrainRanged()
            };
            var orcArmy = new List<IFighter>
            {
                orcBarracks.TrainMelee(),
                orcBarracks.TrainRanged()
            };
            var humanCommander = new Commander(humanArmy);
            var orcCommander = new Commander(orcArmy);
            humanCommander.LaunchAttack();
            orcCommander.LaunchAttack();
        }

        private class Commander
        {
            private readonly List<IFighter> _army;

            public Commander(List<IFighter> army)
            {
                _army = army;
            }

            public void LaunchAttack()
            {
                _army.ForEach(f => f.Attack());
            }
        }
    }
}
