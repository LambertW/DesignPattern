using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public sealed class ConfirmationReceipt : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，没问题可以就可以签收！");
            order.SetState(new Success());
            order.TaskFinished = false;
            order.Action();
        }
    }
}
