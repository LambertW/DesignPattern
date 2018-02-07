using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder buickCarBuilder = new BuickBuilder();
            Builder aoDiBuilder = new AoDiBuilder();

            director.Construct(buickCarBuilder);

            Car buickCar = buickCarBuilder.GetCar();
            buickCar.Show();

            director.Construct(aoDiBuilder);
            Car aoDiCar = aoDiBuilder.GetCar();
            aoDiCar.Show();

            Console.Read();
        }
    }
}
