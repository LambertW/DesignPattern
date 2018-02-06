using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class AoDiCarFactory : Factory
    {
        public override Car CreateCar()
        {
            return new AodiCar();
        }
    }
}
