using System;

namespace DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            //订单
            Order order = new Order();
            order.Minute = 9;
            order.Action();
            //可以取消订单
            order.IsCancel = true;
            order.Minute = 20;
            order.Action();
            order.Minute = 33;
            order.Action();
            order.Minute = 43;
            order.Action();

            Console.Read();
        }
    }
}
