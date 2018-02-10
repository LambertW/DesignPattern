using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public abstract class DecorationStrategy : House
    {
        protected House _house;

        public DecorationStrategy(House house)
        {
            _house = house;
        }

        public override void Renovation()
        {
            if(_house != null)
            {
                _house.Renovation();
            }
        }
    }
}
