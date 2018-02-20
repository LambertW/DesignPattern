using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public sealed class WaitForAcceptance : IState
    {
        public void Process(Order order)
        {
            Console.WriteLine("我们开始受理，准备备货！");
            if (order.Minute < 30 && order.IsCancel)
            {
                Console.WriteLine("接受半个小时之内，可以取消订单！");
                order.SetState(new CancelOrder());
                order.Action();
            }
            order.SetState(new AcceptAndDeliver());
            order.TaskFinished = false;
            order.Action();
        }
    }
}
