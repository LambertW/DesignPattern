using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class AoDiBuilder : Builder
    {
        Car aoDiCar = new Car();

        public override void BuildCarDoor()
        {
            aoDiCar.Add("AoDi's Door");
        }

        public override void BuildCarEngine()
        {
            aoDiCar.Add("AoDi's Engine");
        }

        public override void BuildCarWheel()
        {
            aoDiCar.Add("AoDi's Wheel");
        }

        public override Car GetCar()
        {
            return aoDiCar;
        }
    }
}
