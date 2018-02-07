using System;

namespace DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory europeanFactory = new EuropeanFactory();
            europeanFactory.CreateRoof().Create();
            europeanFactory.CreateFloor().Create();
            europeanFactory.CreateDoor().Create();
            europeanFactory.CreateWindow().Create();


            Console.ReadKey();
        }
    }
}
