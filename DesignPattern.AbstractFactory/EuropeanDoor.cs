using System;

namespace DesignPattern.AbstractFactory
{
    internal class EuropeanDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的门");
        }
    }
}