using System;

namespace DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemFacade facade = new SystemFacade();
            facade.Buy();

            Console.Read();
        }
    }
}
