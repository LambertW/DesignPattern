using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    //交易成功---相当于具体状态角色
    public sealed class Success : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("订单结算");
            order.TaskFinished = true;
        }
    }
}
