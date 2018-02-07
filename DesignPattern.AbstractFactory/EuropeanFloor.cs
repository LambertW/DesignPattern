using System;

namespace DesignPattern.AbstractFactory
{
    internal class EuropeanFloor : Floor
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的地板");
        }
    }
}