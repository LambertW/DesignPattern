using System;

namespace DesignPattern.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseRequest requestDao = new PurchaseRequest(8000, "单刀5把");
            PurchaseRequest requestHuaJi = new PurchaseRequest(10000, "10把方天画戟");
            PurchaseRequest requestJian = new PurchaseRequest(80000, "5把金丝龙鳞闪电劈");

            Approver manager = new Manager("黄飞鸿");
            Approver financial = new FinancialManager("黄麒英");
            Approver ceo = new CEO("十三姨");

            // 设置职责链
            manager.NextApprover = financial;
            financial.NextApprover = ceo;

            // 处理请求
            manager.ProcessRequest(requestDao);
            manager.ProcessRequest(requestHuaJi);
            manager.ProcessRequest(requestJian);

            Console.ReadLine();
        }
    }
}
