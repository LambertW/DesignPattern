using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    public sealed class CEO : Approver
    {
        public CEO(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount > 50000 && request.Amount < 300000)
            {
                Console.WriteLine("{0} 总裁批准了对原材料 {1} 的采购计划！", this.Name, request.ProductName);
            }
            else
                Console.WriteLine("这个采购计划的金额比较大，需要一次董事会会议讨论才能决定！");
        }
    }
}
