using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class HongQiCarFactory : Factory
    {
        public override Car CreateCar()
        {
            return new HongQiCar();
        }
    }
}
