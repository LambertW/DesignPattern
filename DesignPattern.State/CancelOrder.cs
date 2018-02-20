using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    //取消订单---相当于具体状态角色
    public sealed class CancelOrder : IState
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，有问题，取消订单！");
            order.TaskFinished = true;
        }
    }
}
