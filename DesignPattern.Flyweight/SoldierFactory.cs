using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public sealed class SoldierFactory
    {
        private static IList<Soldier> _soldiers;

        private Soldier _mySoldier = null;

        static SoldierFactory()
        {
            _soldiers = new List<Soldier>();
        }

        public Soldier GetSoldier(string name, Weapen weapen, SoldierType soldierType)
        {
            foreach (var soldier in _soldiers)
            {
                if(string.Compare(soldier.Name, name, true) == 0)
                {
                    _mySoldier = soldier;
                    return _mySoldier;
                }
            }

            if(soldierType == SoldierType.Normal)
            {
                _mySoldier = new NormalSoldier(name);
            }
            else
            {
                _mySoldier = new WaterSoldier(name);
            }
            _mySoldier.WeapenInstance = weapen;

            _soldiers.Add(_mySoldier);
            return _mySoldier;
        }
    }
}
