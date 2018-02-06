using System;

namespace DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory hongQiFactory = new HongQiCarFactory();
            Factory aoDiFactory = new AoDiCarFactory();

            Car hongQi = hongQiFactory.CreateCar();
            hongQi.Go();

            Car aoDi = aoDiFactory.CreateCar();
            aoDi.Go();

            Console.Read();
        }
    }
}
