using System;

namespace DesignPattern.Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass fan = new ConcreteClass();
            fan.EatDumplings();

            Console.WriteLine();

            fan = new ConcreteClass2();
            fan.EatDumplings();

            Console.Read();
        }
    }
}
