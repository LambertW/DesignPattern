using System;

namespace DesignPattern.AbstractFactory
{
    internal class EuropeanRoof : Roof
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的屋顶");
        }
    }
}