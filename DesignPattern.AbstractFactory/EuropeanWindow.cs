using System;

namespace DesignPattern.AbstractFactory
{
    internal class EuropeanWindow : Window
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的窗户");
        }
    }
}