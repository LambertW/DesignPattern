using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class HongQiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("红旗汽车行驶");
        }
    }
}
