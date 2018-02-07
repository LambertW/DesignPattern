using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class EuropeanFactory : AbstractFactory
    {
        public override Door CreateDoor()
        {
            return new EuropeanDoor();
        }

        public override Floor CreateFloor()
        {
            return new EuropeanFloor();
        }

        public override Roof CreateRoof()
        {
            return new EuropeanRoof();
        }

        public override Window CreateWindow()
        {
            return new EuropeanWindow();
        }
    }
}
