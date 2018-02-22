using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    public sealed class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine("{0} 部门经理批准了对原材料{1}的采购计划！", this.Name, request.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
