using System.Collections.Generic;

namespace DesignPatterns.Implementations.Factory.Abstract
{
    public class Commander
    {
        private readonly Barracks _barracks;
        private readonly List<IFighter> _army;

        public Commander(Barracks barracks)
        {
            _barracks = barracks;
            _army = new List<IFighter>();
        }

        public void RecruitArmy()
        {
            _army.Add(_barracks.TrainMelee());
            _army.Add(_barracks.TrainRanged());
        }

        public void LaunchAttack()
        {
            _army.ForEach(f => f.Attack());
        }
    }
}
