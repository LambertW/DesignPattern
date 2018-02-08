using DesignPattern.Adapter.ClassAdapter;
using DesignPattern.Adapter.ObjectAdapter;
using System;

namespace DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 对象适配器模式
            TwoHoleTarget homeTwoHole = new ObjectAdapter.ThreeToTwoAdapter();
            homeTwoHole.Request();

            // 类适配器模式
            ITwoHoleTarget change = new ClassAdapter.ThreeToTwoAdapter();
            change.Request();

            Console.ReadLine();
        }
    }
}
