using System;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 仅支持单线程
            var instance = Singleton.GetInstance();

            // 多线程，有额外的开销
            var instance1 = Singleton1.GetInstance();

            // Double check
            var instance2 = Singleton2.GetInstance();

        }
    }
}
