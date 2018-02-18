using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public sealed class BeiJingDepositor : Depositor
    {
        public BeiJingDepositor(string name, int total) : base(name, total)
        {
        }

        public override void Update(int currentBalance, DateTime dateTime)
        {
            Console.WriteLine(
                Name
                + ":账户发生了变化，变化时间是"
                + dateTime.ToString()
                + ",当前余额是"
                + currentBalance.ToString());
        }
    }
}
