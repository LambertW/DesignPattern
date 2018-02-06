using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class AodiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("奥迪汽车行驶");
        }
    }
}
